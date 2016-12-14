// This program builds a binary tree with 5 nodes.
#include <iostream>
#include "Header.h"
using namespace std;

int main()
{
   BinaryTree<int> tree;
   bool keepgoing = true;
   int value;
   char cont;
   
   while(keepgoing == true)
   {
	   cout << "What value would you like to input into the node?" << endl;
	   cin >> value;

	   tree.insertNode(value);

	   cout << "Would you like to continue? (y/n)" << endl;
	   cin >> cont;

	   if(cont != 'y')
		   keepgoing = false;
   }

   /*
   tree.insertNode(5);
   tree.insertNode(8);
   tree.insertNode(3);
   tree.insertNode(12);
   tree.insertNode(9);
   */
   cout << "Done.\n";

   return 0;
}