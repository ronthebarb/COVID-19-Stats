Public Class GlobalDeaths
    Private Sub GlobalDeaths_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_COVID_19DataSet.time_series_covid19_deaths_global' table. You can move, or remove it, as needed.
        Me.Time_series_covid19_deaths_globalTableAdapter.Fill(Me._COVID_19DataSet.time_series_covid19_deaths_global)

    End Sub

    Private Sub FilterItalyToolStripButton_Click(sender As Object, e As EventArgs) Handles FilterItalyToolStripButton.Click
        Try
            Me.Time_series_covid19_deaths_globalTableAdapter.FilterItaly(Me._COVID_19DataSet.time_series_covid19_deaths_global, ItalyToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


End Class