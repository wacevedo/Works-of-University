#include <conio.h>
#include <iostream.h>


#define L 10 /* constante con la cantidad maxima de elementos del arreglo*/


void main()
{
int anum [L],temp,i,j;
clrscr();
for (i=0; i<L; i++)
{
 cout<<"Digite el valor  "<<i+1<<" del arreglo\n";
 cin>> anum[i];
}

//metodo burbuja
for (i=0; i<L-1; i++)
   for (j=i+1; j<L; j++)
   {
      if (anum[i] < anum[j])//Para ordenar menor a mayor solo hay que cambiar el signo < por >
	 {
	  temp = anum[i];
	  anum[i] = anum[j];
	  anum[j] = temp;
	 }
   }

cout<<endl;
cout<<"Arreglo ordenado\n";
   for (i=0; i<L; i++)
     cout<<anum[i]<<"  ";

getch();
}