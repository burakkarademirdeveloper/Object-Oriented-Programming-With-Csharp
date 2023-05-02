// See https://aka.ms/new-console-template for more information
public interface IBankAccount
{
    void PayIn(decimal amount);
    bool Withdraw(decimal amount);
    decimal Balance { get; }
}