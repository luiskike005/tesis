Public Class regusuario 

    Private Sub regusuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.usuarios' Puede moverla o quitarla según sea necesario.
        cargarusuario()
    End Sub

    Private Sub cmdguardar_Click(sender As Object, e As EventArgs) Handles cmdguardar.Click
        guardarusuario()
    End Sub

    Private Sub cmdnuevo_Click(sender As Object, e As EventArgs) Handles cmdnuevo.Click
        nuevousuario()
    End Sub

    Private Sub cmdpri_Click(sender As Object, e As EventArgs) Handles cmdpri.Click
        primerousuario()
    End Sub

    Private Sub cmdatras_Click(sender As Object, e As EventArgs) Handles cmdatras.Click
        atrasusuario()
    End Sub

    Private Sub cmdsig_Click(sender As Object, e As EventArgs) Handles cmdsig.Click
        adelanteusuario()
    End Sub

    Private Sub cmdult_Click(sender As Object, e As EventArgs) Handles cmdult.Click
        ultimousuario()
    End Sub

    Private Sub cmdeliminar_Click(sender As Object, e As EventArgs) Handles cmdeliminar.Click
        eliminarusuario()
    End Sub

    Private Sub cmdmodificar_Click(sender As Object, e As EventArgs) Handles cmdmodificar.Click
        editarusuario()
    End Sub

    Private Sub cmdcancelar_Click(sender As Object, e As EventArgs) Handles cmdcancelar.Click
        cancelarusuario()
    End Sub

    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        Close()
    End Sub

    Private Sub image_Click(sender As Object, e As EventArgs) Handles image.Click
        fotousuario()
    End Sub
End Class