<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        picRadar = New PictureBox()
        radarTimer = New Timer(components)
        Panel1 = New Panel()
        TableLayoutPanel2 = New TableLayoutPanel()
        GroupBox2 = New GroupBox()
        tkbJammerPower = New TrackBar()
        GroupBox1 = New GroupBox()
        radDeception = New RadioButton()
        radNoise = New RadioButton()
        radNone = New RadioButton()
        TableLayoutPanel1 = New TableLayoutPanel()
        CType(picRadar, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(tkbJammerPower, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' picRadar
        ' 
        picRadar.Dock = DockStyle.Fill
        picRadar.Location = New Point(3, 3)
        picRadar.Name = "picRadar"
        picRadar.Size = New Size(438, 255)
        picRadar.TabIndex = 0
        picRadar.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TableLayoutPanel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(447, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(234, 255)
        Panel1.TabIndex = 1
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(GroupBox2, 0, 1)
        TableLayoutPanel2.Controls.Add(GroupBox1, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(234, 255)
        TableLayoutPanel2.TabIndex = 5
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(tkbJammerPower)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(3, 130)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(228, 122)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "Jammer Power"
        ' 
        ' tkbJammerPower
        ' 
        tkbJammerPower.Dock = DockStyle.Fill
        tkbJammerPower.Location = New Point(3, 19)
        tkbJammerPower.Name = "tkbJammerPower"
        tkbJammerPower.Size = New Size(222, 100)
        tkbJammerPower.TabIndex = 3
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(radDeception)
        GroupBox1.Controls.Add(radNoise)
        GroupBox1.Controls.Add(radNone)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.Location = New Point(3, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(228, 121)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Jammer Mode"
        ' 
        ' radDeception
        ' 
        radDeception.AutoSize = True
        radDeception.Location = New Point(6, 68)
        radDeception.Name = "radDeception"
        radDeception.Size = New Size(209, 19)
        radDeception.TabIndex = 2
        radDeception.TabStop = True
        radDeception.Text = "Deception Jamming (False Targets)"
        radDeception.UseVisualStyleBackColor = True
        ' 
        ' radNoise
        ' 
        radNoise.AutoSize = True
        radNoise.Location = New Point(6, 43)
        radNoise.Name = "radNoise"
        radNoise.Size = New Size(158, 19)
        radNoise.TabIndex = 1
        radNoise.TabStop = True
        radNoise.Text = "Noise Jamming (Barrage)"
        radNoise.UseVisualStyleBackColor = True
        ' 
        ' radNone
        ' 
        radNone.AutoSize = True
        radNone.Location = New Point(6, 18)
        radNone.Name = "radNone"
        radNone.Size = New Size(54, 19)
        radNone.TabIndex = 0
        radNone.TabStop = True
        radNone.Text = "None"
        radNone.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 65F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35F))
        TableLayoutPanel1.Controls.Add(picRadar, 0, 0)
        TableLayoutPanel1.Controls.Add(Panel1, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(684, 261)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(684, 261)
        Controls.Add(TableLayoutPanel1)
        MinimumSize = New Size(700, 300)
        Name = "Form1"
        Text = "Goofy Jammer"
        CType(picRadar, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(tkbJammerPower, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents picRadar As PictureBox
    Friend WithEvents radarTimer As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radDeception As RadioButton
    Friend WithEvents radNoise As RadioButton
    Friend WithEvents radNone As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tkbJammerPower As TrackBar
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel

End Class
