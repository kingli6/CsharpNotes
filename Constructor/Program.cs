namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Joe", "Fisher");
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