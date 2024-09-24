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
        Enemy3 = New PictureBox()
        Enemy1 = New PictureBox()
        Platform = New PictureBox()
        CType(Avatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(star, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Platform, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Avatar
        ' 
        Avatar.Image = CType(resources.GetObject("Avatar.Image"), Image)
        Avatar.Location = New Point(45, 59)
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
        star.BackColor = SystemColors.Control
        star.Image = My.Resources.Resources.Mario_Star_PNG
        star.Location = New Point(691, 331)
        star.Name = "star"
        star.Size = New Size(99, 93)
        star.SizeMode = PictureBoxSizeMode.Zoom
        star.TabIndex = 1
        star.TabStop = False
        ' 
        ' Enemy2
        ' 
        Enemy2.Image = CType(resources.GetObject("Enemy2.Image"), Image)
        Enemy2.Location = New Point(487, 158)
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
        ' Enemy1
        ' 
        Enemy1.Image = CType(resources.GetObject("Enemy1.Image"), Image)
        Enemy1.Location = New Point(340, 297)
        Enemy1.Name = "Enemy1"
        Enemy1.Size = New Size(65, 62)
        Enemy1.SizeMode = PictureBoxSizeMode.Zoom
        Enemy1.TabIndex = 5
        Enemy1.TabStop = False
        Enemy1.Tag = "-1"
        ' 
        ' Platform
        ' 
        Platform.Image = CType(resources.GetObject("Platform.Image"), Image)
        Platform.Location = New Point(316, 353)
        Platform.Name = "Platform"
        Platform.Size = New Size(123, 85)
        Platform.SizeMode = PictureBoxSizeMode.Zoom
        Platform.TabIndex = 6
        Platform.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(813, 450)
        Controls.Add(Platform)
        Controls.Add(Enemy1)
        Controls.Add(Enemy3)
        Controls.Add(Enemy2)
        Controls.Add(star)
        Controls.Add(Avatar)
        Name = "Form1"
        Text = "Form1"
        CType(Avatar, ComponentModel.ISupportInitialize).EndInit()
        CType(star, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy2, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy3, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy1, ComponentModel.ISupportInitialize).EndInit()
        CType(Platform, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Avatar As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents star As PictureBox
    Friend WithEvents Enemy2 As PictureBox
    Friend WithEvents Enemy3 As PictureBox
    Friend WithEvents Enemy1 As PictureBox
    Friend WithEvents Platform As PictureBox

End Class
