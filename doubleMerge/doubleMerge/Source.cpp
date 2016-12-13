#include <iostream>
#include <iomanip>
#include <string>
#include "Header.h"
using namespace std;

int main()
{
	NumberList list;
	bool check = true;
	int val,  arrayNum;
	string cont;
	
	

	while(check)
	{
		cout << "What integer would you like to add to the list?" << endl;
		cin >> val;
		
		list.appendNode(val);

		cout << "Would you like to continue? (Y/N)" << endl;
		cin >> cont;

		if(cont != "y")
			check = false;
	}	

	cout << "Here is your linked list" << endl;
	list.displayList();

	cout << "How many values would you like to insert?" << endl;
	cin >> arrayNum;
	
	double *a = new double[arrayNum];

	for(int i = 0; i < arrayNum; i++)
	{
		cout << "What is your #" << i << " value?" << endl;
		cin >> a[i];

		cout << i + 1 << "Is equal to " << a[i] << endl;
	}
	list.mergeArray(a, arrayNum);

	list.displayList();
	
}