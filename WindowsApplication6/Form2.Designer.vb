Imports System.ComponentModel

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Combobox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Combobox2 = New System.Windows.Forms.ComboBox()
        Me.Combobox3 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Checkbox1 = New System.Windows.Forms.CheckBox()
        Me.Checkbox2 = New System.Windows.Forms.CheckBox()
        Me.Checkbox3 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Checkbox4 = New System.Windows.Forms.CheckBox()
        Me.Checkbox5 = New System.Windows.Forms.CheckBox()
        Me.Combobox4 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Resolution"
        '
        'Combobox1
        '
        Me.Combobox1.FormattingEnabled = True
        Me.Combobox1.Items.AddRange(New Object() {"640x480", "800x600", "1024x768", "1280x720", "1366x768", "1600x900", "1920x1080", "2048x1080"})
        Me.Combobox1.Location = New System.Drawing.Point(99, 32)
        Me.Combobox1.Name = "Combobox1"
        Me.Combobox1.Size = New System.Drawing.Size(121, 21)
        Me.Combobox1.TabIndex = 4
        Me.Combobox1.Text = "Select"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Renderer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Aspect ratio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Texture filtering"
        '
        'Combobox2
        '
        Me.Combobox2.FormattingEnabled = True
        Me.Combobox2.Items.AddRange(New Object() {"DirectX 9", "DirectX 10", "Direct3D11"})
        Me.Combobox2.Location = New System.Drawing.Point(99, 82)
        Me.Combobox2.Name = "Combobox2"
        Me.Combobox2.Size = New System.Drawing.Size(121, 21)
        Me.Combobox2.TabIndex = 8
        Me.Combobox2.Text = "Select"
        '
        'Combobox3
        '
        Me.Combobox3.FormattingEnabled = True
        Me.Combobox3.Items.AddRange(New Object() {"4:3", "16:9"})
        Me.Combobox3.Location = New System.Drawing.Point(99, 129)
        Me.Combobox3.Name = "Combobox3"
        Me.Combobox3.Size = New System.Drawing.Size(121, 21)
        Me.Combobox3.TabIndex = 9
        Me.Combobox3.Text = "Select"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Vsync"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Shadows"
        '
        'Checkbox1
        '
        Me.Checkbox1.AutoSize = True
        Me.Checkbox1.Location = New System.Drawing.Point(99, 166)
        Me.Checkbox1.Name = "Checkbox1"
        Me.Checkbox1.Size = New System.Drawing.Size(15, 14)
        Me.Checkbox1.TabIndex = 12
        Me.Checkbox1.UseVisualStyleBackColor = True
        '
        'Checkbox2
        '
        Me.Checkbox2.AutoSize = True
        Me.Checkbox2.Location = New System.Drawing.Point(99, 216)
        Me.Checkbox2.Name = "Checkbox2"
        Me.Checkbox2.Size = New System.Drawing.Size(15, 14)
        Me.Checkbox2.TabIndex = 13
        Me.Checkbox2.UseVisualStyleBackColor = True
        '
        'Checkbox3
        '
        Me.Checkbox3.AutoSize = True
        Me.Checkbox3.Location = New System.Drawing.Point(99, 193)
        Me.Checkbox3.Name = "Checkbox3"
        Me.Checkbox3.Size = New System.Drawing.Size(15, 14)
        Me.Checkbox3.TabIndex = 14
        Me.Checkbox3.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.Location = New System.Drawing.Point(137, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Shadows"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.Location = New System.Drawing.Point(137, 193)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Texture Resolution"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.Location = New System.Drawing.Point(137, 216)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Distortion"
        '
        'Checkbox4
        '
        Me.Checkbox4.AutoSize = True
        Me.Checkbox4.Location = New System.Drawing.Point(205, 166)
        Me.Checkbox4.Name = "Checkbox4"
        Me.Checkbox4.Size = New System.Drawing.Size(15, 14)
        Me.Checkbox4.TabIndex = 18
        Me.Checkbox4.UseVisualStyleBackColor = True
        '
        'Checkbox5
        '
        Me.Checkbox5.AutoSize = True
        Me.Checkbox5.Location = New System.Drawing.Point(205, 216)
        Me.Checkbox5.Name = "Checkbox5"
        Me.Checkbox5.Size = New System.Drawing.Size(15, 14)
        Me.Checkbox5.TabIndex = 19
        Me.Checkbox5.UseVisualStyleBackColor = True
        '
        'Combobox4
        '
        Me.Combobox4.FormattingEnabled = True
        Me.Combobox4.Items.AddRange(New Object() {"Low", "Normal", "High", "Very High", "Ultra"})
        Me.Combobox4.Location = New System.Drawing.Point(229, 190)
        Me.Combobox4.Name = "Combobox4"
        Me.Combobox4.Size = New System.Drawing.Size(61, 21)
        Me.Combobox4.TabIndex = 20
        Me.Combobox4.Text = "Select"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(229, 211)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = Me.Size
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Combobox4)
        Me.Controls.Add(Me.Checkbox5)
        Me.Controls.Add(Me.Checkbox4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Checkbox3)
        Me.Controls.Add(Me.Checkbox2)
        Me.Controls.Add(Me.Checkbox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Combobox3)
        Me.Controls.Add(Me.Combobox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Combobox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Graphic"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Combobox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Combobox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Combobox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Combobox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Checkbox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Checkbox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Checkbox3 As System.Windows.Forms.CheckBox
    Friend WithEvents Checkbox4 As System.Windows.Forms.CheckBox
    Friend WithEvents Checkbox5 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
