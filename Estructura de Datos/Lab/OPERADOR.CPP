#include<stdlib.h>
#include<stdio.h>
#include<conio.h>
#include<process.h>
#include<ctype.h>
//#include<string.h>
 
 char oper;
 float num1=0, num2=0, result=0;

 void main()
 {
   clrscr();
   gotoxy(1,5);
   printf("inserte la operacion que quiere realizar\n");
   printf("ejemplo: 2+7 , 2*2 , 5-2 , 9/3\n");
   scanf("%f",&num1);
   do
   {
   	gotoxy(1,8);scanf("%s",&oper);
   	if ((oper=='*')||(oper=='/')||(oper=='-')||(oper=='+'))
       break;

    gotoxy(1,8);printf("ERROR 314! operador not found");
   }while((oper=='*') || (oper=='/') || (oper=='+') || (oper=='-'));
   scanf("%f",&num2);
   if (oper=='*') 
   {result=num1*num2;}
   if (oper=='/') 
   {result=num1/num2;}	
   if (oper=='-') 
   {result=num1-num2;} 
   if (oper=='+')
   {result=num1+num2;}
   gotoxy(1,10);printf("El Resulto es: %f",result);
   getch();
 }