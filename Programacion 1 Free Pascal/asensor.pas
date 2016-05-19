program axensor;
uses crt;
var a,b,y :integer;
begin

clrscr;
 textcolor(white);
 gotoxy(20,2); //Posici¢n en pantalla.
        Writeln('BIENVENIDO AL SISTEMA DE ASCENSOR!');
        gotoxy(20,3);
        Writeln('----------------------------------', '');

 a:=a+1;
 repeat

   y:=y+1;

   textcolor(white);

 Write(' ');
 writeln('Numero de piso a acceder:');
 readln(b);

 //modulo de validacion
 textcolor(red);
 if (b>4) then
  begin
   clrscr;
   gotoxy(20,13);
   write('ERROR! el edificio solo tiene 4 pisos.');
  end
 else
 if (a=1) and (b=1) then
  begin
   clrscr;
   gotoxy(20,13);
   write('ERROR! usted esta en el primer piso.');
  end
 else
 if (a=2) and (b=2) then
  begin
   clrscr;
   gotoxy(20,13);
   write('ERROR! usted esta en el segundo piso.');
   end
 else
 if (a=3) and (b=3) then
  begin
   clrscr;
   gotoxy(20,13);
  write('ERROR! usted esta en el tercer piso.');
  end
 else
 if (a=4) and (b=4) then
  begin
   clrscr;
   gotoxy(20,13);
   write('ERROR! usted esta en el cuarto piso.');
  end
 else
 //aqui termina la validacion
 textcolor(white);
 if (a=1) and (b=2) then
 begin
 writeln('usted esta en el segundo piso.');
 gotoxy(30,4);
Writeln('                            ___________                 ');
gotoxy(30,5);
Writeln('                           /  |     |  \                ');
gotoxy(30,6);
Writeln('                          |   |     |   |               ');
gotoxy(30,7);
Writeln('                          |   |     |   |               ');
gotoxy(30,8);
Writeln('                          |   |     |   |               ');
gotoxy(30,9);
Writeln('                          |   |     |   |               ');
gotoxy(30,10);
Writeln('                          |=============|               ');
gotoxy(30,11);
Writeln('                          |   |     |   |               ');
gotoxy(30,12);
Writeln('                          |   |     |   |               ');
gotoxy(30,13);
Writeln('                          |   |     |   |               ');
gotoxy(30,14);
Writeln('                          |   |     |   |               ');
gotoxy(30,15);
Writeln('                          |=============|               ');
gotoxy(30,16);
Writeln('                          |   |     |   |               ');
gotoxy(30,17);
Writeln('                          |   |  _  |   |               ');
gotoxy(30,18);
Writeln('                          |   | | | |   |               ');
gotoxy(30,19);
Writeln('                          |   | |_| |   |               ');
gotoxy(30,20);
Writeln('                          |=============|               ');
gotoxy(30,21);
Writeln('                          |   |     |   |               ');
gotoxy(30,22);
Writeln('                          |   |     |   |               ');
gotoxy(30,23);
  Write('                          |   |     |   |               ');
gotoxy(30,24);
  Write('                          |___|_____|___|               ');
  a:=b
 //aqui va un gotoxy con x contante, hacer que el dibujo baje haciendo un contador que le sume a la variable y
 end;

  if (a=1) and (b=3) then
begin
 writeln('usted esta en el tercer piso.');
 gotoxy(30,4);
Writeln('                            ___________                 ');
gotoxy(30,5);
Writeln('                           /  |     |  \                ');
gotoxy(30,6);
Writeln('                          |   |     |   |               ');
gotoxy(30,7);
Writeln('                          |   |     |   |               ');
gotoxy(30,8);
Writeln('                          |   |     |   |               ');
gotoxy(30,9);
Writeln('                          |   |     |   |               ');
gotoxy(30,10);
Writeln('                          |=============|               ');
gotoxy(30,11);
Writeln('                          |   |     |   |               ');
gotoxy(30,12);
Writeln('                          |   |  _  |   |               ');
gotoxy(30,13);
Writeln('                          |   | | | |   |               ');
gotoxy(30,14);
Writeln('                          |   | |_| |   |               ');
gotoxy(30,15);
Writeln('                          |=============|               ');
gotoxy(30,16);
Writeln('                          |   |     |   |               ');
gotoxy(30,17);
Writeln('                          |   |     |   |               ');
gotoxy(30,18);
Writeln('                          |   |     |   |               ');
gotoxy(30,19);
Writeln('                          |   |     |   |               ');
gotoxy(30,20);
Writeln('                          |=============|               ');
gotoxy(30,21);
Writeln('                          |   |     |   |               ');
gotoxy(30,22);
Writeln('                          |   |     |   |               ');
gotoxy(30,23);
  Write('                          |   |     |   |               ');
