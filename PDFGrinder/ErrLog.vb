Imports System.IO
Module ErrLog
    '    Dim ERRFILE As String = Path.GetDirectoryName(Application.ExecutablePath) & "Errlog.txt"
    '  Dim ERRFILE As String = Application.ExecutablePath.Trim & ".Err"
    Dim ERRLogPath As String = LocalUserDataDir
    Public Function GetErrFileList() As String()
        ' Return as datasource for combo
        Dim files As String() = IO.Directory.GetFiles(ERRLOGPath, My.Application.Info.ProductName & "*.err")
        For f As Int32 = 0 To files.GetUpperBound(0)
            files(f) = IO.Path.GetFileName(files(f))
        Next
        Return files
    End Function

    Public Sub Write(ByVal ex As Exception, Optional ByVal ShowMsg As Boolean = True)
        ' make a new FileStream object, ready for read and write steps. 
        Try
            Dim ERRFILE As String = IO.Path.Combine(ERRLogPath, My.Application.Info.ProductName & Now.ToString("_yyyyMM") & ".exe.Err")
            Dim fs As FileStream = New FileStream(ERRFILE, FileMode.OpenOrCreate, FileAccess.ReadWrite)
            Dim w As StreamWriter = New StreamWriter(fs) ' create a stream writer 
            Dim stackTrace As New Diagnostics.StackFrame(2, True) ' Get 2 method back because 1 back is calling this error handler

            w.BaseStream.Seek(0, SeekOrigin.End) ' set the file pointer to the end of file 
            w.WriteLine("{0}[***** {1} {2} *****]", vbCrLf, Format(Now, "MM/dd/yyyy hh:mm:ss tt"), Now.DayOfWeek)
            w.WriteLine("Calling Method: {0} File: {1} Line:{2} Path: {3}", stackTrace.GetMethod.Name, IO.Path.GetFileName(stackTrace.GetFileName), stackTrace.GetFileLineNumber.ToString, IO.Path.GetDirectoryName(stackTrace.GetFileName))
            w.WriteLine("{0}", ex.Message)
            '        w.WriteLine("  {0}", e.Message.Replace(vbCrLf, ""))
            w.WriteLine("{0}", ex.StackTrace)
            w.Flush() ' update underlying file
            w.Close()
            w = Nothing
            fs.Close()
            fs = Nothing
            If ShowMsg Then
                Dim TheMsg As String
                TheMsg = "CALLING METHOD: " & stackTrace.GetMethod.Name & " File: " & IO.Path.GetFileName(stackTrace.GetFileName) & " Line:" & stackTrace.GetFileLineNumber.ToString & " Path: " & IO.Path.GetDirectoryName(stackTrace.GetFileName) & vbCrLf & vbCrLf
                TheMsg &= ex.Message + vbCrLf + ex.StackTrace
                TheMsg += vbCrLf + vbCrLf + "Error Log Has Been Updated. Please Notify Developer."
                MsgBox(TheMsg, MsgBoxStyle.Critical, "Application Error")
            End If
        Catch ex_Write As Exception
            Dim TheMsg As String
            TheMsg = "Error Log Update FAILED" + vbCrLf + ex_Write.Message + vbCrLf + ex_Write.StackTrace
            TheMsg += vbCrLf + vbCrLf + "Please Notify Developer Immediately."
            TheMsg += vbCrLf + vbCrLf + "You Will Be Shown The Original Error When You Click OK"
            MsgBox(TheMsg, MsgBoxStyle.Critical, "Application Error")
            TheMsg = ex.Message + vbCrLf + ex.StackTrace
            TheMsg += vbCrLf + vbCrLf + "Error Log HAS NOT Been Updated. Please Notify Developer."
            MsgBox(TheMsg, MsgBoxStyle.Critical, "Application Error")
        End Try
    End Sub

    Public Function Read(ByVal FillControl As TextBox, Optional Filename As String = "") As Int32
        If Filename = "" Then Filename = My.Application.Info.ProductName & Now.ToString("_yyyyMM") & ".exe.Err"
        Dim ERRFILE As String = IO.Path.Combine(ERRLogPath, Filename)
        If Not File.Exists(ERRFILE) Then
            FillControl.Text = "Log File Empty."
            Exit Function
        End If

        Dim fs As FileStream = New FileStream(ERRFILE, FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim r As StreamReader = New StreamReader(fs)  ' create a stream writer 

        Dim CountReads As Int32 = 0
        r.BaseStream.Seek(0, SeekOrigin.Begin)
        Do While r.Peek() > -1
            CountReads += 1
            FillControl.Text += r.ReadToEnd + vbCrLf
        Loop
        r.Close()
        r = Nothing
        fs.Close()
        fs = Nothing
    End Function


    Public Function DeleteLog(Optional Filename As String = "") As Boolean ' Delete Log File
        If Filename = "" Then Filename = My.Application.Info.ProductName & Now.ToString("_yyyyMM") & ".exe.Err"
        Dim ERRFILE As String = IO.Path.Combine(ERRLogPath, Filename)
        If File.Exists(ERRFILE) Then
            Try
                Kill(ERRFILE)
                Return True
            Catch
                Return False
            End Try
        End If
    End Function
End Module
