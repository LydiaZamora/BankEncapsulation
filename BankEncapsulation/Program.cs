namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount userAccount = new  BankAccount();

            Console.WriteLine("Hello, please enter deposit amount.");

            userAccount.Deposit(double.Parse(Console.ReadLine()));

            Console.WriteLine($"Your balance is: {userAccount.GetBalance()}");
            
            
        }
    }
}
