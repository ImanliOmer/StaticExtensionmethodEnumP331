namespace StaticExtensionMethodEnumP331
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Ruslan", "Andrey",1);
            User user1 = new User("Metleb", "Huseynov", 2);
            User user2 = new User("Seymur", "Quliyev", 4);
            User user3 = new User("Rustem", "Allahverdiyev", 6);
            User user4 = new User("Huseyn", "Elizade", 11);

            Console.WriteLine(user.GetDetails());

        }
    }
}