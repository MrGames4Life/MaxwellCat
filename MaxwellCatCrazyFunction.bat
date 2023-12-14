:spawn
start MaxwellCat.exe
timeout /t 5 > nul
taskkill /f /im MaxwellCat.exe >nul
goto spawn
