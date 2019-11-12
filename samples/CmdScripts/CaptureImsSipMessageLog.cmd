echo off
title IMS SIP Logs
set EFSTOOLS=..\..\EfsTools.exe
%EFSTOOLS% getLog -l IMS_MESSAGE
pause