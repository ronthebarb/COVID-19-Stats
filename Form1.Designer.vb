<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CartesianChart1 = New LiveCharts.WinForms.CartesianChart()
        Me.ConfirmedUS_DataSet = New VBProject2.ConfirmedUS_DataSet()
        Me.Timeseriescovid19confirmedUSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Time_series_covid19_confirmed_USTableAdapter = New VBProject2.ConfirmedUS_DataSetTableAdapters.time_series_covid19_confirmed_USTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USConfirmedCasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfirmedChartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USDailyReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USDeathsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GlobalConfirmedCasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowItalyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GlobalDailyReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GlobalsDeathsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.ConfirmedUS_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Timeseriescovid19confirmedUSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(800, 426)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(792, 400)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(116, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(566, 209)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(16, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(531, 180)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(421, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COVID-19 Data Tables"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CartesianChart1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(792, 400)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CartesianChart1
        '
        Me.CartesianChart1.Location = New System.Drawing.Point(66, 48)
        Me.CartesianChart1.Name = "CartesianChart1"
        Me.CartesianChart1.Size = New System.Drawing.Size(657, 327)
        Me.CartesianChart1.TabIndex = 0
        Me.CartesianChart1.Text = "CartesianChart1"
        '
        'ConfirmedUS_DataSet
        '
        Me.ConfirmedUS_DataSet.DataSetName = "ConfirmedUS_DataSet"
        Me.ConfirmedUS_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Timeseriescovid19confirmedUSBindingSource
        '
        Me.Timeseriescovid19confirmedUSBindingSource.DataMember = "time_series_covid19_confirmed_US"
        Me.Timeseriescovid19confirmedUSBindingSource.DataSource = Me.ConfirmedUS_DataSet
        '
        'Time_series_covid19_confirmed_USTableAdapter
        '
        Me.Time_series_covid19_confirmed_USTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
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
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.USConfirmedCasesToolStripMenuItem, Me.USDailyReportsToolStripMenuItem, Me.USDeathsToolStripMenuItem, Me.GlobalConfirmedCasesToolStripMenuItem, Me.GlobalDailyReportsToolStripMenuItem, Me.GlobalsDeathsToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.ViewToolStripMenuItem.Text = "Tables"
        '
        'USConfirmedCasesToolStripMenuItem
        '
        Me.USConfirmedCasesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfirmedChartToolStripMenuItem})
        Me.USConfirmedCasesToolStripMenuItem.Name = "USConfirmedCasesToolStripMenuItem"
        Me.USConfirmedCasesToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.USConfirmedCasesToolStripMenuItem.Text = "US Confirmed Cases"
        '
        'ConfirmedChartToolStripMenuItem
        '
        Me.ConfirmedChartToolStripMenuItem.Name = "ConfirmedChartToolStripMenuItem"
        Me.ConfirmedChartToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ConfirmedChartToolStripMenuItem.Text = "Confirmed Chart"
        '
        'USDailyReportsToolStripMenuItem
        '
        Me.USDailyReportsToolStripMenuItem.Name = "USDailyReportsToolStripMenuItem"
        Me.USDailyReportsToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.USDailyReportsToolStripMenuItem.Text = "US Daily Reports"
        '
        'USDeathsToolStripMenuItem
        '
        Me.USDeathsToolStripMenuItem.Name = "USDeathsToolStripMenuItem"
        Me.USDeathsToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.USDeathsToolStripMenuItem.Text = "US Deaths"
        '
        'GlobalConfirmedCasesToolStripMenuItem
        '
        Me.GlobalConfirmedCasesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowItalyToolStripMenuItem})
        Me.GlobalConfirmedCasesToolStripMenuItem.Name = "GlobalConfirmedCasesToolStripMenuItem"
        Me.GlobalConfirmedCasesToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.GlobalConfirmedCasesToolStripMenuItem.Text = "Global Deaths"
        '
        'ShowItalyToolStripMenuItem
        '
        Me.ShowItalyToolStripMenuItem.Name = "ShowItalyToolStripMenuItem"
        Me.ShowItalyToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ShowItalyToolStripMenuItem.Text = "Find Country"
        '
        'GlobalDailyReportsToolStripMenuItem
        '
        Me.GlobalDailyReportsToolStripMenuItem.Name = "GlobalDailyReportsToolStripMenuItem"
        Me.GlobalDailyReportsToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.GlobalDailyReportsToolStripMenuItem.Text = "Global Confirmed Cases"
        '
        'GlobalsDeathsToolStripMenuItem
        '
        Me.GlobalsDeathsToolStripMenuItem.Name = "GlobalsDeathsToolStripMenuItem"
        Me.GlobalsDeathsToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.GlobalsDeathsToolStripMenuItem.Text = "Globals Recovered"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.ConfirmedUS_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Timeseriescovid19confirmedUSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents CartesianChart1 As LiveCharts.WinForms.CartesianChart
    Friend WithEvents ConfirmedUS_DataSet As ConfirmedUS_DataSet
    Friend WithEvents Timeseriescovid19confirmedUSBindingSource As BindingSource
    Friend WithEvents Time_series_covid19_confirmed_USTableAdapter As ConfirmedUS_DataSetTableAdapters.time_series_covid19_confirmed_USTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents USConfirmedCasesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents USDailyReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents USDeathsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GlobalConfirmedCasesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GlobalDailyReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GlobalsDeathsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowItalyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfirmedChartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
End Class
