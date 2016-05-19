#include <stdlib.h>
#include <stdio.h>
#include <conio.h>
#include <windows.h>

void wait(int miseg)
{  
 int y,x;
	for(x=1; x<=miseg+10000; x++)
	{
		y=y+x;
	}
}

void gotoxy(int x,int y)
{  
      HANDLE hcon;  
      hcon = GetStdHandle(STD_OUTPUT_HANDLE);  
      COORD dwPos;  
      dwPos.X = x;  
      dwPos.Y= y;  
      SetConsoleCursorPosition(hcon,dwPos);  
 } 
 
int main()
{ int x;
	while(!kbhit())
	{
		gotoxy(10,10);printf("Presione una tecla");
		Sleep(1000);
		gotoxy(10,10);printf("                  ");
		Sleep(1000);
	}
}
