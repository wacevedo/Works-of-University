#include <stdlib.h>
#include <stdio.h>
#include <conio.h>
#include <process.h>
#include <ctype.h>
#include <dos.h>

char sexo;
int m=0,f=0;

void main()
{
clrscr();


do{
	    gotoxy(28,5);printf("   ");
    	gotoxy(1,5);
    	printf("inserte F o M <0=terminar>: ");
    	
    	scanf("%c",&sexo);
    	switch(sexo)
    	{
            case'0':
            {
                break;
            }
    		case'M':
    		{
    			m++;
                break;
    		}
            case'f':
            {
                f++;
                break;
            }    
    		case'm':
    		{  
                m++;
    			break;
    		}
    		case'F':
    		{
    			f++;
                break;
    		}
    		
            default:
            {   
                /*if ((sexo!='m') && (sexo!='f') && (sexo!='M') &&  (sexo!='F'))
                {                  
                gotoxy(28,5);
                printf("Invalid input!");
                delay(1000);
                gotoxy(28,5);
                printf("              ");
                }*/
                break;              
                                
            }
    	}
}while(sexo!='0');
gotoxy(1,7);
printf("Hay %d Hombres y %d Mujeres",m,f);

getch();
}