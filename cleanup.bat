for /d /r . %%d in (obj,.vs,bin,Debug,Release) do @if exist "%%d" rd /s/q "%%d"
del /S /F /AH *.suo
del /S /F /AH *.htm
del /S /F /AH *.msi
del /S /F /AH *.exe