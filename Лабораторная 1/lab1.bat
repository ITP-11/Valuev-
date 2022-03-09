@echo off
cls
:start
echo vvedite pervoe rashirenie
set /p r1=""
@REM EFI
For /R "D:\" %%i In ("%r1%") Do ( 
	(echo %%i >> E:\write.txt)
)
echo vvedite vtoroe rashirenie
set /p r2=""
@REM ISO
For /R "E:\" %%i In ("%r2%") Do (
	(echo %%i >> E:\write.txt)
)
echo vvedite tretie rashirenie
set /p r3=""
@REM CDR
For /R "C:\" %%i In ("%r3%") Do (
	(echo %%i >> E:\write.txt)
)
COPY "E:\write.txt" "E:\FolderX"
start WinRAR A "E:\arhiv.rar" "E:\FolderX"
pause