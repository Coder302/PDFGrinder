Imports System.ComponentModel
Imports Infragistics
Imports Infragistics.Win.UltraWinGrid

Public Class Mainform
    Public dtFiles As DataTable
    Public dtList As DataTable
    Public curTabIndex As Int32 = 0
    Private Delegate Sub delInitProcProgs(ByVal DocCnt As Int32, ByVal PageCnt As Int32, ByVal Filesize As ULong)
    Private Delegate Sub delUpdateProcProgs(ByVal DocCnt As Int32, ByVal PageCnt As Int32, ByVal Filesize As Int32)

    Private Delegate Sub delUpdatePageCount(ByVal Rowindex As Int32, ByVal FileSize As Long, ByVal PageCount As Int32)
    Private Delegate Sub delGetTabPageSelectIndex(ByRef index As Int32)

    Public ProcFilesProgBars As ProgressForm
    Private CurTotalFiles As Int32
    Private CurTotalPages As Int32
    Private CurTotalSize As ULong

    Private TotalSizeType As String
    Private SizeProcSoFar As ULong
    Private StopWatch As Stopwatch
    Private useDPI As String
    Private useDownScale As String
    Private PagePattern As String
    Private UseDiffDir As String
    Private Sub Mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboDPI.SelectedIndex = 1
        cboDownScaleFactor.SelectedIndex = 0
        SetupGrid()
    End Sub
    Private Sub SetupGrid()
        dtFiles = New DataTable
        dtFiles.Columns.Add("FileName", Type.GetType("System.String"))
        dtFiles.Columns.Add("FileSize", Type.GetType("System.Int32"))
        dtFiles.Columns.Add("Pages", Type.GetType("System.Int32"))
        ugFiles.DataSource = dtFiles
        dtList = New DataTable
        dtList.Columns.Add("FileName", Type.GetType("System.String"))
        dtList.Columns.Add("FileSize", Type.GetType("System.Int32"))
        dtList.Columns.Add("Pages", Type.GetType("System.Int32"))
        ' dtList.Columns.Add("Folder", Type.GetType("System.String"))
        ugList.DataSource = dtList

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        TabControl1.SelectedIndex = 0
        If cboSrcDir.Text = "" OrElse Not IO.Directory.Exists(cboSrcDir.Text) Then
            Beep()
            Exit Sub
        End If
        AIPageCnt.Visible = True
        AIPageCnt.Start()
        Dim fa() As String
        If chkIncludeSubs.Checked Then
            fa = IO.Directory.GetFiles(cboSrcDir.Text, "*.PDF", IO.SearchOption.AllDirectories)
        Else
            fa = IO.Directory.GetFiles(cboSrcDir.Text, "*.PDF", IO.SearchOption.TopDirectoryOnly)
        End If
        dtFiles.Rows.Clear()
        Dim p As iTextSharp.text.pdf.PdfReader
        '  MsgBox(p.NumberOfPages)
        Dim tp As Int32 = 0
        Dim ts As Int64 = 0
        For Each f As String In fa
            Dim nr As DataRow = dtFiles.NewRow
            nr.Item(0) = f
            ' nr.Item(1) = FileLen(f)
            dtFiles.Rows.Add(nr)
            If chkPgCnt.Checked Then
                '  bgPages.RunWorkerAsync()
                'p = New iTextSharp.text.pdf.PdfReader(f)
                'nr.Item(2) = p.NumberOfPages
                '   tp += p.NumberOfPages
                '  ts += p.FileLength
            End If
        Next
        ugFiles.DataSource = dtFiles
        ugFiles.Text = "Files: " & ugFiles.Rows.Count.ToString & " (Pages:" & CurTotalPages.ToString & ")"
        Debug.WriteLine("rows-" & ugFiles.Rows.Count)
        Me.Text = "Getting Files."
        If chkPgCnt.Checked Then
            bgPages.RunWorkerAsync()
        End If

        'MsgBox("Total Pages" & tp.ToString & " Total bytes " & ts.ToString)
    End Sub


    Private Function PDF2TIF(Src As String, Optional page2export As Int32 = 0) As Boolean
        Return PDF2TIF(Src, IO.Path.ChangeExtension(Src, "TIF"), page2export)
    End Function
    Private Function PDF2TIF(Src As String, dst As String, Optional page2export As Int32 = 0) As Boolean
        Dim PdfFilePath As String = Src
        Dim TifFilePath As String = dst

        '      Dim Args() As String = {"-q", "-dNOPAUSE", "-dBATCH", "-dSAFER",
        '"-sDEVICE=png16m", "-r600", "-dDownScaleFactor=6", "-dTextAlphaBits=4",
        '"-dGraphicsAlphaBits=4", "-sPAPERSIZE=letter",
        '"-sOutputFile=" & PngFilePath, PdfFilePath}

        If radSingle.Checked Then
            TifFilePath = IO.Path.Combine(IO.Path.GetDirectoryName(TifFilePath), IO.Path.GetFileNameWithoutExtension(TifFilePath) & PagePattern & IO.Path.GetExtension(TifFilePath))

        End If
        'If chkSinglePg.Checked Then

        '    TifFilePath = IO.Path.Combine(IO.Path.GetDirectoryName(TifFilePath), IO.Path.GetFileNameWithoutExtension(TifFilePath) & "%04d" & IO.Path.GetExtension(TifFilePath))
        'End If
        Dim Args() As String


        '-r200
        'If page2export > 0 Then
        '    Args = {"-q", "-dNOPAUSE", "-dBATCH", "-dSAFER",
        '    "-dFirstPage=" & page2export.ToString,
        '    "-dLastPage=" & page2export.ToString,
        '    "-sDEVICE=tiffg4", "-r" & useDPI, "-dDownScaleFactor=6", "-dTextAlphaBits=4",
        '    "-dGraphicsAlphaBits=4", "-sPAPERSIZE=letter",
        '    "-sOutputFile=" & TifFilePath, PdfFilePath}
        'Else
        '    Args = {"-q", "-dNOPAUSE", "-dBATCH", "-dSAFER",
        '    "-sDEVICE=tiffg4", "-r" & useDPI, "-dDownScaleFactor=6", "-dTextAlphaBits=4",
        '    "-dGraphicsAlphaBits=4", "-sPAPERSIZE=letter",
        '    "-sOutputFile=" & TifFilePath, PdfFilePath}
        'End If
        If page2export > 0 Then
            Args = {"-q", "-dNOPAUSE", "-dBATCH", "-dSAFER",
            "-dFirstPage=" & page2export.ToString,
            "-dLastPage=" & page2export.ToString,
            "-sDEVICE=tiffg4", "-r" & useDPI, "-dDownScaleFactor=" & useDownScale, "-dTextAlphaBits=4",
            "-dGraphicsAlphaBits=4", "-sPAPERSIZE=letter",
            "-sOutputFile=" & TifFilePath, PdfFilePath}
        Else
            Args = {"-q", "-dNOPAUSE", "-dBATCH", "-dSAFER",
            "-sDEVICE=tiffg4", "-r" & useDPI, "-dDownScaleFactor=" & useDownScale, "-dTextAlphaBits=4",
            "-dGraphicsAlphaBits=4", "-sPAPERSIZE=letter",
            "-sOutputFile=" & TifFilePath, PdfFilePath}
        End If
        Try
            Return RunGS(Args)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim ug As UltraGrid

        If curTabIndex = 0 Then
            ug = ugFiles
        Else
            ug = ugList
        End If

        UseDiffDir = "" ' init it
        If ug.Rows.Count = 0 Then
            MsgBox("Please Load Some Files To Process First.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Task Aborted")
            Exit Sub
        End If
        If radProcSel.Checked Then
            If ug.Selected.Rows.Count = 0 Then
                MsgBox("Select Files To Process", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Process Aborted")
                Exit Sub
            End If
        End If

        If chkOutputDiffFolder.Checked Then
            If txtDest.Text = "" Then
                MsgBox("Enter Destination Folder or Uncheck Output to Different Folder.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Process Aborted")
                Exit Sub
            End If

            If Not IO.Directory.Exists(txtDest.Text) Then
                If MsgBox(txtDest.Text & vbCrLf & "Output Directoty Does Not Exist." & vbCrLf & vbCrLf & "Create It?", MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.No Then
                    Exit Sub
                Else
                    Try
                        IO.Directory.CreateDirectory(txtDest.Text)

                    Catch ex As Exception
                        MsgBox("Unable to Create Directory!" & vbCrLf & vbCrLf & txtDest.Text, MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Task Aborted")
                    End Try
                End If
            End If
            UseDiffDir = txtDest.Text
        End If

        PagePattern = cboPagePattern.Text
        useDPI = cboDPI.Text
        useDownScale = cboDownScaleFactor.Text.Substring(0, 1)
        If bgPages.IsBusy Then
            MsgBox("Still Counting Pages.. Hold On..")
            Exit Sub
        End If
        For x As Int32 = 0 To 34
            Dim ts As New TimeSpan(0, x, x, x)

            Debug.WriteLine(String.Format("{3:0} Time Remaining  {0} Hours, {1} Minutes, {2} Seconds", ts.Hours, ts.Minutes, ts.Seconds, ts.TotalHours))
            '            Debug.WriteLine(FormatBytes(CULng((2 ^ x) + x), 2))
        Next
        ' Exit Sub
        ProcFilesProgBars = New ProgressForm(AddressOf ProcFilesCallBack)
        '   StopWatch = New Stopwatch
        ProcFilesProgBars.ShowDialog()
    End Sub

    Private Sub bgPages_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgPages.DoWork
        Dim ug As UltraGrid

        If curtabindex = 0 Then
            ug = ugFiles
        Else
            ug = ugList
        End If
        '  ug = ugList

        Dim p As iTextSharp.text.pdf.PdfReader
        CurTotalFiles = 0
        CurTotalPages = 0
        CurTotalSize = 0
        SizeProcSoFar = 0
        For r As Int32 = 0 To ug.Rows.Count - 1
            'If e.Cancel = True Then
            '    Exit Sub
            'End If
            Try
                p = New iTextSharp.text.pdf.PdfReader(ug.Rows(r).Cells("FileName").Text)
                UpdatePageCount(r, p.FileLength, p.NumberOfPages)
            Catch ex As Exception
                UpdatePageCount(r, 0, 0)

            End Try
            Debug.WriteLine("Done bg")
        Next
        p.Close()

        CurTotalFiles = ug.Rows.Count
        Beep()
    End Sub

    Private Sub bgPages_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgPages.ProgressChanged
        '        UpdatePageCount(RowIndex, PageCount)

    End Sub
    Private Sub bgPages_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgPages.RunWorkerCompleted
        AIPageCnt.Stop(True)
        AIPageCnt.Visible = False
        Debug.WriteLine("Runworker Completed")
        'Me.Text = "Pages Counted"
        If TabControl1.SelectedIndex = 0 Then
            ugFiles.Text = "Files: " & ugFiles.Rows.Count.ToString & " (Pages:" & CurTotalPages.ToString & ")"
        Else
            ugList.Text = "Files: " & ugList.Rows.Count.ToString & " (Pages:" & CurTotalPages.ToString & ")"
        End If
    End Sub
    Private Sub UpdatePageCount(ByVal rowIndex As Int32, ByVal FileSize As Long, ByVal PageCount As Int32)
        Try
            If InvokeRequired Then
                Dim d As New delUpdatePageCount(AddressOf UpdatePageCount)
                Me.Invoke(d, New Object() {[rowIndex], [FileSize], [PageCount]})
            Else
                '            dtFiles.Rows(rowIndex).Item("PageCount") = PageCount.ToString
                If TabControl1.SelectedIndex = 0 Then
                    ugFiles.Rows(rowIndex).Cells("FileSize").Value = FileSize
                    CurTotalSize += CULng(FileSize)
                    ugFiles.Rows(rowIndex).Cells("Pages").Value = PageCount
                    ugFiles.Rows(rowIndex).Update()
                    CurTotalPages += PageCount
                Else
                    ugList.Rows(rowIndex).Cells("FileSize").Value = FileSize
                    CurTotalSize += CULng(FileSize)
                    ugList.Rows(rowIndex).Cells("Pages").Value = PageCount
                    ugList.Rows(rowIndex).Update()
                    CurTotalPages += PageCount
                End If

                '      Debug.WriteLine("Pageup")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btntestproc_Click(sender As Object, e As EventArgs)
        If bgPages.IsBusy Then
            MsgBox("Still Counting Pages.. Hold On..")
            Exit Sub
        End If
        For x As Int32 = 0 To 34
            Dim ts As New TimeSpan(0, x, x, x)

            Debug.WriteLine(String.Format("{3:0} Time Remaining  {0} Hours, {1} Minutes, {2} Seconds", ts.Hours, ts.Minutes, ts.Seconds, ts.TotalHours))
            '            Debug.WriteLine(FormatBytes(CULng((2 ^ x) + x), 2))
        Next
        ' Exit Sub
        ProcFilesProgBars = New ProgressForm(AddressOf ProcFilesCallBack)

        ProcFilesProgBars.ShowDialog()
    End Sub
    Private Sub ProcFilesCallBack(ByRef pf As ProgressForm)
        bgProcFiles.RunWorkerAsync()
    End Sub

    Private Sub bgProcFiles_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgProcFiles.DoWork
        '  StopWatch.Start()
        Dim ug As UltraGrid
        If curTabIndex = 0 Then
            ug = ugFiles
        Else
            ug = ugList
        End If
        Dim SelCurTotalPages As Int32
        Dim SelCurTotalSize As ULong
        SelCurTotalSize = 0
        SelCurTotalPages = 0
        If radProcSel.Checked Then
            For Each row As Win.UltraWinGrid.UltraGridRow In ug.Selected.Rows
                SelCurTotalPages += CInt(row.Cells("Pages").Value)
                SelCurTotalSize += CULng(row.Cells("FileSize").Value)
            Next
            InitProcProgs(ug.Selected.Rows.Count, SelCurTotalPages, SelCurTotalSize)
        Else
            For Each row As Win.UltraWinGrid.UltraGridRow In ug.Rows
                SelCurTotalPages += CInt(row.Cells("Pages").Value)
                SelCurTotalSize += CULng(row.Cells("FileSize").Value)
            Next
            '            InitProcProgs(CurTotalFiles, CurTotalPages, CurTotalSize)
            InitProcProgs(ug.Rows.Count, SelCurTotalPages, SelCurTotalSize)
        End If
        SizeProcSoFar = 0
        For Each row As Win.UltraWinGrid.UltraGridRow In ug.Rows
            If radProcAll.Checked OrElse row.Selected Then
                With ProcFilesProgBars
                    If .AskingToCancel Then
                        StopWatch.Stop()
                        If MsgBox("Are You Sure You Want To Cancel?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Abort") = MsgBoxResult.Yes Then
                            .Cancelled = True
                            e.Cancel = True
                            Exit Sub
                        Else
                            .AskingToCancel = False
                        End If
                        StopWatch.Start() 'Resume
                    End If
                End With
                If Not UseDiffDir = "" Then
                    Dim NewDir As String = IO.Path.GetDirectoryName(row.Cells("Filename").Text.Replace(cboSrcDir.Text, txtDest.Text))
                    If Not IO.Directory.Exists(NewDir) Then
                        IO.Directory.CreateDirectory(NewDir)
                    End If
                    If PDF2TIF(row.Cells("Filename").Text, IO.Path.ChangeExtension(IO.Path.Combine(NewDir, IO.Path.GetFileName(row.Cells("Filename").Text)), "TIF")) = False Then
                        ProcFilesProgBars.Cancelled = True
                        e.Cancel = True
                        Exit Sub
                    End If
                Else
                    If PDF2TIF(row.Cells("Filename").Text) = False Then
                        ProcFilesProgBars.Cancelled = True
                        e.Cancel = True
                        Exit Sub
                    End If
                End If

                SizeProcSoFar += CULng(row.Cells("Filesize").Value)
                Try
                    UpdateProcProgs(1, CInt(row.Cells("Pages").Value), CInt(FormatBytesAs(TotalSizeType, SizeProcSoFar, 0, True)))
                Catch
                    'todo craig fix this im ignoring an error
                End Try
            End If
        Next

    End Sub
    Private Sub InitProcProgs(ByVal DocCnt As Int32, ByVal PageCnt As Int32, ByVal Filesize As ULong)
        If InvokeRequired Then
            Dim d As New delInitProcProgs(AddressOf InitProcProgs)
            Me.Invoke(d, New Object() {[DocCnt], [PageCnt], [Filesize]})
        Else
            StopWatch = New Stopwatch
            StopWatch.Start()
            ProcFilesProgBars.ProgFiles.Maximum = CurTotalFiles
            ProcFilesProgBars.ProgPages.Maximum = CurTotalPages
            TotalSizeType = FormatBytes(Filesize, 0, False)
            TotalSizeType = TotalSizeType.Substring(TotalSizeType.IndexOf(" ") + 1)
            ProcFilesProgBars.ProgSize.Text = String.Format("{2}% Size {0}/{1} {3}", Infragistics.Win.UltraWinProgressBar.UltraProgressBar.LABEL_VALUE, Infragistics.Win.UltraWinProgressBar.UltraProgressBar.LABEL_MAXIMUM, Infragistics.Win.UltraWinProgressBar.UltraProgressBar.LABEL_PERCENT_COMPLETED, TotalSizeType)
            ProcFilesProgBars.ProgSize.Maximum = CInt(FormatBytes(Filesize, 0, True)) ' CurTotalSize
            Debug.WriteLine(" -------- SizeMax set to" & ProcFilesProgBars.ProgSize.Maximum.ToString)
        End If
    End Sub
    Private Sub UpdateProcProgs(ByVal AddDocCnt As Int32, ByVal AddPageCnt As Int32, ByVal SetFilesize As Int32)
        If InvokeRequired Then
            Dim d As New delUpdateProcProgs(AddressOf UpdateProcProgs)
            Me.Invoke(d, New Object() {[AddDocCnt], [AddPageCnt], [SetFilesize]})
        Else
            Debug.WriteLine(" -------- try set Sizeval to " & SetFilesize.ToString & "curval=" & ProcFilesProgBars.ProgSize.Maximum.ToString)
            ProcFilesProgBars.ProgFiles.Value += AddDocCnt
            ProcFilesProgBars.ProgPages.Value += AddPageCnt
            ProcFilesProgBars.ProgSize.Value = SetFilesize 'This i set instead of add
            ProcFilesProgBars.lblTimeElapsed.Text = String.Format("Time Processing {0:0} Hours, {1} Minutes, {2} Seconds", StopWatch.Elapsed.TotalHours, StopWatch.Elapsed.Minutes, StopWatch.Elapsed.Seconds)
            '            StopWatch.Elapsed.Ticks
            Dim ts As New TimeSpan(CLng(StopWatch.Elapsed.Ticks / ProcFilesProgBars.ProgSize.Value * (ProcFilesProgBars.ProgSize.Maximum - ProcFilesProgBars.ProgSize.Value)))

            '            CLng(StopWatch.Elapsed.Ticks / ProcFilesProgBars.ProgSize.Value * (ProcFilesProgBars.ProgSize.Maximum - ProcFilesProgBars.ProgSize.Value))

            ProcFilesProgBars.lblTimeLeft.Text = String.Format("Time Remaining  {0:0} Hours, {1} Minutes, {2} Seconds", ts.TotalHours, ts.Minutes, ts.Seconds)
        End If
    End Sub
    Private Sub GetTabPageSelectIndex(ByRef index As Int32)
        'delGetTabPageSelectIndex
        If InvokeRequired Then
            Dim d As New delGetTabPageSelectIndex(AddressOf GetTabPageSelectIndex)
            Me.Invoke(d, New Object() {index})
        Else
            index = TabControl1.SelectedIndex
        End If
    End Sub

    Private Sub bgProcFiles_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgProcFiles.RunWorkerCompleted
        StopWatch.Stop()
        If e.Error IsNot Nothing Then
            ' MsgBox("bgProcFiles Error" & e.Error.Message)
            ErrLog.Write(e.Error)
        End If

        If e.Cancelled Then
            Dim stats As String
            stats = "Files: " & ProcFilesProgBars.ProgFiles.Value.ToString & vbCrLf
            stats &= "Pages: " & ProcFilesProgBars.ProgPages.Value.ToString & vbCrLf
            stats &= "Size: " & ProcFilesProgBars.ProgSize.Value.ToString & " " & TotalSizeType & vbCrLf
            MsgBox("Conversion Cancelled!" & vbCrLf & stats & vbCrLf &
                   String.Format("Time Processing {0:0} Hours, {1} Minutes, {2} Seconds",
                   StopWatch.Elapsed.TotalHours, StopWatch.Elapsed.Minutes, StopWatch.Elapsed.Seconds),
                   MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Conversion Results")
        Else
            Dim stats As String
            stats = "Files: " & ProcFilesProgBars.ProgFiles.Value.ToString & vbCrLf
            stats &= "Pages: " & ProcFilesProgBars.ProgPages.Value.ToString & vbCrLf
            stats &= "Size: " & ProcFilesProgBars.ProgSize.Value.ToString & " " & TotalSizeType & vbCrLf
            MsgBox("Conversion Complete!" & vbCrLf & stats & vbCrLf &
                   String.Format("Time Processing {0:0} Hours, {1} Minutes, {2} Seconds",
                   StopWatch.Elapsed.TotalHours, StopWatch.Elapsed.Minutes, StopWatch.Elapsed.Seconds),
                   MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Conversion Results")
        End If
        StopWatch.Reset()
        ProcFilesProgBars.Close()
    End Sub

    Private Sub txtDest_TextChanged(sender As Object, e As EventArgs) Handles txtDest.TextChanged

    End Sub

    Private Sub txtDest_Validated(sender As Object, e As EventArgs) Handles txtDest.Validated
        If Not txtDest.Text.EndsWith("\") Then
            txtDest.Text &= "\"
        End If
    End Sub

    Private Sub cboSrcDir_Validated(sender As Object, e As EventArgs) Handles cboSrcDir.Validated
        If Not cboSrcDir.Text.EndsWith("\") Then
            cboSrcDir.Text &= "\"
        End If
    End Sub

    Private Sub ugFiles_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs)
        Process.Start(e.Row.Cells("Filename").Text.ToString)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBrowSrc.Click
        Dim brow As New FolderBrowserDialog
        brow.RootFolder = Environment.SpecialFolder.MyComputer
        If Not cboSrcDir.Text = "" AndAlso IO.Directory.Exists(cboSrcDir.Text) Then
            brow.SelectedPath = cboSrcDir.Text

        End If
        SendKeys.Send("{Tab}{Tab}{Right}")
        If brow.ShowDialog = DialogResult.OK Then
            cboSrcDir.Text = brow.SelectedPath
            cboSrcDir_Validated(Nothing, Nothing)
        End If
    End Sub



    Private Sub Mainform_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub Mainform_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            TabControl1.SelectTab(1)
            Application.DoEvents()
            Dim filePaths As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
            For Each filePath As String In filePaths
                Dim nr As DataRow = dtList.NewRow

                nr(0) = filePath
                dtList.Rows.Add(nr)
            Next filePath
            '            ugList.DataSource = dtlist
            ugList.Text = "Files: " & ugList.Rows.Count.ToString & " (Pages:" & CurTotalPages.ToString & ")"
            Debug.WriteLine("rows-" & ugFiles.Rows.Count)
            Me.Text = "Getting Files."
            If chkPgCnt.Checked Then
                bgPages.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        curTabIndex = TabControl1.SelectedIndex
    End Sub


End Class
