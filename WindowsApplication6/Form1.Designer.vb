Imports System.IO
Imports Microsoft.VisualBasic
Imports System.Windows.Forms
' Token: 0x0200000A RID: 10
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form1
    Inherits Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    ' Token: 0x0600003E RID: 62
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiscROMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ISOFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GraphicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControllerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RUNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog3 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ConfigToolStripMenuItem, Me.AboutToolStripMenuItem, Me.RUNToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(478, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DiscROMToolStripMenuItem, Me.ISOFileToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'DiscROMToolStripMenuItem
        '
        Me.DiscROMToolStripMenuItem.Image = Global.WindowsApplication6.My.Resources.Resources.DiscROMToolStripMenuItem
        Me.DiscROMToolStripMenuItem.Name = "DiscROMToolStripMenuItem"
        Me.DiscROMToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.DiscROMToolStripMenuItem.Text = "Disc ROM"
        '
        'ISOFileToolStripMenuItem
        '
        Me.ISOFileToolStripMenuItem.Image = Global.WindowsApplication6.My.Resources.Resources.ISOFileToolStripMenuItem
        Me.ISOFileToolStripMenuItem.Name = "ISOFileToolStripMenuItem"
        Me.ISOFileToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ISOFileToolStripMenuItem.Text = "ISO File"
        '
        'ConfigToolStripMenuItem
        '
        Me.ConfigToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GraphicToolStripMenuItem, Me.SoundToolStripMenuItem, Me.ControllerToolStripMenuItem, Me.BiosToolStripMenuItem})
        Me.ConfigToolStripMenuItem.Name = "ConfigToolStripMenuItem"
        Me.ConfigToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ConfigToolStripMenuItem.Text = "Config"
        '
        'GraphicToolStripMenuItem
        '
        Me.GraphicToolStripMenuItem.Image = Global.WindowsApplication6.My.Resources.Resources.GraphicToolStripMenuItem
        Me.GraphicToolStripMenuItem.Name = "GraphicToolStripMenuItem"
        Me.GraphicToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.GraphicToolStripMenuItem.Text = "Graphic"
        '
        'SoundToolStripMenuItem
        '
        Me.SoundToolStripMenuItem.Image = Global.WindowsApplication6.My.Resources.Resources.SoundToolStripMenuItem
        Me.SoundToolStripMenuItem.Name = "SoundToolStripMenuItem"
        Me.SoundToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.SoundToolStripMenuItem.Text = "Sound"
        '
        'ControllerToolStripMenuItem
        '
        Me.ControllerToolStripMenuItem.Image = Global.WindowsApplication6.My.Resources.Resources.ControllerToolStripMenuItem
        Me.ControllerToolStripMenuItem.Name = "ControllerToolStripMenuItem"
        Me.ControllerToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ControllerToolStripMenuItem.Text = "Controller"
        '
        'BiosToolStripMenuItem
        '
        Me.BiosToolStripMenuItem.Image = Global.WindowsApplication6.My.Resources.Resources.BiosToolStripMenuItem
        Me.BiosToolStripMenuItem.Name = "BiosToolStripMenuItem"
        Me.BiosToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.BiosToolStripMenuItem.Text = "Bios"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'RUNToolStripMenuItem
        '
        Me.RUNToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartGameToolStripMenuItem})
        Me.RUNToolStripMenuItem.Name = "RUNToolStripMenuItem"
        Me.RUNToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.RUNToolStripMenuItem.Text = "Run"
        '
        'StartGameToolStripMenuItem
        '
        Me.StartGameToolStripMenuItem.Image = Global.WindowsApplication6.My.Resources.Resources.StartGameToolStripMenuItem
        Me.StartGameToolStripMenuItem.Name = "StartGameToolStripMenuItem"
        Me.StartGameToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.StartGameToolStripMenuItem.Text = "Start game"
        '
        'OpenFileDialog3
        '
        Me.OpenFileDialog3.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.WindowsApplication6.My.Resources.Resources.PictureBox1
        Me.PictureBox1.Location = New System.Drawing.Point(-23, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(519, 301)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(478, 290)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "PS4_Emu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DiscROMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ISOFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GraphicToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SoundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControllerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BiosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents OpenFileDialog3 As OpenFileDialog
    Friend WithEvents RUNToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartGameToolStripMenuItem As ToolStripMenuItem
    ' Token: 0x04000014 RID: 20
    Private components As System.ComponentModel.IContainer
End Class