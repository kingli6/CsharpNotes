namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User hiUser = new User();   //hi
            //User userName = new User("Jonathan");   // Hi, Jonathan
            User user = new User("Joe", "Fisher");    //Hi, welcome Joe Fisher
        }

        class User
        {
            public User()
            {
                Console.Write("Hi, ");
            }
            public User(string name1) : this()
            {
                Console.Write(name1);
            }
            public User(string firstName, string secondName) : this("welcome ")
            {
                Console.Write(firstName + " " + secondName);
            }
        }
    }
}