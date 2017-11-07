
Module ddescuento
    Function cargadescuentos()
        With descuento
            Try
                ' conn.Open()
                ' Insert code to process data.
                With descuento
                    .DescuentosTableAdapter.Fill(.Dtsisbus.descuentos)
                    opt = -1

                    If .DescuentosBindingSource.Count.ToString = 0 Then
                        opt = 0
                        .txttipo.Text = ""
                        .txtvalor.Text = 0

                    Else
                        id = .DescuentosTableAdapter.minid()
                        localizardescuentos()
                    End If
                    desabilitardescuentos()
                End With
            Catch ex As Exception
                MsgBox("Error al intentar acceder a base de datos,compruebe la conexión a la base de datos", MsgBoxStyle.Critical, "Conexion fallida")
                descuento.Close()
            Finally
            End Try
        End With
    End Function
    Function nuevodescuentos()
        With descuento
            opt = 1
            .txttipo.Text = ""
            .txtvalor.Text = 0
            desabilitardescuentos()
        End With
    End Function
    Function guardardescuentos()
        With descuento
            .dxtipo.Validate()
            .dxvalor.Validate()           
            '----Guardar un nuevo registro--------------------------------------------------------------------------------
            If opt = 1 Then
                If .txttipo.Text = "" Or .txtvalor.Text <= 0 Then
                    MsgBox("Ha dejado campos incompletos, porfavor ingrese los datos necesarios", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Campos imcompletos")
                Else
                    Dim resp As Integer
                    resp = MsgBox("Desea registar el descuento", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro del descuento")
                    If resp = 6 Then
                        Dim idmax As Integer = Val(.DescuentosTableAdapter.maxid) + 1
                        .DescuentosTableAdapter.nuevodesc(idmax, .txttipo.Text, .txtvalor.Text, Date.Now)
                        id = idmax
                        MsgBox("Se ha registrado el descuento", MsgBoxStyle.Information, "Registro guardado")
                        opt = 4
                        desabilitardescuentos()
                        localizardescuentos()
                    End If
                End If
            End If
            '---------------------------------------------------------------------------------------------------------------
            '----editar un nuevo registro--------------------------------------------------------------------------------
            If opt = 2 Then
                Dim resp As Integer
                resp = MsgBox("Desea actualizar los datos del descuento", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Actualizar registro del descuento")
                If .txttipo.Text = "" Or .txtvalor.Text <= 0 Then
                    MsgBox("Ha dejado campos incompletos, porfavor ingrese los datos necesarios", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Campos imcompletos")
                Else
                    If resp = 6 Then                       
                        .DescuentosTableAdapter.editardesc(.txttipo.Text, .txtvalor.Text, id)
                        MsgBox("Se ha actualizado la información del descuento", MsgBoxStyle.Information, "Registro actualizado")
                        opt = 4
                        desabilitardescuentos()
                        localizardescuentos()
                    End If
                End If
                End If
        End With
    End Function
    Function localizardescuentos()
        With descuento
            .DescuentosTableAdapter.Fill(.Dtsisbus.descuentos)
            If opt <> 1 Then
                Dim item As Integer = .DescuentosBindingSource.Find("iddesc", id)
                .DescuentosBindingSource.Position = item
            Else
                .DescuentosBindingSource.MoveLast()
            End If
            navegaciondescuentos()
        End With
    End Function
    Function navegaciondescuentos()
        With descuento          
            id = .Dtsisbus.descuentos.Rows(.DescuentosBindingSource.Position).Item(0).ToString
            .txttipo.Text = .Dtsisbus.descuentos.Rows(.DescuentosBindingSource.Position).Item(1).ToString
            .txtvalor.EditValue = .Dtsisbus.descuentos.Rows(.DescuentosBindingSource.Position).Item(2)
        End With
    End Function
    Function habilitardescuentos()
        With descuento
            If opt = 0 Then
                .cmdnuevo.Enabled = True
                .cmdsalir.Enabled = True
                .txttipo.Text = ""
                .txtvalor.Text = 0
            ElseIf opt = 1 Or opt = 2 Then
                .cmdguardar.Enabled = True
                .cmdeliminar.Visible = False
                .cmdcancelar.Enabled = True
                .txttipo.Enabled = True
                .txtvalor.Enabled = True
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
    Function desabilitardescuentos()
        With descuento
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
            .txttipo.Enabled = False
            .txtvalor.Enabled = False
            habilitardescuentos()
        End With
    End Function
    Function adelantedescuentos()
        With descuento
            .DescuentosBindingSource.MoveNext()
            navegaciondescuentos()
        End With
    End Function
    Function atrasdescuentos()
        With descuento
            .DescuentosBindingSource.MovePrevious()
            navegaciondescuentos()
        End With
    End Function
    Function primerodescuentos()
        With descuento
            .DescuentosBindingSource.MoveFirst()
            navegaciondescuentos()
        End With
    End Function
    Function ultimodescuentos()
        With descuento
            .DescuentosBindingSource.MoveLast()
            navegaciondescuentos()
        End With
    End Function
    Function canelardescuentos()
        With descuento
            opt = 3
            If .DescuentosBindingSource.Count.ToString = 0 Then
                opt = 0
                .txttipo.Text = ""
                .txtvalor.Text = 0
            Else
                localizardescuentos()
            End If
            desabilitardescuentos()
        End With
    End Function
    Function eliminardescuentos()
        With descuento
            If .DescuentosTableAdapter.elivaldesc(id) >= 0 Then
                MsgBox("No se puede eliminar este registro del descuento, ya se han hecho transacciones con este registro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Proceso terminado")
            Else
                Dim resp As Integer
                resp = MsgBox("Desea eliminar el descuento", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar registro del descuento")
                If resp = 6 Then
                    .DescuentosTableAdapter.eliminardesc(id)
                    MsgBox("Se ha eliminado la información del descuento", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Registro eliminado")
                    opt = 5
                    .DescuentosTableAdapter.Fill(.Dtsisbus.descuentos)
                    .DescuentosBindingSource.MoveFirst()
                    If .DescuentosBindingSource.Count.ToString = 0 Then
                        opt = 0
                        .txttipo.Text = ""
                        .txtvalor.Text = 0
                    Else
                        localizardescuentos()
                    End If
                    desabilitardescuentos()
                End If
            End If
        End With
    End Function
    Function editardescuentos()
        opt = 2
        desabilitardescuentos()
    End Function
    Function cancelardescuentos()
        With descuento
            opt = 3
            If .DescuentosBindingSource.Count.ToString = 0 Then
                opt = 0
                .txttipo.Text = ""
                .txtvalor.Text = 0
            Else
                localizardescuentos()
            End If
            desabilitardescuentos()
        End With
    End Function
End Module
