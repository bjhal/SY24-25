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
        enemy = New PictureBox()
        Enemy2 = New PictureBox()
        Enemy3 = New PictureBox()
        CType(Avatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(star, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Avatar
        ' 
        Avatar.Image = CType(resources.GetObject("Avatar.Image"), Image)
        Avatar.Location = New Point(12, 12)
        Avatar.Name = "Avatar"
        Avatar.Size = New Size(133, 127)
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
        star.BackColor = SystemColors.Control
        star.Image = My.Resources.Resources.Mario_Star_PNG
        star.Location = New Point(691, 331)
        star.Name = "star"
        star.Size = New Size(99, 93)
        star.SizeMode = PictureBoxSizeMode.Zoom
        star.TabIndex = 1
        star.TabStop = False
        ' 
        ' enemy
        ' 
        enemy.Image = My.Resources.Resources.the_super_mario_bros_movie___piranha_plant_png_by_lolthd_dfujppw_fullview
        enemy.Location = New Point(579, 62)
        enemy.Name = "enemy"
        enemy.Size = New Size(83, 95)
        enemy.SizeMode = PictureBoxSizeMode.Zoom
        enemy.TabIndex = 2
        enemy.TabStop = False
        ' 
        ' Enemy2
        ' 
        Enemy2.Image = CType(resources.GetObject("Enemy2.Image"), Image)
        Enemy2.Location = New Point(229, 244)
        Enemy2.Name = "Enemy2"
        Enemy2.Size = New Size(65, 62)
        Enemy2.SizeMode = PictureBoxSizeMode.Zoom
        Enemy2.TabIndex = 3
        Enemy2.TabStop = False
        ' 
        ' Enemy3
        ' 
        Enemy3.Image = CType(resources.GetObject("Enemy3.Image"), Image)
        Enemy3.Location = New Point(517, 286)
        Enemy3.Name = "Enemy3"
        Enemy3.Size = New Size(65, 62)
        Enemy3.SizeMode = PictureBoxSizeMode.Zoom
        Enemy3.TabIndex = 4
        Enemy3.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(813, 450)
        Controls.Add(Enemy3)
        Controls.Add(Enemy2)
        Controls.Add(enemy)
        Controls.Add(star)
        Controls.Add(Avatar)
        Name = "Form1"
        Text = "Form1"
        CType(Avatar, ComponentModel.ISupportInitialize).EndInit()
        CType(star, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy2, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Avatar As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents star As PictureBox
    Friend WithEvents enemy As PictureBox
    Friend WithEvents Enemy2 As PictureBox
    Friend WithEvents Enemy3 As PictureBox

End Class
