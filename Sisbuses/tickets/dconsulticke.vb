Module dconsulticke
    Function cargarconsulticket()
        With consulticket
            'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.vistaticket' Puede moverla o quitarla según sea necesario.
            .VistaticketTableAdapter.Fill(.Dtsisbus.vistaticket)
            'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.vistahorario' Puede moverla o quitarla según sea necesario.
            .VistahorarioTableAdapter.Fill(.Dtsisbus.vistahorario)
            .f1.DateTime = Date.Now
            .f2.DateTime = Date.Now
        End With

        cargarradioruta()
    End Function
    Function cargarradioruta()
        With consulticket
            filtro = ""
            If .RadioGroup1.SelectedIndex = 0 Then
                .cboruta.Enabled = False
                filtro += ""
            Else
                .cboruta.Enabled = True
                filtro += "idruta=" + Str(.cboruta.SelectedValue)
            End If
        End With
        cargarradiofecha()
    End Function
    Function cargarradiofecha()
        With consulticket
            If .RadioGroup2.SelectedIndex = 0 Then
                .f1.Enabled = False
                .f2.Enabled = False
                filtro += ""
            Else
                .f1.Enabled = True
                .f2.Enabled = True
                If Trim(filtro) = "" Then
                    filtro += "fecha>='" + .f1.Text + "' and fecha<='" + .f2.Text + "'"
                Else
                    filtro += "AND fecha>='" + .f1.Text + "' and fecha<='" + .f2.Text + "'"
                End If

            End If
        End With

    End Function
    Function filvistaticket()
        With consulticket
            .VistaticketBindingSource.RemoveFilter()
            .VistaticketBindingSource.Filter = filtro
        End With
    End Function
End Module
