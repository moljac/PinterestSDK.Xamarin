# common definitions in here
X_MS_BUILD	= /Library/Frameworks/Mono.framework/Versions/3.2.7/bin/xbuild
			# xbuild # old version
BTOUCH		=/Developer/MonoTouch/usr/bin/btouch
MDTOOL		=/Applications/Xamarin\ Studio.app/Contents/MacOS/mdtool 

RM			= rm
ECHO		= echo

DIRS		= src samples component



all:		clean debug release

debug:
			$(MDTOOL) \
				--verbose \
				build '--configuration:Debug|iPhone' \
				Pinterest.App.XamarinIOS.csproj
	

release:
			$(MDTOOL) \
				--verbose \
				build '--configuration:Release|iPhone' \
				Pinterest.App.XamarinIOS.csproj
	

clean:	
			$(ECHO) cleaning up in .
			-$(RM) -fr bin/ obj/
			-$(RM) -f  $(EXE) $(OBJS) $(OBJLIBS)
	
	
	$(MDTOOL) --verbose  build '--configuration:Release|iPhone' Pinterest.App.XamarinIOS.csproj