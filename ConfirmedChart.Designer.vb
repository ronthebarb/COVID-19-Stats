<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmedChart
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me._COVID_19DataSet1 = New VBProject2._COVID_19DataSet()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Time_series_covid19_confirmed_globalTableAdapter = New VBProject2._COVID_19DataSetTableAdapters.time_series_covid19_confirmed_globalTableAdapter()
        Me.GeoMap1 = New LiveCharts.WinForms.GeoMap()
        Me.CartesianChart1 = New LiveCharts.WinForms.CartesianChart()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me._COVID_19DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        '_COVID_19DataSet1
        '
        Me._COVID_19DataSet1.DataSetName = "_COVID_19DataSet"
        Me._COVID_19DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "time_series_covid19_confirmed_global"
        Me.BindingSource1.DataSource = Me._COVID_19DataSet1
        '
        'Time_series_covid19_confirmed_globalTableAdapter
        '
        Me.Time_series_covid19_confirmed_globalTableAdapter.ClearBeforeFill = True
        '
        'GeoMap1
        '
        Me.GeoMap1.Location = New System.Drawing.Point(291, 152)
        Me.GeoMap1.Name = "GeoMap1"
        Me.GeoMap1.Size = New System.Drawing.Size(200, 100)
        Me.GeoMap1.TabIndex = 0
        Me.GeoMap1.Text = "GeoMap1"
        '
        'CartesianChart1
        '
        Me.CartesianChart1.Location = New System.Drawing.Point(7, 45)
        Me.CartesianChart1.Name = "CartesianChart1"
        Me.CartesianChart1.Size = New System.Drawing.Size(781, 393)
        Me.CartesianChart1.TabIndex = 1
        Me.CartesianChart1.Text = "CartesianChart1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ConfirmedChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CartesianChart1)
        Me.Controls.Add(Me.GeoMap1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ConfirmedChart"
        Me.Text = "ConfirmedChart"
        CType(Me._COVID_19DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _COVID_19DataSet1 As _COVID_19DataSet
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Time_series_covid19_confirmed_globalTableAdapter As _COVID_19DataSetTableAdapters.time_series_covid19_confirmed_globalTableAdapter
    Friend WithEvents GeoMap1 As LiveCharts.WinForms.GeoMap
    Friend WithEvents CartesianChart1 As LiveCharts.WinForms.CartesianChart
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
