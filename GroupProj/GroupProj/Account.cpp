#include "Account.h"   
#include <iostream>
#include <cstdlib>       
using namespace std;


Account::Account(double b, double i)
{
    balance = b;
    interestRate = i;                  
}
void Account::deposit(double amount)
{
    balance += amount;
    deposits++;
}
void Account::withdraw(double amount)
{
	balance -= amount;
	withdrawals--;
}
void Account::calcInt()
{
    balance = balance + (balance * (interestRate/12));
}
void Account::monthlyProc()
{
    balance -= serviceCharges;
    calcInt();
    withdrawals = 0;
    deposits = 0;
    serviceCharges = 0;
}