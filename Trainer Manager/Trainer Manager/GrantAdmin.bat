@echo off
reg add "HKCU\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers" /v %~1 /d "RUNASADMIN"