Module dlogin
    Function cargalogin()
        ' login.UsuariosTableAdapter.Fill(login.Dtsisbus.usuarios)
        Try
            'conn.Open()
            ' Insert code to process data.
            login.UsuariosTableAdapter.Fill(login.Dtsisbus.usuarios)
        Catch ex As Exception
            MsgBox("Error al intentar acceder a base de datos,compruebe la conexión a la base de datos", MsgBoxStyle.Critical, "Conexion fallida")
            End
        Finally

        End Try

    End Function
    Function acceso()
        With login
            .DxValidationProvider1.Validate()
            If .txtclave.Text.Trim() = "" Then
                MsgBox("Campo contraseña esta vacio", MsgBoxStyle.Critical, "Acceso denegado")
                login.txtclave.Focus()
                Exit Function
            Else
                Try
                    login.UsuariosTableAdapter.Getusuario(login.cbousuario.SelectedValue)
                    If login.UsuariosTableAdapter.Getusuario(login.cbousuario.SelectedValue).Item(0).pass = login.txtclave.Text Then
                        idusu = .UsuariosTableAdapter.Getusuario(login.cbousuario.SelectedValue).Item(0).idusuario
                        nom = .UsuariosTableAdapter.Getusuario(login.cbousuario.SelectedValue).Item(0).nombre
                        usu = .UsuariosTableAdapter.Getusuario(login.cbousuario.SelectedValue).Item(0).nick
                        perfil = .UsuariosTableAdapter.Getusuario(login.cbousuario.SelectedValue).Item(0).perfil
                        habi = .UsuariosTableAdapter.Getusuario(login.cbousuario.SelectedValue).Item(0).habilitado
                        'principal.ShowDialog()
                        tilemenu.ShowDialog()
                    Else
                        MsgBox("Usuario o contraseña invalidos", MsgBoxStyle.Critical, "Acceso denegado")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error al intentar iniciar sesion, usuario o contraseña invalida")
                Finally
                    'conn.Close()
                End Try

            End If
        End With
    End Function

End Module
