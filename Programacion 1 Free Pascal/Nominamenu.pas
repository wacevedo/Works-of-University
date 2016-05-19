program Menuburbuja;
uses crt;
const
T1='UCATECI';
T2='PROGRAMACION 1';
T3='MENU PRINCIPAL';
T4='NOMINA ';

l=5;//contante de los limetes de los arreglos

var

cod,sueldo  :array [1..l] of integer;
nombre,cargo:array [1..l] of string;
t:char;
op,c1,f1: integer;
numero:string;






procedure listo(y:integer);
begin
 while not keypressed do
    begin

     gotoxy((80-length('Preciona cualquier tecla para continuar')) div 2,{19}y);
     write('Preciona cualquier tecla para continuar');
     delay(500);
     gotoxy((80-length('Preciona cualquier tecla para continuar')) div 2,{19}y);
                 write('                                       ');
     delay(250);

    end;

   readkey;

end;



procedure cuadro(x1,y1,x2,y2:integer);
var
x,y:integer;

begin

 for x:=x1 to x2 do
  begin
   gotoxy(x,y1); write('²');
   gotoxy(x,y2); write('²');
   //delay(1);
  end;

 for y:=y1 to y2 do
  begin
   gotoxy(x1,y); write('²');
   gotoxy(x2,y); write('²');
   //delay(1);
  end;

end;


procedure cuadrito;
var
x,y:integer;
begin

 for x:=2 to 79 do
  begin
   gotoxy(x,14); write('Ä');
   gotoxy(x,16); write('Ä');

  end;

 for y:=14 to 16 do
  begin
   gotoxy(2,y); write('³');
   gotoxy(79,y); write('³');

  end;

 gotoxy(2,16);write('À');
 gotoxy(79,14);write('¿');
 gotoxy(79,16);write('Ù');
 gotoxy(2,14);write('Ú');

end;


procedure carga;
var
 n,ciclo,x,y:integer;
 por:real;

begin
 clrscr;
 n:=3;
 gotoxy((80-length('Cargando')) div 2,7);write('Cargando');
 cuadro(1,13,80,19);
 cuadrito;


 for ciclo:=3 to 78 do
  begin
   textcolor(yellow);
   gotoxy(ciclo,15);write(chr(219));
   por:=por+1.32;
   delay(10);
   textcolor(white);
   gotoxy(37,17);write(por:4:0,'%');
  end;
  textcolor(white);
end;


procedure burbuja;
var
 x,y,t,t2 :integer;
 t1,t3:string;
begin
 clrscr;
 Cuadro(1,6,80,8);
 gotoxy((80-length('Ordenando...')) div 2,7);write('Ordenando...');
 for x:= 1 to L do
  for y:=1 to L-1 do
   if (cod[y]>cod[y+1]) then
    begin
     t:=cod[y];
     cod[y]:=cod[y+1];
     cod[y+1]:=t;

     t1:=nombre[y];
     nombre[y]:=nombre[y+1];
     nombre[y+1]:=t1;

     t2:=sueldo[y];
     sueldo[y]:=sueldo[y+1];
     sueldo[y+1]:=t2;

     t3:=cargo[y];
     cargo[y]:=cargo[y+1];
     cargo[y+1]:=t3;

    end;
  gotoxy((80-length('Listo!')) div 2,10);write('Listo!');
  listo(19);
  //readkey;
end;

procedure burbujacargo;
var
 x,y,t,t2 :integer;
 t1,t3:string;
begin
 clrscr;
 Cuadro(1,6,80,8);
 gotoxy((80-length('Ordenando...')) div 2,7);write('Ordenando...');
 for x:= 1 to L do
  for y:=1 to L-1 do
   if (cargo[y]>cargo[y+1]) then
    begin
     t:=cod[y];
     cod[y]:=cod[y+1];
     cod[y+1]:=t;

     t1:=nombre[y];
     nombre[y]:=nombre[y+1];
     nombre[y+1]:=t1;

     t2:=sueldo[y];
     sueldo[y]:=sueldo[y+1];
     sueldo[y+1]:=t2;

     t3:=cargo[y];
     cargo[y]:=cargo[y+1];
     cargo[y+1]:=t3;

    end;
  gotoxy((80-length('Listo!')) div 2,10);write('Listo!');
  listo(19);
  //readkey;
end;

