# 3DEXPERIENCE Minidump

> The session needs to be restarted; we apologize for the inconvenience

## About
Fake 3DEXPERIENCE incident report message generator. Your favorite 3DEXPERIENCE feature, whenever you want !

![](Minidump/ressources/pictures/demo.gif)

## Usage
1. Start `Minidump.exe`
2. Enjoy
3. Repeat

You don't need 3DEXPERIENCE to run the `Minidump.exe` program.  
Fully portable, no admin rights / setup needed.

If you want to edit the dialog box message, just edit the `Minidump.exe.config` file :

```xml
<applicationSettings>
	<Minidump.My.MySettings>
		<setting name="MsgBoxText" serializeAs="String">
			<value>OOPS ! April fool's joke !</value>
		</setting>
	</Minidump.My.MySettings>
</applicationSettings>
```

![](Minidump/ressources/pictures/demo_advanced.gif)

## Requirements
- Microsoft [.NET Framework 4](https://www.microsoft.com/en-US/download/details.aspx?id=17851)
- Microsoft Windows Vista or later

## License
3DEXPERIENCE Minidump is released under the [Unlicense](http://unlicense.org).