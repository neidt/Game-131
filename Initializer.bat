@echo off

REM Clones Repository
Set /p repURL=Enter the URL of the repository:
git clone %repURL%
REM pull branches/make new branch for development
Set /p newBranch=Enter the name of the new branch:
git branch %newBranch% 
REM Switch to newly made branch
git checkout %newBranch%
REM Sets user credentials
Set /p userName=Enter your user name:
git config user.name %userName%
Set /p userEmail=Enter your email:
git config user.email %userEmail%
