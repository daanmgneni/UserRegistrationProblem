namespace UserRegistrationProgram
{
    class Program
    {public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Page!!");
            Console.WriteLine("********************************");
            UserRegistrationCode obj = new UserRegistrationCode();
            Console.WriteLine("Enter the First Name:");
            string FName = Console.ReadLine();
            Console.WriteLine(obj.ValidateFName(FName));
        }
    }
}
