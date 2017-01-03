@echo off
set /p id="Enter private key file pass: "
"C:\Program Files (x86)\Windows Kits\10\bin\x86\signtool" sign /t http://timestamp.verisign.com/scripts/timestamp.dll /f "%USERPROFILE%\Documents\My Private Key.pfx" /p %id% "Trainer Manager\bin\Debug\New Age Trainer Manager.exe"
"C:\Program Files (x86)\Windows Kits\10\bin\x86\signtool" sign /t http://timestamp.verisign.com/scripts/timestamp.dll /f "%USERPROFILE%\Documents\My Private Key.pfx" /p %id% "Trainer Installer\Debug\setup.exe"
"C:\Program Files (x86)\Windows Kits\10\bin\x86\signtool" sign /t http://timestamp.verisign.com/scripts/timestamp.dll /f "%USERPROFILE%\Documents\My Private Key.pfx" /p %id% "Trainer Installer\Debug\New Age Trainer Manager Installer.msi"
pause