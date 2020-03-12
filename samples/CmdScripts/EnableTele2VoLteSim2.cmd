echo off
title Set modem config
set EFSTOOLS=..\..\EfsTools.exe
set MODEMCONFIG=..\ModemConfigs\tele2-volte-items.json
%EFSTOOLS% setModemConfig -p %MODEMCONFIG% -s1

pause