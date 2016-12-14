#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

struct speakers
{
	string name, topic;
	double phoneNumber, fee;
};

int main()
{
	int userEdit, editNum, listSize = 1;
	speakers bureauList[1];
	string userAnswer;

	for(int counter = 0; counter < listSize; counter++)
	{
		cout << "The name for speaker #" << counter + 1 << ":" << endl;
		cin >> bureauList[counter].name;
		cout << "The topic that " << bureauList[counter].name << " will be speaking about" << endl;
		cin >> bureauList[counter].topic;
		cout << bureauList[counter].name << "'s phone number?" << endl;
		cin >> bureauList[counter].phoneNumber;
		cout << bureauList[counter].name << "'s Fee?" << endl;
		cin >> bureauList[counter].fee;
	}
	cout << "Would you like to edit any of the data you presented? (Yes to continue)" << endl;
	cin >> userAnswer;

	while(userAnswer == "Yes" || userAnswer == "yes")
	{
		cout << "What is your speakers number?" << endl;
		cin >> editNum;

		cout << "1) Would you like to edit " << bureauList[editNum-1].name << "'s name?" << endl << "2) Would you like to edit " << bureauList[editNum-1].name << "'s  topic?" << endl << 
				"3) Would you like to edit " << bureauList[editNum-1].name << "'s Phone number?" << endl  << "4) would you like to edit " << bureauList[editNum-1].name << "'s fee?" << endl;
		cin >> userEdit;

			switch(userEdit)
			{
			case '1' :
				{
					cout << "What is their new name?" << endl;
					cin >> bureauList[editNum - 1].name;
				}
			case '2' :
				{
					cout << "What is their new topic?" << endl;
					cin >> bureauList[editNum -1].topic;
				}
			case '3' :
				{
					cout << "What is their new Phone Number?" << endl;
					cin >> bureauList[editNum - 1].phoneNumber;
				}
			case '4' :
				{
					cout << "What is their new fee?" << endl;
					cin >> bureauList[editNum -1].fee;
				}
			}
		cout << "Would you like to continue editing?" << endl;
		cin >> userAnswer;
	}
}
	

/*	for(int counter = 0; counter < 10; counter++)
	{
			cout << "Please input information for your speakers." << endl;
			cin >> bureauList[counter];
	}

	cout << "Would you like to edit the speakers? ('Yes' to continue)" << endl;
	cin >> userAnswer;

	while(userAnswer == "Yes" || userAnswer == "yes")
	{
		cout << "What is the array element of the speaker you would like to edit?" << endl;
		cin >> element;
		cout << "What would you like to change the name to?" << endl;
		cin >> changedName;
		bureauList[element].name == changedName;
		cout << "What would you like to change the topic to?" << endl;
		cin >> changedTopic;
		bureauList[element].topic == changedTopic;
		cout << "What would you like to change the Number to?" << endl;
		bureauList[element].phoneNumber == changedNumber;
		cout << "What would you like to change the Fee to?" << endl;
		bureauList[element].fee == changedFee;

		cout << "Would you like to edit another array element?" << endl;
		cin >> element;
	}
*/

	




