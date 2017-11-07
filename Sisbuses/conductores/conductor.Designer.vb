<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class conductor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(conductor))
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
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
        Me.txtactivo = New DevExpress.XtraEditors.ToggleSwitch()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttel = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidentidad = New DevExpress.XtraEditors.TextEdit()
        Me.txtconductor = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtfecha = New DevExpress.XtraEditors.DateEdit()
        Me.Dtsisbus = New Sisbuses.dtsisbus()
        Me.ConductorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConductorTableAdapter = New Sisbuses.dtsisbusTableAdapters.conductorTableAdapter()
        Me.TableAdapterManager = New Sisbuses.dtsisbusTableAdapters.TableAdapterManager()
        Me.Dxblanco = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtactivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtidentidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtconductor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txtfecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txtfecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtsisbus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConductorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dxblanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(229, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(211, 24)
        Me.LabelControl1.TabIndex = 55
        Me.LabelControl1.Text = "Registro de Conductores"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdeliminar)
        Me.GroupBox3.Controls.Add(Me.cmdcancelar)
        Me.GroupBox3.Controls.Add(Me.cmdguardar)
        Me.GroupBox3.Controls.Add(Me.cmdsalir)
        Me.GroupBox3.Controls.Add(Me.cmdmodificar)
        Me.GroupBox3.Controls.Add(Me.cmdnuevo)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(180, 154)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(468, 70)
        Me.GroupBox3.TabIndex = 58
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones:"
        '
        'cmdeliminar
        '
        Me.cmdeliminar.Image = CType(resources.GetObject("cmdeliminar.Image"), System.Drawing.Image)
        Me.cmdeliminar.Location = New System.Drawing.Point(189, 22)
        Me.cmdeliminar.Name = "cmdeliminar"
        Me.cmdeliminar.Size = New System.Drawing.Size(92, 41)
        Me.cmdeliminar.TabIndex = 9
        Me.cmdeliminar.Text = "Eliminar"
        '
        'cmdcancelar
        '
        Me.cmdcancelar.Image = CType(resources.GetObject("cmdcancelar.Image"), System.Drawing.Image)
        Me.cmdcancelar.Location = New System.Drawing.Point(189, 22)
        Me.cmdcancelar.Name = "cmdcancelar"
        Me.cmdcancelar.Size = New System.Drawing.Size(92, 41)
        Me.cmdcancelar.TabIndex = 8
        Me.cmdcancelar.Text = "Cancelar"
        '
        'cmdguardar
        '
        Me.cmdguardar.Image = CType(resources.GetObject("cmdguardar.Image"), System.Drawing.Image)
        Me.cmdguardar.Location = New System.Drawing.Point(280, 22)
        Me.cmdguardar.Name = "cmdguardar"
        Me.cmdguardar.Size = New System.Drawing.Size(92, 41)
        Me.cmdguardar.TabIndex = 2
        Me.cmdguardar.Text = "Guardar"
        '
        'cmdsalir
        '
        Me.cmdsalir.Image = CType(resources.GetObject("cmdsalir.Image"), System.Drawing.Image)
        Me.cmdsalir.Location = New System.Drawing.Point(371, 22)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(92, 41)
        Me.cmdsalir.TabIndex = 6
        Me.cmdsalir.Text = "Salir"
        '
        'cmdmodificar
        '
        Me.cmdmodificar.Image = CType(resources.GetObject("cmdmodificar.Image"), System.Drawing.Image)
        Me.cmdmodificar.Location = New System.Drawing.Point(98, 22)
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
        Me.GroupBox4.Location = New System.Drawing.Point(2, 153)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(172, 71)
        Me.GroupBox4.TabIndex = 57
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
        Me.GroupBox1.Controls.Add(Me.txtactivo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txttel)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtidentidad)
        Me.GroupBox1.Controls.Add(Me.txtconductor)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txtfecha)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(2, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(646, 105)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del conductor:"
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
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Fecha vence licencia:"
        '
        'txttel
        '
        Me.txttel.Location = New System.Drawing.Point(128, 73)
        Me.txttel.Name = "txttel"
        '
        '
        '
        Me.txttel.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txttel.Size = New System.Drawing.Size(116, 20)
        Me.txttel.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(128, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Telefono:"
        '
        'txtidentidad
        '
        Me.txtidentidad.Location = New System.Drawing.Point(6, 73)
        Me.txtidentidad.Name = "txtidentidad"
        '
        '
        '
        Me.txtidentidad.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtidentidad.Size = New System.Drawing.Size(116, 20)
        Me.txtidentidad.TabIndex = 36
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Este campo no puede quedar vacio"
        ConditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.Dxblanco.SetValidationRule(Me.txtidentidad, ConditionValidationRule1)
        '
        'txtconductor
        '
        Me.txtconductor.Location = New System.Drawing.Point(6, 34)
        Me.txtconductor.Name = "txtconductor"
        Me.txtconductor.Size = New System.Drawing.Size(479, 20)
        Me.txtconductor.TabIndex = 35
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Este campo no puede quedar vacio"
        ConditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.Dxblanco.SetValidationRule(Me.txtconductor, ConditionValidationRule2)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(6, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Identidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(6, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Conductor"
        '
        'Txtfecha
        '
        Me.Txtfecha.EditValue = New Date(2017, 10, 30, 0, 0, 0, 0)
        Me.Txtfecha.Location = New System.Drawing.Point(250, 73)
        Me.Txtfecha.Name = "Txtfecha"
        '
        '
        '
        Me.Txtfecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        '
        '
        '
        Me.Txtfecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Txtfecha.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.Txtfecha.Properties.Mask.EditMask = ""
        Me.Txtfecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Txtfecha.Size = New System.Drawing.Size(116, 20)
        Me.Txtfecha.TabIndex = 40
        '
        'Dtsisbus
        '
        Me.Dtsisbus.DataSetName = "dtsisbus"
        Me.Dtsisbus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConductorBindingSource
        '
        Me.ConductorBindingSource.DataMember = "conductor"
        Me.ConductorBindingSource.DataSource = Me.Dtsisbus
        '
        'ConductorTableAdapter
        '
        Me.ConductorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.busTableAdapter = Nothing
        Me.TableAdapterManager.conductorTableAdapter = Me.ConductorTableAdapter
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
        'conductor
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Appearance.ForeColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 230)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "conductor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtactivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtidentidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtconductor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txtfecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txtfecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtsisbus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConductorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dxblanco, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ConductorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConductorTableAdapter As Sisbuses.dtsisbusTableAdapters.conductorTableAdapter
    Friend WithEvents TableAdapterManager As Sisbuses.dtsisbusTableAdapters.TableAdapterManager
    Private WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
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
    Private WithEvents txttel As DevExpress.XtraEditors.TextEdit
    Private WithEvents txtidentidad As DevExpress.XtraEditors.TextEdit
    Private WithEvents txtconductor As DevExpress.XtraEditors.TextEdit
    Private WithEvents Txtfecha As DevExpress.XtraEditors.DateEdit
    Private WithEvents Dxblanco As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Private WithEvents txtactivo As DevExpress.XtraEditors.ToggleSwitch
End Class
