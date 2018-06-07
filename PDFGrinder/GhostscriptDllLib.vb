Option Explicit On
Imports System.Runtime.InteropServices

'--- Simple VB.Net wrapper for Ghostscript gsdll32.dll

'    (Tested using Visual Studio 2010 and Ghostscript 9.06)

Module GhostscriptDllLib

    Private Declare Function gsapi_new_instance Lib "gsdll32.dll" _
      (ByRef instance As IntPtr,
      ByVal caller_handle As IntPtr) As Integer

    Private Declare Function gsapi_set_stdio Lib "gsdll32.dll" _
      (ByVal instance As IntPtr,
      ByVal gsdll_stdin As StdIOCallBack,
      ByVal gsdll_stdout As StdIOCallBack,
      ByVal gsdll_stderr As StdIOCallBack) As Integer

    Private Declare Function gsapi_init_with_args Lib "gsdll32.dll" _
      (ByVal instance As IntPtr,
      ByVal argc As Integer,
      <MarshalAs(UnmanagedType.LPArray, ArraySubType:=UnmanagedType.LPStr)>
      ByVal argv() As String) As Integer

    Private Declare Function gsapi_exit Lib "gsdll32.dll" _
      (ByVal instance As IntPtr) As Integer

    Private Declare Sub gsapi_delete_instance Lib "gsdll32.dll" _
      (ByVal instance As IntPtr)

    '--- Run Ghostscript with specified arguments

    Public Function RunGS(ByVal ParamArray Args() As String) As Boolean

        Dim InstanceHndl As IntPtr
        Dim NumArgs As Integer
        Dim StdErrCallback As StdIOCallBack
        Dim StdInCallback As StdIOCallBack
        Dim StdOutCallback As StdIOCallBack

        NumArgs = Args.Count

        StdInCallback = AddressOf InOutErrCallBack
        StdOutCallback = AddressOf InOutErrCallBack
        StdErrCallback = AddressOf InOutErrCallBack

        '--- Shift arguments to begin at index 1 (Ghostscript requirement)

        ReDim Preserve Args(NumArgs)
        System.Array.Copy(Args, 0, Args, 1, NumArgs)

        '--- Start a new Ghostscript instance
        'Craig Changed 0 to nothing for the second parameter below
        Dim xx As New IntPtr
        If gsapi_new_instance(InstanceHndl, xx) <> 0 Then
            Return False
            Exit Function
        End If

        '--- Set up dummy callbacks
        Dim craig As Int32
        craig = gsapi_set_stdio(InstanceHndl, StdInCallback, StdOutCallback, StdErrCallback)

        '--- Run Ghostscript using specified arguments
        ' Dim craig As Int32
        craig = gsapi_init_with_args(InstanceHndl, NumArgs + 1, Args)

        '--- Exit Ghostscript

        gsapi_exit(InstanceHndl)

        '--- Delete instance

        gsapi_delete_instance(InstanceHndl)

        Return True

    End Function

    '--- Delegate function for callbacks

    Private Delegate Function StdIOCallBack(ByVal handle As IntPtr,
      ByVal Strz As IntPtr, ByVal Bytes As Integer) As Integer

    '--- Dummy callback for standard input, standard output, and errors

    Private Function InOutErrCallBack(ByVal handle As IntPtr,
      ByVal Strz As IntPtr, ByVal Bytes As Integer) As Integer

        Return 0

    End Function

End Module