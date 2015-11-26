using _02.BankOfKurtovoKonare.Models;

namespace _02.BankOfKurtovoKonare.Interfaces
{
    public interface IAccount
    {
        Customer Customer { get; }
        decimal Balance { get; }
        decimal InterestRate { get; }
        void DepositMoney(decimal amount);
        decimal CalculateInterest(int months);
    }
}
