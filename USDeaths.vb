Public Class USDeaths
    Private Sub USDeaths_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_COVID_19DataSet.time_series_covid19_deaths_US' table. You can move, or remove it, as needed.
        Me.Time_series_covid19_deaths_USTableAdapter.Fill(Me._COVID_19DataSet.time_series_covid19_deaths_US)

    End Sub
End Class