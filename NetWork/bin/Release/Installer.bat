@echo off
title NetWork Installer

%WINDIR%\Microsoft.NET\Framework64\v4.0.30319\RegAsm /codebase %~dp0\NetWork.dll

taskkill /im explorer.exe /f
start explorer.exe

pause