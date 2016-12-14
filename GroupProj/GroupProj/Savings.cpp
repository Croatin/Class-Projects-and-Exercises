//Graham Simpson
#include "Savings.h"
#include <iostream>      
#include <cstdlib>       
using namespace std;

void Savings::withdraw(double amount)
{
	activity();
	if (status==false) // check to see if the activity of the account
	{
		cout << "Account is inactive get more money to reactivate you account" << endl;
	}

	else
	{
		Account::withdraw(amount); // funtion call to the base class withdraw function	
	}
}
void Savings::deposit(double amount)
{	

	if (status==false) // check to the if the account is inactive 
	{
		
				
		balance=balance+amount;
		activity();
		if(status)
		{
			Account::deposit(amount);
		}
		else 
		{
			cout << "Account is inactive get more money to reactivate you account" << endl;
			balance -= amount;
		}
	}
	else
	{
		Account::deposit(amount); // funtion call to the base class deposit function	
	}
			

}
void Savings::monthlyProc()
{
	int xtrawithdraws; // temp varible to hold the number of charges over the alotted 4 
	xtrawithdraws=(withdrawals-4);

	if (xtrawithdraws>0)
	{
		cout<<" you have too many withdraws this month; a $1 service chage will be added for each withdraw above 4"<<endl;
		serviceCharges=(serviceCharges+xtrawithdraws);
		activity();
		
		Account::monthlyProc(); // calling the base class function 
	}
 
	else
	{
		Account::monthlyProc(); // calling the base class function 
	}
}
void Savings::activity()
{
	
	if (balance < 25)
	{
		status=false;
	}

	else 
	{ 
		status=true;
	}
}