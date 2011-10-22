Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form1
    Dim ConnectionString As String
    Dim cn As MySqlConnection, cmd As MySqlCommand, dr As MySqlDataReader, cmd1 As MySqlCommand, dr1 As MySqlDataReader

    Public Class genomerunnertable
        Public ID As Integer
        Public FeatureTable As String
        Public FeatureName As String
        Public Tier As Integer
    End Class
    Private Function GetConnectionSettings(ByRef uName As String, ByRef uPassword As String, ByRef uServer As String, ByRef uDatabase As String) As String
        'gets the connection string values from the registry if they exist
        Dim connectionString As String
        Try
            uName = GetSetting("GenomeRunner", "Database", "uName")
            uPassword = GetSetting("GenomeRunner", "Database", "uPassword")
            uServer = GetSetting("GenomeRunner", "Database", "uServer")
            uDatabase = GetSetting("GenomeRunner", "Database", "uDatabase")
        Catch
            SaveSetting("GenomeRunner", "Database", "uName", "genomerunner")
            SaveSetting("GenomeRunner", "Database", "uPassword", "genomerunner")
            SaveSetting("GenomeRunner", "Database", "uServer", "156.110.144.34")
            SaveSetting("GenomeRunner", "Database", "uDatabase", "hg18test")
            uName = GetSetting("GenomeRunner", "Database", "uName")
            uPassword = GetSetting("GenomeRunner", "Database", "uPassword")
            uServer = GetSetting("GenomeRunner", "Database", "uServer")
            uDatabase = GetSetting("GenomeRunner", "Database", "uDatabase")
        End Try
        connectionString = "Server=" & uServer & ";Database=" & uDatabase & ";User ID=" & uName & ";Password=" & uPassword
        Return connectionString
    End Function

    Private Sub OpenDatabase()
        Dim uName As String = ""
        Dim uPassword As String = ""
        Dim uServer As String = ""
        Dim uDatabase As String = ""

        ConnectionString = GetConnectionSettings(uName, uPassword, uServer, uDatabase)
        'checks again to see if the values are still empty, if they are the connection is left blank and a connection is not oppened. 
        Dim ConnectionWorks As Boolean = False
        While ConnectionWorks = False
            Try
                cn = New MySqlConnection(ConnectionString) : cn.Open()
                cmd = New MySqlCommand("SELECT id FROM genomerunner limit 1", cn)
                dr = cmd.ExecuteReader()
                ConnectionWorks = True
                dr.Close()
            Catch
                frmLogin.ShowDialog()
                ConnectionString = GetConnectionSettings(uName, uPassword, uServer, uDatabase)
            End Try
        End While

    End Sub


    Private Sub btnExtractAllGFs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtractAllGFs.Click
        Dim GFs As New List(Of genomerunnertable)
        Dim columnnames, columnsreturned As String
        OpenDatabase()
        cmd = New MySqlCommand("SELECT id,featuretable,featurename,tier FROM genomerunner", cn)
        dr = cmd.ExecuteReader
        While dr.Read
            Dim tempGF As New genomerunnertable
            With tempGF
                .ID = dr(0) : .FeatureTable = dr(1) : .FeatureName = dr(2) : .Tier = dr(3)
            End With
            GFs.Add(tempGF)
        End While
        dr.Close() : cmd.Dispose()

        For Each GF In GFs
            If GF.ID >= 59 Then
                Try
                    cmd = New MySqlCommand("SHOW COLUMNS FROM " & GF.FeatureTable & ";", cn)
                    dr = cmd.ExecuteReader : columnnames = vbNullString
                    While dr.Read
                        columnnames &= dr(0)
                    End While
                    dr.Close() : cmd.Dispose()

                    Dim nameIndex As Integer = columnnames.ToLower().IndexOf("name")
                    Dim strandIndex As Integer = columnnames.ToLower().IndexOf("strand")
                    Dim geneIndex As Integer = columnnames.ToLower().IndexOf("txstart")
                    columnsreturned = ""
                    If geneIndex <> -1 Then
                        columnsreturned = "chrom,txstart,txend"
                    Else
                        columnsreturned = "chrom,chromstart,chromend"
                    End If
                    If nameIndex <> -1 Then columnsreturned &= ",name"
                    If strandIndex <> -1 Then columnsreturned &= ",strand"

                    cmd = New MySqlCommand("SELECT " & columnsreturned & " FROM " & GF.FeatureTable & ";", cn)
                    dr = cmd.ExecuteReader
                    Using writer As New StreamWriter("F:\WorkOMRF\Gene Ontology\GenomeRunner_tests\All_GF\" & GF.ID & "-" & GF.FeatureTable & "-" & GF.Tier & ".bed")
                        While dr.Read
                            writer.Write(dr(0) & vbTab & dr(1) & vbTab & dr(2))
                            If nameIndex <> -1 Then
                                writer.Write(vbTab & dr(3))
                            Else
                                writer.Write(vbTab & "")
                            End If
                            If strandIndex <> -1 Then writer.Write(vbTab & dr(4))
                            writer.Write(vbCrLf)
                        End While
                        dr.Close() : cmd.Dispose()
                    End Using
                    Debug.Print("Done - " & GF.ID)
                Catch
                    Debug.Print(GF.ID)
                End Try
            End If
        Next
        MsgBox("Success!!!")
    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        frmLogin.ShowDialog()
    End Sub

    Function TrimStr(ByRef StringToTrim As String) As String
        'http://www.vbdotnetforums.com/vb-net-general-discussion/31506-how-remove-all-special-characters-string-visual-basic-net.html
        Dim illegalChars As Char() = "!@#$%^&*(){}[]""+'<>?/\:.-".ToCharArray() '"!@#$%^&*(){}[]""_+<>?/".ToCharArray() 
        Dim sb As New System.Text.StringBuilder
        For Each ch As Char In StringToTrim
            If Array.IndexOf(illegalChars, ch) = -1 Then
                sb.Append(ch)
            End If
        Next
        Return sb.ToString
    End Function
End Class
