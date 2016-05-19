#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
char user[5];
char pass[5];
int intentos=4;


int main()
{
	printf(" Willson Neris Acevedo Sanchez\n");
 	printf(" 2012-1993\n");
 	printf("\n");
 	while(intentos>0)
 	{
 		intentos--;
 		printf("Ususrio:");
 		scanf("%s",&user);
 		printf("Contrase%ca:",164);
 		scanf("%s",&pass);
 		if ((user!="ADMI") || (pass!="ADMI"))
 		{ 			
		  	printf("Error, el usuario y/o la contrase%ca son incorretos \n%s\n%s\n",164,user,pass);
		  	printf("Le quendan %d intentos\n",intentos); 			
 		}
 		else if((user=="ADMI")&& (pass=="ADMI"))
 		{
 			printf("Sesion iniciada\n");
 			break;
 		}
 	}
 	if(intentos==0)
 	{
 		printf("Ha excedido el numero de intentos\n");
 	}
	else
	{
		printf("Bienvenido\n");
	}
 	
 	getchar();
    return 0;

}
