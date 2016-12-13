#include <iostream>
#include <iomanip>
using namespace std;
#ifndef NUMLIST_H
#define NUMLIST_H


class NumberList
{
private:
	struct numList
	{
		int T;
		struct numList *next;
	};

	numList *head;

public:
		NumberList()
		{ head = NULL; }
	//	~NumberList();

		void appendNode(int);
		void insertNode(int);
		void deleteNode(int);
		void displayList() const;
		void mergeArray(double arr[], int arraySize);
};
#endif

void NumberList::mergeArray(double arr[], int arraySize)
{
	for(int i = 0; i < arraySize; i++)
	{
		NumberList::insertNode(arr[i]);
	}
}
void NumberList::appendNode(int num)
{
	numList *newNode;
	numList *nodePtr;

	newNode = new numList;
	newNode-> T = num;
	newNode-> next = NULL;

	if(!head)
			head = newNode;
	else
	{
		nodePtr = head;
		while (nodePtr->next)
			nodePtr = nodePtr->next;
		nodePtr->next = newNode;
	}
}
void NumberList::displayList() const
{
	numList *nodePtr;

	nodePtr= head;

	while(nodePtr)
	{
		cout << nodePtr->T << endl;

		nodePtr = nodePtr->next;
	}
}
void NumberList::insertNode(int num)
{
	numList *newNode;
	numList *nodePtr;
	numList *previousNode = NULL;

	newNode = new numList;
	newNode->next = NULL;

	if(!head)
	{
		head = newNode;
		newNode->next = NULL;
	}
	else
	{
		nodePtr = head;
		previousNode = NULL;
		while(nodePtr != NULL && nodePtr -> T < num)
		{
			previousNode = nodePtr;
			nodePtr = nodePtr->next;
		}
		if(previousNode == NULL)
		{
			head = newNode;
			newNode->next = nodePtr;
		}
		else
		{
			previousNode->next = newNode;
			newNode->next = nodePtr;
		}
	}
}

void NumberList::deleteNode(int numM)
{
	numList *nodePtr;
	numList *previousNode;

	if(!head)
		return;
	if(head->T == numM)
	{
		nodePtr = head->next;
		delete head;
		head = nodePtr;
	}
	else
	{
		nodePtr = head;

		while (nodePtr != NULL && nodePtr -> T != numM)
		{
			previousNode = nodePtr;
			nodePtr = nodePtr->next;
		}
		if(nodePtr)
		{
			previousNode -> next = nodePtr->next;
			delete nodePtr;
		}
	}
}
