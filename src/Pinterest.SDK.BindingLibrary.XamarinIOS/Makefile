# common definitions in here

MONOXBUILD	= /Library/Frameworks/Mono.framework/Commands/xbuild
X_MS_BUILD	= /Library/Frameworks/Mono.framework/Versions/3.2.7/bin/xbuild
			# xbuild # old version
BTOUCH		=/Developer/MonoTouch/usr/bin/btouch
MDTOOL		=/Applications/Xamarin\ Studio.app/Contents/MacOS/mdtool 


RM			= rm
ECHO		= echo
PWD 		= $(shell pwd)

DIRS		= src samples component

all:		clean PinterestSDK.dll debug release

debug:
			$(X_MS_BUILD) \
				/p:Configuration=Debug \
				/verbosity:diagnostic \
				Pinterest.SDK.BindingLibrary.XamarinIOS.csproj
	

release:
			$(X_MS_BUILD) \
				/p:Configuration=Release \
				/verbosity:diagnostic \
				Pinterest.SDK.BindingLibrary.XamarinIOS.csproj
	
PinItSDKiOS.zip:
			curl -O https://pinterest-ota-builds.s3.amazonaws.com/PinItSDKiOS.zip > $@
			unzip $@

Pinterest: PinItSDKiOS.zip
			cp \
				PinItSDKiOS/Pinterest.embeddedframework/Pinterest.framework/Versions/A/Pinterest \
				Pinterest

Resources/PinterestSDKResources.bundle: PinItSDKiOS.zip Pinterest
			mkdir Resources
			cp -R \
				PinItSDKiOS/Pinterest.embeddedframework/Pinterest.framework/Versions/A/Resources/* \
				Resources/

PinterestSDK.dll: 	Makefile \
					Pinterest.linkwith.cs \
					Com.Pinterest.Pinit.ApiDefinition.cs \
					StructsAndEnums.cs \
					Com.Pinterest.Pinit.ApiDefinition.Extras.cs \
					Pinterest \
					Resources/PinterestSDKResources.bundle
			$(X_MS_BUILD) \
				/p:Configuration=Release \
				/verbosity:diagnostic \
				Pinterest.SDK.BindingLibrary.XamarinIOS.csproj
			cp \
				bin/Release/Pinterest.SDK.BindingLibrary.XamarinIOS.dll \
				Pinterest.SDK.BindingLibrary.XamarinIOS.dll

prepare: Resources/GoogleMaps.bundle

clean:	
	$(ECHO) cleaning up in $(PWD)
	-$(RM) -fr bin/ obj/
	-$(RM) -f  $(EXE) $(OBJS) $(OBJLIBS)
	-rm -rf list ios Resources/ PinItSDKiOS/ bin/ obj/ *.sln *.userprefs *.dll *.o *.zip *.mdb Pinterest __MACOSX
	