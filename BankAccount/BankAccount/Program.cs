                    internal class BankAccount
                    {
                        public string AccountNumber { get; private set; }
                        public string AccountHolder { get; private set; }
                        public decimal Balance { get; private set; }

                        public BankAccount(string accountNumber, string accountHolder, decimal balance) {

                            AccountNumber = accountNumber;
                            AccountHolder = accountHolder;
                            Balance = balance ;
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
                                Console.WriteLine($"the Rs: {amount} is deposited in your account and your new Balance is: {Balance}");
                            }
                        }

                        public void Withdraw(decimal amount)
                        {
                            if(amount <= 0 || amount > Balance)
                            {
                                Console.WriteLine("Transaction failed");
                            }

                            else
                            {
                                Balance -= amount;
                                Console.WriteLine($"the Rs: {amount} is withdrawn from your account and your new Balance is: {Balance}");
                            }

                        }
    

                        private static void Main(string[] args)
                        {

                            BankAccount account1 = new BankAccount("abc123456","Rameez",0);
                            Console.WriteLine($"Account is Successfully Created under the name of {account1.AccountHolder}");
                            Console.WriteLine($"The initial account balance is: {account1.Balance}");

                            account1.Deposit(5000);
      

                            //account1.Deposit(0);
                            account1.Withdraw(1000);
      
        


                        }                                                                                                                                                                                                                                        
                    }