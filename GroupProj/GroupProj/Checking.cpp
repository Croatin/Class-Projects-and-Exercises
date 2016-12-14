#include <iostream>
#include <cstdlib> 
#include "Checking.h"
using namespace std;


//defintion of withdraw function
void Checking::withdraw(double amount)
{
	balance = balance - amount;
	if (balance < 0)
	{
		balance += amount; // not making withdraw
		balance -= 15; // service charge of $15
		cout << "Your balance is negative." << endl;
	}
	
}

// definition of monthlyProc function
void Checking::monthlyProc()
{
	serviceCharges = 5 + (.10 * withdrawals);// calculates the service charages for one month.
}
		

	