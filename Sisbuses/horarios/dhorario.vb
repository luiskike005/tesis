Module dhorario
    Function cargahorario()
        Try
            ' conn.Open()
            ' Insert code to process data.
            With horario
                'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.conductor' Puede moverla o quitarla según sea necesario.
                .ConductorTableAdapter.Fill(.Dtsisbus.conductor)
                'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.bus' Puede moverla o quitarla según sea necesario.
                .BusTableAdapter.Fill(.Dtsisbus.bus)
                'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.ruta' Puede moverla o quitarla según sea necesario.
                .RutaTableAdapter.Fill(.Dtsisbus.ruta)
                'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.horario' Puede moverla o quitarla según sea necesario.
                .HorarioTableAdapter.Fill(.Dtsisbus.horario)
                'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.vistahorario' Puede moverla o quitarla según sea necesario.
                .VistahorarioTableAdapter.Fill(.Dtsisbus.vistahorario)
                opt = 0
                ' .DestinoBindingSource.Filter = "idruta=1"
                .gridDestino.Columns.Item(0).Visible = False
                desabilitarhorario()
               
            End With
        Catch ex As Exception
            MsgBox("Error al intentar acceder a base de datos,compruebe la conexión a la base de datos", MsgBoxStyle.Critical, "Conexion fallida")
            descuento.Close()
        Finally
        End Try
    End Function
    Function listahorario()
        With horario
            opt = -1
            If .RutaBindingSource.Count.ToString = 0 Then
                opt = 0
            Else
                opt = 4
                If cargaidruta = 0 Then
                    idruta = .cboruta.SelectedValue
                Else
                    .cboruta.Text = rutan
                End If
                cargaidruta = 0
                .VistahorarioBindingSource.RemoveFilter()
                .VistahorarioTableAdapter.Fill(.Dtsisbus.vistahorario)
                .VistahorarioBindingSource.Filter = "idruta=" + Str(idruta)
                filtro = "idruta=" + Str(idruta)
            End If
            desabilitarhorario()
        End With
    End Function
    Function nuevohorario()
        With horario
            opt = 1
            guardarhorario()
        End With
    End Function
    Function guardarhorario()
        With horario
            '.Dxblanco.Validate()
           
            '----Guardar un nuevo registro--------------------------------------------------------------------------------
            If opt = 1 Then
               
                If .cbobus.Text = "" Or .cboconductor.Text = "" Or .txthora.Text = "" And .cboht.Text <> "" Then
                    MsgBox("Ha dejado campos incompletos, porfavor ingrese los datos necesarios", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Campos imcompletos")
                Else
                    idbus = .cbobus.SelectedValue
                    idconductor = .cboconductor.SelectedValue
                    Dim resp As Integer
                    resp = MsgBox("Desea registar el Horario", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro del horario")
                    If resp = 6 Then
                        Dim idmax As Integer = Val(.HorarioTableAdapter.idmax) + 1
                        ' Dim times As TimeSpan = .txthora.EditValue
                        .HorarioTableAdapter.nuevohorario(idmax, idruta, idbus, idconductor, .txthora.Text, .cboht.Text)
                        id = idmax
                        MsgBox("Se ha registrado el horario", MsgBoxStyle.Information, "Registro guardado")
                        opt = 4
                        .HorarioTableAdapter.Fill(.Dtsisbus.horario)
                        listahorario()
                        desabilitarhorario()
                    End If
                End If
            End If
            '---------------------------------------------------------------------------------------------------------------
            '----editar un nuevo registro--------------------------------------------------------------------------------
            If opt = 2 Then
                Dim resp As Integer
                resp = MsgBox("Desea actualizar los datos ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Actualizar registro")
                If .cbobbus.Text = "" Or .cbobconductor.Text = "" Or .txthorasalida1.Text = "" And .cboap.Text <> "" Then
                    MsgBox("Ha dejado campos incompletos, porfavor ingrese los datos necesarios", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Campos imcompletos")
                Else
                    idbus = .cbobus.SelectedValue
                    idconductor = .cbobconductor.SelectedValue
                    If resp = 6 Then
                        .HorarioTableAdapter.editarhorario(idbus, idconductor, .txthorasalida1.Text, .cboap.Text, id, idruta)
                        MsgBox("Se ha actualizado la información ", MsgBoxStyle.Information, "Registro actualizado")

                        opt = 4
                        .HorarioTableAdapter.Fill(.Dtsisbus.horario)
                        .grupodestino.Visible = False
                        desabilitarhorario()
                        listahorario()
                    End If
                End If
            End If
        End With
    End Function
    Function habilitarHorario()
        With horario
            If opt = 0 Then
                .VistahorarioBindingSource.Filter = "idhorario=0"
                .cmdsalir.Enabled = True
                .cbobus.Text = ""
                .cboconductor.Text = ""
                .txthora.Text = ""
                .cbobus.Enabled = False
                .cboconductor.Enabled = False
                .txthora.Enabled = False
                .cmdagregar.Enabled = False
                .cmdimprimir.Enabled = False
                .cmdmodificar.Enabled = False
                .cmdeliminar.Enabled = False
                .cmdsalir.Enabled = True
            Else
                .cbobus.Text = ""
                .cboconductor.Text = ""
                .txthora.Text = ""
                .cboht.Enabled = True
                .cbobus.Enabled = True
                .cboconductor.Enabled = True
                .txthora.Enabled = True
                .cmdagregar.Enabled = True
                .cmdimprimir.Enabled = True
                .cmdmodificar.Enabled = True
                .cmdeliminar.Enabled = True
                .cmdsalir.Enabled = True
            End If
        End With
    End Function
    Function desabilitarhorario()
        With horario
            .cmdimprimir.Enabled = False
            .cmdsalir.Enabled = False
            .cmdmodificar.Enabled = False
            .cmdeliminar.Enabled = False
            .cmdeliminar.Visible = True
            .cmdguardar.Enabled = False
            .cmdcancelar.Enabled = False
            .cmdsalir.Enabled = False
            .cbobus.Enabled = False
            .cboconductor.Enabled = False
            .txthora.Enabled = False
            .cboht.Enabled = False
            habilitarHorario()
        End With
    End Function
    Function canelarhorario()
        With horario
            opt = 3
            If .RutaBindingSource.Count.ToString = 0 Then
                opt = 0
                .cbobbus.Text = ""
                .cbobconductor.Text = ""
                .txthorasalida1.Text = ""
            End If
            listahorario()
            .grupodestino.Visible = False
        End With
    End Function
    Function eliminarhorario()
        With horario
            'If .rutaTableAdapter.minid = id Then
            'MsgBox("No se puede eliminar esta ruta, ya se han hecho transacciones con este registro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Proceso terminado")
            ' Else
            If .gridDestino.RowCount > 0 Then
                Dim resp As Integer

                resp = MsgBox("Desea eliminar el destino", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar registro ")
                If resp = 6 Then
                    Dim a As Integer
                    a = .gridDestino.SelectedRows.Item(0).Index
                    id = .gridDestino.Item(0, a).Value
                    .HorarioTableAdapter.eliminarlineahorario(id, idruta)
                    MsgBox("Se ha eliminado la información ", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Registro eliminado")
                    opt = 5
                    .HorarioTableAdapter.Fill(.Dtsisbus.horario)
                    listahorario()
                End If
            Else
                listahorario()
                MsgBox("No hay datos para eliminar", MsgBoxStyle.Critical, "Proceso terminado")
            End If
        End With
    End Function
    Function editarhorario()
        opt = 2

        With horario
            If .gridDestino.RowCount > 0 Then
                Dim a As Integer
                a = .gridDestino.SelectedRows.Item(0).Index
                id = .gridDestino.Item(0, a).Value
                .grupodestino.Visible = True
                .cbobbus.Text = .gridDestino.Item(4, a).Value
                .cbobconductor.Text = .gridDestino.Item(6, a).Value
                .txthorasalida1.EditValue = .gridDestino.Item(7, a).Value.ToString
                .cboap.Text = .gridDestino.Item(8, a).Value.ToString
                .cmdguardar.Enabled = True
                .cmdcancelar.Enabled = True
            Else
                MsgBox("No hay datos para editar", MsgBoxStyle.Critical, "Proceso terminado")
                listahorario()
            End If
        End With
    End Function
End Module