procedure llenar;
var
x,y,z,c:integer;
begin

 clrscr;
 Cuadro(1,1,80,3);
 gotoxy((80-length('Llenando Formularios')) div 2,2);
 write('Llenando Formularios');

 gotoxy(1,5);  write('Codigo:');
 gotoxy(12,5); write('Nombre:');
 gotoxy(40,5); write('Cargo:');
 gotoxy(59,5); write('Pago por hora:');

 Cuadro(1,22,80,24);

  gotoxy(8,23);  write('0 en codigo = Salir');

  gotoxy(39,23); write('Teclado para escribir');



 for c:=6 to 21 do
  begin
   gotoxy(11,c); write('º');
   gotoxy(39,c); write('º');
   gotoxy(58,c); write('º');

  end;

 for z:=1 to 79 do
  begin
   gotoxy(z,6); write('Í');
  end;

  y:=7;
 for x:=1 to l do

  begin

   gotoxy(1,y); readln(cod[x]);
   if cod[x]=0 then break;
   gotoxy(12,y); readln(nombre[x]);
   gotoxy(40,y); readln(cargo[x]);
   gotoxy(59,y); readln(sueldo[x]);

   inc(y);

  end;

  clrscr;
  Cuadro(1,13,80,15);
  gotoxy((80-length('Listo! Los arreglos estan completos')) div 2,14);
  write('Listo! Los arreglos estan completos');

   while not keypressed do
    begin

     gotoxy((80-length('Preciona cualquier tecla')) div 2,17);
     write('Preciona cualquier tecla');
     delay(500);
     gotoxy((80-length('Preciona cualquier tecla')) div 2,17);
     write('                        ');
     delay(250);

    end;

   readkey;

end;

procedure mostrar;
var
 x,y,c,z: integer;
begin
 y:=7;
 clrscr;
 Cuadro(1,1,80,3);
 gotoxy((80-length('Mostrando Formulario')) div 2,2);write('Mostrando Formulario');
 gotoxy(1,5); write('Codigo:');
 gotoxy(12,5); write('Nombre:');
 gotoxy(40,5); write('Cargo:');
 gotoxy(59,5); write('Sueldo:');

 for c:=6 to 24 do
  begin

   gotoxy(11,c); write('º');
   gotoxy(39,c); write('º');
   gotoxy(58,c); write('º');

  end;

 for z:=1 to 79 do
  begin
   gotoxy(z,6); write('Í');
  end;

 for x:=1 to l do
  begin
  if cod[x]<>0 then
  begin
   gotoxy(1,y); write(cod[x]);
   gotoxy(12,y); write(nombre[x]);
   gotoxy(40,y); write(cargo[x]);
   gotoxy(59,y); write(sueldo[x]);

   y:= y+1;
  end;


 end;
 gotoxy((80-length('Listo!')) div 2,4);write('Listo!');
 readkey;
end;

function numletr(num:string):string;
var
x:integer;
t1,t2,t3,t4,t5,t6,t7,t8,t9,t10, letra:string;
begin
 for x:=10 to 1 do
  begin
   case num[10] of

   '0':t1:='';

   '1':begin
   t1:='uno';
   end;

   '2':begin
   t1:='dos';
   end;

   '3':begin
   t1:='tres';
   end;

   '4':begin
   t1:='cuatro';
   end;

   '5':begin
   t1:='cinco';
   end;

   '6':t1:='seis';

   '7':t1:='siete';

   '8':t1:='ocho';

   '9':t1:='nueve';

  end;

  case num[9] of

   '0':t2:='';

   '1':begin
   t2:='diez';
   end;

   '2':begin
   t2:='veinte';
   end;

   '3':begin
   t2:='treinta';
   end;

   '4':begin
   t2:='cuarenta';
   end;

   '5':begin
   t2:='cincuenta';
   end;

   '6':t2:='sesenta';

   '7':t2:='setenta';

   '8':t2:='ochenta';

   '9':t2:='noventa';

  end;

  case num[8] of

   '0':t3:='';

   '1':begin
   t3:='cien';
   end;

   '2':begin
   t3:='dociento';
   end;

   '3':begin
   t3:='treciento';
   end;

   '4':begin
   t3:='cuatrociento';
   end;

   '5':begin
   t3:='quiniento';
   end;

   '6':t3:='seisciento';

   '7':t3:='seteciento';

   '8':t3:='ochociento';

   '9':t3:='noveciento';

  end;

  case num[7] of

   '0':t4:='';

   '1':begin
   t4:='mil';
   end;

   '2':begin
   t4:='dosmil';
   end;

   '3':begin
   t4:='tresmil';
   end;

   '4':begin
   t4:='cuatromil';
   end;

   '5':begin
   t4:='cincomil';
   end;

   '6':t4:='seismil';

   '7':t4:='sietemil';

   '8':t4:='ochomil';

   '9':t4:='nuevemil';

   end;

