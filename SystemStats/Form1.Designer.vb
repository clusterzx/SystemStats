<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ChartPen1 As SpPerfChart.ChartPen = New SpPerfChart.ChartPen()
        Dim ChartPen2 As SpPerfChart.ChartPen = New SpPerfChart.ChartPen()
        Dim ChartPen3 As SpPerfChart.ChartPen = New SpPerfChart.ChartPen()
        Dim ChartPen4 As SpPerfChart.ChartPen = New SpPerfChart.ChartPen()
        Dim ChartPen5 As SpPerfChart.ChartPen = New SpPerfChart.ChartPen()
        Dim ChartPen6 As SpPerfChart.ChartPen = New SpPerfChart.ChartPen()
        Dim ChartPen7 As SpPerfChart.ChartPen = New SpPerfChart.ChartPen()
        Dim ChartPen8 As SpPerfChart.ChartPen = New SpPerfChart.ChartPen()
        Dim ChartPen9 As SpPerfChart.ChartPen = New SpPerfChart.ChartPen()
        Dim ChartPen10 As SpPerfChart.ChartPen = New SpPerfChart.ChartPen()
        Dim ChartPen11 As SpPerfChart.ChartPen = New SpPerfChart.ChartPen()
        Dim ChartPen12 As SpPerfChart.ChartPen = New SpPerfChart.ChartPen()
        Dim ChartPen13 As SpPerfChart.ChartPen = New SpPerfChart.ChartPen()
        Dim ChartPen14 As SpPerfChart.ChartPen = New SpPerfChart.ChartPen()
        Dim ChartPen15 As SpPerfChart.ChartPen = New SpPerfChart.ChartPen()
        Dim ChartPen16 As SpPerfChart.ChartPen = New SpPerfChart.ChartPen()
        Me.proc_view = New System.Diagnostics.Process()
        Me.tmr_live = New System.Windows.Forms.Timer(Me.components)
        Me.cpu = New System.Diagnostics.PerformanceCounter()
        Me.mem = New System.Diagnostics.PerformanceCounter()
        Me.notify = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.mnu_tray = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnu_close = New System.Windows.Forms.ToolStripMenuItem()
        Me.EarnTheme1 = New SystemStats.EarnTheme()
        Me.EarnGroupBox4 = New SystemStats.EarnGroupBox()
        Me.outgoing = New SpPerfChart.PerfChart()
        Me.incoming = New SpPerfChart.PerfChart()
        Me.EarnGroupBox3 = New SystemStats.EarnGroupBox()
        Me.chart_cpu = New SpPerfChart.PerfChart()
        Me.EarnGroupBox2 = New SystemStats.EarnGroupBox()
        Me.lbl_procnum = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmd_about = New System.Windows.Forms.Button()
        Me.btn_minimize = New System.Windows.Forms.Button()
        Me.EarnGroupBox1 = New SystemStats.EarnGroupBox()
        Me.lbl_perc_used = New System.Windows.Forms.Label()
        Me.chart_mem = New SpPerfChart.PerfChart()
        Me.lbl_totalmem = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.cpu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnu_tray.SuspendLayout()
        Me.EarnTheme1.SuspendLayout()
        Me.EarnGroupBox4.SuspendLayout()
        Me.EarnGroupBox3.SuspendLayout()
        Me.EarnGroupBox2.SuspendLayout()
        Me.EarnGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'proc_view
        '
        Me.proc_view.StartInfo.Domain = ""
        Me.proc_view.StartInfo.LoadUserProfile = False
        Me.proc_view.StartInfo.Password = Nothing
        Me.proc_view.StartInfo.StandardErrorEncoding = Nothing
        Me.proc_view.StartInfo.StandardOutputEncoding = Nothing
        Me.proc_view.StartInfo.UserName = ""
        Me.proc_view.SynchronizingObject = Me
        '
        'tmr_live
        '
        Me.tmr_live.Interval = 1
        '
        'cpu
        '
        Me.cpu.CategoryName = "Processor"
        Me.cpu.CounterName = "% Processor Time"
        Me.cpu.InstanceName = "_Total"
        '
        'mem
        '
        Me.mem.CategoryName = "Memory"
        Me.mem.CounterName = "% Committed Bytes In Use"
        '
        'notify
        '
        Me.notify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.notify.BalloonTipText = "Minimized to tray." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Double click to open again."
        Me.notify.BalloonTipTitle = "Info"
        Me.notify.ContextMenuStrip = Me.mnu_tray
        Me.notify.Icon = CType(resources.GetObject("notify.Icon"), System.Drawing.Icon)
        Me.notify.Text = "StatsMonitor"
        Me.notify.Visible = True
        '
        'mnu_tray
        '
        Me.mnu_tray.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_close})
        Me.mnu_tray.Name = "mnu_tray"
        Me.mnu_tray.Size = New System.Drawing.Size(104, 26)
        '
        'mnu_close
        '
        Me.mnu_close.Name = "mnu_close"
        Me.mnu_close.Size = New System.Drawing.Size(103, 22)
        Me.mnu_close.Text = "Close"
        '
        'EarnTheme1
        '
        Me.EarnTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.EarnTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.EarnTheme1.Controls.Add(Me.EarnGroupBox4)
        Me.EarnTheme1.Controls.Add(Me.EarnGroupBox3)
        Me.EarnTheme1.Controls.Add(Me.EarnGroupBox2)
        Me.EarnTheme1.Controls.Add(Me.cmd_about)
        Me.EarnTheme1.Controls.Add(Me.btn_minimize)
        Me.EarnTheme1.Controls.Add(Me.EarnGroupBox1)
        Me.EarnTheme1.Customization = "WU1L//////8="
        Me.EarnTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EarnTheme1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.EarnTheme1.Image = Nothing
        Me.EarnTheme1.Location = New System.Drawing.Point(0, 0)
        Me.EarnTheme1.Movable = False
        Me.EarnTheme1.Name = "EarnTheme1"
        Me.EarnTheme1.NoRounding = False
        Me.EarnTheme1.Sizable = False
        Me.EarnTheme1.Size = New System.Drawing.Size(415, 513)
        Me.EarnTheme1.SmartBounds = True
        Me.EarnTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.EarnTheme1.TabIndex = 0
        Me.EarnTheme1.Text = "Processes"
        Me.EarnTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.EarnTheme1.Transparent = False
        '
        'EarnGroupBox4
        '
        Me.EarnGroupBox4.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.EarnGroupBox4.Controls.Add(Me.outgoing)
        Me.EarnGroupBox4.Controls.Add(Me.incoming)
        Me.EarnGroupBox4.Customization = "WU1L/1lNS/9ZTUv//////w=="
        Me.EarnGroupBox4.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.EarnGroupBox4.Image = Nothing
        Me.EarnGroupBox4.Location = New System.Drawing.Point(12, 315)
        Me.EarnGroupBox4.Movable = True
        Me.EarnGroupBox4.Name = "EarnGroupBox4"
        Me.EarnGroupBox4.NoRounding = False
        Me.EarnGroupBox4.Sizable = True
        Me.EarnGroupBox4.Size = New System.Drawing.Size(390, 127)
        Me.EarnGroupBox4.SmartBounds = True
        Me.EarnGroupBox4.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.EarnGroupBox4.TabIndex = 4
        Me.EarnGroupBox4.Text = "Network traffic ( Incoming | Outgoing )"
        Me.EarnGroupBox4.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.EarnGroupBox4.Transparent = False
        '
        'outgoing
        '
        Me.outgoing.BorderStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.outgoing.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.outgoing.Location = New System.Drawing.Point(3, 82)
        Me.outgoing.Name = "outgoing"
        Me.outgoing.PerfChartStyle.AntiAliasing = True
        ChartPen1.Color = System.Drawing.Color.Black
        ChartPen1.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartPen1.Width = 1.0!
        Me.outgoing.PerfChartStyle.AvgLinePen = ChartPen1
        Me.outgoing.PerfChartStyle.BackgroundColorBottom = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.outgoing.PerfChartStyle.BackgroundColorTop = System.Drawing.Color.Silver
        ChartPen2.Color = System.Drawing.Color.Red
        ChartPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        ChartPen2.Width = 0!
        Me.outgoing.PerfChartStyle.ChartLinePen = ChartPen2
        ChartPen3.Color = System.Drawing.Color.Black
        ChartPen3.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartPen3.Width = 1.0!
        Me.outgoing.PerfChartStyle.HorizontalGridPen = ChartPen3
        Me.outgoing.PerfChartStyle.ShowAverageLine = True
        Me.outgoing.PerfChartStyle.ShowHorizontalGridLines = True
        Me.outgoing.PerfChartStyle.ShowVerticalGridLines = True
        ChartPen4.Color = System.Drawing.Color.Black
        ChartPen4.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartPen4.Width = 1.0!
        Me.outgoing.PerfChartStyle.VerticalGridPen = ChartPen4
        Me.outgoing.ScaleMode = SpPerfChart.ScaleMode.Relative
        Me.outgoing.Size = New System.Drawing.Size(378, 39)
        Me.outgoing.TabIndex = 0
        Me.outgoing.TimerInterval = 1000
        Me.outgoing.TimerMode = SpPerfChart.TimerMode.SynchronizedAverage
        '
        'incoming
        '
        Me.incoming.BorderStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.incoming.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.incoming.Location = New System.Drawing.Point(3, 34)
        Me.incoming.Name = "incoming"
        Me.incoming.PerfChartStyle.AntiAliasing = True
        ChartPen5.Color = System.Drawing.Color.Black
        ChartPen5.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartPen5.Width = 1.0!
        Me.incoming.PerfChartStyle.AvgLinePen = ChartPen5
        Me.incoming.PerfChartStyle.BackgroundColorBottom = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.incoming.PerfChartStyle.BackgroundColorTop = System.Drawing.Color.Silver
        ChartPen6.Color = System.Drawing.Color.Red
        ChartPen6.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartPen6.Width = 0!
        Me.incoming.PerfChartStyle.ChartLinePen = ChartPen6
        ChartPen7.Color = System.Drawing.Color.Black
        ChartPen7.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartPen7.Width = 1.0!
        Me.incoming.PerfChartStyle.HorizontalGridPen = ChartPen7
        Me.incoming.PerfChartStyle.ShowAverageLine = True
        Me.incoming.PerfChartStyle.ShowHorizontalGridLines = True
        Me.incoming.PerfChartStyle.ShowVerticalGridLines = True
        ChartPen8.Color = System.Drawing.Color.Black
        ChartPen8.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartPen8.Width = 1.0!
        Me.incoming.PerfChartStyle.VerticalGridPen = ChartPen8
        Me.incoming.ScaleMode = SpPerfChart.ScaleMode.Relative
        Me.incoming.Size = New System.Drawing.Size(378, 39)
        Me.incoming.TabIndex = 0
        Me.incoming.TimerInterval = 100
        Me.incoming.TimerMode = SpPerfChart.TimerMode.SynchronizedAverage
        '
        'EarnGroupBox3
        '
        Me.EarnGroupBox3.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.EarnGroupBox3.Controls.Add(Me.chart_cpu)
        Me.EarnGroupBox3.Customization = "WU1L/1lNS/9ZTUv//////w=="
        Me.EarnGroupBox3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.EarnGroupBox3.Image = Nothing
        Me.EarnGroupBox3.Location = New System.Drawing.Point(12, 189)
        Me.EarnGroupBox3.Movable = True
        Me.EarnGroupBox3.Name = "EarnGroupBox3"
        Me.EarnGroupBox3.NoRounding = False
        Me.EarnGroupBox3.Sizable = True
        Me.EarnGroupBox3.Size = New System.Drawing.Size(391, 120)
        Me.EarnGroupBox3.SmartBounds = True
        Me.EarnGroupBox3.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.EarnGroupBox3.TabIndex = 3
        Me.EarnGroupBox3.Text = "CPU Usage"
        Me.EarnGroupBox3.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.EarnGroupBox3.Transparent = False
        '
        'chart_cpu
        '
        Me.chart_cpu.BorderStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.chart_cpu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.chart_cpu.Location = New System.Drawing.Point(6, 31)
        Me.chart_cpu.Name = "chart_cpu"
        Me.chart_cpu.PerfChartStyle.AntiAliasing = True
        ChartPen9.Color = System.Drawing.Color.Black
        ChartPen9.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartPen9.Width = 1.0!
        Me.chart_cpu.PerfChartStyle.AvgLinePen = ChartPen9
        Me.chart_cpu.PerfChartStyle.BackgroundColorBottom = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chart_cpu.PerfChartStyle.BackgroundColorTop = System.Drawing.Color.Silver
        ChartPen10.Color = System.Drawing.Color.Red
        ChartPen10.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartPen10.Width = 2.0!
        Me.chart_cpu.PerfChartStyle.ChartLinePen = ChartPen10
        ChartPen11.Color = System.Drawing.Color.Black
        ChartPen11.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartPen11.Width = 1.0!
        Me.chart_cpu.PerfChartStyle.HorizontalGridPen = ChartPen11
        Me.chart_cpu.PerfChartStyle.ShowAverageLine = True
        Me.chart_cpu.PerfChartStyle.ShowHorizontalGridLines = True
        Me.chart_cpu.PerfChartStyle.ShowVerticalGridLines = True
        ChartPen12.Color = System.Drawing.Color.Black
        ChartPen12.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartPen12.Width = 1.0!
        Me.chart_cpu.PerfChartStyle.VerticalGridPen = ChartPen12
        Me.chart_cpu.ScaleMode = SpPerfChart.ScaleMode.Absolute
        Me.chart_cpu.Size = New System.Drawing.Size(378, 81)
        Me.chart_cpu.TabIndex = 0
        Me.chart_cpu.TimerInterval = 100
        Me.chart_cpu.TimerMode = SpPerfChart.TimerMode.Disabled
        '
        'EarnGroupBox2
        '
        Me.EarnGroupBox2.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.EarnGroupBox2.Controls.Add(Me.lbl_procnum)
        Me.EarnGroupBox2.Controls.Add(Me.Label4)
        Me.EarnGroupBox2.Customization = "WU1L/1lNS/9ZTUv//////w=="
        Me.EarnGroupBox2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.EarnGroupBox2.Image = Nothing
        Me.EarnGroupBox2.Location = New System.Drawing.Point(12, 448)
        Me.EarnGroupBox2.Movable = True
        Me.EarnGroupBox2.Name = "EarnGroupBox2"
        Me.EarnGroupBox2.NoRounding = False
        Me.EarnGroupBox2.Sizable = True
        Me.EarnGroupBox2.Size = New System.Drawing.Size(390, 53)
        Me.EarnGroupBox2.SmartBounds = True
        Me.EarnGroupBox2.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.EarnGroupBox2.TabIndex = 2
        Me.EarnGroupBox2.Text = "Processes"
        Me.EarnGroupBox2.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.EarnGroupBox2.Transparent = False
        '
        'lbl_procnum
        '
        Me.lbl_procnum.AutoSize = True
        Me.lbl_procnum.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.lbl_procnum.ForeColor = System.Drawing.Color.Red
        Me.lbl_procnum.Location = New System.Drawing.Point(360, 30)
        Me.lbl_procnum.Name = "lbl_procnum"
        Me.lbl_procnum.Size = New System.Drawing.Size(28, 13)
        Me.lbl_procnum.TabIndex = 0
        Me.lbl_procnum.Text = "100"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total number of processes :"
        '
        'cmd_about
        '
        Me.cmd_about.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.cmd_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_about.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_about.Location = New System.Drawing.Point(359, 4)
        Me.cmd_about.Name = "cmd_about"
        Me.cmd_about.Size = New System.Drawing.Size(20, 22)
        Me.cmd_about.TabIndex = 1
        Me.cmd_about.Text = "?"
        Me.cmd_about.UseVisualStyleBackColor = False
        '
        'btn_minimize
        '
        Me.btn_minimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_minimize.Location = New System.Drawing.Point(385, 4)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(20, 22)
        Me.btn_minimize.TabIndex = 1
        Me.btn_minimize.Text = "X"
        Me.btn_minimize.UseVisualStyleBackColor = False
        '
        'EarnGroupBox1
        '
        Me.EarnGroupBox1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.EarnGroupBox1.Controls.Add(Me.lbl_perc_used)
        Me.EarnGroupBox1.Controls.Add(Me.chart_mem)
        Me.EarnGroupBox1.Controls.Add(Me.lbl_totalmem)
        Me.EarnGroupBox1.Controls.Add(Me.Label1)
        Me.EarnGroupBox1.Customization = "WU1L/1lNS/9ZTUv//////w=="
        Me.EarnGroupBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.EarnGroupBox1.Image = Nothing
        Me.EarnGroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.EarnGroupBox1.Movable = True
        Me.EarnGroupBox1.Name = "EarnGroupBox1"
        Me.EarnGroupBox1.NoRounding = False
        Me.EarnGroupBox1.Sizable = True
        Me.EarnGroupBox1.Size = New System.Drawing.Size(391, 142)
        Me.EarnGroupBox1.SmartBounds = True
        Me.EarnGroupBox1.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.EarnGroupBox1.TabIndex = 0
        Me.EarnGroupBox1.Text = "Memory Usage"
        Me.EarnGroupBox1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.EarnGroupBox1.Transparent = False
        '
        'lbl_perc_used
        '
        Me.lbl_perc_used.AutoSize = True
        Me.lbl_perc_used.ForeColor = System.Drawing.Color.Red
        Me.lbl_perc_used.Location = New System.Drawing.Point(316, 32)
        Me.lbl_perc_used.Name = "lbl_perc_used"
        Me.lbl_perc_used.Size = New System.Drawing.Size(50, 13)
        Me.lbl_perc_used.TabIndex = 2
        Me.lbl_perc_used.Text = "% used"
        '
        'chart_mem
        '
        Me.chart_mem.BorderStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.chart_mem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.chart_mem.Location = New System.Drawing.Point(6, 52)
        Me.chart_mem.Name = "chart_mem"
        Me.chart_mem.PerfChartStyle.AntiAliasing = True
        ChartPen13.Color = System.Drawing.Color.Red
        ChartPen13.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash
        ChartPen13.Width = 2.0!
        Me.chart_mem.PerfChartStyle.AvgLinePen = ChartPen13
        Me.chart_mem.PerfChartStyle.BackgroundColorBottom = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chart_mem.PerfChartStyle.BackgroundColorTop = System.Drawing.Color.Silver
        ChartPen14.Color = System.Drawing.Color.Red
        ChartPen14.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        ChartPen14.Width = 2.0!
        Me.chart_mem.PerfChartStyle.ChartLinePen = ChartPen14
        ChartPen15.Color = System.Drawing.Color.Black
        ChartPen15.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartPen15.Width = 1.0!
        Me.chart_mem.PerfChartStyle.HorizontalGridPen = ChartPen15
        Me.chart_mem.PerfChartStyle.ShowAverageLine = False
        Me.chart_mem.PerfChartStyle.ShowHorizontalGridLines = True
        Me.chart_mem.PerfChartStyle.ShowVerticalGridLines = True
        ChartPen16.Color = System.Drawing.Color.Black
        ChartPen16.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        ChartPen16.Width = 1.0!
        Me.chart_mem.PerfChartStyle.VerticalGridPen = ChartPen16
        Me.chart_mem.ScaleMode = SpPerfChart.ScaleMode.Absolute
        Me.chart_mem.Size = New System.Drawing.Size(378, 81)
        Me.chart_mem.TabIndex = 1
        Me.chart_mem.TimerInterval = 100
        Me.chart_mem.TimerMode = SpPerfChart.TimerMode.Disabled
        '
        'lbl_totalmem
        '
        Me.lbl_totalmem.AutoSize = True
        Me.lbl_totalmem.ForeColor = System.Drawing.Color.Red
        Me.lbl_totalmem.Location = New System.Drawing.Point(161, 32)
        Me.lbl_totalmem.Name = "lbl_totalmem"
        Me.lbl_totalmem.Size = New System.Drawing.Size(56, 13)
        Me.lbl_totalmem.TabIndex = 0
        Me.lbl_totalmem.Text = "%MEM%"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total available memory :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 513)
        Me.Controls.Add(Me.EarnTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "SystemStats - v1.1.2"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.cpu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnu_tray.ResumeLayout(False)
        Me.EarnTheme1.ResumeLayout(False)
        Me.EarnGroupBox4.ResumeLayout(False)
        Me.EarnGroupBox3.ResumeLayout(False)
        Me.EarnGroupBox2.ResumeLayout(False)
        Me.EarnGroupBox2.PerformLayout()
        Me.EarnGroupBox1.ResumeLayout(False)
        Me.EarnGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents proc_view As Process
    Friend WithEvents EarnTheme1 As EarnTheme
    Friend WithEvents btn_minimize As Button
    Friend WithEvents EarnGroupBox1 As EarnGroupBox
    Friend WithEvents lbl_totalmem As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents EarnGroupBox3 As EarnGroupBox
    Friend WithEvents EarnGroupBox2 As EarnGroupBox
    Friend WithEvents tmr_live As Timer
    Friend WithEvents lbl_procnum As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cpu As PerformanceCounter
    Friend WithEvents chart_cpu As SpPerfChart.PerfChart
    Friend WithEvents chart_mem As SpPerfChart.PerfChart
    Friend WithEvents lbl_perc_used As Label
    Friend WithEvents mem As PerformanceCounter
    Friend WithEvents notify As NotifyIcon
    Friend WithEvents cmd_about As Button
    Friend WithEvents mnu_tray As ContextMenuStrip
    Friend WithEvents mnu_close As ToolStripMenuItem
    Friend WithEvents EarnGroupBox4 As EarnGroupBox
    Friend WithEvents outgoing As SpPerfChart.PerfChart
    Friend WithEvents incoming As SpPerfChart.PerfChart
End Class
