Public Class busqgastos 


    Private Sub busqgastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.gastos' Puede moverla o quitarla según sea necesario.
        cargabusqgastos()

    End Sub

    Private Sub cmdregistrar_Click(sender As Object, e As EventArgs) Handles cmdregistrar.Click
        gasto.ShowDialog()
        filtrargastos()
    End Sub

    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        GastosBindingSource.RemoveFilter()
        Close()
    End Sub

    Private Sub cmdfiltrar_Click(sender As Object, e As EventArgs) Handles cmdfiltrar.Click
        filtrargastos()
    End Sub

    Private Sub gridGastos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridGastos.CellDoubleClick
        cargagrid()
    End Sub

    Private Sub cmdimprimir_Click(sender As Object, e As EventArgs) Handles cmdimprimir.Click
        report = 2
        informe.Show()
    End Sub

   
End Class