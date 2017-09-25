Imports System.Net.NetworkInformation

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width - 415
        y = Screen.PrimaryScreen.WorkingArea.Height - 513
        Me.Location = New Point(x, y)
        tmr_live.Enabled = True
    End Sub
    Function GetUsedMemory()
        Dim memTotal As String = Split(My.Computer.Info.TotalPhysicalMemory / 1024 / 1024, ",")(0)
        Dim memfree As String = Split(My.Computer.Info.AvailablePhysicalMemory / 1024 / 1024, ",")(0)

        lbl_totalmem.Text = memTotal & " MB"
        lbl_perc_used.Text = Math.Round(mem.NextValue()) & " % used"
        chart_mem.TimerMode = SpPerfChart.TimerMode.SynchronizedAverage
        chart_mem.AddValue(mem.NextValue())
    End Function
    Function GetCPU()
        chart_cpu.AutoScroll = False
        chart_cpu.TimerMode = SpPerfChart.TimerMode.SynchronizedAverage
        chart_cpu.AddValue(cpu.NextValue())
    End Function
    Function GetProcesses()
        Dim i As Integer = 0
        For Each proc As Process In Process.GetProcesses
            i = i + 1
        Next
        lbl_procnum.Text = i
    End Function

    Function GetTraffic()
        incoming.TimerMode = SpPerfChart.TimerMode.SynchronizedAverage
        outgoing.TimerMode = SpPerfChart.TimerMode.SynchronizedAverage
        Dim performanceCounterCategory As New PerformanceCounterCategory("Network Interface")
        Dim instance As String = performanceCounterCategory.GetInstanceNames()(2)
        ' 1st NIC !
        Dim performanceCounterSent As New PerformanceCounter("Network Interface", "Bytes Sent/sec", instance)
        Dim performanceCounterReceived As New PerformanceCounter("Network Interface", "Bytes Received/sec", instance)

        Dim Properties As IPGlobalProperties
        Dim StatV4 As IPGlobalStatistics
        Properties = IPGlobalProperties.GetIPGlobalProperties
        StatV4 = Properties.GetIPv4GlobalStatistics

        EarnGroupBox4.Text = "Network traffic ( Incoming | Outgoing ) " & Properties.HostName

        For i As Integer = 0 To 1
            Dim inc As String = Convert.ToDecimal(performanceCounterReceived.NextValue())
            Dim out As String = Convert.ToDecimal(performanceCounterSent.NextValue())
            outgoing.AddValue(out / 1024)
            incoming.AddValue(inc / 1024)
        Next

    End Function
    Function UpdateTray()
        Dim memTotal As String = Split(My.Computer.Info.TotalPhysicalMemory / 1024 / 1024, ",")(0)
        Dim memfree As String = Split(My.Computer.Info.AvailablePhysicalMemory / 1024 / 1024, ",")(0)
        notify.Text = "MEM USED (GB): " & Math.Round(memTotal / memfree, 2) & vbNewLine & "MEM FREE (GB): " & Math.Round(memfree / 1024, 2)
    End Function
    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
        notify.ShowBalloonTip(10)
    End Sub

    Private Sub tmr_live_Tick(sender As Object, e As EventArgs) Handles tmr_live.Tick
        GetUsedMemory()
        GetCPU()
        GetProcesses()
        UpdateTray()
        GetTraffic()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            notify.Visible = True
            Me.Hide()
        End If
    End Sub
    Private Sub notify_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles notify.MouseDoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        Me.Visible = True
    End Sub
    Private Sub Cmd_about_Click(sender As Object, e As EventArgs) Handles cmd_about.Click
        frm_about.Show()
    End Sub
    Private Sub mnu_close_Click(sender As Object, e As EventArgs) Handles mnu_close.Click
        Application.Exit()
    End Sub
End Class
