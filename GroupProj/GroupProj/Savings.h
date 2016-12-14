// Graham SImpson 
// savings.h 
#ifndef SAVINGS_H
#define SAVINGS_H
#include "Account.h"
class Savings: public Account
{
	private:
		bool status;

	public:
		Savings(double balance, double annualInterest) : Account(balance, annualInterest){};
		void withdraw(double);
		void deposit(double);
		void monthlyProc();
		void activity();
		


};
#endif