gotoxy(30,24);
  Write('                          |___|_____|___|               ');
  a:=b
 //aqui va un gotoxy con x contante
end;

if (a=1) and (b=4) then
 begin
  writeln('usted esta en el cuarto piso.');
  gotoxy(30,4);
Writeln('                            ___________                 ');
gotoxy(30,5);
Writeln('                           /  |     |  \                ');
gotoxy(30,6);
Writeln('                          |   |     |   |               ');
gotoxy(30,7);
Writeln('                          |   |  _  |   |               ');
gotoxy(30,8);
Writeln('                          |   | | | |   |               ');
gotoxy(30,9);
Writeln('                          |   | |_| |   |               ');
gotoxy(30,10);
Writeln('                          |=============|               ');
gotoxy(30,11);
Writeln('                          |   |     |   |               ');
gotoxy(30,12);
Writeln('                          |   |     |   |               ');
gotoxy(30,13);
Writeln('                          |   |     |   |               ');
gotoxy(30,14);
Writeln('                          |   |     |   |               ');
gotoxy(30,15);
Writeln('                          |=============|               ');
gotoxy(30,16);
Writeln('                          |   |     |   |               ');
gotoxy(30,17);
Writeln('                          |   |     |   |               ');
gotoxy(30,18);
Writeln('                          |   |     |   |               ');
gotoxy(30,19);
Writeln('                          |   |     |   |               ');
gotoxy(30,20);
Writeln('                          |=============|               ');
gotoxy(30,21);
Writeln('                          |   |     |   |               ');
gotoxy(30,22);
Writeln('                          |   |     |   |               ');
gotoxy(30,23);
  Write('                          |   |     |   |               ');
gotoxy(30,24);
  Write('                          |___|_____|___|               ');
   a:=b
 //aqui va un gotoxy con x contante
 end;

if (a=2) and (b=1) then
 begin
  writeln('usted esta en el primer piso.');
  gotoxy(30,4);
Writeln('                            ___________                 ');
gotoxy(30,5);
Writeln('                           /  |     |  \                ');
gotoxy(30,6);
Writeln('                          |   |     |   |               ');
gotoxy(30,7);
Writeln('                          |   |     |   |               ');
gotoxy(30,8);
Writeln('                          |   |     |   |               ');
gotoxy(30,9);
Writeln('                          |   |     |   |               ');
gotoxy(30,10);
Writeln('                          |=============|               ');
gotoxy(30,11);
Writeln('                          |   |     |   |               ');
gotoxy(30,12);
Writeln('                          |   |     |   |               ');
gotoxy(30,13);
Writeln('                          |   |     |   |               ');
gotoxy(30,14);
Writeln('                          |   |     |   |               ');
gotoxy(30,15);
Writeln('                          |=============|               ');
gotoxy(30,16);
Writeln('                          |   |     |   |               ');
gotoxy(30,17);
Writeln('                          |   |     |   |               ');
gotoxy(30,18);
Writeln('                          |   |     |   |               ');
gotoxy(30,19);
Writeln('                          |   |     |   |               ');
gotoxy(30,20);
Writeln('                          |=============|               ');
gotoxy(30,21);
Writeln('                          |   |     |   |               ');
gotoxy(30,22);
Writeln('                          |   |  _  |   |               ');
gotoxy(30,23);
  Write('                          |   | | | |   |               ');
gotoxy(30,24);
  Write('                          |___|_|_|_|___|               ');
   a:=b
 //aqui va un gotoxy con x contante
 end;


 if (a=2) and (b=3) then
  begin
   writeln('usted esta en el tercer piso.');
   gotoxy(30,4);
