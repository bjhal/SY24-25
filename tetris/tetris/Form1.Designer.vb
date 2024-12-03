<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Avatar = New PictureBox()
        Timer1 = New Timer(components)
        star = New PictureBox()
        Enemy2 = New PictureBox()
        Enemy1wall = New PictureBox()
        Platform = New PictureBox()
        platform3 = New PictureBox()
        Platform2 = New PictureBox()
        Enemy4wall = New PictureBox()
        enemy5wall = New PictureBox()
        PictureBox1 = New PictureBox()
        Platform4 = New PictureBox()
        enemy6wall = New PictureBox()
        Platform5 = New PictureBox()
        enemy7wall = New PictureBox()
        scorelabel = New Label()
        Timer2 = New Timer(components)
        moneylabel = New Label()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        PictureBox9 = New PictureBox()
        PictureBox10 = New PictureBox()
        PictureBox11 = New PictureBox()
        Timer3 = New Timer(components)
        overlabel = New Label()
        restartbutton = New Button()
        CType(Avatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(star, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy1wall, ComponentModel.ISupportInitialize).BeginInit()
        CType(Platform, ComponentModel.ISupportInitialize).BeginInit()
        CType(platform3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Platform2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy4wall, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy5wall, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Platform4, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy6wall, ComponentModel.ISupportInitialize).BeginInit()
        CType(Platform5, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy7wall, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Avatar
        ' 
        Avatar.Image = CType(resources.GetObject("Avatar.Image"), Image)
        Avatar.Location = New Point(207, 147)
        Avatar.Name = "Avatar"
        Avatar.Size = New Size(94, 91)
        Avatar.SizeMode = PictureBoxSizeMode.Zoom
        Avatar.TabIndex = 0
        Avatar.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' star
        ' 
        star.BackColor = Color.Tan
        star.Image = CType(resources.GetObject("star.Image"), Image)
        star.Location = New Point(733, 2)
        star.Name = "star"
        star.Size = New Size(68, 71)
        star.SizeMode = PictureBoxSizeMode.Zoom
        star.TabIndex = 1
        star.TabStop = False
        star.Tag = "mula"
        ' 
        ' Enemy2
        ' 
        Enemy2.Image = CType(resources.GetObject("Enemy2.Image"), Image)
        Enemy2.Location = New Point(9, 190)
        Enemy2.Name = "Enemy2"
        Enemy2.Size = New Size(94, 91)
        Enemy2.SizeMode = PictureBoxSizeMode.Zoom
        Enemy2.TabIndex = 3
        Enemy2.TabStop = False
        Enemy2.Tag = "bad"
        ' 
        ' Enemy1wall
        ' 
        Enemy1wall.Image = CType(resources.GetObject("Enemy1wall.Image"), Image)
        Enemy1wall.Location = New Point(157, 2)
        Enemy1wall.Name = "Enemy1wall"
        Enemy1wall.Size = New Size(26, 80)
        Enemy1wall.SizeMode = PictureBoxSizeMode.Zoom
        Enemy1wall.TabIndex = 5
        Enemy1wall.TabStop = False
        Enemy1wall.Tag = "-1"
        ' 
        ' Platform
        ' 
        Platform.Location = New Point(189, 2)
        Platform.Name = "Platform"
        Platform.Size = New Size(12, 771)
        Platform.SizeMode = PictureBoxSizeMode.Zoom
        Platform.TabIndex = 6
        Platform.TabStop = False
        ' 
        ' platform3
        ' 
        platform3.Location = New Point(399, -28)
        platform3.Name = "platform3"
        platform3.Size = New Size(12, 771)
        platform3.SizeMode = PictureBoxSizeMode.Zoom
        platform3.TabIndex = 7
        platform3.TabStop = False
        ' 
        ' Platform2
        ' 
        Platform2.Location = New Point(349, -28)
        Platform2.Name = "Platform2"
        Platform2.Size = New Size(12, 771)
        Platform2.SizeMode = PictureBoxSizeMode.Zoom
        Platform2.TabIndex = 8
        Platform2.TabStop = False
        ' 
        ' Enemy4wall
        ' 
        Enemy4wall.Image = CType(resources.GetObject("Enemy4wall.Image"), Image)
        Enemy4wall.Location = New Point(334, 220)
        Enemy4wall.Name = "Enemy4wall"
        Enemy4wall.Size = New Size(26, 236)
        Enemy4wall.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy4wall.TabIndex = 9
        Enemy4wall.TabStop = False
        Enemy4wall.Tag = "2"
        ' 
        ' enemy5wall
        ' 
        enemy5wall.Image = CType(resources.GetObject("enemy5wall.Image"), Image)
        enemy5wall.Location = New Point(385, 2)
        enemy5wall.Name = "enemy5wall"
        enemy5wall.Size = New Size(26, 236)
        enemy5wall.SizeMode = PictureBoxSizeMode.StretchImage
        enemy5wall.TabIndex = 10
        enemy5wall.TabStop = False
        enemy5wall.Tag = "1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(401, -160)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(12, 771)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Platform4
        ' 
        Platform4.Location = New Point(433, 2)
        Platform4.Name = "Platform4"
        Platform4.Size = New Size(234, 10)
        Platform4.SizeMode = PictureBoxSizeMode.Zoom
        Platform4.TabIndex = 15
        Platform4.TabStop = False
        ' 
        ' enemy6wall
        ' 
        enemy6wall.Image = CType(resources.GetObject("enemy6wall.Image"), Image)
        enemy6wall.Location = New Point(479, 18)
        enemy6wall.Name = "enemy6wall"
        enemy6wall.Size = New Size(10, 226)
        enemy6wall.SizeMode = PictureBoxSizeMode.StretchImage
        enemy6wall.TabIndex = 16
        enemy6wall.TabStop = False
        enemy6wall.Tag = "1"
        ' 
        ' Platform5
        ' 
        Platform5.Location = New Point(675, 2)
        Platform5.Name = "Platform5"
        Platform5.Size = New Size(10, 454)
        Platform5.SizeMode = PictureBoxSizeMode.Zoom
        Platform5.TabIndex = 17
        Platform5.TabStop = False
        ' 
        ' enemy7wall
        ' 
        enemy7wall.Image = CType(resources.GetObject("enemy7wall.Image"), Image)
        enemy7wall.Location = New Point(661, 2)
        enemy7wall.Name = "enemy7wall"
        enemy7wall.Size = New Size(26, 326)
        enemy7wall.SizeMode = PictureBoxSizeMode.StretchImage
        enemy7wall.TabIndex = 18
        enemy7wall.TabStop = False
        enemy7wall.Tag = "2"
        ' 
        ' scorelabel
        ' 
        scorelabel.AutoSize = True
        scorelabel.Location = New Point(12, 10)
        scorelabel.Name = "scorelabel"
        scorelabel.Size = New Size(42, 20)
        scorelabel.TabIndex = 19
        scorelabel.Text = "Time"
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        Timer2.Interval = 1000
        ' 
        ' moneylabel
        ' 
        moneylabel.AutoSize = True
        moneylabel.Location = New Point(12, 44)
        moneylabel.Name = "moneylabel"
        moneylabel.Size = New Size(48, 20)
        moneylabel.TabIndex = 20
        moneylabel.Text = "Points"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.SaddleBrown
        PictureBox2.Location = New Point(-2, 435)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(153, 62)
        PictureBox2.TabIndex = 22
        PictureBox2.TabStop = False
        PictureBox2.Tag = "wall"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.SaddleBrown
        PictureBox3.Location = New Point(-62, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(77, 436)
        PictureBox3.TabIndex = 23
        PictureBox3.TabStop = False
        PictureBox3.Tag = "wall"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.SaddleBrown
        PictureBox4.Location = New Point(807, 2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(77, 436)
        PictureBox4.TabIndex = 24
        PictureBox4.TabStop = False
        PictureBox4.Tag = "wall"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.SaddleBrown
        PictureBox5.Location = New Point(189, 435)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(139, 62)
        PictureBox5.TabIndex = 25
        PictureBox5.TabStop = False
        PictureBox5.Tag = "wall"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.SaddleBrown
        PictureBox6.Location = New Point(418, 435)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(235, 62)
        PictureBox6.TabIndex = 26
        PictureBox6.TabStop = False
        PictureBox6.Tag = "wall"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.SaddleBrown
        PictureBox7.Location = New Point(691, 435)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(235, 62)
        PictureBox7.TabIndex = 27
        PictureBox7.TabStop = False
        PictureBox7.Tag = "wall"
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = Color.SaddleBrown
        PictureBox8.Location = New Point(189, -50)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(139, 62)
        PictureBox8.TabIndex = 28
        PictureBox8.TabStop = False
        PictureBox8.Tag = "wall"
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackColor = Color.SaddleBrown
        PictureBox9.Location = New Point(-34, -50)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(185, 62)
        PictureBox9.TabIndex = 29
        PictureBox9.TabStop = False
        PictureBox9.Tag = "wall"
        ' 
        ' PictureBox10
        ' 
        PictureBox10.BackColor = Color.SaddleBrown
        PictureBox10.Location = New Point(418, -50)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(237, 62)
        PictureBox10.TabIndex = 30
        PictureBox10.TabStop = False
        PictureBox10.Tag = "wall"
        ' 
        ' PictureBox11
        ' 
        PictureBox11.BackColor = Color.SaddleBrown
        PictureBox11.Location = New Point(689, -50)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(237, 62)
        PictureBox11.TabIndex = 31
        PictureBox11.TabStop = False
        PictureBox11.Tag = "wall"
        ' 
        ' Timer3
        ' 
        Timer3.Interval = 3000
        ' 
        ' overlabel
        ' 
        overlabel.BackColor = Color.Red
        overlabel.Font = New Font("Showcard Gothic", 72F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        overlabel.Location = New Point(-12, -8)
        overlabel.Name = "overlabel"
        overlabel.Size = New Size(844, 464)
        overlabel.TabIndex = 32
        overlabel.Text = "                             GAME OVER"
        overlabel.Visible = False
        ' 
        ' restartbutton
        ' 
        restartbutton.BackColor = Color.Lime
        restartbutton.Font = New Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        restartbutton.Location = New Point(675, 357)
        restartbutton.Name = "restartbutton"
        restartbutton.Size = New Size(126, 81)
        restartbutton.TabIndex = 33
        restartbutton.Text = "Restart"
        restartbutton.UseVisualStyleBackColor = False
        restartbutton.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Tan
        ClientSize = New Size(813, 450)
        Controls.Add(restartbutton)
        Controls.Add(scorelabel)
        Controls.Add(moneylabel)
        Controls.Add(overlabel)
        Controls.Add(PictureBox11)
        Controls.Add(PictureBox10)
        Controls.Add(PictureBox9)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(enemy7wall)
        Controls.Add(enemy6wall)
        Controls.Add(enemy5wall)
        Controls.Add(Enemy4wall)
        Controls.Add(Enemy1wall)
        Controls.Add(Enemy2)
        Controls.Add(star)
        Controls.Add(Avatar)
        Controls.Add(Platform)
        Controls.Add(platform3)
        Controls.Add(Platform4)
        Controls.Add(Platform5)
        Controls.Add(Platform2)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(Avatar, ComponentModel.ISupportInitialize).EndInit()
        CType(star, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy2, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy1wall, ComponentModel.ISupportInitialize).EndInit()
        CType(Platform, ComponentModel.ISupportInitialize).EndInit()
        CType(platform3, ComponentModel.ISupportInitialize).EndInit()
        CType(Platform2, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy4wall, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy5wall, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(Platform4, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy6wall, ComponentModel.ISupportInitialize).EndInit()
        CType(Platform5, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy7wall, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Avatar As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents star As PictureBox
    Friend WithEvents Enemy2 As PictureBox
    Friend WithEvents Enemy1wall As PictureBox
    Friend WithEvents Platform As PictureBox
    Friend WithEvents platform3 As PictureBox
    Friend WithEvents Platform2 As PictureBox
    Friend WithEvents Enemy4wall As PictureBox
    Friend WithEvents enemy5wall As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Platform4 As PictureBox
    Friend WithEvents enemy6wall As PictureBox
    Friend WithEvents Platform5 As PictureBox
    Friend WithEvents enemy7wall As PictureBox
    Friend WithEvents score As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents scorelabel As Label
    Friend WithEvents moneylabel As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents Timer3 As Timer
    Friend WithEvents overlabel As Label
    Friend WithEvents restartbutton As Button

End Class
