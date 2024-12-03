Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        pik.Visibility = Visibility.Visible
        bul.Visibility = Visibility.Hidden
        charm.Visibility = Visibility.Hidden
        natxt.Text = pibu.Content
        cotxt.Text = "yellow"
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        pik.Visibility = Visibility.Hidden
        bul.Visibility = Visibility.Hidden
        charm.Visibility = Visibility.Visible
        natxt.Text = chbu.Content
        cotxt.Text = "orange"
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        pik.Visibility = Visibility.Hidden
        bul.Visibility = Visibility.Visible
        charm.Visibility = Visibility.Hidden
        natxt.Text = bubu.Content
        cotxt.Text = "green"
    End Sub
End Class
