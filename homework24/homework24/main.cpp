#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

int main()
{
	int num[10] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
	int rNum = 0;
	int input;
	bool found = false;

	cout << "What number are you looking for?" << endl;
	cin >> input;
	
	for(int i = 0; i < 10; i++)
	{
		if(num[i] = input)
		{
			found = true;
		}
	}
	if(found = false)
	{
		throw "Error: cant find that one." << endl;
	}
	
}
