<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class respaldo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(respaldo))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmddireccion1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtdireccion1 = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdrespaldo = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdsalir = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdcarga = New DevExpress.XtraEditors.SimpleButton()
        Me.cmddireccion2 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtdireccion2 = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtdireccion1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtdireccion2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Location = New System.Drawing.Point(177, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(281, 24)
        Me.LabelControl1.TabIndex = 44
        Me.LabelControl1.Text = "Respaldo y Carga de Base Datos"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cmddireccion1)
        Me.GroupBox1.Controls.Add(Me.txtdireccion1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(2, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 74)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        '
        'cmddireccion1
        '
        Me.cmddireccion1.Location = New System.Drawing.Point(457, 38)
        Me.cmddireccion1.Name = "cmddireccion1"
        Me.cmddireccion1.Size = New System.Drawing.Size(30, 23)
        Me.cmddireccion1.TabIndex = 40
        Me.cmddireccion1.Text = "..."
        '
        'txtdireccion1
        '
        Me.txtdireccion1.Enabled = False
        Me.txtdireccion1.Location = New System.Drawing.Point(5, 40)
        Me.txtdireccion1.Name = "txtdireccion1"
        Me.txtdireccion1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtdireccion1.Size = New System.Drawing.Size(451, 20)
        Me.txtdireccion1.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(2, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Destino para respaldo base datos:"
        '
        'cmdrespaldo
        '
        Me.cmdrespaldo.Location = New System.Drawing.Point(489, 93)
        Me.cmdrespaldo.Name = "cmdrespaldo"
        Me.cmdrespaldo.Size = New System.Drawing.Size(90, 25)
        Me.cmdrespaldo.TabIndex = 45
        Me.cmdrespaldo.Text = "Hacer Respaldo"
        '
        'cmdsalir
        '
        Me.cmdsalir.Image = CType(resources.GetObject("cmdsalir.Image"), System.Drawing.Image)
        Me.cmdsalir.Location = New System.Drawing.Point(494, 216)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(92, 41)
        Me.cmdsalir.TabIndex = 46
        Me.cmdsalir.Text = "Salir"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.cmdcarga)
        Me.GroupBox2.Controls.Add(Me.cmddireccion2)
        Me.GroupBox2.Controls.Add(Me.txtdireccion2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(2, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(584, 74)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        '
        'cmdcarga
        '
        Me.cmdcarga.Location = New System.Drawing.Point(487, 37)
        Me.cmdcarga.Name = "cmdcarga"
        Me.cmdcarga.Size = New System.Drawing.Size(90, 25)
        Me.cmdcarga.TabIndex = 47
        Me.cmdcarga.Text = "Cargar Respaldo"
        '
        'cmddireccion2
        '
        Me.cmddireccion2.Location = New System.Drawing.Point(457, 38)
        Me.cmddireccion2.Name = "cmddireccion2"
        Me.cmddireccion2.Size = New System.Drawing.Size(30, 23)
        Me.cmddireccion2.TabIndex = 40
        Me.cmddireccion2.Text = "..."
        '
        'txtdireccion2
        '
        Me.txtdireccion2.Enabled = False
        Me.txtdireccion2.Location = New System.Drawing.Point(5, 40)
        Me.txtdireccion2.Name = "txtdireccion2"
        Me.txtdireccion2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtdireccion2.Size = New System.Drawing.Size(451, 20)
        Me.txtdireccion2.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(2, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Origen para cargar respaldo base datos:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'respaldo
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 265)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdrespaldo)
        Me.Controls.Add(Me.cmdsalir)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "respaldo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtdireccion1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtdireccion2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmddireccion1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtdireccion1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdrespaldo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdcarga As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmddireccion2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtdireccion2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
End Class
