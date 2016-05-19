#include <stdio.h>


main()
{

   
   FILE*fichero;
   char mensaje[400];
   if ((fichero=fopen("dmm.txt","r")) !=NULL)
   {
   	printf("fichero dmm.txt abierto correctamente  \n");
   	printf("\n");
   	while(!feof (fichero))
   	{
	    fgets(mensaje,4000,fichero);
   	    if(feof(fichero))
   	      {
   		   printf("fin de fichero");
   	      }
   	    else
   	    fputs(mensaje,stdout);
    }
   	fclose(fichero);
   	
   }
    
   else 
    printf("Error al abrir dmm.txt");
    
 }
