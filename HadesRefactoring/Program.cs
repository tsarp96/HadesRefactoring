// See https://aka.ms/new-console-template for more information
using HadesRefactoring.Readers;
using HadesRefactoring.Repositories;
using HadesRefactoring.User;
using HadesRefactoring.User.Services;


var userRepository = new UserRepository();
var userReader = new UserReader(userRepository);
var semanticUserEvaluator = new SemanticUserEvaluator();

var userService = new UserService(
    semanticUserEvaluator, 
    userReader);







