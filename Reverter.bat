@echo off

echo Warning! This will undo all the changes made to the repository!
set /p usercont = "Do you want to continue(Y/N)?"
IF %usercont%=='Y' goto runfile
ELSE goto exit

:runfile
git reset --hard

:exit
echo Exiting App...