using CompositePattern;
using CompositePattern.Axes;
using CompositePattern.Recipes;
using CompositePattern.Steps;

var axisFactory = new AxisFactory();

// Creating a Recipe (this is the normal composite pattern way)
var recipe = new Recipe("CustomRecipe");

// Adding Leaf
IAxis _gantry = axisFactory.Create("Gantry");
recipe.AddStep(new MoveRelativeStep(_gantry, 1000, 100));

// Add Composite
recipe.AddStep(new GoToSampleRecipe(10, axisFactory));

// Calling Component method
recipe.Run();

Console.WriteLine();

// Running a Recipe with pre-initialized steps
var recipeHome = new HomeRecipe(axisFactory);
recipeHome.Run();