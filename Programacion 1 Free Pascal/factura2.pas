program factura;
uses crt;

const
t1='Numero de factura: ';
t2='Fecha: ';
t3='Cliente:';
t4='Producto:';
t5='cantidad:';
t6='Precio:';
t7='Importe:';
t8='Cantidad de productos: ';
t9='Subtotal:';
t10='ITBIS:';
t11='TOTAL:';

var
cantidad, precio, importe, subtotal, itbis, total :real;
numfactura, cantproduc, y:integer;
cliente, product, fecha :string;


begin
y:=7;
clrscr;
writeln('inserte la fecha de hoy: ');
 readln(fecha);
 clrscr;
 writeln('SUPERMERCADO');
 writeln(fecha);


 repeat
 numfactura:=numfactura+1;
 writeln(t1, numfactura);

 write('Inserte nombre cliente:');
 gotoxy(1,5);
 read(cliente);
 if cliente='0' then break;

  gotoxy(1,6);
  write(t4);
  gotoxy(14,6);
  write(t6);
  gotoxy(24,6);
  write(t5);
  gotoxy(36,6);
  write(t7);

 repeat


  read(product);



 until(precio=0);

 total:=subtotal+itbis;
 writeln(total:10:2);
 writeln(cantproduc);

 writeln(subtotal:10:2);
 writeln(itbis:10:2);



 readkey;
 clrscr;
 until cliente = '0';

end.



