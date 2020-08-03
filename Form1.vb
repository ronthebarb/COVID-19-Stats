Imports LiveCharts

' Requirement 1: Check
' Requirement 2: Check

' Requirement 3: Check

' Requirement 4: Couldnt get Chart working, to late to contact for help.


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ConfirmedUS_DataSet.time_series_covid19_confirmed_US' table. You can move, or remove it, as needed.
        Me.Time_series_covid19_confirmed_USTableAdapter.Fill(Me.ConfirmedUS_DataSet.time_series_covid19_confirmed_US)


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

    Private Sub USConfirmedCasesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USConfirmedCasesToolStripMenuItem.Click
        Dim frmUs As New USConfirmed()

        frmUs.ShowDialog()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub USDailyReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USDailyReportsToolStripMenuItem.Click
        Dim frmUs As New USDailyReports()

        frmUs.ShowDialog()
    End Sub

    Private Sub USDeathsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USDeathsToolStripMenuItem.Click
        Dim frmUs As New USDeaths()

        frmUs.ShowDialog()
    End Sub

    Private Sub GlobalConfirmedCasesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GlobalConfirmedCasesToolStripMenuItem.Click
        Dim frmGlobal As New GlobalDeaths()

        frmGlobal.ShowDialog()
    End Sub

    Private Sub GlobalRecoveredToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GlobalDailyReportsToolStripMenuItem.Click
        Dim frmGlobal As New GlobalConfirmed()

        frmGlobal.ShowDialog()
    End Sub

    Private Sub GlobalsDeathsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GlobalsDeathsToolStripMenuItem.Click
        Dim frmGlobal As New GlobalRecovered()

        frmGlobal.ShowDialog()
    End Sub

    Private Sub ShowItalyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowItalyToolStripMenuItem.Click
        Dim frmGlobalSearch As New FindCountry()

        frmGlobalSearch.ShowDialog()
    End Sub

    Private Sub ConfirmedChartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfirmedChartToolStripMenuItem.Click
        Dim frmConfirmedChart As New ConfirmedChart()

        frmConfirmedChart.Show()

    End Sub


End Class
