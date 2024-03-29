﻿using CompositePattern;
using CompositePattern.Axes;
using CompositePattern.Recipes;
using CompositePattern.Steps;

var axisFactory = new AxisFactory();

// Creating a Recipe (this is the normal composite pattern way)
var recipe = new Recipe("CustomRecipe");

// Adding Leaf
recipe.Add(new MoveRelativeStep(axisFactory.Create("Gantry"), 1000, 100));

// Add Composite
recipe.Add(new GoToSampleRecipe(10, axisFactory));

// Calling Component method
recipe.Run();

Console.WriteLine();

// Running a Recipe with pre-initialized steps
var recipeGoToSample = new GoToSampleRecipe(10, axisFactory);
recipeGoToSample.Run();