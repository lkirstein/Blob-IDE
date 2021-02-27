@echo off

title VB Code Compile  -  Blob IDE
color f

for /f "Delims=" %%a  in (C:\Users\%username%\AppData\Roaming\Blob-IDE\Data\compile\vbc\locate.txt) do (

set TEXT=%%a

)


echo start !
echo.
echo.
cd C:\Windows\Microsoft.NET\Framework\v4.0.30319\
vbc %TEXT%
echo.
echo done!
echo.
echo Executable file is in the same directory as the .VB file
echo.
echo Press any key...
pause >nul
echo.
echo.
echo.
