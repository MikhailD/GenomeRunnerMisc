<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnExtractAllGFs = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnRandFOIs = New System.Windows.Forms.Button()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.rbtnPipe = New System.Windows.Forms.RadioButton()
        Me.rbtnComma = New System.Windows.Forms.RadioButton()
        Me.rbtn3stars = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbtnSourceID = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.rbtnUcsc = New System.Windows.Forms.RadioButton()
        Me.rbtnRefseq = New System.Windows.Forms.RadioButton()
        Me.btnConvertTable2name = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.rbtnOutputConverted = New System.Windows.Forms.RadioButton()
        Me.rbtnOutputBoth = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnDiseaseOntology = New System.Windows.Forms.Button()
        Me.btnGOquery = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblHost = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblDB = New System.Windows.Forms.Label()
        Me.btnGenomeGovProcessing = New System.Windows.Forms.Button()
        Me.btnVistaEnhancers = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.listFiles = New System.Windows.Forms.ListView()
        Me.btnClustering = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.btnMC = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.btnRandGene = New System.Windows.Forms.Button()
        Me.txtMisc = New System.Windows.Forms.TextBox()
        Me.btnProcessVCF = New System.Windows.Forms.Button()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.btnProcessExons = New System.Windows.Forms.Button()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.btnTranscriptionExport = New System.Windows.Forms.Button()
        Me.btnHistoneModExtraction = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.btnExonExtract = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExtractAllGFs
        '
        Me.btnExtractAllGFs.Location = New System.Drawing.Point(6, 116)
        Me.btnExtractAllGFs.Name = "btnExtractAllGFs"
        Me.btnExtractAllGFs.Size = New System.Drawing.Size(96, 23)
        Me.btnExtractAllGFs.TabIndex = 0
        Me.btnExtractAllGFs.Text = "Extract All GFs"
        Me.btnExtractAllGFs.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(6, 87)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(96, 23)
        Me.btnConnect.TabIndex = 1
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnRandFOIs
        '
        Me.btnRandFOIs.Location = New System.Drawing.Point(6, 145)
        Me.btnRandFOIs.Name = "btnRandFOIs"
        Me.btnRandFOIs.Size = New System.Drawing.Size(96, 23)
        Me.btnRandFOIs.TabIndex = 2
        Me.btnRandFOIs.Text = "Create rand FOIs"
        Me.btnRandFOIs.UseVisualStyleBackColor = True
        '
        'btnConvert
        '
        Me.btnConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(163, 237)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "ID2name"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsReturn = True
        Me.TextBox1.AcceptsTab = True
        Me.TextBox1.AllowDrop = True
        Me.TextBox1.Location = New System.Drawing.Point(6, 88)
        Me.TextBox1.MaxLength = 327670000
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(143, 228)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.WordWrap = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID to name converter"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(192, 293)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(192, 264)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(75, 23)
        Me.btnCopy.TabIndex = 7
        Me.btnCopy.Text = "Copy"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'rbtnPipe
        '
        Me.rbtnPipe.AutoSize = True
        Me.rbtnPipe.Checked = True
        Me.rbtnPipe.Location = New System.Drawing.Point(9, 21)
        Me.rbtnPipe.Name = "rbtnPipe"
        Me.rbtnPipe.Size = New System.Drawing.Size(46, 17)
        Me.rbtnPipe.TabIndex = 9
        Me.rbtnPipe.TabStop = True
        Me.rbtnPipe.Text = "Pipe"
        Me.rbtnPipe.UseVisualStyleBackColor = True
        '
        'rbtnComma
        '
        Me.rbtnComma.AutoSize = True
        Me.rbtnComma.Location = New System.Drawing.Point(9, 44)
        Me.rbtnComma.Name = "rbtnComma"
        Me.rbtnComma.Size = New System.Drawing.Size(60, 17)
        Me.rbtnComma.TabIndex = 10
        Me.rbtnComma.TabStop = True
        Me.rbtnComma.Text = "Comma"
        Me.rbtnComma.UseVisualStyleBackColor = True
        '
        'rbtn3stars
        '
        Me.rbtn3stars.AutoSize = True
        Me.rbtn3stars.Checked = True
        Me.rbtn3stars.Location = New System.Drawing.Point(6, 19)
        Me.rbtn3stars.Name = "rbtn3stars"
        Me.rbtn3stars.Size = New System.Drawing.Size(37, 17)
        Me.rbtn3stars.TabIndex = 12
        Me.rbtn3stars.TabStop = True
        Me.rbtn3stars.Text = "***"
        Me.rbtn3stars.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnComma)
        Me.GroupBox1.Controls.Add(Me.rbtnPipe)
        Me.GroupBox1.Location = New System.Drawing.Point(163, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(160, 66)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Separator"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtnSourceID)
        Me.GroupBox2.Controls.Add(Me.rbtn3stars)
        Me.GroupBox2.Location = New System.Drawing.Point(163, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(160, 63)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "If not converted, replace by"
        '
        'rbtnSourceID
        '
        Me.rbtnSourceID.AutoSize = True
        Me.rbtnSourceID.Location = New System.Drawing.Point(6, 40)
        Me.rbtnSourceID.Name = "rbtnSourceID"
        Me.rbtnSourceID.Size = New System.Drawing.Size(73, 17)
        Me.rbtnSourceID.TabIndex = 13
        Me.rbtnSourceID.Text = "Source ID"
        Me.rbtnSourceID.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox11)
        Me.GroupBox3.Controls.Add(Me.btnConvertTable2name)
        Me.GroupBox3.Controls.Add(Me.GroupBox7)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.btnConvert)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.btnClear)
        Me.GroupBox3.Controls.Add(Me.btnCopy)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(334, 325)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Conversion"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.rbtnUcsc)
        Me.GroupBox11.Controls.Add(Me.rbtnRefseq)
        Me.GroupBox11.Location = New System.Drawing.Point(6, 16)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(142, 55)
        Me.GroupBox11.TabIndex = 17
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "ID type"
        '
        'rbtnUcsc
        '
        Me.rbtnUcsc.AutoSize = True
        Me.rbtnUcsc.Location = New System.Drawing.Point(9, 36)
        Me.rbtnUcsc.Name = "rbtnUcsc"
        Me.rbtnUcsc.Size = New System.Drawing.Size(54, 17)
        Me.rbtnUcsc.TabIndex = 1
        Me.rbtnUcsc.TabStop = True
        Me.rbtnUcsc.Text = "UCSC"
        Me.rbtnUcsc.UseVisualStyleBackColor = True
        '
        'rbtnRefseq
        '
        Me.rbtnRefseq.AutoSize = True
        Me.rbtnRefseq.Checked = True
        Me.rbtnRefseq.Location = New System.Drawing.Point(9, 18)
        Me.rbtnRefseq.Name = "rbtnRefseq"
        Me.rbtnRefseq.Size = New System.Drawing.Size(59, 17)
        Me.rbtnRefseq.TabIndex = 0
        Me.rbtnRefseq.TabStop = True
        Me.rbtnRefseq.Text = "Refseq"
        Me.rbtnRefseq.UseVisualStyleBackColor = True
        '
        'btnConvertTable2name
        '
        Me.btnConvertTable2name.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertTable2name.Location = New System.Drawing.Point(248, 237)
        Me.btnConvertTable2name.Name = "btnConvertTable2name"
        Me.btnConvertTable2name.Size = New System.Drawing.Size(75, 23)
        Me.btnConvertTable2name.TabIndex = 16
        Me.btnConvertTable2name.Text = "Table2name"
        Me.btnConvertTable2name.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.rbtnOutputConverted)
        Me.GroupBox7.Controls.Add(Me.rbtnOutputBoth)
        Me.GroupBox7.Location = New System.Drawing.Point(163, 158)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(160, 73)
        Me.GroupBox7.TabIndex = 15
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Output"
        '
        'rbtnOutputConverted
        '
        Me.rbtnOutputConverted.AutoSize = True
        Me.rbtnOutputConverted.Location = New System.Drawing.Point(9, 43)
        Me.rbtnOutputConverted.Name = "rbtnOutputConverted"
        Me.rbtnOutputConverted.Size = New System.Drawing.Size(96, 17)
        Me.rbtnOutputConverted.TabIndex = 1
        Me.rbtnOutputConverted.TabStop = True
        Me.rbtnOutputConverted.Text = "Converted only"
        Me.rbtnOutputConverted.UseVisualStyleBackColor = True
        '
        'rbtnOutputBoth
        '
        Me.rbtnOutputBoth.AutoSize = True
        Me.rbtnOutputBoth.Checked = True
        Me.rbtnOutputBoth.Location = New System.Drawing.Point(9, 20)
        Me.rbtnOutputBoth.Name = "rbtnOutputBoth"
        Me.rbtnOutputBoth.Size = New System.Drawing.Size(131, 17)
        Me.rbtnOutputBoth.TabIndex = 0
        Me.rbtnOutputBoth.TabStop = True
        Me.rbtnOutputBoth.Text = "Source and converted"
        Me.rbtnOutputBoth.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.btnDiseaseOntology)
        Me.GroupBox4.Controls.Add(Me.btnGOquery)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.btnGenomeGovProcessing)
        Me.GroupBox4.Controls.Add(Me.btnConnect)
        Me.GroupBox4.Controls.Add(Me.btnVistaEnhancers)
        Me.GroupBox4.Controls.Add(Me.btnExtractAllGFs)
        Me.GroupBox4.Controls.Add(Me.btnRandFOIs)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 343)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(334, 208)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Misc"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(253, 179)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnDiseaseOntology
        '
        Me.btnDiseaseOntology.Location = New System.Drawing.Point(207, 145)
        Me.btnDiseaseOntology.Name = "btnDiseaseOntology"
        Me.btnDiseaseOntology.Size = New System.Drawing.Size(121, 23)
        Me.btnDiseaseOntology.TabIndex = 20
        Me.btnDiseaseOntology.Text = "Disease ontology"
        Me.btnDiseaseOntology.UseVisualStyleBackColor = True
        '
        'btnGOquery
        '
        Me.btnGOquery.Location = New System.Drawing.Point(248, 19)
        Me.btnGOquery.Name = "btnGOquery"
        Me.btnGOquery.Size = New System.Drawing.Size(75, 23)
        Me.btnGOquery.TabIndex = 16
        Me.btnGOquery.Text = "GO query"
        Me.btnGOquery.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblHost)
        Me.GroupBox5.Controls.Add(Me.lblUser)
        Me.GroupBox5.Controls.Add(Me.lblDB)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(156, 62)
        Me.GroupBox5.TabIndex = 21
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Current Connection Settings"
        '
        'lblHost
        '
        Me.lblHost.AutoSize = True
        Me.lblHost.Location = New System.Drawing.Point(6, 29)
        Me.lblHost.Name = "lblHost"
        Me.lblHost.Size = New System.Drawing.Size(49, 13)
        Me.lblHost.TabIndex = 18
        Me.lblHost.Text = "localhost"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(6, 16)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(27, 13)
        Me.lblUser.TabIndex = 20
        Me.lblUser.Text = "user"
        '
        'lblDB
        '
        Me.lblDB.AutoSize = True
        Me.lblDB.Location = New System.Drawing.Point(6, 46)
        Me.lblDB.Name = "lblDB"
        Me.lblDB.Size = New System.Drawing.Size(22, 13)
        Me.lblDB.TabIndex = 19
        Me.lblDB.Text = "DB"
        '
        'btnGenomeGovProcessing
        '
        Me.btnGenomeGovProcessing.Location = New System.Drawing.Point(207, 116)
        Me.btnGenomeGovProcessing.Name = "btnGenomeGovProcessing"
        Me.btnGenomeGovProcessing.Size = New System.Drawing.Size(121, 23)
        Me.btnGenomeGovProcessing.TabIndex = 1
        Me.btnGenomeGovProcessing.Text = "genome.gov"
        Me.btnGenomeGovProcessing.UseVisualStyleBackColor = True
        '
        'btnVistaEnhancers
        '
        Me.btnVistaEnhancers.Location = New System.Drawing.Point(207, 87)
        Me.btnVistaEnhancers.Name = "btnVistaEnhancers"
        Me.btnVistaEnhancers.Size = New System.Drawing.Size(121, 23)
        Me.btnVistaEnhancers.TabIndex = 0
        Me.btnVistaEnhancers.Text = "Vista Enhancers"
        Me.btnVistaEnhancers.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.listFiles)
        Me.GroupBox6.Controls.Add(Me.btnClustering)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Location = New System.Drawing.Point(352, 12)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(137, 325)
        Me.GroupBox6.TabIndex = 18
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Clustering"
        '
        'listFiles
        '
        Me.listFiles.AllowDrop = True
        Me.listFiles.Location = New System.Drawing.Point(6, 37)
        Me.listFiles.Name = "listFiles"
        Me.listFiles.Size = New System.Drawing.Size(121, 250)
        Me.listFiles.TabIndex = 18
        Me.listFiles.UseCompatibleStateImageBehavior = False
        Me.listFiles.View = System.Windows.Forms.View.List
        '
        'btnClustering
        '
        Me.btnClustering.Location = New System.Drawing.Point(29, 296)
        Me.btnClustering.Name = "btnClustering"
        Me.btnClustering.Size = New System.Drawing.Size(75, 23)
        Me.btnClustering.TabIndex = 17
        Me.btnClustering.Text = "Cluster!"
        Me.btnClustering.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Drag-and-drop matrix files"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.btnMC)
        Me.GroupBox8.Controls.Add(Me.Label4)
        Me.GroupBox8.Controls.Add(Me.Label3)
        Me.GroupBox8.Controls.Add(Me.txtNumber)
        Me.GroupBox8.Controls.Add(Me.btnRandGene)
        Me.GroupBox8.Controls.Add(Me.txtMisc)
        Me.GroupBox8.Location = New System.Drawing.Point(495, 12)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(201, 325)
        Me.GroupBox8.TabIndex = 19
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Misc"
        '
        'btnMC
        '
        Me.btnMC.Location = New System.Drawing.Point(133, 128)
        Me.btnMC.Name = "btnMC"
        Me.btnMC.Size = New System.Drawing.Size(62, 23)
        Me.btnMC.TabIndex = 6
        Me.btnMC.Text = "MC"
        Me.btnMC.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(125, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "random genes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(132, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Generate"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(133, 36)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(62, 20)
        Me.txtNumber.TabIndex = 2
        Me.txtNumber.Text = "100"
        '
        'btnRandGene
        '
        Me.btnRandGene.Location = New System.Drawing.Point(134, 75)
        Me.btnRandGene.Name = "btnRandGene"
        Me.btnRandGene.Size = New System.Drawing.Size(61, 23)
        Me.btnRandGene.TabIndex = 1
        Me.btnRandGene.Text = "Generate!"
        Me.btnRandGene.UseVisualStyleBackColor = True
        '
        'txtMisc
        '
        Me.txtMisc.Location = New System.Drawing.Point(6, 34)
        Me.txtMisc.MaxLength = 32767000
        Me.txtMisc.Multiline = True
        Me.txtMisc.Name = "txtMisc"
        Me.txtMisc.Size = New System.Drawing.Size(121, 253)
        Me.txtMisc.TabIndex = 0
        '
        'btnProcessVCF
        '
        Me.btnProcessVCF.Location = New System.Drawing.Point(6, 15)
        Me.btnProcessVCF.Name = "btnProcessVCF"
        Me.btnProcessVCF.Size = New System.Drawing.Size(121, 23)
        Me.btnProcessVCF.TabIndex = 20
        Me.btnProcessVCF.Text = "Process VCF"
        Me.btnProcessVCF.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.btnProcessExons)
        Me.GroupBox9.Controls.Add(Me.btnProcessVCF)
        Me.GroupBox9.Location = New System.Drawing.Point(352, 353)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(137, 195)
        Me.GroupBox9.TabIndex = 21
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "GroupBox9"
        '
        'btnProcessExons
        '
        Me.btnProcessExons.Location = New System.Drawing.Point(6, 44)
        Me.btnProcessExons.Name = "btnProcessExons"
        Me.btnProcessExons.Size = New System.Drawing.Size(121, 23)
        Me.btnProcessExons.TabIndex = 23
        Me.btnProcessExons.Text = "Process exons"
        Me.btnProcessExons.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.btnExonExtract)
        Me.GroupBox10.Controls.Add(Me.btnTranscriptionExport)
        Me.GroupBox10.Controls.Add(Me.btnHistoneModExtraction)
        Me.GroupBox10.Location = New System.Drawing.Point(490, 353)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(189, 129)
        Me.GroupBox10.TabIndex = 23
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "UCSC Data Extraction"
        '
        'btnTranscriptionExport
        '
        Me.btnTranscriptionExport.Location = New System.Drawing.Point(5, 48)
        Me.btnTranscriptionExport.Name = "btnTranscriptionExport"
        Me.btnTranscriptionExport.Size = New System.Drawing.Size(178, 23)
        Me.btnTranscriptionExport.TabIndex = 1
        Me.btnTranscriptionExport.Text = "Transcription Factor Export"
        Me.btnTranscriptionExport.UseVisualStyleBackColor = True
        '
        'btnHistoneModExtraction
        '
        Me.btnHistoneModExtraction.Location = New System.Drawing.Point(5, 19)
        Me.btnHistoneModExtraction.Name = "btnHistoneModExtraction"
        Me.btnHistoneModExtraction.Size = New System.Drawing.Size(178, 23)
        Me.btnHistoneModExtraction.TabIndex = 0
        Me.btnHistoneModExtraction.Text = "Histone Modification Extraction"
        Me.btnHistoneModExtraction.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(496, 525)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(200, 23)
        Me.ProgressBar1.TabIndex = 24
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Location = New System.Drawing.Point(501, 506)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(0, 13)
        Me.lblProgress.TabIndex = 25
        '
        'btnExonExtract
        '
        Me.btnExonExtract.Location = New System.Drawing.Point(6, 77)
        Me.btnExonExtract.Name = "btnExonExtract"
        Me.btnExonExtract.Size = New System.Drawing.Size(177, 23)
        Me.btnExonExtract.TabIndex = 2
        Me.btnExonExtract.Text = "First/Last exon extraction"
        Me.btnExonExtract.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 560)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "Form1"
        Me.Text = "GenomeRunnerMisc"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExtractAllGFs As System.Windows.Forms.Button
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents btnRandFOIs As System.Windows.Forms.Button
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents rbtnPipe As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnComma As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn3stars As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnSourceID As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblDB As System.Windows.Forms.Label
    Friend WithEvents lblHost As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClustering As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents listFiles As System.Windows.Forms.ListView
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnOutputConverted As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnOutputBoth As System.Windows.Forms.RadioButton
    Friend WithEvents btnGOquery As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents btnVistaEnhancers As System.Windows.Forms.Button
    Friend WithEvents btnGenomeGovProcessing As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnDiseaseOntology As System.Windows.Forms.Button
    Friend WithEvents btnConvertTable2name As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnRandGene As System.Windows.Forms.Button
    Friend WithEvents txtMisc As System.Windows.Forms.TextBox
    Friend WithEvents btnProcessVCF As System.Windows.Forms.Button
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents btnProcessExons As System.Windows.Forms.Button
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents btnHistoneModExtraction As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btnTranscriptionExport As System.Windows.Forms.Button
    Friend WithEvents lblProgress As System.Windows.Forms.Label
    Friend WithEvents btnMC As System.Windows.Forms.Button
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnUcsc As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnRefseq As System.Windows.Forms.RadioButton
    Friend WithEvents btnExonExtract As System.Windows.Forms.Button

End Class
