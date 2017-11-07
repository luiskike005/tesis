<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class verticket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(verticket))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtpago = New DevExpress.XtraEditors.TextEdit()
        Me.VistaticketBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dtsisbus = New Sisbuses.dtsisbus()
        Me.txtcambio = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtefectivo = New DevExpress.XtraEditors.TextEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmdsalir = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtdescuento = New DevExpress.XtraEditors.TextEdit()
        Me.txtdestino = New DevExpress.XtraEditors.TextEdit()
        Me.txtruta = New DevExpress.XtraEditors.TextEdit()
        Me.Lblpor = New System.Windows.Forms.Label()
        Me.txthora = New DevExpress.XtraEditors.TextEdit()
        Me.txtdesc = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtfecha = New DevExpress.XtraEditors.DateEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtprecio = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VistaticketTableAdapter = New Sisbuses.dtsisbusTableAdapters.vistaticketTableAdapter()
        Me.TableAdapterManager = New Sisbuses.dtsisbusTableAdapters.TableAdapterManager()
        Me.NticketLabel1 = New System.Windows.Forms.Label()
        Me.cmdimprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtpago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaticketBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtsisbus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcambio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtefectivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtdescuento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdestino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtruta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txthora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtprecio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupBox2.Location = New System.Drawing.Point(3, 197)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(327, 65)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de pago:"
        '
        'txtpago
        '
        Me.txtpago.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VistaticketBindingSource, "pagob", True))
        Me.txtpago.Enabled = False
        Me.txtpago.Location = New System.Drawing.Point(5, 33)
        Me.txtpago.Name = "txtpago"
        Me.txtpago.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtpago.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtpago.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtpago.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtpago.Properties.Mask.EditMask = "n"
        Me.txtpago.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtpago.Size = New System.Drawing.Size(100, 20)
        Me.txtpago.TabIndex = 51
        '
        'VistaticketBindingSource
        '
        Me.VistaticketBindingSource.DataMember = "vistaticket"
        Me.VistaticketBindingSource.DataSource = Me.Dtsisbus
        '
        'Dtsisbus
        '
        Me.Dtsisbus.DataSetName = "dtsisbus"
        Me.Dtsisbus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtcambio
        '
        Me.txtcambio.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VistaticketBindingSource, "cambio", True))
        Me.txtcambio.Enabled = False
        Me.txtcambio.Location = New System.Drawing.Point(217, 33)
        Me.txtcambio.Name = "txtcambio"
        Me.txtcambio.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtcambio.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtcambio.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtcambio.Properties.AppearanceDisabled.Options.UseForeColor = True
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
        Me.txtefectivo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VistaticketBindingSource, "efectivoen", True))
        Me.txtefectivo.Enabled = False
        Me.txtefectivo.Location = New System.Drawing.Point(111, 33)
        Me.txtefectivo.Name = "txtefectivo"
        Me.txtefectivo.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtefectivo.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtefectivo.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtefectivo.Properties.AppearanceDisabled.Options.UseForeColor = True
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
        'cmdsalir
        '
        Me.cmdsalir.Image = CType(resources.GetObject("cmdsalir.Image"), System.Drawing.Image)
        Me.cmdsalir.Location = New System.Drawing.Point(445, 201)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(102, 61)
        Me.cmdsalir.TabIndex = 55
        Me.cmdsalir.Text = "Salir"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(152, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(65, 24)
        Me.LabelControl1.TabIndex = 53
        Me.LabelControl1.Text = "Ticket#"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtdescuento)
        Me.GroupBox1.Controls.Add(Me.txtdestino)
        Me.GroupBox1.Controls.Add(Me.txtruta)
        Me.GroupBox1.Controls.Add(Me.Lblpor)
        Me.GroupBox1.Controls.Add(Me.txthora)
        Me.GroupBox1.Controls.Add(Me.txtdesc)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtfecha)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtprecio)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(3, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(542, 154)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del ticket:"
        '
        'txtdescuento
        '
        Me.txtdescuento.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VistaticketBindingSource, "descuento", True))
        Me.txtdescuento.Enabled = False
        Me.txtdescuento.Location = New System.Drawing.Point(5, 120)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtdescuento.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtdescuento.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtdescuento.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtdescuento.Size = New System.Drawing.Size(312, 20)
        Me.txtdescuento.TabIndex = 55
        '
        'txtdestino
        '
        Me.txtdestino.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VistaticketBindingSource, "destino", True))
        Me.txtdestino.Enabled = False
        Me.txtdestino.Location = New System.Drawing.Point(5, 80)
        Me.txtdestino.Name = "txtdestino"
        Me.txtdestino.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtdestino.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtdestino.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtdestino.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtdestino.Size = New System.Drawing.Size(312, 20)
        Me.txtdestino.TabIndex = 54
        '
        'txtruta
        '
        Me.txtruta.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VistaticketBindingSource, "ruta", True))
        Me.txtruta.Enabled = False
        Me.txtruta.Location = New System.Drawing.Point(5, 40)
        Me.txtruta.Name = "txtruta"
        Me.txtruta.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtruta.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtruta.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtruta.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtruta.Size = New System.Drawing.Size(312, 20)
        Me.txtruta.TabIndex = 53
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
        Me.txthora.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VistaticketBindingSource, "hora", True))
        Me.txthora.Enabled = False
        Me.txthora.Location = New System.Drawing.Point(320, 41)
        Me.txthora.Name = "txthora"
        Me.txthora.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txthora.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txthora.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txthora.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txthora.Size = New System.Drawing.Size(105, 20)
        Me.txthora.TabIndex = 51
        '
        'txtdesc
        '
        Me.txtdesc.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VistaticketBindingSource, "preciodesc", True))
        Me.txtdesc.Enabled = False
        Me.txtdesc.Location = New System.Drawing.Point(321, 124)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtdesc.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtdesc.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtdesc.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtdesc.Properties.Mask.EditMask = "n"
        Me.txtdesc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtdesc.Size = New System.Drawing.Size(100, 20)
        Me.txtdesc.TabIndex = 50
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
        Me.txtfecha.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VistaticketBindingSource, "fecha", True))
        Me.txtfecha.EditValue = Nothing
        Me.txtfecha.Enabled = False
        Me.txtfecha.Location = New System.Drawing.Point(431, 41)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtfecha.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtfecha.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtfecha.Properties.AppearanceDisabled.Options.UseForeColor = True
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
        Me.txtprecio.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VistaticketBindingSource, "preciob", True))
        Me.txtprecio.Enabled = False
        Me.txtprecio.Location = New System.Drawing.Point(320, 80)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtprecio.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtprecio.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtprecio.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtprecio.Properties.Mask.EditMask = "n"
        Me.txtprecio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtprecio.Size = New System.Drawing.Size(100, 20)
        Me.txtprecio.TabIndex = 45
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
        Me.Label4.Location = New System.Drawing.Point(330, 63)
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
        'VistaticketTableAdapter
        '
        Me.VistaticketTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.busTableAdapter = Nothing
        Me.TableAdapterManager.conductorTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.descuentosTableAdapter = Nothing
        Me.TableAdapterManager.destinoTableAdapter = Nothing
        Me.TableAdapterManager.gastosTableAdapter = Nothing
        Me.TableAdapterManager.horarioTableAdapter = Nothing
        Me.TableAdapterManager.opcionesTableAdapter = Nothing
        Me.TableAdapterManager.rutaTableAdapter = Nothing
        Me.TableAdapterManager.ticketTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sisbuses.dtsisbusTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'NticketLabel1
        '
        Me.NticketLabel1.AutoSize = True
        Me.NticketLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VistaticketBindingSource, "nticket", True))
        Me.NticketLabel1.Font = New System.Drawing.Font("Tahoma", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NticketLabel1.ForeColor = System.Drawing.Color.Red
        Me.NticketLabel1.Location = New System.Drawing.Point(218, 9)
        Me.NticketLabel1.Name = "NticketLabel1"
        Me.NticketLabel1.Size = New System.Drawing.Size(92, 29)
        Me.NticketLabel1.TabIndex = 59
        Me.NticketLabel1.Text = "Label9"
        '
        'cmdimprimir
        '
        Me.cmdimprimir.Image = CType(resources.GetObject("cmdimprimir.Image"), System.Drawing.Image)
        Me.cmdimprimir.Location = New System.Drawing.Point(337, 201)
        Me.cmdimprimir.Name = "cmdimprimir"
        Me.cmdimprimir.Size = New System.Drawing.Size(102, 61)
        Me.cmdimprimir.TabIndex = 60
        Me.cmdimprimir.Text = "Imprimir"
        '
        'verticket
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Appearance.ForeColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 270)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdimprimir)
        Me.Controls.Add(Me.NticketLabel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdsalir)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "verticket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtpago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaticketBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtsisbus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcambio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtefectivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtdescuento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdestino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtruta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txthora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtprecio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtpago As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtcambio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtefectivo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmdsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Lblpor As System.Windows.Forms.Label
    Friend WithEvents txthora As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtdesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtfecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtprecio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Dtsisbus As Sisbuses.dtsisbus
    Friend WithEvents VistaticketBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VistaticketTableAdapter As Sisbuses.dtsisbusTableAdapters.vistaticketTableAdapter
    Friend WithEvents TableAdapterManager As Sisbuses.dtsisbusTableAdapters.TableAdapterManager
    Friend WithEvents NticketLabel1 As System.Windows.Forms.Label
    Friend WithEvents txtdescuento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtdestino As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtruta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdimprimir As DevExpress.XtraEditors.SimpleButton
End Class
