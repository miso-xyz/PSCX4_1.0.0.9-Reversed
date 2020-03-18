Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace WindowsApplication6.My
	' Token: 0x02000004 RID: 4
	<HideModuleName()>
	<GeneratedCode("MyTemplate", "10.0.0.0")>
	Friend NotInheritable Module MyProject
		' Token: 0x17000001 RID: 1
		' (get) Token: 0x06000008 RID: 8 RVA: 0x00002750 File Offset: 0x00000950
		<HelpKeyword("My.Computer")>
		Friend ReadOnly Property Computer As MyComputer
			<DebuggerHidden()>
			Get
				Return MyProject.m_ComputerObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000002 RID: 2
		' (get) Token: 0x06000009 RID: 9 RVA: 0x0000276C File Offset: 0x0000096C
		<HelpKeyword("My.Application")>
		Friend ReadOnly Property Application As MyApplication
			<DebuggerHidden()>
			Get
				Return MyProject.m_AppObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000003 RID: 3
		' (get) Token: 0x0600000A RID: 10 RVA: 0x00002788 File Offset: 0x00000988
		<HelpKeyword("My.User")>
		Friend ReadOnly Property User As User
			<DebuggerHidden()>
			Get
				Return MyProject.m_UserObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000004 RID: 4
		' (get) Token: 0x0600000B RID: 11 RVA: 0x000027A4 File Offset: 0x000009A4
		<HelpKeyword("My.Forms")>
		Friend ReadOnly Property Forms As MyProject.MyForms
			<DebuggerHidden()>
			Get
				Return MyProject.m_MyFormsObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000005 RID: 5
		' (get) Token: 0x0600000C RID: 12 RVA: 0x000027C0 File Offset: 0x000009C0
		<HelpKeyword("My.WebServices")>
		Friend ReadOnly Property WebServices As MyProject.MyWebServices
			<DebuggerHidden()>
			Get
				Return MyProject.m_MyWebServicesObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x04000002 RID: 2
		Private m_ComputerObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyComputer) = New MyProject.ThreadSafeObjectProvider(Of MyComputer)()

		' Token: 0x04000003 RID: 3
		Private m_AppObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyApplication) = New MyProject.ThreadSafeObjectProvider(Of MyApplication)()

		' Token: 0x04000004 RID: 4
		Private m_UserObjectProvider As MyProject.ThreadSafeObjectProvider(Of User) = New MyProject.ThreadSafeObjectProvider(Of User)()

		' Token: 0x04000005 RID: 5
		Private m_MyFormsObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms) = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms)()

		' Token: 0x04000006 RID: 6
		Private m_MyWebServicesObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices) = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices)()

		' Token: 0x02000005 RID: 5
		<EditorBrowsable(EditorBrowsableState.Never)>
		<MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")>
		Friend NotInheritable Class MyForms
			' Token: 0x17000006 RID: 6
			' (get) Token: 0x0600000D RID: 13 RVA: 0x000027DC File Offset: 0x000009DC
			' (set) Token: 0x06000014 RID: 20 RVA: 0x000028F4 File Offset: 0x00000AF4
			Public Property Form1 As Form1
				<DebuggerNonUserCode()>
				Get
					Me.m_Form1 = MyProject.MyForms.Create__Instance__(Of Form1)(Me.m_Form1)
					Return Me.m_Form1
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form1)
					Dim flag As Boolean = value Is Me.m_Form1
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form1)(Me.m_Form1)
					End If
				End Set
			End Property

			' Token: 0x17000007 RID: 7
			' (get) Token: 0x0600000E RID: 14 RVA: 0x00002804 File Offset: 0x00000A04
			' (set) Token: 0x06000015 RID: 21 RVA: 0x00002938 File Offset: 0x00000B38
			Public Property Form2 As Form2
				<DebuggerNonUserCode()>
				Get
					Me.m_Form2 = MyProject.MyForms.Create__Instance__(Of Form2)(Me.m_Form2)
					Return Me.m_Form2
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form2)
					Dim flag As Boolean = value Is Me.m_Form2
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form2)(Me.m_Form2)
					End If
				End Set
			End Property

			' Token: 0x17000008 RID: 8
			' (get) Token: 0x0600000F RID: 15 RVA: 0x0000282C File Offset: 0x00000A2C
			' (set) Token: 0x06000016 RID: 22 RVA: 0x0000297C File Offset: 0x00000B7C
			Public Property Form3 As Form3
				<DebuggerNonUserCode()>
				Get
					Me.m_Form3 = MyProject.MyForms.Create__Instance__(Of Form3)(Me.m_Form3)
					Return Me.m_Form3
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form3)
					Dim flag As Boolean = value Is Me.m_Form3
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form3)(Me.m_Form3)
					End If
				End Set
			End Property

			' Token: 0x17000009 RID: 9
			' (get) Token: 0x06000010 RID: 16 RVA: 0x00002854 File Offset: 0x00000A54
			' (set) Token: 0x06000017 RID: 23 RVA: 0x000029C0 File Offset: 0x00000BC0
			Public Property Form4 As Form4
				<DebuggerNonUserCode()>
				Get
					Me.m_Form4 = MyProject.MyForms.Create__Instance__(Of Form4)(Me.m_Form4)
					Return Me.m_Form4
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form4)
					Dim flag As Boolean = value Is Me.m_Form4
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form4)(Me.m_Form4)
					End If
				End Set
			End Property

			' Token: 0x1700000A RID: 10
			' (get) Token: 0x06000011 RID: 17 RVA: 0x0000287C File Offset: 0x00000A7C
			' (set) Token: 0x06000018 RID: 24 RVA: 0x00002A04 File Offset: 0x00000C04
			Public Property Form5 As Form5
				<DebuggerNonUserCode()>
				Get
					Me.m_Form5 = MyProject.MyForms.Create__Instance__(Of Form5)(Me.m_Form5)
					Return Me.m_Form5
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form5)
					Dim flag As Boolean = value Is Me.m_Form5
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form5)(Me.m_Form5)
					End If
				End Set
			End Property

			' Token: 0x1700000B RID: 11
			' (get) Token: 0x06000012 RID: 18 RVA: 0x000028A4 File Offset: 0x00000AA4
			' (set) Token: 0x06000019 RID: 25 RVA: 0x00002A48 File Offset: 0x00000C48
			Public Property Form6 As Form6
				<DebuggerNonUserCode()>
				Get
					Me.m_Form6 = MyProject.MyForms.Create__Instance__(Of Form6)(Me.m_Form6)
					Return Me.m_Form6
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form6)
					Dim flag As Boolean = value Is Me.m_Form6
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form6)(Me.m_Form6)
					End If
				End Set
			End Property

			' Token: 0x1700000C RID: 12
			' (get) Token: 0x06000013 RID: 19 RVA: 0x000028CC File Offset: 0x00000ACC
			' (set) Token: 0x0600001A RID: 26 RVA: 0x00002A8C File Offset: 0x00000C8C
			Public Property Form7 As Form7
				<DebuggerNonUserCode()>
				Get
					Me.m_Form7 = MyProject.MyForms.Create__Instance__(Of Form7)(Me.m_Form7)
					Return Me.m_Form7
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form7)
					Dim flag As Boolean = value Is Me.m_Form7
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form7)(Me.m_Form7)
					End If
				End Set
			End Property

			' Token: 0x0600001B RID: 27 RVA: 0x00002AD0 File Offset: 0x00000CD0
			<DebuggerHidden()>
			Private Shared Function Create__Instance__(Of T As{Form, New})(Instance As T) As T
				Dim flag As Boolean = Instance Is Nothing OrElse Instance.IsDisposed
				If flag Then
					Dim flag2 As Boolean = MyProject.MyForms.m_FormBeingCreated IsNot Nothing
					If flag2 Then
						Dim flag3 As Boolean = MyProject.MyForms.m_FormBeingCreated.ContainsKey(GetType(T))
						If flag3 Then
							Throw New InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", New String(-1) {}))
						End If
					Else
						MyProject.MyForms.m_FormBeingCreated = New Hashtable()
					End If
					MyProject.MyForms.m_FormBeingCreated.Add(GetType(T), Nothing)
					Try
						Return Activator.CreateInstance(Of T)()
					Catch ex As TargetInvocationException When ex.InnerException IsNot Nothing
						Dim resourceString As String = Utils.GetResourceString("WinForms_SeeInnerException", New String() { ex.InnerException.Message })
						Throw New InvalidOperationException(resourceString, ex.InnerException)
					Finally
						MyProject.MyForms.m_FormBeingCreated.Remove(GetType(T))
					End Try
				End If
				Return Instance
			End Function

			' Token: 0x0600001C RID: 28 RVA: 0x00002C0C File Offset: 0x00000E0C
			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T As Form)(ByRef instance As T)
				instance.Dispose()
				instance = Nothing
			End Sub

			' Token: 0x0600001D RID: 29 RVA: 0x000020E5 File Offset: 0x000002E5
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub

			' Token: 0x0600001E RID: 30 RVA: 0x00002C38 File Offset: 0x00000E38
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			' Token: 0x0600001F RID: 31 RVA: 0x00002C58 File Offset: 0x00000E58
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x06000020 RID: 32 RVA: 0x00002C70 File Offset: 0x00000E70
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function [GetType]() As Type
				Return GetType(MyProject.MyForms)
			End Function

			' Token: 0x06000021 RID: 33 RVA: 0x00002C8C File Offset: 0x00000E8C
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x04000007 RID: 7
			Public m_Form1 As Form1

			' Token: 0x04000008 RID: 8
			Public m_Form2 As Form2

			' Token: 0x04000009 RID: 9
			Public m_Form3 As Form3

			' Token: 0x0400000A RID: 10
			Public m_Form4 As Form4

			' Token: 0x0400000B RID: 11
			Public m_Form5 As Form5

			' Token: 0x0400000C RID: 12
			Public m_Form6 As Form6

			' Token: 0x0400000D RID: 13
			Public m_Form7 As Form7

			' Token: 0x0400000E RID: 14
			<ThreadStatic()>
			Private Shared m_FormBeingCreated As Hashtable
		End Class

		' Token: 0x02000006 RID: 6
		<MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend NotInheritable Class MyWebServices
			' Token: 0x06000022 RID: 34 RVA: 0x00002C38 File Offset: 0x00000E38
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			' Token: 0x06000023 RID: 35 RVA: 0x00002C58 File Offset: 0x00000E58
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x06000024 RID: 36 RVA: 0x00002CA4 File Offset: 0x00000EA4
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function [GetType]() As Type
				Return GetType(MyProject.MyWebServices)
			End Function

			' Token: 0x06000025 RID: 37 RVA: 0x00002C8C File Offset: 0x00000E8C
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x06000026 RID: 38 RVA: 0x00002CC0 File Offset: 0x00000EC0
			<DebuggerHidden()>
			Private Shared Function Create__Instance__(Of T As New)(instance As T) As T
				Dim flag As Boolean = instance Is Nothing
				Dim result As T
				If flag Then
					result = Activator.CreateInstance(Of T)()
				Else
					result = instance
				End If
				Return result
			End Function

			' Token: 0x06000027 RID: 39 RVA: 0x00002CEC File Offset: 0x00000EEC
			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T)(ByRef instance As T)
				instance = Nothing
			End Sub

			' Token: 0x06000028 RID: 40 RVA: 0x000020E5 File Offset: 0x000002E5
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub
		End Class

		' Token: 0x02000007 RID: 7
		<EditorBrowsable(EditorBrowsableState.Never)>
		<ComVisible(False)>
		Friend NotInheritable Class ThreadSafeObjectProvider(Of T As New)
			' Token: 0x1700000D RID: 13
			' (get) Token: 0x06000029 RID: 41 RVA: 0x00002D0C File Offset: 0x00000F0C
			Friend ReadOnly Property GetInstance As T
				<DebuggerHidden()>
				Get
					Dim flag As Boolean = MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue Is Nothing
					If flag Then
						MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue = Activator.CreateInstance(Of T)()
					End If
					Return MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue
				End Get
			End Property

			' Token: 0x0600002A RID: 42 RVA: 0x000020E5 File Offset: 0x000002E5
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub

			' Token: 0x0400000F RID: 15
			<CompilerGenerated()>
			<ThreadStatic()>
			Private Shared m_ThreadStaticValue As T
		End Class
	End Module
End Namespace
