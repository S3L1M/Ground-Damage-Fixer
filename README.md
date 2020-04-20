S3L1M created a very useful program to help revert files captured by `ground.exe` virus.  I got infected, amd noticed it fairly quickly when I noticed `ground.exe` running in task manager.  I would like to create this updated readme with more detailed instructions for using Ground-Damage-Fixer. Of course, you already have `Ground` stopped and are stuck with this messy aftermath. I included how I removed `Ground.exe` below in case you came across this page while still searching for a way to remove the virus.

The command to manualy unhide and retsore permissions to a file/folder is
```
attrib -H -S *.exe /S /D
```

1) Run `Super Unhider`
2) Click on `Add Files`
2) search for files with `size:534,016`
![Alt Text](https://github.com/bizzar721/Ground-Damage-Fixer/blob/master/1111.png)
3 )After search is complete, use `CTRL-A` to select all, then `CTRL-X` to cut (Icons should all now be transparent)
![Alt Text](https://github.com/bizzar721/Ground-Damage-Fixer/blob/master/2222.png)
4) Click `Open`
5) Open `Recycle Bin`, then `CTRL-V` to paste the infected `.exe`s
![Alt Text](https://github.com/bizzar721/Ground-Damage-Fixer/blob/master/3333.png)
6) Click on the top entry in `Super Unhider` and click `Unhide` (runs from selected downward)
7) Give it a minute to finish, then select the top entry again and click `Rename`

All files should now be restored.

# Removing Ground.exe
* I recomend having Malwarebytes Anti-malware installed (free)
* Boot into   `Safe Mode` . This can be done by typing `msconfig` in the search bar.
* Select `boot` tab and select `Safe boot`
* After restarting in safe mode, go into your start menu and delete `ground.exe` from your `start up` folder
* Go to `%appdata%/Roaming` and remove `ground.exe`
* Run `msconfig` and uncheck safemode (but do not restart yet)
* For safe measure, run Malwarebytes Anti-malware, then reboot



ORIGINAL README by S3L1M
# Ground-Damage-Fixer
Ground virus leaves infected undetectable files with ugly icons, this program uses simple command to remove it and restore orignal files.
you can find the program in Executable folder

# How to use
[YouTube Video](https://youtu.be/uvOk7dA5dy0)
