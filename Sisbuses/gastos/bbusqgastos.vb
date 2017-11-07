Module bbusqgastos
    Function cargabusqgastos()
        With busqgastos
            .GastosTableAdapter.Fill(.Dtsisbus.gastos)
            .txtfecha1.DateTime = Date.Now
            .txtfecha2.DateTime = Date.Now
            .gridGastos.Columns.Item(0).Visible = False
        End With
    End Function
    Function cargagrid()
        With busqgastos

            Dim a As Integer
            a = .gridGastos.SelectedRows.Item(0).Index
            id = .gridGastos.Item(0, a).Value
            cargform = 1
            gasto.ShowDialog()
            cargform = 0
            filtrargastos()

        End With
    End Function
    Function filtrargastos()
        With busqgastos
            .GastosTableAdapter.Fill(.Dtsisbus.gastos)
            .GastosBindingSource.RemoveFilter()
            Dim fil As String           
            fil = "fechamonto>='" + .txtfecha1.Text + "' and fechamonto<='" + .txtfecha2.Text + "'"
            filtro = fil
            .GastosBindingSource.Filter = fil
            .gridGastos.Columns.Item(0).Visible = False
        End With
    End Function
End Module
