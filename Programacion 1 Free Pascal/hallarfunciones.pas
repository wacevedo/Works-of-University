program hallardemasfunciones;
uses crt,dos;
 const
 t2='Hallar Las demas Funciones trigonometricas';
 t4='¨Cual desea insertar?';
arreglotitulo:array [9..13] of string = ('',' Hipotenusa',' Cateto Adyasente',' Cateto Opuesto','');

 var
c1,f1,op,ciclo,f :integer;
t:char;
a,m,d,ds,h,mm,s,ns:word;
Hip,CA,CO:real;

////////////Fecha y hora/////////////

procedure fecha;

 begin

   getdate(a,m,d,ds); //obteniendo fecha del sistema
   gettime(h,mm,s,ns); //obteniendo hora del sistema

   gotoxy(2,2);
   write(d,'/',m,'/',a);    //mostrando fecha
   gotoxy(2,3);
   writeln(h,':',mm);      //mostrando hora

 end;


///////////Limpiar parte de la pantalla//////////

procedure clrpart;
var
 x,y,z:integer;    // para for de limpiar

begin

 for y:=7 to 21 do
  for x:= 1 to 80 do
   begin
    gotoxy(x,y);
    write(' ');             //limpiando la parte central de pantalla
   end;

 gotoxy((80-length('                                          ')) div 2,5);
 write('                                          '); //limpiando titulo



  for z:=2 to 79 do
   begin
    gotoxy(z,23);
    write(' ');
    gotoxy(z,25);       //limpiando cuadro de mensajes
    write(' ');
   end;



     fecha;                //actualizando fecha

end;

///////////////limpiar mensaje//////////

procedure clrmsj;
var
 x:integer;        // para for de limpiar mensaje
begin
 for x:=2 to 79 do
  begin
    gotoxy(x,23);       //limpiando cuadro de mensajes
    write(' ');
  end;
end;


//////////////listo///////////////


procedure listo(y:integer);   // "y" para ubicacion
begin
 while not keypressed do
    begin

     gotoxy((80-length('Preciona cualquier tecla para continuar')) div 2,y);
     write('Preciona cualquier tecla para continuar');
     delay(500);
     gotoxy((80-length('Preciona cualquier tecla para continuar')) div 2,y);
                 write('                                       ');
     delay(250);

    end;

   readkey;

end;

//////////////Dibujo Cuadro///////////////

procedure cuadro(x1,y1,x2,y2:integer);
var
 x,y:integer;

begin

 for x:=x1 to x2 do
  begin

   gotoxy(x,y1); write('²');
   gotoxy(x,y2); write('²');

  end;

 for y:=y1 to y2 do
  begin

   gotoxy(x1,y); write('²');
   gotoxy(x2,y); write('²');

  end;

end;

//////////////Dibujo Cuadrito con parametro///////////////

procedure cuadritopar(x1,y1,x2,y2:integer);
var
 x,y:integer;

begin

 for x:=x1 to x2 do
  begin

   gotoxy(x,y1); write('Ä');
   gotoxy(x,y2); write('Ä');

  end;

 for y:=y1 to y2 do
  begin

   gotoxy(x1,y); write('³');
   gotoxy(x2,y); write('³');

  end;

  gotoxy(x1,y2);write('À');
  gotoxy(x2,y1);write('¿'); //esquinas
  gotoxy(x2,y2);write('Ù');
  gotoxy(x1,y1);write('Ú');

end;

