<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bus))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdeliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdcancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdguardar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdsalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdmodificar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdnuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmdult = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdsig = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdatras = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdpri = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtactivo = New DevExpress.XtraEditors.ToggleSwitch()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtasientos = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtplaca = New DevExpress.XtraEditors.TextEdit()
        Me.txtbus = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txttamaño = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Dtsisbus = New Sisbuses.dtsisbus()
        Me.BusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BusTableAdapter = New Sisbuses.dtsisbusTableAdapters.busTableAdapter()
        Me.TableAdapterManager = New Sisbuses.dtsisbusTableAdapters.TableAdapterManager()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtactivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtasientos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtplaca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtbus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txttamaño.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtsisbus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdeliminar)
        Me.GroupBox3.Controls.Add(Me.cmdcancelar)
        Me.GroupBox3.Controls.Add(Me.cmdguardar)
        Me.GroupBox3.Controls.Add(Me.cmdsalir)
        Me.GroupBox3.Controls.Add(Me.cmdmodificar)
        Me.GroupBox3.Controls.Add(Me.cmdnuevo)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(178, 154)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(472, 70)
        Me.GroupBox3.TabIndex = 62
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones:"
        '
        'cmdeliminar
        '
        Me.cmdeliminar.Image = CType(resources.GetObject("cmdeliminar.Image"), System.Drawing.Image)
        Me.cmdeliminar.Location = New System.Drawing.Point(191, 22)
        Me.cmdeliminar.Name = "cmdeliminar"
        Me.cmdeliminar.Size = New System.Drawing.Size(92, 41)
        Me.cmdeliminar.TabIndex = 9
        Me.cmdeliminar.Text = "Eliminar"
        '
        'cmdcancelar
        '
        Me.cmdcancelar.Image = CType(resources.GetObject("cmdcancelar.Image"), System.Drawing.Image)
        Me.cmdcancelar.Location = New System.Drawing.Point(191, 22)
        Me.cmdcancelar.Name = "cmdcancelar"
        Me.cmdcancelar.Size = New System.Drawing.Size(92, 41)
        Me.cmdcancelar.TabIndex = 8
        Me.cmdcancelar.Text = "Cancelar"
        '
        'cmdguardar
        '
        Me.cmdguardar.Image = CType(resources.GetObject("cmdguardar.Image"), System.Drawing.Image)
        Me.cmdguardar.Location = New System.Drawing.Point(283, 22)
        Me.cmdguardar.Name = "cmdguardar"
        Me.cmdguardar.Size = New System.Drawing.Size(92, 41)
        Me.cmdguardar.TabIndex = 2
        Me.cmdguardar.Text = "Guardar"
        '
        'cmdsalir
        '
        Me.cmdsalir.Image = CType(resources.GetObject("cmdsalir.Image"), System.Drawing.Image)
        Me.cmdsalir.Location = New System.Drawing.Point(375, 22)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(92, 41)
        Me.cmdsalir.TabIndex = 6
        Me.cmdsalir.Text = "Salir"
        '
        'cmdmodificar
        '
        Me.cmdmodificar.Image = CType(resources.GetObject("cmdmodificar.Image"), System.Drawing.Image)
        Me.cmdmodificar.Location = New System.Drawing.Point(99, 22)
        Me.cmdmodificar.Name = "cmdmodificar"
        Me.cmdmodificar.Size = New System.Drawing.Size(92, 41)
        Me.cmdmodificar.TabIndex = 1
        Me.cmdmodificar.Text = "Modificar"
        '
        'cmdnuevo
        '
        Me.cmdnuevo.Image = CType(resources.GetObject("cmdnuevo.Image"), System.Drawing.Image)
        Me.cmdnuevo.Location = New System.Drawing.Point(7, 22)
        Me.cmdnuevo.Name = "cmdnuevo"
        Me.cmdnuevo.Size = New System.Drawing.Size(92, 41)
        Me.cmdnuevo.TabIndex = 0
        Me.cmdnuevo.Text = "Nuevo"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmdult)
        Me.GroupBox4.Controls.Add(Me.cmdsig)
        Me.GroupBox4.Controls.Add(Me.cmdatras)
        Me.GroupBox4.Controls.Add(Me.cmdpri)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(3, 153)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(172, 71)
        Me.GroupBox4.TabIndex = 61
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Opciones de navegación:"
        '
        'cmdult
        '
        Me.cmdult.Image = CType(resources.GetObject("cmdult.Image"), System.Drawing.Image)
        Me.cmdult.Location = New System.Drawing.Point(122, 22)
        Me.cmdult.Name = "cmdult"
        Me.cmdult.Size = New System.Drawing.Size(38, 41)
        Me.cmdult.TabIndex = 10
        '
        'cmdsig
        '
        Me.cmdsig.Image = CType(resources.GetObject("cmdsig.Image"), System.Drawing.Image)
        Me.cmdsig.Location = New System.Drawing.Point(84, 22)
        Me.cmdsig.Name = "cmdsig"
        Me.cmdsig.Size = New System.Drawing.Size(38, 41)
        Me.cmdsig.TabIndex = 9
        '
        'cmdatras
        '
        Me.cmdatras.Image = CType(resources.GetObject("cmdatras.Image"), System.Drawing.Image)
        Me.cmdatras.Location = New System.Drawing.Point(46, 22)
        Me.cmdatras.Name = "cmdatras"
        Me.cmdatras.Size = New System.Drawing.Size(38, 41)
        Me.cmdatras.TabIndex = 8
        '
        'cmdpri
        '
        Me.cmdpri.Image = CType(resources.GetObject("cmdpri.Image"), System.Drawing.Image)
        Me.cmdpri.Location = New System.Drawing.Point(8, 22)
        Me.cmdpri.Name = "cmdpri"
        Me.cmdpri.Size = New System.Drawing.Size(38, 41)
        Me.cmdpri.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtactivo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtasientos)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtplaca)
        Me.GroupBox1.Controls.Add(Me.txtbus)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txttamaño)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(3, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(647, 105)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del bus:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(369, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Estado:"
        '
        'txtactivo
        '
        Me.txtactivo.EditValue = True
        Me.txtactivo.Location = New System.Drawing.Point(372, 69)
        Me.txtactivo.Name = "txtactivo"
        '
        '
        '
        Me.txtactivo.Properties.OffText = "Inactivo"
        Me.txtactivo.Properties.OnText = "Activo"
        Me.txtactivo.Size = New System.Drawing.Size(113, 24)
        Me.txtactivo.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(250, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "tamaño:"
        '
        'txtasientos
        '
        Me.txtasientos.Location = New System.Drawing.Point(128, 73)
        Me.txtasientos.Name = "txtasientos"
        '
        '
        '
        Me.txtasientos.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtasientos.Size = New System.Drawing.Size(116, 20)
        Me.txtasientos.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(128, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Numero asientos:"
        '
        'txtplaca
        '
        Me.txtplaca.Location = New System.Drawing.Point(6, 73)
        Me.txtplaca.Name = "txtplaca"
        '
        '
        '
        Me.txtplaca.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtplaca.Size = New System.Drawing.Size(116, 20)
        Me.txtplaca.TabIndex = 36
        '
        'txtbus
        '
        Me.txtbus.Location = New System.Drawing.Point(6, 34)
        Me.txtbus.Name = "txtbus"
        '
        '
        '
        Me.txtbus.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtbus.Size = New System.Drawing.Size(479, 20)
        Me.txtbus.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(6, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Placa:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(6, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Bus"
        '
        'Txttamaño
        '
        Me.Txttamaño.Location = New System.Drawing.Point(250, 73)
        Me.Txttamaño.Name = "Txttamaño"
        '
        '
        '
        Me.Txttamaño.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Txttamaño.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.Txttamaño.Properties.Items.AddRange(New Object() {"Pequeño", "Grande"})
        Me.Txttamaño.Size = New System.Drawing.Size(116, 20)
        Me.Txttamaño.TabIndex = 40
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(263, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(150, 24)
        Me.LabelControl1.TabIndex = 59
        Me.LabelControl1.Text = "Registro de buses"
        '
        'Dtsisbus
        '
        Me.Dtsisbus.DataSetName = "dtsisbus"
        Me.Dtsisbus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BusBindingSource
        '
        Me.BusBindingSource.DataMember = "bus"
        Me.BusBindingSource.DataSource = Me.Dtsisbus
        '
        'BusTableAdapter
        '
        Me.BusTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.busTableAdapter = Me.BusTableAdapter
        Me.TableAdapterManager.conductorTableAdapter = Nothing
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
        'bus
        '
        Me.Appearance.BackColor = System.Drawing.Color.MediumBlue
        Me.Appearance.ForeColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 229)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "bus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtactivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtasientos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtplaca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtbus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txttamaño.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtsisbus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Dtsisbus As Sisbuses.dtsisbus
    Friend WithEvents BusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BusTableAdapter As Sisbuses.dtsisbusTableAdapters.busTableAdapter
    Friend WithEvents TableAdapterManager As Sisbuses.dtsisbusTableAdapters.TableAdapterManager
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents cmdeliminar As DevExpress.XtraEditors.SimpleButton
    Private WithEvents cmdcancelar As DevExpress.XtraEditors.SimpleButton
    Private WithEvents cmdguardar As DevExpress.XtraEditors.SimpleButton
    Private WithEvents cmdsalir As DevExpress.XtraEditors.SimpleButton
    Private WithEvents cmdmodificar As DevExpress.XtraEditors.SimpleButton
    Private WithEvents cmdnuevo As DevExpress.XtraEditors.SimpleButton
    Private WithEvents cmdult As DevExpress.XtraEditors.SimpleButton
    Private WithEvents cmdsig As DevExpress.XtraEditors.SimpleButton
    Private WithEvents cmdatras As DevExpress.XtraEditors.SimpleButton
    Private WithEvents cmdpri As DevExpress.XtraEditors.SimpleButton
    Private WithEvents txtactivo As DevExpress.XtraEditors.ToggleSwitch
    Private WithEvents txtasientos As DevExpress.XtraEditors.TextEdit
    Private WithEvents txtplaca As DevExpress.XtraEditors.TextEdit
    Private WithEvents txtbus As DevExpress.XtraEditors.TextEdit
    Private WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Private WithEvents Txttamaño As DevExpress.XtraEditors.ComboBoxEdit
End Class
