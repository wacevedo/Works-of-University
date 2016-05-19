#include <stdlib.h>
#include <stdio.h>
#include <conio.h>

int main()
{
	int num;
	
	printf(" Willson Neris Acevedo Sanchez\n");
 	printf(" 2012-1993\n");
 	printf("\n\n"); 	
    
	printf("Inserte un numero: ");
	scanf("%d",&num);
	
	switch(num)
	{
		case 1:
			{
				printf("one");
				break;
			}
		case 2:
		   {		   
			    printf("two");
				break;
	       }
		case 3:
	       {
		        printf("three");
				break;
	       }
	       case 4:
	       {
		        printf("four");
				break;
	       }
	       case 5:
	       {
		        printf("five");
				break;
	       }
	       case 6:
	       {
		        printf("six");
				break;
	       }
	       case 7:
	       {
		        printf("seven");
				break;
	       }
	       case 8:
	       {
		        printf("eight");
				break;
	       }
	       case 9:
	       {
		        printf("nine");
				break;
	       }
	       case 10:
	       {
		        printf("ten");
				break;
	       }
	       case 11:
	       {
		        printf("eleven");
				break;
	       }
	       case 12:
	       {
		        printf("twelve");
				break;
	       }
	    default:
		{   
		    printf("Numero no disponible");
	    	break;
	    }   				
	}
	
	
	getch();
	return 0;
}
