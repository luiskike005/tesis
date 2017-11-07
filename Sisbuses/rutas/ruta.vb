Public Class ruta 
    Private Sub ruta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.ruta' Puede moverla o quitarla según sea necesario.
        cargaruta()
    End Sub
    Private Sub cmdguardar_Click(sender As Object, e As EventArgs) Handles cmdguardar.Click
        guardarruta()
    End Sub
    Private Sub cmdnuevo_Click(sender As Object, e As EventArgs) Handles cmdnuevo.Click
        nuevoruta()
    End Sub
    Private Sub cmdpri_Click(sender As Object, e As EventArgs) Handles cmdpri.Click
        primeroruta()
    End Sub
    Private Sub cmdatras_Click(sender As Object, e As EventArgs) Handles cmdatras.Click
        atrasruta()
    End Sub
    Private Sub cmdsig_Click(sender As Object, e As EventArgs) Handles cmdsig.Click
        adelanteruta()
    End Sub
    Private Sub cmdult_Click(sender As Object, e As EventArgs) Handles cmdult.Click
        ultimoruta()
    End Sub
    Private Sub cmdeliminar_Click(sender As Object, e As EventArgs) Handles cmdeliminar.Click
        eliminarruta()
    End Sub
    Private Sub cmdmodificar_Click(sender As Object, e As EventArgs) Handles cmdmodificar.Click
        editarruta()
    End Sub
    Private Sub cmdcancelar_Click(sender As Object, e As EventArgs) Handles cmdcancelar.Click
        cancelarruta()
    End Sub
    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        Close()
    End Sub
End Class