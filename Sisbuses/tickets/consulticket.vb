Public Class consulticket 

    Private Sub consulticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.ruta' Puede moverla o quitarla según sea necesario.
        Me.RutaTableAdapter.Fill(Me.Dtsisbus.ruta)
        cargarconsulticket()
    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup1.SelectedIndexChanged
        cargarradioruta()

    End Sub

    Private Sub RadioGroup2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup2.SelectedIndexChanged
        cargarradioruta()

    End Sub

    Private Sub cmdimprimir_Click(sender As Object, e As EventArgs) Handles cmdimprimir.Click
        If VistaticketDataGridView.Rows.Count > 0 Then
            report = 4
            informe.Show()
        Else
            MsgBox("No hay datos que mostar", MsgBoxStyle.Critical, "Proceso terminado")
        End If
    End Sub

    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        Close()
    End Sub

    Private Sub cmdticket_Click(sender As Object, e As EventArgs) Handles cmdticket.Click
        cargarradioruta()
        filvistaticket()
    End Sub

    Private Sub VistaticketDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles VistaticketDataGridView.CellDoubleClick
        Dim a As Integer
        a = VistaticketDataGridView.SelectedRows.Item(0).Index
        id = VistaticketDataGridView.Item(0, a).Value


        verticket.ShowDialog()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class