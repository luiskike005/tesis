Imports System.IO
Module dusuario
    '-----------formulario usuario-----------------------
    Function cargarusuario()
        Try
            ' conn.Open()
            ' Insert code to process data.
            With regusuario
                .UsuariosTableAdapter.Fill(regusuario.Dtsisbus.usuarios)
                opt = -1

                If .UsuariosBindingSource.Count.ToString = 0 Then
                    opt = 0
                    .txtnombre.Text = ""
                    .txtusuario.Text = ""
                    .txtcontraseña.Text = ""
                    .opthabilitado.SelectedIndex = 0
                    .optperfil.SelectedIndex = 0
                Else
                    id = .UsuariosTableAdapter.minid()
                    localizarusuario()
                End If
                desabilitarusuario()
            End With
        Catch ex As Exception
            MsgBox("Error al intentar acceder a base de datos,compruebe la conexión a la base de datos", MsgBoxStyle.Critical, "Conexion fallida")
            regusuario.Close()
        Finally
        End Try
    End Function
    Function nuevousuario()
        With regusuario
            .image.Image = Sisbuses.My.Resources.Resources.user
            opt = 1
            .txtnombre.Text = ""
            .txtusuario.Text = ""
            .txtcontraseña.Text = ""
            .optperfil.SelectedIndex = 0
            .opthabilitado.SelectedIndex = 0
            'For Each objet In .GroupBox4.Controls
            'If TypeOf objet Is DevExpress.XtraEditors.CheckEdit Then
            'objet.Checked = False
            'End If
            ' Next         
            desabilitarusuario()
        End With
    End Function
    Function desabilitarusuario()
        With regusuario

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
            .image.Enabled = False
            .cmdsalir.Enabled = False
            .txtnombre.Enabled = False
            .txtusuario.Enabled = False
            .txtcontraseña.Enabled = False
            .opthabilitado.Enabled = False
            .optperfil.Enabled = False
            habilitarusuario()
        End With
    End Function
    Function habilitarusuario()
        With regusuario
            If opt = 0 Then
                .cmdnuevo.Enabled = True
                .cmdsalir.Enabled = True
                .txtnombre.Text = ""
                .txtusuario.Text = ""
                .txtcontraseña.Text = ""
                .optperfil.SelectedIndex = 0
                .opthabilitado.SelectedIndex = 1
            ElseIf opt = 1 Or opt = 2 Then
                .image.Enabled = True
                .cmdguardar.Enabled = True
                .cmdeliminar.Visible = False
                .cmdcancelar.Enabled = True
                .txtnombre.Enabled = True
                .txtusuario.Enabled = True
                .txtcontraseña.Enabled = True
                .optperfil.Enabled = True
                .opthabilitado.Enabled = True
                If opt = 1 Then
                    .opthabilitado.SelectedIndex = 0
                End If

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
    Function guardarusuario()
        With regusuario
            .Dxnombre.Validate()
            .Dxusuario.Validate()
            .Dxpass.Validate()
            Dim arrFilename() As String = Split(.Text, "\")
            Array.Reverse(arrFilename)
            Dim ms As New MemoryStream
            .image.Image.Save(ms, .image.Image.RawFormat)
            Dim arrImage() As Byte = ms.GetBuffer
            '----Guardar un nuevo registro--------------------------------------------------------------------------------
            If opt = 1 Then

                If .txtnombre.Text = "" Or .txtusuario.Text = "" Or .txtcontraseña.Text = "" Then
                    MsgBox("Ha dejado campos incompletos, porfavor ingrese los datos necesarios", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Campos imcompletos")
                Else
                    Dim resp As Integer
                    resp = MsgBox("Desea registar el usuario", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Registro del usuario")
                    If resp = 6 Then
                        Dim idmax As Integer = .UsuariosTableAdapter.maxid + 1
                        Dim perfil As String
                        If .optperfil.SelectedIndex = 0 Then
                            perfil = "cajero"
                        Else
                            perfil = "administrador"
                        End If
                        .UsuariosTableAdapter.nuevo_usuario(idmax, .txtnombre.Text, .txtusuario.Text, .txtcontraseña.Text, perfil, .opthabilitado.EditValue, arrImage, Date.Now)
                        id = idmax
                        MsgBox("Se ha registrado el usuario", MsgBoxStyle.Information, "Registro guardado")
                        opt = 4
                        desabilitarusuario()
                        localizarusuario()
                    End If
                End If
            End If
            '---------------------------------------------------------------------------------------------------------------
            '----editar un nuevo registro--------------------------------------------------------------------------------
            If opt = 2 Then
                If (.optperfil.SelectedIndex = 0 And .UsuariosTableAdapter.minid = id) Or (.opthabilitado.SelectedIndex = 1 And .UsuariosTableAdapter.minid = id) Then
                    MsgBox("El administrador maestro no puede ser cambiado a cajero ni desabilitado", MsgBoxStyle.Critical, "Proceso cancelado")
                Else

                    Dim resp As Integer
                    resp = MsgBox("Desea actualizar los datos del usuario", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Actualizar registro del usuario")
                    If .txtnombre.Text = "" Or .txtusuario.Text = "" Or .txtcontraseña.Text = "" Then
                        MsgBox("Ha dejado campos incompletos, porfavor ingrese los datos necesarios", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Campos imcompletos")
                    Else
                        If resp = 6 Then
                            Dim perfil As String
                            If .optperfil.SelectedIndex = 0 Then
                                perfil = "cajero"
                            Else
                                perfil = "administrador"
                            End If
                            .UsuariosTableAdapter.editar_usuario(.txtnombre.Text, .txtusuario.Text, .txtcontraseña.Text, perfil, .opthabilitado.EditValue, arrImage, id)

                            MsgBox("Se ha actualizado la información del usuario", MsgBoxStyle.Information, "Registro actualizado")
                            opt = 4
                            desabilitarusuario()
                            localizarusuario()
                        End If
                    End If
                End If
            End If
        End With
    End Function
    Function navegacionusuario()
        With regusuario
            id = .Dtsisbus.usuarios.Rows(.UsuariosBindingSource.Position).Item(0).ToString
            .txtnombre.Text = .Dtsisbus.usuarios.Rows(.UsuariosBindingSource.Position).Item(1).ToString
            .txtusuario.Text = .Dtsisbus.usuarios.Rows(.UsuariosBindingSource.Position).Item(2).ToString
            .txtcontraseña.Text = .Dtsisbus.usuarios.Rows(.UsuariosBindingSource.Position).Item(3).ToString
            If .Dtsisbus.usuarios.Rows(.UsuariosBindingSource.Position).Item(4).ToString = "administrador" Then
                .optperfil.SelectedIndex = 1
            Else
                .optperfil.SelectedIndex = 0
            End If
            If .Dtsisbus.usuarios.Rows(.UsuariosBindingSource.Position).Item(5) = False Then
                .opthabilitado.SelectedIndex = 1
            Else
                .opthabilitado.SelectedIndex = 0
            End If
            Dim MyPhoto() As Byte = CType(.Dtsisbus.usuarios.Rows(.UsuariosBindingSource.Position).Item(6), Byte())
            Dim ms As New MemoryStream(MyPhoto)
            .image.Image = Image.FromStream(ms)
        End With
    End Function
    Function localizarusuario()
        With regusuario
            .UsuariosTableAdapter.Fill(.Dtsisbus.usuarios)
            If opt <> 1 Then
                Dim item As Integer = .UsuariosBindingSource.Find("idusuario", id)
                .UsuariosBindingSource.Position = item
            Else
                .UsuariosBindingSource.MoveLast()
            End If
            navegacionusuario()
        End With
    End Function
    Function adelanteusuario()
        With regusuario
            .UsuariosBindingSource.MoveNext()
            navegacionusuario()
        End With
    End Function
    Function atrasusuario()
        With regusuario
            .UsuariosBindingSource.MovePrevious()
            navegacionusuario()
        End With
    End Function
    Function primerousuario()
        With regusuario
            .UsuariosBindingSource.MoveFirst()
            navegacionusuario()
        End With
    End Function
    Function ultimousuario()
        With regusuario
            .UsuariosBindingSource.MoveLast()
            navegacionusuario()
        End With
    End Function
    Function canelarusuario()
        With regusuario
            opt = 3
            If .UsuariosBindingSource.Count.ToString = 0 Then
                opt = 0
                .txtusuario.Text = ""
                .txtnombre.Text = "t"
                .txtcontraseña.Text = ""
                .opthabilitado.SelectedIndex = 0
                .optperfil.SelectedIndex = 0
            Else
                localizarusuario()
            End If
            desabilitarusuario()
        End With
    End Function
    Function eliminarusuario()
        With regusuario
            If .UsuariosTableAdapter.minid = id Then
                MsgBox("No se puede eliminar este usuario ya que es el usuario administrador maestro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Eliminacíon no valida")
            Else
                Dim resp As Integer
                resp = MsgBox("Desea eliminar el usuario", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar registro del usuario")
                If resp = 6 Then
                    .UsuariosTableAdapter.eliminar_usuario(id)
                    MsgBox("Se ha eliminado la información del usuario", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Registro eliminado")
                    opt = 5
                    .UsuariosTableAdapter.Fill(.Dtsisbus.usuarios)
                    .UsuariosBindingSource.MoveFirst()
                    If .UsuariosBindingSource.Count.ToString = 0 Then
                        opt = 0
                        .txtnombre.Text = ""
                        .txtusuario.Text = ""
                        .txtcontraseña.Text = ""
                        .optperfil.SelectedIndex = 0
                        .opthabilitado.SelectedIndex = 0
                    Else
                        localizarusuario()
                    End If
                    desabilitarusuario()
                End If
            End If
        End With
    End Function
    Function editarusuario()
        opt = 2
        desabilitarusuario()
    End Function
    Function cancelarusuario()
        With regusuario
            opt = 3
            If .UsuariosBindingSource.Count.ToString = 0 Then
                opt = 0
                .txtusuario.Text = ""
                .txtnombre.Text = "t"
                .txtcontraseña.Text = ""
                .opthabilitado.SelectedIndex = 0
                .optperfil.SelectedIndex = 0
            Else
                localizarusuario()
            End If
            desabilitarusuario()
        End With
    End Function
    Function fotousuario()
        With regusuario
            Dim foto As String
            .OpenFileDialog1.FileName = ""
            .OpenFileDialog1.Filter = "Todos(*.Jpg, *.Png, *.Gif, *.Tiff, *.Jpeg, *.Bmp)|*.Jpg; *.Png; *.Gif; *.Tiff; *.Jpeg; *.Bmp"
            .OpenFileDialog1.ShowDialog()
            Try
                foto = .OpenFileDialog1.FileName.ToString
                If foto <> "" Then
                    .image.Image = System.Drawing.Image.FromFile(foto)
                End If
            Catch ex As Exception

            End Try

        End With
    End Function
    '--------------formulario cambio clave-----------------------
    Function cargaclave()
        Try
            clave.UsuariosTableAdapter.Fill(clave.Dtsisbus.usuarios)
        Catch ex As Exception
            clave.Close()
        End Try

    End Function
    Function cambio()
        With clave
            .Dxpassactual.Validate()
            .Dxpassnueva.Validate()
            .Dxpassverib.Validate()
            If .txtpassactual.Text = "" Or .txtpassnueva.Text = "" Or .txtpassvery.Text = "" Then
                MsgBox("Ha dejado campos incompletos", MsgBoxStyle.Critical, "Proceso cancelado")
            Else
                If .UsuariosTableAdapter.obtpass(idusu) = Trim(.txtpassactual.Text) Then
                    If Trim(.txtpassnueva.Text) = Trim(.txtpassvery.Text) Then
                        .UsuariosTableAdapter.editarpass(Trim(.txtpassnueva.Text), idusu)
                        MsgBox("Contraseña modificada con exito", MsgBoxStyle.Information, "Proceso terminado")
                        .txtpassactual.Text = ""
                        .txtpassnueva.Text = ""
                        .txtpassvery.Text = ""
                    Else
                        MsgBox("la contraseña nueva y de verificación no concuerdan", MsgBoxStyle.Critical, "Proceso cancelado")
                    End If
                Else
                    MsgBox("La contraseña actual ingresada es invalida", MsgBoxStyle.Critical, "Proceso cancelado")
                End If
            End If
        End With
    End Function
End Module
