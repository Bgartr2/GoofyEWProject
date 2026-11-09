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
        radNone = New RadioButton()
        radNoise = New RadioButton()
        radDeception = New RadioButton()
        GroupBox1 = New GroupBox()
        tkbJammerPower = New TrackBar()
        GroupBox2 = New GroupBox()
        CType(picRadar, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(tkbJammerPower, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' picRadar
        ' 
        picRadar.Location = New Point(137, 90)
        picRadar.Name = "picRadar"
        picRadar.Size = New Size(331, 268)
        picRadar.TabIndex = 0
        picRadar.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(GroupBox2)
        Panel1.Controls.Add(GroupBox1)
        Panel1.Location = New Point(514, 90)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(274, 268)
        Panel1.TabIndex = 1
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
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(radDeception)
        GroupBox1.Controls.Add(radNoise)
        GroupBox1.Controls.Add(radNone)
        GroupBox1.Location = New Point(3, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(268, 100)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Jammer Mode"
        ' 
        ' tkbJammerPower
        ' 
        tkbJammerPower.Location = New Point(6, 17)
        tkbJammerPower.Name = "tkbJammerPower"
        tkbJammerPower.Size = New Size(256, 45)
        tkbJammerPower.TabIndex = 3
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(tkbJammerPower)
        GroupBox2.Location = New Point(3, 109)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(268, 68)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "Jammer Power"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(picRadar)
        Name = "Form1"
        Text = "Form1"
        CType(picRadar, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(tkbJammerPower, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
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

End Class
