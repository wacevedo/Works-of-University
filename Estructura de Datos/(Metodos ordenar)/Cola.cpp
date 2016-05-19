#include <conio.h>
#include <stdio.h>
#include <stdlib.h>
#define MAX 5

int stack[MAX];
int top=-1;
void push(int);
int pop();
void mostrar();

main()
{
 
	int elegir, num;
	
	while(1)
	{		
		printf("\nDigite Opcion\n");
		printf("1. Insertar\n");
		printf("2. Borrar\n");
		printf("3. Mostrar\n");
		printf("4. Salir\n");
		scanf("%d", &elegir);
		switch(elegir)
		{
			case 1:
				printf("Introduzca numero: ");
				scanf("%d",&num);
				push(num);
				break;
			case 2:
			    num=pop();
				break;
			case 3:
			    mostrar();
				break;	
			case 4:
				exit(1);
			default:
				printf("Opcion Invalida\n");
		}
	}
}

void push(int elemento)
{
	if (top==MAX-1)
	{
		printf("La Pila esta sobrecargada\n");
		return;
	}
	top=top+1;
	stack[top]=elemento;
}

int pop()
{
	int elemento;
	if(top==-1)
	{
		printf("la Cola esta vacia\n");
		return 0;
	}
	elemento=stack[top];
	top=top-1;
	printf("%d ha sido borrado", elemento);
	return elemento;
}

void mostrar()
{
	int i;
	if(top==-1)
	{
		printf("La Cola esta vacia\n");
		return;		
	}
	printf("\n\n");
	for (i=top;i>+0;i--)
	printf("%d\n", stack[i]);
}
	

