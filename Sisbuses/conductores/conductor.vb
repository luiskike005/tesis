Public Class conductor 

  

    Private Sub conductor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.conductor' Puede moverla o quitarla según sea necesario.

        cargarconductor()
    End Sub
    Private Sub cmdguardar_Click(sender As Object, e As EventArgs) Handles cmdguardar.Click
        guardarconductor()
    End Sub
    Private Sub cmdnuevo_Click(sender As Object, e As EventArgs) Handles cmdnuevo.Click
        nuevoconductor()
    End Sub
    Private Sub cmdpri_Click(sender As Object, e As EventArgs) Handles cmdpri.Click
        primeroconductor()
    End Sub
    Private Sub cmdatras_Click(sender As Object, e As EventArgs) Handles cmdatras.Click
        atrasconductor()
    End Sub
    Private Sub cmdsig_Click(sender As Object, e As EventArgs) Handles cmdsig.Click
        adelanteconductor()
    End Sub
    Private Sub cmdult_Click(sender As Object, e As EventArgs) Handles cmdult.Click
        ultimoconductor()
    End Sub
    Private Sub cmdeliminar_Click(sender As Object, e As EventArgs) Handles cmdeliminar.Click
        eliminarconductor()
    End Sub
    Private Sub cmdmodificar_Click(sender As Object, e As EventArgs) Handles cmdmodificar.Click
        editarconductor()
    End Sub
    Private Sub cmdcancelar_Click(sender As Object, e As EventArgs) Handles cmdcancelar.Click
        cancelarconductor()
    End Sub
    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        Close()
    End Sub

    Private Sub txtconductor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtconductor.KeyPress
        'Si solo letras  usar IsLetter
        'Si solo letras  usar IsDigit
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class