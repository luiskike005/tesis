Public Class consultahorario 

    Private Sub consultahorario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.ruta' Puede moverla o quitarla según sea necesario.
        cargaconsultahora()

    End Sub

    Private Sub gridvista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridvista.CellDoubleClick

        'ticket.showdialog
    End Sub

    Private Sub cboruta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboruta.SelectedIndexChanged
        listahorario1()
    End Sub

    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        Close()
    End Sub

    Private Sub cmdimprimir_Click(sender As Object, e As EventArgs) Handles cmdimprimir.Click
        report = 3
        informe.Show()
    End Sub

    Private Sub cmdticket_Click(sender As Object, e As EventArgs) Handles cmdticket.Click
        Dim a As Integer
        a = gridvista.SelectedRows.Item(0).Index
        idruta = gridvista.Item(1, a).Value
        descruta = gridvista.Item(2, a).Value
        idbus = gridvista.Item(3, a).Value
        hora = gridvista.Item(7, a).Value.ToString + " " + gridvista.Item(8, a).Value
        ticket.ShowDialog()
    End Sub

   

  
   
    Private Sub cmdmodificar_Click(sender As Object, e As EventArgs) Handles cmdmodificar.Click
        If cboruta.Text <> "" Then
            Dim idru As Integer
            idru = idruta
            rutan = cboruta.Text
            cargaidruta = 1
            horario.ShowDialog()
            idruta = idru
            listahorario1()
        End If
    End Sub
End Class