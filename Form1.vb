Imports System.Threading
Public Class Form1

    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If GetAsyncKeyState(Keys.F5) Then
            NotifyIcon1.BalloonTipText = "Koruma AKTİF"
            NotifyIcon1.ShowBalloonTip(1)
            Shell("devmanview.exe /disable " & """HID Keyboard Device""")
        ElseIf GetAsyncKeyState(Keys.F6) Then
            NotifyIcon1.BalloonTipText = "Koruma DEAKTİF"
            NotifyIcon1.ShowBalloonTip(1)
            Shell("devmanview.exe /enable " & """HID Keyboard Device""")
        End If

    End Sub

    Private Sub ÇıkışToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÇıkışToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Thread.Sleep(1000)
        Me.Visible = False
        Me.Hide()
        Timer2.Enabled = False
    End Sub
End Class
