#include<stdio.h>
#include<conio.h>
void main()
{
 FILE *fichero;
 char cadena[4000];

 if((fichero=fopen("datos.txt","a"))!=NULL) //w sobre escribe,//a anade nuevos datos sin eliminar los enteriores
 {
  printf("El fichero ejemplo.txt se ha abierto correctamente. \n");
  printf("Introdusca el mensaje a grabar: \n\n");

  fgets(cadena,4000,stdin);//captura el mensaje
  fputs(cadena,fichero);//graba el mensaje

  printf("\n\nMensaje grabado Correctamente..");

  fclose(fichero);
 }
 else
 {
  printf("Error al abrir fichero ejemplo.txt");
 }
 getch();
}
