# Composite Pattern

![UML Diagram](img/uml-diagram.png)

The purpose of the Composite Pattern to provide the ability to nest objects in a tree-like hierarchy of nodes with the intent to recursively run each node that has children.

This pattern reminds of the Linux command `grep -R "search term"`, which recusively opens files in directories searching for a given string.

# Example

The example used in this repository details a machine that executes certain actions (_"Steps"_) in a specific order to perform overall functions (_"Recipes"_). The naming convention is borrowed from cooking due to it's similarity.

`IStep` is a _Component_. The _operation()_ shown in the diagram above is the _Run()_ method.

A `Step` is a _Leaf_. It inherits the _Run()_ method from `IStep` and defines a certain action in that method.

A `Recipe` is a _Composite_. It contains a collection of other `IStep` objects, which it iterates over in the inherited _Run()_ method from `IStep`. Each iteration on an `IStep` object calls that object's _Run()_ method. 

Since `Step` and `Recipe` objects both inherit from `IStep`, so they are both also considered _Components_. 