program MenuEstudiantes;
uses crt;

const
T1='UCATECI';
T2='PROGRAMACION 1';  //titulos superiores
T3='MENU PRINCIPAL';
T4='REGISTRO DE ESTUDIANTES';

l=5;//contante de los limetes de los arreglos
l1=5;//limite de las asignaturas

type

 restudiantes=record
  ano:integer;
  matricula:integer;   //records de informacion de estudiantes
  nombre:string[40];
  carrera:string[30];
  sexo:char;
 end;

 rcalificacion=record          //records de calificacion de estudiantes
  ano,matricula:integer;
  asignatura:array[1..l1] of  string[20];
  pp,sp,ef,tp,ti,total:array [1..l1] of integer;
  letra:array [1..l1] of char;
  end;

var

vestudiantes:array [1..l] of restudiantes;    //arreglos
vcalificacion :array[1..l] of rcalificacion;
t:char;
op:integer;
c1,f1:integer;   //ubicion

//////////////listo///////////////

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

//////////////Dibujo Cuadro pequeno///////////////

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
 gotoxy(79,14);write('¿'); //esquinas
 gotoxy(79,16);write('Ù');
 gotoxy(2,14);write('Ú');

end;

///////////// Dibujo de "cargando" ///////////////

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

//////////////Impresion de Titulos///////////////

procedure titulo;
var
 x,y:integer;

