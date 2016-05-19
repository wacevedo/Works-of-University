program prestamos;
uses crt;

var
interesmont, numprestamos, monto, tiempo,cuota, interescalc, interes, amortizacion :real;
 cliente, fecha :string;

 begin
 interes:=0;
   interescalc:=0;
  interesmont:=0;
  monto:=0;
  interes:=0;
  amortizacion:=0;
  cuota:=0;
  tiempo:=0;

  clrscr;
  writeln('Inserte fecha: ');
  readln(fecha);

  repeat
  writeln('inserte cliente:');
  readln(cliente);
  if cliente ='0' then break;

  writeln('Inserte monto:');
  readln(monto);
 repeat
  writeln('Inserte % interes:');
  readln(interes);
  if ((interes <=100) and (interes >=0)) then break;
  writeln('ERROR! 325:');
 until ((interes <=100) and (interes >=0));
  interescalc:=interes/100;

  writeln('Inserte tiempo en meses:');
  readln(tiempo);

 interesmont:= monto*interescalc;
 amortizacion:= interesmont + monto;
 cuota:= amortizacion/tiempo;
 writeln(interesmont:8:2);
 writeln(amortizacion:8:2);
 writeln(cuota:8:2);
 readkey;
until (cliente ='0');
readkey;
end.



