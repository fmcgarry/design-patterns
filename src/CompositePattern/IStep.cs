namespace CompositePattern;

internal interface IStep // Component
{
    /* 
     * This is the base Component object type. All Steps and Recipes are IStep,
     * which allows you to treat a collection of Steps (which is a Recipe)
     * as a Step. That is the purpose of the Composite Pattern.
     */

    /* 
     * The Composite pattern takes a tree-like hierarchy of nodes,
     * and recursively runs each node that has children. See Recipe.Run()
     * for an example.
     */

    public void Run();
}
