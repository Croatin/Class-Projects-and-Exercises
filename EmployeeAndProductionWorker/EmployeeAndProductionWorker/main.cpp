#include <iostream>
#include <iomanip>
#include "ProductionWorker.h"
using namespace std;

int main()
{
	ProductionWorker worker;

	worker.setInfo();
	worker.getInfo();

	worker.setInfoP();
	worker.getInfoP();
}