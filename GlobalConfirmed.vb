Public Class GlobalConfirmed
    Private Sub GlobalConfirmed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_COVID_19DataSet.time_series_covid19_confirmed_global' table. You can move, or remove it, as needed.
        Me.Time_series_covid19_confirmed_globalTableAdapter.Fill(Me._COVID_19DataSet.time_series_covid19_confirmed_global)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class