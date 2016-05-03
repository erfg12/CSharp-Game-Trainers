for /d /r . %%d in (obj,debug,.vs,bin) do @if exist "%%d" rd /s/q "%%d"
del /S /F /AH *.suo
del /S /F /AH *.htm
del /S /F /AH *.exe
rmdir /S /F /AH Debug
rmdir /S /F /AH Release