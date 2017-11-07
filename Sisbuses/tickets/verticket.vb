Public Class verticket 

    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        Close()
    End Sub

  
    Private Sub verticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.vistaticket' Puede moverla o quitarla según sea necesario.
        Me.VistaticketTableAdapter.Fill(Me.Dtsisbus.vistaticket)
        Me.VistaticketBindingSource.RemoveFilter()
        Me.VistaticketBindingSource.Filter = "idticket=" + Str(id)
    End Sub

    Private Sub cmdimprimir_Click(sender As Object, e As EventArgs) Handles cmdimprimir.Click
        report = 5
        filtro = "idticket=" + Str(id)
        informe.Show()
    End Sub
End Class