Imports LiveCharts
Public Class ConfirmedChart
    Private Sub ConfirmedChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_COVID_19DataSet1.time_series_covid19_confirmed_global' table. You can move, or remove it, as needed.
        Me.Time_series_covid19_confirmed_globalTableAdapter.Fill(Me._COVID_19DataSet1.time_series_covid19_confirmed_global)


        Dim scollection As New SeriesCollection

        Dim sc As New LiveCharts.Wpf.ColumnSeries

        sc.Values = New ChartValues(Of Int32)
        sc.Values.AddRange({10, 50, 39, 50})
        sc.Title = "2015"
        scollection.Add(sc)

        Dim sc1 As New LiveCharts.Wpf.ColumnSeries

        sc1.Values = New ChartValues(Of Int32)
        sc1.Values.AddRange({11, 56, 42, 48})
        sc1.Title = "2016"
        scollection.Add(sc1)

        CartesianChart1.Series = scollection


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class