echo off
title Supported LTE bands
set EFSTOOLS=..\..\EfsTools.exe
set EXTRACTPATH=lte_bands_${date:format=yyyyMMdd_HHmmss}.json
%EFSTOOLS% getModemConfig -m LteBandPreference -p %EXTRACTPATH%
pause