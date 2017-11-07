Imports System.IO
Imports System.Data.SqlClient 
Module drespaldo
    Dim con, con1 As SqlConnection
    Dim cmd As SqlCommand
    Dim dread As SqlDataReader
    Function carga()
        If respaldo.txtdireccion2.Text = "" Then
            MsgBox("Debe ingresar una ruta valida", MsgBoxStyle.Critical, "Proceso terminado")
        Else
            Try
                con = New SqlConnection("Data Source=localhost;Initial Catalog=sisbus;Persist Security Info=True;User ID=sa;Password=hlmt6")
                con.Open()
                cmd = New SqlCommand("USE [master] ALTER DATABASE [sisbus] SET SINGLE_USER WITH ROLLBACK IMMEDIATE RESTORE DATABASE [sisbus] FROM DISK = N'" + respaldo.txtdireccion2.Text + "' WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 10 ALTER DATABASE [sisbus] SET MULTI_USER", con)



                cmd.ExecuteNonQuery()
                MsgBox("carga de base datos realizada con exito", MsgBoxStyle.Information, "Proceso terminado")
            Catch ex As Exception
                MsgBox("Falla al cargar base datos", MsgBoxStyle.Critical, "Proceso terminado")
            Finally
                con.Close()
            End Try
        End If
    End Function
    Function respaldod()
        If respaldo.txtdireccion1.Text = "" Then
            MsgBox("Debe ingresar una ruta valida", MsgBoxStyle.Critical, "Proceso terminado")
        Else
        Try
                con = New SqlConnection("Data Source=localhost;Initial Catalog=sisbus;Persist Security Info=True;User ID=sa;Password=hlmt6")
            con.Open()
                cmd = New SqlCommand("BACKUP DATABASE [sisbus] to disk=N'" + respaldo.txtdireccion1.Text + "\sistema.bak' WITH NOFORMAT, NOINIT,  NAME = N'sisbus-Completa Base de datos Copia de seguridad', SKIP, NOREWIND, NOUNLOAD,  STATS = 10", con)
            cmd.ExecuteNonQuery()
            MsgBox("Respaldo de base datos realizada con exito", MsgBoxStyle.Information, "Proceso terminado")
        Catch ex As Exception
                MsgBox("Direccion no valida para hacer respaldo", MsgBoxStyle.Critical, "Proceso terminado")
        Finally
            con.Close()
        End Try
        End If
    End Function
End Module
