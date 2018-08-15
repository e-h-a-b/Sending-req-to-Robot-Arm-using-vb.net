<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Text2 = New System.Windows.Forms.TextBox()
        Me.Linenum = New System.Windows.Forms.TextBox()
        Me.FileSelect = New System.Windows.Forms.TextBox()
        Me.ComBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(154, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Run Code"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Plexi Bot Controller"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Lines to run"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Current"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "File path"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Select COM Port"
        '
        'Text2
        '
        Me.Text2.Location = New System.Drawing.Point(95, 64)
        Me.Text2.Name = "Text2"
        Me.Text2.Size = New System.Drawing.Size(53, 20)
        Me.Text2.TabIndex = 6
        Me.Text2.Text = "0"
        '
        'Linenum
        '
        Me.Linenum.Location = New System.Drawing.Point(75, 118)
        Me.Linenum.Name = "Linenum"
        Me.Linenum.Size = New System.Drawing.Size(150, 20)
        Me.Linenum.TabIndex = 7
        '
        'FileSelect
        '
        Me.FileSelect.Location = New System.Drawing.Point(75, 155)
        Me.FileSelect.Name = "FileSelect"
        Me.FileSelect.Size = New System.Drawing.Size(150, 20)
        Me.FileSelect.TabIndex = 8
        Me.FileSelect.Text = "C:\rcode.txt"
        '
        'ComBox
        '
        Me.ComBox.Location = New System.Drawing.Point(124, 206)
        Me.ComBox.Name = "ComBox"
        Me.ComBox.Size = New System.Drawing.Size(101, 20)
        Me.ComBox.TabIndex = 9
        Me.ComBox.Text = "COM#"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(277, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 213)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 286)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ComBox)
        Me.Controls.Add(Me.FileSelect)
        Me.Controls.Add(Me.Linenum)
        Me.Controls.Add(Me.Text2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Text2 As System.Windows.Forms.TextBox
    Friend WithEvents Linenum As System.Windows.Forms.TextBox
    Friend WithEvents FileSelect As System.Windows.Forms.TextBox
    Friend WithEvents ComBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
