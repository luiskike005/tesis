<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class horario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(horario))
        Me.grupodestino = New DevExpress.XtraEditors.GroupControl()
        Me.txthorasalida1 = New DevExpress.XtraEditors.TimeEdit()
        Me.cbobconductor = New System.Windows.Forms.ComboBox()
        Me.ConductorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dtsisbus = New Sisbuses.dtsisbus()
        Me.cboap = New System.Windows.Forms.ComboBox()
        Me.cbobbus = New System.Windows.Forms.ComboBox()
        Me.BusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmdguardar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdcancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gridDestino = New System.Windows.Forms.DataGridView()
        Me.IdhorarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdrutaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RutaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdbusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdconductorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConductorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ht = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VistahorarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdcargar = New DevExpress.XtraEditors.SimpleButton()
        Me.cboruta = New System.Windows.Forms.ComboBox()
        Me.RutaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdimprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdeliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdsalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdmodificar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txthora = New DevExpress.XtraEditors.TimeEdit()
        Me.cboht = New System.Windows.Forms.ComboBox()
        Me.cboconductor = New System.Windows.Forms.ComboBox()
        Me.cbobus = New System.Windows.Forms.ComboBox()
        Me.cmdagregar = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HorarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HorarioTableAdapter = New Sisbuses.dtsisbusTableAdapters.horarioTableAdapter()
        Me.TableAdapterManager = New Sisbuses.dtsisbusTableAdapters.TableAdapterManager()
        Me.BusTableAdapter = New Sisbuses.dtsisbusTableAdapters.busTableAdapter()
        Me.ConductorTableAdapter = New Sisbuses.dtsisbusTableAdapters.conductorTableAdapter()
        Me.RutaTableAdapter = New Sisbuses.dtsisbusTableAdapters.rutaTableAdapter()
        Me.VistahorarioTableAdapter = New Sisbuses.dtsisbusTableAdapters.vistahorarioTableAdapter()
        CType(Me.grupodestino, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupodestino.SuspendLayout()
        CType(Me.txthorasalida1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConductorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtsisbus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistahorarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.RutaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txthora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grupodestino
        '
        Me.grupodestino.Appearance.BackColor = System.Drawing.Color.Blue
        Me.grupodestino.Appearance.Options.UseBackColor = True
        Me.grupodestino.Controls.Add(Me.txthorasalida1)
        Me.grupodestino.Controls.Add(Me.cbobconductor)
        Me.grupodestino.Controls.Add(Me.cboap)
        Me.grupodestino.Controls.Add(Me.cbobbus)
        Me.grupodestino.Controls.Add(Me.cmdguardar)
        Me.grupodestino.Controls.Add(Me.cmdcancelar)
        Me.grupodestino.Controls.Add(Me.Label6)
        Me.grupodestino.Controls.Add(Me.Label4)
        Me.grupodestino.Controls.Add(Me.Label3)
        Me.grupodestino.Location = New System.Drawing.Point(180, 116)
        Me.grupodestino.Name = "grupodestino"
        Me.grupodestino.Size = New System.Drawing.Size(254, 201)
        Me.grupodestino.TabIndex = 59
        Me.grupodestino.Text = "Edicion de datos del destino"
        Me.grupodestino.Visible = False
        '
        'txthorasalida1
        '
        Me.txthorasalida1.EditValue = Nothing
        Me.txthorasalida1.Location = New System.Drawing.Point(5, 125)
        Me.txthorasalida1.Name = "txthorasalida1"
        Me.txthorasalida1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txthorasalida1.Properties.Mask.EditMask = "t"
        Me.txthorasalida1.Size = New System.Drawing.Size(76, 20)
        Me.txthorasalida1.TabIndex = 43
        '
        'cbobconductor
        '
        Me.cbobconductor.DataSource = Me.ConductorBindingSource
        Me.cbobconductor.DisplayMember = "conductor"
        Me.cbobconductor.FormattingEnabled = True
        Me.cbobconductor.Location = New System.Drawing.Point(5, 84)
        Me.cbobconductor.Name = "cbobconductor"
        Me.cbobconductor.Size = New System.Drawing.Size(238, 21)
        Me.cbobconductor.TabIndex = 45
        Me.cbobconductor.ValueMember = "idconductor"
        '
        'ConductorBindingSource
        '
        Me.ConductorBindingSource.DataMember = "conductor"
        Me.ConductorBindingSource.DataSource = Me.Dtsisbus
        '
        'Dtsisbus
        '
        Me.Dtsisbus.DataSetName = "dtsisbus"
        Me.Dtsisbus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboap
        '
        Me.cboap.FormattingEnabled = True
        Me.cboap.Items.AddRange(New Object() {"AM", "PM"})
        Me.cboap.Location = New System.Drawing.Point(83, 124)
        Me.cboap.Name = "cboap"
        Me.cboap.Size = New System.Drawing.Size(40, 21)
        Me.cboap.TabIndex = 42
        '
        'cbobbus
        '
        Me.cbobbus.DataSource = Me.BusBindingSource
        Me.cbobbus.DisplayMember = "bus"
        Me.cbobbus.FormattingEnabled = True
        Me.cbobbus.Location = New System.Drawing.Point(5, 46)
        Me.cbobbus.Name = "cbobbus"
        Me.cbobbus.Size = New System.Drawing.Size(238, 21)
        Me.cbobbus.TabIndex = 40
        Me.cbobbus.ValueMember = "idbus"
        '
        'BusBindingSource
        '
        Me.BusBindingSource.DataMember = "bus"
        Me.BusBindingSource.DataSource = Me.Dtsisbus
        '
        'cmdguardar
        '
        Me.cmdguardar.Image = CType(resources.GetObject("cmdguardar.Image"), System.Drawing.Image)
        Me.cmdguardar.Location = New System.Drawing.Point(31, 151)
        Me.cmdguardar.Name = "cmdguardar"
        Me.cmdguardar.Size = New System.Drawing.Size(92, 41)
        Me.cmdguardar.TabIndex = 44
        Me.cmdguardar.Text = "Guardar"
        '
        'cmdcancelar
        '
        Me.cmdcancelar.Image = CType(resources.GetObject("cmdcancelar.Image"), System.Drawing.Image)
        Me.cmdcancelar.Location = New System.Drawing.Point(129, 151)
        Me.cmdcancelar.Name = "cmdcancelar"
        Me.cmdcancelar.Size = New System.Drawing.Size(92, 41)
        Me.cmdcancelar.TabIndex = 43
        Me.cmdcancelar.Text = "Cancelar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(5, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Hora salida:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(5, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Conductor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(5, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Bus:"
        '
        'gridDestino
        '
        Me.gridDestino.AllowUserToAddRows = False
        Me.gridDestino.AllowUserToDeleteRows = False
        Me.gridDestino.AutoGenerateColumns = False
        Me.gridDestino.BackgroundColor = System.Drawing.Color.White
        Me.gridDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridDestino.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdhorarioDataGridViewTextBoxColumn, Me.IdrutaDataGridViewTextBoxColumn, Me.RutaDataGridViewTextBoxColumn, Me.IdbusDataGridViewTextBoxColumn, Me.BusDataGridViewTextBoxColumn, Me.IdconductorDataGridViewTextBoxColumn, Me.ConductorDataGridViewTextBoxColumn, Me.HoraDataGridViewTextBoxColumn, Me.ht})
        Me.gridDestino.DataSource = Me.VistahorarioBindingSource
        Me.gridDestino.Location = New System.Drawing.Point(4, 185)
        Me.gridDestino.Name = "gridDestino"
        Me.gridDestino.ReadOnly = True
        Me.gridDestino.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridDestino.Size = New System.Drawing.Size(508, 220)
        Me.gridDestino.TabIndex = 57
        '
        'IdhorarioDataGridViewTextBoxColumn
        '
        Me.IdhorarioDataGridViewTextBoxColumn.DataPropertyName = "idhorario"
        Me.IdhorarioDataGridViewTextBoxColumn.HeaderText = "idhorario"
        Me.IdhorarioDataGridViewTextBoxColumn.Name = "IdhorarioDataGridViewTextBoxColumn"
        Me.IdhorarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdhorarioDataGridViewTextBoxColumn.Visible = False
        '
        'IdrutaDataGridViewTextBoxColumn
        '
        Me.IdrutaDataGridViewTextBoxColumn.DataPropertyName = "idruta"
        Me.IdrutaDataGridViewTextBoxColumn.HeaderText = "idruta"
        Me.IdrutaDataGridViewTextBoxColumn.Name = "IdrutaDataGridViewTextBoxColumn"
        Me.IdrutaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdrutaDataGridViewTextBoxColumn.Visible = False
        '
        'RutaDataGridViewTextBoxColumn
        '
        Me.RutaDataGridViewTextBoxColumn.DataPropertyName = "ruta"
        Me.RutaDataGridViewTextBoxColumn.HeaderText = "ruta"
        Me.RutaDataGridViewTextBoxColumn.Name = "RutaDataGridViewTextBoxColumn"
        Me.RutaDataGridViewTextBoxColumn.ReadOnly = True
        Me.RutaDataGridViewTextBoxColumn.Visible = False
        Me.RutaDataGridViewTextBoxColumn.Width = 200
        '
        'IdbusDataGridViewTextBoxColumn
        '
        Me.IdbusDataGridViewTextBoxColumn.DataPropertyName = "idbus"
        Me.IdbusDataGridViewTextBoxColumn.HeaderText = "idbus"
        Me.IdbusDataGridViewTextBoxColumn.Name = "IdbusDataGridViewTextBoxColumn"
        Me.IdbusDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdbusDataGridViewTextBoxColumn.Visible = False
        '
        'BusDataGridViewTextBoxColumn
        '
        Me.BusDataGridViewTextBoxColumn.DataPropertyName = "bus"
        Me.BusDataGridViewTextBoxColumn.HeaderText = "bus"
        Me.BusDataGridViewTextBoxColumn.Name = "BusDataGridViewTextBoxColumn"
        Me.BusDataGridViewTextBoxColumn.ReadOnly = True
        Me.BusDataGridViewTextBoxColumn.Width = 150
        '
        'IdconductorDataGridViewTextBoxColumn
        '
        Me.IdconductorDataGridViewTextBoxColumn.DataPropertyName = "idconductor"
        Me.IdconductorDataGridViewTextBoxColumn.HeaderText = "idconductor"
        Me.IdconductorDataGridViewTextBoxColumn.Name = "IdconductorDataGridViewTextBoxColumn"
        Me.IdconductorDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdconductorDataGridViewTextBoxColumn.Visible = False
        '
        'ConductorDataGridViewTextBoxColumn
        '
        Me.ConductorDataGridViewTextBoxColumn.DataPropertyName = "conductor"
        Me.ConductorDataGridViewTextBoxColumn.HeaderText = "conductor"
        Me.ConductorDataGridViewTextBoxColumn.Name = "ConductorDataGridViewTextBoxColumn"
        Me.ConductorDataGridViewTextBoxColumn.ReadOnly = True
        Me.ConductorDataGridViewTextBoxColumn.Width = 200
        '
        'HoraDataGridViewTextBoxColumn
        '
        Me.HoraDataGridViewTextBoxColumn.DataPropertyName = "hora"
        Me.HoraDataGridViewTextBoxColumn.HeaderText = "hora"
        Me.HoraDataGridViewTextBoxColumn.Name = "HoraDataGridViewTextBoxColumn"
        Me.HoraDataGridViewTextBoxColumn.ReadOnly = True
        Me.HoraDataGridViewTextBoxColumn.Width = 50
        '
        'ht
        '
        Me.ht.DataPropertyName = "ht"
        Me.ht.HeaderText = "."
        Me.ht.Name = "ht"
        Me.ht.ReadOnly = True
        Me.ht.Width = 50
        '
        'VistahorarioBindingSource
        '
        Me.VistahorarioBindingSource.DataMember = "vistahorario"
        Me.VistahorarioBindingSource.DataSource = Me.Dtsisbus
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.cmdcargar)
        Me.GroupBox2.Controls.Add(Me.cboruta)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(4, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(617, 68)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de rutas:"
        '
        'cmdcargar
        '
        Me.cmdcargar.Image = CType(resources.GetObject("cmdcargar.Image"), System.Drawing.Image)
        Me.cmdcargar.Location = New System.Drawing.Point(360, 32)
        Me.cmdcargar.Name = "cmdcargar"
        Me.cmdcargar.Size = New System.Drawing.Size(106, 25)
        Me.cmdcargar.TabIndex = 10
        Me.cmdcargar.Text = "Cargar Horario"
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
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Location = New System.Drawing.Point(214, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(146, 24)
        Me.LabelControl1.TabIndex = 58
        Me.LabelControl1.Text = "Registro Horario"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.cmdimprimir)
        Me.GroupBox3.Controls.Add(Me.cmdeliminar)
        Me.GroupBox3.Controls.Add(Me.cmdsalir)
        Me.GroupBox3.Controls.Add(Me.cmdmodificar)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(514, 182)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(107, 189)
        Me.GroupBox3.TabIndex = 56
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
        Me.GroupBox1.Controls.Add(Me.txthora)
        Me.GroupBox1.Controls.Add(Me.cboht)
        Me.GroupBox1.Controls.Add(Me.cboconductor)
        Me.GroupBox1.Controls.Add(Me.cbobus)
        Me.GroupBox1.Controls.Add(Me.cmdagregar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(4, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(617, 63)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del horario:"
        '
        'txthora
        '
        Me.txthora.EditValue = New Date(2016, 9, 25, 16, 24, 36, 0)
        Me.txthora.Location = New System.Drawing.Point(202, 37)
        Me.txthora.Name = "txthora"
        Me.txthora.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txthora.Properties.Mask.EditMask = "hh:mm"
        Me.txthora.Size = New System.Drawing.Size(76, 20)
        Me.txthora.TabIndex = 41
        '
        'cboht
        '
        Me.cboht.FormattingEnabled = True
        Me.cboht.Items.AddRange(New Object() {"AM", "PM"})
        Me.cboht.Location = New System.Drawing.Point(280, 36)
        Me.cboht.Name = "cboht"
        Me.cboht.Size = New System.Drawing.Size(40, 21)
        Me.cboht.TabIndex = 40
        Me.cboht.Text = "AM"
        '
        'cboconductor
        '
        Me.cboconductor.DataSource = Me.ConductorBindingSource
        Me.cboconductor.DisplayMember = "conductor"
        Me.cboconductor.FormattingEnabled = True
        Me.cboconductor.Location = New System.Drawing.Point(326, 36)
        Me.cboconductor.Name = "cboconductor"
        Me.cboconductor.Size = New System.Drawing.Size(174, 21)
        Me.cboconductor.TabIndex = 27
        Me.cboconductor.ValueMember = "idconductor"
        '
        'cbobus
        '
        Me.cbobus.DataSource = Me.BusBindingSource
        Me.cbobus.DisplayMember = "bus"
        Me.cbobus.FormattingEnabled = True
        Me.cbobus.Location = New System.Drawing.Point(6, 34)
        Me.cbobus.Name = "cbobus"
        Me.cbobus.Size = New System.Drawing.Size(190, 21)
        Me.cbobus.TabIndex = 28
        Me.cbobus.ValueMember = "idbus"
        '
        'cmdagregar
        '
        Me.cmdagregar.Image = CType(resources.GetObject("cmdagregar.Image"), System.Drawing.Image)
        Me.cmdagregar.Location = New System.Drawing.Point(506, 31)
        Me.cmdagregar.Name = "cmdagregar"
        Me.cmdagregar.Size = New System.Drawing.Size(106, 25)
        Me.cmdagregar.TabIndex = 27
        Me.cmdagregar.Text = "Agregar Destino"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(203, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Hora Salida:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(330, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Conductor:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(6, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Bus:"
        '
        'HorarioBindingSource
        '
        Me.HorarioBindingSource.DataMember = "horario"
        Me.HorarioBindingSource.DataSource = Me.Dtsisbus
        '
        'HorarioTableAdapter
        '
        Me.HorarioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.busTableAdapter = Me.BusTableAdapter
        Me.TableAdapterManager.conductorTableAdapter = Me.ConductorTableAdapter
        Me.TableAdapterManager.descuentosTableAdapter = Nothing
        Me.TableAdapterManager.destinoTableAdapter = Nothing
        Me.TableAdapterManager.gastosTableAdapter = Nothing
        Me.TableAdapterManager.horarioTableAdapter = Me.HorarioTableAdapter
        Me.TableAdapterManager.opcionesTableAdapter = Nothing
        Me.TableAdapterManager.rutaTableAdapter = Me.RutaTableAdapter
        Me.TableAdapterManager.ticketTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sisbuses.dtsisbusTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'BusTableAdapter
        '
        Me.BusTableAdapter.ClearBeforeFill = True
        '
        'ConductorTableAdapter
        '
        Me.ConductorTableAdapter.ClearBeforeFill = True
        '
        'RutaTableAdapter
        '
        Me.RutaTableAdapter.ClearBeforeFill = True
        '
        'VistahorarioTableAdapter
        '
        Me.VistahorarioTableAdapter.ClearBeforeFill = True
        '
        'horario
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 406)
        Me.ControlBox = False
        Me.Controls.Add(Me.grupodestino)
        Me.Controls.Add(Me.gridDestino)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "horario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.grupodestino, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupodestino.ResumeLayout(False)
        Me.grupodestino.PerformLayout()
        CType(Me.txthorasalida1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConductorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtsisbus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistahorarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.RutaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txthora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HorarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grupodestino As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmdguardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdcancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gridDestino As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdcargar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboruta As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdimprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdeliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdmodificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbobus As System.Windows.Forms.ComboBox
    Friend WithEvents cmdagregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboconductor As System.Windows.Forms.ComboBox
    Friend WithEvents cbobconductor As System.Windows.Forms.ComboBox
    Friend WithEvents cbobbus As System.Windows.Forms.ComboBox
    Friend WithEvents Dtsisbus As Sisbuses.dtsisbus
    Friend WithEvents HorarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HorarioTableAdapter As Sisbuses.dtsisbusTableAdapters.horarioTableAdapter
    Friend WithEvents TableAdapterManager As Sisbuses.dtsisbusTableAdapters.TableAdapterManager
    Friend WithEvents RutaTableAdapter As Sisbuses.dtsisbusTableAdapters.rutaTableAdapter
    Friend WithEvents RutaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BusTableAdapter As Sisbuses.dtsisbusTableAdapters.busTableAdapter
    Friend WithEvents BusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConductorTableAdapter As Sisbuses.dtsisbusTableAdapters.conductorTableAdapter
    Friend WithEvents ConductorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VistahorarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VistahorarioTableAdapter As Sisbuses.dtsisbusTableAdapters.vistahorarioTableAdapter
    Friend WithEvents cboht As System.Windows.Forms.ComboBox
    Friend WithEvents txthora As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents IdhorarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdrutaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RutaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdbusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdconductorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConductorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HoraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ht As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txthorasalida1 As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents cboap As System.Windows.Forms.ComboBox
End Class
