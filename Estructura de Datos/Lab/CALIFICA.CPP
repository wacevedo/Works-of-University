#include <stdlib.h>
#include <stdio.h>
#include <conio.h>
#include <process.h>
#include <ctype.h>
  
 int calif=0;
 
 void main()
 { 
 do{
 	clrscr();
 	gotoxy(1,5);
 	printf("Digite su calificacion: ");
 	scanf("%d",&calif);
 	gotoxy(1,6);
 	if ((calif>=70) && (calif<=79))
 		{printf("su nota es C");}
 	if ((calif<60)) 
 		{printf("su nota es F");}
 	if ((calif>=80) && (calif<=89))
 		{printf("su nota es B");}
 	if ((calif>=90) && (calif<=100))
 		{printf("su nota es A");}
 	if ((calif>=60) && (calif<=69))
 		{printf("su nota es D");}
 	getch();
 	gotoxy(24,5);
 	printf("    ");
    }while(calif!=0);

 } 