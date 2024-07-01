using System;
namespace BankEncapsulation
{
	public class BankAccount
	{
		private double balance = 0;

		public void Deposit(double myBalance)
		{
			balance = myBalance; 
		}

		public string GetBalance()
		{
			return $"${balance}";
		}
		public BankAccount()
		{
		}
	}
}

