#include <stdlib.h>
#include stdio.h>
#include conio.h>
#include <process.h>
#include <ctype.h>
 
float anoact=0, anonac=0, ano=0, mes=0, sem=0, dias=0, horas=0;
void main()
{
	clrscr();
gotoxy(1,5);printf("Digite el ano actual: ");
scanf("%f",&anoact);
gotoxy(1,6);printf("Digite el ano de nacimiento: ");
scanf("%f",&anonac);
ano=anoact-anonac;
mes=12*ano;
sem=52.14*ano;
dias=365*ano;
horas=8765.812*ano;

gotoxy(1,9); printf("Su edad en ano: %f",ano);
gotoxy(1,10); printf("Su edad en meses: %f",mes);
gotoxy(1,11); printf("Su edad en semana: %f",sem);
gotoxy(1,12); printf("Su edad en dias: %f",dias);
gotoxy(1,13); printf("Su edad en horas: %f",horas);
getch();
}