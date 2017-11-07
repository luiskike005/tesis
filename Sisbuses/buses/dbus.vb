Module dbus
    Function cargarbus()
        Try
            ' conn.Open()
            ' Insert code to process data.
            With bus
                .BusTableAdapter.Fill(.Dtsisbus.bus)
                opt = -1

                If .BusBindingSource.Count.ToString = 0 Then
                    opt = 0
                    .txtbus.Text = ""
                    .txtplaca.Text = ""
                    .txtasientos.Text = ""
                    .Txttamaño.Text = ""
                    .txtactivo.IsOn = True
                Else
                    id = .BusTableAdapter.idmin()
                    localizarbus()
                End If
                desabilitarbus()
            End With
        Catch ex As Exception
            MsgBox("Error al intentar acceder a base de datos,compruebe la conexión a la base de datos", MsgBoxStyle.Critical, "Conexion fallida")
            bus.Close()
        Finally
        End Try

    End Function
    Function nuevobus()
        With bus
            opt = 1
            .txtbus.Text = ""
            .txtplaca.Text = ""
            .txtasientos.Text = ""
            .Txttamaño.Text = ""
            .txtactivo.IsOn = True
            desabilitarbus()
        End With
    End Function
    Function guardarbus()
        With bus
            ' .Dxblanco.Validate()

            '----Guardar un nuevo registro--------------------------------------------------------------------------------
            If opt = 1 Then
                If .txtbus.Text = "" Or .txtplaca.Text = "" Then
                    MsgBox("Ha dejado campos incompletos, porfavor ingrese los datos necesarios", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Campos imcompletos")
                Else
                    Dim resp As Integer
                    resp = MsgBox("Desea registar del bus", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro del bus")
                    If resp = 6 Then
                        Dim idmax As Integer = Val(.BusTableAdapter.idmax) + 1
                        .BusTableAdapter.nuevobus(idmax, .txtbus.Text, .txtplaca.Text, .txtasientos.Text, .Txttamaño.Text, .txtactivo.EditValue)
                        id = idmax
                        MsgBox("Se ha registrado el bus", MsgBoxStyle.Information, "Registro guardado")
                        opt = 4
                        desabilitarbus()
                        localizarbus()
                    End If
                End If
            End If
            '---------------------------------------------------------------------------------------------------------------
            '----editar un nuevo registro--------------------------------------------------------------------------------
            If opt = 2 Then
                Dim resp As Integer
                resp = MsgBox("Desea actualizar los datos del bus", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Actualizar registro")
                If .txtbus.Text = "" Or .txtplaca.Text = "" Then
                    MsgBox("Ha dejado campos incompletos, porfavor ingrese los datos necesarios", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Campos imcompletos")
                Else
                    If resp = 6 Then
                        .BusTableAdapter.editarbus(.txtbus.Text, .txtplaca.Text, .txtasientos.Text, .Txttamaño.Text, .txtactivo.EditValue, id)
                        MsgBox("Se ha actualizado la información del bus", MsgBoxStyle.Information, "Registro actualizado")
                        opt = 4
                        desabilitarbus()
                        localizarbus()
                    End If
                End If
            End If
        End With
    End Function
    Function localizarbus()
        With bus
            .BusTableAdapter.Fill(.Dtsisbus.bus)
            If opt <> 1 Then
                Dim item As Integer = .BusBindingSource.Find("idbus", id)
                .BusBindingSource.Position = item
            Else
                .BusBindingSource.MoveLast()
            End If
            navegacionbus()
        End With
    End Function
    Function navegacionbus()
        With bus
            id = .Dtsisbus.bus.Rows(.BusBindingSource.Position).Item(0).ToString
            .txtbus.Text = .Dtsisbus.bus.Rows(.BusBindingSource.Position).Item(1).ToString
            .txtplaca.Text = .Dtsisbus.bus.Rows(.BusBindingSource.Position).Item(2).ToString
            .txtasientos.Text = .Dtsisbus.bus.Rows(.BusBindingSource.Position).Item(3).ToString
            .Txttamaño.Text = .Dtsisbus.bus.Rows(.BusBindingSource.Position).Item(4).ToString
            .txtactivo.IsOn = .Dtsisbus.bus.Rows(.BusBindingSource.Position).Item(5).ToString
        End With
    End Function
    Function habilitarbus()
        With bus
            If opt = 0 Then
                .cmdnuevo.Enabled = True
                .cmdsalir.Enabled = True
                .txtbus.Text = ""
                .txtplaca.Text = ""
                .txtasientos.Text = ""
                .Txttamaño.Text = ""
                .txtactivo.IsOn = True
            ElseIf opt = 1 Or opt = 2 Then
                .cmdguardar.Enabled = True
                .cmdeliminar.Visible = False
                .cmdcancelar.Enabled = True
                .txtbus.Enabled = True
                .txtplaca.Enabled = True
                .txtasientos.Enabled = True
                .Txttamaño.Enabled = True
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
    Function desabilitarbus()
        With bus
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
            .txtbus.Enabled = False
            .txtplaca.Enabled = False
            .txtasientos.Enabled = False
            .Txttamaño.Enabled = False
            .txtactivo.Enabled = False
            habilitarbus()
        End With
    End Function
    Function adelantebus()
        With bus
            .BusBindingSource.MoveNext()
            navegacionbus()
        End With
    End Function
    Function atrasbus()
        With bus
            .BusBindingSource.MovePrevious()
            navegacionbus()
        End With
    End Function
    Function primerobus()
        With bus
            .BusBindingSource.MoveFirst()
            navegacionbus()
        End With
    End Function
    Function ultimobus()
        With bus
            .BusBindingSource.MoveLast()
            navegacionbus()
        End With
    End Function
    Function canelarbus()
        With bus
            opt = 3
            If .BusBindingSource.Count.ToString = 0 Then
                opt = 0
                .txtbus.Text = ""
                .txtplaca.Text = ""
                .txtasientos.Text = ""
                .Txttamaño.Text = ""
                .txtactivo.IsOn = True
            Else
                localizarbus()
            End If
            desabilitarbus()
        End With
    End Function
    Function eliminarbus()
        With bus
            If .BusTableAdapter.elivalbus(id) >= 1 Then
                MsgBox("No se puede eliminar este registro de bus, ya se han hecho transacciones con este registro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Proceso terminado")
            Else
                Dim resp As Integer
                resp = MsgBox("Desea eliminar el registro del bus", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar registro ")
                If resp = 6 Then
                    .BusTableAdapter.eliminarbus(id)
                    MsgBox("Se ha eliminado la información del bus", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Registro eliminado")
                    opt = 5
                    .BusTableAdapter.Fill(.Dtsisbus.bus)
                    .BusBindingSource.MoveFirst()
                    If .BusBindingSource.Count.ToString = 0 Then
                        opt = 0
                        .txtbus.Text = ""
                        .txtplaca.Text = ""
                        .txtasientos.Text = ""
                        .Txttamaño.Text = ""
                        .txtactivo.IsOn = True
                    Else
                        localizarbus()
                    End If
                    desabilitarbus()
                End If
            End If
        End With
    End Function
    Function editarbus()
        opt = 2
        desabilitarbus()
    End Function
    Function cancelarbus()
        With bus
            opt = 3
            If .BusBindingSource.Count.ToString = 0 Then
                opt = 0
                .txtbus.Text = ""
                .txtplaca.Text = ""
                .txtasientos.Text = ""
                .Txttamaño.Text = ""
                .txtactivo.IsOn = True
            Else
                localizarbus()
            End If
            desabilitarbus()
        End With
    End Function
End Module
