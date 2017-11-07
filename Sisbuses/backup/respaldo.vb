Public Class respaldo 

    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        Close()
    End Sub

    Private Sub cmddireccion1_Click(sender As Object, e As EventArgs) Handles cmddireccion1.Click
        FolderBrowserDialog1.ShowDialog()
        txtdireccion1.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub cmddireccion2_Click(sender As Object, e As EventArgs) Handles cmddireccion2.Click
        'FolderBrowserDialog1.ShowDialog()
        ' txtdireccion2.Text = FolderBrowserDialog1.SelectedPath
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Todos(*.bak)|*.bak"
        OpenFileDialog1.ShowDialog()
        txtdireccion2.Text = OpenFileDialog1.FileName.ToString
    End Sub

    Private Sub cmdrespaldo_Click(sender As Object, e As EventArgs) Handles cmdrespaldo.Click
        respaldod()
    End Sub

    Private Sub cmdcarga_Click(sender As Object, e As EventArgs) Handles cmdcarga.Click
        carga()
    End Sub
End Class