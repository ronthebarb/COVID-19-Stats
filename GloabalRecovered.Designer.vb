<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GlobalRecovered
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FIPSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Admin2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvinceStateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountryRegionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastUpdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LongDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConfirmedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeathsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecoveredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActiveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CombinedKeyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GlobalDailyReportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._COVID_19DataSet = New VBProject2._COVID_19DataSet()
        Me.Global_Daily_ReportsTableAdapter = New VBProject2._COVID_19DataSetTableAdapters.Global_Daily_ReportsTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GlobalDailyReportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._COVID_19DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FIPSDataGridViewTextBoxColumn, Me.Admin2DataGridViewTextBoxColumn, Me.ProvinceStateDataGridViewTextBoxColumn, Me.CountryRegionDataGridViewTextBoxColumn, Me.LastUpdateDataGridViewTextBoxColumn, Me.LatDataGridViewTextBoxColumn, Me.LongDataGridViewTextBoxColumn, Me.ConfirmedDataGridViewTextBoxColumn, Me.DeathsDataGridViewTextBoxColumn, Me.RecoveredDataGridViewTextBoxColumn, Me.ActiveDataGridViewTextBoxColumn, Me.CombinedKeyDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GlobalDailyReportsBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(800, 450)
        Me.DataGridView1.TabIndex = 0
        '
        'FIPSDataGridViewTextBoxColumn
        '
        Me.FIPSDataGridViewTextBoxColumn.DataPropertyName = "FIPS"
        Me.FIPSDataGridViewTextBoxColumn.HeaderText = "FIPS"
        Me.FIPSDataGridViewTextBoxColumn.Name = "FIPSDataGridViewTextBoxColumn"
        Me.FIPSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Admin2DataGridViewTextBoxColumn
        '
        Me.Admin2DataGridViewTextBoxColumn.DataPropertyName = "Admin2"
        Me.Admin2DataGridViewTextBoxColumn.HeaderText = "Admin2"
        Me.Admin2DataGridViewTextBoxColumn.Name = "Admin2DataGridViewTextBoxColumn"
        Me.Admin2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProvinceStateDataGridViewTextBoxColumn
        '
        Me.ProvinceStateDataGridViewTextBoxColumn.DataPropertyName = "Province_State"
        Me.ProvinceStateDataGridViewTextBoxColumn.HeaderText = "Province_State"
        Me.ProvinceStateDataGridViewTextBoxColumn.Name = "ProvinceStateDataGridViewTextBoxColumn"
        Me.ProvinceStateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CountryRegionDataGridViewTextBoxColumn
        '
        Me.CountryRegionDataGridViewTextBoxColumn.DataPropertyName = "Country_Region"
        Me.CountryRegionDataGridViewTextBoxColumn.HeaderText = "Country_Region"
        Me.CountryRegionDataGridViewTextBoxColumn.Name = "CountryRegionDataGridViewTextBoxColumn"
        Me.CountryRegionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastUpdateDataGridViewTextBoxColumn
        '
        Me.LastUpdateDataGridViewTextBoxColumn.DataPropertyName = "Last_Update"
        Me.LastUpdateDataGridViewTextBoxColumn.HeaderText = "Last_Update"
        Me.LastUpdateDataGridViewTextBoxColumn.Name = "LastUpdateDataGridViewTextBoxColumn"
        Me.LastUpdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LatDataGridViewTextBoxColumn
        '
        Me.LatDataGridViewTextBoxColumn.DataPropertyName = "Lat"
        Me.LatDataGridViewTextBoxColumn.HeaderText = "Lat"
        Me.LatDataGridViewTextBoxColumn.Name = "LatDataGridViewTextBoxColumn"
        Me.LatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LongDataGridViewTextBoxColumn
        '
        Me.LongDataGridViewTextBoxColumn.DataPropertyName = "Long"
        Me.LongDataGridViewTextBoxColumn.HeaderText = "Long"
        Me.LongDataGridViewTextBoxColumn.Name = "LongDataGridViewTextBoxColumn"
        Me.LongDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ConfirmedDataGridViewTextBoxColumn
        '
        Me.ConfirmedDataGridViewTextBoxColumn.DataPropertyName = "Confirmed"
        Me.ConfirmedDataGridViewTextBoxColumn.HeaderText = "Confirmed"
        Me.ConfirmedDataGridViewTextBoxColumn.Name = "ConfirmedDataGridViewTextBoxColumn"
        Me.ConfirmedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DeathsDataGridViewTextBoxColumn
        '
        Me.DeathsDataGridViewTextBoxColumn.DataPropertyName = "Deaths"
        Me.DeathsDataGridViewTextBoxColumn.HeaderText = "Deaths"
        Me.DeathsDataGridViewTextBoxColumn.Name = "DeathsDataGridViewTextBoxColumn"
        Me.DeathsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RecoveredDataGridViewTextBoxColumn
        '
        Me.RecoveredDataGridViewTextBoxColumn.DataPropertyName = "Recovered"
        Me.RecoveredDataGridViewTextBoxColumn.HeaderText = "Recovered"
        Me.RecoveredDataGridViewTextBoxColumn.Name = "RecoveredDataGridViewTextBoxColumn"
        Me.RecoveredDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ActiveDataGridViewTextBoxColumn
        '
        Me.ActiveDataGridViewTextBoxColumn.DataPropertyName = "Active"
        Me.ActiveDataGridViewTextBoxColumn.HeaderText = "Active"
        Me.ActiveDataGridViewTextBoxColumn.Name = "ActiveDataGridViewTextBoxColumn"
        Me.ActiveDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CombinedKeyDataGridViewTextBoxColumn
        '
        Me.CombinedKeyDataGridViewTextBoxColumn.DataPropertyName = "Combined_Key"
        Me.CombinedKeyDataGridViewTextBoxColumn.HeaderText = "Combined_Key"
        Me.CombinedKeyDataGridViewTextBoxColumn.Name = "CombinedKeyDataGridViewTextBoxColumn"
        Me.CombinedKeyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GlobalDailyReportsBindingSource
        '
        Me.GlobalDailyReportsBindingSource.DataMember = "Global_Daily_Reports"
        Me.GlobalDailyReportsBindingSource.DataSource = Me._COVID_19DataSet
        '
        '_COVID_19DataSet
        '
        Me._COVID_19DataSet.DataSetName = "_COVID_19DataSet"
        Me._COVID_19DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Global_Daily_ReportsTableAdapter
        '
        Me.Global_Daily_ReportsTableAdapter.ClearBeforeFill = True
        '
        'GlobalRecovered
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "GlobalRecovered"
        Me.Text = "GlobalRecovered"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GlobalDailyReportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._COVID_19DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents _COVID_19DataSet As _COVID_19DataSet
    Friend WithEvents GlobalDailyReportsBindingSource As BindingSource
    Friend WithEvents Global_Daily_ReportsTableAdapter As _COVID_19DataSetTableAdapters.Global_Daily_ReportsTableAdapter
    Friend WithEvents FIPSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Admin2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProvinceStateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CountryRegionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastUpdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LongDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConfirmedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeathsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecoveredDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActiveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CombinedKeyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
