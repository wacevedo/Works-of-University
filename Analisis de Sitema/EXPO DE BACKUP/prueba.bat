@echo off
set /p fcomparar=Introduce fecha a comparar: DD/MM/YYYY: 
set /p hcomparar=Introduce hora a comparar: HH:MM:SS.mm 
echo la fecha del sistema es: %date%
echo la fecha que quiero comparar es: %fcomparar%
echo la hora es: %time% 
echo la hora es: %hcomparar% 
pause>null
if %fcomparar% EQU %date% echo LAS FECHAS COINCIDEN!!
if %hcomparar% EQU %time% echo LAS horas COINCIDEN!!
IF %fcomparar% NEQ %date% echo LAS FECHAS NO COINCIDEN!!
IF %hcomparar% NEQ %time% echo LAS horas NO COINCIDEN!!
pause>null