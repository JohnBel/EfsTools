echo off
title Extract MBN file
set EFSTOOLS=..\..\EfsTools.exe
set MBNFILE=mcfg_sw.mbn
set EXTRACTPATH=content
%EFSTOOLS% extractMbn -i %MBNFILE% -p %EXTRACTPATH% -n

pause