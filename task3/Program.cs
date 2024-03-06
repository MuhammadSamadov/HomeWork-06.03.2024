



using task3;

var bank=new BankAccount();
bank.AccountNumber=1;
bank.Owner="Samadov Muhammad";
bank.TopUp(5000);
bank.Withdraw(5000);
System.Console.WriteLine(bank.PrintStatement());