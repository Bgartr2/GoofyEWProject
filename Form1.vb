Public Class Form1
    Private sweepAngle As Single = 0.0F

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radarTimer = New Timer()
        radarTimer.Interval = 33
        AddHandler radarTimer.Tick, AddressOf RadarTimer_Tick
        radarTimer.Start()

        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.DoubleBuffer, True)
    End Sub

    Private Sub RadarTimer_Tick(sender As Object, e As EventArgs)
        sweepAngle += 3.0F
        If sweepAngle >= 360.0F Then sweepAngle = 0.0F

        picRadar.Invalidate()
    End Sub

    Private Sub picRadar_Paint(sender As Object, e As PaintEventArgs) Handles picRadar.Paint
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim cx As Single = picRadar.Width / 2.0F
        Dim cy As Single = picRadar.Height / 2.0F
        Dim radius As Single = Math.Min(cx, cy) - 10

        ' Draw Radar Background & Grid
        g.Clear(Color.Black)
        Using gridPen As New Pen(Color.FromArgb(0, 50, 0), 1)
            g.DrawEllipse(gridPen, cx - radius, cy - radius, radius * 2, radius * 2)
            g.DrawEllipse(gridPen, cx - (radius / 2), cy - (radius / 2), radius, radius)
            g.DrawLine(gridPen, cx - radius, cy, cx + radius, cy)
            g.DrawLine(gridPen, cx, cy - radius, cx, cy + radius)
        End Using

        ' Draw Radar Sweep Line
        Dim angleRad As Double = sweepAngle * (Math.PI / 180.0)
        Dim endX As Single = cx + CSng(radius * Math.Cos(angleRad))
        Dim endY As Single = CSng(cy + radius * Math.Sin(angleRad))

        Using sweepPen As New Pen(Color.LimeGreen, 2)
            g.DrawLine(sweepPen, cx, cy, endX, endY)
        End Using

        ' Render Targets & Jamming Effects (if Jammer is active)
        If radNoise.Checked Then
            Dim rnd As New Random()
            Using noisePen As New Pen(Color.FromArgb(100, Color.LimeGreen))
                For i As Integer = 0 To tkbJammerPower.Value * 10
                    Dim nx As Single = cx + CSng((rnd.NextDouble() * 2 - 1) * radius)
                    Dim ny As Single = cy + CSng((rnd.NextDouble() * 2 - 1) * radius)
                    g.DrawRectangle(noisePen, nx, ny, 2, 2)
                Next
            End Using
        End If
    End Sub
End Class