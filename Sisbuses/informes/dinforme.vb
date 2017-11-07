Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data
Module dinforme

    Function cargareport()
        With informe
            'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.vistahorario' Puede moverla o quitarla según sea necesario.
            .VistahorarioTableAdapter.Fill(.Dtsisbus.vistahorario)
            'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.ruta' Puede moverla o quitarla según sea necesario.
            .RutaTableAdapter.Fill(.Dtsisbus.ruta)
            'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.destino' Puede moverla o quitarla según sea necesario.
            .DestinoTableAdapter.Fill(.Dtsisbus.destino)
            'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.horario' Puede moverla o quitarla según sea necesario.
            .HorarioTableAdapter.Fill(.Dtsisbus.horario)
            'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.gastos' Puede moverla o quitarla según sea necesario.
            .GastosTableAdapter.Fill(.Dtsisbus.gastos)
            .VistagastoTableAdapter.Fill(.Dtsisbus.vistagasto)
            .VistaticketTableAdapter.Fill(.Dtsisbus.vistaticket)

            Dim ds As New dtsisbus
            Dim cnn As SqlConnection
            Dim connectionString As String
            Dim sql, sql1 As String
            connectionString = "Data Source=localhost;Initial Catalog=sisbus;Integrated Security=True"
            cnn = New SqlConnection(connectionString)
            cnn.Open()       
            If report = 1 Then
                sql = "select * from ruta where " + filtro
                sql1 = "select * from destino where " + filtro
                Dim dscmd As New SqlDataAdapter(sql, cnn)
                dscmd.Fill(ds, "ruta")
                Dim dscmd1 As New SqlDataAdapter(sql1, cnn)
                dscmd1.Fill(ds, "destino")
                cnn.Close()
                Dim objRpt As New reportedestinos
                objRpt.SetDataSource(ds)
                .CrystalReportViewer1.ReportSource = objRpt
            End If
            If report = 2 Then
                If filtro = "" Then
                    sql = "select * from vistagasto "
                Else
                    sql = "select * from vistagasto where " + filtro
                End If

                Dim dscmd As New SqlDataAdapter(sql, cnn)
                dscmd.Fill(ds, "vistagasto")
                cnn.Close()
                Dim objRpt As New rgastos
                objRpt.SetDataSource(ds)
                .CrystalReportViewer1.ReportSource = objRpt
            End If
            If report = 3 Then
                sql = "select * from vistahorario"
                'where " + filtro"
                Dim dscmd As New SqlDataAdapter(sql, cnn)
                dscmd.Fill(ds, "vistahorario")
                cnn.Close()
                Dim objRpt As New rhorario
                objRpt.SetDataSource(ds)
                .CrystalReportViewer1.ReportSource = objRpt
            End If
            If report = 4 Then
                If Trim(filtro) = "" Then
                    sql = "select * from Vistaticket"
                Else
                    sql = "select * from Vistaticket where " + filtro
                End If
                Dim dscmd As New SqlDataAdapter(sql, cnn)
                dscmd.Fill(ds, "Vistaticket")
                cnn.Close()
                Dim objRpt As New listatickets
                objRpt.SetDataSource(ds)
                .CrystalReportViewer1.ReportSource = objRpt
            End If
            If report = 5 Then
                If Trim(filtro) = "" Then
                    sql = "select * from Vistaticket"
                Else
                    sql = "select * from Vistaticket where " + filtro
                End If
                Dim dscmd As New SqlDataAdapter(sql, cnn)
                dscmd.Fill(ds, "Vistaticket")
                cnn.Close()
                Dim objRpt As New tickets
                objRpt.SetDataSource(ds)
                .CrystalReportViewer1.ReportSource = objRpt
            End If
            .CrystalReportViewer1.Refresh()
        End With
    End Function
End Module
