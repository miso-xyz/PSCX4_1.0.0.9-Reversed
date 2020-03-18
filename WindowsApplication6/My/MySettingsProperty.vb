Imports System
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace WindowsApplication6.My
	' Token: 0x02000013 RID: 19
	<DebuggerNonUserCode()>
	<HideModuleName()>
	<CompilerGenerated()>
	Friend NotInheritable Module MySettingsProperty
		' Token: 0x17000064 RID: 100
		' (get) Token: 0x06000112 RID: 274 RVA: 0x000076F8 File Offset: 0x000058F8
		<HelpKeyword("My.Settings")>
		Friend ReadOnly Property Settings As MySettings
			Get
				Return MySettings.[Default]
			End Get
		End Property
	End Module
End Namespace
