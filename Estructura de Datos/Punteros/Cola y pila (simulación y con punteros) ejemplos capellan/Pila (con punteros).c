#include<conio.h>
#include<stdbool.h>
#include<stdio.h>
#include<stdlib.h>
#define Mensaje1 "Crear"
#define Mensaje2 "Tama"
#define Mensaje3 "Apilar"
#define Mensaje4 "Desapilar"
#define Mensaje5 "Cima"
#define Mensaje6 "Vac"
#define Mensaje7 "Mostrar"
#define Mensaje8 "Salir"

struct Estudiante
{
    struct Estudiante *Anterior;
    char Nombre[20], Asignatura[20], Letra;
    int Matricula, Calificacion;
};

struct Estudiante *Auxiliar = NULL;
struct Estudiante *Ultimo = NULL;
bool Control_Crear = false;
int Tamanio = 0;

void Crear();
void Tamagnio();
void Apilar();
void Desapilar();
void Cima();
void Vacia();
void Mostrar();
void Salir();

void main()
{
    int Opcion = 1, Tecla;

    do
    {
        do
        {
            clrscr();
            textcolor(14); gotoxy(38, 1); printf("Pila", 162);
            textcolor(12); gotoxy(59, 25); printf("Ariel D%caz (2012-0134)", 161); gotoxy(1, 1);
            textcolor(15);
            gotoxy(1, 3); printf(Mensaje1);
            gotoxy(1, 4); printf(Mensaje2 "%co", 164);
            gotoxy(1, 5); printf(Mensaje3);
            gotoxy(1, 6); printf(Mensaje4);
            gotoxy(1, 7); printf(Mensaje5);
            gotoxy(1, 8); printf(Mensaje6 "%ca", 161);
            gotoxy(1, 9); printf(Mensaje7);
            gotoxy(1, 10); printf(Mensaje8);

            switch(Opcion)
            {
                case 1:
                    textbackground(15); textcolor(0); gotoxy(1, 3); printf(Mensaje1);
                    textbackground(0); textcolor(15);
                    break;
                case 2:
                    textbackground(15); textcolor(0); gotoxy(1, 4); printf(Mensaje2 "%co", 164);
                    textbackground(0); textcolor(15);
                    break;
                case 3:
                    textbackground(15); textcolor(0); gotoxy(1, 5); printf(Mensaje3);
                    textbackground(0); textcolor(15);
                    break;
                case 4:
                    textbackground(15); textcolor(0); gotoxy(1, 6); printf(Mensaje4);
                    textbackground(0); textcolor(15);
                    break;
                case 5:
                    textbackground(15); textcolor(0); gotoxy(1, 7); printf(Mensaje5);
                    textbackground(0); textcolor(15);
                    break;
                case 6:
                    textbackground(15); textcolor(0); gotoxy(1, 8); printf(Mensaje6 "%ca", 161);
                    textbackground(0); textcolor(15);
                    break;
                case 7:
                    textbackground(15); textcolor(0); gotoxy(1, 9); printf(Mensaje7);
                    textbackground(0); textcolor(15);
                    break;
                case 8:
                    textbackground(15); textcolor(0); gotoxy(1, 10); printf(Mensaje8);
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
                Tamagnio();
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
    if(!Control_Crear)
    {
        clrscr();
        Control_Crear = true;
        textcolor(14); gotoxy(38, 1); printf("Pila", 162);
        textcolor(12); gotoxy(59, 25); printf("Ariel D%caz (2012-0134)", 161); gotoxy(1, 1);
        textcolor(10); gotoxy(1, 3); printf("La pila fue creada.");
        getch();
    }
    else
    {
        clrscr();
        textcolor(14); gotoxy(38, 1); printf("Pila", 162);
        textcolor(12); gotoxy(59, 25); printf("Ariel D%caz (2012-0134)", 161); gotoxy(1, 1);
        textcolor(12); gotoxy(1, 3); printf("La pila est%c creada.", 160);
        getch();
    }
}

void Tamagnio()
{
    if(Control_Crear)
    {
        clrscr();
        textcolor(14); gotoxy(38, 1); printf("Pila", 162);
        textcolor(12); gotoxy(59, 25); printf("Ariel D%caz (2012-0134)", 161); gotoxy(1, 1);
        textcolor(15); gotoxy(1, 3); printf("Tama%co: ", 164); textcolor(14); printf("%i", Tamanio);
        getch();
    }
    else
    {
        clrscr();
        textcolor(14); gotoxy(38, 1); printf("Pila", 162);
        textcolor(12); gotoxy(59, 25); printf("Ariel D%caz (2012-0134)", 161); gotoxy(1, 1);
        textcolor(14); gotoxy(1, 3); printf("La pila no est%c creada.", 160);
        getch();
    }
}

void Apilar()
{
    if(Control_Crear)
    {
        clrscr();
        Auxiliar = (struct Estudiante*) malloc(sizeof(struct Estudiante));
        textcolor(14); gotoxy(38, 1); printf("Pila", 162);
        textcolor(12); gotoxy(59, 25); printf("Ariel D%caz (2012-0134)", 161); gotoxy(1, 1);
        gotoxy(1, 3);
        textcolor(15); printf("Matr%ccula...: ", 161); textcolor(14); scanf("%i", &Auxiliar -> Matricula);
        textcolor(15); printf("Nombre......: "); textcolor(14); scanf("%s", &Auxiliar -> Nombre);
        textcolor(15); printf("Asignatura..: "); textcolor(14); scanf("%s", &Auxiliar -> Asignatura);

        do
        {
            textcolor(15); gotoxy(1, 6); printf("Calificaci%cn: ", 162); textcolor(14); scanf("%i", &Auxiliar -> Calificacion);

            if(Auxiliar -> Calificacion < 0 || Auxiliar -> Calificacion > 100)
            {
                gotoxy(1, 6); printf("                                                                                ");
                textcolor(12); gotoxy(1, 6); printf("Calificaci%cn inv%clida.", 162, 160); getch();
                gotoxy(1, 6); printf("                                                                                ");
            }
        }while(Auxiliar -> Calificacion < 0 || Auxiliar -> Calificacion > 100);

        if(Auxiliar -> Calificacion >= 90)
            Auxiliar -> Letra = 'A';
        else
            if(Auxiliar -> Calificacion >= 80)
                Auxiliar -> Letra = 'B';
            else
                if(Auxiliar -> Calificacion >= 70)
                    Auxiliar -> Letra = 'C';
                else
                    if(Auxiliar -> Calificacion >= 60)
                        Auxiliar -> Letra = 'D';
                    else
                        Auxiliar -> Letra = 'F';

        if(Ultimo == NULL)
        {
            Ultimo = Auxiliar;
            Auxiliar -> Anterior = NULL;
        }
        else
        {
            Auxiliar -> Anterior = Ultimo;
            Ultimo = Auxiliar;
        }

        clrscr();
        textcolor(14); gotoxy(38, 1); printf("Pila", 162);
        textcolor(12); gotoxy(59, 25); printf("Ariel D%caz (2012-0134)", 161); gotoxy(1, 1);
        textcolor(10); gotoxy(1, 3); printf("Estudiante apilado.");
        Tamanio++;
        getch();
    }
    else
    {
        clrscr();
        textcolor(14); gotoxy(38, 1); printf("Pila", 162);
        textcolor(12); gotoxy(59, 25); printf("Ariel D%caz (2012-0134)", 161); gotoxy(1, 1);
        textcolor(14); gotoxy(1, 3); printf("La pila no est%c creada.", 160);
        getch();
    }
}

void Desapilar()
{
    if(Control_Crear)
    {
        if(Ultimo == NULL)
        {
            clrscr();
            textcolor(14); gotoxy(38, 1); printf("Pila", 162);
            textcolor(12); gotoxy(59, 25); printf("Ariel D%caz (2012-0134)", 161); gotoxy(1, 1);
            textcolor(14); gotoxy(1, 3); printf("La pila est%c vac%ca.", 160, 161);
            getch();
            return;
        }

        Auxiliar = Ultimo;
        Ultimo = Ultimo -> Anterior;
        free(Auxiliar);
        clrscr();
        textcolor(14); gotoxy(38, 1); printf("Pila", 162);
        textcolor(12); gotoxy(59, 25); printf("Ariel D%caz (2012-0134)", 161); gotoxy(1, 1);
        textcolor(10); gotoxy(1, 3); printf("Estudiante desapilado.");
        Tamanio--;
        getch();
    }
    else
    {
        clrscr();
        textcolor(14); gotoxy(38, 1); printf("Pila", 162);
        textcolor(12); gotoxy(59, 25); printf("Ariel D%caz (2012-0134)", 161); gotoxy(1, 1);
        textcolor(14); gotoxy(1, 3); printf("La pila no est%c creada.", 160);
        getch();
    }
}

void Cima()
{
    if(Control_Crear)
    {
        clrscr();

        if(Ultimo == NULL)
        {
            clrscr();
            textcolor(14); gotoxy(38, 1); printf("Pila", 162);
            textcolor(12); gotoxy(59, 25); printf("Ariel D%caz (2012-0134)", 161); gotoxy(1, 1);
            textcolor(14); gotoxy(1, 3); printf("La pila est%c vac%ca.", 160, 161);
            getch();
            return;
        }

        Auxiliar = Ultimo;
        textcolor(14); gotoxy(38, 1); printf("Pila", 162);
        textcolor(12); gotoxy(59, 25); printf("Ariel D%caz (2012-0134)", 161); gotoxy(1, 1);
        gotoxy(1, 3);
        textcolor(15); printf("Matr%ccula...: ", 161); textcolor(14); printf("%i\n", Auxiliar -> Matricula);
        textcolor(15); printf("Nombre......: "); textcolor(14); printf("%s\n", Auxiliar -> Nombre);
        textcolor(15); printf("Asignatura..: "); textcolor(14); printf("%s\n", Auxiliar -> Asignatura);
        textcolor(15); printf("Calificaci%cn: ", 162); textcolor(14); printf("%i\n", Auxiliar -> Calificacion);
        textcolor(15); printf("Letra.......: "); textcolor(14); printf("%c\n\n", Auxiliar -> Letra);
        getch();
    }
    else
    {
        clrscr();
        textcolor(14); gotoxy(38, 1); printf("Pila", 162);
        textcolor(12); gotoxy(59, 25); printf("Ariel D%caz (2012-0134)", 161); gotoxy(1, 1);
        textcolor(14); gotoxy(1, 3); printf("La pila no est%c creada.", 160);
        getch();
    }
}

void Vacia()
{
    if(Control_Crear)
    {
        if(Ultimo == NULL)
        {
            clrscr();
            textcolor(14); gotoxy(38, 1); printf("Pila", 162);
            textcolor(12); gotoxy(59, 25); printf("Ariel D%caz (2012-0134)", 161); gotoxy(1, 1);
            textcolor(10); gotoxy(1, 3); printf("Cierto.");
            getch();
            return;
        }
        else
        {
            clrscr();
            textcolor(14); gotoxy(38, 1); printf("Pila", 162);
            textcolor(12); gotoxy(59, 25); printf("Ariel D%caz (2012-0134)", 161); gotoxy(1, 1);
            textcolor(12); gotoxy(1, 3); printf("Falso.");
            getch();
            return;
        }
    }
    else
    {
        clrscr();
        textcolor(14); gotoxy(38, 1); printf("Pila", 162);
        textcolor(12); gotoxy(59, 25); printf("Ariel D%caz (2012-0134)", 161); gotoxy(1, 1);
        textcolor(14); gotoxy(1, 3); printf("La pila no est%c creada.", 160);
        getch();
    }
}

void Mostrar()
{
    if(Control_Crear)
    {
        clrscr();

        if(Ultimo == NULL)
        {
            clrscr();
            textcolor(14); gotoxy(38, 1); printf("Pila", 162);
            textcolor(12); gotoxy(59, 25); printf("Ariel D%caz (2012-0134)", 161); gotoxy(1, 1);
            textcolor(14); gotoxy(1, 3); printf("La pila est%c vac%ca.", 160, 161);
            getch();
            return;
        }

        Auxiliar = Ultimo;

        textcolor(14); gotoxy(38, 1); printf("Pila", 162);
        textcolor(12); gotoxy(59, 25); printf("Ariel D%caz (2012-0134)", 161); gotoxy(1, 1);
        gotoxy(1, 3);

        while(Auxiliar != NULL)
        {

            textcolor(15); printf("Matr%ccula...: ", 161); textcolor(14); printf("%i\n", Auxiliar -> Matricula);
            textcolor(15); printf("Nombre......: "); textcolor(14); printf("%s\n", Auxiliar -> Nombre);
            textcolor(15); printf("Asignatura..: "); textcolor(14); printf("%s\n", Auxiliar -> Asignatura);
            textcolor(15); printf("Calificaci%cn: ", 162); textcolor(14); printf("%i\n", Auxiliar -> Calificacion);
            textcolor(15); printf("Letra.......: "); textcolor(14); printf("%c\n\n", Auxiliar -> Letra);
            Auxiliar = Auxiliar -> Anterior;
        }

        getch();
    }
    else
    {
        clrscr();
        textcolor(14); gotoxy(38, 1); printf("Pila", 162);
        textcolor(12); gotoxy(59, 25); printf("Ariel D%caz (2012-0134)", 161); gotoxy(1, 1);
        textcolor(14); gotoxy(1, 3); printf("La pila no est%c creada.", 160);
        getch();
    }
}

void Salir()
{
    clrscr();
    textcolor(14); gotoxy(38, 1); printf("Pila", 162);
    textcolor(12); gotoxy(59, 25); printf("Ariel D%caz (2012-0134)", 161); gotoxy(1, 1);
    textcolor(10); gotoxy(1, 3); printf("%cGracias, regrese pronto!", 173);
    getch();
}
