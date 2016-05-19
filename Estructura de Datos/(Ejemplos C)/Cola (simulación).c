#include<conio.h>
#include<stdio.h>
#define Mensaje1 "Crear"
#define Mensaje2 "Encolar"
#define Mensaje3 "Desencolar"
#define Mensaje4 "Frente"
#define Mensaje5 "Mostrar"
#define Mensaje6 "Salir"
#define Maximo 5

void Crear();
void Encolar();
void Desencolar();
void Frente();
void Mostrar();
void Salir();

int Posicion = Maximo + 1, Cola[Maximo], I;

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
            gotoxy(1, 2); printf(Mensaje2);
            gotoxy(1, 3); printf(Mensaje3);
            gotoxy(1, 4); printf(Mensaje4);
            gotoxy(1, 5); printf(Mensaje5);
            gotoxy(1, 6); printf(Mensaje6);

            switch(Opcion)
            {
                case 1:
                    textbackground(15); textcolor(0); gotoxy(1, 1); printf(Mensaje1);
                    textbackground(0); textcolor(15);
                    break;
                case 2:
                    textbackground(15); textcolor(0); gotoxy(1, 2); printf(Mensaje2);
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
                    textbackground(15); textcolor(0); gotoxy(1, 6); printf(Mensaje6);
                    textbackground(0); textcolor(15);
                    break;
            }

            do
                Tecla = getch();
            while(Tecla != 13 && Tecla != 72 && Tecla != 80);

            if(Tecla == 72)
            {
                if(Opcion == 1)
                    Opcion = 6;
                else
                    if(Opcion > 1)
                        Opcion--;
            }
            else
                if(Tecla == 80)
                    if(Opcion == 6)
                        Opcion = 1;
                    else
                        if(Opcion < 6)
                            Opcion++;
        }while(Tecla != 13);

        switch(Opcion)
        {
            case 1:
                Crear();
                break;
            case 2:
                Encolar();
                break;
            case 3:
                Desencolar();
                break;
            case 4:
                Frente();
                break;
            case 5:
                Mostrar();
                break;
        }
    }while(Opcion != 6);

    Salir();
}

void Crear()
{
    Posicion = Maximo;

    clrscr();
    printf("Cola creada.");
    getch();
}

void Encolar()
{
    clrscr();

    if(Posicion == Maximo + 1)
        printf("Cola no creada.");
        else
            if(Posicion == Maximo - Maximo)
                printf("Cola llena.");
            else
            {
                printf("Elemento: "); scanf("%i", &Cola[Posicion]);
                clrscr();
                printf("Elemento encolado.");

                Posicion--;
            }

    getch();
}

void Desencolar()
{
    clrscr();

    if(Posicion == Maximo + 1)
        printf("Cola no creada.");
        else
            if(Posicion == Maximo)
                printf("Cola vac%ca.", 161);
            else
            {
                for(I = Maximo; I > 0; I--)
                    Cola[I] = Cola[I - 1];

                printf("Elemento desencolado.");

                Posicion++;
            }

    getch();
}

void Frente()
{
    clrscr();

    if(Posicion == Maximo + 1)
        printf("Cola no creada.");
        else
            if(Posicion == Maximo)
                printf("Cola vac%ca.", 161);
            else
                printf("%i", Cola[Maximo]);

    getch();
}

void Mostrar()
{
    clrscr();

    if(Posicion == Maximo + 1)
        printf("Cola no creada.");
        else
            if(Posicion == Maximo)
                printf("Cola vac%ca.", 161);
            else
                for(I = 1; I <= Maximo; I++)
                    printf("%i ", Cola[I]);

    getch();
}

void Salir()
{
    clrscr();
    printf("%cGracias, regrese pronto!", 173);
    getch();
}
