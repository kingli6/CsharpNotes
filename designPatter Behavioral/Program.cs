// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//https://www.freecodecamp.org/news/the-basic-design-patterns-all-developers-need-to-know/
/*
 Chef chef = new Chef();
        
		Order order = new Order(chef, “Pasta”);
		Waiter waiter = new Waiter(order);
		waiter.execute();

		order = new Order(chef, “Cake”);
		waiter = new Waiter(order);
		waiter.execute();
 
 */
public class Chef
{
    private Cook cook1;
    private Cook2 cook2;

    void aMethod(string item)
    {
        if(item == "pasta")  cook1.makeFood(); 
        else cook2.makeFood();
    }

    private class Cook
    {
        internal void makeFood()
        {
            throw new NotImplementedException();
        }
    }
}

internal class Cook2
{
    internal void makeFood()
    {
        throw new NotImplementedException();
    }
}