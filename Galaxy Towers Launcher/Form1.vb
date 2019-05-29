Public Class Form_Launcher

    Public version_address As String = ""
    Public download_address As String = ""

    Private Sub Form_Launcher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        check_updates()
    End Sub

    Private Sub check_updates()
        Throw New NotImplementedException()
    End Sub
End Class
