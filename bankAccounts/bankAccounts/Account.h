#ifndef ACCOUNT_H
#define ACCOUNT_H

class Account
{ 
   protected:
			int withdrawals;
			int deposits;
			double interestRate; 
			double balance;
			double serviceCharges;      
   public:
			Account(double, double);
			virtual void deposit(double);
			virtual void withdraw(double);
			virtual void calcInt();
			virtual void monthlyProc();
			virtual double getBalance()
			{
				return balance;
			}
			virtual int getDeposits()
			{
				return deposits;
			}
			virtual int getWithdrawals()
			{
				return withdrawals;
			}
			virtual double getService()
			{
				return serviceCharges;
			}
          
};
#endif