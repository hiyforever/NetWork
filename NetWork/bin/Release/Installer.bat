@echo off

title Desk Band Debug Installer

SET path_dll=%cd%\NetWork.dll
SET path_regasm=%WINDIR%\Microsoft.NET\Framework64\v4.0.30319\RegAsm.exe

"%path_regasm%" /codebase %path_dll%

taskkill /im explorer.exe /f
start explorer.exe

pause
