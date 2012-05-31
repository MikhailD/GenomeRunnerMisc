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
        Dim response As MsgBoxResult = MessageBox.Show("Save as default connection settings?", "Save Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            SaveSetting("GenomeRunnerMisc", "Database", "uName", txtUsername.Text)
            SaveSetting("GenomeRunnerMisc", "Database", "uPassword", txtPassword.Text)
            SaveSetting("GenomeRunnerMisc", "Database", "uServer", txtServer.Text)
            SaveSetting("GenomeRunnerMisc", "Database", "uDatabase", txtDatabase.Text)
            With Form1
                .lblHost.Text = txtServer.Text : .lblDB.Text = txtDatabase.Text : .lblUser.Text = txtUsername.Text
            End With
        End If
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub btnUCSC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUCSC.Click
        txtUsername.Text = "genome"
        txtPassword.Text = ""
        txtServer.Text = "genome-mysql.cse.ucsc.edu"
        txtDatabase.Text = "hg19"
    End Sub
   

    Private Sub btnRemoteDatabase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoteDatabase.Click
        txtUsername.Text = "genomerunner"
        txtPassword.Text = "genomerunner"
        txtServer.Text = "156.110.144.34"
        txtDatabase.Text = "hg19"
    End Sub
End Class
