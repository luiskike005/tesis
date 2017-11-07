<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class principal
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(principal))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.cmdbus = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdconductor = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdruta = New DevExpress.XtraBars.BarButtonItem()
        Me.cmddestino = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdusu = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdclave = New DevExpress.XtraBars.BarButtonItem()
        Me.cmddatos = New DevExpress.XtraBars.BarButtonItem()
        Me.cmddesc = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdconsticket = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdhorario = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdgastos = New DevExpress.XtraBars.BarButtonItem()
        Me.Cmdconhorario = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdbackup = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.cmdbus, Me.cmdconductor, Me.cmdruta, Me.cmddestino, Me.cmdusu, Me.cmdclave, Me.cmddatos, Me.cmddesc, Me.cmdconsticket, Me.cmdhorario, Me.cmdgastos, Me.Cmdconhorario, Me.cmdbackup})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 15
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(853, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'cmdbus
        '
        Me.cmdbus.Caption = "Registro de buses"
        Me.cmdbus.Glyph = CType(resources.GetObject("cmdbus.Glyph"), System.Drawing.Image)
        Me.cmdbus.Id = 1
        Me.cmdbus.LargeGlyph = Global.Sisbuses.My.Resources.Resources.bus_256
        Me.cmdbus.Name = "cmdbus"
        '
        'cmdconductor
        '
        Me.cmdconductor.Caption = "Registro de conductores"
        Me.cmdconductor.Glyph = CType(resources.GetObject("cmdconductor.Glyph"), System.Drawing.Image)
        Me.cmdconductor.Id = 2
        Me.cmdconductor.LargeGlyph = Global.Sisbuses.My.Resources.Resources.images
        Me.cmdconductor.Name = "cmdconductor"
        '
        'cmdruta
        '
        Me.cmdruta.Caption = "Registro de rutas"
        Me.cmdruta.Glyph = CType(resources.GetObject("cmdruta.Glyph"), System.Drawing.Image)
        Me.cmdruta.Id = 3
        Me.cmdruta.LargeGlyph = Global.Sisbuses.My.Resources.Resources.g
        Me.cmdruta.Name = "cmdruta"
        '
        'cmddestino
        '
        Me.cmddestino.Caption = "Registro destinos"
        Me.cmddestino.Glyph = CType(resources.GetObject("cmddestino.Glyph"), System.Drawing.Image)
        Me.cmddestino.Id = 4
        Me.cmddestino.LargeGlyph = Global.Sisbuses.My.Resources.Resources.images1
        Me.cmddestino.Name = "cmddestino"
        '
        'cmdusu
        '
        Me.cmdusu.Caption = "Registro usuarios"
        Me.cmdusu.Glyph = CType(resources.GetObject("cmdusu.Glyph"), System.Drawing.Image)
        Me.cmdusu.Id = 5
        Me.cmdusu.LargeGlyph = CType(resources.GetObject("cmdusu.LargeGlyph"), System.Drawing.Image)
        Me.cmdusu.Name = "cmdusu"
        '
        'cmdclave
        '
        Me.cmdclave.Caption = "Cambiar clave"
        Me.cmdclave.Glyph = CType(resources.GetObject("cmdclave.Glyph"), System.Drawing.Image)
        Me.cmdclave.Id = 6
        Me.cmdclave.LargeGlyph = CType(resources.GetObject("cmdclave.LargeGlyph"), System.Drawing.Image)
        Me.cmdclave.Name = "cmdclave"
        '
        'cmddatos
        '
        Me.cmddatos.Caption = "Datos Basicos"
        Me.cmddatos.Glyph = CType(resources.GetObject("cmddatos.Glyph"), System.Drawing.Image)
        Me.cmddatos.Id = 7
        Me.cmddatos.LargeGlyph = CType(resources.GetObject("cmddatos.LargeGlyph"), System.Drawing.Image)
        Me.cmddatos.Name = "cmddatos"
        '
        'cmddesc
        '
        Me.cmddesc.Caption = "Registro descuentos"
        Me.cmddesc.Glyph = CType(resources.GetObject("cmddesc.Glyph"), System.Drawing.Image)
        Me.cmddesc.Id = 8
        Me.cmddesc.LargeGlyph = CType(resources.GetObject("cmddesc.LargeGlyph"), System.Drawing.Image)
        Me.cmddesc.Name = "cmddesc"
        '
        'cmdconsticket
        '
        Me.cmdconsticket.Caption = "Consulta ticket"
        Me.cmdconsticket.Glyph = CType(resources.GetObject("cmdconsticket.Glyph"), System.Drawing.Image)
        Me.cmdconsticket.Id = 10
        Me.cmdconsticket.LargeGlyph = CType(resources.GetObject("cmdconsticket.LargeGlyph"), System.Drawing.Image)
        Me.cmdconsticket.Name = "cmdconsticket"
        '
        'cmdhorario
        '
        Me.cmdhorario.Caption = "Registro horario"
        Me.cmdhorario.Glyph = CType(resources.GetObject("cmdhorario.Glyph"), System.Drawing.Image)
        Me.cmdhorario.Id = 11
        Me.cmdhorario.LargeGlyph = CType(resources.GetObject("cmdhorario.LargeGlyph"), System.Drawing.Image)
        Me.cmdhorario.Name = "cmdhorario"
        '
        'cmdgastos
        '
        Me.cmdgastos.Caption = "Registro de gastos"
        Me.cmdgastos.Glyph = CType(resources.GetObject("cmdgastos.Glyph"), System.Drawing.Image)
        Me.cmdgastos.Id = 12
        Me.cmdgastos.LargeGlyph = CType(resources.GetObject("cmdgastos.LargeGlyph"), System.Drawing.Image)
        Me.cmdgastos.Name = "cmdgastos"
        '
        'Cmdconhorario
        '
        Me.Cmdconhorario.Caption = "Consulta horario"
        Me.Cmdconhorario.Glyph = CType(resources.GetObject("Cmdconhorario.Glyph"), System.Drawing.Image)
        Me.Cmdconhorario.Id = 13
        Me.Cmdconhorario.LargeGlyph = CType(resources.GetObject("Cmdconhorario.LargeGlyph"), System.Drawing.Image)
        Me.Cmdconhorario.Name = "Cmdconhorario"
        '
        'cmdbackup
        '
        Me.cmdbackup.Caption = "Backup"
        Me.cmdbackup.Glyph = CType(resources.GetObject("cmdbackup.Glyph"), System.Drawing.Image)
        Me.cmdbackup.Id = 14
        Me.cmdbackup.LargeGlyph = CType(resources.GetObject("cmdbackup.LargeGlyph"), System.Drawing.Image)
        Me.cmdbackup.Name = "cmdbackup"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3, Me.RibbonPageGroup5})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = " "
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.cmdbus)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.cmdconductor)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Buses/Conductores"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.cmdruta)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.cmddestino)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Rutas/Destinos"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.cmddesc)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.cmdusu)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.cmdclave)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.cmddatos)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.cmdgastos)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.cmdbackup)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Opciones basicas"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.cmdhorario)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.Cmdconhorario)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.cmdconsticket)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.Text = "Horario/Ticket"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 418)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(853, 31)
        '
        'principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 449)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "principal"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = " "
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents cmdbus As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdconductor As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdruta As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmddestino As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents cmdusu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdclave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmddatos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents cmddesc As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdconsticket As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdhorario As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents cmdgastos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Cmdconhorario As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdbackup As DevExpress.XtraBars.BarButtonItem

End Class
