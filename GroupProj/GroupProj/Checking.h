//Katie Frederick
#ifndef CHECKING_H
#define CHECKING_H
#include "Account.h"

class Checking : public Account
{
	public:
		Checking(double balance, double annualInterest) : Account(balance, annualInterest){};
		void withdraw(double); 
		void monthlyProc();
};
#endif