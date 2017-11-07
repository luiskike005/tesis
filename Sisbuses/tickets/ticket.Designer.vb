<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ticket
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ticket))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Lblpor = New System.Windows.Forms.Label()
        Me.txthora = New DevExpress.XtraEditors.TextEdit()
        Me.txtdesc = New DevExpress.XtraEditors.TextEdit()
        Me.cbodesc = New System.Windows.Forms.ComboBox()
        Me.DescuentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dtsisbus = New Sisbuses.dtsisbus()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtfecha = New DevExpress.XtraEditors.DateEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtprecio = New DevExpress.XtraEditors.TextEdit()
        Me.cbodestino = New System.Windows.Forms.ComboBox()
        Me.DestinoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboruta = New System.Windows.Forms.ComboBox()
        Me.RutaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdguardar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdsalir = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtpago = New DevExpress.XtraEditors.TextEdit()
        Me.txtcambio = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtefectivo = New DevExpress.XtraEditors.TextEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.RutaTableAdapter = New Sisbuses.dtsisbusTableAdapters.rutaTableAdapter()
        Me.DestinoTableAdapter = New Sisbuses.dtsisbusTableAdapters.destinoTableAdapter()
        Me.DescuentosTableAdapter = New Sisbuses.dtsisbusTableAdapters.descuentosTableAdapter()
        Me.TicketBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TicketTableAdapter = New Sisbuses.dtsisbusTableAdapters.ticketTableAdapter()
        Me.TableAdapterManager = New Sisbuses.dtsisbusTableAdapters.TableAdapterManager()
        Me.OpcionesTableAdapter = New Sisbuses.dtsisbusTableAdapters.opcionesTableAdapter()
        Me.OpcionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.txthora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescuentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtsisbus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtprecio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RutaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtpago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcambio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtefectivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpcionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Location = New System.Drawing.Point(233, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 24)
        Me.LabelControl1.TabIndex = 44
        Me.LabelControl1.Text = "Ticket"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Lblpor)
        Me.GroupBox1.Controls.Add(Me.txthora)
        Me.GroupBox1.Controls.Add(Me.txtdesc)
        Me.GroupBox1.Controls.Add(Me.cbodesc)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtfecha)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtprecio)
        Me.GroupBox1.Controls.Add(Me.cbodestino)
        Me.GroupBox1.Controls.Add(Me.cboruta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(2, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(542, 154)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del ticket:"
        '
        'Lblpor
        '
        Me.Lblpor.AutoSize = True
        Me.Lblpor.BackColor = System.Drawing.Color.Transparent
        Me.Lblpor.Location = New System.Drawing.Point(269, 127)
        Me.Lblpor.Name = "Lblpor"
        Me.Lblpor.Size = New System.Drawing.Size(0, 13)
        Me.Lblpor.TabIndex = 52
        '
        'txthora
        '
        Me.txthora.Enabled = False
        Me.txthora.Location = New System.Drawing.Point(320, 41)
        Me.txthora.Name = "txthora"
        Me.txthora.Size = New System.Drawing.Size(105, 20)
        Me.txthora.TabIndex = 51
        '
        'txtdesc
        '
        Me.txtdesc.Enabled = False
        Me.txtdesc.Location = New System.Drawing.Point(321, 124)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Properties.Mask.EditMask = "n"
        Me.txtdesc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtdesc.Size = New System.Drawing.Size(100, 20)
        Me.txtdesc.TabIndex = 50
        '
        'cbodesc
        '
        Me.cbodesc.DataSource = Me.DescuentosBindingSource
        Me.cbodesc.DisplayMember = "tipodesc"
        Me.cbodesc.FormattingEnabled = True
        Me.cbodesc.Location = New System.Drawing.Point(5, 120)
        Me.cbodesc.Name = "cbodesc"
        Me.cbodesc.Size = New System.Drawing.Size(258, 21)
        Me.cbodesc.TabIndex = 49
        Me.cbodesc.ValueMember = "iddesc"
        '
        'DescuentosBindingSource
        '
        Me.DescuentosBindingSource.DataMember = "descuentos"
        Me.DescuentosBindingSource.DataSource = Me.Dtsisbus
        '
        'Dtsisbus
        '
        Me.Dtsisbus.DataSetName = "dtsisbus"
        Me.Dtsisbus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(6, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Descuento:"
        '
        'txtfecha
        '
        Me.txtfecha.EditValue = Nothing
        Me.txtfecha.Location = New System.Drawing.Point(431, 41)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtfecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtfecha.Size = New System.Drawing.Size(100, 20)
        Me.txtfecha.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(441, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Fecha:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(331, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Descuento L:"
        '
        'txtprecio
        '
        Me.txtprecio.Enabled = False
        Me.txtprecio.Location = New System.Drawing.Point(320, 81)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Properties.Mask.EditMask = "n"
        Me.txtprecio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtprecio.Size = New System.Drawing.Size(100, 20)
        Me.txtprecio.TabIndex = 45
        '
        'cbodestino
        '
        Me.cbodestino.DataSource = Me.DestinoBindingSource
        Me.cbodestino.DisplayMember = "destino"
        Me.cbodestino.FormattingEnabled = True
        Me.cbodestino.Location = New System.Drawing.Point(6, 80)
        Me.cbodestino.Name = "cbodestino"
        Me.cbodestino.Size = New System.Drawing.Size(309, 21)
        Me.cbodestino.TabIndex = 44
        Me.cbodestino.ValueMember = "iddestino"
        '
        'DestinoBindingSource
        '
        Me.DestinoBindingSource.DataMember = "destino"
        Me.DestinoBindingSource.DataSource = Me.Dtsisbus
        '
        'cboruta
        '
        Me.cboruta.DataSource = Me.RutaBindingSource
        Me.cboruta.DisplayMember = "ruta"
        Me.cboruta.FormattingEnabled = True
        Me.cboruta.Location = New System.Drawing.Point(5, 40)
        Me.cboruta.Name = "cboruta"
        Me.cboruta.Size = New System.Drawing.Size(309, 21)
        Me.cboruta.TabIndex = 42
        Me.cboruta.ValueMember = "idruta"
        '
        'RutaBindingSource
        '
        Me.RutaBindingSource.DataMember = "ruta"
        Me.RutaBindingSource.DataSource = Me.Dtsisbus
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(7, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Destino:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(324, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Hora:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(318, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Precio boleto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(2, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Ruta:"
        '
        'cmdguardar
        '
        Me.cmdguardar.Image = CType(resources.GetObject("cmdguardar.Image"), System.Drawing.Image)
        Me.cmdguardar.Location = New System.Drawing.Point(335, 203)
        Me.cmdguardar.Name = "cmdguardar"
        Me.cmdguardar.Size = New System.Drawing.Size(101, 59)
        Me.cmdguardar.TabIndex = 45
        Me.cmdguardar.Text = "Registrar"
        '
        'cmdsalir
        '
        Me.cmdsalir.Image = CType(resources.GetObject("cmdsalir.Image"), System.Drawing.Image)
        Me.cmdsalir.Location = New System.Drawing.Point(442, 202)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(102, 61)
        Me.cmdsalir.TabIndex = 46
        Me.cmdsalir.Text = "Salir"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.txtpago)
        Me.GroupBox2.Controls.Add(Me.txtcambio)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtefectivo)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(2, 198)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(327, 65)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de pago:"
        '
        'txtpago
        '
        Me.txtpago.Enabled = False
        Me.txtpago.Location = New System.Drawing.Point(5, 33)
        Me.txtpago.Name = "txtpago"
        Me.txtpago.Properties.Mask.EditMask = "n"
        Me.txtpago.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtpago.Size = New System.Drawing.Size(100, 20)
        Me.txtpago.TabIndex = 51
        '
        'txtcambio
        '
        Me.txtcambio.Enabled = False
        Me.txtcambio.Location = New System.Drawing.Point(217, 33)
        Me.txtcambio.Name = "txtcambio"
        Me.txtcambio.Properties.Mask.EditMask = "n"
        Me.txtcambio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtcambio.Size = New System.Drawing.Size(100, 20)
        Me.txtcambio.TabIndex = 50
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(217, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Cambio:"
        '
        'txtefectivo
        '
        Me.txtefectivo.Location = New System.Drawing.Point(111, 33)
        Me.txtefectivo.Name = "txtefectivo"
        Me.txtefectivo.Properties.Mask.EditMask = "n"
        Me.txtefectivo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtefectivo.Size = New System.Drawing.Size(100, 20)
        Me.txtefectivo.TabIndex = 45
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(108, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 13)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Efectivo entregado:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(2, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 13)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Total a pagar:"
        '
        'RutaTableAdapter
        '
        Me.RutaTableAdapter.ClearBeforeFill = True
        '
        'DestinoTableAdapter
        '
        Me.DestinoTableAdapter.ClearBeforeFill = True
        '
        'DescuentosTableAdapter
        '
        Me.DescuentosTableAdapter.ClearBeforeFill = True
        '
        'TicketBindingSource
        '
        Me.TicketBindingSource.DataMember = "ticket"
        Me.TicketBindingSource.DataSource = Me.Dtsisbus
        '
        'TicketTableAdapter
        '
        Me.TicketTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.busTableAdapter = Nothing
        Me.TableAdapterManager.conductorTableAdapter = Nothing
        Me.TableAdapterManager.descuentosTableAdapter = Me.DescuentosTableAdapter
        Me.TableAdapterManager.destinoTableAdapter = Me.DestinoTableAdapter
        Me.TableAdapterManager.gastosTableAdapter = Nothing
        Me.TableAdapterManager.horarioTableAdapter = Nothing
        Me.TableAdapterManager.opcionesTableAdapter = Me.OpcionesTableAdapter
        Me.TableAdapterManager.rutaTableAdapter = Me.RutaTableAdapter
        Me.TableAdapterManager.ticketTableAdapter = Me.TicketTableAdapter
        Me.TableAdapterManager.UpdateOrder = Sisbuses.dtsisbusTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'OpcionesTableAdapter
        '
        Me.OpcionesTableAdapter.ClearBeforeFill = True
        '
        'OpcionesBindingSource
        '
        Me.OpcionesBindingSource.DataMember = "opciones"
        Me.OpcionesBindingSource.DataSource = Me.Dtsisbus
        '
        'ticket
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 264)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdguardar)
        Me.Controls.Add(Me.cmdsalir)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ticket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txthora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescuentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtsisbus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtprecio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RutaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtpago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcambio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtefectivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpcionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtdesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbodesc As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtfecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtprecio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbodestino As System.Windows.Forms.ComboBox
    Friend WithEvents cboruta As System.Windows.Forms.ComboBox
    Friend WithEvents cmdguardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtpago As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtcambio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtefectivo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Dtsisbus As Sisbuses.dtsisbus
    Friend WithEvents RutaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RutaTableAdapter As Sisbuses.dtsisbusTableAdapters.rutaTableAdapter
    Friend WithEvents DestinoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DestinoTableAdapter As Sisbuses.dtsisbusTableAdapters.destinoTableAdapter
    Friend WithEvents DescuentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DescuentosTableAdapter As Sisbuses.dtsisbusTableAdapters.descuentosTableAdapter
    Friend WithEvents TicketBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As Sisbuses.dtsisbusTableAdapters.TableAdapterManager
    Friend WithEvents OpcionesTableAdapter As Sisbuses.dtsisbusTableAdapters.opcionesTableAdapter
    Friend WithEvents OpcionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txthora As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Lblpor As System.Windows.Forms.Label
    Friend WithEvents TicketTableAdapter As Sisbuses.dtsisbusTableAdapters.ticketTableAdapter
End Class
