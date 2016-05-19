#include <stdlib.h>
#include <stdio.h>
#include <conio.h>

int main()
{
	int num1,num2,result;
	char oper;
	printf(" Willson Neris Acevedo Sanchez\n");
 	printf(" 2012-1993\n");
 	printf("\n\n"); 	
    
	printf("Inserte un numero: ");
	scanf("%d",&num1);
	printf("Inserte un operador: ");
	scanf("%s",&oper);
	printf("Inserte otro numero: ");	
	scanf("%d",&num2);
	switch(oper)
	{
		case '+':
			{
				result=num1+num2;
				break;
			}
		case '-':
		   {		   
			    result=num1-num2;
				break;
	       }
		case '/':
	       {
		       result=num1/num2;
				break;
	       }
		case '*':
		   {
		     	result=num1*num2;
				break;
		   }
	    case '%':
		   {		   
		     	result=num1%num2;
				break;
		   }
	    default:
		{   
		    printf("Operador incorrecto %c\n",oper);
	    	break;
	    }   				
	}
	printf("El resultado es:  %d %c %d = %d",num1,oper,num2,result);
	
	getch();
	return 0;
}
