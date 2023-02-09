using FluentAssertions;
using HadesRefactoring.BuildingBlocks;
using HadesRefactoring.Readers;
using HadesRefactoring.User;
using HadesRefactoring.User.Rules.SemanticRules;
using Moq;

namespace UnitTest.User;

public class Tests
{
    //MethodName_ExpectedBehavior_StateUnderTest


    [Test]
    public void CreateUser_WhenUsernameIsNotUnique_ShouldThrow()
    {
        // setup
        var dummyUsername = "ismailTunaOguzhan";
        var userReader = new Mock<IUserReader>();
        userReader.Setup(r => r.GetByUsername(It.IsAny<string>()))
            .Returns(new HadesRefactoring.User.User(dummyUsername, "asasd"));
        var evaluator = new SemanticUserEvaluator();
        evaluator.SetRules(new List<IRule>() { new EnsureUsernameMustBeUniqueRule(userReader.Object, dummyUsername)});
        // Act
        Action sut = () =>
        {
            evaluator.Execute();
        };
        // Assert
        sut.Should().Throw<DomainException>();
    }
    
    // syntactic test should be separate locations
    [Test]
    public void CreateUser_WhenUsernameIsNull_ShouldThrow()
    {
        // setup
        var dummyUsername = "";
        
        //Act
        Action sut = () =>
        {
            new HadesRefactoring.User.User(dummyUsername, "sadsdf");
        };
        // Assert
        sut.Should().Throw<DomainException>();
    }
    
    // syntactic test should be separate locations
    [Test]
    public void CreateUser_WhenEverythingIsOk_ShouldBeCreated()
    {
        //Act
        var user = new HadesRefactoring.User.User("dummyUsername", "sadsdf");
        // Assert
        user.Username.Should().Be("dummyUsername");
        user.Password.Should().Be("sadsdf");

    }
}