Imports System.IO
Module dopciones
    Function cargaopciones()
        With datosempresa
            .OpcionesTableAdapter.Fill(.Dtsisbus.opciones)
            '--------------------------
            .txtempresa.Enabled = False
            .txtdireccion.Enabled = False
            .txttelefono.Enabled = False
            .txtemail.Enabled = False
            .txtrtn.Enabled = False
            .txtcai.Enabled = False
            .txtcodtikect.Enabled = False
            .txtnticket.Enabled = False
            .txtrango1.Enabled = False
            .txtrango2.Enabled = False
            .txtfechalimit.Enabled = False
            .logo.Enabled = False
            .cmdguardar.Enabled = False
            .cmdcancelar.Enabled = False
            .cmdeditar.Enabled = True
            .cmdsalir.Enabled = True
            '--------------------------
            .txtempresa.Text = .OpcionesTableAdapter.GetData.Item(0).empresa.ToString
            .txtdireccion.Text = .OpcionesTableAdapter.GetData.Item(0).direccion.ToString
            .txttelefono.Text = .OpcionesTableAdapter.GetData.Item(0).telefono.ToString
            .txtemail.Text = .OpcionesTableAdapter.GetData.Item(0).email.ToString
            .txtrtn.Text = .OpcionesTableAdapter.GetData.Item(0).rtn.ToString
            .txtcai.Text = .OpcionesTableAdapter.GetData.Item(0).cai.ToString
            .txtcodtikect.Text = .OpcionesTableAdapter.GetData.Item(0).codticket.ToString
            .txtnticket.Text = .OpcionesTableAdapter.GetData.Item(0).nticket.ToString
            .txtrango1.Text = .OpcionesTableAdapter.GetData.Item(0).rango1.ToString
            .txtrango2.Text = .OpcionesTableAdapter.GetData.Item(0).rango2.ToString
            .txtfechalimit.Text = .OpcionesTableAdapter.GetData.Item(0).fechalimt.ToString
            Dim MyPhoto() As Byte = CType(.OpcionesTableAdapter.GetData.Item(0).logo, Byte())
            Dim ms As New MemoryStream(MyPhoto)
            .logo.Image = Image.FromStream(ms)
        End With
    End Function
    Function editaropciones()
        With datosempresa
            '--------------------------
            .txtempresa.Enabled = True
            .txtdireccion.Enabled = True
            .txttelefono.Enabled = True
            .txtemail.Enabled = True
            .txtrtn.Enabled = True
            .txtcai.Enabled = True
            .txtcodtikect.Enabled = True
            .txtnticket.Enabled = True
            .txtrango1.Enabled = True
            .txtrango2.Enabled = True
            .txtfechalimit.Enabled = True
            .logo.Enabled = True
            .cmdguardar.Enabled = True
            .cmdcancelar.Enabled = True
            .cmdeditar.Enabled = False
            .cmdsalir.Enabled = False
        End With
    End Function
    Function guardaropciones()
        With datosempresa
            .Dxempresa.Validate()
            If .txtempresa.Text = "" Or .txtdireccion.Text = "" Or .txtrtn.Text = "" Or .txtcai.Text = "" Or .txtnticket.Text = "" Then
                MsgBox("Ha dejados campos incompletos", MsgBoxStyle.Critical, "Proceso terminado")
            Else
                Dim arrFilename() As String = Split(.Text, "\")
                Array.Reverse(arrFilename)
                Dim ms As New MemoryStream
                .logo.Image.Save(ms, .logo.Image.RawFormat)
                Dim arrImage() As Byte = ms.GetBuffer
                .OpcionesTableAdapter.editaropciones(.txtempresa.Text, .txtdireccion.Text, .txttelefono.Text, .txtemail.Text, .txtrtn.Text, .txtcai.Text, .txtcodtikect.Text, .txtnticket.Text, .txtrango1.Text, .txtrango2.Text, .txtfechalimit.DateTime.Date, arrImage)
                MsgBox("Datos Actualizados con exito", MsgBoxStyle.Information, "Proceso terminado")
                cargaopciones()
            End If

        End With
    End Function
    Function imagenlogo()
        With datosempresa
            Dim foto As String
            .OpenFileDialog1.FileName = ""
            .OpenFileDialog1.Filter = "Todos(*.Jpg, *.Png, *.Gif, *.Tiff, *.Jpeg, *.Bmp)|*.Jpg; *.Png; *.Gif; *.Tiff; *.Jpeg; *.Bmp"
            .OpenFileDialog1.ShowDialog()
            Try
                foto = .OpenFileDialog1.FileName.ToString
                If foto <> "" Then
                    .logo.Image = System.Drawing.Image.FromFile(foto)
                End If
            Catch ex As Exception
            End Try
        End With
    End Function
End Module
