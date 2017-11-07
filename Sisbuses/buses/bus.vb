Public Class bus 
    Private Sub bus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.bus' Puede moverla o quitarla según sea necesario.
        cargarbus()
    End Sub
    Private Sub cmdguardar_Click(sender As Object, e As EventArgs) Handles cmdguardar.Click
        guardarbus()
    End Sub
    Private Sub cmdnuevo_Click(sender As Object, e As EventArgs) Handles cmdnuevo.Click
        nuevobus()
    End Sub
    Private Sub cmdpri_Click(sender As Object, e As EventArgs) Handles cmdpri.Click
        primerobus()
    End Sub
    Private Sub cmdatras_Click(sender As Object, e As EventArgs) Handles cmdatras.Click
        atrasbus()
    End Sub
    Private Sub cmdsig_Click(sender As Object, e As EventArgs) Handles cmdsig.Click
        adelantebus()
    End Sub
    Private Sub cmdult_Click(sender As Object, e As EventArgs) Handles cmdult.Click
        ultimobus()
    End Sub
    Private Sub cmdeliminar_Click(sender As Object, e As EventArgs) Handles cmdeliminar.Click
        eliminarbus()
    End Sub
    Private Sub cmdmodificar_Click(sender As Object, e As EventArgs) Handles cmdmodificar.Click
        editarbus()
    End Sub
    Private Sub cmdcancelar_Click(sender As Object, e As EventArgs) Handles cmdcancelar.Click
        cancelarbus()
    End Sub
    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter, GroupBox1.Validated
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("solo se admiten letras", "validacion de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


        End If
        Me.TextBox_Letras.CharacterCasing = CharacterCasing.Upper  ' para mayuculas
        Me.TextBox_Letras.CharacterCasing = CharacterCasing.Lower ' para minuscula 








        End If
    End Sub

    Private Sub GroupBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GroupBox1.Validating


    End Sub
End Class