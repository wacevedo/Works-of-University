//Ejemplo de implementacion de pilas

#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

  /* declaracion */
struct tpila{
  int clave;
  char nombre[30]; 
  struct tpila *sig;
};
   /* prototipos e implementacion */

void crear(struct tpila **pila);
int vacia(struct tpila *pila);
void apilar(struct tpila *pila, int elem, char nomb[30]);
void desapilar(struct tpila *pila, int *elem);
void mostrar(struct tpila *pila);

void crear(struct tpila **pila)
{  *pila = (struct tpila *) malloc(sizeof(struct tpila));
  (*pila)->sig = NULL;
}

int vacia(struct tpila *pila){
  return (pila->sig == NULL);
}

void apilar(struct tpila *pila, int elem){
  struct tpila *nuevo;

  nuevo = (struct tpila *) malloc(sizeof(struct tpila));
  nuevo->clave = elem;
  nuevo->sig = pila->sig;
  pila->sig = nuevo;
}

void desapilar(struct tpila *pila, int *elem){
  struct tpila *aux;

  aux = pila->sig;
  *elem = aux->clave;
  pila->sig = aux->sig;
  free(aux);
}

void mostrar(struct tpila *pila)
{
 struct tpila *aux;

 while (pila!=NULL)
   {
     printf("clave: %d \n",pila->clave);
     aux=pila->sig;
     pila->sig= aux->sig;
     free(aux);
   }
}

   /* programa de prueba */
int main(void)
{
  struct tpila *pila;
  int elem;

  clrscr();
  crear(&pila);
  if (vacia(pila)) printf("nPila vacia!");
  getch();
  apilar(pila, 1);
  mostrar(pila);
  getch();
  desapilar(pila, &elem);
  mostrar(pila);
  getch();
  return 0;
}