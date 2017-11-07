<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clave
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clave))
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule4 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdguardar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdsalir = New DevExpress.XtraEditors.SimpleButton()
        Me.txtpassvery = New DevExpress.XtraEditors.TextEdit()
        Me.txtpassnueva = New DevExpress.XtraEditors.TextEdit()
        Me.txtpassactual = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dxpassactual = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.Dxpassnueva = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.Dxpassveri = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.Dxpassverib = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.Dtsisbus = New Sisbuses.dtsisbus()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New Sisbuses.dtsisbusTableAdapters.usuariosTableAdapter()
        Me.TableAdapterManager = New Sisbuses.dtsisbusTableAdapters.TableAdapterManager()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtpassvery.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpassnueva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpassactual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dxpassactual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dxpassnueva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dxpassveri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dxpassverib, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtsisbus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(199, 24)
        Me.LabelControl1.TabIndex = 42
        Me.LabelControl1.Text = "Cambio de Contraseña"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cmdguardar)
        Me.GroupBox1.Controls.Add(Me.cmdsalir)
        Me.GroupBox1.Controls.Add(Me.txtpassvery)
        Me.GroupBox1.Controls.Add(Me.txtpassnueva)
        Me.GroupBox1.Controls.Add(Me.txtpassactual)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(2, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 199)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de contraseña:"
        '
        'cmdguardar
        '
        Me.cmdguardar.Image = CType(resources.GetObject("cmdguardar.Image"), System.Drawing.Image)
        Me.cmdguardar.Location = New System.Drawing.Point(16, 147)
        Me.cmdguardar.Name = "cmdguardar"
        Me.cmdguardar.Size = New System.Drawing.Size(92, 41)
        Me.cmdguardar.TabIndex = 38
        Me.cmdguardar.Text = "Guardar"
        '
        'cmdsalir
        '
        Me.cmdsalir.Image = CType(resources.GetObject("cmdsalir.Image"), System.Drawing.Image)
        Me.cmdsalir.Location = New System.Drawing.Point(108, 147)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(92, 41)
        Me.cmdsalir.TabIndex = 39
        Me.cmdsalir.Text = "Salir"
        '
        'txtpassvery
        '
        Me.txtpassvery.Location = New System.Drawing.Point(6, 121)
        Me.txtpassvery.Name = "txtpassvery"
        Me.txtpassvery.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtpassvery.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassvery.Size = New System.Drawing.Size(213, 20)
        Me.txtpassvery.TabIndex = 37
        ConditionValidationRule1.ErrorText = "Esta contraseña no concuerda con nueva contraseña"
        ConditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.Dxpassveri.SetValidationRule(Me.txtpassvery, ConditionValidationRule1)
        ConditionValidationRule2.ErrorText = "Este campo no puede Quedar en blanco"
        Me.Dxpassverib.SetValidationRule(Me.txtpassvery, ConditionValidationRule2)
        '
        'txtpassnueva
        '
        Me.txtpassnueva.Location = New System.Drawing.Point(5, 79)
        Me.txtpassnueva.Name = "txtpassnueva"
        Me.txtpassnueva.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtpassnueva.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassnueva.Size = New System.Drawing.Size(214, 20)
        Me.txtpassnueva.TabIndex = 36
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Este campo no puede quedar en blanco"
        ConditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.Dxpassnueva.SetValidationRule(Me.txtpassnueva, ConditionValidationRule3)
        '
        'txtpassactual
        '
        Me.txtpassactual.Location = New System.Drawing.Point(5, 40)
        Me.txtpassactual.Name = "txtpassactual"
        Me.txtpassactual.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtpassactual.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassactual.Size = New System.Drawing.Size(214, 20)
        Me.txtpassactual.TabIndex = 35
        ConditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule4.ErrorText = "Este campo no debe estar en blanco"
        ConditionValidationRule4.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.Dxpassactual.SetValidationRule(Me.txtpassactual, ConditionValidationRule4)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(6, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Nueva contraseña:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(6, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Confirmar su nueva contraseña:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(2, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Contraseña actual:"
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
        'clave
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Appearance.ForeColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 258)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "clave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtpassvery.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpassnueva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpassactual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dxpassactual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dxpassnueva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dxpassveri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dxpassverib, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtsisbus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtpassvery As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtpassnueva As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtpassactual As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdguardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Dxpassverib As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents Dxpassveri As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents Dxpassnueva As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents Dxpassactual As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents Dtsisbus As Sisbuses.dtsisbus
    Friend WithEvents UsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuariosTableAdapter As Sisbuses.dtsisbusTableAdapters.usuariosTableAdapter
    Friend WithEvents TableAdapterManager As Sisbuses.dtsisbusTableAdapters.TableAdapterManager
End Class
