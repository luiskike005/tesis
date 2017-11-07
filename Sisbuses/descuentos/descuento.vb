Public Class descuento 
    Private Sub cmdguardar_Click(sender As Object, e As EventArgs) Handles cmdguardar.Click
        guardardescuentos()
    End Sub
    Private Sub cmdnuevo_Click(sender As Object, e As EventArgs) Handles cmdnuevo.Click
        nuevodescuentos()
    End Sub
    Private Sub cmdpri_Click(sender As Object, e As EventArgs) Handles cmdpri.Click
        primerodescuentos()
    End Sub
    Private Sub cmdatras_Click(sender As Object, e As EventArgs) Handles cmdatras.Click
        atrasdescuentos()
    End Sub
    Private Sub cmdsig_Click(sender As Object, e As EventArgs) Handles cmdsig.Click
        adelantedescuentos()
    End Sub
    Private Sub cmdult_Click(sender As Object, e As EventArgs) Handles cmdult.Click
        ultimodescuentos()
    End Sub
    Private Sub cmdeliminar_Click(sender As Object, e As EventArgs) Handles cmdeliminar.Click
        eliminardescuentos()
    End Sub
    Private Sub cmdmodificar_Click(sender As Object, e As EventArgs) Handles cmdmodificar.Click
        editardescuentos()
    End Sub
    Private Sub cmdcancelar_Click(sender As Object, e As EventArgs) Handles cmdcancelar.Click
        cancelardescuentos()
    End Sub
    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        Close()
    End Sub
    Private Sub descuento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.descuentos' Puede moverla o quitarla según sea necesario.
        cargadescuentos()
    End Sub
End Class