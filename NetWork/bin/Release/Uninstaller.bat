@echo off
title NetWork Uninstaller

%WINDIR%\Microsoft.NET\Framework64\v4.0.30319\RegAsm /u %~dp0\NetWork.dll

taskkill /im explorer.exe /f
start explorer.exe

pause