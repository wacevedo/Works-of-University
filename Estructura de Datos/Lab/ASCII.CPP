#include <stdio.h>
#include <conio.h>

void main()
{
 
 int codigo=1, y=1,x=1;
 clrscr();
 
  do
   {
       
      gotoxy(x,y);
   	  printf("%d= %c\n",codigo,codigo);
      codigo++;
      y++;
      if (y>=25)
      	{y=1; x+=7;}
   }
  while(codigo<=255);
  getch();
}