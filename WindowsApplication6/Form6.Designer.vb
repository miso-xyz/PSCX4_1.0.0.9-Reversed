
' Token: 0x0200000F RID: 15
Imports Microsoft.VisualBasic
Imports System.Windows.Forms
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form6
    Inherits System.Windows.Forms.Form

    ' Token: 0x06000100 RID: 256 RVA: 0x000071BC File Offset: 0x000053BC
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            Dim flag As Boolean = disposing AndAlso Me.components IsNot Nothing
            If flag Then
                Me.components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    ' Token: 0x06000101 RID: 257 RVA: 0x0000720C File Offset: 0x0000540C
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(260, 237)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = "This application is fake, it uses Windows Media Player to load video files" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Deblo" & _
            "ated & Cracked by misonothx" & Global.Microsoft.VisualBasic.ChrW(10) & "sinister.ly <3"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form6"
        Me.Text = "About "
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RichTextBox1 As RichTextBox
    ' Token: 0x0400006C RID: 108
    Private components As System.ComponentModel.IContainer
End Class
