#include <iostream>
#include <sstream>
using namespace std;

class Pallendrome
{
private:
	string compare, saved;
	stringstream convert;
	
public:
	string pallCheck(string checking, int pos, int size);
};

string Pallendrome::pallCheck(string checking, int pos, int size)
{
	saved = "";
	if(pos < size -1)
	{
		pallCheck(checking, pos + 1, size);

		convert << checking[pos];
		convert >> compare;
		
		cout << "this is the positioning: " << checking[pos]<< endl;

		saved.append(compare);

		cout << "Saved: " << saved << endl;
		return saved;
	}
	return saved;
}