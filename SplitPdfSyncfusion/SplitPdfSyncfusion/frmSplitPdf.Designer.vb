<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplitPdf
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
        Dim MessageBoxSettings3 As Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings = New Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings()
        Dim PdfViewerPrinterSettings3 As Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings = New Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplitPdf))
        Dim TextSearchSettings3 As Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings = New Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings()
        Me.PdfViewerControl1 = New Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbPageTo = New System.Windows.Forms.ComboBox()
        Me.cmbPageFrom = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSplitPage = New System.Windows.Forms.Button()
        Me.btnSplitAllPage = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PdfViewerControl1
        '
        Me.PdfViewerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PdfViewerControl1.CursorMode = Syncfusion.Windows.Forms.PdfViewer.PdfViewerCursorMode.SelectTool
        Me.PdfViewerControl1.EnableContextMenu = True
        Me.PdfViewerControl1.EnableNotificationBar = True
        Me.PdfViewerControl1.HorizontalScrollOffset = 0
        Me.PdfViewerControl1.IsBookmarkEnabled = True
        Me.PdfViewerControl1.IsTextSearchEnabled = True
        Me.PdfViewerControl1.IsTextSelectionEnabled = True
        Me.PdfViewerControl1.Location = New System.Drawing.Point(3, 80)
        MessageBoxSettings3.EnableNotification = True
        Me.PdfViewerControl1.MessageBoxSettings = MessageBoxSettings3
        Me.PdfViewerControl1.MinimumZoomPercentage = 50
        Me.PdfViewerControl1.Name = "PdfViewerControl1"
        Me.PdfViewerControl1.PageBorderThickness = 1
        PdfViewerPrinterSettings3.Copies = 1
        PdfViewerPrinterSettings3.PageOrientation = Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.[Auto]
        PdfViewerPrinterSettings3.PageSize = Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.ActualSize
        PdfViewerPrinterSettings3.PrintLocation = CType(resources.GetObject("PdfViewerPrinterSettings3.PrintLocation"), System.Drawing.PointF)
        PdfViewerPrinterSettings3.ShowPrintStatusDialog = True
        Me.PdfViewerControl1.PrinterSettings = PdfViewerPrinterSettings3
        Me.PdfViewerControl1.ReferencePath = Nothing
        Me.PdfViewerControl1.ScrollDisplacementValue = 0
        Me.PdfViewerControl1.ShowHorizontalScrollBar = True
        Me.PdfViewerControl1.ShowToolBar = True
        Me.PdfViewerControl1.ShowVerticalScrollBar = True
        Me.PdfViewerControl1.Size = New System.Drawing.Size(1008, 569)
        Me.PdfViewerControl1.SpaceBetweenPages = 8
        Me.PdfViewerControl1.TabIndex = 6
        Me.PdfViewerControl1.Text = "PdfViewerControl1"
        TextSearchSettings3.CurrentInstanceColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(64, Byte), Integer))
        TextSearchSettings3.HighlightAllInstance = True
        TextSearchSettings3.OtherInstanceColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PdfViewerControl1.TextSearchSettings = TextSearchSettings3
        Me.PdfViewerControl1.ThemeName = "Default"
        Me.PdfViewerControl1.VerticalScrollOffset = 0
        Me.PdfViewerControl1.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.[Default]
        Me.PdfViewerControl1.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.[Default]
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.Image = CType(resources.GetObject("btnBrowse.Image"), System.Drawing.Image)
        Me.btnBrowse.Location = New System.Drawing.Point(982, 11)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(28, 28)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtFileName
        '
        Me.txtFileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFileName.Location = New System.Drawing.Point(74, 12)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(906, 26)
        Me.txtFileName.TabIndex = 0
        Me.txtFileName.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "PDF File:"
        '
        'cmbPageTo
        '
        Me.cmbPageTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPageTo.FormattingEnabled = True
        Me.cmbPageTo.Location = New System.Drawing.Point(184, 44)
        Me.cmbPageTo.Name = "cmbPageTo"
        Me.cmbPageTo.Size = New System.Drawing.Size(66, 26)
        Me.cmbPageTo.TabIndex = 3
        '
        'cmbPageFrom
        '
        Me.cmbPageFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPageFrom.FormattingEnabled = True
        Me.cmbPageFrom.Location = New System.Drawing.Point(74, 44)
        Me.cmbPageFrom.Name = "cmbPageFrom"
        Me.cmbPageFrom.Size = New System.Drawing.Size(66, 26)
        Me.cmbPageFrom.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 18)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "From: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(146, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 18)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "To: "
        '
        'btnSplitPage
        '
        Me.btnSplitPage.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSplitPage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSplitPage.FlatAppearance.BorderSize = 0
        Me.btnSplitPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSplitPage.ForeColor = System.Drawing.Color.White
        Me.btnSplitPage.Location = New System.Drawing.Point(256, 44)
        Me.btnSplitPage.Name = "btnSplitPage"
        Me.btnSplitPage.Size = New System.Drawing.Size(121, 27)
        Me.btnSplitPage.TabIndex = 4
        Me.btnSplitPage.Text = "Split Page"
        Me.btnSplitPage.UseVisualStyleBackColor = False
        '
        'btnSplitAllPage
        '
        Me.btnSplitAllPage.BackColor = System.Drawing.Color.Gold
        Me.btnSplitAllPage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSplitAllPage.FlatAppearance.BorderSize = 0
        Me.btnSplitAllPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSplitAllPage.ForeColor = System.Drawing.Color.Black
        Me.btnSplitAllPage.Location = New System.Drawing.Point(383, 44)
        Me.btnSplitAllPage.Name = "btnSplitAllPage"
        Me.btnSplitAllPage.Size = New System.Drawing.Size(121, 27)
        Me.btnSplitAllPage.TabIndex = 5
        Me.btnSplitAllPage.Text = "Split All Page"
        Me.btnSplitAllPage.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(889, 45)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(121, 27)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit Program"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmSplitPdf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 652)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSplitAllPage)
        Me.Controls.Add(Me.btnSplitPage)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbPageFrom)
        Me.Controls.Add(Me.cmbPageTo)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PdfViewerControl1)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1030, 691)
        Me.Name = "frmSplitPdf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Split PDF Page [Syncfusion] - coDe bY: Thongkorn Tubtimkrob"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PdfViewerControl1 As Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl
    Friend WithEvents cmbPageTo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPageFrom As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSplitPage As System.Windows.Forms.Button
    Friend WithEvents btnSplitAllPage As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
