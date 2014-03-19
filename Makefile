# common definitions in here
X_MS_BUILD	= /Library/Frameworks/Mono.framework/Versions/3.2.7/bin/xbuild
			# xbuild # old version
BTOUCH		=/Developer/MonoTouch/usr/bin/btouch
MDTOOL		=/Applications/Xamarin\ Studio.app/Contents/MacOS/mdtool 

RM			= rm
ECHO		= echo

DIRS		= src samples component



all:		clean src samples component

src:		 
			cd src && $(MAKE)

samples:		 
			cd samples && $(MAKE)

component:		 
			cd component && $(MAKE)

clean:	
			$(ECHO) cleaning up in .
			-$(RM) -f $(EXE) $(OBJS) $(OBJLIBS)
			-for d in $(DIRS); do (cd $$d; $(MAKE) clean ); done
	