Writeln('                            ___________                 ');
gotoxy(30,5);
Writeln('                           /  |     |  \                ');
gotoxy(30,6);
Writeln('                          |   |     |   |               ');
gotoxy(30,7);
Writeln('                          |   |     |   |               ');
gotoxy(30,8);
Writeln('                          |   |     |   |               ');
gotoxy(30,9);
Writeln('                          |   |     |   |               ');
gotoxy(30,10);
Writeln('                          |=============|               ');
gotoxy(30,11);
Writeln('                          |   |     |   |               ');
gotoxy(30,12);
Writeln('                          |   |  _  |   |               ');
gotoxy(30,13);
Writeln('                          |   | | | |   |               ');
gotoxy(30,14);
Writeln('                          |   | |_| |   |               ');
gotoxy(30,15);
Writeln('                          |=============|               ');
gotoxy(30,16);
Writeln('                          |   |     |   |               ');
gotoxy(30,17);
Writeln('                          |   |     |   |               ');
gotoxy(30,18);
Writeln('                          |   |     |   |               ');
gotoxy(30,19);
Writeln('                          |   |     |   |               ');
gotoxy(30,20);
Writeln('                          |=============|               ');
gotoxy(30,21);
Writeln('                          |   |     |   |               ');
gotoxy(30,22);
Writeln('                          |   |     |   |               ');
gotoxy(30,23);
  Write('                          |   |     |   |               ');
gotoxy(30,24);
  Write('                          |___|_____|___|               ');
  a:=b
 //aqui va un gotoxy con x contante
 end;

if (a=2) and (b=4) then
 begin
  writeln('usted esta en el cuarto piso.');
  gotoxy(30,4);
Writeln('                            ___________                 ');
gotoxy(30,5);
Writeln('                           /  |     |  \                ');
gotoxy(30,6);
Writeln('                          |   |     |   |               ');
gotoxy(30,7);
Writeln('                          |   |  _  |   |               ');
gotoxy(30,8);
Writeln('                          |   | | | |   |               ');
gotoxy(30,9);
Writeln('                          |   | |_| |   |               ');
gotoxy(30,10);
Writeln('                          |=============|               ');
gotoxy(30,11);
Writeln('                          |   |     |   |               ');
gotoxy(30,12);
Writeln('                          |   |     |   |               ');
gotoxy(30,13);
Writeln('                          |   |     |   |               ');
gotoxy(30,14);
Writeln('                          |   |     |   |               ');
gotoxy(30,15);
Writeln('                          |=============|               ');
gotoxy(30,16);
Writeln('                          |   |     |   |               ');
gotoxy(30,17);
Writeln('                          |   |     |   |               ');
gotoxy(30,18);
Writeln('                          |   |     |   |               ');
gotoxy(30,19);
Writeln('                          |   |     |   |               ');
gotoxy(30,20);
Writeln('                          |=============|               ');
gotoxy(30,21);
Writeln('                          |   |     |   |               ');
gotoxy(30,22);
Writeln('                          |   |     |   |               ');
gotoxy(30,23);
  Write('                          |   |     |   |               ');
gotoxy(30,24);
  Write('                          |___|_____|___|               ');
   a:=b
 //aqui va un gotoxy con x contante
 end;

if (a=3) and (b=1) then
 begin
  writeln('usted esta en el segundo piso.');
  gotoxy(30,4);
Writeln('                            ___________                 ');
gotoxy(30,5);
Writeln('                           /  |     |  \                ');
gotoxy(30,6);
Writeln('                          |   |     |   |               ');
gotoxy(30,7);
Writeln('                          |   |     |   |               ');
gotoxy(30,8);
Writeln('                          |   |     |   |               ');
gotoxy(30,9);
Writeln('                          |   |     |   |               ');
gotoxy(30,10);
Writeln('                          |=============|               ');
gotoxy(30,11);
Writeln('                          |   |     |   |               ');
gotoxy(30,12);
Writeln('                          |   |     |   |               ');
gotoxy(30,13);
Writeln('                          |   |     |   |               ');
gotoxy(30,14);
Writeln('                          |   |     |   |               ');
gotoxy(30,15);
Writeln('                          |=============|               ');
gotoxy(30,16);
Writeln('                          |   |     |   |               ');
gotoxy(30,17);
Writeln('                          |   |     |   |               ');
gotoxy(30,18);
Writeln('                          |   |     |   |               ');
gotoxy(30,19);
Writeln('                          |   |     |   |               ');
gotoxy(30,20);
Writeln('                          |=============|               ');
gotoxy(30,21);
Writeln('                          |   |     |   |               ');
gotoxy(30,22);
Writeln('                          |   |  _  |   |               ');
gotoxy(30,23);
  Write('                          |   | | | |   |               ');
