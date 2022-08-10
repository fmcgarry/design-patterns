using CompositePattern.Axes;
using CompositePattern.Recipes.Custom;

var axisFactory = new AxisFactory();

var recipeHome = new HomeRecipe(axisFactory);

recipeHome.Run();