program ejercicio1;
uses crt;
var n1,n2,R,S,M,D:real;
begin
clrscr;
Textbackground(2);
textcolor(white);
write('Digite un numero '); readln(n1);
write('Digite otro numero '); readln(n2);
R:=n1-n2;
S:=n1+n2;
M:=n1*n2;
Writeln('Suma ',S:8:2);
Writeln('resta ',R:8:2);
Writeln('multiplicacion ',M:8:2);
if (n1=0) or (n2=0) then
Write('ERROR 84865 Entre 0 no es divisible')
else
begin
D:=n1/n2;
Writeln('Divicion ',D:8:2);
end;
readkey;
end.