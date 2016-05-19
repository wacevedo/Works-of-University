#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <conio.h>
#include <string.h>

void main()
{float precio, subtotal,total=0;
  int num=0,cantidad=0,deseo=1,y,np;
  char producto[20];
  do
            {
  clrscr();
  printf(" Willson Neris Acevedo Sanchez\n");
  printf(" 2012-1993                                      <0 en No. = sacar total>\n");
  printf("\n");
  printf(" Programa Factura\n");
  printf("\n");
  

  
            
            num++;              
              
                
                printf("SUPERMERCADO LA SOLUCION\n");  
                printf("No. Factura: %d\n", num);
                gotoxy(1,9);
                printf("No.");
                gotoxy(10,9);
                printf("producto:");
                gotoxy(30, 9);
                printf("cantidad:");
                gotoxy(44, 9);
                printf("precio:");
                gotoxy(55, 9);
                printf("SubTotal:");
                y=10;
            
                

                
               do{
                   gotoxy(1, y);
                   scanf("%d",&np);
                   if (np == 0) break;
                   gotoxy(10,y);
                   scanf("%s",&producto);                   
                   gotoxy(30, y);                   
                   scanf("%d",&cantidad); 
                   gotoxy(44, y);
                   scanf("%f",&precio);
                   subtotal = cantidad * precio;
                   gotoxy(55, y);
                   printf("$ %4.2f",subtotal);
                   total = total + subtotal;
                   y++;
               }while (np!=0);
               printf("\n");
               printf("----------------------------------------\n");
   


               printf("El total de la factura es: %4.2f\n",total);
               printf("\n");
               total =0;


                printf("Desea continuar? <1= si  ; 0 = no> :");
                scanf("%d",&deseo);
            } while (deseo == 1);
}            
