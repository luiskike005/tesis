<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ruta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ruta))
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtabrdestino = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtabrorigen = New DevExpress.XtraEditors.TextEdit()
        Me.txtruta = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dxblanco = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.Dtsisbus = New Sisbuses.dtsisbus()
        Me.RutaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RutaTableAdapter = New Sisbuses.dtsisbusTableAdapters.rutaTableAdapter()
        Me.TableAdapterManager = New Sisbuses.dtsisbusTableAdapters.TableAdapterManager()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtabrdestino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtabrorigen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtruta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dxblanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtsisbus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RutaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Location = New System.Drawing.Point(252, 22)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(157, 24)
        Me.LabelControl1.TabIndex = 48
        Me.LabelControl1.Text = "Registro De Rutas"
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
        Me.GroupBox3.Location = New System.Drawing.Point(198, 121)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(438, 57)
        Me.GroupBox3.TabIndex = 47
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones:"
        '
        'cmdeliminar
        '
        Me.cmdeliminar.Image = CType(resources.GetObject("cmdeliminar.Image"), System.Drawing.Image)
        Me.cmdeliminar.Location = New System.Drawing.Point(171, 20)
        Me.cmdeliminar.Name = "cmdeliminar"
        Me.cmdeliminar.Size = New System.Drawing.Size(89, 33)
        Me.cmdeliminar.TabIndex = 9
        Me.cmdeliminar.Text = "Eliminar"
        '
        'cmdcancelar
        '
        Me.cmdcancelar.Image = CType(resources.GetObject("cmdcancelar.Image"), System.Drawing.Image)
        Me.cmdcancelar.Location = New System.Drawing.Point(171, 20)
        Me.cmdcancelar.Name = "cmdcancelar"
        Me.cmdcancelar.Size = New System.Drawing.Size(89, 33)
        Me.cmdcancelar.TabIndex = 8
        Me.cmdcancelar.Text = "Cancelar"
        '
        'cmdguardar
        '
        Me.cmdguardar.Image = CType(resources.GetObject("cmdguardar.Image"), System.Drawing.Image)
        Me.cmdguardar.Location = New System.Drawing.Point(259, 20)
        Me.cmdguardar.Name = "cmdguardar"
        Me.cmdguardar.Size = New System.Drawing.Size(84, 33)
        Me.cmdguardar.TabIndex = 2
        Me.cmdguardar.Text = "Guardar"
        '
        'cmdsalir
        '
        Me.cmdsalir.Image = CType(resources.GetObject("cmdsalir.Image"), System.Drawing.Image)
        Me.cmdsalir.Location = New System.Drawing.Point(342, 21)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(91, 32)
        Me.cmdsalir.TabIndex = 6
        Me.cmdsalir.Text = "Salir"
        '
        'cmdmodificar
        '
        Me.cmdmodificar.Image = CType(resources.GetObject("cmdmodificar.Image"), System.Drawing.Image)
        Me.cmdmodificar.Location = New System.Drawing.Point(84, 20)
        Me.cmdmodificar.Name = "cmdmodificar"
        Me.cmdmodificar.Size = New System.Drawing.Size(88, 33)
        Me.cmdmodificar.TabIndex = 1
        Me.cmdmodificar.Text = "Modificar"
        '
        'cmdnuevo
        '
        Me.cmdnuevo.Image = CType(resources.GetObject("cmdnuevo.Image"), System.Drawing.Image)
        Me.cmdnuevo.Location = New System.Drawing.Point(7, 20)
        Me.cmdnuevo.Name = "cmdnuevo"
        Me.cmdnuevo.Size = New System.Drawing.Size(78, 32)
        Me.cmdnuevo.TabIndex = 0
        Me.cmdnuevo.Text = "Nuevo"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.cmdult)
        Me.GroupBox4.Controls.Add(Me.cmdsig)
        Me.GroupBox4.Controls.Add(Me.cmdatras)
        Me.GroupBox4.Controls.Add(Me.cmdpri)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(8, 121)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(184, 57)
        Me.GroupBox4.TabIndex = 46
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Opciones de navegación:"
        '
        'cmdult
        '
        Me.cmdult.Image = CType(resources.GetObject("cmdult.Image"), System.Drawing.Image)
        Me.cmdult.Location = New System.Drawing.Point(133, 19)
        Me.cmdult.Name = "cmdult"
        Me.cmdult.Size = New System.Drawing.Size(44, 32)
        Me.cmdult.TabIndex = 10
        '
        'cmdsig
        '
        Me.cmdsig.Image = CType(resources.GetObject("cmdsig.Image"), System.Drawing.Image)
        Me.cmdsig.Location = New System.Drawing.Point(90, 19)
        Me.cmdsig.Name = "cmdsig"
        Me.cmdsig.Size = New System.Drawing.Size(44, 32)
        Me.cmdsig.TabIndex = 9
        '
        'cmdatras
        '
        Me.cmdatras.Image = CType(resources.GetObject("cmdatras.Image"), System.Drawing.Image)
        Me.cmdatras.Location = New System.Drawing.Point(46, 20)
        Me.cmdatras.Name = "cmdatras"
        Me.cmdatras.Size = New System.Drawing.Size(45, 31)
        Me.cmdatras.TabIndex = 8
        '
        'cmdpri
        '
        Me.cmdpri.Image = CType(resources.GetObject("cmdpri.Image"), System.Drawing.Image)
        Me.cmdpri.Location = New System.Drawing.Point(2, 20)
        Me.cmdpri.Name = "cmdpri"
        Me.cmdpri.Size = New System.Drawing.Size(45, 31)
        Me.cmdpri.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtabrdestino)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtabrorigen)
        Me.GroupBox1.Controls.Add(Me.txtruta)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(8, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(628, 63)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de rutas:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(128, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "-"
        '
        'txtabrdestino
        '
        Me.txtabrdestino.Location = New System.Drawing.Point(147, 106)
        Me.txtabrdestino.Name = "txtabrdestino"
        Me.txtabrdestino.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtabrdestino.Size = New System.Drawing.Size(116, 20)
        Me.txtabrdestino.TabIndex = 38
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Este campo no puede quedar vacio"
        ConditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.Dxblanco.SetValidationRule(Me.txtabrdestino, ConditionValidationRule1)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(147, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Abreviatura Destino:"
        '
        'txtabrorigen
        '
        Me.txtabrorigen.Location = New System.Drawing.Point(6, 106)
        Me.txtabrorigen.Name = "txtabrorigen"
        Me.txtabrorigen.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtabrorigen.Size = New System.Drawing.Size(116, 20)
        Me.txtabrorigen.TabIndex = 36
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Este campo no puede quedar vacio"
        ConditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.Dxblanco.SetValidationRule(Me.txtabrorigen, ConditionValidationRule2)
        '
        'txtruta
        '
        Me.txtruta.Location = New System.Drawing.Point(6, 34)
        Me.txtruta.Name = "txtruta"
        Me.txtruta.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtruta.Size = New System.Drawing.Size(479, 20)
        Me.txtruta.TabIndex = 35
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Este campo no puede quedar vacio"
        ConditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.Dxblanco.SetValidationRule(Me.txtruta, ConditionValidationRule3)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(6, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Abreviatura Origen:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(6, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Ruta:"
        '
        'Dtsisbus
        '
        Me.Dtsisbus.DataSetName = "dtsisbus"
        Me.Dtsisbus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RutaBindingSource
        '
        Me.RutaBindingSource.DataMember = "ruta"
        Me.RutaBindingSource.DataSource = Me.Dtsisbus
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
        Me.TableAdapterManager.destinoTableAdapter = Nothing
        Me.TableAdapterManager.gastosTableAdapter = Nothing
        Me.TableAdapterManager.horarioTableAdapter = Nothing
        Me.TableAdapterManager.opcionesTableAdapter = Nothing
        Me.TableAdapterManager.rutaTableAdapter = Me.RutaTableAdapter
        Me.TableAdapterManager.ticketTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sisbuses.dtsisbusTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'ruta
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 181)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ruta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtabrdestino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtabrorigen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtruta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dxblanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtsisbus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RutaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtabrdestino As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtabrorigen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtruta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Dxblanco As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents Dtsisbus As Sisbuses.dtsisbus
    Friend WithEvents RutaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RutaTableAdapter As Sisbuses.dtsisbusTableAdapters.rutaTableAdapter
    Friend WithEvents TableAdapterManager As Sisbuses.dtsisbusTableAdapters.TableAdapterManager
End Class
