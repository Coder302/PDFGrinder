Public Class ProgressForm
    Public Delegate Sub FunctionToRunPDelegate(ByRef pf As ProgressForm)
    Public Cancelled As Boolean = False
    Public AskingToCancel As Boolean = False
    Public ProcessIT As FunctionToRunPDelegate

    Public Sub New(ByRef FunctionToRun As FunctionToRunPDelegate)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ProcessIT = FunctionToRun
    End Sub

    Private Sub ProgressForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgFiles.Text = String.Format("{2}%  Files {0}/{1}", Infragistics.Win.UltraWinProgressBar.UltraProgressBar.LABEL_VALUE, Infragistics.Win.UltraWinProgressBar.UltraProgressBar.LABEL_MAXIMUM, Infragistics.Win.UltraWinProgressBar.UltraProgressBar.LABEL_PERCENT_COMPLETED)
        ProgPages.Text = String.Format("{2}%  Pages {0}/{1}", Infragistics.Win.UltraWinProgressBar.UltraProgressBar.LABEL_VALUE, Infragistics.Win.UltraWinProgressBar.UltraProgressBar.LABEL_MAXIMUM, Infragistics.Win.UltraWinProgressBar.UltraProgressBar.LABEL_PERCENT_COMPLETED)
        ' ProgSize.Text = String.Format("{2}% Size {0}/{1}", Infragistics.Win.UltraWinProgressBar.UltraProgressBar.LABEL_VALUE, Infragistics.Win.UltraWinProgressBar.UltraProgressBar.LABEL_MAXIMUM, Infragistics.Win.UltraWinProgressBar.UltraProgressBar.LABEL_PERCENT_COMPLETED)

    End Sub

    Private Sub ProgressForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ' Use a Delegate to run on funtion mainform
        ' Dim ProcessIt As ProcMDBAsyncPDelegate
        ' ProcessIT = AddressOf CType(Me.Owner, Mainform).ProcMDBAsync

        ProcessIT.Invoke(Me)
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        AskingToCancel = True
        'If MsgBox("Are You Sure You Want To Stop Processing?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Notice") = MsgBoxResult.Yes Then
        '    Cancelled = True
        '    ' Me.Close()
        'End If
    End Sub

End Class