Public Class USDailyReports
    Private Sub USDailyReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_COVID_19DataSet.US_Daily_Reports' table. You can move, or remove it, as needed.
        Me.US_Daily_ReportsTableAdapter.Fill(Me._COVID_19DataSet.US_Daily_Reports)

    End Sub
End Class