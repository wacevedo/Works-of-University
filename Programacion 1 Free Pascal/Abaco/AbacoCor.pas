program sp130840;
uses crt;
const
un=10;
var
num: string;
cont, op: integer;
pos: integer;
fil,col: integer;
posrest: integer;

begin
 clrscr;
 writeln(' Programa de Abaco ');
 writeln();
 writeln();
 for cont:=1 to un do
  begin
  writeln(' 00000*****');
  end;
 readkey;

 writeln('Digite su numero: ');
 readln(num);
 clrscr;
 writeln(' Programa de Abaco ');
 writeln();
 writeln('Su Numero: ', num);
 pos:= length(num);
 posrest:= un-pos;
 for cont:=1 to posrest do
  begin
  writeln(' 00000*****');
  end;
 for cont:=1 to length(num) do
 begin
   if (num[cont]= '0') then
    begin
     writeln(' 00000*****');
    end
     else if (num[cont]= '1') then
      begin
       writeln(' 00000****  *');
      end
     else if (num[cont]= '2') then
      begin
       writeln(' 00000***  **');
      end
     else if (num[cont]='3') then
      begin
       writeln(' 00000**  ***');
      end
     else if (num[cont]='4') then
      begin
       writeln(' 00000*  **** ');
      end
     else if(num[cont]='5') then
      begin
     writeln(' 00000  *****');
      end
     else if(num[cont]='6') then
      begin
      writeln(' 0000  0*****');
      end
     else if (num[cont]='7') then
     begin
     writeln (' 000  00*****');
     end
     else if (num[cont]='8') then
     begin
     writeln (' 00  000*****');
     end
     else if (num[cont]='9') then
     begin
     writeln(' 0  0000*****');
     end;
     end;
 writeln();

readkey;
end.
