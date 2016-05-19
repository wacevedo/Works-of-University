#include <conio.h>
#include <stdio.h>
#include <stdlib.h>
#define MAX 5

void insert (int);
int del();
void display();
int queve[MAX];
int front=-1;
int rear=-1;

main()
{
	int choice, num;
	while(1)
	{
		printf("\nEnter Your Choice\n");
		printf("1. Insert\n");
		printf("2. Delete\n");
		printf("3. Display\n");
		printf("4. Exit\n");
		scanf("%d", &choice);
		switch(choice)
		{
			case 1:
				printf("Enter a number to be inserted: ");
				scanf("%d",&num);
				insert(num);
				break;
			case 2:
			    num=del();
				break;
			case 3:
			    display();
				break;	
			case 4:
				exit(1);
			default:
				printf("Invalid Choice\n");
		}
		
	}
}

void insert(int element)
{
	if (rear==MAX-1)
	{
		printf("\nQueve is Full\n");
		return;
	}
	
	if(front==-1)
	{
		front=0;
	}
	rear=rear+1;
	queve[rear]=element;
}


int del()
{
	int element;
	if(front==-1 || front==rear+1)
	{
		printf("Queve is Empty\n");
		return 0;
	}
	
element=queve[front];
front=front + 1;
printf("%d has been deleted", element);

if (rear==front-1)
{
	front=-1;
	rear=-1;
}
return element;
}

void display()
{

	if (front==-1 || front==rear+1)
	{
		printf("Queve is Empty\n");
		return;
	}
	for (int i=front; i<=rear; i++)
	{
		printf("%d   ",queve[i]);
	}

}
