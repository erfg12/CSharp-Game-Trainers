@echo off
reg add "HKCU\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers" /v "%CD%\PROGRAM.exe" /d "RUNASADMIN"
pause