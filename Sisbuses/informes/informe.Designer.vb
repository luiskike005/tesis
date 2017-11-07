<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class informe
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Dtsisbus = New Sisbuses.dtsisbus()
        Me.GastosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GastosTableAdapter = New Sisbuses.dtsisbusTableAdapters.gastosTableAdapter()
        Me.TableAdapterManager = New Sisbuses.dtsisbusTableAdapters.TableAdapterManager()
        Me.DestinoTableAdapter = New Sisbuses.dtsisbusTableAdapters.destinoTableAdapter()
        Me.HorarioTableAdapter = New Sisbuses.dtsisbusTableAdapters.horarioTableAdapter()
        Me.RutaTableAdapter = New Sisbuses.dtsisbusTableAdapters.rutaTableAdapter()
        Me.HorarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DestinoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RutaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VistahorarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VistahorarioTableAdapter = New Sisbuses.dtsisbusTableAdapters.vistahorarioTableAdapter()
        Me.VistagastoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VistagastoTableAdapter = New Sisbuses.dtsisbusTableAdapters.vistagastoTableAdapter()
        Me.VistaticketBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VistaticketTableAdapter = New Sisbuses.dtsisbusTableAdapters.vistaticketTableAdapter()
        CType(Me.Dtsisbus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GastosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RutaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistahorarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistagastoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaticketBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.CachedPageNumberPerDoc = 10
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(836, 432)
        Me.CrystalReportViewer1.TabIndex = 0
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
        Me.TableAdapterManager.destinoTableAdapter = Me.DestinoTableAdapter
        Me.TableAdapterManager.gastosTableAdapter = Me.GastosTableAdapter
        Me.TableAdapterManager.horarioTableAdapter = Me.HorarioTableAdapter
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
        'HorarioTableAdapter
        '
        Me.HorarioTableAdapter.ClearBeforeFill = True
        '
        'RutaTableAdapter
        '
        Me.RutaTableAdapter.ClearBeforeFill = True
        '
        'HorarioBindingSource
        '
        Me.HorarioBindingSource.DataMember = "horario"
        Me.HorarioBindingSource.DataSource = Me.Dtsisbus
        '
        'DestinoBindingSource
        '
        Me.DestinoBindingSource.DataMember = "destino"
        Me.DestinoBindingSource.DataSource = Me.Dtsisbus
        '
        'RutaBindingSource
        '
        Me.RutaBindingSource.DataMember = "ruta"
        Me.RutaBindingSource.DataSource = Me.Dtsisbus
        '
        'VistahorarioBindingSource
        '
        Me.VistahorarioBindingSource.DataMember = "vistahorario"
        Me.VistahorarioBindingSource.DataSource = Me.Dtsisbus
        '
        'VistahorarioTableAdapter
        '
        Me.VistahorarioTableAdapter.ClearBeforeFill = True
        '
        'VistagastoBindingSource
        '
        Me.VistagastoBindingSource.DataMember = "vistagasto"
        Me.VistagastoBindingSource.DataSource = Me.Dtsisbus
        '
        'VistagastoTableAdapter
        '
        Me.VistagastoTableAdapter.ClearBeforeFill = True
        '
        'VistaticketBindingSource
        '
        Me.VistaticketBindingSource.DataMember = "vistaticket"
        Me.VistaticketBindingSource.DataSource = Me.Dtsisbus
        '
        'VistaticketTableAdapter
        '
        Me.VistaticketTableAdapter.ClearBeforeFill = True
        '
        'informe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 432)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "informe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Dtsisbus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GastosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HorarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RutaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistahorarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistagastoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaticketBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Dtsisbus As Sisbuses.dtsisbus
    Friend WithEvents GastosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GastosTableAdapter As Sisbuses.dtsisbusTableAdapters.gastosTableAdapter
    Friend WithEvents TableAdapterManager As Sisbuses.dtsisbusTableAdapters.TableAdapterManager
    Friend WithEvents HorarioTableAdapter As Sisbuses.dtsisbusTableAdapters.horarioTableAdapter
    Friend WithEvents HorarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DestinoTableAdapter As Sisbuses.dtsisbusTableAdapters.destinoTableAdapter
    Friend WithEvents DestinoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RutaTableAdapter As Sisbuses.dtsisbusTableAdapters.rutaTableAdapter
    Friend WithEvents RutaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VistahorarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VistahorarioTableAdapter As Sisbuses.dtsisbusTableAdapters.vistahorarioTableAdapter
    Friend WithEvents VistagastoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VistagastoTableAdapter As Sisbuses.dtsisbusTableAdapters.vistagastoTableAdapter
    Friend WithEvents VistaticketBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VistaticketTableAdapter As Sisbuses.dtsisbusTableAdapters.vistaticketTableAdapter
End Class
