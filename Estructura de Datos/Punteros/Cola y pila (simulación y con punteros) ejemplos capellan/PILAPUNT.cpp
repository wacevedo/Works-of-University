PROGRAM pila_emulando_cava_de_vinos;
USES CRT;
const
        maxpila = 3;
type
        tipoelemento = ^TIPOPILA;
        tipopila=record
                        elementos:array[1..maxpila] of tipoelemento;
                        cabeza:0..maxpila;
                        siguiente: tipoelemento; 
                 end;
function pilallena(pila:tipopila):boolean;
begin
        pilallena:=pila.cabeza = maxpila;
end;
function pilavacia(pila:tipopila):boolean;
begin
        pilavacia:=pila.cabeza = 0;
end;
procedure meter(var pila:tipopila;nuevoelemento:tipoelemento);
begin
        pila.cabeza := pila.cabeza + 1;
        pila.elementos[pila.cabeza]:=nuevoelemento
end;
procedure sacar(var pila:tipopila; var elemsacado:tipoelemento);
begin
        elemsacado:=pila.elementos[pila.cabeza];
        pila.cabeza := pila.cabeza - 1;
end;
procedure limpiarpila(var pila:tipopila);
begin
        pila.cabeza := 0;
end;
 
VAR
   pilafr,pilach,pilame,pilaca:tipopila;
   tipo,x:char;
   cosecha,cos:tipoelemento;
begin
        clrscr;
        tipo:='a';
        while tipo <> 'x' do
        begin
                write('Año de cosecha: ');readln(cosecha);
                write('Tipo de vino f/c/m/a/x (salir) : ');readln(tipo);
                if tipo = 'f' then
                        if not pilallena(pilafr) then
                                meter(pilafr,cosecha)
                        else
                                writeln('No caben mas vinos franceses');
               if tipo = 'c' then
                        if not pilallena(pilach) then
                                meter(pilach,cosecha)
                        else
                                writeln('No caben mas vinos chilenos');
               if tipo = 'm' then
                        if not pilallena(pilame) then
                                meter(pilame,cosecha)
                        else
                                writeln('No caben mas vinos mexicanos');
               if tipo = 'a' then
                        if not pilallena(pilaca) then
                                meter(pilaca,cosecha)
                        else
                                writeln('No caben mas vinos californianos');
        end;
        (*IMPRESION DE LA CAVA DE VINOS FRANCESES*)
        while not pilavacia(pilafr) do
        begin
                sacar(pilafr,cos);
                writeln('cosecha:',cos);
        end;
        read(x);
(*COMO EJERCICIO: PREGUNTA SI SE DESEA VACIAR POR COMPLETO UNA CAVA Y*)
(*UTILIZA EL PROCEDIMIENTO LIMPIARPILA*)
end.
