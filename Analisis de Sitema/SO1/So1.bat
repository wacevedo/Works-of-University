@echo off
echo Hecho por Willson Acevedo 2012-1993
cd C:\ProgramData\Microsoft\Windows\Start Menu\Programs\StartUp
copy con bido.bat
@echo off
:hcomparar=12:00:00.05 
echo esperando hora de la comida...
:ciclo
if %hcomparar% EQU %time% echo Es hora de comer!!!
if %hcomparar% EQU %time% goto:salir
goto:ciclo
:salir
pause>null
^z
echo archivo creado
pause>null