Module ddestino
    Function cargadestino()
        Try
            ' conn.Open()
            ' Insert code to process data.
            With destino
                'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.destino' Puede moverla o quitarla según sea necesario.
                .DestinoTableAdapter.Fill(.Dtsisbus.destino)
                'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.ruta' Puede moverla o quitarla según sea necesario.
                .RutaTableAdapter.Fill(.Dtsisbus.ruta)
                opt = 0
                ' .DestinoBindingSource.Filter = "idruta=1"
                desabilitardestino()
            End With
        Catch ex As Exception
            MsgBox("Error al intentar acceder a base de datos,compruebe la conexión a la base de datos", MsgBoxStyle.Critical, "Conexion fallida")
            descuento.Close()
        Finally
        End Try
    End Function
    Function listadestino()
        With destino
            opt = -1
            If .RutaBindingSource.Count.ToString = 0 Then
                opt = 0               
            Else
                opt = 4
                idruta = .cboruta.SelectedValue
                .DestinoBindingSource.RemoveFilter()
                filtro = "idruta=" + Str(idruta)
                .DestinoBindingSource.Filter = "idruta=" + Str(idruta)
            End If
            desabilitardestino()
            End With 
    End Function
    Function nuevodestino()
        With ruta
            opt = 1
            guardardestino()
        End With
    End Function
    Function guardardestino()
        With destino


            '----Guardar un nuevo registro--------------------------------------------------------------------------------
            If opt = 1 Then
                If .txtdestino.Text = "" Or .txtprecio.Text <= 0 Then
                    MsgBox("Ha dejado campos incompletos, porfavor ingrese los datos necesarios", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Campos imcompletos")
                Else
                    .Dxblanco.Validate()
                    Dim resp As Integer
                    resp = MsgBox("Desea registar el destino", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro del destino")
                    If resp = 6 Then
                        Dim idmax As Integer = Val(.DestinoTableAdapter.maxid) + 1
                        .DestinoTableAdapter.nuevodestino(idmax, .txtdestino.Text, "", .txtprecio.Text, Date.Now, idruta)
                        id = idmax
                        MsgBox("Se ha registrado la el destino", MsgBoxStyle.Information, "Registro guardado")
                        opt = 4
                        .DestinoTableAdapter.Fill(.Dtsisbus.destino)
                        listadestino()
                        desabilitarruta()
                    End If
                End If
            End If
            '---------------------------------------------------------------------------------------------------------------
            '----editar un nuevo registro--------------------------------------------------------------------------------
            If opt = 2 Then
                Dim resp As Integer
                resp = MsgBox("Desea actualizar los datos ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Actualizar registro")
                If .txtd.Text = "" Or .txtp.Text <= 0 Then
                    MsgBox("Ha dejado campos incompletos, porfavor ingrese los datos necesarios", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Campos imcompletos")
                Else
                    If resp = 6 Then
                        .DestinoTableAdapter.editardestino(.txtd.Text, "", .txtp.Text, id, idruta)
                        MsgBox("Se ha actualizado la información ", MsgBoxStyle.Information, "Registro actualizado")

                        opt = 4
                        .DestinoTableAdapter.Fill(.Dtsisbus.destino)
                        .grupodestino.Visible = False
                        desabilitarruta()
                        listadestino()
                    End If
                End If
            End If
        End With
    End Function
    Function habilitardestino()
        With destino
            If opt = 0 Then
                .DestinoBindingSource.Filter = "iddestino=0"               
                .cmdsalir.Enabled = True
                .txtdestino.Text = ""
                .txtabrdestino.Text = ""
                .txtprecio.Text = 0.0
                .txtdestino.Enabled = False
                .txtabrdestino.Enabled = False
                .txtprecio.Enabled = False
                .cmdagregar.Enabled = False
                .cmdimprimir.Enabled = False
                .cmdmodificar.Enabled = False
                .cmdeliminar.Enabled = False
                .cmdsalir.Enabled = True
            Else
                .txtdestino.Text = ""
                .txtabrdestino.Text = ""
                .txtprecio.Text = 0.0
                .txtdestino.Enabled = True
                .txtabrdestino.Enabled = True
                .txtprecio.Enabled = True
                .cmdagregar.Enabled = True
                .cmdimprimir.Enabled = True
                .cmdmodificar.Enabled = True
                .cmdeliminar.Enabled = True
                .cmdsalir.Enabled = True
            End If
        End With
    End Function
    Function desabilitardestino()
        With destino           

            .cmdimprimir.Enabled = False
            .cmdsalir.Enabled = False
            .cmdmodificar.Enabled = False
            .cmdeliminar.Enabled = False
            .cmdeliminar.Visible = True
            .cmdguardar.Enabled = False
            .cmdcancelar.Enabled = False
            .cmdsalir.Enabled = False
            .txtdestino.Enabled = False
            .txtabrdestino.Enabled = False
            .txtprecio.Enabled = False
            habilitardestino()
        End With
    End Function   
    Function canelardestino()
        With destino
            opt = 3
            If .RutaBindingSource.Count.ToString = 0 Then
                opt = 0
                .txtd.Text = ""
                .txta.Text = ""
                .txtp.Text = 0.0
            End If
            listadestino()
            .grupodestino.Visible = False
        End With
    End Function
    Function eliminardestino()
        With destino
          
                If .gridDestino.RowCount > 0 Then
                    Dim resp As Integer

                    resp = MsgBox("Desea eliminar el destino", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar registro ")
                    If resp = 6 Then
                        Dim a As Integer
                        a = .gridDestino.SelectedRows.Item(0).Index
                        id = .gridDestino.Item(0, a).Value
                    If .DestinoTableAdapter.elivaldestino(id) >= 0 Then
                        MsgBox("No se puede eliminar este destino, ya se han hecho transacciones con este registro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Proceso terminado")
                    Else
                        .DestinoTableAdapter.eliminarruta(id, idruta)
                        MsgBox("Se ha eliminado la información ", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Registro eliminado")
                        opt = 5
                    End If
                    .DestinoTableAdapter.Fill(.Dtsisbus.destino)
                    listadestino()
                End If
                Else
                    listadestino()
                    MsgBox("No hay datos para eliminar", MsgBoxStyle.Critical, "Proceso terminado")
                End If

        End With
    End Function
    Function editardestino()
        opt = 2      
        With destino
            If .gridDestino.RowCount > 0 Then
                Dim a As Integer
                a = .gridDestino.SelectedRows.Item(0).Index
                id = .gridDestino.Item(0, a).Value
                .grupodestino.Visible = True
                .txtd.Text = .gridDestino.Item(1, a).Value
                '.txta.Text = .gridDestino.Item(2, a).Value
                .txtp.Text = .gridDestino.Item(3, a).Value
                .cmdguardar.Enabled = True
                .cmdcancelar.Enabled = True
            Else
                MsgBox("No hay datos para editar", MsgBoxStyle.Critical, "Proceso terminado")
                listadestino()
            End If
        End With
    End Function
End Module
