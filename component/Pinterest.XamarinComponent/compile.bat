@echo off
call "%PROGRAMFILES%\Microsoft Visual Studio 10.0\VC\vcvarsall.bat"

::=========================================================================================
set BUILD=msbuid
set PROJECT_ANDROID=..\log4net.XamarinAndroid.vs2010\log4net.XamarinAndroid.vs2010.csproj
set PROJECT_IOS=..\log4net.XamariniOS.vs2010\log4net.XamariniOS.vs2010.cspro
set COMPONENT_FOLDER=..\XamarinComponent.log4net
::=========================================================================================

rmdir /q /s .\bin\
rmdir /q /s .\content\bin\
rmdir /q /s .\content\lib

%BUILD%  ^
		%PROJECT_ANDROID% ^
		/p:Configuration=Release ^
		/property:OutDir=%COMPONENT_FOLDER%\content\bin\

%BUILD%  ^
		%PROJECT_IOS% ^
		/p:Configuration=Release ^
		/property:OutDir=%COMPONENT_FOLDER%\content\bin\

echo ======================================================================================
echo creating references for component samples in content\lib
echo folders 
echo		lib\android 
echo and
echo 		lib\ios
echo are generated during xam packaging
echo only Release build is for component
echo ======================================================================================

%BUILD%  ^
		%PROJECT_ANDROID% ^
		/p:Configuration=Release ^
		/property:OutDir=%COMPONENT_FOLDER%\content\lib\android

%BUILD%  ^
		%PROJECT_ANDROID% ^
		/p:Configuration=Release ^
		/property:OutDir=%COMPONENT_FOLDER%\content\lib\ios


@IF %ERRORLEVEL% NEQ 0 PAUSE	
