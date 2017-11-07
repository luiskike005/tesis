<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Me.Dtsisbus = New Sisbuses.dtsisbus()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New Sisbuses.dtsisbusTableAdapters.usuariosTableAdapter()
        Me.TableAdapterManager = New Sisbuses.dtsisbusTableAdapters.TableAdapterManager()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbousuario = New System.Windows.Forms.ComboBox()
        Me.cmdsalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdacceso = New DevExpress.XtraEditors.SimpleButton()
        Me.txtclave = New DevExpress.XtraEditors.TextEdit()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.Dtsisbus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtclave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TableAdapterManager.UpdateOrder = Sisbuses.dtsisbusTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Me.UsuariosTableAdapter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sisbuses.My.Resources.Resources.login
        Me.PictureBox1.Location = New System.Drawing.Point(-15, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(395, 249)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'cbousuario
        '
        Me.cbousuario.DataSource = Me.UsuariosBindingSource
        Me.cbousuario.DisplayMember = "nick"
        Me.cbousuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbousuario.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbousuario.FormattingEnabled = True
        Me.cbousuario.Location = New System.Drawing.Point(108, 122)
        Me.cbousuario.Name = "cbousuario"
        Me.cbousuario.Size = New System.Drawing.Size(206, 24)
        Me.cbousuario.TabIndex = 9
        Me.cbousuario.ValueMember = "idusuario"
        '
        'cmdsalir
        '
        Me.cmdsalir.BackgroundImage = CType(resources.GetObject("cmdsalir.BackgroundImage"), System.Drawing.Image)
        Me.cmdsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdsalir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.cmdsalir.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdsalir.Location = New System.Drawing.Point(138, 185)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(96, 34)
        Me.cmdsalir.TabIndex = 8
        Me.cmdsalir.Text = "Salir"
        '
        'cmdacceso
        '
        Me.cmdacceso.BackgroundImage = CType(resources.GetObject("cmdacceso.BackgroundImage"), System.Drawing.Image)
        Me.cmdacceso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdacceso.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.cmdacceso.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdacceso.Location = New System.Drawing.Point(36, 185)
        Me.cmdacceso.Name = "cmdacceso"
        Me.cmdacceso.Size = New System.Drawing.Size(96, 34)
        Me.cmdacceso.TabIndex = 7
        Me.cmdacceso.Text = "Acceso"
        '
        'txtclave
        '
        Me.txtclave.Location = New System.Drawing.Point(108, 157)
        Me.txtclave.Name = "txtclave"
        Me.txtclave.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtclave.Properties.Appearance.Options.UseFont = True
        Me.txtclave.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtclave.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtclave.Size = New System.Drawing.Size(206, 20)
        Me.txtclave.TabIndex = 10
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "El campo clave no puede estar vacio"
        ConditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.DxValidationProvider1.SetValidationRule(Me.txtclave, ConditionValidationRule1)
        '
        'DxValidationProvider1
        '
        Me.DxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'login
        '
        Me.AcceptButton = Me.cmdacceso
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 243)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtclave)
        Me.Controls.Add(Me.cbousuario)
        Me.Controls.Add(Me.cmdsalir)
        Me.Controls.Add(Me.cmdacceso)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.Dtsisbus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtclave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Dtsisbus As Sisbuses.dtsisbus
    Friend WithEvents UsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuariosTableAdapter As Sisbuses.dtsisbusTableAdapters.usuariosTableAdapter
    Friend WithEvents TableAdapterManager As Sisbuses.dtsisbusTableAdapters.TableAdapterManager
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cbousuario As System.Windows.Forms.ComboBox
    Friend WithEvents cmdsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdacceso As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtclave As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
End Class
