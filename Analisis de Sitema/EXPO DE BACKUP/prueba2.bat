@echo off
 set FECHA_ACTUAL=%DATE%
 set HORA_ACTUAL=%TIME%
 set ANO=%FECHA_ACTUAL:~6,4%
 set MES=%FECHA_ACTUAL:~3,2%
 set DIA=%FECHA_ACTUAL:~0,2%
 set HORA=%HORA_ACTUAL:~0,2%
 set MINUTOS=%HORA_ACTUAL:~3,2%
 set SEGUNDOS=%HORA_ACTUAL:~6,2%
pause>null
XCOPY C:\Users\Willson Acevedo\Desktop\tarea.txt C:\Users\Willson Acevedo\Desktop\New folder (2) /s /i
pause>null