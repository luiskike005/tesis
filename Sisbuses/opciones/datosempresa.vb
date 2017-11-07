Public Class datosempresa 

    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        Close()
    End Sub

    Private Sub datosempresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.opciones' Puede moverla o quitarla según sea necesario.
        cargaopciones()

    End Sub

    Private Sub logo_Click(sender As Object, e As EventArgs) Handles logo.Click
        imagenlogo()
    End Sub

    Private Sub cmdeditar_Click(sender As Object, e As EventArgs) Handles cmdeditar.Click
        editaropciones()
    End Sub

    Private Sub cmdguardar_Click(sender As Object, e As EventArgs) Handles cmdguardar.Click
        guardaropciones()
    End Sub

    Private Sub cmdcancelar_Click(sender As Object, e As EventArgs) Handles cmdcancelar.Click
        cargaopciones()
    End Sub
End Class