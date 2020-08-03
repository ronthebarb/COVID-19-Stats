<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class USDailyReports
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
        Me.ProvinceStateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountryRegionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastUpdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LongDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConfirmedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeathsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecoveredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActiveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIPSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IncidentRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeopleTestedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeopleHospitalizedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MortalityRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISO3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestingRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HospitalizationRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USDailyReportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._COVID_19DataSet = New VBProject2._COVID_19DataSet()
        Me.US_Daily_ReportsTableAdapter = New VBProject2._COVID_19DataSetTableAdapters.US_Daily_ReportsTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USDailyReportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProvinceStateDataGridViewTextBoxColumn, Me.CountryRegionDataGridViewTextBoxColumn, Me.LastUpdateDataGridViewTextBoxColumn, Me.LatDataGridViewTextBoxColumn, Me.LongDataGridViewTextBoxColumn, Me.ConfirmedDataGridViewTextBoxColumn, Me.DeathsDataGridViewTextBoxColumn, Me.RecoveredDataGridViewTextBoxColumn, Me.ActiveDataGridViewTextBoxColumn, Me.FIPSDataGridViewTextBoxColumn, Me.IncidentRateDataGridViewTextBoxColumn, Me.PeopleTestedDataGridViewTextBoxColumn, Me.PeopleHospitalizedDataGridViewTextBoxColumn, Me.MortalityRateDataGridViewTextBoxColumn, Me.UIDDataGridViewTextBoxColumn, Me.ISO3DataGridViewTextBoxColumn, Me.TestingRateDataGridViewTextBoxColumn, Me.HospitalizationRateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.USDailyReportsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(1, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(798, 447)
        Me.DataGridView1.TabIndex = 0
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
        'FIPSDataGridViewTextBoxColumn
        '
        Me.FIPSDataGridViewTextBoxColumn.DataPropertyName = "FIPS"
        Me.FIPSDataGridViewTextBoxColumn.HeaderText = "FIPS"
        Me.FIPSDataGridViewTextBoxColumn.Name = "FIPSDataGridViewTextBoxColumn"
        Me.FIPSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IncidentRateDataGridViewTextBoxColumn
        '
        Me.IncidentRateDataGridViewTextBoxColumn.DataPropertyName = "Incident_Rate"
        Me.IncidentRateDataGridViewTextBoxColumn.HeaderText = "Incident_Rate"
        Me.IncidentRateDataGridViewTextBoxColumn.Name = "IncidentRateDataGridViewTextBoxColumn"
        Me.IncidentRateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PeopleTestedDataGridViewTextBoxColumn
        '
        Me.PeopleTestedDataGridViewTextBoxColumn.DataPropertyName = "People_Tested"
        Me.PeopleTestedDataGridViewTextBoxColumn.HeaderText = "People_Tested"
        Me.PeopleTestedDataGridViewTextBoxColumn.Name = "PeopleTestedDataGridViewTextBoxColumn"
        Me.PeopleTestedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PeopleHospitalizedDataGridViewTextBoxColumn
        '
        Me.PeopleHospitalizedDataGridViewTextBoxColumn.DataPropertyName = "People_Hospitalized"
        Me.PeopleHospitalizedDataGridViewTextBoxColumn.HeaderText = "People_Hospitalized"
        Me.PeopleHospitalizedDataGridViewTextBoxColumn.Name = "PeopleHospitalizedDataGridViewTextBoxColumn"
        Me.PeopleHospitalizedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MortalityRateDataGridViewTextBoxColumn
        '
        Me.MortalityRateDataGridViewTextBoxColumn.DataPropertyName = "Mortality_Rate"
        Me.MortalityRateDataGridViewTextBoxColumn.HeaderText = "Mortality_Rate"
        Me.MortalityRateDataGridViewTextBoxColumn.Name = "MortalityRateDataGridViewTextBoxColumn"
        Me.MortalityRateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UIDDataGridViewTextBoxColumn
        '
        Me.UIDDataGridViewTextBoxColumn.DataPropertyName = "UID"
        Me.UIDDataGridViewTextBoxColumn.HeaderText = "UID"
        Me.UIDDataGridViewTextBoxColumn.Name = "UIDDataGridViewTextBoxColumn"
        Me.UIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ISO3DataGridViewTextBoxColumn
        '
        Me.ISO3DataGridViewTextBoxColumn.DataPropertyName = "ISO3"
        Me.ISO3DataGridViewTextBoxColumn.HeaderText = "ISO3"
        Me.ISO3DataGridViewTextBoxColumn.Name = "ISO3DataGridViewTextBoxColumn"
        Me.ISO3DataGridViewTextBoxColumn.ReadOnly = True
        '
        'TestingRateDataGridViewTextBoxColumn
        '
        Me.TestingRateDataGridViewTextBoxColumn.DataPropertyName = "Testing_Rate"
        Me.TestingRateDataGridViewTextBoxColumn.HeaderText = "Testing_Rate"
        Me.TestingRateDataGridViewTextBoxColumn.Name = "TestingRateDataGridViewTextBoxColumn"
        Me.TestingRateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HospitalizationRateDataGridViewTextBoxColumn
        '
        Me.HospitalizationRateDataGridViewTextBoxColumn.DataPropertyName = "Hospitalization_Rate"
        Me.HospitalizationRateDataGridViewTextBoxColumn.HeaderText = "Hospitalization_Rate"
        Me.HospitalizationRateDataGridViewTextBoxColumn.Name = "HospitalizationRateDataGridViewTextBoxColumn"
        Me.HospitalizationRateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'USDailyReportsBindingSource
        '
        Me.USDailyReportsBindingSource.DataMember = "US_Daily_Reports"
        Me.USDailyReportsBindingSource.DataSource = Me._COVID_19DataSet
        '
        '_COVID_19DataSet
        '
        Me._COVID_19DataSet.DataSetName = "_COVID_19DataSet"
        Me._COVID_19DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'US_Daily_ReportsTableAdapter
        '
        Me.US_Daily_ReportsTableAdapter.ClearBeforeFill = True
        '
        'USDailyReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "USDailyReports"
        Me.Text = " "
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USDailyReportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._COVID_19DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents _COVID_19DataSet As _COVID_19DataSet
    Friend WithEvents USDailyReportsBindingSource As BindingSource
    Friend WithEvents US_Daily_ReportsTableAdapter As _COVID_19DataSetTableAdapters.US_Daily_ReportsTableAdapter
    Friend WithEvents ProvinceStateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CountryRegionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastUpdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LongDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConfirmedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeathsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecoveredDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActiveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FIPSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IncidentRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PeopleTestedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PeopleHospitalizedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MortalityRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ISO3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TestingRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HospitalizationRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
