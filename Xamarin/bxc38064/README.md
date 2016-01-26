[Xamarin Bug 38064](https://bugzilla.xamarin.com/show_bug.cgi?id=38064) - DataContractJsonSerializer does not work under the "supported" 4.5 profile

## Repro

Run the project under Xamarin Studio. Pressing the button in the application should result in a crash. Switching the target framework to the supported Xamarin.Mac mobile profile will result in a successful execution of the code.

## Environment

```
=== Xamarin Studio ===

Version 5.10.2 (build 55)
Installation UUID: 2701a58e-0630-4e42-b81d-229161066215
Runtime:
	Mono 4.2.2 (explicit/996df3c)
	GTK+ 2.24.23 (Raleigh theme)

	Package version: 402020030

=== Xamarin.Profiler ===

Not Installed

=== Apple Developer Tools ===

Xcode 7.0 (8223)
Build 7A218

=== Xamarin.iOS ===

Version: 9.4.1.24 (Business Edition)
Hash: 47eb74b4
Branch: master
Build date: 2016-01-20 17:06:01-0500

=== Xamarin.Android ===

Version: 6.0.1.9 (Business Edition)
Android SDK: /Users/aaron/Library/Developer/Xamarin/android-sdk-macosx
	Supported Android versions:
		2.3   (API level 10)
		4.0.3 (API level 15)
		4.4   (API level 19)
		5.0   (API level 21)
		5.1   (API level 22)

SDK Tools Version: 24.4.0
SDK Platform Tools Version: 23.0.1
SDK Build Tools Version: 23.0.1

Java SDK: /usr
java version "1.8.0_40"
Java(TM) SE Runtime Environment (build 1.8.0_40-b27)
Java HotSpot(TM) 64-Bit Server VM (build 25.40-b25, mixed mode)

=== Xamarin Android Player ===

Version: 0.3.7
Location: /Applications/Xamarin Android Player.app

=== Xamarin.Mac ===

Version: 2.4.1.6 (Business Edition)

=== Build Information ===

Release ID: 510020055
Git revision: 7c95611a8097853826b8ee411887a1f88cf83add
Build date: 2016-01-19 22:23:27-05
Xamarin addins: 9816bee7ff5ab3845ef51354dc687010422beb68
Build lane: monodevelop-lion-cycle6-c6sr1

=== Operating System ===

Mac OS X 10.11.3
Darwin porkbelly.local 15.3.0 Darwin Kernel Version 15.3.0
    Thu Dec 10 18:20:09 PST 2015
    root:xnu-3248.30.4~2/RELEASE_X86_64 x86_64
```
