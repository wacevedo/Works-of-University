
program practica1;
uses crt;
var
cadena,resultado:string;
num,numero_per:integer;

{***************************************************************************}

function factorial(numero:integer):integer;
 begin {Esta funcion calcula el}
  if numero = 0 then {factorial de un numero}
   factorial := 1
  else
   factorial := numero * factorial(numero-1)
 end;

{***************************************************************************}

procedure swap(a,b:char);
var
 t:char;
begin
 a:=t;
 a:=b;
 b:=t;
End;

{***************************************************************************}

function permutaciones (P:string; N,Num:integer):string; {funcion que realizara
las permutaciones}
var
i,k:integer;

Begin
 k:=1;
 while k<>Num do
  for i:=2 to N do
   Begin
    Swap(P[1],P[i]);
   End;
 i:=2;
 k:=k+N;
 permutaciones:=P;
End; {Funcion permutaciones}

{***************************************************************************}

Begin {Programa}
 clrscr;
 writeln('Escriba la cadena de caracteres');
 readln(cadena);
 num:=ord(cadena[0]);
 write(num);
 numero_per:=factorial(num);
 write(numero_per);
 resultado:=permutaciones(cadena,Num,Numero_per);
 write(resultado);
End. {Programa}


