Module dconhorario
    Function cargaconsultahora()
        With consultahorario
            .RutaTableAdapter.Fill(.Dtsisbus.ruta)
            'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.vistahorario' Puede moverla o quitarla según sea necesario.
            .VistahorarioTableAdapter.Fill(.Dtsisbus.vistahorario)

            listahorario1()
            .gridvista.Columns.Item(1).Visible = False
        End With
    End Function
    Function listahorario1()
        With consultahorario
            .gridvista.Columns.Item(0).Visible = False
            opt = -1
            If .RutaBindingSource.Count.ToString = 0 Then
                opt = 0
            Else
                opt = 4
                idruta = .cboruta.SelectedValue
                .VistahorarioBindingSource.RemoveFilter()
                .VistahorarioTableAdapter.Fill(.Dtsisbus.vistahorario)
                .VistahorarioBindingSource.Filter = "idruta=" + Str(idruta)
                filtro = "idruta=" + Str(idruta)
            End If
        End With
    End Function
End Module
