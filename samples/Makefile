# common definitions in here
X_MS_BUILD	= /Library/Frameworks/Mono.framework/Versions/3.2.7/bin/xbuild
			# xbuild # old version
BTOUCH		=/Developer/MonoTouch/usr/bin/btouch
MDTOOL		=/Applications/Xamarin\ Studio.app/Contents/MacOS/mdtool 

RM			= rm
ECHO		= echo
PWD 		= $(shell pwd)

DIRS		= src samples component



all:		clean android ios

android:		 
			cd Pinterest.App.XamarinAndroid/ && $(MAKE)

ios:		 
			cd Pinterest.App.XamarinIOS/ && $(MAKE)

clean:	
			cd Pinterest.App.XamarinAndroid/ && $(MAKE) clean
			cd Pinterest.App.XamarinIOS/ && $(MAKE) clean