end;

letra:=t1+t2+t3+t4;
gotoxy(10,12);
writeln(letra);
//write(t1+t2+t3+t4);
write(t1);
write(t2);
write(t3);

end;




procedure guardar;
var
 archivo:text;
 nomarchivo:string[10];
 x:integer;

begin

nomarchivo:='Formulario';
assign(archivo,'C:\'+nomarchivo+'.txt');
rewrite(archivo);


  writeln(archivo,'Formulario ');
  write(archivo,'Codigo: ');
  write(archivo,'Nombre:     ');
  write(archivo,'Cargo:      ');
  writeln(archivo,'Sueldo:   ');




   for x:=1 to l do
    begin
      write(archivo,cod[x],'    ');
      write(archivo,nombre[x],'    ');
      write(archivo,cargo[x],'     ');
      writeln(archivo,sueldo[x],'    ');


    end;


 close(archivo);


end;





procedure titulo;
var x,y:integer;

begin
clrscr;
 for x:=1 to 80 do
  begin
   gotoxy(x,7); write('Ä');
   gotoxy(x,21); write('Ä');
   //delay(1);
  end;
 for y:=7 to 21 do
  begin
   gotoxy(1,y); write('³');
   gotoxy(80,y); write('³');
   //delay(1);
  end;

 gotoxy(1,21);write('À');
 gotoxy(80,7);write('¿');
 gotoxy(80,21);write('Ù');
 gotoxy(1,7);write('Ú');



  Cuadro(1,1,80,6);

  gotoxy((80-length(T1)) div 2,2); write(T1);
  gotoxy((80-length(T2)) div 2,3); write(T2);
  gotoxy((80-length(T3)) div 2,4); write(T3);
  gotoxy((80-length(T4)) div 2,5); write(T4);
  gotoxy(10,9);  write('  Llenar Formulario');
  gotoxy(10,10); write('  Ordenar Formulario');
  gotoxy(10,11); write('  Mostrar Formulario');
  gotoxy(10,12); write('  Buscar Por Cargo');
  gotoxy(10,13); write('  Salir');

  Cuadro(1,22,80,24);

  gotoxy(8,23);  write('Esc=Salir');
  gotoxy(21,23); write(#24'=Mover arriba');
  gotoxy(39,23); write(#25'=Mover abajo');
  gotoxy(55,23); write('Enter=Seleccionar');

  c1:=9; f1:=9;
  gotoxy(c1,f1-1);write('   ');
  gotoxy(c1,f1+1);write('   ');
  gotoxy(c1,f1);  write('- ');
  gotoxy({(80-length('Wilson Acevedo - 2012-1993')) div 2}3,25);
  write('Wilson Acevedo - 2012-1993');
  gotoxy({(80-length('Wilson Acevedo - 2012-1993')) div 2}50,25);
  write('Tab=Instruciones');

end;


procedure buscar;
var
 car:string;
 x,y,c,z:integer;
begin

 clrscr;
 y:=7;

 Cuadro(1,1,80,3);
 gotoxy((80-length('Resultados de la busqueda')) div 2,2);write('Resultados de la busqueda');
 gotoxy(1,5); write('Codigo:');
 gotoxy(12,5); write('Nombre:');
 gotoxy(40,5); write('Cargo:');
 gotoxy(59,5); write('Sueldo:');

 for c:=6 to 24 do
  begin

   gotoxy(11,c); write('º');
   gotoxy(39,c); write('º');
   gotoxy(58,c); write('º');

  end;

 for z:=1 to 79 do
  begin
   gotoxy(z,6); write('Í');
  end;

  textcolor(yellow);
 gotoxy((80-length('Introdusca el cargo que quiere buscar')) div 2,4);
write('Introdusca el cargo que quiere buscar');
  textcolor(white);

 gotoxy(40,y);
 readln(car);

 for x:=1 to l do
   if car=cargo[x] then

    begin

     gotoxy(1,y);  write(cod[x]);
     gotoxy(12,y); write(nombre[x]);
     gotoxy(40,y); write(cargo[x]);
     gotoxy(59,y); write(sueldo[x]);

     y:= y+1;

   end;

     if y=7 then
    begin
     clrscr;
     Cuadro(1,13,80,15);
     gotoxy((80-length('no se ha encontrado ningun cargo con ese nombre')) div 2,14);
     write('No se ha encontrado ningun cargo llamado ',car);
     listo(19);
    end
    else
    begin
     gotoxy((80-length('Introdusca el cargo que quiere buscar')) div 2,4);
             write('                                     ');
     gotoxy((80-length('Listo!')) div 2,4);write('Listo!');
     readkey;
    end;


end;

/////////////////cuerpo//////////////////////
begin
textbackground(blue);
textcolor(white);
carga;

 repeat

   titulo;

  repeat

    t:=readkey;
     case t of

  #72:begin //arriba
   if (f1>9) then
   dec(f1)
   else
    begin
    gotoxy(c1,f1);write('   ');
   f1:=13;//cambiar cada vez que se aplien las opciones del menu
    end;

      end;

  #80:begin //abajo
   if (f1<13) then //cambiar cada vez que se aplien las opciones del menu
   inc(f1)
   else
   begin
     gotoxy(c1,f1);write('   ');
    f1:=9;
    end;
      end;

    end;

   gotoxy(c1,f1-1);write('   ');
   gotoxy(c1,f1);  write('- ');
   gotoxy(c1,f1+1);write('   ');

   if (t=#32) then
   begin
    clrscr;
    Cuadro(1,1,80,6);

  gotoxy((80-length(T1)) div 2,2); write(T1);
  gotoxy((80-length(T2)) div 2,3); write(T2);
  gotoxy((80-length(T3)) div 2,4); write(T3);
  gotoxy(10,8); write('Introdusca el numero: ');readln(numero);
  numletr(numero);
  write(numero);
  listo(22);
  titulo;

  end;
   if (t=#9) then
   begin
   clrscr;
    Cuadro(1,1,80,6);

  gotoxy((80-length(T1)) div 2,2); write(T1);
  gotoxy((80-length(T2)) div 2,3); write(T2);
  gotoxy((80-length(T3)) div 2,4); write(T3);
  gotoxy((80-length('Instrucciones')) div 2,5); write('Instrucciones');

  gotoxy(10,8);  write('  Llenar Formulario:');
  gotoxy(10,11); write('  Ordenar Formulario:');
  gotoxy(10,15); write('  Mostrar Formulario:');
  gotoxy(10,18); write('  Salir:');

  textcolor(yellow);
  gotoxy(30,8);  write(' se llenan ',l,' cantidad de arreglo con el codigo,');
  gotoxy(10,9);  write('el nombre, el cargo y el precio por hora que se le paga al empleado.');

  gotoxy(31,11); write(' a precionar esta opcion se le dara a escojer ');
  gotoxy(10,12);  write('entre dos maneras de organizar los arreglos: 0 para ordenar por ');
  gotoxy(10,13);  write('codigo y 1 para ordenar segun el orden alfabetico del cargo.');

  gotoxy(31,15); write(' esta opcion permite visualizar el estado de ');
  gotoxy(10,16); write('los arreglos.');

  gotoxy(17,18); write(' al salir se le dara la opcion de guardar o no, al guardar se');
  gotoxy(10,19); write('creara un archivo .txt con lo que quedo de los arreglos ');
  gotoxy(10,20); write('ubicado en la raiz del disco duro C:\ con el nombre "Formulario".');
  textcolor(white);

  while not keypressed do
    begin

     gotoxy((80-length('Preciona cualquier tecla para continuar')) div 2,23);
     write('Preciona cualquier tecla para continuar');
     delay(500);
     gotoxy((80-length('Preciona cualquier tecla para continuar')) div 2,23);
     write('                                       ');
     delay(250);

    end;

   readkey;

  titulo;

   end;

   if (t=#13) and (f1=9) then
   begin
    llenar;
    titulo;
   end;

   if (t=#13) and (f1=10) then
   begin
    clrscr;
    Cuadro(1,13,80,15);
    gotoxy(15,14); write('0=Ordenar por codigo');
    gotoxy(50,14); write('1=Ordenar por cargo');
    Cuadro(34,18,46,20);
    gotoxy(40,19);read(op);

    if op=0 then
     begin
      burbuja;
      titulo;
     end;

    if op=1 then
     begin
      burbujacargo;
      titulo;
     end;

   end;


   if (t=#13) and (f1=11) then
    begin
     mostrar;
     titulo;
    end;

    if (t=#13) and (f1=12) then
     begin
      buscar;
      titulo;

     end;

   if (t=#13) and (f1=13) then
    begin
     t:=#27;

    end;



 until(t=#27);


 begin
  clrscr;
  Cuadro(1,13,80,15);
  gotoxy(15,14); write('0=Salir sin guardar');
  gotoxy(50,14); write('1=Guardar y salir');
  Cuadro(34,18,46,20);
  gotoxy(40,19);read(op);
 end;

 if op=1 then
  begin
   guardar;
   op:=op-1;
  end;


until(op=0);

end.

