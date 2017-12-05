# deepinstall
The CLI Installer that elevates so much it will make you giddy.


## Changes
* (2017-12-04) signed with included key (aka "strongly named"):
	* tries to guarantee uniqueness in the GAC, but does not guarantee any kind of security (Microsoft recommends distibuting the private key with your software if code is public, and things can be decompiled and re-signed either way)
	* needed for installing Local System services, especially with uiAccess in manifest
	* needed for linking with programs which are signed
* (2017-12-01) started scripting functionality

## Known Issues
* implement base functionality (install programs using scripts)