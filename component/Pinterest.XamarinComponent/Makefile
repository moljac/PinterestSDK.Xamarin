
MONO		=	/Library/Frameworks/Mono.framework/Versions/3.2.7/bin/mono
XPKG		=	./sbin/xpkg/xamarin-component.exe
PACKAGE		=Pinterest

all: component 

component:
	mkdir content/bin ; \
	mkdir content/lib ; \
	cp -fr ../../src/Pinterest.SDK.BindingLibrary.XamarinAndroid/bin/Debug/* content/bin/ ; \
	cp -fr ../../src/Pinterest.SDK.BindingLibrary.XamarinAndroid/bin/Debug/* content/lib/ ; \
	cp -fr ../../src/Pinterest.SDK.BindingLibrary.XamarinIOS/bin/Debug/* content/bin/ ; \
	cp -fr ../../src/Pinterest.SDK.BindingLibrary.XamarinIOS/bin/Debug/* content/lib/ ; \
	$(MONO) $(XPKG) \
	create-manually \
		$(PACKAGE)-1.0.xam \
		--name="Pinterest" \
		--summary="Pinterest SDK ..." \
		--publisher="Xamarin" \
		--website="http://xamarin.com/" \
		--details="content/Details.md" \
		--license="content/License.md" \
		--getting-started="content/GettingStarted.md" \
		--icon="content/icons/Pinterest_128x128.png" \
		--icon="content/icons/Pinterest_512x512.png" \
		--library="ios":"content/bin/Pinterest.SDK.BindingLibrary.XamarinIOS.dll" \
		--sample="Sample for iOS. $(PACKAGE) sample for iOS.":"content/samples/$(PACKAGE).iOS.sln" \
		--library="android":"content/bin/Pinterest.SDK.BindingLibrary.XamarinAndroid.dll" \
		--sample="Sample for Android. $(PACKAGE) sample for Android.":"content/samples/$(PACKAGE).Android.sln"
	
	
clean:
	rm -fr ./bin/ ; \
	rm -fr ./obj/ ; \
	rm -fr ./content/bin/ ; \
	rm -fr ./content/lib/ ; \
	

# msbuild ..\log4net.XamarinAndroid.vs2010\log4net.XamarinAndroid.vs2010.csproj \
# 		/p:Configuration=Release \
# 		/property:OutDir=..\XamarinComponent.log4net\content\bin\
# 
# msbuild ..\log4net.XamariniOS.vs2010\log4net.XamariniOS.vs2010.csproj \
# 		/p:Configuration=Release \
# 		/property:OutDir=..\XamarinComponent.log4net\content\bin\