//////////////triangulo rectangulo//////////////
procedure triangulo;
var
q,w,e :integer;
begin
q:=0; w:=0; e:=0;
 for q:=50 to 55 do
  begin
    gotoxy(q,14); write('Ä');;
  end;

 for w:=9 to 14 do
  begin
   gotoxy(50,w); write('³');
  end;
   w:=9; q:=51;
 for e:=1  to 5  do
  begin
   gotoxy(q,w); write('\');
   inc(w);
   inc(q);
  end;
   gotoxy(50,14); write('À');
   gotoxy(40,11); write(CO:8:2);
   gotoxy(50,15); write(CA:8:2);
   gotoxy(55,11); write(Hip:8:2)
end;


////////titulo/////////
procedure titulo;
var
f5:integer;
begin
f5:=10;
for ciclo:=10 to 12 do
   begin
    gotoxy(10,f5); write(arreglotitulo[ciclo]);
    inc(f5);
   end;

   gotoxy(8,23);  write('Esc=Salir');
   gotoxy(21,23); write(#24'=Mover arriba');   //forma de manejo
   gotoxy(39,23); write(#25'=Mover abajo');
   gotoxy(55,23); write('Enter=Seleccionar');


   gotoxy(3,25);
   write('Tab=Instruciones');

end;

//////////////Calculo Hipotenusa y cateto op/////////////
procedure hallarcatetoad;
var
catetoad:real;

begin
 clrpart;
 CA:=sqrt((Hip*Hip)-(CO*CO));
 gotoxy(10,9); write('Seno',CO:8:1,'/',Hip:8:1);
 gotoxy(10,10); write('Coseno',CA:8:1,'/',Hip:8:1);
 gotoxy(10,11); write('Tangente',CO:8:1,'/',CA:8:1);
 gotoxy(10,12); write('Cotangente',CA:8:1,'/',CO:8:1);
 gotoxy(10,13); write('Secante',Hip:8:1,'/',CA:8:1);
 gotoxy(10,14); write('Cosecante',Hip:8:1,'/',CO:8:1);
 triangulo;
 listo(23);
 clrpart;
 titulo;

end;

//////////////Calculo Hipotenusa y cateto ad/////////////
procedure hallarcatetoop;
var
catetoop:real;

begin
 clrpart;
 CO:=sqrt((Hip*Hip)-(CA*CA));
 gotoxy(10,9); write('Seno',CO:8:1,'/',Hip:8:1);
 gotoxy(10,10); write('Coseno',CA:8:1,'/',Hip:8:1);
 gotoxy(10,11); write('Tangente',CO:8:1,'/',CA:8:1);
 gotoxy(10,12); write('Cotangente',CA:8:1,'/',CO:8:1);
 gotoxy(10,13); write('Secante',Hip:8:1,'/',CA:8:1);
 gotoxy(10,14); write('Cosecante',Hip:8:1,'/',CO:8:1);
 triangulo;
 listo(23);
 clrpart;
 titulo;



end;

//////////////Calculo de catetos ////////////
procedure hallarhipotenusa;
var
hipotenusa:real;
begin
  clrpart;
  Hip:=sqrt((CO*CO)+(CA*CA));
  gotoxy(10,9); write('Seno',CO:8:1,'/',Hip:8:1);
 gotoxy(10,10); write('Coseno',CA:8:1,'/',Hip:8:1);
 gotoxy(10,11); write('Tangente',CO:8:1,'/',CA:8:1);
 gotoxy(10,12); write('Cotangente',CA:8:1,'/',CO:8:1);
 gotoxy(10,13); write('Secante',Hip:8:1,'/',CA:8:1);
 gotoxy(10,14); write('Cosecante',Hip:8:1,'/',CO:8:1);
 triangulo;
 listo(23);
 clrpart;
 titulo;
end;

//////////////////Cuerpo/////////////////////

begin
 c1:=8; f1:=10;  f:=10;
 textbackground(blue);
 textcolor(white);
 clrscr;



 repeat

  Cuadro(1,1,80,6);
  fecha;

  gotoxy((80-length(T2)) div 2,3); write(T2);  //parte superior
  gotoxy((80-length(T4)) div 2,4); write(T4);

  gotoxy(63,5);
  write('Willson Acevedo');

  Cuadro(1,22,80,24);

  gotoxy(8,23);  write('Esc=Salir');
  gotoxy(21,23); write(#24'=Mover arriba');   //forma de manejo
  gotoxy(39,23); write(#25'=Mover abajo');
  gotoxy(55,23); write('Enter=Seleccionar');


  gotoxy(3,25);
  write('Tab=Instruciones');

   titulo;

   repeat

    t:=readkey;
     case t of

  #72:begin //arriba
   if (f1>10) then
   dec(f1)
   else
    begin
    gotoxy(c1,f1);write('   ');
    gotoxy(10,f1); write(arreglotitulo[f1]);
   f1:=12;//cambiar cada vez que se aplien las opciones del menu
    end;

      end;




  #80:begin //abajo
   if (f1<12) then //cambiar cada vez que se aplien las opciones del menu
   inc(f1)
   else
   begin
     gotoxy(c1,f1);write('   ');
     gotoxy(10,f1); write(arreglotitulo[f1]);
    f1:=10;
    end;
      end;

    end;

   gotoxy(c1,f1-1);write('   ');
   gotoxy(c1,f1);  write('- ');
   gotoxy(c1,f1+1);write('   ');

   textcolor(yellow);
   gotoxy(10,f1); write(arreglotitulo[f1]);
   textcolor(white);
   gotoxy(10,f1-1); write(arreglotitulo[f1-1]);
   gotoxy(10,f1+1); write(arreglotitulo[f1+1]);


   //if (t=#32) then {espacio}


   if (t=#9) then   //instrucciones
   begin
   clrpart;
   fecha;


    gotoxy((80-length('Instrucciones')) div 2,5); write('Instrucciones');

    {gotoxy(10,8);  write('  Registrar:');
    gotoxy(10,11); write('  Ordenar :');
    gotoxy(10,15); write('  Mostrar :');
    gotoxy(10,18); write('  Salir:');

    textcolor(yellow);
    gotoxy(21,8);  write(' se llenan ',l,' cantidad de arreglo con la informacion');
    gotoxy(10,9);  write('del estudiante, matricula, nombre, carrera, calificaciones,etc.');

    gotoxy(20,11); write(' a precionar esta opcion se le dara a escojer ');
    gotoxy(10,12);  write('entre dos maneras de organizar los arreglos: 0 para ordenar por ');
    gotoxy(10,13);  write('Matricula y 1 para ordenar segun el orden alfabetico de la carrera.');

    gotoxy(20,15); write(' esta opcion permite visualizar el estado de ');
    gotoxy(10,16); write('los arreglos, sea los estudiantes o sus asignaturas inscritas.');

    gotoxy(17,18); write(' al salir se le dara la opcion de guardar o no, al guardar se');
    gotoxy(10,19); write('creara un archivo .txt con lo que quedo de los arreglos ');
    gotoxy(10,20); write('ubicado en la raiz del disco duro C:\ con el nombre "Inscripcion".');
    textcolor(white);}

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

   Cuadro(1,22,80,24);
   titulo;

   end;


   if (f1=10) and (t=#13) then
   begin
    gotoxy(10+(length(arreglotitulo[f1])),f1);write('=');
    gotoxy(12+(length(arreglotitulo[f1])),f1);
    readln(hip);

   end;

    if (f1=11) and (t=#13) then
   begin
    gotoxy(10+(length(arreglotitulo[f1])),f1);write('=');
    gotoxy(12+(length(arreglotitulo[f1])),f1);
    readln(CA);

   end;

   if (f1=12) and (t=#13) then
   begin
    gotoxy(10+(length(arreglotitulo[f1])),f1);write('=');
    gotoxy(12+(length(arreglotitulo[f1])),f1);
    readln(CO);

   end;

   if (Hip<>0) and (CA<>0) then
   begin
    hallarcatetoop;
    Hip:=0;
    CA:=0;
   end;

   if (Hip<>0) and (CO<>0) then
   begin
   hallarcatetoad;
   Hip:=0;
    CO:=0;
    end;

   if (CA<>0) and (CO<>0) then
   begin
   hallarhipotenusa;
   CO:=0;
    CA:=0;
    end;


 until(t=#27);


 begin
  clrpart;

  cuadritopar(1,7,80,21);

  cuadro(2,9,79,13);
   gotoxy((80-length('¨Desea guardar en un archivo .txt?')) div 2,11);
   write('¨Desea guardar en un archivo .txt?');

  gotoxy((80-length('Saliendo')) div 2,5); write('SALIENDO');


  gotoxy(15,23); write('0=Salir sin guardar');
  gotoxy(50,23); write('1=Guardar y salir');
  Cuadritopar(34,18,46,20);
  gotoxy(40,19);read(op);
 end;

 if op=1 then
  begin
   //guardar;
   op:=op-1;
  end;


until(op=0);

end.

