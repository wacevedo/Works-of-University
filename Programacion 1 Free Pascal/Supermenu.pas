program prueba02;
uses crt;
const
T1='UCATECI';
T2='PROGRAMACION 1';
T3='MENU PRINCIPAL';
T4='MENU DE DISE¥O';
var
op: integer;
t:char;
//cuerpo

procedure mover;
var
c1,f1:integer;
t:char;
begin
 clrscr;
 c1:=1; f1:=18;
 repeat
  t:=readkey;
  case t of
   #72:if(f1>2) then
   dec(f1)
   else
   f1:=21;
   #80:if (f1<21) then
   inc(f1)
   else
   f1:=2;
   #75:if (c1>2) then
   dec(c1)
   else
   c1:=78;
   #77:if (c1<78) then
   inc(c1)
   else
   c1:=2;
  end;
gotoxy(c1,f1-1);write('    ');
gotoxy(c1,f1); write(' ',chr(1),' ');
gotoxy(c1,f1+1);write('    ');
until(t=#27); //Esc
end;

procedure clrpart;
var x, y:integer;
begin
for y:=6 to 24 do
for x:=1 to 80 do
begin
gotoxy(x,y);
write(' ');
end;

end;

procedure cuadro(x1,y1,x2,y2:integer);
var
x,y:integer;

begin

 for x:=x1 to x2 do
  begin
   gotoxy(x,y1); write('²');
   gotoxy(x,y2); write('²');
   delay(1);
end;
for y:=y1 to y2 do
 begin
  gotoxy(x1,y); write('²');
  gotoxy(x2,y); write('²');
  delay(1);
 end;

end;

procedure cuadros;
var x,c,f :integer;
begin
 clrscr;
 c:=5;
 f:=2;
 for x:=1 to 5 do
  begin
   cuadro(c,f,80-c,24-f);
   c:=c+5;
   f:=f+2;
  end;
 readkey;
end;

PROCEDURE carga;
 VAR
  N,R:INTEGER;
  POR:REAL;
BEGIN
clrpart;
N:=3;
gotoxy((80-length('Loading')) div 2,7); WRITE('Loading');
CUADRO(2,14,79,17);
FOR R:=1 TO 76 DO
BEGIN
GOTOXY(N,15);
WRITE(CHR(219));
N:=N+1;
POR:=POR+1.32;
DELAY(50);
GOTOXY(38,16);
WRITE(POR:4:0,'%');
END;
END;

procedure LineaHor;
var x,xx,yy, y:integer;
begin
repeat
clrpart;
gotoxy(1,7);
write('Inserte las cordenadas en x de la linea y el tama¤o de espacios:');
gotoxy(1,8);
write('<0 para salir>');
readln(x,y);
xx:=x+25;
yy:=y;
cuadro(x,y,xx,yy);
readkey;
until(x=0);
end;

procedure LineaVer;
var x,xx,yy, y:integer;
begin
repeat
clrpart;
gotoxy(1,7);
write('Inserte las cordenadas en Y de la linea y el tama¤o de espacios:');
gotoxy(1,8);
write('<0 para salir>');
readln(x,y);
xx:=x;
yy:=y+25;
cuadro(x,y,xx,yy);
readkey;
until(x=0);
end;

procedure triangulo;
var
c1,c2,f,x: integer;
 begin
 clrpart;
 c1:=25;
 c2:=25;
 f:=7;
 gotoxy(25,7);write('*');
  for x:=1 to 7 do
  begin
  inc(f);
  inc(c1);
  dec(c2);
  gotoxy(c1,f);write('*');delay(5);
  gotoxy(c2,f);write('*');delay(5);
  gotoxy(c1,14);write('*');delay(5);
  gotoxy(c2,14);write('*');delay(5);

  end;
 gotoxy(25,14);write('*');
end;

procedure laberinto;
var {ciclo,x,y,x1,y1,}f1,c1:integer;
l,r,t:char;
begin
gotoxy((80-length('Laberinto')) div 2,3);
write('Laberinto');
gotoxy((80-length('Nivel 1')) div 2,5);
write('Nivel 1');
cuadro(8,8,73,24);
gotoxy(8,10);write('  ');
gotoxy(73,22);write('  ');
l:='|'; r:='_';

{y:=9; x:=15;
for ciclo:=1 to 4  do
 begin
 gotoxy(x,y); write('|');
 inc(y);
 end;
 y:=9; x:=30;
 for ciclo:=1 to 11  do
 begin
 gotoxy(x,y); write('|');
 inc(y);
 end;
 gotoxy(x,y+3);write('|');
 gotoxy(x+30,y+3);write('|');
 gotoxy(x+30,y-1);write('|');
 gotoxy(20,y);write('|');

 x:=50; y:=14;
 for ciclo:=1 to 10  do
  begin
   gotoxy(x,y); write('|');
   inc(y);
  end;
  x:=40; y:=9;
   for ciclo:=1 to 3  do
 begin
 gotoxy(x,y); write('|');
 inc(y);
 end;
 x:=20; y:=15;
 for ciclo:=1 to 5  do
 begin
  gotoxy(x,y); write('|');
  inc(y);
 end;}

gotoxy(16,10);write(l);
gotoxy(16,9);write(l);
gotoxy(16,11);write(l);
gotoxy(16,12);write(l);
gotoxy(16,13);write(l);
gotoxy(16,14);write(l);
gotoxy(24,15);write(l);
gotoxy(24,16);write(l);
gotoxy(24,17);write(l);
gotoxy(24,18);write(l);
gotoxy(25,18);write(r);
gotoxy(27,18);write(r);
gotoxy(26,18);write(r);
gotoxy(28,18);write(r);
gotoxy(29,18);write(r);
gotoxy(30,18);write(r);
gotoxy(31,18);write(r);
gotoxy(37,18);write(l);
gotoxy(37,17);write(l);
gotoxy(37,16);write(l);
gotoxy(37,15);write(l);
gotoxy(37,14);write(l);
gotoxy(37,13);write(l);
gotoxy(37,12);write(r);
gotoxy(36,12);write(r);
gotoxy(34,12);write(r);
gotoxy(35,12);write(r);
gotoxy(33,12);write(r);
gotoxy(32,12);write(r);
gotoxy(31,12);write(l);
gotoxy(31,11);write(l);
gotoxy(31,10);write(l);
gotoxy(31,9);write(l);
gotoxy(43,23);write(l);
gotoxy(43,22);write(l);
gotoxy(43,21);write(l);
gotoxy(43,20);write(l);
gotoxy(43,19);write(l);
gotoxy(43,18);write(r);
gotoxy(44,18);write(r);
gotoxy(43,14);write(l);
gotoxy(43,13);write(l);
gotoxy(43,12);write(l);
gotoxy(43,11);write(r);
gotoxy(45,11);write(r);
gotoxy(47,11);write(r);
gotoxy(46,11);write(r);
gotoxy(44,11);write(r);
gotoxy(48,11);write(r);
gotoxy(49,11);write(r);
gotoxy(50,11);write(r);
gotoxy(51,11);write(l);
gotoxy(51,10);write(l);
gotoxy(51,9);write(l);
gotoxy(51,16);write(l);
gotoxy(51,17);write(l);
gotoxy(51,18);write(l);
gotoxy(51,19);write(l);
gotoxy(51,20);write(l);
gotoxy(51,21);write(l);
gotoxy(51,22);write(l);
gotoxy(51,23);write(l);
gotoxy(17,23);write(l);
gotoxy(17,22);write(l);
gotoxy(17,21);write(l);
gotoxy(17,20);write(l);
gotoxy(72,19);write(r);
gotoxy(71,19);write(r);
gotoxy(70,19);write(r);
gotoxy(69,19);write(r);
gotoxy(68,19);write(r);
gotoxy(67,19);write(r);
gotoxy(66,19);write(r);
gotoxy(65,19);write(r);
gotoxy(64,19);write(r);
gotoxy(62,19);write(r);
gotoxy(61,19);write(r);
gotoxy(60,19);write(r);
gotoxy(63,19);write(r);
gotoxy(60,14);write(l);
gotoxy(60,13);write(l);
gotoxy(60,12);write(l);
gotoxy(60,11);write(l);
gotoxy(60,10);write(l);
gotoxy(60,9);write(l);
gotoxy(16,14);write(r);
gotoxy(18,14);write(r);
gotoxy(17,14);write(r);
gotoxy(19,14);write(r);
gotoxy(20,14);write(r);
gotoxy(21,14);write(r);
gotoxy(22,14);write(r);
gotoxy(23,14);write(r);
gotoxy(24,14);write(r);
//readkey;
gotoxy(9,10);//para dejar en la entrada
c1:=9; f1:=10;

 repeat
  t:=readkey;
  case t of
   #72:begin //arriba
   if(f1>9) then
   dec(f1)
   else
   f1:=9;
   if (c1=25) and (f1=18) then  inc(f1);
   if (c1=27) and (f1=18) then  inc(f1);
   if (c1=26) and (f1=18) then  inc(f1);
   if (c1=28) and (f1=18) then  inc(f1);
   if (c1=29) and (f1=18) then  inc(f1);
   if (c1=30) and (f1=18) then  inc(f1);
   if (c1=31) and (f1=18) then  inc(f1);
   if (c1=37) and (f1=12) then  inc(f1);
   if (c1=36) and (f1=12) then  inc(f1);
   if (c1=34) and (f1=12) then  inc(f1);
   if (c1=35) and (f1=12) then  inc(f1);
   if (c1=33) and (f1=12) then  inc(f1);
   if (c1=32) and (f1=12) then  inc(f1);
   if (c1=43) and (f1=18) then  inc(f1);
   if (c1=44) and (f1=18) then  inc(f1);
   if (c1=43) and (f1=11) then  inc(f1);
   if (c1=45) and (f1=11) then  inc(f1);
   if (c1=47) and (f1=11) then  inc(f1);
   if (c1=46) and (f1=11) then  inc(f1);
   if (c1=44) and (f1=11) then  inc(f1);
   if (c1=48) and (f1=11) then  inc(f1);
   if (c1=49) and (f1=11) then  inc(f1);
   if (c1=50) and (f1=11) then  inc(f1);
   if (c1=72) and (f1=19) then  inc(f1);
   if (c1=71) and (f1=19) then  inc(f1);
   if (c1=70) and (f1=19) then  inc(f1);
   if (c1=69) and (f1=19) then  inc(f1);
   if (c1=68) and (f1=19) then  inc(f1);
   if (c1=67) and (f1=19) then  inc(f1);
   if (c1=66) and (f1=19) then  inc(f1);
   if (c1=65) and (f1=19) then  inc(f1);
   if (c1=64) and (f1=19) then  inc(f1);
   if (c1=62) and (f1=19) then  inc(f1);
   if (c1=61) and (f1=19) then  inc(f1);
   if (c1=60) and (f1=19) then  inc(f1);
   if (c1=63) and (f1=19) then  inc(f1);
   if (c1=16) and (f1=14) then  inc(f1);
   if (c1=18) and (f1=14) then  inc(f1);
   if (c1=17) and (f1=14) then  inc(f1);
   if (c1=19) and (f1=14) then  inc(f1);
   if (c1=20) and (f1=14) then  inc(f1);
   if (c1=21) and (f1=14) then  inc(f1);
   if (c1=22) and (f1=14) then  inc(f1);
   if (c1=23) and (f1=14) then  inc(f1);
   if (c1=24) and (f1=14) then  inc(f1);

        end;

   #80:begin //abajo
   if (f1<23) then
   inc(f1)
   else
   f1:=23;
   if (c1=25) and (f1=18) then  dec(f1);
   if (c1=27) and (f1=18) then  dec(f1);
   if (c1=26) and (f1=18) then  dec(f1);
   if (c1=28) and (f1=18) then  dec(f1);
   if (c1=29) and (f1=18) then  dec(f1);
   if (c1=30) and (f1=18) then  dec(f1);
   if (c1=31) and (f1=18) then  dec(f1);
   if (c1=37) and (f1=12) then  dec(f1);
   if (c1=36) and (f1=12) then  dec(f1);
   if (c1=34) and (f1=12) then  dec(f1);
   if (c1=35) and (f1=12) then  dec(f1);
   if (c1=33) and (f1=12) then  dec(f1);
   if (c1=32) and (f1=12) then  dec(f1);
   if (c1=43) and (f1=18) then  dec(f1);
   if (c1=44) and (f1=18) then  dec(f1);
   if (c1=43) and (f1=11) then  dec(f1);
   if (c1=45) and (f1=11) then  dec(f1);
   if (c1=47) and (f1=11) then  dec(f1);
   if (c1=46) and (f1=11) then  dec(f1);
   if (c1=44) and (f1=11) then  dec(f1);
   if (c1=48) and (f1=11) then  dec(f1);
   if (c1=49) and (f1=11) then  dec(f1);
   if (c1=50) and (f1=11) then  dec(f1);
   if (c1=72) and (f1=19) then  dec(f1);
   if (c1=71) and (f1=19) then  dec(f1);
   if (c1=70) and (f1=19) then  dec(f1);
   if (c1=69) and (f1=19) then  dec(f1);
   if (c1=68) and (f1=19) then  dec(f1);
   if (c1=67) and (f1=19) then  dec(f1);
   if (c1=66) and (f1=19) then  dec(f1);
   if (c1=65) and (f1=19) then  dec(f1);
   if (c1=64) and (f1=19) then  dec(f1);
   if (c1=62) and (f1=19) then  dec(f1);
   if (c1=61) and (f1=19) then  dec(f1);
   if (c1=60) and (f1=19) then  dec(f1);
   if (c1=63) and (f1=19) then  dec(f1);
   if (c1=16) and (f1=14) then  dec(f1);
   if (c1=18) and (f1=14) then  dec(f1);
   if (c1=17) and (f1=14) then  dec(f1);
   if (c1=19) and (f1=14) then  dec(f1);
   if (c1=20) and (f1=14) then  dec(f1);
   if (c1=21) and (f1=14) then  dec(f1);
   if (c1=22) and (f1=14) then  dec(f1);
   if (c1=23) and (f1=14) then  dec(f1);
   if (c1=24) and (f1=14) then  dec(f1);
       end;

   #75:begin //izquierda
   if (c1>9) then
   dec(c1)
   else
   c1:=9;
    if (c1=16) and (f1=10) then  inc(c1);
  if (c1=16) and (f1=9) then  inc(c1);
  if (c1=16) and (f1=11) then  inc(c1);
  if (c1=16) and (f1=12) then  inc(c1);
  if (c1=16) and (f1=13) then  inc(c1);
  if (c1=16) and (f1=14) then  inc(c1);
  if (c1=24) and (f1=15) then  inc(c1);
  if (c1=24) and (f1=16) then  inc(c1);
  if (c1=24) and (f1=17) then  inc(c1);
  if (c1=24) and (f1=18) then  inc(c1);
  if (c1=37) and (f1=18) then  inc(c1);
 if (c1=37) and (f1=17) then  inc(c1);
 if (c1=37) and (f1=16) then  inc(c1);
 if (c1=37) and (f1=15) then  inc(c1);
 if (c1=37) and (f1=14) then  inc(c1);
 if (c1=37) and (f1=13) then  inc(c1);
 if (c1=31) and (f1=12) then  inc(c1);
if (c1=31) and (f1=11) then  inc(c1);
if (c1=31) and (f1=10) then  inc(c1);
if (c1=31) and (f1=9) then  inc(c1);
if (c1=43) and (f1=23) then  inc(c1);
if (c1=43) and (f1=22) then  inc(c1);
if (c1=43) and (f1=21) then  inc(c1);
if (c1=43) and (f1=20) then  inc(c1);
if (c1=43) and (f1=19) then  inc(c1);
if (c1=43) and (f1=14) then  inc(c1);
if (c1=43) and (f1=13) then  inc(c1);
if (c1=43) and (f1=12) then  inc(c1);
if (c1=51) and (f1=11) then  inc(c1);
if (c1=51) and (f1=10) then  inc(c1);
if (c1=51) and (f1=9) then  inc(c1);
if (c1=51) and (f1=11) then  inc(c1);
if (c1=51) and (f1=16) then  inc(c1);
if (c1=51) and (f1=17) then  inc(c1);
if (c1=51) and (f1=18) then  inc(c1);
if (c1=51) and (f1=19) then  inc(c1);
if (c1=51) and (f1=20) then  inc(c1);
if (c1=51) and (f1=21) then  inc(c1);
if (c1=51) and (f1=22) then  inc(c1);
if (c1=51) and (f1=23) then  inc(c1);
if (c1=17) and (f1=23) then  inc(c1);
if (c1=17) and (f1=22) then  inc(c1);
if (c1=17) and (f1=21) then  inc(c1);
if (c1=17) and (f1=20) then  inc(c1);
if (c1=60) and (f1=14) then  inc(c1);
if (c1=60) and (f1=13) then  inc(c1);
if (c1=60) and (f1=12) then  inc(c1);
if (c1=60) and (f1=11) then  inc(c1);
if (c1=60) and (f1=10) then  inc(c1);
if (c1=60) and (f1=9) then  inc(c1);

       end;

   #77:begin //derecha
   if (c1<72) then
   inc(c1)
   else
   c1:=72;

  if (c1=16) and (f1=10) then  dec(c1);
  if (c1=16) and (f1=9) then  dec(c1);
  if (c1=16) and (f1=11) then  dec(c1);
  if (c1=16) and (f1=12) then  dec(c1);
  if (c1=16) and (f1=13) then  dec(c1);
  if (c1=16) and (f1=14) then  dec(c1);
  if (c1=24) and (f1=15) then  dec(c1);
  if (c1=24) and (f1=16) then  dec(c1);
  if (c1=24) and (f1=17) then  dec(c1);
  if (c1=24) and (f1=18) then  dec(c1);

if (c1=37) and (f1=18) then  dec(c1);
if (c1=37) and (f1=17) then  dec(c1);
if (c1=37) and (f1=16) then  dec(c1);
if (c1=37) and (f1=15) then  dec(c1);
if (c1=37) and (f1=14) then  dec(c1);
if (c1=37) and (f1=13) then  dec(c1);


if (c1=31) and (f1=12) then  dec(c1);
if (c1=31) and (f1=11) then  dec(c1);
if (c1=31) and (f1=10) then  dec(c1);
if (c1=31) and (f1=9) then  dec(c1);
if (c1=43) and (f1=23) then  dec(c1);
if (c1=43) and (f1=22) then  dec(c1);
if (c1=43) and (f1=21) then  dec(c1);
if (c1=43) and (f1=20) then  dec(c1);
if (c1=43) and (f1=19) then  dec(c1);


if (c1=43) and (f1=14) then  dec(c1);
if (c1=43) and (f1=13) then  dec(c1);
if (c1=43) and (f1=12) then  dec(c1);




if (c1=51) and (f1=11) then  dec(c1);
if (c1=51) and (f1=10) then  dec(c1);
if (c1=51) and (f1=9) then  dec(c1);
if (c1=51) and (f1=11) then  dec(c1);
if (c1=51) and (f1=16) then  dec(c1);
if (c1=51) and (f1=17) then  dec(c1);
if (c1=51) and (f1=18) then  dec(c1);
if (c1=51) and (f1=19) then  dec(c1);
if (c1=51) and (f1=20) then  dec(c1);
if (c1=51) and (f1=21) then  dec(c1);
if (c1=51) and (f1=22) then  dec(c1);
if (c1=51) and (f1=23) then  dec(c1);
if (c1=17) and (f1=23) then  dec(c1);
if (c1=17) and (f1=22) then  dec(c1);
if (c1=17) and (f1=21) then  dec(c1);
if (c1=17) and (f1=20) then  dec(c1);



if (c1=60) and (f1=14) then  dec(c1);
if (c1=60) and (f1=13) then  dec(c1);
if (c1=60) and (f1=12) then  dec(c1);
if (c1=60) and (f1=11) then  dec(c1);
if (c1=60) and (f1=10) then  dec(c1);
if (c1=60) and (f1=9) then  dec(c1);


       end;
  end;

gotoxy(c1,f1);

if (c1=71) and (f1=22) then
 begin
 clrscr;
 cuadro(3,10,78,14);
 gotoxy((80-length('Usted Gano')) div 2,12);
 write('Usted Gano');
 delay(100);
 readkey;
 break
 end;



 until(t=#27); //Esc



end;


procedure progreso;
var x,y:integer;

begin
 clrpart;


 gotoxy((80-length('Progreso')) div 2,7);
 write('Progreso');

 while not keypressed do
  begin
  x:=((80-length('o')) div 2); y:=8;
   gotoxy(x,y);write('o');
   delay(100);
   gotoxy(x,y);write('  ');

  x:=x+5; y:=y+1;
   gotoxy(x,y);write('o');
   delay(100);
   gotoxy(x,y);write('  ');

  x:=x-5; y:=y+1;
   gotoxy(x,y);write('o');
   delay(100);
   gotoxy(x,y);write('   ');

  x:=x-5; y:=y-1;
   gotoxy(x,y);write('o');
   delay(100);
   gotoxy(x,y);write('   ');

  end;



  readkey;

end;

procedure cordenadas;
var x,y,z,c1,f1:integer;
t:char;
begin
 clrscr;

 for x:=1 to 79 do
  begin
   for y:=1 to 25 do
    begin
     gotoxy(x,y);write('o');
    end;
   end;

  c1:=1; f1:=1;
 repeat
  t:=readkey;
  case t of
   #72:if(f1>1) then
   dec(f1)
   else
   f1:=25;
   #80:if (f1<25) then
   inc(f1)
   else
   f1:=1;
   #75:if (c1>1) then
   dec(c1)
   else
   c1:=80;
   #77:if (c1<80) then
   inc(c1)
   else
   c1:=1;
  end;
//gotoxy(c1,f1-1);//write('    ');
gotoxy(c1,f1); //write(' ',chr(1),' ');
//gotoxy(c1,f1+1);//write('    ');

if t='0' then
begin
clrscr;
gotoxy(c1,f1);
write(c1,',',f1);
readkey;
for x:=1 to 79 do
  begin
   for y:=1 to 25 do
    begin
     gotoxy(x,y);write('o');
    end;
   end
end;

until(t=#27); //Esc

end;

procedure dislab;
var
t:char;
c1,f1,x:integer;
 //cor,lin: array [1..300] of integer;
 FName, fname2  : String[10];
    UserFile, file2   : Text;


Begin
clrscr;
 FName := 'DibujoLaberinto';
 fname2 := 'IFlaberinto';
 Assign(UserFile,'C:\'+FName+'.txt'); {assign a text file}
 Assign(file2,'C:\'+fName2+'.txt');
 Rewrite(UserFile); {open the file 'fname' for writing}
 Rewrite(file2);



     clrscr;
      gotoxy((80-length('Dise¤o de Laberinto')) div 2,3);
      write('Dise¤o de Laberinto');
      cuadro(8,8,73,24);
      gotoxy(8,10);write('  ');
      gotoxy(73,22);write('  ');
      c1:=1; f1:=1;
 repeat
  t:=readkey;
  case t of
   #72:if(f1>1) then
   dec(f1)
   else
   f1:=25;
   #80:if (f1<25) then
   inc(f1)
   else
   f1:=1;
   #75:if (c1>1) then
   dec(c1)
   else
   c1:=80;
   #77:if (c1<80) then
   inc(c1)
   else
   c1:=1;
  end;

gotoxy(c1,f1);

if t='1' then
 begin
  gotoxy(c1,f1);
   write('º');
 { cor[x]:=c1;
  lin[x]:=f1;}
  writeln(file2,'if (c1=',c1,') and (f1=',f1,') then  dec(c1);');
  Write(UserFile,'gotoxy(',c1,',');
  Writeln(UserFile,f1,');write(l);');
  //x:=x+1;
  end;

if t='2' then
 begin
  gotoxy(c1,f1);
   write('Í');
   {cor[x]:=(c1);
  lin[x]:=(f1);}
  writeln(file2,'if (c1=',c1,') and (f1=',f1,') then  dec(f1);');
  Write(UserFile,'gotoxy(',c1,',');
  Writeln(UserFile,f1,');write(r);');
  //x:=x+1;
  end;


 until(t=#27);
 //assign(cor,'C:\Documents and Settings\Administrador\Escritorio\laberinto.txt');

 Close(UserFile);
 Close(file2);

end;



begin
textcolor(white);
 repeat
  clrscr;
  Cuadro(1,1,80,5);
  gotoxy((80-length(T1)) div 2,2); write(T1);
  gotoxy((80-length(T2)) div 2,3); write(T2);
  gotoxy((80-length(T3)) div 2,4); write(T3);
  gotoxy(10,6); write('1-Cuadro');
  gotoxy(10,7); write('2-Carga');
  gotoxy(10,8); write('3-Progreso');
  gotoxy(10,9); write('4-Mover');
  gotoxy(10,10); write('5-Limpiar');
  gotoxy(10,11); write('6-Linea Horizontal');
  gotoxy(10,12); write('7-Linea Vertical');
  gotoxy(10,13); write('8-Triangulo');
  gotoxy(10,14); write('9-Laberinto');


  gotoxy(10,16); write('0-Salir');

  gotoxy(10,18); write('Opcion: '); readln(op);
  case op of
  1:cuadros;
  2:begin
  carga;
  readkey;
  end;
  3:progreso;
  4:mover;
  5: begin
  clrpart;
  readkey;
  end;

  6:LineaHor;
  7:LineaVer;

  8:begin
  triangulo;
  readkey;
  end;

  9:begin
  clrscr;
  laberinto;
  readkey;
  end;



  100:begin
  carga;
  clrpart;
  gotoxy((80-length(T4)) div 2,4); write(T4);
  gotoxy(10,6); write('1-Dise¤ar laberinto');
  gotoxy(10,7); write('2-Cordenadas para ubicar lineas');
  gotoxy(10,8); write('3-Dibujar lineas del laberinto');
  gotoxy(10,9); write('4-Cordenadas');
  gotoxy(10,18); write('Opcion: ');
  repeat
  t:=readkey;
  if t='1' then
   begin
    clrscr;
    laberinto;
    readkey;
   end;
  if t='2' then
   begin
    clrscr;
    cordenadas;

    readkey;
   end;
    if t='3' then
     begin
      dislab;
      end;

     if t='4'then
     cordenadas;

   until(t=#27);
       end;
  end;
 until(op=0);
end.

