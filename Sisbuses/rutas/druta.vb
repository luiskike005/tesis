Module druta
    Function cargaruta()
            Try
                ' conn.Open()
                ' Insert code to process data.
                With ruta
                    .RutaTableAdapter.Fill(.Dtsisbus.ruta)
                    opt = -1

                    If .RutaBindingSource.Count.ToString = 0 Then
                        opt = 0
                        .txtruta.Text = ""
                        .txtabrorigen.Text = ""
                        .txtabrdestino.Text = ""
                    Else
                    id = .RutaTableAdapter.minid()
                    localizarruta()
                    End If
                desabilitarruta()
                End With
            Catch ex As Exception
                MsgBox("Error al intentar acceder a base de datos,compruebe la conexión a la base de datos", MsgBoxStyle.Critical, "Conexion fallida")
                descuento.Close()
            Finally
            End Try

    End Function
    Function nuevoruta()
        With ruta
            opt = 1
            .txtruta.Text = ""
            .txtabrorigen.Text = ""
            .txtabrdestino.Text = ""
            desabilitarruta()
        End With
    End Function
    Function guardarruta()
        With ruta
            .Dxblanco.Validate()

            '----Guardar un nuevo registro--------------------------------------------------------------------------------
            If opt = 1 Then
                If .txtruta.Text = "" Then
                    MsgBox("Ha dejado campos incompletos, porfavor ingrese los datos necesarios", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Campos imcompletos")
                Else
                    Dim resp As Integer
                    resp = MsgBox("Desea registar la ruta", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro de la ruta")
                    If resp = 6 Then
                        Dim idmax As Integer = Val(.RutaTableAdapter.maxid) + 1
                        .RutaTableAdapter.nuevaruta(idmax, .txtruta.Text, "", "", Date.Now)
                        id = idmax
                        MsgBox("Se ha registrado la ruta", MsgBoxStyle.Information, "Registro guardado")
                        opt = 4
                        desabilitarruta()
                        localizarruta()
                    End If
                End If
            End If
            '---------------------------------------------------------------------------------------------------------------
            '----editar un nuevo registro--------------------------------------------------------------------------------
            If opt = 2 Then
                Dim resp As Integer
                resp = MsgBox("Desea actualizar los datos de la ruta", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Actualizar registro")
                If .txtruta.Text = "" Or .txtabrorigen.Text = "" Or .txtabrdestino.Text = "" Then
                    MsgBox("Ha dejado campos incompletos, porfavor ingrese los datos necesarios", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Campos imcompletos")
                Else
                    If resp = 6 Then
                        .RutaTableAdapter.editarruta(.txtruta.Text, "", "", id)
                        MsgBox("Se ha actualizado la información de la ruta", MsgBoxStyle.Information, "Registro actualizado")
                        opt = 4
                        desabilitarruta()
                        localizarruta()
                    End If
                End If
            End If
        End With
    End Function
    Function localizarruta()
        With ruta
            .RutaTableAdapter.Fill(.Dtsisbus.ruta)
            If opt <> 1 Then
                Dim item As Integer = .RutaBindingSource.Find("idruta", id)
                .RutaBindingSource.Position = item
            Else
                .RutaBindingSource.MoveLast()
            End If
            navegacionruta()
        End With
    End Function
    Function navegacionruta()
        With ruta
            id = .Dtsisbus.ruta.Rows(.RutaBindingSource.Position).Item(0).ToString
            .txtruta.Text = .Dtsisbus.ruta.Rows(.RutaBindingSource.Position).Item(1).ToString
            .txtabrorigen.Text = .Dtsisbus.ruta.Rows(.RutaBindingSource.Position).Item(2).ToString
            .txtabrdestino.Text = .Dtsisbus.ruta.Rows(.RutaBindingSource.Position).Item(3).ToString
        End With
    End Function
    Function habilitarruta()
        With ruta
            If opt = 0 Then
                .cmdnuevo.Enabled = True
                .cmdsalir.Enabled = True
                .txtruta.Text = ""
                .txtabrorigen.Text = ""
                .txtabrdestino.Text = ""
            ElseIf opt = 1 Or opt = 2 Then
                .cmdguardar.Enabled = True
                .cmdeliminar.Visible = False
                .cmdcancelar.Enabled = True
                .txtruta.Enabled = True
                .txtabrorigen.Enabled = True
                .txtabrdestino.Enabled = True
            Else
                .cmdpri.Enabled = True
                .cmdatras.Enabled = True
                .cmdsig.Enabled = True
                .cmdult.Enabled = True
                .cmdsalir.Enabled = True
                .cmdnuevo.Enabled = True
                .cmdmodificar.Enabled = True
                .cmdeliminar.Enabled = True
                .cmdeliminar.Visible = True
                .cmdcancelar.Enabled = True
                .cmdsalir.Enabled = True
            End If
        End With
    End Function
    Function desabilitarruta()
        With ruta
            .cmdpri.Enabled = False
            .cmdatras.Enabled = False
            .cmdsig.Enabled = False
            .cmdult.Enabled = False
            .cmdsalir.Enabled = False
            .cmdnuevo.Enabled = False
            .cmdmodificar.Enabled = False
            .cmdeliminar.Enabled = False
            .cmdeliminar.Visible = True
            .cmdguardar.Enabled = False
            .cmdcancelar.Enabled = False
            .cmdsalir.Enabled = False
            .txtruta.Enabled = False
            .txtabrorigen.Enabled = False
            .txtabrdestino.Enabled = False
            habilitarruta()
        End With
    End Function
    Function adelanteruta()
        With ruta
            .RutaBindingSource.MoveNext()
            navegacionruta()
        End With
    End Function
    Function atrasruta()
        With ruta
            .RutaBindingSource.MovePrevious()
            navegacionruta()
        End With
    End Function
    Function primeroruta()
        With ruta
            .RutaBindingSource.MoveFirst()
            navegacionruta()
        End With
    End Function
    Function ultimoruta()
        With ruta
            .RutaBindingSource.MoveLast()
            navegacionruta()
        End With
    End Function
    Function canelarruta()
        With ruta
            opt = 3
            If .RutaBindingSource.Count.ToString = 0 Then
                opt = 0
                .txtruta.Text = ""
                .txtabrorigen.Text = ""
                .txtabrdestino.Text = ""
            Else
                localizarruta()
            End If
            desabilitarruta()
        End With
    End Function
    Function eliminarruta()
        With ruta
            'If .rutaTableAdapter.minid = id Then
            'MsgBox("No se puede eliminar esta ruta, ya se han hecho transacciones con este registro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Proceso terminado")
            ' Else
            Dim resp As Integer
            resp = MsgBox("Desea eliminar la ruta", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar registro ")
            If resp = 6 Then
                .RutaTableAdapter.eliminarruta(id)
                MsgBox("Se ha eliminado la información de la ruta", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Registro eliminado")
                opt = 5
                .RutaTableAdapter.Fill(.Dtsisbus.ruta)
                .RutaBindingSource.MoveFirst()
                If .RutaBindingSource.Count.ToString = 0 Then
                    opt = 0
                    .txtruta.Text = ""
                    .txtabrorigen.Text = ""
                    .txtabrdestino.Text = ""
                Else
                    localizarruta()
                End If
                desabilitarruta()
            End If
            ' End If
        End With
    End Function
    Function editarruta()
        opt = 2
        desabilitarruta()
    End Function
    Function cancelarruta()
        With ruta
            opt = 3
            If .RutaBindingSource.Count.ToString = 0 Then
                opt = 0
                .txtruta.Text = ""
                .txtabrorigen.Text = ""
                .txtabrdestino.Text = ""
            Else
                localizarruta()
            End If
            desabilitarruta()
        End With
    End Function
End Module
