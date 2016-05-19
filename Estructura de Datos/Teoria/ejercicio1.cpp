#include<stdio.h>
#include<stdlib.h>
#include<conio.h>

int num1=0,num2=0,num3=0;
int main()

{
	//clrscr();
	printf(" Willson Neris Acevedo Sanchez\n");
 	printf(" 2012-1993\n");
 	printf("\n");
 	printf("Digite su primer numero: ");
 	scanf("%d",&num1);
 	printf("Digite su segundo numero: ");
 	scanf("%d",&num2);
 	printf("Digite su tercer numero: ");
 	scanf("%d",&num3);
 	if((num1<num2) && (num1<num3)&& (num2<num3))
 	{
 		printf("el orden correcto es: %d,%d,%d \n",num1,num2,num3);
	}
	else if((num2<num1) && (num2<num3)&& (num1<num3))
 	{
 		printf("el orden correcto es: %d,%d,%d \n",num2,num1,num3);
 	}
 	else if((num3<num1) && (num3<num2)&& (num1<num2))
 	{
 		printf("el orden correcto es: %d,%d,%d \n",num3,num1,num2);
 	}
 	else
 	{
 		printf("el orden correcto es: %d,%d,%d \n",num3,num2,num1);
 	}
 	getchar();
    return 0;

}
