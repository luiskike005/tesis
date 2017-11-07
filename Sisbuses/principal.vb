Public Class principal 

    Private Sub cmdbus_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdbus.ItemClick
        bus.ShowDialog()
    End Sub

    Private Sub cmdconductor_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdconductor.ItemClick
        conductor.ShowDialog()
    End Sub

    Private Sub cmdruta_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdruta.ItemClick
        ruta.ShowDialog()
    End Sub

    Private Sub cmddestino_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmddestino.ItemClick
        destino.ShowDialog()
    End Sub

    Private Sub cmddesc_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmddesc.ItemClick
        descuento.ShowDialog()
    End Sub

    Private Sub cmdusu_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdusu.ItemClick
        regusuario.ShowDialog()
    End Sub

    Private Sub cmdclave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdclave.ItemClick
        clave.ShowDialog()
    End Sub

    Private Sub cmddatos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmddatos.ItemClick
        datosempresa.ShowDialog()
    End Sub

    Private Sub cmdgastos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdgastos.ItemClick
        busqgastos.ShowDialog()
    End Sub

    Private Sub cmdhorario_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdhorario.ItemClick
        horario.ShowDialog()
    End Sub

   

    Private Sub cmdticket_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        ticket.ShowDialog()
    End Sub

    Private Sub Cmdconhorario_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Cmdconhorario.ItemClick
        consultahorario.ShowDialog()
    End Sub

    Private Sub cmdconsticket_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdconsticket.ItemClick
        consulticket.ShowDialog()
    End Sub

    Private Sub principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If perfil = "administrador" Then
            RibbonPageGroup1.Visible = True
            RibbonPageGroup2.Visible = True
            cmddesc.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            cmdusu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            cmddatos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Else
            RibbonPageGroup1.Visible = False
            RibbonPageGroup2.Visible = False

            cmddesc.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            cmdusu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            cmddatos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
    End Sub

    Private Sub cmdbackup_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdbackup.ItemClick
        respaldo.ShowDialog()
    End Sub
End Class