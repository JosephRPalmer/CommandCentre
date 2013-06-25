Public Class comandcentre

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles taskman.Click
        Process.Start("taskmgr")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles exitwindow.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ctrlpanel.Click
        Process.Start("control")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles shutdown.Click
        Process.Start("shutdown", "-s -t 10")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles restart.Click
        Process.Start("shutdown", "-r -t 10")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles abort.Click
        Process.Start("shutdown", "-a")
    End Sub

    Private Sub about_Click(sender As Object, e As EventArgs) Handles about.Click
        MsgBox("Created by Joseph Ryan-Palmer")
    End Sub

    Private Sub comandcentre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.Manual

        Dim leftStart As Integer = Me.ClientSize.Width - (Me.Width + (SystemInformation.Border3DSize.Width * 2))
        Dim topStart As Integer = Me.ClientSize.Height - (Me.Height + (SystemInformation.Border3DSize.Height * 2))

        Me.Location = New Point(leftStart, topStart)
        Me.Show()
    End Sub

    Private Sub cmd_Click(sender As Object, e As EventArgs) Handles cmd.Click
        Process.Start("cmd", "/K cd " + My.Computer.FileSystem.SpecialDirectories.MyDocuments)
    End Sub

    Private Sub run_Click(sender As Object, e As EventArgs) Handles run.Click
        Process.Start("run")
    End Sub
End Class
