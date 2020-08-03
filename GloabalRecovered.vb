Public Class GlobalRecovered
    Private Sub GloabalReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_COVID_19DataSet.Global_Daily_Reports' table. You can move, or remove it, as needed.
        Me.Global_Daily_ReportsTableAdapter.Fill(Me._COVID_19DataSet.Global_Daily_Reports)

    End Sub
End Class