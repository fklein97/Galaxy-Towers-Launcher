Imports System.IO
Imports System.IO.Compression
Imports System.Threading

Public Class Form_Launcher

    Public version_address As String = "http://galaxytowers.altervista.org/update/version.txt"
    Public local_ver_address As String = "game_ver.txt"
    Public download_address As String = "http://galaxytowers.altervista.org/update/Galaxy_Towers.zip"
    Public client As New Net.WebClient

    Private Sub Form_Launcher_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim thread As New Thread(
            Sub()
                ListBox_status.Items.Add("Starting Launcher...")
                check_updates()
            End Sub
        )

        thread.Start()
    End Sub

    Private Sub check_updates()
        ListBox_status.Items.Add("Looking for Updates...")
        Dim server_ver As String
        Dim local_ver As String

        server_ver = client.DownloadString(version_address)
        ListBox_status.Items.Add("Newest Version is " + server_ver + "!")

        local_ver = My.Computer.FileSystem.ReadAllText(local_ver_address)
        ListBox_status.Items.Add("Local Version is " + local_ver + "!")

        If String.Compare(server_ver, local_ver) <> 0 Then
            ListBox_status.Items.Add("Update available!")
            start_update()
            My.Computer.FileSystem.WriteAllText(local_ver_address, server_ver, False)
        Else
            ListBox_status.Items.Add("No Update available!")
        End If
    End Sub

    Private Sub start_update()
        ProgressBar_update.Visible = True
        ListBox_status.Items.Add("Start Update...")
        ProgressBar_update.Value = 10
        ListBox_status.Items.Add("Downloading Update...")
        My.Computer.Network.DownloadFile(download_address, "game.zip")
        ProgressBar_update.Value = 70
        ListBox_status.Items.Add("Removing old Version...")
        My.Computer.FileSystem.DeleteDirectory("game_data", FileIO.DeleteDirectoryOption.DeleteAllContents)
        ProgressBar_update.Value = 80
        ListBox_status.Items.Add("Unpacking Update...")
        ZipFile.ExtractToDirectory("game.zip", "game_data")
        ProgressBar_update.Value = 90
        ListBox_status.Items.Add("Removing Update-Package...")
        My.Computer.FileSystem.DeleteFile("game.zip")
        ProgressBar_update.Value = 95
        ListBox_status.Items.Add("Update finished!")
        ProgressBar_update.Value = 100
    End Sub

    Private Sub Button_close_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button_play_Click(sender As Object, e As EventArgs) Handles Button_play.Click
        ChDir("game_data")
        Dim PSI As New ProcessStartInfo("Galaxy Towers.exe")
        PSI.WindowStyle = ProcessWindowStyle.Maximized 'or ProcessWindowStyle.Normal
        Process.Start(PSI)
        Me.Close()
    End Sub

    Private Sub Button_forceUpdate_Click(sender As Object, e As EventArgs) Handles Button_forceUpdate.Click
        Dim thread2 As New Thread(
            Sub()
                start_update()
            End Sub
        )
        thread2.Start()
    End Sub

    Private Sub Button_close_Click_1(sender As Object, e As EventArgs) Handles Button_close.Click
        Me.Close()
    End Sub
End Class
