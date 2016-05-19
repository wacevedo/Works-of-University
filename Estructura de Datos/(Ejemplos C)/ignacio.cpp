#include <stdio.h>
#include <stdlib.h>

int main()
{
	printf("hola\n");
	
	FILE *miarchivo = NULL;
	char *nombrearchivo = "data.txt";
	miarchivo = fopen(nombrearchivo, "w");
	if (miarchivo == NULL) return -1;
	
	fprintf(miarchivo, "hola soy el archivo creado\n");
	fclose(miarchivo);
	return 0 ;
}
