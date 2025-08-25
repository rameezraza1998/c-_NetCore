using System;

public class BankAccount
{
    public string AccountNumber { get; private set; }
    public string AccountHolder { get; private set; }
    public decimal Balance { get; private set; }

    public BankAccount(string accountNumber, string accountHolder, decimal balance)
    {
        AccountNumber = accountNumber;
        AccountHolder = accountHolder;
        Balance = balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be more than 0.");
        }
        else
        {
            Balance += amount;
            Console.WriteLine($"The Rs: {amount} is deposited in your account and your new Balance is: {Balance}");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0 || amount > Balance)
        {
            Console.WriteLine("Transaction failed");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine($"The Rs: {amount} is withdrawn from your account and your new Balance is: {Balance}");
        }
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Please create an account number: ");
        string accountNumber = Console.ReadLine();   // ✅ declare string

        Console.WriteLine("Please enter your name: ");
        string accountHolder = Console.ReadLine();   // ✅ declare string

        BankAccount account1 = new BankAccount(accountNumber, accountHolder, 0);

        account1.Deposit(1000m);
        account1.Withdraw(100m);
    }

}
