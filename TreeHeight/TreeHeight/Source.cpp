#include <iostream>
#include "Tree.h"
using namespace std;

int main()
{
	
   BinaryTree<int> tree;
   int input;
   bool cont = true;
   char yorN;

   while(cont)
   {
	   cout << "Enter a value for the Binary tree" << endl;
	   cin >> input;
	   tree.insertNode(input);
	   cout << "Do you wish to continue? (Y/N)" << endl;
	   cin >> yorN;
	   if(yorN != 'y')
		   cont = false;
   }
   /*
   for(int count=0; count<3; count++)
   {
		cout << "please enter a value to insert into the binary tree"<<endl;
		cin>>input;
		tree.insertNode(input);
   }
   cout<<"enter a value to search for"<<endl;
   cin>>input;
   tree.searchNode(input);
   */
   //int * ptr;
   int var = tree.callCounter();
   cout<< "The node count is: " << var << endl;
   system("pause");
   return 0;
}