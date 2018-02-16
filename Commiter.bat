@echo off

echo Make sure to add any necessary files before running this tool (git add filename)!
set /p usercont = "Do you want to continue?"
IF %userocnt% == “Y”  goto runfile 
ELSE goto error

:error 
echo Not Continuing. Exiting...

:runfile
git add .
Set /p commitMessage=Enter commit comment
git commit -a  -m %commitMessage%
git push --all
