program calcavan;
uses crt;

var     nomb, puest :array [1..200] of string;

//Horas trabajadas, precio por hora, descuento, sueldo, sueldo neto.
var     horas, ph, desc, sueldo, sueldoN :array [1..200] of single;

//Total impuestos, total a pagar, promedio del sueldo.
var     totalimp, totalpag, promsuel :single;

var     x, y :integer; //Contadores y variables de ciclo.

var     don :shortint; //Variable para terminar el ciclo.

Begin
clrscr;

        gotoxy(15,2); //Posici¢n en pantalla.
        Writeln('BIENVENIDO AL SISTEMA DE NOMINA AVANZADA!');
        gotoxy(15,3);
        Writeln('-----------------------------------------', '');
               Repeat
               	x := x + 1;

                Writeln('Nombre: ');
                Readln(nomb[x]);
                Writeln('');

                Writeln('Puesto: ');
		Readln(puest[x]);
                Writeln('');

                Writeln('Horas: ');
                Readln(horas[x]);

                Writeln('');
                Writeln('Precio horas: ');
                Readln(ph[x]); //Precio por hora

                Writeln('');

                sueldo[x]:= horas[x] * ph[x];
		desc[x]:= sueldo[x] * 0.29;
		sueldoN[x] := sueldo[x] - desc[x];
		totalimp := totalimp + desc[x];
		totalpag := totalpag + sueldoN[x];

                Writeln('¨Termin¢?');
                Writeln('0 para terminar, 1 para insertar otro trabajador.');
                Readln(don);
                if (don<>1) or (don<>0) then
                writeln('Error! es 0 o 1')
                else
                writeln('');

         Until (don=0);

        promsuel := totalpag / x;
	For y := 1 to x do //"To x" por la cantidad de empleados.
		Begin
                        writeln('------------------------');
                        Write('Nombre: ');
                        writeln(nomb[y]);
                        write('Puesto: ');
                        writeln(puest[y]);
                        write('Sueldo Neto: RD$');
			writeln(sueldoN[y]:4:2);
                        //4:2 = 4 cifras antes, 2 cifras despues del punto.
                        writeln('');
		end;
        writeln('------------------------');
        writeln('------------------------');
        Write('Total Pagado: RD$');
        writeln(totalpag:4:2);
        Write('Total Impuestos: RD$');
	writeln(totalimp:4:2);
        Write('Promedio Sueldo: RD$');
	writeln(promsuel:4:2);
        writeln('');
        writeln('Copyright¸ 2013, Aristides Cruz 2012-1882, Pedro Rosario 2013-0253');

Readkey;
End.

