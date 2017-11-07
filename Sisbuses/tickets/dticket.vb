Module dticket
    Dim carga = 0
    Function nuevoticket()

        With ticket

            'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.opciones' Puede moverla o quitarla según sea necesario.
            .OpcionesTableAdapter.Fill(.Dtsisbus.opciones)
            'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.ticket' Puede moverla o quitarla según sea necesario.
            .TicketTableAdapter.Fill(.Dtsisbus.ticket)
            'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.descuentos' Puede moverla o quitarla según sea necesario.
            .DescuentosTableAdapter.Fill(.Dtsisbus.descuentos)
            'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.destino' Puede moverla o quitarla según sea necesario.
            .DestinoTableAdapter.Fill(.Dtsisbus.destino)
            'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.ruta' Puede moverla o quitarla según sea necesario.
            .RutaTableAdapter.Fill(.Dtsisbus.ruta)
            .DestinoBindingSource.Filter = "idruta=" + Str(idruta)
            .cboruta.Text = descruta
            .cbodestino.SelectedIndex = -1
            .txtfecha.DateTime = Date.Now
            .txthora.Text = hora
            .cbodesc.SelectedIndex = -1
            .txtprecio.EditValue = 0.0
            .txtdesc.EditValue = 0.0
            .txtpago.EditValue = 0.0
            .txtefectivo.EditValue = 0.0
            .txtcambio.EditValue = 0.0

            .Lblpor.Text = "0%="
        End With

        carga = 1
    End Function
    Function calpre()
        If carga = 1 Then
            With ticket
                If .cboruta.Text <> "" Then
                    iddestino = .cbodestino.SelectedValue
                    .txtprecio.EditValue = .DestinoTableAdapter.obtprecio(iddestino)
                End If
            End With
        End If
    End Function
    Function caldesc()
        If carga = 1 Then
            With ticket
                If .cbodesc.Text <> "" Then
                    Dim pre As Decimal = .txtprecio.EditValue
                    iddescuento = .cbodesc.SelectedValue
                    Dim porcen As Integer = .DescuentosTableAdapter.obtpredesc(iddescuento)                
                        .Lblpor.Text = porcen.ToString + "%="
                        Dim repor As Decimal = (porcen / 100) * pre
                    .txtdesc.EditValue = repor
                    
                End If
            End With
        End If
    End Function
    Function calpaos()
        If carga = 1 Then
            With ticket

                Dim pago, efectivo, cambio As Decimal
                pago = .txtprecio.EditValue - .txtdesc.EditValue
                efectivo = .txtefectivo.EditValue
                cambio = efectivo - pago
                .txtpago.EditValue = pago
                If cambio >= 0 Then

                    .txtcambio.Text = cambio
                End If
            End With
        End If
    End Function
    Function guardarticket()
        With ticket
            If idruta <> 0 And iddestino <> 0 And (.txtefectivo.EditValue >= .txtpago.EditValue) Then

                Dim idtick As Integer = Val(.TicketTableAdapter.maxid)
                If idtick = 0 Then
                    idtick = .OpcionesTableAdapter.GetData().Item(0).nticket
                Else
                    idtick += 1
                End If
                Dim ticn As String
                If Len(Trim(Str(idtick))) = 1 Then
                    ticn = "0000000" + Trim(Str(idtick))
                ElseIf Len(Trim(Str(idtick))) = 2 Then
                    ticn = "000000" + Trim(Str(idtick))
                ElseIf Len(Trim(Str(idtick))) = 3 Then
                    ticn = "00000" + Trim(Str(idtick))
                ElseIf Len(Trim(Str(idtick))) = 4 Then
                    ticn = "0000" + Trim(Str(idtick))
                ElseIf Len(Trim(Str(idtick))) = 5 Then
                    ticn = "000" + Trim(Str(idtick))
                ElseIf Len(Trim(Str(idtick))) = 6 Then
                    ticn = "00" + Trim(Str(idtick))
                ElseIf Len(Trim(Str(idtick))) = 7 Then
                    ticn = "0" + Trim(Str(idtick))
                Else
                    ticn = Trim(Str(idtick))
                End If

                Dim codtick As String = .OpcionesTableAdapter.GetData().Item(0).codticket
                Dim rangfech As String = .OpcionesTableAdapter.GetData().Item(0).rango1 + "-" + .OpcionesTableAdapter.GetData().Item(0).rango2
                .TicketTableAdapter.nuevoticket(idtick, codtick, ticn, rangfech, idruta, iddestino, .txtprecio.Text, .txthora.Text, iddescuento, .txtdesc.Text, .txtpago.Text, .txtefectivo.Text, .txtcambio.Text, .txtfecha.Text, idbus, .cbodesc.Text)
                MsgBox("Ticket registrado", MsgBoxStyle.Information, "Proceso terminado")
                filtro = "idticket=" + Str(idtick)
                report = 5
                informe.Show()
            Else
                MsgBox("Ha dejado campos incompletos", MsgBoxStyle.Critical, "Proceso terminado")
            End If
        End With
    End Function
End Module
