program suma;
uses crt;

var
x, n1, n2 : integer;
begin
   clrscr;
   gotoxy(39,3); //la cordenada se pone alreves de las columnas y filas de pascal
   writeln('Bienvenido');
   gotoxy(11,12);
   writeln('Inserte el primer numero');
   readln(n1);
   writeln('inserte el segundo numero');
   readln(n2);

   x:= n1 + n2;
   writeln('su resultado es ', x);


   readkey;

end.
