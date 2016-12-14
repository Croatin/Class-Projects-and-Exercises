#include <iostream>
#include <iomanip>
#include <string>
#include "Employee.h"

class ProductionWorker : public Employee
{
private: 
	int shift;
	double hourlyPay;
public:
	void setInfoP();
	void getInfoP();
};

void ProductionWorker::setInfoP()
{
	int s;
	double h;
	hourlyPay = 0;



	cout << "Type 1 if you have a day shift. 2 if you work the night shift." << endl;
	cin >> s;

	while (s != 1 && s != 2)
	{
		cout << "Incorrect, try again" << endl;
		cin >> s;
		shift = s;
	}

	cout << "What is your hourly pay?" << endl;
	cin >> h;
	hourlyPay = h;
	
}

void ProductionWorker::getInfoP()
{
	if(shift == 1)
	{
		cout << "You have a Day shift." << endl;
	}
	if(shift == 2)
	{
		cout << "You have a Night shift." << endl;
	}
	cout << "Your hourly pay is: " << hourlyPay << endl;
}