gotoxy(30,24);
  Write('                          |___|_|_|_|___|               ');
   a:=b
 //aqui va un gotoxy con x contante
 end;

if (a=3) and (b=2) then
 begin
  writeln('usted esta en el segundo piso.');
  gotoxy(30,4);
Writeln('                            ___________                 ');
gotoxy(30,5);
Writeln('                           /  |     |  \                ');
gotoxy(30,6);
Writeln('                          |   |     |   |               ');
gotoxy(30,7);
Writeln('                          |   |     |   |               ');
gotoxy(30,8);
Writeln('                          |   |     |   |               ');
gotoxy(30,9);
Writeln('                          |   |     |   |               ');
gotoxy(30,10);
Writeln('                          |=============|               ');
gotoxy(30,11);
Writeln('                          |   |     |   |               ');
gotoxy(30,12);
Writeln('                          |   |     |   |               ');
gotoxy(30,13);
Writeln('                          |   |     |   |               ');
gotoxy(30,14);
Writeln('                          |   |     |   |               ');
gotoxy(30,15);
Writeln('                          |=============|               ');
gotoxy(30,16);
Writeln('                          |   |     |   |               ');
gotoxy(30,17);
Writeln('                          |   |  _  |   |               ');
gotoxy(30,18);
Writeln('                          |   | | | |   |               ');
gotoxy(30,19);
Writeln('                          |   | |_| |   |               ');
gotoxy(30,20);
Writeln('                          |=============|               ');
gotoxy(30,21);
Writeln('                          |   |     |   |               ');
gotoxy(30,22);
Writeln('                          |   |     |   |               ');
gotoxy(30,23);
  Write('                          |   |     |   |               ');
gotoxy(30,24);
  Write('                          |___|_____|___|               ');
   a:=b
 //aqui va un gotoxy con x contante
 end;

if (a=3) and (b=4) then
 begin
  writeln('usted esta en el cuarto piso.');
  gotoxy(30,4);
Writeln('                            ___________                 ');
gotoxy(30,5);
Writeln('                           /  |     |  \                ');
gotoxy(30,6);
Writeln('                          |   |     |   |               ');
gotoxy(30,7);
Writeln('                          |   |  _  |   |               ');
gotoxy(30,8);
Writeln('                          |   | | | |   |               ');
gotoxy(30,9);
Writeln('                          |   | |_| |   |               ');
gotoxy(30,10);
Writeln('                          |=============|               ');
gotoxy(30,11);
Writeln('                          |   |     |   |               ');
gotoxy(30,12);
Writeln('                          |   |     |   |               ');
gotoxy(30,13);
Writeln('                          |   |     |   |               ');
gotoxy(30,14);
Writeln('                          |   |     |   |               ');
gotoxy(30,15);
Writeln('                          |=============|               ');
gotoxy(30,16);
Writeln('                          |   |     |   |               ');
gotoxy(30,17);
Writeln('                          |   |     |   |               ');
gotoxy(30,18);
Writeln('                          |   |     |   |               ');
gotoxy(30,19);
Writeln('                          |   |     |   |               ');
gotoxy(30,20);
Writeln('                          |=============|               ');
gotoxy(30,21);
Writeln('                          |   |     |   |               ');
gotoxy(30,22);
Writeln('                          |   |     |   |               ');
gotoxy(30,23);
  Write('                          |   |     |   |               ');
gotoxy(30,24);
  Write('                          |___|_____|___|               ');
   a:=b
 //aqui va un gotoxy con x contante
 end;
if (a=4) and (b=1) then
 begin
  writeln('usted esta en el primer piso.');
  gotoxy(30,4);
Writeln('                            ___________                 ');
gotoxy(30,5);
Writeln('                           /  |     |  \                ');
gotoxy(30,6);
Writeln('                          |   |     |   |               ');
gotoxy(30,7);
Writeln('                          |   |     |   |               ');
gotoxy(30,8);
Writeln('                          |   |     |   |               ');
gotoxy(30,9);
Writeln('                          |   |     |   |               ');
gotoxy(30,10);
Writeln('                          |=============|               ');
gotoxy(30,11);
Writeln('                          |   |     |   |               ');
gotoxy(30,12);
Writeln('                          |   |     |   |               ');
gotoxy(30,13);
Writeln('                          |   |     |   |               ');
gotoxy(30,14);
Writeln('                          |   |     |   |               ');
gotoxy(30,15);
Writeln('                          |=============|               ');
gotoxy(30,16);
Writeln('                          |   |     |   |               ');
gotoxy(30,17);
Writeln('                          |   |     |   |               ');
gotoxy(30,18);
Writeln('                          |   |     |   |               ');
gotoxy(30,19);
Writeln('                          |   |     |   |               ');
gotoxy(30,20);
Writeln('                          |=============|               ');
gotoxy(30,21);
Writeln('                          |   |     |   |               ');
gotoxy(30,22);
Writeln('                          |   |  _  |   |               ');
gotoxy(30,23);
  Write('                          |   | | | |   |               ');
