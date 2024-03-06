namespace task3;

public class BankAccount 
{
    public int AccountNumber { get; set; }
    decimal _balance;
    public string? Owner { get; set; }
    public void TopUp(decimal amount)
    {
        _balance=amount;
    }
    public void Withdraw(decimal amount)
    {
        amount=_balance;
    }
    public decimal PrintStatement()
    {
        return _balance;
    }
}
