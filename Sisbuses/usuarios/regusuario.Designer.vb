<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class regusuario
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
        Dim PerfilLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(regusuario))
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.image = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtcontraseña = New DevExpress.XtraEditors.TextEdit()
        Me.txtusuario = New DevExpress.XtraEditors.TextEdit()
        Me.txtnombre = New DevExpress.XtraEditors.TextEdit()
        Me.opthabilitado = New DevExpress.XtraEditors.RadioGroup()
        Me.optperfil = New DevExpress.XtraEditors.RadioGroup()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Dxnombre = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.Dxusuario = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.Dxpass = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.Dtsisbus = New Sisbuses.dtsisbus()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New Sisbuses.dtsisbusTableAdapters.usuariosTableAdapter()
        Me.TableAdapterManager = New Sisbuses.dtsisbusTableAdapters.TableAdapterManager()
        Me.PerfilTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        PerfilLabel = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtcontraseña.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtusuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.opthabilitado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optperfil.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dxnombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dxusuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dxpass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtsisbus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerfilTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PerfilLabel
        '
        PerfilLabel.AutoSize = True
        PerfilLabel.Location = New System.Drawing.Point(670, 110)
        PerfilLabel.Name = "PerfilLabel"
        PerfilLabel.Size = New System.Drawing.Size(35, 13)
        PerfilLabel.TabIndex = 40
        PerfilLabel.Text = "perfil:"
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
        Me.GroupBox3.Location = New System.Drawing.Point(175, 221)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(481, 71)
        Me.GroupBox3.TabIndex = 39
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
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.cmdult)
        Me.GroupBox4.Controls.Add(Me.cmdsig)
        Me.GroupBox4.Controls.Add(Me.cmdatras)
        Me.GroupBox4.Controls.Add(Me.cmdpri)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(2, 221)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(172, 71)
        Me.GroupBox4.TabIndex = 38
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
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.image)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(422, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(167, 190)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos opcionales:"
        '
        'image
        '
        Me.image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.image.Image = Global.Sisbuses.My.Resources.Resources.user
        Me.image.Location = New System.Drawing.Point(7, 37)
        Me.image.Name = "image"
        Me.image.Size = New System.Drawing.Size(151, 134)
        Me.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.image.TabIndex = 32
        Me.image.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(6, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Foto:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtcontraseña)
        Me.GroupBox1.Controls.Add(Me.txtusuario)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.opthabilitado)
        Me.GroupBox1.Controls.Add(Me.optperfil)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(2, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(420, 190)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Caracteristicas del usuario:"
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Location = New System.Drawing.Point(8, 112)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtcontraseña.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcontraseña.Size = New System.Drawing.Size(286, 20)
        Me.txtcontraseña.TabIndex = 37
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "This value is not valid"
        ConditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.Dxpass.SetValidationRule(Me.txtcontraseña, ConditionValidationRule1)
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(6, 73)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtusuario.Size = New System.Drawing.Size(286, 20)
        Me.txtusuario.TabIndex = 36
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "This value is not valid"
        ConditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.Dxusuario.SetValidationRule(Me.txtusuario, ConditionValidationRule2)
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(6, 34)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtnombre.Size = New System.Drawing.Size(286, 20)
        Me.txtnombre.TabIndex = 35
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "This value is not valid"
        ConditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.Dxnombre.SetValidationRule(Me.txtnombre, ConditionValidationRule3)
        '
        'opthabilitado
        '
        Me.opthabilitado.EditValue = True
        Me.opthabilitado.Location = New System.Drawing.Point(190, 151)
        Me.opthabilitado.Name = "opthabilitado"
        Me.opthabilitado.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.opthabilitado.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.opthabilitado.Properties.Appearance.Options.UseBackColor = True
        Me.opthabilitado.Properties.Appearance.Options.UseForeColor = True
        Me.opthabilitado.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Habilitado"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Deshabilitado")})
        Me.opthabilitado.Size = New System.Drawing.Size(179, 28)
        Me.opthabilitado.TabIndex = 34
        '
        'optperfil
        '
        Me.optperfil.EditValue = Global.Microsoft.VisualBasic.ChrW(48)
        Me.optperfil.Location = New System.Drawing.Point(8, 151)
        Me.optperfil.Name = "optperfil"
        Me.optperfil.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.optperfil.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.optperfil.Properties.Appearance.Options.UseBackColor = True
        Me.optperfil.Properties.Appearance.Options.UseForeColor = True
        Me.optperfil.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Global.Microsoft.VisualBasic.ChrW(48), "Cajero"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Global.Microsoft.VisualBasic.ChrW(49), "Administrador")})
        Me.optperfil.Size = New System.Drawing.Size(179, 28)
        Me.optperfil.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(10, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Perfil:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(5, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Usuario:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(6, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(187, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Estado de la cuenta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(6, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Nombre:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(234, -1)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(180, 24)
        Me.LabelControl1.TabIndex = 40
        Me.LabelControl1.Text = "Registro de Usuarios"
        '
        'Dtsisbus
        '
        Me.Dtsisbus.DataSetName = "dtsisbus"
        Me.Dtsisbus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "usuarios"
        Me.UsuariosBindingSource.DataSource = Me.Dtsisbus
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.rutaTableAdapter = Nothing
        Me.TableAdapterManager.ticketTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sisbuses.dtsisbusTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Me.UsuariosTableAdapter
        '
        'PerfilTextEdit
        '
        Me.PerfilTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UsuariosBindingSource, "perfil", True))
        Me.PerfilTextEdit.Location = New System.Drawing.Point(711, 107)
        Me.PerfilTextEdit.Name = "PerfilTextEdit"
        Me.PerfilTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.PerfilTextEdit.TabIndex = 41
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'regusuario
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Appearance.ForeColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 295)
        Me.ControlBox = False
        Me.Controls.Add(PerfilLabel)
        Me.Controls.Add(Me.PerfilTextEdit)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "regusuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtcontraseña.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtusuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.opthabilitado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optperfil.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dxnombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dxusuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dxpass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtsisbus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerfilTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents image As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents opthabilitado As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents optperfil As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcontraseña As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtusuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtnombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Dtsisbus As Sisbuses.dtsisbus
    Friend WithEvents UsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuariosTableAdapter As Sisbuses.dtsisbusTableAdapters.usuariosTableAdapter
    Friend WithEvents TableAdapterManager As Sisbuses.dtsisbusTableAdapters.TableAdapterManager
    Friend WithEvents Dxpass As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents Dxusuario As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents Dxnombre As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents PerfilTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
