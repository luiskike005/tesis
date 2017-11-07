Public Class horario

    Private Sub horario_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If cargaidruta = 1 Then
            listahorario()
        End If
    End Sub
    Private Sub horario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargahorario()
    End Sub
    Private Sub destino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargahorario()

    End Sub

    Private Sub cmdcargar_Click(sender As Object, e As EventArgs) Handles cmdcargar.Click

        listahorario()
    End Sub

    Private Sub cmdagregar_Click(sender As Object, e As EventArgs) Handles cmdagregar.Click
        nuevohorario()
    End Sub

    Private Sub cmdmodificar_Click(sender As Object, e As EventArgs) Handles cmdmodificar.Click
        editarhorario()
    End Sub



    Private Sub cmdeliminar_Click(sender As Object, e As EventArgs) Handles cmdeliminar.Click
        eliminarhorario()
    End Sub

    Private Sub cmdguardar_Click(sender As Object, e As EventArgs) Handles cmdguardar.Click
        guardarhorario()
    End Sub

    Private Sub cmdcancelar_Click(sender As Object, e As EventArgs) Handles cmdcancelar.Click
        canelarhorario()
    End Sub



    Private Sub gridDestino_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles gridDestino.CellDoubleClick
        editarhorario()
    End Sub

    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        Close()
    End Sub


    Private Sub cmdimprimir_Click(sender As Object, e As EventArgs) Handles cmdimprimir.Click
        report = 3
        informe.Show()
    End Sub
End Class