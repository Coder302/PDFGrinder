Module Globals
    Public LocalUserDataDir As String = Application.LocalUserAppDataPath.Substring(0, Application.LocalUserAppDataPath.LastIndexOf("\"c) + 1)

    Public Property FormatBytes(ByVal BytesCaller As ULong, ByVal decplaces As Int32, ByVal JustDigits As Boolean) As String
        Get
            Try
                Select Case BytesCaller
                    Case Is >= 1099511627776
                        ' DoubleBytes = CDbl(BytesCaller / 1099511627776) 'TB
                        Return FormatNumber(CDbl(BytesCaller / 1099511627776), decplaces) & IIf(JustDigits, "", " TB").ToString
                    Case 1073741824 To 1099511627775
                        ' DoubleBytes = CDbl(BytesCaller / 1073741824) 'GB
                        Return FormatNumber(CDbl(BytesCaller / 1073741824), decplaces) & IIf(JustDigits, "", " GB").ToString
                    Case 1048576 To 1073741823
                        ' DoubleBytes = CDbl(BytesCaller / 1048576) 'MB
                        Return FormatNumber(CDbl(BytesCaller / 1048576), decplaces) & IIf(JustDigits, "", " MB").ToString
                    Case 1024 To 1048575
                        '  DoubleBytes = CDbl(BytesCaller / 1024) 'KB
                        Return FormatNumber(CDbl(BytesCaller / 1024), decplaces) & IIf(JustDigits, "", " KB").ToString
                    Case 0 To 1023
                        '  DoubleBytes = BytesCaller ' bytes
                        Return FormatNumber(BytesCaller, decplaces) & IIf(JustDigits, "", " bytes").ToString
                    Case Else
                        Return ""
                End Select
            Catch
                Return ""
            End Try
        End Get
        Set(value As String)

        End Set
    End Property
    Public Property FormatBytesAs(ByVal FormatAs As String, ByVal BytesCaller As ULong, ByVal decplaces As Int32, ByVal JustDigits As Boolean) As String
        'This returns filesize formated as a specific type like Megabtye or Kilobytes
        Get
            Try
                Select Case FormatAs.Trim.ToUpper
                    Case "TB"
                        ' DoubleBytes = CDbl(BytesCaller / 1099511627776) 'TB
                        Return FormatNumber(CDbl(BytesCaller / 1099511627776), decplaces) & IIf(JustDigits, "", " TB").ToString
                    Case "GB"
                        ' DoubleBytes = CDbl(BytesCaller / 1073741824) 'GB
                        Return FormatNumber(CDbl(BytesCaller / 1073741824), decplaces) & IIf(JustDigits, "", " GB").ToString
                    Case "MB"
                        ' DoubleBytes = CDbl(BytesCaller / 1048576) 'MB
                        Return FormatNumber(CDbl(BytesCaller / 1048576), decplaces) & IIf(JustDigits, "", " MB").ToString
                    Case "KB"
                        '  DoubleBytes = CDbl(BytesCaller / 1024) 'KB
                        Return FormatNumber(CDbl(BytesCaller / 1024), decplaces) & IIf(JustDigits, "", " KB").ToString
                    Case "BYTES"
                        '  DoubleBytes = BytesCaller ' bytes
                        Return FormatNumber(BytesCaller, decplaces) & IIf(JustDigits, "", " bytes").ToString
                    Case Else
                        Return ""
                End Select
            Catch
                Return ""
            End Try
        End Get
        Set(value As String)

        End Set
    End Property
End Module
