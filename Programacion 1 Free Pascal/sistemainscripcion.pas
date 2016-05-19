program MenuEstudiantes;
uses crt,dos;         //libretias

const
T1='UCATECI';
T2='PROGRAMACION 1';  //titulos superiores
T3='MENU PRINCIPAL';
T4='SISTEMA DE INSCRIPCION';

usuario='admin';     //usuario con el que se accesa al programa
passw='admin';       //contrase¤a con la que se accesa al programa

l=5;                //contante de los limetes de los arreglos
l1=5;           //limite de las asignaturas
l2=10;     //limite de los arreglos de materias

///////Arreglos const para validacion de asignaturas a inscribir//////

arreglomateria:array[1..l2] of string[30] = ('matematicas 1','espa¤ol 1','ingles 1','fisica'     ,'programacion 1','anatomia 1'   ,'calculo 1','Orientacion univ','programacion 2','seminario 1');
arreglocodigo:array[1..l2] of string[11] =  ('CIM 001'     ,'HUM 002'  ,'HUM 010 ','CIF 001'   ,'ISC 005'      ,'MED 201'       ,'CIM 004'  , 'HUM 001 ','ISC 009 ','ISC 007');
arreglolab:array [1..l2] of string[30] =    ('no'          ,'no'      ,'no'     ,'Lab. Fisica','Lab. programc','Lab. anatomia','no'      ,'no','Lab. programc2 ','Taller S1');

/////////////////Arreglo const para seleccion de opciones/////////////////////
arreglotitulo:array [8..17] of  string[40]=
('',//se necesitan esta variable vacia para su funcionamiento
'  Registrar Estudiantes',
'  Registrar Asignatura',
'  Ordenar Estudiantes',
'  Mostrar Los Estudiantes',                //titulos
'  Mostrar Asignatura Por Estudiantes',
'  Buscar Estudiante',
'  Ver Asignaturas del pensum',
'  Salir',
'');//se necesitan esta variable vacia para su funcionamiento


type

 restudiantes=record
  {ano,}matricula:string[9]{integer};   //records de informacion de estudiantes
  nombre:string[40];
  carrera:string[30];
  sexo:char;
  mtr:integer;
 end;

 rasignatura=record          //records de asignaturas que inscriben los estudiantes
  {ano,}matricula:string[9]{integer};
  codigo:array[1..l1] of string[11];
  materia:array[1..l1] of  string[30];
  lab:array[1..l1] of string[30];
  asig:array[1..l1] of integer;
 end;

var

vestudiantes:array [1..l] of restudiantes;    //arreglos
vasignatura :array[1..l] of rasignatura;

t:char;           //variable de movimiento de flecha y ingreso a la opcion
op:integer;      //variable opciones
c1,f1,intentos:integer;   //variable de ubicion
u,p:string[20];      //variables de usuario y contrase¤a
a, m, d, ds : word;  //para la fecha a¤o, mes, numero de dia, dia de la semana
h, mm, s, ns : word; //para la hora  hora, minuto, segundo, nanosegundo


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



///////////// Dibujo de "cargando" ///////////////

procedure carga;
var
 ciclo:integer;
 por:real;

begin
 clrscr;

 gotoxy((80-length('Cargando')) div 2,7);write('Cargando');

 cuadro(1,13,80,19);

 cuadritopar(2,14,79,16);


 for ciclo:=3 to 78 do
  begin

   textcolor(yellow);
   gotoxy(ciclo,15);write('Û');
   por:=por+1.32;
   delay(15);
   textcolor(white);
   gotoxy(37,17);write(por:4:0,'%');

  end;

 textcolor(white);

end;

///////////////Error de intentos//////////////

procedure errorint;
var
q:integer;

begin
 clrscr;
 textcolor(red);
 cuadro(1,11,80,17);
 textcolor(yellow);
 cuadritopar(2,13,79,15);
 textcolor(white);

   repeat

     gotoxy((80-length('Error! A excedido el numero de intentos')) div 2,14);
     write('Error! A excedido el numero de intentos');
     delay(500);
     gotoxy((80-length('Error! A excedido el numero de intentos')) div 2,14);
                 write('                                       ');
     delay(250);

   until(q=100);

end;


///////////////Inicio al programa/////////////////

procedure inicio;

begin
 intentos:=0;

 clrscr;
 cuadro(20,10,60,18);
 gotoxy((80-length('Accediendo al Sistema')) div 2,8);
 write('Accediendo al Sistema');

 gotoxy(21,13); write('usuario:');

 gotoxy(21,16); write('contrase¤a:');

 cuadritopar(33,12,58,14);
 cuadritopar(33,15,58,17);
 //cuadritopar(54,12,58,14);
 //gotoxy(55,13);write('==>');

   repeat
    inc(intentos);
    textcolor(yellow);
    gotoxy(34,13); readln(u);
    gotoxy(34,16); readln(p);
    textcolor(white);
    if ((u=usuario) and (p=passw)) then break;
    if (intentos=3) then errorint;

    gotoxy((80-length('Numero de intentos:   /3')) div 2,21);
    write('Numero de intentos: ',intentos:2,'/3');
    gotoxy((80-length('ERROR! El usuario o la contrase¤a son incorrectos')) div 2,20);
    writeln('ERROR! El usuario o la contrase¤a son incorrectos');
    delay(2000);
    gotoxy((80-length('ERROR! El usuario o la contrase¤a son incorrectos  ')) div 2,20);
    writeln('                                                     ');
    gotoxy(34,13);write('                       ');
    gotoxy(34,16);write('                       ');

   until((u=usuario) and (p=passw));

   clrscr;
   carga;
   clrscr;

   Cuadro(1,12,80,16);
  gotoxy((80-length('Bienvenido al sistema de inscripcion')) div 2,14);
  write('BIENVENIDO AL SISTEMA DE INSCRIPCION');
  textcolor(yellow);
  listo(20);
  textcolor(white);



