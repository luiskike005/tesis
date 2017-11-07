Public Class ticket 

    Private Sub ticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
     
        nuevoticket()
    End Sub

  

    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        Close()
    End Sub

    Private Sub cbodestino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbodestino.SelectedIndexChanged
        calpre()
        caldesc()
        calpaos()
    End Sub

    Private Sub cbodesc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbodesc.SelectedIndexChanged
        caldesc()
        calpaos()
    End Sub

    Private Sub txtefectivo_EditValueChanged(sender As Object, e As EventArgs) Handles txtefectivo.EditValueChanged
        calpaos()
    End Sub

 
    Private Sub txtcanti_EditValueChanged(sender As Object, e As EventArgs)
        caldesc()
        calpaos()
    End Sub

    Private Sub cmdguardar_Click(sender As Object, e As EventArgs) Handles cmdguardar.Click
        guardarticket()
    End Sub

    Private Sub cbodesc_TextChanged(sender As Object, e As EventArgs) Handles cbodesc.TextChanged
        If cbodesc.Text = "" Then
            txtdesc.EditValue = 0.0
            Lblpor.Text = ""
            caldesc()
            calpaos()
        End If
    End Sub
End Class