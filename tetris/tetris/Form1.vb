Public Class Form1
    Dim movements As New Dictionary(Of String, Collection)
    Dim tracks As New Dictionary(Of String, Integer)

    Dim s As Integer
    Dim m As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        follow(Enemy2, Avatar, 2, 2)
        PaceY(Enemy1wall, Platform, 15)
        PaceY(Enemy4wall, Platform2, 2)
        PaceY(enemy5wall, platform3, 12)
        PaceX(enemy6wall, Platform4, 7)
        PaceY(enemy7wall, Platform5, 12)
    End Sub
    Sub PaceX(e As PictureBox, p As PictureBox, speed As Integer)
        Dim dir As Integer
        dir = e.Tag

        move(e, dir * speed, 0)

        If e.Location.X > p.Location.X + p.Width / 2 Then
            e.Tag = dir * -1
        End If
        If e.Location.X < p.Location.X Then
            e.Tag = dir * -1
        End If
    End Sub

    Sub PaceY(e As PictureBox, p As PictureBox, speed As Integer)
        Dim dir As Integer
        dir = e.Tag

        move(e, 0, dir * speed)

        If e.Location.Y < p.Location.Y Then
            e.Tag = dir * -1
        End If
        If e.Location.Y > p.Location.Y + p.Height / 2 Then
            e.Tag = dir * -1
        End If
    End Sub

    Sub follow(e As PictureBox, a As PictureBox, xspeed As Integer, yspeed As Integer)
        If e.Location.Y < a.Location.Y Then
            move(e, 0, yspeed)
        Else
            move(e, 0, -yspeed)
        End If
        If e.Location.X < a.Location.X Then
            move(e, xspeed, 0)
        Else
            move(e, -xspeed, 0)
        End If
    End Sub
    Sub Track(e As PictureBox, a As PictureBox)
        If Not tracks.ContainsKey(e.Name & a.Name) Then
            tracks.Add(e.Name & a.Name, 1)
        Else
            Dim idx As Integer
            idx = tracks(e.Name & a.Name)
            If movements.ContainsKey(a.Name) AndAlso idx < movements(a.Name).Count Then
                e.Location = movements(a.Name).Item(idx)
                tracks(e.Name & a.Name) = idx + 1
            End If

        End If
    End Sub


    Dim rng As New Random
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown, restartbutton.KeyDown
        If e.KeyCode = Keys.Right Or e.KeyCode = Keys.D Then
            move(Avatar, 10, 0)
        End If
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.A Then
            move(Avatar, -10, 0)
        End If
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.S Then
            move(Avatar, 0, 10)
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.W Then
            move(Avatar, 0, -10)
        End If
        If e.KeyCode = Keys.Space Then
            Avatar.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        End If
        Avatar.Refresh()

        If Avatar.Bounds.IntersectsWith(star.Bounds) Then
            star.Location = New Point(rng.Next(0, Size.Width - 75), rng.Next(0, Size.Height - 75))
        End If
    End Sub
    Sub move(p As PictureBox, xdir As Integer, ydir As Integer)
        p.Location += New Point(xdir, ydir)

        If IntersectsWith(Avatar, "wall") Then
            p.Location -= New Point(xdir, ydir)
        End If

        If Not movements.ContainsKey(p.Name) Then
            movements.Add(p.Name, New Collection)
        End If
        movements(p.Name).Add(p.Location)

        If IntersectsWith(Avatar, "mula") Then
            m += 100
            moneylabel.Text = m
            MovePictureBoxToRandomLocation()
        End If
        If IntersectsWith(Avatar, "bad") Then

            overlabel.Visible = True
            restartbutton.Visible = True
        End If
    End Sub
    Function endingWith(s As String) As Collection
        Dim coll As New Collection
        For Each o In Controls
            Dim obj As PictureBox
            obj = TryCast(o, PictureBox)
            If Not obj Is Nothing Then
                If UCase(obj.Name).EndsWith(UCase(s)) Then
                    coll.Add(obj)
                End If
            End If
        Next
        Return coll
    End Function

    Function IntersectsWith(p As PictureBox, tag As String) As Boolean
        For Each o In Controls
            Dim obj As PictureBox
            obj = TryCast(o, PictureBox)
            If Not obj Is Nothing AndAlso obj.Name <> p.Name Then
                If p.Bounds.IntersectsWith(obj.Bounds) And (UCase(obj.Tag) = UCase(tag) Or
                    UCase(obj.Name).EndsWith(UCase(tag))) Then
                    Return True
                End If
            End If
        Next
        Return False
    End Function


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        s += 1
        scorelabel.Text = s
    End Sub

    Private Sub MovePictureBoxToRandomLocation()

        Dim rng As New Random
        star.Location = New Point(rng.Next(0, Me.Size.Width - 75), rng.Next(0, Me.Size.Height - 75))

    End Sub
    Dim loc As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles restartbutton.Click
        overlabel.Visible = False
        moneylabel.Text = "points"
        scorelabel.Text = "time"
        restartbutton.Visible = False
        Enemy2.Location = New Point
    End Sub
End Class