end;



//////////////Impresion de Titulos///////////////

procedure titulo;
var
 x,y:integer;

begin
 clrpart;
 fecha;
 for x:=1 to 80 do
  begin

   gotoxy(x,7); write('Ä');
   gotoxy(x,21); write('Ä');

  end;

 for y:=7 to 21 do
  begin

   gotoxy(1,y); write('³');
   gotoxy(80,y); write('³');

  end;

 gotoxy(1,21);write('À');
 gotoxy(80,7);write('¿');
 gotoxy(80,21);write('Ù');
 gotoxy(1,7);write('Ú');




  gotoxy((80-length(T3)) div 2,5); write(T3);
  gotoxy(10,9);  write('  Registrar Estudiantes');
  gotoxy(10,10); write('  Registrar Asignatura');
  gotoxy(10,11); write('  Ordenar Estudiantes');       //opciones
  gotoxy(10,12); write('  Mostrar Los Estudiantes');
  gotoxy(10,13); write('  Mostrar Asignatura Por Estudiantes');
  gotoxy(10,14); write('  Buscar Estudiante');
  gotoxy(10,15); write('  Ver Asignaturas del pensum');
  gotoxy(10,16); write('  Salir');

   gotoxy(8,23);  write('Esc=Salir');
   gotoxy(21,23); write(#24'=Mover arriba');          //mensajes
   gotoxy(39,23); write(#25'=Mover abajo');
   gotoxy(55,23); write('Enter=Seleccionar');
   gotoxy(50,25);
   write('Usuario:',usuario);              //usuario
   gotoxy(3,25);
   write('Tab=Instruciones');

  c1:=8; f1:=9;

  gotoxy(c1,f1-1);write('   ');
  gotoxy(c1,f1+1);write('   ');
  gotoxy(c1,f1);  write('- ');
  textcolor(yellow);
  gotoxy(10,f1); write(arreglotitulo[f1]);
  textcolor(white);


end;

//////////////Registrar estudiantes///////////////

procedure registrarest;
var
x,y,z,c:integer;
begin

 clrpart;
 fecha;
 gotoxy((80-length('Regitrar Estudiantes')) div 2,5);
 write('Regitrar Estudiantes');

 gotoxy(1,7);  write('Matricula:');
 gotoxy(12,7); write('Nombre:');               //encabezados
 gotoxy(40,7); write('Carrera:');
 gotoxy(59,7); write('Sexo:');

 gotoxy(2,23);  write('<0 en Matricula = Salir>');
 gotoxy(28,23);  write('Poner guion(-) en Matricula');    //mensaje
 gotoxy(59,23); write('Teclado para escribir');


 for c:=9 to 21 do
  begin

   gotoxy(11,c); write('º');
   gotoxy(39,c); write('º'); //lineas desendentes, columnas que separan los datos
   gotoxy(58,c); write('º');
   gotoxy(63,c); write('º');

  end;

 for z:=1 to 79 do
  begin

   gotoxy(z,8); write('Í'); //linea horizontal que separa los titulos de los datos

  end;

  y:=9;

 for x:=1 to l do

  begin

  // gotoxy(1,y); readln(vestudiantes[x].ano);
  //gotoxy(5,y); write('-');

   repeat
    gotoxy(1,y); readln(vestudiantes[x].matricula);
    if vestudiantes[x].matricula='0' then break;
    if vestudiantes[x].matricula[5]='-'then break;
    gotoxy(1,y);  writeln('         ');
    gotoxy(1,y);  writeln('ERROR!');
    clrmsj;
    gotoxy((80-length('ERROR! Se le olvido el guion(-)')) div 2,23);
    write('ERROR! Se le olvido el guion(-)');
    delay(2000);
    clrmsj;
    gotoxy(2,23);  write('<0 en Matricula = Salir>');
    gotoxy(28,23);  write('Poner guion(-) en Matricula');
    gotoxy(59,23); write('Teclado para escribir');
    gotoxy(1,y);  writeln('         ');
   until(vestudiantes[x].matricula[5]='-');

   if vestudiantes[x].matricula='0' then break;

   //vasignatura[x].ano:=vestudiantes[x].ano;
   vasignatura[x].matricula:=vestudiantes[x].matricula;  //creando registro de asignaturas

   gotoxy(12,y); readln(vestudiantes[x].nombre);
   gotoxy(40,y); readln(vestudiantes[x].carrera);

   repeat
    gotoxy(59,y); readln(vestudiantes[x].sexo);
    if ((vestudiantes[x].sexo='f') or (vestudiantes[x].sexo='m')
      or (vestudiantes[x].sexo='M') or (vestudiantes[x].sexo='F')) then break;
    gotoxy(59,y);  writeln('    º     ');
    gotoxy(59,y);  writeln('ERROR!');
    clrmsj; gotoxy((80-length('ERROR! SEXO es F o M')) div 2,23);
    write('ERROR! SEXO es F o M');
    delay(2000);
    clrmsj;
    gotoxy(2,23);  write('<0 en Matricula = Salir>');
    gotoxy(28,23);  write('Poner guion(-) en Matricula');
    gotoxy(59,23); write('Teclado para escribir');

    gotoxy(59,y);  writeln('    º     ');
   until((vestudiantes[x].sexo='f') or (vestudiantes[x].sexo='m')
      or (vestudiantes[x].sexo='M') or (vestudiantes[x].sexo='F'));
   inc(vestudiantes[x].mtr);

   inc(y);

  end;

   if vestudiantes[x].matricula='0' then
   vestudiantes[x].matricula:='';


  clrpart;
  gotoxy((80-length('Listo!')) div 2,5);write('Listo!');
  Cuadro(1,13,80,15);
  gotoxy((80-length('Listo! Los arreglos estan completos')) div 2,14);
  write('Listo! Los arreglos estan completos');
  listo(23);


end;


//////////////Mostrando contenido de records estudiantes///////////////


procedure mostrarest;
var
 x,y,z,c:integer;

begin

 clrpart;
 fecha;
 gotoxy((80-length('Mostrando Estudiantes')) div 2,5);
 write('Mostrando Estudiantes');

 gotoxy(1,7);  write('Matricula:');
 gotoxy(12,7); write('Nombre:');
 gotoxy(40,7); write('Carrera:');
 gotoxy(59,7); write('Sexo:');

 for c:=8 to 21 do
  begin

   gotoxy(11,c); write('º');
   gotoxy(39,c); write('º');
   gotoxy(58,c); write('º');
   gotoxy(63,c); write('º');

  end;

 for z:=1 to 79 do
  begin

   gotoxy(z,8); write('Í');

  end;

  y:=9;

 for x:=1 to l do
  if vestudiantes[x].matricula<>'0' then
   begin

    {gotoxy(1,y); writeln(vestudiantes[x].ano:4);
    gotoxy(5,y); write('-');}
    if vestudiantes[x].mtr=0 then break;
    gotoxy(1,y); writeln(vestudiantes[x].matricula);
    gotoxy(12,y); writeln(vestudiantes[x].nombre);
    gotoxy(40,y); writeln(vestudiantes[x].carrera);
    gotoxy(59,y); writeln(vestudiantes[x].sexo);
    gotoxy(64,y); write('Asignaturas');
    inc(y);

   end;

  listo(23);

end;

//////////////Digitando Asignaturas///////////////

procedure registrarasig;
var
 x,y,z,c,x1,x2:integer;

begin
 clrpart;
 fecha;
 gotoxy((80-length('Regitrar Asignatura')) div 2,5);
 write('Regitrar Asignatura');

 gotoxy(1,7);  write('Matricula:');
 gotoxy(12,7); write('Codigo');               //encabezado
 gotoxy(23,7); write('Asignatura:');
 gotoxy(60,7); write('Laboratorio:');

 gotoxy(8,23);  write('0 en asignatura  = Salir');
                                                      //mensajes
 gotoxy(39,23); write('Teclado para escribir');



 for c:=8 to 21 do
  begin

   gotoxy(11,c); write('º');
   gotoxy(22,c); write('º');
   gotoxy(59,c); write('º');


  end;

 for z:=1 to 79 do
  begin

   gotoxy(z,8); write('Í');

  end;


  y:=9;

 for x:=1 to l do

  begin


   gotoxy(1,y); writeln(vasignatura[x].matricula);
   if vestudiantes[x].mtr=0 then break;

    for x1:=1 to l1 do

      begin
       if vasignatura[x].materia[x1]='0' then break;

       repeat
        gotoxy(23,y); readln(vasignatura[x].materia[x1]);
        if vasignatura[x].materia[x1]='0' then break;



        for x2:=1 to l2 do
         begin
          if vasignatura[x].materia[x1]='0' then break;
          if (vasignatura[x].materia[x1]=arreglomateria[x2]) then break;

          if (vasignatura[x].materia[x1]<>arreglomateria[l2]) and (x2=l2) then
           begin
            gotoxy(23,y); writeln('ERROR! No existe esta materia');
            clrmsj; gotoxy((80-length('Revisar asignaturas del pensum')) div 2,23);
            write('Revisar asignaturas del pensum');
            delay(2000);
            clrmsj;
            gotoxy(8,23);  write('0 en asignatura  = Salir');
            gotoxy(39,23); write('Teclado para escribir');
            gotoxy(23,y); writeln('                             ')
           end;
         end;



     until (vasignatura[x].materia[x1]=arreglomateria[x2])
             or (vasignatura[x].materia[x1]='0') ;

         inc(vasignatura[x].asig[x1]);

       if vasignatura[x].materia[x1]='0' then break;

      vasignatura[x].codigo[x1]:=arreglocodigo[x2];
      gotoxy(12,y); write(vasignatura[x].codigo[x1]);

      vasignatura[x].lab[x1]:=arreglolab[x2];
      gotoxy(60,y); write(vasignatura[x].lab[x1]);


      if y<22 then
       inc(y)
      else
       begin
        y:=9;
       end;

       if vasignatura[x].materia[x1]='0' then break;
     end;
     if vasignatura[x].materia[x1]='0'  then
     vasignatura[x].materia[x1]:='';
  end;


  clrpart;
  fecha;
  Cuadro(1,13,80,15);
  gotoxy((80-length('Listo! Los arreglos estan completos')) div 2,14);
  write('Listo! Los arreglos estan completos');
  listo(23);


end;

//////////////validacion estudiante para ver sus asignatura///////////////

procedure selecionasig;
//var
//x,y,almA,almB:integer;
begin
 clrpart;
 //for x:=1 to l do
 // almA:=vestudiantes[x].mtr+almA;
 //if (almA<>0) then
 if (vestudiantes[1].mtr<>0) then
  begin

    registrarasig;

  end

 else
 //for y:=1 to l do
 //almB:=vestudiantes[y].mtr+almB
 //if (almA=0) then

  begin
   fecha;
   textcolor(red);
   Cuadro(1,13,80,15);
   textcolor(white);
   gotoxy((80-length('Error! No hay ningun registro de estudiante creado')) div 2,14);
   write('Error! No hay ningun registro de estudiante creado');
   listo(23);

  end;


end;

//////////////Mostrando asignaturas del estudiante seleccionado///////////////

procedure asignat(x:integer);
var
c,z,x1,y:integer;
 begin
    clrpart;
    fecha;
    gotoxy((80-length('Mostrando Calificaciones')) div 2,5);
    write('Mostrando Calificaciones');

    gotoxy(1,7);  write('Matricula:');
    gotoxy(12,7); write('Codigo');
    gotoxy(23,7); write('Asignatura:');
    gotoxy(60,7); write('Laboratorio:');




 for c:=8 to 21 do
  begin
   gotoxy(11,c); write('º');
   gotoxy(22,c); write('º');
   gotoxy(59,c); write('º');

  end;

 for z:=1 to 79 do
  begin
   gotoxy(z,8); write('Í');
  end;

  y:=9;




   {gotoxy(1,y); writeln(vasignatura[x].ano);
   gotoxy(5,y); write('-');}
   gotoxy(1,y); writeln(vasignatura[x].matricula);


    for x1:=1 to l1 do
      begin

       if vasignatura[x].asig[x1]=0 then break;
       gotoxy(23,y); write(vasignatura[x].materia[x1]);

       gotoxy(12,y); write(vasignatura[x].codigo[x1]);

       gotoxy(60,y); write(vasignatura[x].lab[x1]);
     y:=y+1;
     end;

end;

//////////////Seleccionar estudiante para ver su calificaion///////////////

procedure mostrarcal;
var
 x,y,z,c,c2,f2:integer;
 t2:char;
begin
 clrpart;
 fecha;
 gotoxy((80-length('Selecione una calificacion')) div 2,5);
 write('Selecione una calificacion');

 gotoxy(1,7);  write('Matricula:');
 gotoxy(12,7); write('Nombre:');
 gotoxy(40,7); write('Carrera:');
 gotoxy(59,7); write('Sexo:');

 for c:=8 to 21 do
  begin

   gotoxy(11,c); write('º');
   gotoxy(39,c); write('º');
   gotoxy(58,c); write('º');
   gotoxy(63,c); write('º');

  end;

 for z:=1 to 79 do
  begin

   gotoxy(z,8); write('Í');

  end;

  y:=9;
 for x:=1 to l do
  if (vestudiantes[x].matricula<>'0') or (vestudiantes[x].matricula<>' ') or (vestudiantes[x].mtr<>0) then
   begin

    if vestudiantes[x].mtr=0 then break;
    gotoxy(1,y); writeln(vestudiantes[x].matricula);

    gotoxy(12,y); writeln(vestudiantes[x].nombre);
    gotoxy(40,y); writeln(vestudiantes[x].carrera);
    gotoxy(59,y); writeln(vestudiantes[x].sexo);
    if vasignatura[x].asig[1]<>0 then
    begin
    gotoxy(64,y); write('Asignatura');        //solo se escribe si existe registro de asignatura
    end;

    inc(y);
   end;


   gotoxy(8,23);  write('Esc=Salir');
   gotoxy(21,23); write(#24'=Mover arriba');
   gotoxy(39,23); write(#25'=Mover abajo');
   gotoxy(55,23); write('Enter=Seleccionar');

 c2:=78; f2:=9;
 gotoxy(c2,f2);  write('- ');
  repeat

    t2:=readkey;
     case t2 of

  #72:begin //arriba
   if (f2>9) then
   dec(f2)
   else
    begin
    gotoxy(c2,f2);write('   ');
   f2:=9+l-1;//cambiar cada vez que se aplien los arreglos l1 del menu
    end;

      end;

  #80:begin //abajo
   if (f2<9+l-1) then //cambiar cada vez que se aplien los arreglos l1 del menu
   inc(f2)
   else
   begin
     gotoxy(c2,f2);write('   ');
    f2:=9;
    end;
      end;

    end;
   textcolor(yellow);
   gotoxy(c2,f2-1);write('   ');
   gotoxy(c2,f2);  write('- ');
   gotoxy(c2,f2+1);write('   ');
   textcolor(white);


   if (t2=#13) and (f2=9) and
     (vestudiantes[1].mtr<>0){or
      (vestudiantes[1].matricula<>'')or
      (vestudiantes[1].matricula<>' '))}  and

       (vasignatura[1].asig[1]<>0) {or
        (vasignatura[1].materia[1]<>'')  or
        (vasignatura[1].materia[1]<>' '))}  then
      begin
   asignat(1);
   listo(23);
   t2:=#27;
   end
   else
   if (t2=#13) and (f2=9) then
   begin
   gotoxy(64,f2);write('No hay regitro');
   delay(100);

   end;

   if (t2=#13) and (f2=10) and
   (vestudiantes[2].mtr<>0){or
   (vestudiantes[2].matricula<>'')or
   (vestudiantes[2].matricula<>' ')} and

   (vasignatura[2].asig[1]<>0) {or
      (vasignatura[2].materia[1]<>'')  or
      (vasignatura[2].materia[1]<>' ')}  then
      begin
   asignat(2);
   listo(23);
   t2:=#27;
   end
   else
   if (t2=#13) and (f2=10) then
   begin
   gotoxy(64,f2);write('No hay regitro');
   delay(100);

   end;

   if (t2=#13) and (f2=11) and
   (vestudiantes[3].mtr<>0){
    or(vestudiantes[3].matricula<>' ')
    or (vestudiantes[3].matricula<>'')} and

     (vasignatura[3].asig[1]<>0){ or
      (vasignatura[3].materia[1]<>'')  or
      (vasignatura[3].materia[1]<>' ')}  then
      begin
   asignat(3);
   listo(23);
   t2:=#27;
   end
   else
   if (t2=#13) and (f2=11) then
   begin
   gotoxy(64,f2);write('No hay regitro');
   delay(100);

   end;

   if (t2=#13) and (f2=12) and
   (vestudiantes[4].mtr<>0) {or
   (vestudiantes[4].matricula<>'')   or
   (vestudiantes[4].matricula<>' ')} and
     (vasignatura[4].asig[1]<>0) {or
      (vasignatura[4].materia[1]<>'')  or
      (vasignatura[4].materia[1]<>' ')}  then
      begin
   asignat(4);
   listo(23);
   t2:=#27;
   end
   else
   if (t2=#13) and (f2=12) then
   begin
   gotoxy(64,f2);write('No hay regitro');
   delay(100);

   end;

   if (t2=#13) and (f2=13) and (vestudiantes[5].mtr<>0)
   {or (vestudiantes[5].matricula<>'')or
   (vestudiantes[5].matricula<>' ')} and

     (vasignatura[5].asig[1]<>0){ or
      (vasignatura[5].materia[1]<>'')  or
      (vasignatura[5].materia[1]<>' ')}  then
      begin
   asignat(5);
   listo(23);
   t2:=#27;
   end
   else
   if (t2=#13) and (f2=13) then
   begin
   gotoxy(64,f2);write('No hay regitro');
   delay(100);

   end;


  until(t2=#27);
end;

/////////////////Buscador por sexo/////////////////

procedure buscarsex;
var
 sex :char;
 x,y,c,z:integer;
begin


 y:=9;

 clrpart;


 gotoxy(1,7);  write('Matricula:');
 gotoxy(12,7); write('Nombre:');
 gotoxy(40,7); write('Carrera:');
 gotoxy(59,7); write('Sexo:');

 for c:=8 to 21 do
  begin

   gotoxy(11,c); write('º');
   gotoxy(39,c); write('º');
   gotoxy(58,c); write('º');
   gotoxy(63,c); write('º');

  end;

 for z:=1 to 79 do
  begin

   gotoxy(z,8); write('Í');

  end;
  gotoxy((80-length('Teclado para escribir')) div 2,23);
  write('Teclado para escribir');


  textcolor(yellow);
  gotoxy((80-length('Introdusca la carrera que quiere buscar')) div 2,5);
  write('Introdusca la carrera que quiere buscar');
  textcolor(white);


 // repeat

   gotoxy(59,y); readln(sex);   //problema con la lectura de esta variable
                                    //repeat fue la solucion
//  until(carrera<>'');

 for x:=1 to l do
   if sex=vestudiantes[x].sexo then

    begin
     if vestudiantes[x].matricula='0' then break;
     {gotoxy(1,y); writeln(vestudiantes[x].ano);
     gotoxy(5,y); write('-');}
     gotoxy(1,y); writeln(vestudiantes[x].matricula);

     gotoxy(12,y); writeln(vestudiantes[x].nombre);
     gotoxy(40,y); writeln(vestudiantes[x].carrera);
     gotoxy(59,y); writeln(vestudiantes[x].sexo);


     y:= y+1;

   end;

     if y=9 then
      begin

       clrpart;
       fecha;
       textcolor(red);
       Cuadro(1,13,80,15);
       textcolor(white);
       gotoxy((80-length('no se ha encontrado ninguna carrera con ese nombre')) div 2,14);
       write('No se ha encontrado ninguna carrera llamado ',sex);
       listo(23);

      end

    else

    begin

     gotoxy((80-length('Introdusca el cargo que            quiere buscar')) div 2,5);
                 write('                                                ');
     gotoxy((80-length('Listo!')) div 2,5);write('Listo!');

     listo(23);
    end;


end;

/////////////////Buscador por nombre/////////////////

procedure buscarnom;
var
 nomb :string[45];
 x,y,c,z:integer;
begin


 y:=9;

 clrpart;


 gotoxy(1,7);  write('Matricula:');
 gotoxy(12,7); write('Nombre:');
 gotoxy(40,7); write('Carrera:');
 gotoxy(59,7); write('Sexo:');

 for c:=8 to 21 do
  begin

   gotoxy(11,c); write('º');
   gotoxy(39,c); write('º');
   gotoxy(58,c); write('º');
   gotoxy(63,c); write('º');

  end;

 for z:=1 to 79 do
  begin

   gotoxy(z,8); write('Í');

  end;
  gotoxy((80-length('Teclado para escribir')) div 2,23);
  write('Teclado para escribir');


  textcolor(yellow);
  gotoxy((80-length('Introdusca la carrera que quiere buscar')) div 2,5);
  write('Introdusca la carrera que quiere buscar');
  textcolor(white);


  repeat

   gotoxy(40,y); readln(nomb);   //problema con la lectura de esta variable
                                    //repeat fue la solucion
  until(nomb<>'');

 for x:=1 to l do
   if nomb=vestudiantes[x].nombre then

    begin
     if vestudiantes[x].matricula='0' then break;
     {gotoxy(1,y); writeln(vestudiantes[x].ano);
     gotoxy(5,y); write('-');}
     gotoxy(1,y); writeln(vestudiantes[x].matricula);

     gotoxy(12,y); writeln(vestudiantes[x].nombre);
     gotoxy(40,y); writeln(vestudiantes[x].carrera);
     gotoxy(59,y); writeln(vestudiantes[x].sexo);


     y:= y+1;

   end;

     if y=9 then
      begin

       clrpart;
       fecha;
       textcolor(red);
       Cuadro(1,13,80,15);
       textcolor(white);
       gotoxy((80-length('no se ha encontrado ninguna carrera con ese nombre')) div 2,14);
       write('No se ha encontrado ninguna carrera llamado ',nomb);
       listo(23);

      end

    else

    begin

     gotoxy((80-length('Introdusca el cargo que            quiere buscar')) div 2,5);
                 write('                                                ');
     gotoxy((80-length('Listo!')) div 2,5);write('Listo!');

     listo(23);
    end;


end;

/////////////////Buscador por carrera/////////////////

procedure buscar;
var
 carrera :string[30];
 x,y,c,z:integer;
begin


 y:=9;

 clrpart;


 gotoxy(1,7);  write('Matricula:');
 gotoxy(12,7); write('Nombre:');
 gotoxy(40,7); write('Carrera:');
 gotoxy(59,7); write('Sexo:');

 for c:=8 to 21 do
  begin

   gotoxy(11,c); write('º');
   gotoxy(39,c); write('º');
   gotoxy(58,c); write('º');
   gotoxy(63,c); write('º');

  end;

 for z:=1 to 79 do
  begin

   gotoxy(z,8); write('Í');

  end;
  gotoxy((80-length('Teclado para escribir')) div 2,23);
  write('Teclado para escribir');


  textcolor(yellow);
  gotoxy((80-length('Introdusca la carrera que quiere buscar')) div 2,5);
  write('Introdusca la carrera que quiere buscar');
  textcolor(white);


  repeat

   gotoxy(40,y); readln(carrera);   //problema con la lectura de esta variable
                                    //repeat fue la solucion
  until(carrera<>'');

 for x:=1 to l do
   if carrera=vestudiantes[x].carrera then

    begin
     if vestudiantes[x].matricula='0' then break;
     {gotoxy(1,y); writeln(vestudiantes[x].ano);
     gotoxy(5,y); write('-');}
     gotoxy(1,y); writeln(vestudiantes[x].matricula);

     gotoxy(12,y); writeln(vestudiantes[x].nombre);
     gotoxy(40,y); writeln(vestudiantes[x].carrera);
     gotoxy(59,y); writeln(vestudiantes[x].sexo);


     y:= y+1;

   end;

     if y=9 then
      begin

       clrpart;
       fecha;
       textcolor(red);
       Cuadro(1,13,80,15);
       textcolor(white);
       gotoxy((80-length('no se ha encontrado ninguna carrera con ese nombre')) div 2,14);
       write('No se ha encontrado ninguna carrera llamado ',carrera);
       listo(23);

      end

    else

    begin

     gotoxy((80-length('Introdusca el cargo que            quiere buscar')) div 2,5);
                 write('                                                ');
     gotoxy((80-length('Listo!')) div 2,5);write('Listo!');

     listo(23);
    end;


end;

///////////////////Buscador por matricula////////////////

procedure buscarmat;
var
 {an,}mat:{integer}string[9];
 x,y,c,z:integer;
begin


 y:=9;

 clrpart;


 gotoxy(1,7);  write('Matricula:');
 gotoxy(12,7); write('Nombre:');
 gotoxy(40,7); write('Carrera:');
 gotoxy(59,7); write('Sexo:');

 for c:=8 to 21 do
  begin

   gotoxy(11,c); write('º');
   gotoxy(39,c); write('º');
   gotoxy(58,c); write('º');
   gotoxy(63,c); write('º');

  end;

 for z:=1 to 79 do
  begin

   gotoxy(z,8); write('Í');

  end;

  gotoxy((80-length('Teclado para escribir')) div 2,23);
  write('Teclado para escribir');


  textcolor(yellow);
  gotoxy((80-length('Introdusca la carrera que quiere buscar')) div 2,5);
  write('Introdusca la matricula que quiere buscar');
  textcolor(white);

  {gotoxy(1,y);readln(an);
  gotoxy(5,y); write('-');}
  repeat

   gotoxy(1,y); readln(mat);

  until(mat<>'');

 for x:=1 to l do
   if {(an=vestudiantes[x].ano) and} (mat=vestudiantes[x].matricula) then

    begin

    if vestudiantes[x].matricula='0' then break;
   {gotoxy(1,y); writeln(vestudiantes[x].ano);
   gotoxy(5,y); write('-');}
   gotoxy(1,y); writeln(vestudiantes[x].matricula);


   gotoxy(12,y); writeln(vestudiantes[x].nombre);
   gotoxy(40,y); writeln(vestudiantes[x].carrera);
   gotoxy(59,y); writeln(vestudiantes[x].sexo);


     y:= y+1;

   end;

     if y=9 then
    begin
     clrpart;
     fecha;
     textcolor(red);
     Cuadro(1,13,80,15);
     textcolor(white);
     gotoxy((80-length('no se ha encontrado ninguna carrera con ese nombre')) div 2,14);
     write('No se ha encontrado ninguna matricula llamado '{,an,'-'},mat);
     listo(23);
    end
    else
    begin
     gotoxy((80-length('Introdusca el cargo            que quiere buscar')) div 2,5);
                 write('                                                ');
     gotoxy((80-length('Listo!')) div 2,5);write('Listo!');

     listo(23)
    end;


end;

/////////////Ordenamiento por burbuja segun matricula//////////////


procedure burbuja;
var
 x,y:integer;
 t:restudiantes;
 t2:rasignatura;
begin
 clrpart;
 fecha;

 Cuadro(1,10,80,12);
 gotoxy((80-length('Ordenando por Matricula')) div 2,11);
 write('Ordenando por Matricula');
 for x:= 1 to l do
  for y:=1 to l-1 do
   begin
    if {(vestudiantes[y].ano>vestudiantes[y+1].ano)} (vestudiantes[y].matricula>vestudiantes[y+1].matricula) then
     begin

      t:=vestudiantes[y];
      vestudiantes[y]:=vestudiantes[y+1];
      vestudiantes[y+1]:=t;

      t2:=vasignatura[y];
      vasignatura[y]:=vasignatura[y+1];
      vasignatura[y+1]:=t2;

     end;

    {if (vestudiantes[y].ano=vestudiantes[y+1].ano) and
    (vestudiantes[y].matricula>vestudiantes[y+1].matricula)  then
     begin

      t:=vestudiantes[y];
      vestudiantes[y]:=vestudiantes[y+1];
      vestudiantes[y+1]:=t;

      t2:=vasignatura[y];
      vasignatura[y]:=vasignatura[y+1];
      vasignatura[y+1]:=t2;

     end;}
   end;
  gotoxy((80-length('Listo!')) div 2,5);write('Listo!');
  gotoxy((80-length('Listo!')) div 2,15);write('Listo!');
  listo(23);

end;

/////////////Ordenamiento por burbuja segun Carrera//////////////

procedure burbujacarrera;
var
 x,y:integer;
 t:restudiantes;
 t2:rasignatura;

begin

 clrpart;
 fecha;
 Cuadro(1,10,80,12);
 gotoxy((80-length('Ordenando por Matricula')) div 2,11);
 write('Ordenando por Carrera');
 for x:= 1 to l do
  for y:=1 to l-1 do
   if (vestudiantes[y].carrera>vestudiantes[y+1].carrera) then
    begin

     t:=vestudiantes[y];
     vestudiantes[y]:=vestudiantes[y+1];
     vestudiantes[y+1]:=t;

     t2:=vasignatura[y];
     vasignatura[y]:=vasignatura[y+1];
     vasignatura[y+1]:=t2;

    end;


  gotoxy((80-length('Listo!')) div 2,15);write('Listo!');
  gotoxy((80-length('Listo!')) div 2,5); write('Listo!');
  listo(23);

end;

/////////////Guardar en archivo.txt//////////////


procedure guardar;
var
 archivo:text;
 nomarchivo:string[10];
 x,y:integer;

begin

  nomarchivo:='Inscripcion'; //nombre del archivo

  assign(archivo,'C:\'+nomarchivo+'.txt');    //creando archivo

  rewrite(archivo);                       //abriendo archivo para escritura

  writeln(archivo,'                Registro: ');
  write(archivo,'Matricula:   ');
  write(archivo,'Nombre:       ');
  write(archivo,'Carrera:     ');
  writeln(archivo,'Sexo:   ');
  write(archivo,'Codigo: ');
  write(archivo,'Asignatura:    ');
  writeln(archivo,'Laboratorio:  ');


   for x:=1 to l do
    begin
      if vestudiantes[x].matricula='0' then break;
      write(archivo,{vestudiantes[x].ano,'-',}vestudiantes[x].matricula,'    ');
      write(archivo,vestudiantes[x].nombre,'       ');
      write(archivo,vestudiantes[x].carrera,'     ');
      writeln(archivo,vestudiantes[x].sexo,'    ');
        for y:=1 to l1 do
         begin
           if (vasignatura[x].materia[y]='0') or (vasignatura[x].materia[y]='') then break;
           write(archivo,vasignatura[x].codigo[y],'    ');
           write(archivo,vasignatura[x].materia[y],'    ');
           writeln(archivo,vasignatura[x].lab[y],'    ');

         end;

    end;


 close(archivo);  //cerrando archivo


end;

//////////////////Ver asignaturas del pensum///////////////

Procedure pensum;
var
 x,c,z,y:integer;
begin
  clrpart;
  fecha;
  gotoxy((80-length('Lista de Materias')) div 2,5);write('Lista de Materias');

    gotoxy(1,7); write('Codigo');
    gotoxy(20,7); write('Asignatura:');
    gotoxy(55,7); write('Laboratorio:');




 for c:=7 to 21 do
  begin

   gotoxy(19,c); write('º');
   gotoxy(54,c); write('º');

  end;

 for z:=1 to 79 do
  begin
   gotoxy(z,8); write('Í');
  end;

  y:=9;





    for x:=1 to l2 do
      begin


       gotoxy(1,y); write(arreglocodigo[x]);

       gotoxy(20,y); write(arreglomateria[x]);

       gotoxy(55,y); write(arreglolab[x]);
     y:=y+1;
     end;

    listo(23);

end;





/////////////////Cuerpo del programa//////////////////////

begin
 c1:=8; f1:=9;
 textbackground(blue);
 textcolor(white);
 inicio;


 repeat

  Cuadro(1,1,80,6);

  gotoxy((80-length(T1)) div 2,2); write(T1);
  gotoxy((80-length(T2)) div 2,3); write(T2);  //parte superior
  gotoxy((80-length(T4)) div 2,4); write(T4);
  gotoxy((80-length(T3)) div 2,5); write(T3);
  gotoxy(70,5);
  write('2012-1993');

  Cuadro(1,22,80,24);

  gotoxy(8,23);  write('Esc=Salir');
  gotoxy(21,23); write(#24'=Mover arriba');   //forma de manejo
  gotoxy(39,23); write(#25'=Mover abajo');
  gotoxy(55,23); write('Enter=Seleccionar');

  gotoxy(50,25);
  write('Usuario:',usuario);
  gotoxy(3,25);
  write('Tab=Instruciones');

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
    gotoxy(10,f1); write(arreglotitulo[f1]);
   f1:=16;//cambiar cada vez que se aplien las opciones del menu
    end;

      end;




  #80:begin //abajo
   if (f1<16) then //cambiar cada vez que se aplien las opciones del menu
   inc(f1)
   else
   begin
     gotoxy(c1,f1);write('   ');
     gotoxy(10,f1); write(arreglotitulo[f1]);
    f1:=9;
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

    gotoxy(10,8);  write('  Registrar:');
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

   Cuadro(1,22,80,24);
   titulo;

   end;

   if (t=#13) and (f1=9) then
   begin
    fecha;
    registrarest;
    titulo;

   end;


   if (t=#13) and (f1=11) then
   begin

    clrpart;
    fecha;

    cuadritopar(1,7,80,21);

    gotoxy(2,23);
    write('<0=Volver Atras>');

    gotoxy((80-length('Teclado para escribir')) div 2,23);
    write('Teclado para escribir');
    gotoxy((80-length('Ordenador')) div 2,5); write('ORDENADOR');

    Cuadro(2,13,79,15);
    gotoxy(10,14); write('1=Ordenar por Matricula');
    gotoxy(50,14); write('2=Ordenar por Carrera');
    Cuadritopar(34,18,46,20);
    gotoxy(40,19);read(op);

    if op=0 then
     begin

      titulo;

     end;

    if op=1 then
     begin

      burbuja;
      titulo;

     end;

    if op=2 then
     begin

      burbujacarrera;
      titulo;

     end;

   end;


   if (t=#13) and (f1=10) then
    begin

     selecionasig;
     titulo;
    end;

    if (t=#13) and (f1=12) then
     begin
      mostrarest;
      titulo;

     end;

     if (t=#13) and (f1=13) then
     begin
      mostrarcal;
      titulo;

     end;

     if (t=#13) and (f1=14) then
     begin

      clrpart;

      fecha;
       cuadritopar(1,7,80,21);

      gotoxy((80-length('Buscador')) div 2,5); write('BUSCANDOR');
      gotoxy(2,23);
      write('<0=Volver Atras>');
      gotoxy((80-length('Teclado para escribir')) div 2,23);
      write('Teclado para escribir');
      Cuadro(2,9,79,11);
      gotoxy(14,10); write('1=Buscar por Sexo');
      gotoxy(50,10); write('2=Buscar por Nombre');
      Cuadro(2,13,79,15);
      gotoxy(11,14); write('3=Buscar por Matricula');
      gotoxy(50,14); write('4=Buscar por Carrera');
      Cuadritopar(34,18,46,20);
      gotoxy(40,19);read(op);

      if op=3 then
       begin
        buscarmat;
        titulo;
       end;

      if op=4 then
       begin
        buscar;
        titulo;
       end;

      if op=1 then
       begin
        buscarsex;
        titulo;
       end;

      if op=2 then
       begin
        buscarnom;
        titulo;
       end;

      if op=0 then
       begin

        titulo;
       end;


   end;

   if (t=#13) and (f1=15) then
    begin
     pensum;
     titulo;
    end;

   if (t=#13) and (f1=16) then
    begin
     t:=#27;

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
   guardar;
   op:=op-1;
  end;


until(op=0);

end.


