Public Class FindCountry
    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Me.Time_series_covid19_deaths_globalTableAdapter.Fill(Me.FindCountryDataSet.time_series_covid19_deaths_global, txtcountry.Text)
    End Sub

    Private Sub Timeseriescovid19deathsglobalBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles Timeseriescovid19deathsglobalBindingSource.CurrentChanged

    End Sub
End Class