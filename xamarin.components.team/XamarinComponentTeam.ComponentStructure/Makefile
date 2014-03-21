COMPONENT_NAME			=Pinterest
#-------------------------------------------------------------------
# Component Team 
LOCATION_BINDINGS_IOS	=../monotouch-bindings/$(COMPONENT_NAME)
#LOCATION_BINDINGS_IOS	=src/bindings/
#-------------------------------------------------------------------
# moljac
# not using Android for projectnames (and namespaces) because of name collisions
LOCATION_BINDINGS_ANDROID=src/bindings/$(COMPONENT_NAME).XamarinAndroid/
#.....................................................................
# use following if iOS bindings are not in monotouch-bindings repo
#LOCATION_BINDINGS_ANDROID=src/bindings/$(COMPONENT_NAME).XamarinIOS/
#-------------------------------------------------------------------
LOCATION_XAMARIN_PACKAGE=./component/

all: ios android

android: clean
			-$(ECHO) =================================================================================
			cd  $(LOCATION_BINDINGS_ANDROID)/ && make

ios: clean
			-$(ECHO) =================================================================================
			cd  $(LOCATION_BINDINGS_IOS) && make

package:
			cd $(LOCATION_XAMARIN_PACKAGE) && make
			
clean:
			-$(ECHO) =================================================================================
			-$(ECHO) cleaning up in $(shell pwd)
			-$(RM) -fr bin/ obj/
			-$(RM) -f  $(EXE) $(OBJS) $(OBJLIBS) *.xam *.suo *.user .DS_Store
			cd  $(LOCATION_BINDINGS_ANDROID)/ && make clean
			cd  $(LOCATION_BINDINGS_IOS)/ && make clean
