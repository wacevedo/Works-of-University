#include<conio.h>
#include<stdio.h>
#define Mensaje1 "Crear"
#define Mensaje2 "Tama"
#define Mensaje3 "Apilar"
#define Mensaje4 "Desapilar"
#define Mensaje5 "Cima"
#define Mensaje6 "Vac"
#define Mensaje7 "Mostrar"
#define Mensaje8 "Salir"
#define Maximo 5

void Crear();
void Tamanio();
void Apilar();
void Desapilar();
void Cima();
void Vacia();
void Mostrar();
void Salir();

int Posicion = Maximo + 1, Pila[Maximo], I;

void main()
{
    int Opcion = 1, Tecla;

    do
    {
        do
        {
            clrscr();
            textcolor(15);
            gotoxy(1, 1); printf(Mensaje1);
            gotoxy(1, 2); printf(Mensaje2 "%co", 164);
            gotoxy(1, 3); printf(Mensaje3);
            gotoxy(1, 4); printf(Mensaje4);
            gotoxy(1, 5); printf(Mensaje5);
            gotoxy(1, 6); printf(Mensaje6 "%ca", 161);
            gotoxy(1, 7); printf(Mensaje7);
            gotoxy(1, 8); printf(Mensaje8);

            switch(Opcion)
            {
                case 1:
                    textbackground(15); textcolor(0); gotoxy(1, 1); printf(Mensaje1);
                    textbackground(0); textcolor(15);
                    break;
                case 2:
                    textbackground(15); textcolor(0); gotoxy(1, 2); printf(Mensaje2 "%co", 164);
                    textbackground(0); textcolor(15);
                    break;
                case 3:
                    textbackground(15); textcolor(0); gotoxy(1, 3); printf(Mensaje3);
                    textbackground(0); textcolor(15);
                    break;
                case 4:
                    textbackground(15); textcolor(0); gotoxy(1, 4); printf(Mensaje4);
                    textbackground(0); textcolor(15);
                    break;
                case 5:
                    textbackground(15); textcolor(0); gotoxy(1, 5); printf(Mensaje5);
                    textbackground(0); textcolor(15);
                    break;
                case 6:
                    textbackground(15); textcolor(0); gotoxy(1, 6); printf(Mensaje6 "%ca", 161);
                    textbackground(0); textcolor(15);
                    break;
                case 7:
                    textbackground(15); textcolor(0); gotoxy(1, 7); printf(Mensaje7);
                    textbackground(0); textcolor(15);
                    break;
                case 8:
                    textbackground(15); textcolor(0); gotoxy(1, 8); printf(Mensaje8);
                    textbackground(0); textcolor(15);
            }

            do
                Tecla = getch();
            while(Tecla != 13 && Tecla != 72 && Tecla != 80);

            if(Tecla == 72)
            {
                if(Opcion == 1)
                    Opcion = 8;
                else
                    if(Opcion > 1)
                        Opcion--;
            }
            else
                if(Tecla == 80)
                    if(Opcion == 8)
                        Opcion = 1;
                    else
                        if(Opcion < 8)
                            Opcion++;
        }while(Tecla != 13);

        switch(Opcion)
        {
            case 1:
                Crear();
                break;
            case 2:
                Tamanio();
                break;
            case 3:
                Apilar();
                break;
            case 4:
                Desapilar();
                break;
            case 5:
                Cima();
                break;
            case 6:
                Vacia();
                break;
            case 7:
                Mostrar();
                break;
        }
    }while(Opcion != 8);

    Salir();
}

void Crear()
{
    Posicion = Maximo;

    clrscr();
    printf("Pila creada.");
    getch();
}

void Tamanio()
{
    clrscr();

    if(Posicion == Maximo + 1)
        printf("Pila no creada.");
        else
            printf("%i", Maximo - Posicion);

    getch();
}

void Apilar()
{
    clrscr();

    if(Posicion == Maximo + 1)
        printf("Pila no creada.");
        else
            if(Posicion == Maximo - Maximo)
                printf("Pila llena.");
            else
            {
                printf("Elemento: "); scanf("%i", &Pila[Posicion]);
                clrscr();
                printf("Elemento apilado.");

                Posicion--;
            }

    getch();
}

void Desapilar()
{
    clrscr();

    if(Posicion == Maximo + 1)
        printf("Pila no creada.");
        else
            if(Posicion == Maximo)
                printf("Pila vac%ca.", 161);
            else
            {
                Posicion++;
                Pila[Posicion] = -999999999;

                printf("Elemento desapilado.");
            }

    getch();
}

void Cima()
{
    clrscr();

    if(Posicion == Maximo + 1)
        printf("Pila no creada.");
        else
            if(Posicion == Maximo)
                printf("Pila vac%ca.", 161);
            else
                printf("%i", Pila[Posicion + 1]);

    getch();
}

void Vacia()
{
    clrscr();

    if(Posicion == Maximo + 1)
        printf("Pila no creada.");
    else
        if(Posicion == Maximo)
            printf("Cierto.");
        else
            printf("Falso.");

    getch();
}

void Mostrar()
{
    clrscr();

    if(Posicion == Maximo + 1)
        printf("Pila no creada.");
        else
            if(Posicion == Maximo)
                printf("Pila vac%ca.", 161);
            else
                for(I = 1; I <= Maximo; I++)
                {
                    if(Pila[I] == -999999999)
                    {
                        gotoxy(1, I); printf("0");
                    }
                    else
                    {
                        gotoxy(1, I); printf("%i", Pila[I]);
                    }
                }

    getch();
}

void Salir()
{
    clrscr();
    printf("%cGracias, regrese pronto!", 173);
    getch();
}