begin
 clrscr;
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



  Cuadro(1,1,80,6);

  gotoxy((80-length(T1)) div 2,2); write(T1);
  gotoxy((80-length(T2)) div 2,3); write(T2);  //parte superior
  gotoxy((80-length(T3)) div 2,4); write(T3);
  gotoxy((80-length(T4)) div 2,5); write(T4);

  gotoxy(10,9);  write('  Registrar Estudiantes');
  gotoxy(10,10); write('  Registrar Calificacion');
  gotoxy(10,11); write('  Ordenar Estudiantes');       //opciones
  gotoxy(10,12); write('  Mostrar Los Estudiantes');
  gotoxy(10,13); write('  Mostrar Calificacion Por Estudiantes');
  gotoxy(10,14); write('  Buscar Estudiante');

  gotoxy(10,15); write('  Salir');

  Cuadro(1,22,80,24);

  gotoxy(8,23);  write('Esc=Salir');
  gotoxy(21,23); write(#24'=Mover arriba');   //forma de manejo
  gotoxy(39,23); write(#25'=Mover abajo');
  gotoxy(55,23); write('Enter=Seleccionar');

  gotoxy({(80-length('Wilson Acevedo - 2012-1993')) div 2}3,25);
  write('Wilson Acevedo - 2012-1993');
  gotoxy({(80-length('Wilson Acevedo - 2012-1993')) div 2}50,25);
  write('Tab=Instruciones');


  c1:=9; f1:=9;

  gotoxy(c1,f1-1);write('   ');
  gotoxy(c1,f1+1);write('   ');
  gotoxy(c1,f1);  write('- ');


end;

//////////////Registrar estudiantes///////////////

procedure registrarest;
var
x,y,z,c:integer;
begin

 clrscr;
 Cuadro(1,1,80,3);
 gotoxy((80-length('Regitrar Estudiantes')) div 2,2);
 write('Regitrar Estudiantes');

 gotoxy(1,5);  write('Matricula:');
 gotoxy(12,5); write('Nombre:');
 gotoxy(40,5); write('Carrera:');
 gotoxy(59,5); write('Sexo:');


 Cuadro(1,22,80,24);

  gotoxy(8,23);  write('0 en Matricula = Salir');

  gotoxy(42,23); write('Teclado para escribir');



 for c:=6 to 21 do
  begin

   gotoxy(11,c); write('º');
   gotoxy(39,c); write('º'); //lineas desendentes, columnas que separan los datos
   gotoxy(58,c); write('º');
   gotoxy(63,c); write('º');

  end;

 for z:=1 to 79 do
  begin

   gotoxy(z,6); write('Í'); //linea horizontal que separa los titulos de los datos

  end;

  y:=7;

 for x:=1 to l do

  begin

   gotoxy(1,y); readln(vestudiantes[x].ano);
   if vestudiantes[x].ano=0 then break;
   gotoxy(5,y); write('-');
   gotoxy(6,y); readln(vestudiantes[x].matricula);


   vcalificacion[x].ano:=vestudiantes[x].ano;    //creando registro de calificacion
   vcalificacion[x].matricula:=vestudiantes[x].matricula;

   gotoxy(12,y); readln(vestudiantes[x].nombre);
   gotoxy(40,y); readln(vestudiantes[x].carrera);
   gotoxy(59,y); readln(vestudiantes[x].sexo);

   inc(y);

  end;




  clrscr;
  Cuadro(1,13,80,15);
  gotoxy((80-length('Listo! Los arreglos estan completos')) div 2,14);
  write('Listo! Los arreglos estan completos');
  listo(20);


end;


//////////////Mostrando contenido de records estudiantes///////////////


procedure mostrarest;
var
 x,y,z,c:integer;

begin

 clrscr;
 Cuadro(1,1,80,3);
 gotoxy((80-length('Mostrando Estudiantes')) div 2,2);
 write('Mostrando Estudiantes');

 gotoxy(1,5);  write('Matricula:');
 gotoxy(12,5); write('Nombre:');
 gotoxy(40,5); write('Carrera:');
 gotoxy(59,5); write('Sexo:');

 for c:=6 to 24 do
  begin

   gotoxy(11,c); write('º');
   gotoxy(39,c); write('º');
   gotoxy(58,c); write('º');
   gotoxy(63,c); write('º');

  end;

 for z:=1 to 79 do
  begin

   gotoxy(z,6); write('Í');

  end;

  y:=7;

 for x:=1 to l do
  if vestudiantes[x].ano<>0 then
   begin

    gotoxy(1,y); writeln(vestudiantes[x].ano);
    gotoxy(5,y); write('-');
    gotoxy(6,y); writeln(vestudiantes[x].matricula);
    gotoxy(12,y); writeln(vestudiantes[x].nombre);
    gotoxy(40,y); writeln(vestudiantes[x].carrera);
    gotoxy(59,y); writeln(vestudiantes[x].sexo);
    gotoxy(64,y); write('Calificaciones');
    inc(y);

   end;

  listo(4);

end;

//////////////Digitando calificacion///////////////

procedure registrarcal;
var
 x,y,z,c,x1:integer;

begin
 Cuadro(1,1,80,3);
 gotoxy((80-length('Regitrar Calificaciones')) div 2,2);
 write('Regitrar Calificaciones');

 gotoxy(1,5);  write('Matricula:');
 gotoxy(12,5); write('Asignatura:');
 gotoxy(40,5); write('PP:');
 gotoxy(45,5); write('SP:');
 gotoxy(50,5); write('EF:');
 gotoxy(55,5); write('TP:');
 gotoxy(60,5); write('TI:');
 gotoxy(65,5); write('Total:');
 gotoxy(71,5); write('Letra:');


 Cuadro(1,22,80,24);

  gotoxy(8,23);  write('0 en asignatura  = Salir');

  gotoxy(39,23); write('Teclado para escribir');



 for c:=6 to 21 do
  begin

   gotoxy(11,c); write('º');
   gotoxy(39,c); write('º');
   gotoxy(44,c); write('º');
   gotoxy(49,c); write('º');
   gotoxy(54,c); write('º');
   gotoxy(59,c); write('º');
   gotoxy(64,c); write('º');
   gotoxy(70,c); write('º');

  end;

 for z:=1 to 79 do
  begin

   gotoxy(z,6); write('Í');

  end;


  y:=7;

 for x:=1 to l do

  begin

   gotoxy(1,y); writeln(vcalificacion[x].ano);
   gotoxy(5,y); write('-');
   gotoxy(6,y); writeln(vcalificacion[x].matricula);
   if vcalificacion[x].ano=0 then break;

    for x1:=1 to l1 do
      begin
      gotoxy(12,y); readln(vcalificacion[x].asignatura[x1]);
      if vcalificacion[x].asignatura[x1]='0' then break;

   repeat
    gotoxy(40,y); writeln('    º');
    gotoxy(40,y); readln(vcalificacion[x].pp[x1]);
    if (vcalificacion[x].pp[x1]<=15)then break;      //primer parcial
    gotoxy(40,y); writeln('ERROR');delay(500);
   until (vcalificacion[x].pp[x1]<=15);

   repeat
    gotoxy(45,y); writeln('    º');
    gotoxy(45,y); readln(vcalificacion[x].sp[x1]);
    if (vcalificacion[x].sp[x1]<=20)then break;     //segundo parcial
    gotoxy(45,y); writeln('ERROR');delay(500);
   until (vcalificacion[x].sp[x1]<=20);

   repeat
    gotoxy(50,y); writeln('    º');
    gotoxy(50,y); readln(vcalificacion[x].ef[x1]);
    if (vcalificacion[x].ef[x1]<=25)then break;     //Examen final
    gotoxy(50,y); writeln('ERROR');delay(500);
   until (vcalificacion[x].ef[x1]<=25);


   repeat
    gotoxy(55,y); writeln('    º');
    gotoxy(55,y); readln(vcalificacion[x].tp[x1]);
    if (vcalificacion[x].tp[x1]<=25)then break;     //Trabajo practico
    gotoxy(55,y); writeln('ERROR');delay(500);
   until (vcalificacion[x].tp[x1]<=25);

   repeat
    gotoxy(60,y); writeln('    º');
    gotoxy(60,y); readln(vcalificacion[x].ti[x1]);
    if (vcalificacion[x].ti[x1]<=15)then break;     //Trabajo investigacion
    gotoxy(60,y); writeln('ERROR');delay(500);
   until (vcalificacion[x].ti[x1]<=15);



   vcalificacion[x].total[x1]:=(vcalificacion[x].pp[x1]+vcalificacion[x].sp[x1]+vcalificacion[x].ef[x1]+vcalificacion[x].tp[x1]+vcalificacion[x].ti[x1]);
   gotoxy(65,y); writeln(vcalificacion[x].total[x1]);   //determinar nota final

   case (vcalificacion[x].total[x1])   of

   90..100: vcalificacion[x].letra[x1]:='A';
   80..89:  vcalificacion[x].letra[x1]:='B';
   70..79:  vcalificacion[x].letra[x1]:='C';     //determinando letra
   60..69:  vcalificacion[x].letra[x1]:='D';
   0..59:   vcalificacion[x].letra[x1]:='F';

   end;

   gotoxy(72,y); writeln(vcalificacion[x].letra[x1]);

   if y<22 then
   inc(y)
   else
   begin
   //clrpart;
   y:=7;
   end;

     end;

  end;


  clrscr;
  Cuadro(1,13,80,15);
  gotoxy((80-length('Listo! Los arreglos estan completos')) div 2,14);
  write('Listo! Los arreglos estan completos');
  listo(20);


end;

//////////////validacion estudiante para ver su calificaion///////////////

procedure selecioncal;

begin
 clrscr;

 if vestudiantes[1].ano<>0 then
  begin

   registrarcal;

  end

 else

  begin

   textcolor(red);
   Cuadro(1,13,80,15);
   textcolor(white);
   gotoxy((80-length('Error! No hay ningun registro de estudiante creado')) div 2,14);
   write('Error! No hay ningun registro de estudiante creado');
   listo(25);

  end;


end;

//////////////Mostrando calificacion seleccionada///////////////

procedure calificaciones(x:integer);
var
c,z,x1,y:integer;
begin
    clrscr;
    Cuadro(1,1,80,3);
    gotoxy((80-length('Mostrando Calificaciones')) div 2,2);
    write('Mostrando Calificaciones');

    gotoxy(1,5);  write('Matricula:');
    gotoxy(12,5); write('Asignatura:');
    gotoxy(40,5); write('PP:');
    gotoxy(45,5); write('SP:');
    gotoxy(50,5); write('EF:');
    gotoxy(55,5); write('TP:');
    gotoxy(60,5); write('TI:');
    gotoxy(65,5); write('Total:');
    gotoxy(71,5); write('Letra:');



 for c:=6 to 21 do
  begin
   gotoxy(11,c); write('º');
   gotoxy(39,c); write('º');
   gotoxy(44,c); write('º');
   gotoxy(49,c); write('º');
   gotoxy(54,c); write('º');
   gotoxy(59,c); write('º');
   gotoxy(64,c); write('º');
   gotoxy(70,c); write('º');
  end;

 for z:=1 to 79 do
  begin
   gotoxy(z,6); write('Í');
  end;

  y:=7;




   gotoxy(1,y); writeln(vcalificacion[x].ano);
   gotoxy(5,y); write('-');
   gotoxy(6,y); writeln(vcalificacion[x].matricula);


    for x1:=1 to l1 do
       begin

       if ((vcalificacion[x].asignatura[x1]='0') or

      (vcalificacion[x].asignatura[x1]=' '))
      then break;

      gotoxy(12,y); writeln(vcalificacion[x].asignatura[x1]);


     gotoxy(40,y); writeln(vcalificacion[x].pp[x1]);

     gotoxy(45,y); writeln(vcalificacion[x].sp[x1]);

     gotoxy(50,y); writeln(vcalificacion[x].ef[x1]);

     gotoxy(55,y); writeln(vcalificacion[x].tp[x1]);

     gotoxy(60,y); writeln(vcalificacion[x].ti[x1]);

     gotoxy(65,y); writeln(vcalificacion[x].total[x1]);

     gotoxy(72,y); writeln(vcalificacion[x].letra[x1]);
     y:=y+1;
     end;

end;

//////////////Seleccionar estudiante para ver su calificaion///////////////

procedure mostrarcal;
var
 x,y,z,c,c2,f2:integer;
 t2:char;
begin
 clrscr;

 Cuadro(1,1,80,3);
 gotoxy((80-length('Selecione una calificacion')) div 2,2);
 write('Selecione una calificacion');

 gotoxy(1,5);  write('Matricula:');
 gotoxy(12,5); write('Nombre:');
 gotoxy(40,5); write('Carrera:');
 gotoxy(59,5); write('Sexo:');

 for c:=6 to 24 do
  begin

   gotoxy(11,c); write('º');
   gotoxy(39,c); write('º');
   gotoxy(58,c); write('º');
   gotoxy(63,c); write('º');

  end;

 for z:=1 to 79 do
  begin

   gotoxy(z,6); write('Í');

  end;

  y:=7;
 for x:=1 to l do
  if vestudiantes[x].ano<>0 then
   begin

    gotoxy(1,y); writeln(vestudiantes[x].ano);
    gotoxy(5,y); write('-');
    gotoxy(6,y); writeln(vestudiantes[x].matricula);

    gotoxy(12,y); writeln(vestudiantes[x].nombre);
    gotoxy(40,y); writeln(vestudiantes[x].carrera);
    gotoxy(59,y); writeln(vestudiantes[x].sexo);
    gotoxy(64,y); write('Calificaciones');
    inc(y);
   end;

   Cuadro(1,22,80,24);

   gotoxy(8,23);  write('Esc=Salir');
   gotoxy(21,23); write(#24'=Mover arriba');
   gotoxy(39,23); write(#25'=Mover abajo');
   gotoxy(55,23); write('Enter=Seleccionar');

 c2:=78; f2:=7;
 gotoxy(c2,f2);  write('- ');
  repeat

    t2:=readkey;
     case t2 of

  #72:begin //arriba
   if (f2>7) then
   dec(f2)
   else
    begin
    gotoxy(c2,f2);write('   ');
   f2:=7+l-1;//cambiar cada vez que se aplien los arreglos l1 del menu
    end;

      end;

  #80:begin //abajo
   if (f2<7+l-1) then //cambiar cada vez que se aplien los arreglos l1 del menu
   inc(f2)
   else
   begin
     gotoxy(c2,f2);write('   ');
    f2:=7;
    end;
      end;

    end;
   textcolor(yellow);
   gotoxy(c2,f2-1);write('   ');
   gotoxy(c2,f2);  write('- ');
   gotoxy(c2,f2+1);write('   ');
   textcolor(white);


   if (t2=#13) and (f2=7) and (vestudiantes[1].ano<>0)  and

     (vcalificacion[1].pp[1]<>0) {or
       (vcalificacion[1].asignatura[1]<>'')  or
       (vcalificacion[1].asignatura[1]<>' '))} then
      begin
   calificaciones(1);
   listo(4);
   t2:=#27;
   end
   else
   if (t2=#13) and (f2=7) then
   begin
   gotoxy(64,f2);write('No hay regitro');
   delay(100);

   end;

   if (t2=#13) and (f2=8) and (vestudiantes[2].ano<>0) and

     (vcalificacion[2].pp[1]<>0) {or
      (vcalificacion[2].asignatura[1]<>'')  or
      (vcalificacion[2].asignatura[1]<>' ') )} then
      begin
   calificaciones(2);
   listo(4);
   t2:=#27;
   end
   else
   if (t2=#13) and (f2=8) then
   begin
   gotoxy(64,f2);write('No hay regitro');
   delay(100);

   end;

   if (t2=#13) and (f2=9) and (vestudiantes[3].ano<>0) and

     (vcalificacion[3].pp[1]<>0){ or
      (vcalificacion[3].asignatura[1]<>'') or
      (vcalificacion[3].asignatura[1]<>' '))} then
      begin
   calificaciones(3);
   listo(4);
   t2:=#27;
   end
   else
   if (t2=#13) and (f2=9) then
   begin
   gotoxy(64,f2);write('No hay regitro');
   delay(100);

   end;

   if (t2=#13) and (f2=10) and (vestudiantes[4].ano<>0) and
     (vcalificacion[4].pp[1]<>0) {or
      (vcalificacion[4].asignatura[1]<>'') or
      (vcalificacion[4].asignatura[1]<>' '))} then
      begin
   calificaciones(4);
   listo(4);
   t2:=#27;
   end
   else
   if (t2=#13) and (f2=10) then
   begin
   gotoxy(64,f2);write('No hay regitro');
   delay(100);

   end;

   if (t2=#13) and (f2=11) and (vestudiantes[5].ano<>0)  and

     (vcalificacion[5].pp[1]<>0) {or
      (vcalificacion[5].asignatura[1]<>'') or
      (vcalificacion[5].asignatura[1]<>' '))} then
      begin
   calificaciones(5);
   listo(4);
   t2:=#27;
   end
   else
   if (t2=#13) and (f2=11) then
   begin
   gotoxy(64,f2);write('No hay regitro');
   delay(100);

   end;


  until(t2=#27);
end;

/////////////////Buscador por carrera/////////////////

procedure buscar;
var
 carrera :string[30];
 x,y,c,z:integer;
begin

 clrscr;
 y:=7;

 clrscr;
 Cuadro(1,1,80,3);
 gotoxy((80-length('Mostrando Estudiantes')) div 2,2);
 write('Mostrando Estudiantes');

 gotoxy(1,5);  write('Matricula:');
 gotoxy(12,5); write('Nombre:');
 gotoxy(40,5); write('Carrera:');
 gotoxy(59,5); write('Sexo:');

 for c:=6 to 24 do
  begin

   gotoxy(11,c); write('º');
   gotoxy(39,c); write('º');
   gotoxy(58,c); write('º');
   gotoxy(63,c); write('º');

  end;

 for z:=1 to 79 do
  begin

   gotoxy(z,6); write('Í');

  end;


  textcolor(yellow);
  gotoxy((80-length('Introdusca la carrera que quiere buscar')) div 2,4);
  write('Introdusca la carrera que quiere buscar');
  textcolor(white);


  repeat

   gotoxy(40,y); readln(carrera);   //problema con la lectura de esta variable
                                    //repeat fue la solucion
  until(carrera<>'');

 for x:=1 to l do
   if carrera=vestudiantes[x].carrera then

    begin
     if vestudiantes[x].ano=0 then break;
     gotoxy(1,y); writeln(vestudiantes[x].ano);
     gotoxy(5,y); write('-');
     gotoxy(6,y); writeln(vestudiantes[x].matricula);

     gotoxy(12,y); writeln(vestudiantes[x].nombre);
     gotoxy(40,y); writeln(vestudiantes[x].carrera);
     gotoxy(59,y); writeln(vestudiantes[x].sexo);


     y:= y+1;

   end;

     if y=7 then
      begin

       clrscr;
       Cuadro(1,13,80,15);
       gotoxy((80-length('no se ha encontrado ninguna carrera con ese nombre')) div 2,14);
       write('No se ha encontrado ninguna carrera llamado ',carrera);
       listo(19);

      end

    else

    begin

     gotoxy((80-length('Introdusca el cargo que            quiere buscar')) div 2,4);
                 write('                                                ');
     gotoxy((80-length('Listo!')) div 2,4);write('Listo!');
     readkey;

    end;


end;

///////////////////Buscador por matricula////////////////

procedure buscarmat;
var
 an,mat:integer;
 x,y,c,z:integer;
begin

 clrscr;
 y:=7;

 clrscr;
 Cuadro(1,1,80,3);
 gotoxy((80-length('Mostrando Estudiantes')) div 2,2);
 write('Mostrando Estudiantes');

 gotoxy(1,5);  write('Matricula:');
 gotoxy(12,5); write('Nombre:');
 gotoxy(40,5); write('Carrera:');
 gotoxy(59,5); write('Sexo:');

 for c:=6 to 24 do
  begin

   gotoxy(11,c); write('º');
   gotoxy(39,c); write('º');
   gotoxy(58,c); write('º');
   gotoxy(63,c); write('º');

  end;

 for z:=1 to 79 do
  begin

   gotoxy(z,6); write('Í');

  end;


  textcolor(yellow);
  gotoxy((80-length('Introdusca la carrera que quiere buscar')) div 2,4);
  write('Introdusca la matricula que quiere buscar');
  textcolor(white);

  gotoxy(1,y);readln(an);
  gotoxy(5,y); write('-');
  gotoxy(6,y); readln(mat);

 for x:=1 to l do
   if (an=vestudiantes[x].ano) and (mat=vestudiantes[x].matricula) then

    begin

    //if vestudiantes[x].ano=0 then break;
   gotoxy(1,y); writeln(vestudiantes[x].ano);
   gotoxy(5,y); write('-');
   gotoxy(6,y); writeln(vestudiantes[x].matricula);


   gotoxy(12,y); writeln(vestudiantes[x].nombre);
   gotoxy(40,y); writeln(vestudiantes[x].carrera);
   gotoxy(59,y); writeln(vestudiantes[x].sexo);


     y:= y+1;

   end;

     if y=7 then
    begin
     clrscr;
     Cuadro(1,13,80,15);
     gotoxy((80-length('no se ha encontrado ninguna carrera con ese nombre')) div 2,14);
     write('No se ha encontrado ninguna matricula llamado ',an,'-',mat);
     listo(19);
    end
    else
    begin
     gotoxy((80-length('Introdusca el cargo          que quiere buscar')) div 2,4);
                 write('                                              ');
     gotoxy((80-length('Listo!')) div 2,4);write('Listo!');
     readkey;
    end;


end;

/////////////Ordenamiento por burbuja segun matricula//////////////


procedure burbuja;
var
 x,y:integer;
 t:restudiantes;
 t2:rcalificacion;
begin
 clrscr;
 Cuadro(1,6,80,8);
 gotoxy((80-length('Ordenando por Matricula')) div 2,7);
 write('Ordenando por Matricula');
 for x:= 1 to l do
  for y:=1 to l-1 do
   begin
    if (vestudiantes[y].ano>vestudiantes[y+1].ano) then
     begin

      t:=vestudiantes[y];
      vestudiantes[y]:=vestudiantes[y+1];
      vestudiantes[y+1]:=t;

      t2:=vcalificacion[y];
      vcalificacion[y]:=vcalificacion[y+1];
      vcalificacion[y+1]:=t2;

     end;

    if (vestudiantes[y].ano=vestudiantes[y+1].ano) and
    (vestudiantes[y].matricula>vestudiantes[y+1].matricula)  then
     begin

      t:=vestudiantes[y];
      vestudiantes[y]:=vestudiantes[y+1];
      vestudiantes[y+1]:=t;

      t2:=vcalificacion[y];
      vcalificacion[y]:=vcalificacion[y+1];
      vcalificacion[y+1]:=t2;

     end;
   end;

  gotoxy((80-length('Listo!')) div 2,10);write('Listo!');
  listo(19);

end;

/////////////Ordenamiento por burbuja segun Carrera//////////////

procedure burbujacarrera;
var
 x,y:integer;
 t:restudiantes;
 t2:rcalificacion;

begin

 clrscr;
 Cuadro(1,6,80,8);
 gotoxy((80-length('Ordenando por Matricula')) div 2,7);
 write('Ordenando por Carrera');
 for x:= 1 to l do
  for y:=1 to l-1 do
   if (vestudiantes[y].carrera>vestudiantes[y+1].carrera) then
    begin

     t:=vestudiantes[y];
     vestudiantes[y]:=vestudiantes[y+1];
     vestudiantes[y+1]:=t;

     t2:=vcalificacion[y];
     vcalificacion[y]:=vcalificacion[y+1];
     vcalificacion[y+1]:=t2;

    end;


  gotoxy((80-length('Listo!')) div 2,10);write('Listo!');
  listo(19);

end;

/////////////Guardar en archivo.txt//////////////


procedure guardar;
var
 archivo:text;
 nomarchivo:string[10];
 x,y:integer;

begin

  nomarchivo:='Registro'; //nombre del archivo

  assign(archivo,'C:\'+nomarchivo+'.txt');    //creando archivo

  rewrite(archivo);                       //abriendo archivo para escritura

  writeln(archivo,'                Registro: ');
  write(archivo,'Matricula:   ');
  write(archivo,'Nombre:       ');
  write(archivo,'Carrera:     ');
  write(archivo,'Sexo:   ');
  write(archivo,'asignatura:    ');
  write(archivo,'pp: ');
  write(archivo,'sp: ');
  write(archivo,'ef: ');
  write(archivo,'tp: ');
  write(archivo,'ti: ');
  write(archivo,'total: ');
  writeln(archivo,'letra: ');

   for x:=1 to l do
    begin
      if vestudiantes[x].ano=0 then break;
      write(archivo,vestudiantes[x].ano,'-',vestudiantes[x].matricula,'    ');
      write(archivo,vestudiantes[x].nombre,'       ');
      write(archivo,vestudiantes[x].carrera,'     ');
      write(archivo,vestudiantes[x].sexo,'    ');
        for y:=1 to l1 do
         begin
           if vcalificacion[x].pp[y]=0 then break;
           write(archivo,vcalificacion[x].asignatura[y],'    ');
           write(archivo,vcalificacion[x].pp[y],' ');
           write(archivo,vcalificacion[x].sp[y],' ');
           write(archivo,vcalificacion[x].ef[y],' ');
           write(archivo,vcalificacion[x].tp[y],' ');
           write(archivo,vcalificacion[x].ti[y],' ');
           write(archivo,vcalificacion[x].total[y],' ');
           write(archivo,vcalificacion[x].letra[y],' ');
           writeln(archivo,'                                                  ');
         end;

    end;


 close(archivo);  //cerrando archivo


end;

////////////////////moviedo menu/////////////////
procedure movimiento;
const
op1=   '  Registrar Estudiantes ';
op2=   '  Registrar Calificacion ';
op3=   '  Ordenar Estudiantes ';       //opciones
op4=   '  Mostrar Los Estudiantes ';
op5=   '  Mostrar Calificacion Por Estudiantes ';
op6=   '  Buscar Estudiante ';
op7=   '  Salir ';
var

x,y,z,x1:integer;
begin

 {clrscr;
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
 gotoxy(1,7);write('Ú');}


 for x:=10 downto 1 do
  begin
   gotoxy(x,9);  write('  Registrar Estudiantes ');
   gotoxy(x,10); write('  Registrar Calificacion ');
   gotoxy(x,11); write('  Ordenar Estudiantes ');       //opciones
   gotoxy(x,12); write('  Mostrar Los Estudiantes ');
   gotoxy(x,13); write('  Mostrar Calificacion Por Estudiantes ');
   gotoxy(x,14); write('  Buscar Estudiante ');
   gotoxy(x,15); write('  Salir ');
   if x=1 then

    begin
    gotoxy(x,9);  write(' Registrar Estudiantes ');
   gotoxy(x,10); write(' Registrar Calificacion ');
   gotoxy(x,11); write(' Ordenar Estudiantes ');       //opciones
   gotoxy(x,12); write(' Mostrar Los Estudiantes ');
   gotoxy(x,13); write(' Mostrar Calificacion Por Estudiantes ');
   gotoxy(x,14); write(' Buscar Estudiante ');
   gotoxy(x,15); write(' Salir ');

      delay(1);
    gotoxy(x,9);  write('Registrar Estudiantes ');
   gotoxy(x,10); write('Registrar Calificacion ');
   gotoxy(x,11); write('Ordenar Estudiantes ');       //opciones
   gotoxy(x,12); write('Mostrar Los Estudiantes ');
   gotoxy(x,13); write('Mostrar Calificacion Por Estudiantes ');
   gotoxy(x,14); write('Buscar Estudiante ');
   gotoxy(x,15); write('Salir ');
   delay(1);

   gotoxy(x,9);  write('egistrar Estudiantes ');
   gotoxy(x,10); write('egistrar Calificacion ');
   gotoxy(x,11); write('rdenar Estudiantes ');       //opciones
   gotoxy(x,12); write('ostrar Los Estudiantes ');
   gotoxy(x,13); write('ostrar Calificacion Por Estudiantes ');
   gotoxy(x,14); write('uscar Estudiante ');
   gotoxy(x,15); write('alir ');
   delay(1);
   gotoxy(x,9);  write('gistrar Estudiantes ');
   gotoxy(x,10); write('gistrar Calificacion ');
   gotoxy(x,11); write('denar Estudiantes ');       //opciones
   gotoxy(x,12); write('strar Los Estudiantes ');
   gotoxy(x,13); write('strar Calificacion Por Estudiantes ');
   gotoxy(x,14); write('scar Estudiante ');
   gotoxy(x,15); write('lir ');
   delay(1);
   gotoxy(x,9);  write('istrar Estudiantes ');
   gotoxy(x,10); write('istrar Calificacion ');
   gotoxy(x,11); write('enar Estudiantes ');       //opciones
   gotoxy(x,12); write('trar Los Estudiantes ');
   gotoxy(x,13); write('trar Calificacion Por Estudiantes ');
   gotoxy(x,14); write('car Estudiante ');
   gotoxy(x,15); write('ir ');
   delay(1);
   gotoxy(x,9);  write('strar Estudiantes ');
   gotoxy(x,10); write('strar Calificacion ');
   gotoxy(x,11); write('nar Estudiantes ');       //opciones
   gotoxy(x,12); write('rar Los Estudiantes ');
   gotoxy(x,13); write('rar Calificacion Por Estudiantes ');
   gotoxy(x,14); write('ar Estudiante ');
   gotoxy(x,15); write('r ');
   delay(1);
   gotoxy(x,9);  write('trar Estudiantes ');
   gotoxy(x,10); write('trar Calificacion ');
   gotoxy(x,11); write('ar Estudiantes ');       //opciones
   gotoxy(x,12); write('ar Los Estudiantes ');
   gotoxy(x,13); write('ar Calificacion Por Estudiantes ');
   gotoxy(x,14); write('r Estudiante ');
   gotoxy(x,15); write(' ');
   delay(1);
   gotoxy(x,9);  write('rar Estudiantes ');
   gotoxy(x,10); write('rar Calificacion ');
   gotoxy(x,11); write('r Estudiantes ');       //opciones
   gotoxy(x,12); write('r Los Estudiantes ');
   gotoxy(x,13); write('r Calificacion Por Estudiantes ');
   gotoxy(x,14); write(' Estudiante ');
   gotoxy(x,15); write('');
   delay(1);
   gotoxy(x,9);  write('ar Estudiantes ');
   gotoxy(x,10); write('ar Calificacion ');
   gotoxy(x,11); write(' Estudiantes ');       //opciones
   gotoxy(x,12); write(' Los Estudiantes ');
   gotoxy(x,13); write(' Calificacion Por Estudiantes ');
   gotoxy(x,14); write('Estudiante ');
   gotoxy(x,15); write('');
   delay(1);
   gotoxy(x,9);  write('r Estudiantes ');
   gotoxy(x,10); write('r Calificacion ');
   gotoxy(x,11); write('Estudiantes ');       //opciones
   gotoxy(x,12); write('Los Estudiantes ');
   gotoxy(x,13); write('Calificacion Por Estudiantes ');
   gotoxy(x,14); write('studiante ');
   gotoxy(x,15); write('');
   delay(1);
   gotoxy(x,9);  write(' Estudiantes ');
   gotoxy(x,10); write(' Calificacion ');
   gotoxy(x,11); write('studiantes ');       //opciones
   gotoxy(x,12); write('os Estudiantes ');
   gotoxy(x,13); write('alificacion Por Estudiantes ');
   gotoxy(x,14); write('tudiante ');
   gotoxy(x,15); write('');
   delay(1);
   gotoxy(x,9);  write('Estudiantes ');
   gotoxy(x,10); write('Calificacion ');
   gotoxy(x,11); write('tudiantes ');       //opciones
   gotoxy(x,12); write('s Estudiantes ');
   gotoxy(x,13); write('lificacion Por Estudiantes ');
   gotoxy(x,14); write('udiante ');
   gotoxy(x,15); write('');
   delay(1);
   gotoxy(x,9);  write('studiantes ');
   gotoxy(x,10); write('alificacion ');
   gotoxy(x,11); write('udiantes ');       //opciones
   gotoxy(x,12); write(' Estudiantes ');
   gotoxy(x,13); write('ificacion Por Estudiantes ');
   gotoxy(x,14); write('diante ');
   gotoxy(x,15); write('');
   delay(1);
   gotoxy(x,9);  write('tudiantes ');
   gotoxy(x,10); write('lificacion ');
   gotoxy(x,11); write('diantes ');       //opciones
   gotoxy(x,12); write('Estudiantes ');
   gotoxy(x,13); write('ficacion Por Estudiantes ');
   gotoxy(x,14); write('iante ');
   gotoxy(x,15); write('');
   delay(1);
   gotoxy(x,9);  write('udiantes ');
   gotoxy(x,10); write('ificacion ');
   gotoxy(x,11); write('iantes ');       //opciones
   gotoxy(x,12); write('studiantes ');
   gotoxy(x,13); write('icacion Por Estudiantes ');
   gotoxy(x,14); write('ante ');
   gotoxy(x,15); write('');
   delay(1);
   gotoxy(x,9);  write('diantes ');
   gotoxy(x,10); write('ficacion ');
   gotoxy(x,11); write('antes ');       //opciones
   gotoxy(x,12); write('tudiantes ');
   gotoxy(x,13); write('cacion Por Estudiantes ');
   gotoxy(x,14); write('nte ');
   gotoxy(x,15); write('');
   delay(1);
   gotoxy(x,9);  write('iantes ');
   gotoxy(x,10); write('icacion ');
   gotoxy(x,11); write('ntes ');       //opciones
   gotoxy(x,12); write('udiantes ');
   gotoxy(x,13); write('acion Por Estudiantes ');
   gotoxy(x,14); write('te ');
   gotoxy(x,15); write('');
   delay(1);
   gotoxy(x,9);  write('antes ');
   gotoxy(x,10); write('cacion ');
   gotoxy(x,11); write('tes ');       //opciones
   gotoxy(x,12); write('diantes ');
   gotoxy(x,13); write('cion Por Estudiantes ');
   gotoxy(x,14); write('e ');
   gotoxy(x,15); write('');
   delay(1);
   gotoxy(x,9);  write('ntes ');
   gotoxy(x,10); write('acion ');
   gotoxy(x,11); write('es ');       //opciones
   gotoxy(x,12); write('iantes ');
   gotoxy(x,13); write('ion Por Estudiantes ');
   gotoxy(x,14); write(' ');
   gotoxy(x,15); write('');
   delay(1);
   gotoxy(x,9);  write('tes ');
   gotoxy(x,10); write('cion ');
   gotoxy(x,11); write('s ');       //opciones
   gotoxy(x,12); write('antes ');
   gotoxy(x,13); write('on Por Estudiantes ');
   gotoxy(x,14); write('');
   gotoxy(x,15); write('');
   delay(1);
   gotoxy(x,9);  write('es ');
   gotoxy(x,10); write('ion ');
   gotoxy(x,11); write(' ');       //opciones
   gotoxy(x,12); write('ntes ');
   gotoxy(x,13); write('n Por Estudiantes ');
   gotoxy(x,14); write('');
   gotoxy(x,15); write('');
   delay(1);
   gotoxy(x,9);  write('s ');
   gotoxy(x,10); write('on ');
   gotoxy(x,11); write('');       //opciones
   gotoxy(x,12); write('tes ');
   gotoxy(x,13); write(' Por Estudiantes ');
   gotoxy(x,14); write('');
   gotoxy(x,15); write('');
   delay(1);
   gotoxy(x,9);  write(' ');
   gotoxy(x,10); write('n ');
   gotoxy(x,11); write('');       //opciones
   gotoxy(x,12); write('es ');
   gotoxy(x,13); write('Por Estudiantes ');
   gotoxy(x,14); write('');
   gotoxy(x,15); write('');
   delay(1);
   gotoxy(x,9);  write('');
   gotoxy(x,10); write(' ');
   gotoxy(x,11); write('');       //opciones
   gotoxy(x,12); write('s ');
   gotoxy(x,13); write('or Estudiantes ');
   gotoxy(x,14); write('');
   gotoxy(x,15); write('');
   delay(1);
   gotoxy(x,9);  write('');
   gotoxy(x,10); write('');
   gotoxy(x,11); write('');       //opciones
   gotoxy(x,12); write(' ');
   gotoxy(x,13); write('r Estudiantes ');
   gotoxy(x,14); write('');
   gotoxy(x,15); write('');
   delay(1);
   gotoxy(x,9);  write('');
   gotoxy(x,10); write('');
   gotoxy(x,11); write('');       //opciones
   gotoxy(x,12); write('');
   gotoxy(x,13); write(' Estudiantes  ');
   gotoxy(x,14); write('');
   gotoxy(x,15); write('');
   delay(1);
   gotoxy(x,9);  write('');
   gotoxy(x,10); write('');
   gotoxy(x,11); write('');       //opciones
   gotoxy(x,12); write('');
   gotoxy(x,13); write('studiantes  ');
   gotoxy(x,14); write('');
   gotoxy(x,15); write('');
   delay(1);
   gotoxy(x,9);  write('');
   gotoxy(x,10); write('');
   gotoxy(x,11); write('');       //opciones
   gotoxy(x,12); write('');
   gotoxy(x,13); write('tudiantes  ');
   gotoxy(x,14); write('');
   gotoxy(x,15); write('');
   delay(1);
   gotoxy(x,13); write('udiantes  ');
   delay(1);
   gotoxy(x,13); write('diantes  ');
   delay(1);
   gotoxy(x,13); write('iantes  ');
   delay(1);
   gotoxy(x,13); write('antes ');
   delay(1);
   gotoxy(x,13); write('ntes ');
   delay(1);
   gotoxy(x,13); write('tes ');
   delay(1);
   gotoxy(x,13); write('es ');
   delay(1);
   gotoxy(x,13); write('s ');
   delay(1);
   gotoxy(x,13); write(' ');
   delay(1);

    for y:=8 to 16 do
  begin

   gotoxy(1,y); write('³');

  end;



    end;


   delay(1);
  end;



end;





/////////////////Cuerpo del programa//////////////////////

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
   f1:=15;//cambiar cada vez que se aplien las opciones del menu
    end;

      end;

  #75:begin
  movimiento;
  end;


  #80:begin //abajo
   if (f1<15) then //cambiar cada vez que se aplien las opciones del menu
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


   //if (t=#32) then {espacio}


   if (t=#9) then   //instrucciones
   begin
   clrscr;
    Cuadro(1,1,80,6);

  gotoxy((80-length(T1)) div 2,2); write(T1);
  gotoxy((80-length(T2)) div 2,3); write(T2);
  gotoxy((80-length(T3)) div 2,4); write(T3);
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
  gotoxy(10,16); write('los arreglos, sea los estudiantes o sus calificaciones.');

  gotoxy(17,18); write(' al salir se le dara la opcion de guardar o no, al guardar se');
  gotoxy(10,19); write('creara un archivo .txt con lo que quedo de los arreglos ');
  gotoxy(10,20); write('ubicado en la raiz del disco duro C:\ con el nombre "Registro".');
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

    registrarest;
    titulo;

   end;


   if (t=#13) and (f1=11) then
   begin

    clrscr;

    Cuadro(1,1,80,6);

    gotoxy((80-length(T1)) div 2,2); write(T1);
    gotoxy((80-length(T2)) div 2,3); write(T2);
    gotoxy((80-length(T3)) div 2,4); write(T3);
    gotoxy((80-length('Ordenador')) div 2,5); write('ORDENADOR');

    Cuadro(1,13,80,15);
    gotoxy(10,14); write('0=Ordenar por Matricula');
    gotoxy(50,14); write('1=Ordenar por Carrera');
    Cuadro(34,18,46,20);
    gotoxy(40,19);read(op);

    if op=0 then
     begin

      burbuja;
      titulo;

     end;

    if op=1 then
     begin

      burbujacarrera;
      titulo;

     end;

   end;


   if (t=#13) and (f1=10) then
    begin

     selecioncal;
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

      clrscr;

      Cuadro(1,1,80,6);

     gotoxy((80-length(T1)) div 2,2); write(T1);
     gotoxy((80-length(T2)) div 2,3); write(T2);
     gotoxy((80-length(T3)) div 2,4); write(T3);
     gotoxy((80-length('Buscador')) div 2,5); write('BUSCANDOR');


      Cuadro(1,13,80,15);
      gotoxy(11,14); write('0=Buscar por Matricula');
      gotoxy(50,14); write('1=Buscar por Carrera');
      Cuadro(34,18,46,20);
      gotoxy(40,19);read(op);

    if op=0 then
     begin
      buscarmat;
      titulo;
     end;

    if op=1 then
     begin
      buscar;
      titulo;
     end;

   end;

   if (t=#13) and (f1=15) then
    begin
     t:=#27;

    end;



 until(t=#27);


 begin
  clrscr;

  Cuadro(1,1,80,6);

  gotoxy((80-length(T1)) div 2,2); write(T1);
  gotoxy((80-length(T2)) div 2,3); write(T2);
  gotoxy((80-length(T3)) div 2,4); write(T3);
  gotoxy((80-length('Saliendo')) div 2,5); write('SALIENDO');

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


