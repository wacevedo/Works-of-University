Program Lesson9_Program2;
uses crt;
Var FName, Txt : String[10];
    UserFile   : Text;


Begin
clrscr;
 FName := 'Textfile';
 Assign(UserFile,'C:\'+FName+'.txt'); {assign a text file}
 Rewrite(UserFile); {open the file 'fname' for writing}
 Writeln(UserFile,'PASCAL PROGRAMMING');
 Writeln(UserFile,'if you did not understand something,');
 Writeln(UserFile,'please send me an email to:');
 Writeln(UserFile,'victorsaliba@hotmail.com');
 Writeln('Write some text to the file:');
 Readln(Txt);
 Writeln(UserFile,'');
 Writeln(UserFile,'The user entered this text:');
 Writeln(UserFile,Txt);
 Close(UserFile);
 readkey;
End.
