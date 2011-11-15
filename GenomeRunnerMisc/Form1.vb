Imports MySql.Data.MySqlClient
Imports System.IO
Imports alglib

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
        lblHost.Text = uServer : lblDB.Text = uDatabase : lblUser.Text = uName
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
        Dim illegalChars As Char() = "!@#$%^&*(){}[]""+'<>?/\:.-" & vbLf.ToCharArray() '"!@#$%^&*(){}[]""_+<>?/".ToCharArray() 
        Dim sb As New System.Text.StringBuilder
        For Each ch As Char In StringToTrim
            If Array.IndexOf(illegalChars, ch) = -1 Then
                sb.Append(ch)
            End If
        Next
        Return sb.ToString
    End Function

    Private Sub btnRandFOIs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRandFOIs.Click
        'HG18 main chromosomes
        'Dim BkgChr As List(Of String) = New List(Of String)(New String() {"chr1", "chr2", "chr3", "chr4", "chr5", "chr6", "chr7", "chr8", "chr9", "chr10", "chr11", "chr12", "chr13", "chr14", "chr15", "chr16", "chr17", "chr18", "chr19", "chr20", "chr21", "chr22", "chrX", "chrY", "chrM"})
        'Dim BkgStart As List(Of Integer) = New List(Of Integer)(New Integer() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0})
        'Dim BkgEnd As List(Of Integer) = New List(Of Integer)(New Integer() {247249719, 242951149, 199501827, 191273063, 180857866, 170899992, 158821424, 146274826, 140273252, 135374737, 134452384, 132349534, 114142980, 106368585, 100338915, 88827254, 78774742, 76117153, 63811651, 62435964, 46944323, 49691432, 154913754, 57772954, 16571})
        'HG18 all chromosomes
        Dim BkgChr As List(Of String) = New List(Of String)(New String() {"chr1", "chr1_random", "chr2", "chr2_random", "chr3", "chr3_random", "chr4", "chr4_random", "chr5", "chr5_h2_hap1", "chr5_random", "chr6", "chr6_cox_hap1", "chr6_qbl_hap2", "chr6_random", "chr7", "chr7_random", "chr8", "chr8_random", "chr9", "chr9_random", "chr10", "chr10_random", "chr11", "chr11_random", "chr12", "chr13", "chr13_random", "chr14", "chr15", "chr15_random", "chr16", "chr16_random", "chr17", "chr17_random", "chr18", "chr18_random", "chr19", "chr19_random", "chr20", "chr21", "chr21_random", "chr22", "chr22_h2_hap1", "chr22_random", "chrX", "chrX_random", "chrY", "chrM"})
        Dim BkgStart As List(Of Integer) = New List(Of Integer)(New Integer() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0})
        Dim BkgEnd As List(Of Integer) = New List(Of Integer)(New Integer() {247249719, 1663265, 242951149, 185571, 199501827, 749256, 191273063, 842648, 180857866, 1794870, 143687, 170899992, 4731698, 4565931, 1875562, 158821424, 549659, 146274826, 943810, 140273252, 1146434, 135374737, 113275, 134452384, 215294, 132349534, 114142980, 186858, 106368585, 100338915, 784346, 88827254, 105485, 78774742, 2617613, 76117153, 4262, 63811651, 301858, 62435964, 46944323, 1679693, 49691432, 63661, 257318, 154913754, 1719168, 57772954, 16571})
        Dim TotalFiles As Integer = 100         'How many files to output
        Dim MinFOIlength As Integer = 1000      'Minimum interval length
        Dim MaxFOIlength As Integer = 15000     'Maximum interval length
        Dim TotalFOI As Integer = 1000          'How many random features to generate
        Dim TotalChr As Integer = BkgChr.Count  'Total number of chromosomes
        Dim state As hqrndstate
        Dim CurrBkgChr, CurrBkgStart, CurrBkgEnd As New List(Of Integer)    'Lists for holding random coordinates
        Dim CurrLength, CurrBkgLength As Integer
        For i = 0 To TotalFiles                                             'For each file to be generated
            hqrndrandomize(state)
            CurrBkgChr.Clear() : CurrBkgStart.Clear() : CurrBkgEnd.Clear()  'Clear lists
            For j = 0 To TotalFOI                                                                   'Generate TotalFOIs
                'CurrBkgChr.Add(hqrnduniformi(state, TotalChr))                                      'By selecting random chromosome 
                CurrBkgChr.Add(getWeightedRandomChromosome(state, BkgEnd))
                CurrLength = MinFOIlength + hqrnduniformi(state, MaxFOIlength - MinFOIlength + 1)   'then setting random length within predefined limits
                CurrBkgLength = BkgEnd(CurrBkgChr.Last) - BkgStart(CurrBkgChr.Last) - CurrLength    'Take current chromosome length and subtract previously created random length, to create a buffer zone
                CurrBkgStart.Add(hqrnduniformi(state, CurrBkgLength))                               'Get random start within this buffered length
                CurrBkgEnd.Add(CurrBkgStart.Last + CurrLength)                                      'and end by adding previously created random length
            Next
            Using writer As StreamWriter = New StreamWriter("F:\RandFOIweighted" & i & ".bed")              'Now write it all in the file
                For j = 0 To TotalFOI
                    writer.WriteLine(BkgChr(CurrBkgChr(j)) & vbTab & CurrBkgStart(j) & vbTab & CurrBkgEnd(j))
                Next
            End Using
            Debug.Print("File " & i & " created")
        Next
        MsgBox("Files created")
    End Sub

    Private Function getWeightedRandomChromosome(ByRef state As hqrndstate, ByVal bkgEnd As List(Of Integer))
        'This function essentially goes from this:
        '|------chr1-----|---chr2---|--chr3--| etc.
        '0             1000       1500     1750
        '
        'To this:
        '|------chr1-----|---chr2---|--chr3--| etc.
        '0              .57        .86      1.0
        'Since total summing up chromosome length gets bigger than VB data types can handle,
        'these are handled as percentages instead.

        'Find combined length of all chromosomes from background.
        Dim combinedChromLength As ULong = 0
        For Each elem In bkgEnd
            combinedChromLength += elem
        Next

        'For calculation purposes, chrom will be assigned values between 0.0 & 1.0 based on their percentage of total length.
        Dim weightedChromPositions As New List(Of Double)
        weightedChromPositions.Add(bkgEnd(0) / combinedChromLength)
        For i As Integer = 1 To bkgEnd.Count - 1
            weightedChromPositions.Add((bkgEnd(i) / combinedChromLength) + weightedChromPositions(i - 1))
        Next

        'Randomly select number between 0 & 1.0; find which chrom this number would be part of.
        'Dim RandomClass As Random = New Random
        'Dim randomIndex As Double = RandomClass.NextDouble()
        Dim randomIndex As Double = hqrnduniformr(state)
        Dim randChrom As Integer = -1
        Dim counter As Integer = 0
        While randChrom = -1
            If randomIndex <= weightedChromPositions(counter) Then
                randChrom = counter
            End If
            counter = counter + 1
        End While
        Return randChrom
    End Function


    Private Sub btnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        OpenDatabase()
        Dim strTxt As String = TextBox1.Text
        Dim strSplit As String()
        If InStr(TextBox1.Text, vbCrLf) Then
            strSplit = strTxt.Split(vbCrLf) 'Create array from the textbox
        Else
            strSplit = strTxt.Split(vbLf) 'Create array from the textbox
        End If
        Dim strSubSplit As String() 'Array to store pipe separated entries
        Dim strSeparator As String = "|"  'Separator for multiple IDs on one line
        If rbtnPipe.Checked Then strSeparator = "|"
        If rbtnComma.Checked Then strSeparator = ","

        For i = 0 To strSplit.Count - 1
            strSplit(i) = TrimStr(strSplit(i)) 'Remove special characters, not commas and pipes
            If strSplit(i) <> vbNullString Then
                'If the last symbol is a separator, remove it
                If strSplit(i).Substring(strSplit(i).Length - 1) = strSeparator Then strSplit(i) = strSplit(i).Substring(0, strSplit(i).Length - 1)
                strSubSplit = strSplit(i).Split(strSeparator)    'Check if there's something pipe-separated
                strSplit(i) &= vbTab                    'Add a tab, to separate converted names
                For j = 0 To strSubSplit.Count - 1      'Run through each member of pipe-separated string
                    cmd = New MySqlCommand("SELECT geneSymbol FROM kgxref WHERE refseq='" & strSubSplit(j) & "';", cn)
                    dr = cmd.ExecuteReader
                    If dr.HasRows Then
                        dr.Read() : strSplit(i) &= dr(0) & strSeparator  'Add converted name and a pipe
                    Else
                        If rbtn3stars.Checked Then strSplit(i) &= "***" & strSeparator 'Or, if nothing converted, dummy and a pipe
                        If rbtnSourceID.Checked Then strSplit(i) &= strSubSplit(j) & strSeparator 'Or, if nothing converted, source and a pipe
                    End If
                    dr.Close() : cmd.Dispose()
                Next
                strSplit(i) = strSplit(i).Substring(0, strSplit(i).Length - 1) 'Remove last pipe
            End If
        Next
        TextBox1.Text = String.Join(vbCrLf, strSplit)
    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        TextBox1.Text = vbNullString
    End Sub

    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        TextBox1.SelectionStart = 0
        TextBox1.SelectionLength = TextBox1.Text.Length
        TextBox1.Copy()
    End Sub


    Private Sub btnClustering_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClustering.Click
        'Clustering of 
        If listFiles.Items.Count > 0 Then                                           'Proceed only if files available
            Dim mat As MLApp.MLApp = New MLApp.MLApp()                              'Initialize new Matlab instance
            mat.Execute("close all hidden;")                                        'Close previously created figures and histograms
            For Each FileName As ListItemFile In listFiles.Items                    'Process each file
                Dim readLineSP As String()                                          'Array to keep split string
                Dim ColNames As List(Of String) = New List(Of String), RowNames As List(Of String) = New List(Of String) 'Row/Column names storage
                Using reader As StreamReader = New StreamReader(FileName.filPath)
                    readLineSP = reader.ReadLine.Split(vbTab)                       'First line is header
                    For Each s As String In readLineSP                              'And each element in it
                        ColNames.Add(s)                                             'is added to the list
                    Next
                    ColNames.RemoveRange(0, 1)                                      'Remove the first element, which is not used
                    While Not reader.EndOfStream                                    'Go through each row
                        readLineSP = reader.ReadLine.Split(vbTab)                   'Read the line
                        RowNames.Add(readLineSP(0))                                 'and store only the first element, row name
                    End While
                End Using
                mat.Execute("clear all")                                            'Clear all values in Matlab space
                mat.PutWorkspaceData("ColNames", "base", ColNames.ToArray)          'Put ColNames array into Matlab
                mat.Execute("ColNames=ColNames';")                                  'Transpose it, so column names are horisontal
                mat.PutWorkspaceData("RowNames", "base", RowNames.ToArray)          'Put RowNames array
                mat.Execute("matrix=dlmread('" & FileName.filPath & "', '\t',1,1);") 'Read the matrix from the file, starting from row 1, column 1
                'http://www.mathworks.com/help/toolbox/bioinfo/ref/clustergram.html
                mat.Execute("clustergram(matrix,'ColumnLabels', ColNames, 'RowLabels', RowNames, 'Standardize', 'none','Symmetric',true,'Colormap', 'redgreencmap','DisplayRange',3);")
            Next
        Else
            MessageBox.Show("Need at least one matrix file to cluster")
        End If
    End Sub

    'stores the filepath as a variable for later use
    Private Class ListItemFile
        Inherits ListViewItem
        Public filPath As String
        Public fileDir As String
        Public fileName As String
    End Class

    Private Sub listFiles_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles listFiles.DragDrop
        If (e.Data.GetDataPresent(DataFormats.FileDrop) = True) Then
            For Each oneFile As String In _
              e.Data.GetData(DataFormats.FileDrop)
                Dim FileName_Ext() As String = Strings.Split(oneFile, "\")
                Dim nFile As New ListItemFile
                nFile.filPath = oneFile
                nFile.Text = FileName_Ext(FileName_Ext.Length - 1)
                nFile.fileDir = oneFile.Replace(nFile.Text, "")
                Dim FileName() As String = Strings.Split(FileName_Ext(FileName_Ext.Length - 1), ".")
                nFile.fileName = FileName(0)
                listFiles.Items.Add(nFile)
            Next oneFile
        End If

        'If e.Data.GetDataPresent(DataFormats.FileDrop) Then
        '    Dim MyFiles() As String
        '    Dim i As Integer

        '    ' Assign the files to an array.
        '    MyFiles = e.Data.GetData(DataFormats.FileDrop)
        '    ' Loop through the array and add the files to the list.
        '    For i = 0 To MyFiles.Length - 1
        '        listFiles.Items.Add(MyFiles(i))
        '    Next
        'End If
    End Sub

    Private Sub listFiles_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles listFiles.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub
End Class
