'(C) 2011 Mikhail Dozmorov.
Public Class frmLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If txtUsername.Text <> vbNullString And txtPassword.Text <> vbNullString Then
            SaveSetting("GenomeRunnerMisc", "Database", "uName", txtUsername.Text)
            SaveSetting("GenomeRunnerMisc", "Database", "uPassword", txtPassword.Text)
            SaveSetting("GenomeRunnerMisc", "Database", "uServer", txtServer.Text)
            SaveSetting("GenomeRunnerMisc", "Database", "uDatabase", txtDatabase.Text)
        End If
        With Form1
            .lblHost.Text = txtServer.Text : .lblDB.Text = txtDatabase.Text : .lblUser.Text = txtUsername.Text
        End With
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUsername.Text = "genomerunner"
        txtPassword.Text = "genomerunner"
        txtServer.Text = "156.110.144.34"
        txtDatabase.Text = "hg18test"
    End Sub
End Class
