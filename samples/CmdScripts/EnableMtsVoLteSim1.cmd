echo off
title Set modem config
set EFSTOOLS=..\..\EfsTools.exe
set MODEMCONFIG=..\ModemConfigs\mts-volte-items.json
%EFSTOOLS% setModemConfig -p %MODEMCONFIG% -s0

pause