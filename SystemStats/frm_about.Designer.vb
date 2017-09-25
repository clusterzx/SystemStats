<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_about
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.EarnTheme1 = New SystemStats.EarnTheme()
        Me.btn_minimize = New System.Windows.Forms.Button()
        Me.EarnGroupBox1 = New SystemStats.EarnGroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.EarnTheme1.SuspendLayout()
        Me.EarnGroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EarnTheme1
        '
        Me.EarnTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.EarnTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.EarnTheme1.Controls.Add(Me.btn_minimize)
        Me.EarnTheme1.Controls.Add(Me.EarnGroupBox1)
        Me.EarnTheme1.Customization = "WU1L//////8="
        Me.EarnTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EarnTheme1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.EarnTheme1.Image = Nothing
        Me.EarnTheme1.Location = New System.Drawing.Point(0, 0)
        Me.EarnTheme1.Movable = True
        Me.EarnTheme1.Name = "EarnTheme1"
        Me.EarnTheme1.NoRounding = False
        Me.EarnTheme1.Sizable = True
        Me.EarnTheme1.Size = New System.Drawing.Size(284, 249)
        Me.EarnTheme1.SmartBounds = True
        Me.EarnTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.EarnTheme1.TabIndex = 0
        Me.EarnTheme1.Text = "EarnTheme1"
        Me.EarnTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.EarnTheme1.Transparent = False
        '
        'btn_minimize
        '
        Me.btn_minimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_minimize.Location = New System.Drawing.Point(255, 5)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(20, 22)
        Me.btn_minimize.TabIndex = 2
        Me.btn_minimize.Text = "X"
        Me.btn_minimize.UseVisualStyleBackColor = False
        '
        'EarnGroupBox1
        '
        Me.EarnGroupBox1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.EarnGroupBox1.Controls.Add(Me.LinkLabel1)
        Me.EarnGroupBox1.Controls.Add(Me.PictureBox1)
        Me.EarnGroupBox1.Customization = "WU1L/1lNS/9ZTUv//////w=="
        Me.EarnGroupBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.EarnGroupBox1.Image = Nothing
        Me.EarnGroupBox1.Location = New System.Drawing.Point(11, 40)
        Me.EarnGroupBox1.Movable = True
        Me.EarnGroupBox1.Name = "EarnGroupBox1"
        Me.EarnGroupBox1.NoRounding = False
        Me.EarnGroupBox1.Sizable = True
        Me.EarnGroupBox1.Size = New System.Drawing.Size(260, 196)
        Me.EarnGroupBox1.SmartBounds = True
        Me.EarnGroupBox1.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.EarnGroupBox1.TabIndex = 0
        Me.EarnGroupBox1.Text = "Coded by : Dennis Becher"
        Me.EarnGroupBox1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.EarnGroupBox1.Transparent = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(74, 176)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(109, 13)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://bech0r.net"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SystemStats.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(45, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(176, 114)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frm_about
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 249)
        Me.Controls.Add(Me.EarnTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_about"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.EarnTheme1.ResumeLayout(False)
        Me.EarnGroupBox1.ResumeLayout(False)
        Me.EarnGroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EarnTheme1 As EarnTheme
    Friend WithEvents EarnGroupBox1 As EarnGroupBox
    Friend WithEvents btn_minimize As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
