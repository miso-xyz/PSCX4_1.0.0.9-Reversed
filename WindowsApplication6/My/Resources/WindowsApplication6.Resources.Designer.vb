Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace WindowsApplication6.My.Resources
	' Token: 0x02000011 RID: 17
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")>
	<HideModuleName()>
	<CompilerGenerated()>
	<DebuggerNonUserCode()>
	Friend NotInheritable Module Resources
		' Token: 0x17000061 RID: 97
		' (get) Token: 0x0600010B RID: 267 RVA: 0x000075E0 File Offset: 0x000057E0
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend ReadOnly Property ResourceManager As ResourceManager
			Get
				Dim flag As Boolean = Object.ReferenceEquals(Resources.resourceMan, Nothing)
				If flag Then
					Dim resourceManager As ResourceManager = New ResourceManager("WindowsApplication6.Resources", GetType(Resources).Assembly)
					Resources.resourceMan = resourceManager
				End If
				Return Resources.resourceMan
			End Get
		End Property

		' Token: 0x17000062 RID: 98
		' (get) Token: 0x0600010C RID: 268 RVA: 0x00007628 File Offset: 0x00005828
		' (set) Token: 0x0600010D RID: 269 RVA: 0x000025C8 File Offset: 0x000007C8
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend Property Culture As CultureInfo
			Get
				Return Resources.resourceCulture
			End Get
			Set(value As CultureInfo)
				Resources.resourceCulture = value
			End Set
		End Property

		' Token: 0x04000071 RID: 113
		Private resourceMan As ResourceManager

		' Token: 0x04000072 RID: 114
		Private resourceCulture As CultureInfo
	End Module
End Namespace
