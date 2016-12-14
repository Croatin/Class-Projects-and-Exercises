#include <iostream>
#include <iomanip>
#include <string>
#include "linkedList.h"
using namespace std;

int main()
{
	NumberList list;
	bool check = true;
	int val;
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
}