#include <stdio.h>


#define TAM 6


void main()
{
      int m[TAM] = { 75, 80, 72, 91, 83, 87 };
      int i, sum = 0;
      for ( i=0; i<TAM; i++ ) {
          printf("m[%d]=%d\n",i,m[i]);
          sum += m[i];
      }
      printf("Sum = %d\n", sum);
}

// Otro ejemplo

#include <stdio.h>


#define ROWS 2
#define COLS 3


void main()
{
	int m[ROWS][COLS] = { {11,12,13}, {21,22,23} };
	int i, j, sum = 0;
	for ( i=0; i<ROWS; i++ ) { // Cada renglón
	  for ( j=0; j<COLS; j++ ) { // Cada columna
		printf("m[%d][%d]=%d\n",i,j,m[i][j]);
		sum += m[i][j];
	  }
	}
	printf("Sum = %d\n", sum);
}

//manejo de cadenas Sting

    * Cadena de texto: es un arreglo de characteres, e.g.  char cadena[12];

    * Excepción: Por comodidad, la constante tipo cadena es la única constante TDD que soporta C, en vez de char x[]={'H','i','\0'}; se usa char x[]="Hi";

    * Fin-de-cadena (eos): El tamaño del arreglo, i.e. cadena, debe considerar un espacio adicional al final del arreglo para colocar un eos, i.e. caracter '\0'

    * Librería Cadenas string.h: Dado que no existen operadores para arreglos y cadenas, existe la librería <string.h> para copiar, comparar y procesar cadenas en general.

Librería string.h
[Inicio] 	[Final] 		«Atrás 	Sig»
<< [1] [2] [3] [4] [5] [6] [7] [8] [9] [10] [11] [12] [13] >>  [Ref] [CSS]
Tabla 1. Algunas funciones para cadenas de la librería estándard <string.h>
Función 	Descripción
strlen(s) 	Regresa tamaño cadena, i.e. no. caracteres antes de eos
memset(s,c,n) 	Llena cadena s con n caracteres c
strlwr(s) 	Regresa cadena convertida a minúsculas
strupr(s) 	Regresa cadena convertida a MAYUSCULAS
strcpy(s1,s2) 	Copia cadena s1 en s2, e.g. s1 = s2
strdup(s) 	Regresa copia cadena s, e.g. s1 = s
strcat(s1,s2) 	Concatena cadenas e.g. s1 = s1 + s2
strcmp(s1,s2) 	Regresa cero si s1 es igual a s2,
positivo o negativo si s1 es mayor o menor
strchr(s,c) 	Busca un caracter dentro de una cadena
strstr(s1,s2) 	Busca una cadena dentro de otra cadena
sprintf(s,fmt,..) 	stdio.h: similar a printf, envia resutaldo a cadena s


//ejemplo
#include <stdio.h>  // putchar printf puts
#include <string.h> // strlen strcpy strlwr


char tec[99], cet[99]; // Globales


void ejemplo() {
	int i,j,k;
	k = strlen(tec);
	for (i=k-1,j=0; i>=0; i--,j++)
	    cet[j] = tec[i];
	cet[k]='\0';
}


void main() {
	strcpy(tec,"ITCHIHUAHUA");
	ejemplo(); //Entrada:tec, Salida:cet
	printf("%s => %s\n",tec,strlwr(cet));
}


// ejemplo
#include <stdio.h> // printf sprintf
#include <string.h> // memset strcat


#define R 4 // Rows: No. Alumnos
#define C 3 // Cols: No. Examenes


void main()
{
  int  i, j, sum, cal[R][C]={{10,7,9},{8,9,8},{7,8,9},{0,6,9}};
  char s[99], r[R][99]={"","","",""}, nom[R][9]={"Ana","Gil","Lis","Fer"};
  memset(s,'-',32); s[32]=0;
  printf("\n| Nombre | U1 | U2 | U3 | Prom |\n%s",s);
  for ( i=0; i<R; i++ ) {
    for ( j=sum=0; j<C; j++ ) { // Reporte y sumatoria
        sum += cal[i][j]; // Sumatoria calif
        sprintf(s," | %2d",cal[i][j]); // Convierte calif a cadena
        strcat(r[i],(cal[i][j]?s:" | NP")); // Anexa sig. calif
    }
    printf("\n| %5s %s | %4.1f |",nom[i],r[i],((float)sum/C)); // Reporte alum
  }
}
