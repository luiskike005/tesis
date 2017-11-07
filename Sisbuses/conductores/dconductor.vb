Module dconductor
    Function cargarconductor()
        Try
            ' conn.Open()
            ' Insert code to process data.
            With conductor
                .conductorTableAdapter.Fill(.Dtsisbus.conductor)
                opt = -1

                If .ConductorBindingSource.Count.ToString = 0 Then
                    opt = 0
                    .txtconductor.Text = ""
                    .txtidentidad.Text = ""
                    .txttel.Text = ""
                    .Txtfecha.Text = ""
                    .txtactivo.IsOn = True
                Else
                    id = .ConductorTableAdapter.minid()
                    localizarconductor()
                End If
                desabilitarconductor()
            End With
        Catch ex As Exception
            MsgBox("Error al intentar acceder a base de datos,compruebe la conexión a la base de datos", MsgBoxStyle.Critical, "Conexion fallida")
            conductor.Close()
        Finally
        End Try

    End Function
    Function nuevoconductor()
        With conductor
            opt = 1
            .txtconductor.Text = ""
            .txtidentidad.Text = ""
            .txttel.Text = ""
            .Txtfecha.Text = ""
            desabilitarconductor()
        End With
    End Function
    Function guardarconductor()
        With conductor
            .Dxblanco.Validate()

            '----Guardar un nuevo registro--------------------------------------------------------------------------------
            If opt = 1 Then
                If .txtconductor.Text = "" Or .txtidentidad.Text = "" Then
                    MsgBox("Ha dejado campos incompletos, porfavor ingrese los datos necesarios", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Campos imcompletos")
                Else
                    Dim resp As Integer
                    resp = MsgBox("Desea registar del conductor", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro del conductor")
                    If resp = 6 Then
                        Dim idmax As Integer = Val(.ConductorTableAdapter.idmax) + 1
                        .ConductorTableAdapter.nuevoconductor(idmax, .txtconductor.Text, .txtidentidad.Text, .txttel.Text, .Txtfecha.Text, .txtactivo.EditValue)
                        id = idmax
                        MsgBox("Se ha registrado el conductor", MsgBoxStyle.Information, "Registro guardado")
                        opt = 4
                        desabilitarconductor()
                        localizarconductor()
                    End If
                End If
            End If
            '---------------------------------------------------------------------------------------------------------------
            '----editar un nuevo registro--------------------------------------------------------------------------------
            If opt = 2 Then
                Dim resp As Integer
                resp = MsgBox("Desea actualizar los datos del conductor", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Actualizar registro")
                If .txtconductor.Text = "" Or .txtidentidad.Text = "" Then
                    MsgBox("Ha dejado campos incompletos, porfavor ingrese los datos necesarios", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Campos imcompletos")
                Else
                    If resp = 6 Then
                        .ConductorTableAdapter.editarconductor(id, .txtconductor.Text, .txtidentidad.Text, .txttel.Text, .Txtfecha.Text, .txtactivo.EditValue, id)
                        MsgBox("Se ha actualizado la información del conductor", MsgBoxStyle.Information, "Registro actualizado")
                        opt = 4
                        desabilitarconductor()
                        localizarconductor()
                    End If
                End If
            End If
        End With
    End Function
    Function localizarconductor()
        With conductor
            .ConductorTableAdapter.Fill(.Dtsisbus.conductor)
            If opt <> 1 Then
                Dim item As Integer = .ConductorBindingSource.Find("idconductor", id)
                .ConductorBindingSource.Position = item
            Else
                .ConductorBindingSource.MoveLast()
            End If
            navegacionconductor()
        End With
    End Function
    Function navegacionconductor()
        With conductor
            id = .Dtsisbus.conductor.Rows(.ConductorBindingSource.Position).Item(0).ToString
            .txtconductor.Text = .Dtsisbus.conductor.Rows(.ConductorBindingSource.Position).Item(1).ToString
            .txtidentidad.Text = .Dtsisbus.conductor.Rows(.ConductorBindingSource.Position).Item(2).ToString
            .txttel.Text = .Dtsisbus.conductor.Rows(.ConductorBindingSource.Position).Item(3).ToString
            .Txtfecha.EditValue = .Dtsisbus.conductor.Rows(.ConductorBindingSource.Position).Item(4).ToString
            .txtactivo.IsOn = .Dtsisbus.conductor.Rows(.ConductorBindingSource.Position).Item(5).ToString
        End With
    End Function
    Function habilitarconductor()
        With conductor
            If opt = 0 Then
                .cmdnuevo.Enabled = True
                .cmdsalir.Enabled = True
                .txtconductor.Text = ""
                .txtidentidad.Text = ""
                .txttel.Text = ""
                .Txtfecha.Text = ""
                .txtactivo.IsOn = True
            ElseIf opt = 1 Or opt = 2 Then
                .cmdguardar.Enabled = True
                .cmdeliminar.Visible = False
                .cmdcancelar.Enabled = True
                .txtconductor.Enabled = True
                .txtidentidad.Enabled = True
                .txttel.Enabled = True
                .Txtfecha.Enabled = True
                .txtactivo.Enabled = True
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
    Function desabilitarconductor()
        With conductor
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
            .txtconductor.Enabled = False
            .txtidentidad.Enabled = False
            .txttel.Enabled = False
            .Txtfecha.Enabled = False
            .txtactivo.Enabled = False
            habilitarconductor()
        End With
    End Function
    Function adelanteconductor()
        With conductor
            .ConductorBindingSource.MoveNext()
            navegacionconductor()
        End With
    End Function
    Function atrasconductor()
        With conductor
            .ConductorBindingSource.MovePrevious()
            navegacionconductor()
        End With
    End Function
    Function primeroconductor()
        With conductor
            .ConductorBindingSource.MoveFirst()
            navegacionconductor()
        End With
    End Function
    Function ultimoconductor()
        With conductor
            .ConductorBindingSource.MoveLast()
            navegacionconductor()
        End With
    End Function
    Function canelarconductor()
        With conductor
            opt = 3
            If .ConductorBindingSource.Count.ToString = 0 Then
                opt = 0
                .txtconductor.Text = ""
                .txtidentidad.Text = ""
                .txttel.Text = ""
                .Txtfecha.DateTime = ""
            Else
                localizarconductor()
            End If
            desabilitarconductor()
        End With
    End Function
    Function eliminarconductor()
        With conductor
            If .ConductorTableAdapter.elivalconductor(id) >= 1 Then
                MsgBox("No se puede eliminar este registro de conductor, ya se han hecho transacciones con este registro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Proceso terminado")
            Else
                Dim resp As Integer
                resp = MsgBox("Desea eliminar el registro del conductor", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar registro ")
                If resp = 6 Then
                    .ConductorTableAdapter.eliminarconductor(id)
                    MsgBox("Se ha eliminado la información del conductor", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Registro eliminado")
                    opt = 5
                    .ConductorTableAdapter.Fill(.Dtsisbus.conductor)
                    .ConductorBindingSource.MoveFirst()
                    If .ConductorBindingSource.Count.ToString = 0 Then
                        opt = 0
                        .txtconductor.Text = ""
                        .txtidentidad.Text = ""
                        .txttel.Text = ""
                        .Txtfecha.Text = ""
                    Else
                        localizarconductor()

                    End If
                    desabilitarconductor()
                End If
            End If
        End With
    End Function
    Function editarconductor()
        opt = 2
        desabilitarconductor()
    End Function
    Function cancelarconductor()
        With conductor
            opt = 3
            If .ConductorBindingSource.Count.ToString = 0 Then
                opt = 0
                .txtconductor.Text = ""
                .txtidentidad.Text = ""
                .txttel.Text = ""
                .Txtfecha.Text = ""
            Else
                localizarconductor()
            End If
            desabilitarconductor()
        End With
    End Function
End Module
