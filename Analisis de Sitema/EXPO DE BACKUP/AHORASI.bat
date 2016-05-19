@echo off
 
set /p hcomparar=Introduce hora a comparar: HH:MM:SS.mm:
echo la hora es: %time% 
echo la hora a comparar es: %hcomparar% 
echo esperando...
:ciclo
if %hcomparar% EQU %time% shutdow
if %hcomparar% EQU %time% goto:salir
goto:ciclo
:salir
pause>null