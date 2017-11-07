Public Class tilemenu
    Private Sub TileItem1_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem1.ItemClick
        bus.ShowDialog()
    End Sub

    Private Sub TileItem4_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem4.ItemClick
        conductor.ShowDialog()
    End Sub

    Private Sub TileItem9_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem9.ItemClick
        ruta.ShowDialog()
    End Sub

    Private Sub TileItem10_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem10.ItemClick
        destino.ShowDialog()
    End Sub

    Private Sub TileItem14_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem14.ItemClick
        datosempresa.ShowDialog()
    End Sub

    Private Sub TileItem16_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem16.ItemClick
        respaldo.ShowDialog()
    End Sub

    Private Sub TileItem12_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem12.ItemClick
        regusuario.ShowDialog()
    End Sub

    Private Sub TileItem13_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem13.ItemClick
        clave.ShowDialog()
    End Sub

    Private Sub TileItem17_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem17.ItemClick
        horario.ShowDialog()
    End Sub

    Private Sub TileItem18_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem18.ItemClick
        consultahorario.ShowDialog()
    End Sub

    Private Sub TileItem19_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem19.ItemClick
        consulticket.ShowDialog()
    End Sub

    Private Sub TileItem11_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem11.ItemClick
        descuento.ShowDialog()
    End Sub

    Private Sub TileItem15_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem15.ItemClick
        busqgastos.ShowDialog()
    End Sub

    Private Sub tilemenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If perfil = "administrador" Then
            TileGroup2.Visible = True
            TileItem11.Visible = True
            TileItem12.Visible = True
            TileItem14.Visible = True
        Else
            TileGroup2.Visible = False
            TileItem11.Visible = False
            TileItem12.Visible = False
            TileItem14.Visible = False
        End If
    End Sub
End Class