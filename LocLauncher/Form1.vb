Imports System.IO

Public Class Form1
    Dim appPath As String = My.Application.Info.DirectoryPath
    Dim allUsersAppData As String = My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData
    Dim currentUserAppData As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData
    Dim docsDirectory As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments
    Dim musicDirectory As String = My.Computer.FileSystem.SpecialDirectories.MyMusic
    Dim picsDirectory As String = My.Computer.FileSystem.SpecialDirectories.MyPictures
    Dim desktopDirectory As String = My.Computer.FileSystem.SpecialDirectories.Desktop
    Dim programsDirectory As String = My.Computer.FileSystem.SpecialDirectories.Programs
    Dim programFileDirectory As String = My.Computer.FileSystem.SpecialDirectories.ProgramFiles
    Dim tempDirectory As String = My.Computer.FileSystem.SpecialDirectories.Temp
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Close()
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Process.Start(appPath + "\Wow.exe")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim realmlist As StreamWriter = New StreamWriter(appPath + "\Data\esES\realmlist.wtf", False)
        realmlist.WriteLine("set realmlist lordsofchaos.no-ip.biz")
        realmlist.Close()
        MsgBox("Realmlist cambiado correctamente")
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
