<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gasto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gasto))
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
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
        Me.txtmonto = New DevExpress.XtraEditors.SpinEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtrazon = New DevExpress.XtraEditors.MemoEdit()
        Me.txtfecha = New DevExpress.XtraEditors.DateEdit()
        Me.Dtsisbus = New Sisbuses.dtsisbus()
        Me.GastosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GastosTableAdapter = New Sisbuses.dtsisbusTableAdapters.gastosTableAdapter()
        Me.TableAdapterManager = New Sisbuses.dtsisbusTableAdapters.TableAdapterManager()
        Me.Dxrazon = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.Dxmonto = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtmonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtrazon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtsisbus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GastosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dxrazon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dxmonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Location = New System.Drawing.Point(203, 10)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(164, 24)
        Me.LabelControl1.TabIndex = 48
        Me.LabelControl1.Text = "Registro De Gastos"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.cmdeliminar)
        Me.GroupBox3.Controls.Add(Me.cmdcancelar)
        Me.GroupBox3.Controls.Add(Me.cmdguardar)
        Me.GroupBox3.Controls.Add(Me.cmdsalir)
        Me.GroupBox3.Controls.Add(Me.cmdmodificar)
        Me.GroupBox3.Controls.Add(Me.cmdnuevo)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(479, 40)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(105, 229)
        Me.GroupBox3.TabIndex = 47
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones:"
        '
        'cmdeliminar
        '
        Me.cmdeliminar.Image = CType(resources.GetObject("cmdeliminar.Image"), System.Drawing.Image)
        Me.cmdeliminar.Location = New System.Drawing.Point(7, 102)
        Me.cmdeliminar.Name = "cmdeliminar"
        Me.cmdeliminar.Size = New System.Drawing.Size(92, 41)
        Me.cmdeliminar.TabIndex = 9
        Me.cmdeliminar.Text = "Eliminar"
        '
        'cmdcancelar
        '
        Me.cmdcancelar.Image = CType(resources.GetObject("cmdcancelar.Image"), System.Drawing.Image)
        Me.cmdcancelar.Location = New System.Drawing.Point(7, 102)
        Me.cmdcancelar.Name = "cmdcancelar"
        Me.cmdcancelar.Size = New System.Drawing.Size(92, 41)
        Me.cmdcancelar.TabIndex = 8
        Me.cmdcancelar.Text = "Cancelar"
        '
        'cmdguardar
        '
        Me.cmdguardar.Image = CType(resources.GetObject("cmdguardar.Image"), System.Drawing.Image)
        Me.cmdguardar.Location = New System.Drawing.Point(7, 142)
        Me.cmdguardar.Name = "cmdguardar"
        Me.cmdguardar.Size = New System.Drawing.Size(92, 41)
        Me.cmdguardar.TabIndex = 2
        Me.cmdguardar.Text = "Guardar"
        '
        'cmdsalir
        '
        Me.cmdsalir.Image = CType(resources.GetObject("cmdsalir.Image"), System.Drawing.Image)
        Me.cmdsalir.Location = New System.Drawing.Point(7, 182)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(92, 41)
        Me.cmdsalir.TabIndex = 6
        Me.cmdsalir.Text = "Salir"
        '
        'cmdmodificar
        '
        Me.cmdmodificar.Image = CType(resources.GetObject("cmdmodificar.Image"), System.Drawing.Image)
        Me.cmdmodificar.Location = New System.Drawing.Point(7, 62)
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
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(4, 205)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(172, 71)
        Me.GroupBox4.TabIndex = 46
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
        Me.GroupBox1.Controls.Add(Me.txtmonto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtrazon)
        Me.GroupBox1.Controls.Add(Me.txtfecha)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(4, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(469, 164)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del gasto:"
        '
        'txtmonto
        '
        Me.txtmonto.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtmonto.Location = New System.Drawing.Point(6, 132)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtmonto.Properties.Mask.EditMask = "n"
        Me.txtmonto.Size = New System.Drawing.Size(100, 20)
        Me.txtmonto.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(8, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Monto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(387, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Fecha:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(6, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Razon:"
        '
        'txtrazon
        '
        Me.txtrazon.Location = New System.Drawing.Point(6, 34)
        Me.txtrazon.Name = "txtrazon"
        Me.txtrazon.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtrazon.Size = New System.Drawing.Size(357, 78)
        Me.txtrazon.TabIndex = 35
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Este campo no puede quedar en blanco"
        ConditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.Dxmonto.SetValidationRule(Me.txtrazon, ConditionValidationRule1)
        '
        'txtfecha
        '
        Me.txtfecha.EditValue = Nothing
        Me.txtfecha.Location = New System.Drawing.Point(369, 33)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtfecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtfecha.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtfecha.Size = New System.Drawing.Size(94, 20)
        Me.txtfecha.TabIndex = 36
        '
        'Dtsisbus
        '
        Me.Dtsisbus.DataSetName = "dtsisbus"
        Me.Dtsisbus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GastosBindingSource
        '
        Me.GastosBindingSource.DataMember = "gastos"
        Me.GastosBindingSource.DataSource = Me.Dtsisbus
        '
        'GastosTableAdapter
        '
        Me.GastosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.busTableAdapter = Nothing
        Me.TableAdapterManager.conductorTableAdapter = Nothing
        Me.TableAdapterManager.descuentosTableAdapter = Nothing
        Me.TableAdapterManager.destinoTableAdapter = Nothing
        Me.TableAdapterManager.gastosTableAdapter = Me.GastosTableAdapter
        Me.TableAdapterManager.horarioTableAdapter = Nothing
        Me.TableAdapterManager.opcionesTableAdapter = Nothing
        Me.TableAdapterManager.rutaTableAdapter = Nothing
        Me.TableAdapterManager.ticketTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sisbuses.dtsisbusTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'gasto
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 279)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "gasto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtmonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtrazon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtsisbus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GastosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dxrazon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dxmonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdeliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdcancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdguardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdmodificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdnuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdult As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdsig As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdatras As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdpri As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtrazon As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtfecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Dtsisbus As Sisbuses.dtsisbus
    Friend WithEvents GastosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GastosTableAdapter As Sisbuses.dtsisbusTableAdapters.gastosTableAdapter
    Friend WithEvents TableAdapterManager As Sisbuses.dtsisbusTableAdapters.TableAdapterManager
    Friend WithEvents Dxrazon As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents Dxmonto As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents txtmonto As DevExpress.XtraEditors.SpinEdit
End Class
