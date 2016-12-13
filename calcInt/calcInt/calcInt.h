#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

class Account
{
protected:
		double balance;				
		int deposits;			
		int withdrawls;
		double annualInterestRate;		
		double serviceCharges;
		bool status;
public:
	Account();
	void deposit();
	void withrdrawl();
	void calcInt(); 
	void getMonth();
};

void Account::calcInt()
{
	double monthlyInterestRate;
	double monthlyInterest;

	monthlyInterestRate = (annualInterestRate / 12);
	monthlyInterest = balance + monthlyInterestRate;
	balance = balance + monthlyInterest;

	// the following is for test data only
	// cout << "The following is your balance: " << balance << endl;

}