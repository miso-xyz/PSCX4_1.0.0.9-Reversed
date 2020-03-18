Imports System
Imports System.CodeDom.Compiler
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.ApplicationServices

Namespace WindowsApplication6.My
	' Token: 0x02000002 RID: 2
	<GeneratedCode("MyTemplate", "10.0.0.0")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Friend Class MyApplication
		Inherits WindowsFormsApplicationBase

		' Token: 0x06000002 RID: 2 RVA: 0x00002604 File Offset: 0x00000804
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = MyApplication.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = MyApplication.__ENCList.Count = MyApplication.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = MyApplication.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = MyApplication.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								MyApplication.__ENCList(num) = MyApplication.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					MyApplication.__ENCList.RemoveRange(num, MyApplication.__ENCList.Count - num)
					MyApplication.__ENCList.Capacity = MyApplication.__ENCList.Count
				End If
				MyApplication.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		' Token: 0x06000003 RID: 3 RVA: 0x00002714 File Offset: 0x00000914
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		<STAThread()>
		<DebuggerHidden()>
		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Friend Shared Sub Main(Args As String())
			Try
				Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering)
			Finally
			End Try
			MyProject.Application.Run(Args)
		End Sub

		' Token: 0x06000004 RID: 4 RVA: 0x0000205D File Offset: 0x0000025D
		<DebuggerStepThrough()>
		Public Sub New()
			MyBase.New(AuthenticationMode.Windows)
			MyApplication.__ENCAddToList(Me)
			Me.IsSingleInstance = False
			Me.EnableVisualStyles = True
			Me.SaveMySettingsOnExit = True
			Me.ShutdownStyle = ShutdownMode.AfterMainFormCloses
		End Sub

		' Token: 0x06000005 RID: 5 RVA: 0x00002090 File Offset: 0x00000290
		<DebuggerStepThrough()>
		Protected Overrides Sub OnCreateMainForm()
			Me.MainForm = MyProject.Forms.Form1
		End Sub

		' Token: 0x04000001 RID: 1
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()
	End Class
End Namespace