gotoxy(30,24);
  Write('                          |___|_|_|_|___|               ');
   a:=b
 //aqui va un gotoxy con x contante
 end;

if (a=4) and (b=2) then
 begin
  writeln('usted esta en el segundo piso.');
  gotoxy(30,4);
Writeln('                            ___________                 ');
gotoxy(30,5);
Writeln('                           /  |     |  \                ');
gotoxy(30,6);
Writeln('                          |   |     |   |               ');
gotoxy(30,7);
Writeln('                          |   |     |   |               ');
gotoxy(30,8);
Writeln('                          |   |     |   |               ');
gotoxy(30,9);
Writeln('                          |   |     |   |               ');
gotoxy(30,10);
Writeln('                          |=============|               ');
gotoxy(30,11);
Writeln('                          |   |     |   |               ');
gotoxy(30,12);
Writeln('                          |   |     |   |               ');
gotoxy(30,13);
Writeln('                          |   |     |   |               ');
gotoxy(30,14);
Writeln('                          |   |     |   |               ');
gotoxy(30,15);
Writeln('                          |=============|               ');
gotoxy(30,16);
Writeln('                          |   |     |   |               ');
gotoxy(30,17);
Writeln('                          |   |  _  |   |               ');
gotoxy(30,18);
Writeln('                          |   | | | |   |               ');
gotoxy(30,19);
Writeln('                          |   | |_| |   |               ');
gotoxy(30,20);
Writeln('                          |=============|               ');
gotoxy(30,21);
Writeln('                          |   |     |   |               ');
gotoxy(30,22);
Writeln('                          |   |     |   |               ');
gotoxy(30,23);
  Write('                          |   |     |   |               ');
gotoxy(30,24);
  Write('                          |___|_____|___|               ');
   a:=b
 //aqui va un gotoxy con x contante
 end;

if (a=4) and (b=3) then
 begin
  writeln('usted esta en el tercer piso.');
  gotoxy(30,4);
Writeln('                            ___________                 ');
gotoxy(30,5);
Writeln('                           /  |     |  \                ');
gotoxy(30,6);
Writeln('                          |   |     |   |               ');
gotoxy(30,7);
Writeln('                          |   |     |   |               ');
gotoxy(30,8);
Writeln('                          |   |     |   |               ');
gotoxy(30,9);
Writeln('                          |   |     |   |               ');
gotoxy(30,10);
Writeln('                          |=============|               ');
gotoxy(30,11);
Writeln('                          |   |     |   |               ');
gotoxy(30,12);
Writeln('                          |   |  _  |   |               ');
gotoxy(30,13);
Writeln('                          |   | | | |   |               ');
gotoxy(30,14);
Writeln('                          |   | |_| |   |               ');
gotoxy(30,15);
Writeln('                          |=============|               ');
gotoxy(30,16);
Writeln('                          |   |     |   |               ');
gotoxy(30,17);
Writeln('                          |   |     |   |               ');
gotoxy(30,18);
Writeln('                          |   |     |   |               ');
gotoxy(30,19);
Writeln('                          |   |     |   |               ');
gotoxy(30,20);
Writeln('                          |=============|               ');
gotoxy(30,21);
Writeln('                          |   |     |   |               ');
gotoxy(30,22);
Writeln('                          |   |     |   |               ');
gotoxy(30,23);
  Write('                          |   |     |   |               ');
gotoxy(30,24);
  Write('                          |___|_____|___|               ');
   a:=b
 //aqui va un gotoxy con x contante
 end;

 readkey;
 clrscr;

 until (b=0);

 if (b=0) then
  begin
   clrscr;
   gotoxy(20,13);
   Write('Gracias por utilizar nuestros servicios');
  end;

 readkey;

end.
