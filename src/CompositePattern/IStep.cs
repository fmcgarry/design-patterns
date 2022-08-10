namespace CompositePattern;

internal interface IStep
{
    /* 
     * This is the base object type. All Steps and Recipes are IStep,
     * which allows you to treat a collection of Steps (which is a Recipe)
     * as a Step. That is the purpose of the Composite Pattern.
     */

    /* 
     * The Composite pattern takes a tree-like hierarchy of nodes,
     * and recursively runs each node that has childred. See Recipe.Run()
     * for an example.
     */

    public void Run();
}
