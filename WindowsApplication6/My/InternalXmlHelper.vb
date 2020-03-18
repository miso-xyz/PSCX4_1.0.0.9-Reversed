Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Xml.Linq

Namespace WindowsApplication6.My
	' Token: 0x02000008 RID: 8
	<DebuggerNonUserCode()>
	<EditorBrowsable(EditorBrowsableState.Never)>
	<CompilerGenerated()>
	Friend NotInheritable Class InternalXmlHelper
		' Token: 0x0600002B RID: 43 RVA: 0x000020E5 File Offset: 0x000002E5
		<EditorBrowsable(EditorBrowsableState.Never)>
		Private Sub New()
		End Sub

		' Token: 0x1700000E RID: 14
		' (get) Token: 0x0600002C RID: 44 RVA: 0x00002D40 File Offset: 0x00000F40
		' (set) Token: 0x0600002D RID: 45 RVA: 0x00002DA0 File Offset: 0x00000FA0
		Public Shared Property Value(source As IEnumerable(Of XElement)) As String
			Get
				Try
					Dim enumerator As IEnumerator(Of XElement) = source.GetEnumerator()
					If enumerator.MoveNext() Then
						Dim xelement As XElement = enumerator.Current
						Return xelement.Value
					End If
				Finally
					Dim enumerator As IEnumerator(Of XElement)
					Dim flag As Boolean = enumerator IsNot Nothing
					If flag Then
						enumerator.Dispose()
					End If
				End Try
				Return Nothing
			End Get
			Set(value As String)
				Try
					Dim enumerator As IEnumerator(Of XElement) = source.GetEnumerator()
					If enumerator.MoveNext() Then
						Dim xelement As XElement = enumerator.Current
						xelement.Value = value
					End If
				Finally
					Dim enumerator As IEnumerator(Of XElement)
					Dim flag As Boolean = enumerator IsNot Nothing
					If flag Then
						enumerator.Dispose()
					End If
				End Try
			End Set
		End Property

		' Token: 0x1700000F RID: 15
		' (get) Token: 0x0600002E RID: 46 RVA: 0x00002E00 File Offset: 0x00001000
		' (set) Token: 0x0600002F RID: 47 RVA: 0x00002E68 File Offset: 0x00001068
		Public Shared Property AttributeValue(source As IEnumerable(Of XElement), name As XName) As String
			Get
				Try
					Dim enumerator As IEnumerator(Of XElement) = source.GetEnumerator()
					If enumerator.MoveNext() Then
						Dim xelement As XElement = enumerator.Current
						Return CStr(xelement.Attribute(name))
					End If
				Finally
					Dim enumerator As IEnumerator(Of XElement)
					Dim flag As Boolean = enumerator IsNot Nothing
					If flag Then
						enumerator.Dispose()
					End If
				End Try
				Return Nothing
			End Get
			Set(value As String)
				Try
					Dim enumerator As IEnumerator(Of XElement) = source.GetEnumerator()
					If enumerator.MoveNext() Then
						Dim xelement As XElement = enumerator.Current
						xelement.SetAttributeValue(name, value)
					End If
				Finally
					Dim enumerator As IEnumerator(Of XElement)
					Dim flag As Boolean = enumerator IsNot Nothing
					If flag Then
						enumerator.Dispose()
					End If
				End Try
			End Set
		End Property

		' Token: 0x17000010 RID: 16
		' (get) Token: 0x06000030 RID: 48 RVA: 0x00002EC8 File Offset: 0x000010C8
		' (set) Token: 0x06000031 RID: 49 RVA: 0x000020F0 File Offset: 0x000002F0
		Public Shared Property AttributeValue(source As XElement, name As XName) As String
			Get
				Return CStr(source.Attribute(name))
			End Get
			Set(value As String)
				source.SetAttributeValue(name, value)
			End Set
		End Property

		' Token: 0x06000032 RID: 50 RVA: 0x00002EE8 File Offset: 0x000010E8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Shared Function CreateAttribute(name As XName, value As Object) As XAttribute
			Dim flag As Boolean = value Is Nothing
			Dim result As XAttribute
			If flag Then
				result = Nothing
			Else
				result = New XAttribute(name, RuntimeHelpers.GetObjectValue(value))
			End If
			Return result
		End Function

		' Token: 0x06000033 RID: 51 RVA: 0x00002F14 File Offset: 0x00001114
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Shared Function CreateNamespaceAttribute(name As XName, ns As XNamespace) As XAttribute
			Dim xattribute As XAttribute = New XAttribute(name, ns.NamespaceName)
			xattribute.AddAnnotation(ns)
			Return xattribute
		End Function

		' Token: 0x06000034 RID: 52 RVA: 0x00002F3C File Offset: 0x0000113C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Shared Function RemoveNamespaceAttributes(inScopePrefixes As String(), inScopeNs As XNamespace(), attributes As List(Of XAttribute), obj As Object) As Object
			Dim flag As Boolean = obj IsNot Nothing
			If flag Then
				Dim xelement As XElement = TryCast(obj, XElement)
				flag = (xelement IsNot Nothing)
				If flag Then
					Return InternalXmlHelper.RemoveNamespaceAttributes(inScopePrefixes, inScopeNs, attributes, xelement)
				End If
				Dim enumerable As IEnumerable = TryCast(obj, IEnumerable)
				flag = (enumerable IsNot Nothing)
				If flag Then
					Return InternalXmlHelper.RemoveNamespaceAttributes(inScopePrefixes, inScopeNs, attributes, enumerable)
				End If
			End If
			Return obj
		End Function

		' Token: 0x06000035 RID: 53 RVA: 0x00002F9C File Offset: 0x0000119C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Shared Function RemoveNamespaceAttributes(inScopePrefixes As String(), inScopeNs As XNamespace(), attributes As List(Of XAttribute), obj As IEnumerable) As IEnumerable
			Dim flag As Boolean = obj IsNot Nothing
			Dim result As IEnumerable
			If flag Then
				Dim enumerable As IEnumerable(Of XElement) = TryCast(obj, IEnumerable(Of XElement))
				flag = (enumerable IsNot Nothing)
				If flag Then
					result = enumerable.[Select](AddressOf New InternalXmlHelper.RemoveNamespaceAttributesClosure(inScopePrefixes, inScopeNs, attributes).ProcessXElement)
				Else
					result = obj.Cast().[Select](AddressOf New InternalXmlHelper.RemoveNamespaceAttributesClosure(inScopePrefixes, inScopeNs, attributes).ProcessObject)
				End If
			Else
				result = obj
			End If
			Return result
		End Function

		' Token: 0x06000036 RID: 54 RVA: 0x00003010 File Offset: 0x00001210
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Shared Function RemoveNamespaceAttributes(inScopePrefixes As String(), inScopeNs As XNamespace(), attributes As List(Of XAttribute), e As XElement) As XElement
			Dim flag As Boolean = e IsNot Nothing
			If flag Then
				Dim nextAttribute As XAttribute
				Dim xattribute As XAttribute = e.FirstAttribute
				While xattribute IsNot Nothing
					nextAttribute = xattribute.NextAttribute
					flag = xattribute.IsNamespaceDeclaration
					If flag Then
						Dim xnamespace As XNamespace = xattribute.Annotation(Of XNamespace)()
						Dim localName As String = xattribute.Name.LocalName
						flag = (xnamespace IsNot Nothing)
						If flag Then
							Dim flag2 As Boolean = inScopePrefixes IsNot Nothing AndAlso inScopeNs IsNot Nothing
							If flag2 Then
								Dim num As Integer = inScopePrefixes.Length - 1
								Dim num2 As Integer = 0
								Dim num3 As Integer = num
								Dim num4 As Integer = num2
								Dim right As XNamespace
								While True
									Dim num5 As Integer = num4
									Dim num6 As Integer = num3
									If num5 > num6 Then
										GoTo IL_BF
									End If
									Dim value As String = inScopePrefixes(num4)
									right = inScopeNs(num4)
									flag2 = localName.Equals(value)
									If flag2 Then
										Exit For
									End If
									num4 += 1
								End While
								flag = (xnamespace Is right)
								If flag Then
									xattribute.Remove()
								End If
								xattribute = Nothing
							End If
							IL_BF:
							flag2 = (xattribute IsNot Nothing)
							If flag2 Then
								flag = (attributes IsNot Nothing)
								Dim flag3 As Boolean
								If flag Then
									Dim num7 As Integer = attributes.Count - 1
									Dim num8 As Integer = 0
									Dim num9 As Integer = num7
									Dim num10 As Integer = num8
									Dim xnamespace2 As XNamespace
									While True
										Dim num11 As Integer = num10
										Dim num6 As Integer = num9
										If num11 > num6 Then
											GoTo IL_15C
										End If
										Dim xattribute2 As XAttribute = attributes(num10)
										Dim localName2 As String = xattribute2.Name.LocalName
										xnamespace2 = xattribute2.Annotation(Of XNamespace)()
										flag2 = (xnamespace2 IsNot Nothing)
										If flag2 Then
											flag = localName.Equals(localName2)
											If flag Then
												Exit For
											End If
										End If
										num10 += 1
									End While
									flag3 = (xnamespace Is xnamespace2)
									If flag3 Then
										xattribute.Remove()
									End If
									xattribute = Nothing
								End If
								IL_15C:
								flag3 = (xattribute IsNot Nothing)
								If flag3 Then
									xattribute.Remove()
									attributes.Add(xattribute)
								End If
							End If
						End If
					End If
					xattribute = nextAttribute
				End While
			End If
			Return e
		End Function

		' Token: 0x02000009 RID: 9
		<EditorBrowsable(EditorBrowsableState.Never)>
		<CompilerGenerated()>
		<DebuggerNonUserCode()>
		Private NotInheritable Class RemoveNamespaceAttributesClosure
			' Token: 0x06000037 RID: 55 RVA: 0x000020FD File Offset: 0x000002FD
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Sub New(inScopePrefixes As String(), inScopeNs As XNamespace(), attributes As List(Of XAttribute))
				Me.m_inScopePrefixes = inScopePrefixes
				Me.m_inScopeNs = inScopeNs
				Me.m_attributes = attributes
			End Sub

			' Token: 0x06000038 RID: 56 RVA: 0x000031B4 File Offset: 0x000013B4
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function ProcessXElement(elem As XElement) As XElement
				Return InternalXmlHelper.RemoveNamespaceAttributes(Me.m_inScopePrefixes, Me.m_inScopeNs, Me.m_attributes, elem)
			End Function

			' Token: 0x06000039 RID: 57 RVA: 0x000031E0 File Offset: 0x000013E0
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function ProcessObject(obj As Object) As Object
				Dim xelement As XElement = TryCast(obj, XElement)
				Dim flag As Boolean = xelement IsNot Nothing
				Dim result As Object
				If flag Then
					result = InternalXmlHelper.RemoveNamespaceAttributes(Me.m_inScopePrefixes, Me.m_inScopeNs, Me.m_attributes, xelement)
				Else
					result = obj
				End If
				Return result
			End Function

			' Token: 0x04000010 RID: 16
			Private m_inScopePrefixes As String()

			' Token: 0x04000011 RID: 17
			Private m_inScopeNs As XNamespace()

			' Token: 0x04000012 RID: 18
			Private m_attributes As List(Of XAttribute)
		End Class
	End Class
End Namespace
