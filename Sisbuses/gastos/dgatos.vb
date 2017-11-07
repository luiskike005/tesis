Module dgatos
    Function cargagastos()
        With gasto
            Try
                ' conn.Open()
                ' Insert code to process data.             
                .GastosTableAdapter.Fill(.Dtsisbus.gastos)
                    opt = -1

                If .GastosBindingSource.Count.ToString = 0 Then
                    opt = 0
                    .txtrazon.Text = ""
                    .txtmonto.Text = 0.0
                    .txtfecha.DateTime = Date.Now
                Else
                    If cargform <> 1 Then
                        id = .GastosTableAdapter.idmin()
                    End If
                    localizargastos()
                End If
                desabilitargastos()

            Catch ex As Exception
                MsgBox("Error al intentar acceder a base de datos,compruebe la conexión a la base de datos", MsgBoxStyle.Critical, "Conexion fallida")
                gasto.Close()
            Finally
            End Try
        End With
    End Function
    Function nuevogastos()
        With gasto
            opt = 1
            .txtrazon.Text = ""
            .txtmonto.Text = 0.0
            .txtfecha.DateTime = Date.Now
            desabilitargastos()
        End With
    End Function
    Function guardargastos()
        With gasto
            .Dxmonto.Validate()
            .Dxrazon.Validate()
            '----Guardar un nuevo registro--------------------------------------------------------------------------------
            If opt = 1 Then
                If .txtrazon.Text = "" Or .txtmonto.Text <= 0 Then
                    MsgBox("Ha dejado campos incompletos, porfavor ingrese los datos necesarios", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Campos imcompletos")
                Else
                    Dim resp As Integer 
                    resp = MsgBox("Desea registar el gasto", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro del gasto")
                    If resp = 6 Then
                        Dim idmax As Integer = Val(.GastosTableAdapter.idmax) + 1
                        .GastosTableAdapter.nuevogasto(idmax, .txtrazon.Text, .txtmonto.EditValue, .txtfecha.DateTime.Date, Date.Now)
                        id = idmax
                        MsgBox("Se ha registrado el gasto", MsgBoxStyle.Information, "Registro guardado")
                        opt = 4
                        desabilitargastos()
                        localizargastos()
                    End If
                End If
            End If
            '---------------------------------------------------------------------------------------------------------------
            '----editar un nuevo registro--------------------------------------------------------------------------------
            If opt = 2 Then
                Dim resp As Integer
                resp = MsgBox("Desea actualizar los datos del gasto", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Actualizar registro del gasto")
                If .txtrazon.Text = "" Or .txtmonto.Text <= 0 Then
                    MsgBox("Ha dejado campos incompletos, porfavor ingrese los datos necesarios", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Campos imcompletos")
                Else
                    If resp = 6 Then
                        .GastosTableAdapter.editargasto(.txtrazon.Text, .txtmonto.EditValue, .txtfecha.DateTime.Date, id)
                        MsgBox("Se ha actualizado la información del gasto", MsgBoxStyle.Information, "Registro actualizado")
                        opt = 4
                        desabilitargastos()
                        localizargastos()
                    End If
                End If
            End If
        End With
    End Function
    Function localizargastos()
        With gasto
            .GastosTableAdapter.Fill(.Dtsisbus.gastos)
            If opt <> 1 Then
                Dim item As Integer = .GastosBindingSource.Find("idgasto", id)
                .GastosBindingSource.Position = item
            Else
                .GastosBindingSource.MoveLast()
            End If
            navegaciongastos()
        End With
    End Function
    Function navegaciongastos()
        With gasto
            id = .Dtsisbus.gastos.Rows(.GastosBindingSource.Position).Item(0).ToString
            .txtrazon.Text = .Dtsisbus.gastos.Rows(.GastosBindingSource.Position).Item(1).ToString
            .txtmonto.EditValue = .Dtsisbus.gastos.Rows(.GastosBindingSource.Position).Item(2)
            .txtfecha.DateTime = .Dtsisbus.gastos.Rows(.GastosBindingSource.Position).Item(3)
        End With
    End Function
    Function habilitargastos()
        With gasto
            If opt = 0 Then
                .cmdnuevo.Enabled = True
                .cmdsalir.Enabled = True
                .txtrazon.Text = ""
                .txtmonto.Text = 0.0
                .txtfecha.DateTime = Date.Now
            ElseIf opt = 1 Or opt = 2 Then
                .cmdguardar.Enabled = True
                .cmdeliminar.Visible = False
                .cmdcancelar.Enabled = True
                .txtmonto.Enabled = True
                .txtfecha.Enabled = True
                .txtrazon.Enabled = True
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
    Function desabilitargastos()
        With gasto
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

            .txtrazon.Enabled = False
            .txtmonto.Enabled = False
            .txtfecha.Enabled = False
            habilitargastos()
        End With
    End Function
    Function adelantegastos()
        With gasto
            .GastosBindingSource.MoveNext()
            navegaciongastos()
        End With
    End Function
    Function atrasgastos()
        With gasto
            .GastosBindingSource.MovePrevious()
            navegaciongastos()
        End With
    End Function
    Function primerogastos()
        With gasto
            .GastosBindingSource.MoveFirst()
            navegaciongastos()
        End With
    End Function
    Function ultimogastos()
        With gasto
            .GastosBindingSource.MoveLast()
            navegaciongastos()
        End With
    End Function
    Function canelargastos()
        With gasto
            opt = 3
            If .GastosBindingSource.Count.ToString = 0 Then
                opt = 0
                .txtrazon.Text = ""
                .txtmonto.Text = 0.0
                .txtfecha.DateTime = Date.Now
            Else
                localizargastos()
            End If
            desabilitargastos()
        End With
    End Function
    Function eliminargastos()
        With gasto
            Dim resp As Integer
            resp = MsgBox("Desea eliminar el gasto", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar registro del gasto")
            If resp = 6 Then
                .GastosTableAdapter.eliminargasto(id)
                MsgBox("Se ha eliminado la información del gasto", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Registro eliminado")
                opt = 5
                .GastosTableAdapter.Fill(.Dtsisbus.gastos)
                .GastosBindingSource.MoveFirst()
                If .GastosBindingSource.Count.ToString = 0 Then
                    opt = 0
                    .txtrazon.Text = ""
                    .txtmonto.Text = 0.0
                    .txtfecha.DateTime = Date.Now
                Else
                    localizargastos()
                End If
                desabilitargastos()
            End If
        End With
    End Function
    Function editargastos()
        opt = 2
        desabilitargastos()
    End Function
    Function cancelargastos()
        With gasto
            opt = 3
            If .GastosBindingSource.Count.ToString = 0 Then
                opt = 0
                .txtrazon.Text = ""
                .txtmonto.Text = 0.0
                .txtfecha.DateTime = Date.Now
            Else
                localizargastos()
            End If
            desabilitargastos()
        End With
    End Function
End Module
