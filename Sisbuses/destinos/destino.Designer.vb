<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class destino
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(destino))
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule4 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdimprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdeliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdsalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdmodificar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdagregar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtdestino = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtprecio = New DevExpress.XtraEditors.SpinEdit()
        Me.txtabrdestino = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dxblanco = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.txta = New DevExpress.XtraEditors.TextEdit()
        Me.txtd = New DevExpress.XtraEditors.TextEdit()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdnuevor = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdcargar = New DevExpress.XtraEditors.SimpleButton()
        Me.cboruta = New System.Windows.Forms.ComboBox()
        Me.RutaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dtsisbus = New Sisbuses.dtsisbus()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RutaTableAdapter = New Sisbuses.dtsisbusTableAdapters.rutaTableAdapter()
        Me.TableAdapterManager = New Sisbuses.dtsisbusTableAdapters.TableAdapterManager()
        Me.DestinoTableAdapter = New Sisbuses.dtsisbusTableAdapters.destinoTableAdapter()
        Me.DestinoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridDestino = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grupodestino = New DevExpress.XtraEditors.GroupControl()
        Me.cmdguardar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdcancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtp = New DevExpress.XtraEditors.SpinEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtdestino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtprecio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtabrdestino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dxblanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.RutaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtsisbus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grupodestino, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupodestino.SuspendLayout()
        CType(Me.txtp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Location = New System.Drawing.Point(186, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(232, 24)
        Me.LabelControl1.TabIndex = 52
        Me.LabelControl1.Text = "Registro Destinos de Rutas"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdimprimir)
        Me.GroupBox3.Controls.Add(Me.cmdeliminar)
        Me.GroupBox3.Controls.Add(Me.cmdsalir)
        Me.GroupBox3.Controls.Add(Me.cmdmodificar)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(522, 185)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(107, 189)
        Me.GroupBox3.TabIndex = 51
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones:"
        '
        'cmdimprimir
        '
        Me.cmdimprimir.Image = CType(resources.GetObject("cmdimprimir.Image"), System.Drawing.Image)
        Me.cmdimprimir.Location = New System.Drawing.Point(7, 100)
        Me.cmdimprimir.Name = "cmdimprimir"
        Me.cmdimprimir.Size = New System.Drawing.Size(92, 41)
        Me.cmdimprimir.TabIndex = 10
        Me.cmdimprimir.Text = "Imprimir"
        '
        'cmdeliminar
        '
        Me.cmdeliminar.Image = CType(resources.GetObject("cmdeliminar.Image"), System.Drawing.Image)
        Me.cmdeliminar.Location = New System.Drawing.Point(7, 60)
        Me.cmdeliminar.Name = "cmdeliminar"
        Me.cmdeliminar.Size = New System.Drawing.Size(92, 41)
        Me.cmdeliminar.TabIndex = 9
        Me.cmdeliminar.Text = "Eliminar"
        '
        'cmdsalir
        '
        Me.cmdsalir.Image = CType(resources.GetObject("cmdsalir.Image"), System.Drawing.Image)
        Me.cmdsalir.Location = New System.Drawing.Point(7, 140)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(92, 41)
        Me.cmdsalir.TabIndex = 6
        Me.cmdsalir.Text = "Salir"
        '
        'cmdmodificar
        '
        Me.cmdmodificar.Image = CType(resources.GetObject("cmdmodificar.Image"), System.Drawing.Image)
        Me.cmdmodificar.Location = New System.Drawing.Point(7, 20)
        Me.cmdmodificar.Name = "cmdmodificar"
        Me.cmdmodificar.Size = New System.Drawing.Size(92, 41)
        Me.cmdmodificar.TabIndex = 1
        Me.cmdmodificar.Text = "Modificar"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cmdagregar)
        Me.GroupBox1.Controls.Add(Me.txtdestino)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtprecio)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(617, 63)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de rutas:"
        '
        'cmdagregar
        '
        Me.cmdagregar.Image = CType(resources.GetObject("cmdagregar.Image"), System.Drawing.Image)
        Me.cmdagregar.Location = New System.Drawing.Point(384, 31)
        Me.cmdagregar.Name = "cmdagregar"
        Me.cmdagregar.Size = New System.Drawing.Size(106, 25)
        Me.cmdagregar.TabIndex = 27
        Me.cmdagregar.Text = "Agregar Destino"
        '
        'txtdestino
        '
        Me.txtdestino.Location = New System.Drawing.Point(6, 34)
        Me.txtdestino.Name = "txtdestino"
        Me.txtdestino.Size = New System.Drawing.Size(250, 20)
        Me.txtdestino.TabIndex = 35
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Este campo no puede quedar vacio"
        ConditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.Dxblanco.SetValidationRule(Me.txtdestino, ConditionValidationRule1)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(259, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Precio boleto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(6, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Destino:"
        '
        'txtprecio
        '
        Me.txtprecio.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtprecio.Location = New System.Drawing.Point(262, 34)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtprecio.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtprecio.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtprecio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtprecio.Size = New System.Drawing.Size(116, 20)
        Me.txtprecio.TabIndex = 36
        '
        'txtabrdestino
        '
        Me.txtabrdestino.Location = New System.Drawing.Point(653, 25)
        Me.txtabrdestino.Name = "txtabrdestino"
        Me.txtabrdestino.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtabrdestino.Size = New System.Drawing.Size(116, 20)
        Me.txtabrdestino.TabIndex = 38
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Este campo no puede quedar vacio"
        ConditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.Dxblanco.SetValidationRule(Me.txtabrdestino, ConditionValidationRule2)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(653, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Abreviatura Destino:"
        '
        'txta
        '
        Me.txta.Location = New System.Drawing.Point(665, 25)
        Me.txta.Name = "txta"
        Me.txta.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txta.Size = New System.Drawing.Size(116, 20)
        Me.txta.TabIndex = 40
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Este campo no puede quedar vacio"
        ConditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.Dxblanco.SetValidationRule(Me.txta, ConditionValidationRule3)
        '
        'txtd
        '
        Me.txtd.Location = New System.Drawing.Point(5, 47)
        Me.txtd.Name = "txtd"
        Me.txtd.Size = New System.Drawing.Size(199, 20)
        Me.txtd.TabIndex = 37
        ConditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule4.ErrorText = "Este campo no puede quedar vacio"
        ConditionValidationRule4.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.Dxblanco.SetValidationRule(Me.txtd, ConditionValidationRule4)
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.cmdnuevor)
        Me.GroupBox2.Controls.Add(Me.cmdcargar)
        Me.GroupBox2.Controls.Add(Me.cboruta)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(617, 68)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de rutas:"
        '
        'cmdnuevor
        '
        Me.cmdnuevor.Image = CType(resources.GetObject("cmdnuevor.Image"), System.Drawing.Image)
        Me.cmdnuevor.Location = New System.Drawing.Point(472, 32)
        Me.cmdnuevor.Name = "cmdnuevor"
        Me.cmdnuevor.Size = New System.Drawing.Size(106, 25)
        Me.cmdnuevor.TabIndex = 27
        Me.cmdnuevor.Text = "Nueva Ruta"
        '
        'cmdcargar
        '
        Me.cmdcargar.Image = CType(resources.GetObject("cmdcargar.Image"), System.Drawing.Image)
        Me.cmdcargar.Location = New System.Drawing.Point(360, 32)
        Me.cmdcargar.Name = "cmdcargar"
        Me.cmdcargar.Size = New System.Drawing.Size(106, 25)
        Me.cmdcargar.TabIndex = 10
        Me.cmdcargar.Text = "Cargar Destinos"
        '
        'cboruta
        '
        Me.cboruta.DataSource = Me.RutaBindingSource
        Me.cboruta.DisplayMember = "ruta"
        Me.cboruta.FormattingEnabled = True
        Me.cboruta.Location = New System.Drawing.Point(9, 34)
        Me.cboruta.Name = "cboruta"
        Me.cboruta.Size = New System.Drawing.Size(345, 21)
        Me.cboruta.TabIndex = 26
        Me.cboruta.ValueMember = "idruta"
        '
        'RutaBindingSource
        '
        Me.RutaBindingSource.DataMember = "ruta"
        Me.RutaBindingSource.DataSource = Me.Dtsisbus
        '
        'Dtsisbus
        '
        Me.Dtsisbus.DataSetName = "dtsisbus"
        Me.Dtsisbus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(6, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Ruta:"
        '
        'RutaTableAdapter
        '
        Me.RutaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.busTableAdapter = Nothing
        Me.TableAdapterManager.conductorTableAdapter = Nothing
        Me.TableAdapterManager.descuentosTableAdapter = Nothing
        Me.TableAdapterManager.destinoTableAdapter = Me.DestinoTableAdapter
        Me.TableAdapterManager.gastosTableAdapter = Nothing
        Me.TableAdapterManager.horarioTableAdapter = Nothing
        Me.TableAdapterManager.opcionesTableAdapter = Nothing
        Me.TableAdapterManager.rutaTableAdapter = Me.RutaTableAdapter
        Me.TableAdapterManager.ticketTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sisbuses.dtsisbusTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'DestinoTableAdapter
        '
        Me.DestinoTableAdapter.ClearBeforeFill = True
        '
        'DestinoBindingSource
        '
        Me.DestinoBindingSource.DataMember = "destino"
        Me.DestinoBindingSource.DataSource = Me.Dtsisbus
        '
        'gridDestino
        '
        Me.gridDestino.AllowUserToAddRows = False
        Me.gridDestino.AllowUserToDeleteRows = False
        Me.gridDestino.AutoGenerateColumns = False
        Me.gridDestino.BackgroundColor = System.Drawing.Color.White
        Me.gridDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridDestino.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.gridDestino.DataSource = Me.DestinoBindingSource
        Me.gridDestino.Location = New System.Drawing.Point(12, 185)
        Me.gridDestino.Name = "gridDestino"
        Me.gridDestino.ReadOnly = True
        Me.gridDestino.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridDestino.Size = New System.Drawing.Size(508, 220)
        Me.gridDestino.TabIndex = 52
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "iddestino"
        Me.DataGridViewTextBoxColumn1.HeaderText = "iddestino"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 5
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "destino"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Destino"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "abrdestino"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Abreviatura"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 5
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Precio Boleto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "fechacreacion"
        Me.DataGridViewTextBoxColumn5.HeaderText = "fechacreacion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 5
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "idruta"
        Me.DataGridViewTextBoxColumn6.HeaderText = "idruta"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        Me.DataGridViewTextBoxColumn6.Width = 5
        '
        'grupodestino
        '
        Me.grupodestino.Appearance.BackColor = System.Drawing.Color.Blue
        Me.grupodestino.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grupodestino.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grupodestino.Appearance.ForeColor = System.Drawing.Color.Black
        Me.grupodestino.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grupodestino.Appearance.Options.UseBackColor = True
        Me.grupodestino.Appearance.Options.UseBorderColor = True
        Me.grupodestino.Appearance.Options.UseForeColor = True
        Me.grupodestino.AppearanceCaption.BackColor = System.Drawing.Color.Blue
        Me.grupodestino.AppearanceCaption.Options.UseBackColor = True
        Me.grupodestino.Controls.Add(Me.cmdguardar)
        Me.grupodestino.Controls.Add(Me.cmdcancelar)
        Me.grupodestino.Controls.Add(Me.Label6)
        Me.grupodestino.Controls.Add(Me.txtp)
        Me.grupodestino.Controls.Add(Me.txtd)
        Me.grupodestino.Controls.Add(Me.Label3)
        Me.grupodestino.Location = New System.Drawing.Point(203, 116)
        Me.grupodestino.Name = "grupodestino"
        Me.grupodestino.Size = New System.Drawing.Size(215, 166)
        Me.grupodestino.TabIndex = 54
        Me.grupodestino.Text = "Edicion de datos del destino"
        Me.grupodestino.Visible = False
        '
        'cmdguardar
        '
        Me.cmdguardar.Image = CType(resources.GetObject("cmdguardar.Image"), System.Drawing.Image)
        Me.cmdguardar.Location = New System.Drawing.Point(12, 113)
        Me.cmdguardar.Name = "cmdguardar"
        Me.cmdguardar.Size = New System.Drawing.Size(92, 41)
        Me.cmdguardar.TabIndex = 44
        Me.cmdguardar.Text = "Guardar"
        '
        'cmdcancelar
        '
        Me.cmdcancelar.Image = CType(resources.GetObject("cmdcancelar.Image"), System.Drawing.Image)
        Me.cmdcancelar.Location = New System.Drawing.Point(112, 113)
        Me.cmdcancelar.Name = "cmdcancelar"
        Me.cmdcancelar.Size = New System.Drawing.Size(92, 41)
        Me.cmdcancelar.TabIndex = 43
        Me.cmdcancelar.Text = "Cancelar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(9, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Precio boleto:"
        '
        'txtp
        '
        Me.txtp.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtp.Location = New System.Drawing.Point(8, 87)
        Me.txtp.Name = "txtp"
        Me.txtp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtp.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtp.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtp.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtp.Size = New System.Drawing.Size(116, 20)
        Me.txtp.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(5, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Destino:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(665, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Abreviatura Destino:"
        '
        'destino
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 408)
        Me.ControlBox = False
        Me.Controls.Add(Me.grupodestino)
        Me.Controls.Add(Me.txtabrdestino)
        Me.Controls.Add(Me.gridDestino)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txta)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "destino"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtdestino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtprecio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtabrdestino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dxblanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.RutaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtsisbus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grupodestino, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupodestino.ResumeLayout(False)
        Me.grupodestino.PerformLayout()
        CType(Me.txtp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdeliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdmodificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtabrdestino As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Dxblanco As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtdestino As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Dtsisbus As Sisbuses.dtsisbus
    Friend WithEvents RutaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RutaTableAdapter As Sisbuses.dtsisbusTableAdapters.rutaTableAdapter
    Friend WithEvents TableAdapterManager As Sisbuses.dtsisbusTableAdapters.TableAdapterManager
    Friend WithEvents DestinoTableAdapter As Sisbuses.dtsisbusTableAdapters.destinoTableAdapter
    Friend WithEvents DestinoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cmdimprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdagregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtprecio As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents cmdcargar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboruta As System.Windows.Forms.ComboBox
    Friend WithEvents gridDestino As System.Windows.Forms.DataGridView
    Friend WithEvents cmdnuevor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grupodestino As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmdguardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdcancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtp As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
