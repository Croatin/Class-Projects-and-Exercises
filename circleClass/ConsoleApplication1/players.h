#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

class Trivia
{
	private:
		int playerScore1;
		int playerScore2;
		int questionNum;
	public:
		void viewQuestion(int q);
		int isCorrect();
};

/*
cout << "" << endl;
*/