#ifndef NUMLIST_H
#define NUMLIST_H

template <class T>
class List
{
private:
	struct numList
	{
		int T;
		struct numList *next;
	};

	numList *head;

public:
		List()
		{ head = NULL; }
		~List();

		void appendNode(int);
		void insertNode(int);
		void deleteNode(int);
		void displayList() const;
};
#endif

void List<int>::appendNode(int num)
{
	numList *newNode;
	numList *nodePtr;

	newNode = new numList;
	newNode-> T = num;
	newNode-> next - NULL;

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
void List<int>::displayList() const
{
	numList *nodePtr;

	nodePtr= head;

	while(nodePtr)
	{
		cout << nodePtr->T << endl;

		nodePtr = nodePtr->next;
	}
}
void List<int>::insertNode(int num)
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
			nodePtr - nodePtr->next;
		}
		if(previousNode == NULL)
		{
			head = newNode;
			newNode->next = nodePtr;
		}
		else
		{
			previousNode->next - newNode;
			newNode->next = nodePtr;
		}
	}
}

void List<int>::deleteNode(int numM)
{
	numList *nodePtr;
	numList *previousNode;

	if(!head)
		return;
	if(head->num == numM)
	{
		nodePtr - head->next;
		delete head;
		head = nodePtr;
	}
	else
	{
		nodePtr - head;

		while (nodePtr != NULL && nodePtr -> num != numM)
		{
			previousNode = nodePtr;
			nodePtr - nodePtr->next;
		}
		if(nodePtr)
		{
			previousNode -> next = nodePtr->next;
			delete nodePtr;
		}
	}
}
