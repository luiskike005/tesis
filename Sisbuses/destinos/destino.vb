Public Class destino 
    Private Sub destino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargadestino()

    End Sub
   
    Private Sub cmdcargar_Click(sender As Object, e As EventArgs) Handles cmdcargar.Click
        listadestino()
    End Sub

    Private Sub cmdagregar_Click(sender As Object, e As EventArgs) Handles cmdagregar.Click
        nuevodestino()
    End Sub

    Private Sub cmdmodificar_Click(sender As Object, e As EventArgs) Handles cmdmodificar.Click
        editardestino()
    End Sub

    Private Sub gridDestino_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridDestino.CellDoubleClick
        editardestino()
    End Sub

    Private Sub cmdeliminar_Click(sender As Object, e As EventArgs) Handles cmdeliminar.Click
        eliminardestino()
    End Sub

    Private Sub cmdguardar_Click(sender As Object, e As EventArgs)

    End Sub

  

    Private Sub cmdguardar_Click_1(sender As Object, e As EventArgs) Handles cmdguardar.Click
        guardardestino()
    End Sub

    Private Sub cmdcancelar_Click(sender As Object, e As EventArgs) Handles cmdcancelar.Click
        canelardestino()
    End Sub

    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        Close()
    End Sub

    Private Sub cmdimprimir_Click(sender As Object, e As EventArgs) Handles cmdimprimir.Click
        If gridDestino.RowCount > 1 Then
            report = 1
            informe.Show()
        Else
            MsgBox("No hay destinos para mostrar informe", MsgBoxStyle.Information, "Proceso terminado")
        End If
    End Sub

    Private Sub cmdnuevor_Click(sender As Object, e As EventArgs) Handles cmdnuevor.Click
        ruta.ShowDialog()
        RutaTableAdapter.Fill(Dtsisbus.ruta)
    End Sub
End Class