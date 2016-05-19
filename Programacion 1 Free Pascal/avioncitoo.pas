program avion;

uses    crt,graph;


var

cl,fl:integer;
t:char;
x,y,z,a,b,c,p,car,ga,r,op:integer;

{////////////////explocion de la nave\\\\\\\\\\\\\\\\\\\}

procedure bomba(x1,y1,x2,y2:integer);

var x,y:integer;


                  begin
                        for x:=x1 to x2 do
                        for y:=y1 to y2 do
                                begin
                                gotoxy(x,y);  write('  \\|//  ');
                                gotoxy(x,y+1);write(' -     - ');
                                gotoxy(x,y+2);write(' -     -  ');
                                gotoxy(x,y+2);write('  //|\\  ');
                                end;

                  end;






{/////////////////LIMPIEZA\\\\\\\\\\\\\\\\\\\}

procedure limp(x1,y1,x2,y2:integer);

var

x,y:integer;
begin
        for x:=x1 to x2 do
        for y:= y1 to y2 do
        begin
        gotoxy(x,y); write(' ');


        end;
end;



begin
textbackground(blue);
clrscr;
        cl:=30; fl:=22;  z:=3; a:=2; b:=5; c:=3; p:=0; ga:=-4;



        {menu del programa}
        repeat
          textcolor(white);
          gotoxy((80-length('SEGUNDO PARCIAL DE LAB.DE PROGRAMACION I')) DIV 2,1);WRITE('SEGUNDO PARCIAL DE LAB.DE PROGRAMACION I');
          gotoxy((80-length('PRESENTADO POR:                         ')) DIV 2,2);WRITE('ANDY GIL    | JOSE DE LA CRUZ | YOEL NUNEZ');
          gotoxy((80-length('MATRICULA NO. :                         ')) DIV 2,3);WRITE('2012-1606   | 2012-1675       | 2012-1989 ');
          gotoxy((80-length('1-JUGAR                                 ')) DIV 2,7);WRITE('1-JUGAR');
          gotoxy((80-length('2-INSTRUCCIONES                         ')) DIV 2,8);WRITE('2-INSTRUCCIONES');
          gotoxy((80-length('0-SALIR                                 ')) DIV 2,9);WRITE('0-SALIR');
          gotoxy((80-length('SU OPCION:                              ')) DIV 2,11);WRITE('SU OPCION:');READ(op);

        {opciones de menu}
         case op of

        1:begin



        limp(1,1,80,25);

        {progreso}
        for car:= 20 to 45 do
        begin
        textcolor(car);
        ga:=ga+4;
        gotoxy(30,12);write('CARGANDO');
        gotoxy(car,13);write(#254);
        gotoxy(35,14);write(ga,'%');delay(90);

        end;
        {limpieza de pantalla para que borre los residuos del progreso de carga}
         limp(1,1,80,25);
         for r:= 5 to 20 do
                begin
                textcolor(r);
                {moneria por que amimee}
            gotoxy(1,r);write('@');
            gotoxy(80,r);write('@');delay(50);
                end;
            repeat
                textcolor(white);
                while not keypressed do
                  begin
                {movimiento del avioncito enemigo a su antojo}
                  inc(a);
                  inc(b);
                  gotoxy(a,z-1); write('       ');
                  gotoxy(a,z);   write(' |[.]| ');
                  gotoxy(a,z+1); write('       ');
                  gotoxy(a,b-1); write('       ');
                  gotoxy(a,b); write(' |   | '); delay(50);
                  if(a=73) then limp(a,z,a+5,z);
                  limp(a,b,a+5,b+5);
                  if(a=73) then  a:=2;
                  if(b=21)then b:=5;


                  {condicion para que explote}
                  if(b=fl-3)and((cl=a)or(cl+2=a)or(cl-2=a)or(cl+1=a)or(cl-1=a)or(cl+3=a)or(cl-3=a)or(cl+4=a)or(cl-4=a))then
                  begin
                  bomba(cl-2,b,cl+2,b+2);
                  limp(cl-2,b,cl+10,b+4);
                  c:=c-1;
                  end;

                  end;
               {movimiento del cursor}

                t:=readkey;


                case t of

                #72:if (fl>2)  then  dec(fl);

                #80:if (fl<23) then inc(fl);




                #75:if (cl>2) then dec(cl);



                #77:if(cl<73) then inc(cl);


                  {balas explosivas}


                 #49:for y:= fl-2 downto 5 do

                        begin
                                gotoxy(cl+2,y-1); write('   ');
                                gotoxy(cl+2,y);   write(' ',#127,' ');
                                gotoxy(cl+2,y+1); write('   ');delay(5);
                                limp(cl,y,cl+8,5);
                                if(y=5)and((a=cl)or(a+2=cl)or(a-2=cl)or(a+1=cl)or(a-1=cl)or(a+3=cl)or(a-3=cl)or(a+4=cl)or(a-4=cl))then
                                 begin
                                bomba(cl,y-2,cl,y-2);
                                 limp(cl-4,y-2,cl+8,y+2);
                                 p:=p+1;
                                 a:=2;
                                 z:=z+1;
                                 if(z=7)then z:=3;
                                 end;



                        end;









                end;
                {movimiento de la nave por las teclas del cursor}
                gotoxy(cl,fl-1); write('       ');
                gotoxy(cl,fl);   write(' |(^)| ');
                gotoxy(cl,fl+1); write('       ');
                textcolor(red);
                gotoxy(1,1); write('VIDAS=',c);
                gotoxy(12,1);write('PUNTAJE=',p);


                {condicion para que solo llegue hasta la mitad de la pantalla}
                if (fl=13) then fl:=fl+1;
                if(c=0)then
                begin


                t:=#27;




                end;


                until(t=#27); {esc}

                {puntuacion en el fin del juego}
                limp(1,1,80,25);
                gotoxy((80-length('GAME OVER'))DIV 2,10);write('GAME OVER');
                gotoxy((80-length('PUNTAJE=   '))DIV 2,11);write('PUNTAJE=',p);readkey;
                limp(1,1,80,25);
                end;


              2:begin

              {pasos para jugar}
                limp(1,1,80,25);
                gotoxy(1,1);write('(INTRUCCIONES: DEVERA MOVER LAS TECLAS DEL CURSOR PARA VOVER ');
                gotoxy(1,2);write(' EL AVION QUE SE ENCUENTRAEN PELIGRO POR LA TECLA QUE REPRESENTA');

                gotoxy(1,3);write('EL NUMERO UNO(1) SE DISPARAN BALAS QUE HACEN QUE LA NAVE EXPLOTE Y ');

                gotoxy(1,4);write('AVANCE A UNA POSICION MAS SERCA DE TI, CADA VES QUE ASIERTAS ');

                gotoxy(1,4);write(' EL PUNTAJE SERA MAYOR, PERO SOLO CUENTAS CON TRES VIDAS PARA  ');
                gotoxy(1,5);write('EL JUEGO, PARA SALIR DEL JUEGO DEVES PULSAR LA TECLA ESCAPE(ESC).');
                readkey;

                 limp(1,1,80,25);
                 end;

              0:begin
                        gotoxy(1,23);write('SALIENDO...'); DELAY(3000);
                        end;
                end;

                until(op=0);




                end.



