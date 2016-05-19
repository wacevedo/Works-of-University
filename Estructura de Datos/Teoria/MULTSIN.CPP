#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

void main()
{   int num, num2=0, cont=1,cont2=1;
    clrscr();
    printf(" Willson Neris Acevedo Sanchez\n");
    printf(" 2012-1993\n");
    printf("\n");
    printf(" Tabla de multipicacion sin *\n");
    printf("\n"); 
           
            printf("Digite el numero del que quiere la table: ");            
            scanf("%d",&num);
            
            do
            {             
                
                do{ 
                    num2=num2+num;
                    cont2++;
                }while(cont2==cont);
                gotoxy(18,cont+7);
                printf("%d*%d=%d\n", cont, num,num2);
                cont++;
            } while (cont <= 12);

            getch();
}            