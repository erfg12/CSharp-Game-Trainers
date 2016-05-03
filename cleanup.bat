for /d /r . %%d in (obj,.vs,bin) do @if exist "%%d" rd /s/q "%%d"
del /S /F /AH *.suo
del /S /F /AH *.htm