#!/bin/bash

#------------------------------------------------------------------------
# TODO 
# 	start *.command from folder! default pwd is ~ ($HOME)
#------------------------------------------------------------------------

#------------------------------------------------------------------------
# cd to folder where sharpies is!!!!!!
#
# ../sbin/sharpie
# or
# ~/bin/sharpie
#
# error
# mbp:folder moljac$ ./generate-bindings.sh.command
# Cannot open assembly './lib/Sharpie.exe': No such file or directory.

pwd
# ../sbin/sharpie


# cd ~/bin/
cd ../sbin/
./sharpie --version 
./sharpie --show-sdks 
./sharpie --help

#------------------------------------------------------------------------
# TODO 
# 	
#------------------------------------------------------------------------


#------------------------------------------------------------------------
# Help
#
# Usage: sharpie [OPTIONS]+ -framework|<HEADER_FILES>+ [<CLANG_ARGS>+]
# 
# Options:
#   -h, --help                 Show this help message and exit
#       --version              Show detailed version and build information
# 
# Binding Options:
#   -s, --sdk=VALUE            Target SDK (see --help for a list of available SDKs
#       --show-sdks            Show all available Xcode SDKs for use with -sdk
#   -n, --namespace=VALUE      C# namespace to use
#   -f, --framework=VALUE      Framework name to bind
#       --framework-root=VALUE Path to find --framework (default: /System/Library/
#                                Frameworks)
#       --follow-includes      Generate bindings for #include-ed or #import-ed
#                                files (always true when -framework is used)
#   -r, --recurse              Recurse into directories looking for header files
#       --scope=VALUE          Restrict following includes to within a directory (
#                                always set with -framework is used)
#       --skip-massage         Do not massage resulting API into extra C#isms
#       --sexp                 Don't parse S-Expression output from Sharpie's
#                                Objective C parser
#       --omit-verify-attrs    Do not produce [Verify] attributes
#   -c, --clang                Any arguments after are passed directly to clang
#   -v, --verbose              Be more verbose with output to stderr
# 
# Filtering Options:
#       --platform=VALUE       Match APIs only from a given platform; supported
#                                values:
#                                ios|macosx[<|>|=|<=|>=|!=]MAJOR.MINOR
#       --type=VALUE           Match only a specific type name
#       --true                 Always evaluates to TRUE
#       --false                Always evaluates to FALSE
#       --and                  Join two filters with boolean AND (default if
#                                omitted)
#       --or                   Join two filters with boolean OR
#       --not                  Invert the filter that follows (boolean NOT)
#   -(                         Start a parenthetical boolean group
#   -)                         End a parenthetical boolean group
#       --allow-empty-types    Do not filter out types that have no members
#       --dump-filter          Dump the filter at its current state for debugging
#                                (disables parsing)
#------------------------------------------------------------------------
