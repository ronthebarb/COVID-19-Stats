Public Class USConfirmed
    Private Sub USConfirmed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_COVID_19DataSet.time_series_covid19_confirmed_US' table. You can move, or remove it, as needed.
        Me.Time_series_covid19_confirmed_USTableAdapter1.Fill(Me._COVID_19DataSet.time_series_covid19_confirmed_US)
        'TODO: This line of code loads data into the 'ConfirmedUS_DataSet.time_series_covid19_confirmed_US' table. You can move, or remove it, as needed.
        Me.Time_series_covid19_confirmed_USTableAdapter.Fill(Me.ConfirmedUS_DataSet.time_series_covid19_confirmed_US)

    End Sub
End Class