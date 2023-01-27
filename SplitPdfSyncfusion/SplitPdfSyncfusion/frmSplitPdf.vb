#Region "About"
' / --------------------------------------------------------------------------------
' / Developer : Mr.Surapon Yodsanga (Thongkorn Tubtimkrob)
' / eMail : thongkorn@hotmail.com
' / URL: http://www.g2gnet.com (Khon Kaen - Thailand)
' / Facebook: https://www.facebook.com/g2gnet (For Thailand)
' / Facebook: https://www.facebook.com/commonindy (Worldwide)
' / More Info: http://www.g2gsoft.com/
' /
' / Purpose: Split PDF page with Syncfusion Community License Free.
' / Microsoft Visual Basic .NET (2010)
' /
' / This is open source code under @CopyLeft by Thongkorn Tubtimkrob.
' / You can modify and/or distribute without to inform the developer.
' / --------------------------------------------------------------------------------
#End Region

Imports Syncfusion.Pdf
Imports Syncfusion.Pdf.Parsing
Imports Syncfusion.Windows.Forms

Public Class frmSplitPdf

    '// PDF Path 
    Private strPathPDF As String = ""
    Private strPathOutput As String = ""

    ' / --------------------------------------------------------------------------------
    ' / Get my project path
    ' / AppPath = C:\My Project\bin\debug
    ' / Replace "\bin\debug" with "\"
    ' / Return : C:\My Project\
    Function MyPath(ByVal AppPath As String) As String
        '/ Return Value
        MyPath = AppPath.ToLower.Replace("\bin\debug", "\").Replace("\bin\release", "\").Replace("\bin\x86\debug", "\")
        '// If not found folder then put the \ (BackSlash) at the end.
        If Microsoft.VisualBasic.Right(MyPath, 1) <> Chr(92) Then MyPath = MyPath & Chr(92)
    End Function

    ' / --------------------------------------------------------------------------------
    ' / S T A R T ... H E R E
    ' / --------------------------------------------------------------------------------
    Private Sub frmSplitPdf_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '// If folders doesn't exist? then create it.
        '// Original PDF Folder.
        If Not System.IO.Directory.Exists(strPathPDF) Then
            System.IO.Directory.CreateDirectory(MyPath(Application.StartupPath) & "PDF\")
            strPathPDF = MyPath(Application.StartupPath & "PDF\")
        End If
        '// Output PDF Folder.
        If Not System.IO.Directory.Exists(strPathOutput) Then
            System.IO.Directory.CreateDirectory(MyPath(Application.StartupPath) & "Output\")
            strPathOutput = MyPath(Application.StartupPath & "Output\")
        End If
        '// Disable Open/Save toolbar PdfViewerControl of Syncfusion.
        DirectCast(Me.PdfViewerControl1.Controls(0).Controls(0).Controls(0), ToolStrip).Items(0).Visible = False
        DirectCast(Me.PdfViewerControl1.Controls(0).Controls(0).Controls(0), ToolStrip).Items(1).Visible = False
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / Browse PDF File and Load it into PdfViewerControl.
    ' / --------------------------------------------------------------------------------
    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowse.Click
        '/ Declare Open File Dialog @ Run Time.
        Dim dlgOpenFile As OpenFileDialog = New OpenFileDialog()
        Try
            ' / Initialize Open File Dialog.
            With dlgOpenFile
                .InitialDirectory = strPathPDF
                .Title = "Select PDF File"
                .Filter = "PDF Files (*.pdf)|*.pdf"
                .RestoreDirectory = True
            End With
            '/ If the OK button is selected.
            If dlgOpenFile.ShowDialog() = DialogResult.OK Then
                txtFileName.Text = dlgOpenFile.FileName
                '/ Show PDF on PDFViewerControl of Syncfusion.
                Me.PdfViewerControl1.Load(dlgOpenFile.FileName, "")
                '/ Load document.
                Dim LoadDocument As PdfLoadedDocument = New PdfLoadedDocument(txtFileName.Text)
                '// Go To Sub Program Count Pages.
                Call CountPage(LoadDocument)
                LoadDocument.Close(True)
            End If

        Catch ex As Exception
            MessageBoxAdv.Show(ex.Message, "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / Split PDF All Pages.
    ' / --------------------------------------------------------------------------------
    Private Sub btnSplitAllPage_Click(sender As System.Object, e As System.EventArgs) Handles btnSplitAllPage.Click
        If txtFileName.Text.Length = 0 Then Return
        Try
            '// Load PDF document ... Imports Syncfusion.Pdf.Parsing
            Dim LoadDocument As PdfLoadedDocument = New PdfLoadedDocument(txtFileName.Text)
            '// Split PDF document with pattern and save each page.
            LoadDocument.Split(strPathOutput & "Document-{0}.pdf")
            '// Close the document
            LoadDocument.Close(True)
            MessageBoxAdv.Show("Split PDF Successfully.", "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '//
            Dim dlgOpenFile As OpenFileDialog = New OpenFileDialog()
            ' / Initialize Open File Dialog.
            With dlgOpenFile
                .InitialDirectory = strPathOutput
                .Title = "Open PDF File"
                .Filter = "PDF Files (*.pdf)|*.pdf"
                .RestoreDirectory = True
            End With
            '/ If the OK button is selected.
            If dlgOpenFile.ShowDialog() = DialogResult.OK Then
                '/ Show PDF on PDFViewerControl of Syncfusion.
                Me.PdfViewerControl1.Load(dlgOpenFile.FileName, "")
                txtFileName.Text = dlgOpenFile.FileName
                LoadDocument = New PdfLoadedDocument(txtFileName.Text)
                '// Go To Sub Program Count Pages.
                Call CountPage(LoadDocument)
            End If
            LoadDocument.Close(True)
            '//
        Catch ex As Exception
            MessageBoxAdv.Show(ex.Message, "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / Split Range Pages.
    ' / --------------------------------------------------------------------------------
    Private Sub btnSplitPage_Click(sender As System.Object, e As System.EventArgs) Handles btnSplitPage.Click
        If txtFileName.Text.Length = 0 Then Return
        Try
            '// Load PDF document ... Imports Syncfusion.Pdf.Parsing
            Dim LoadDocument As PdfLoadedDocument = New PdfLoadedDocument(txtFileName.Text)
            '// Declare Save File Dialog Control @Run Time 
            Dim dlgSaveFile As SaveFileDialog = New SaveFileDialog
            '// Initialize Save File Dialog
            With dlgSaveFile
                .InitialDirectory = strPathOutput
                .Title = "Save PDF File"
                .Filter = "Save PDF File |*.pdf"
                .RestoreDirectory = True
            End With
            '// Save the new PDF document.
            If dlgSaveFile.ShowDialog() = DialogResult.OK Then
                If txtFileName.Text = dlgSaveFile.FileName Then
                    MessageBoxAdv.Show("This file is already opened. Please close it before saving.", "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If
                '// Create new PDF document.
                Dim document As PdfDocument = New PdfDocument()
                Dim PageFrom As Integer = cmbPageFrom.SelectedIndex
                Dim PageTo As Integer = cmbPageTo.SelectedIndex
                '// Import the range of pages from the existing PDF
                '// If the first page is greater than the last page have to swap values.
                If PageFrom < PageTo Then
                    document.ImportPageRange(LoadDocument, PageFrom, PageTo)
                Else
                    document.ImportPageRange(LoadDocument, PageTo, PageFrom)
                End If
                '// Save PDF.
                document.Save(dlgSaveFile.FileName)
                txtFileName.Text = dlgSaveFile.FileName
                LoadDocument = New PdfLoadedDocument(txtFileName.Text)
                Me.PdfViewerControl1.Load(txtFileName.Text, "")
                Call CountPage(LoadDocument)
                document.Close(True)
            End If
            '// Close the PDF document.
            LoadDocument.Close(True)
            '//
        Catch ex As Exception
            MessageBoxAdv.Show(ex.Message, "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / Count Pages.
    ' / --------------------------------------------------------------------------------
    Sub CountPage(ByRef doc As PdfLoadedDocument)
        '/ Show PDF on PDFViewerControl of Syncfusion.
        Dim count As Integer = doc.Pages.Count
        cmbPageFrom.Items.Clear()
        cmbPageTo.Items.Clear()
        For pg As Integer = 1 To count
            cmbPageTo.Items.Add(pg)
            cmbPageFrom.Items.Add(pg)
        Next
        cmbPageTo.SelectedIndex = 0
        cmbPageFrom.SelectedIndex = 0
    End Sub

    Private Sub txtFileName_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtFileName.KeyPress
        '/ Protect key press on TextBox Control.
        e.Handled = True
    End Sub

    Private Sub frmSplitPdf_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        GC.SuppressFinalize(Me)
        Application.Exit()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
