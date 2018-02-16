@echo off

echo This tool uses the remote repository as the merge base
set /p usercont = "Do you want to continue?"
IF %userocnt% == “Y”  goto runfile 
ELSE goto exit

:runfile
Git pull -x theirs origin

:exit
echo Exiting App...