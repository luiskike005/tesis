Public Class gasto 
    Private Sub cmdguardar_Click(sender As Object, e As EventArgs) Handles cmdguardar.Click
        guardargastos()
    End Sub
    Private Sub cmdnuevo_Click(sender As Object, e As EventArgs) Handles cmdnuevo.Click
        nuevogastos()
    End Sub
    Private Sub cmdpri_Click(sender As Object, e As EventArgs) Handles cmdpri.Click
        primerogastos()
    End Sub
    Private Sub cmdatras_Click(sender As Object, e As EventArgs) Handles cmdatras.Click
        atrasgastos()
    End Sub
    Private Sub cmdsig_Click(sender As Object, e As EventArgs) Handles cmdsig.Click
        adelantegastos()
    End Sub
    Private Sub cmdult_Click(sender As Object, e As EventArgs) Handles cmdult.Click
        ultimogastos()
    End Sub
    Private Sub cmdeliminar_Click(sender As Object, e As EventArgs) Handles cmdeliminar.Click
        eliminargastos()
    End Sub
    Private Sub cmdmodificar_Click(sender As Object, e As EventArgs) Handles cmdmodificar.Click
        editargastos()
    End Sub
    Private Sub cmdcancelar_Click(sender As Object, e As EventArgs) Handles cmdcancelar.Click
        cancelargastos()
    End Sub
    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        Close()
    End Sub
    Private Sub descuento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Dtsisbus.descuentos' Puede moverla o quitarla según sea necesario.
        cargagastos()
    End Sub

End Class