#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

class Employee
{
private: 
		string eName, date;
		double phoneNum;
public:
		void setInfo();
		void getInfo();
};

void Employee::setInfo()
{
	string n, d;
	double pN;

	cout << "Employee's name: " << endl;
	getline(cin, n);
	eName = n;

	cout << "Date of Employment: " << endl;
	getline(cin, d);
	date = d;

	cout << "Employee's phone number: " << endl;
	cin >> pN;
	phoneNum = pN;
}

void Employee::getInfo()
{
	cout << "Employee's name: " << eName << endl;
	cout << "Employee's Phone Number: " << phoneNum << endl;
	cout << "Date of Employment: " << date << endl;
}
