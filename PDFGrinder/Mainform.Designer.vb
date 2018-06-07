<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainform
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
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mainform))
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.chkPgCnt = New System.Windows.Forms.CheckBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.bgPages = New System.ComponentModel.BackgroundWorker()
        Me.bgProcFiles = New System.ComponentModel.BackgroundWorker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboDPI = New System.Windows.Forms.ComboBox()
        Me.cboPagePattern = New System.Windows.Forms.ComboBox()
        Me.radSingle = New System.Windows.Forms.RadioButton()
        Me.radMult = New System.Windows.Forms.RadioButton()
        Me.chkIncludeSubs = New System.Windows.Forms.CheckBox()
        Me.AIPageCnt = New Infragistics.Win.UltraActivityIndicator.UltraActivityIndicator()
        Me.chkOutputDiffFolder = New System.Windows.Forms.CheckBox()
        Me.txtDest = New System.Windows.Forms.TextBox()
        Me.radProcAll = New System.Windows.Forms.RadioButton()
        Me.radProcSel = New System.Windows.Forms.RadioButton()
        Me.Tips = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnBrowSrc = New System.Windows.Forms.Button()
        Me.cboSrcDir = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ugFiles = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ugList = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboDownScaleFactor = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.ugFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.ugList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(570, 24)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(78, 28)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'chkPgCnt
        '
        Me.chkPgCnt.AutoSize = True
        Me.chkPgCnt.Checked = True
        Me.chkPgCnt.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPgCnt.Location = New System.Drawing.Point(951, 25)
        Me.chkPgCnt.Name = "chkPgCnt"
        Me.chkPgCnt.Size = New System.Drawing.Size(100, 21)
        Me.chkPgCnt.TabIndex = 3
        Me.chkPgCnt.Text = "PageCount"
        Me.chkPgCnt.UseVisualStyleBackColor = True
        Me.chkPgCnt.Visible = False
        '
        'btnConvert
        '
        Me.btnConvert.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConvert.Location = New System.Drawing.Point(782, 565)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(143, 32)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'bgPages
        '
        Me.bgPages.WorkerReportsProgress = True
        Me.bgPages.WorkerSupportsCancellation = True
        '
        'bgProcFiles
        '
        Me.bgProcFiles.WorkerReportsProgress = True
        Me.bgProcFiles.WorkerSupportsCancellation = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Source Directory"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cboDownScaleFactor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboDPI)
        Me.GroupBox1.Controls.Add(Me.cboPagePattern)
        Me.GroupBox1.Controls.Add(Me.radSingle)
        Me.GroupBox1.Controls.Add(Me.radMult)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 465)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(405, 123)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Output"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(205, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "DPI"
        '
        'cboDPI
        '
        Me.cboDPI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDPI.FormattingEnabled = True
        Me.cboDPI.Items.AddRange(New Object() {"200", "300", "600", "900"})
        Me.cboDPI.Location = New System.Drawing.Point(241, 16)
        Me.cboDPI.Name = "cboDPI"
        Me.cboDPI.Size = New System.Drawing.Size(121, 24)
        Me.cboDPI.TabIndex = 3
        '
        'cboPagePattern
        '
        Me.cboPagePattern.FormattingEnabled = True
        Me.cboPagePattern.Items.AddRange(New Object() {"%04d", "_%04d", "p%04d", "_p%04d"})
        Me.cboPagePattern.Location = New System.Drawing.Point(162, 46)
        Me.cboPagePattern.Name = "cboPagePattern"
        Me.cboPagePattern.Size = New System.Drawing.Size(121, 24)
        Me.cboPagePattern.TabIndex = 2
        Me.cboPagePattern.Text = "_p%04d"
        Me.Tips.SetToolTip(Me.cboPagePattern, "Format Filename For Single Pages")
        '
        'radSingle
        '
        Me.radSingle.AutoSize = True
        Me.radSingle.Checked = True
        Me.radSingle.Location = New System.Drawing.Point(22, 49)
        Me.radSingle.Name = "radSingle"
        Me.radSingle.Size = New System.Drawing.Size(125, 21)
        Me.radSingle.TabIndex = 1
        Me.radSingle.TabStop = True
        Me.radSingle.Text = "Single Page Tif"
        Me.radSingle.UseVisualStyleBackColor = True
        '
        'radMult
        '
        Me.radMult.AutoSize = True
        Me.radMult.Location = New System.Drawing.Point(22, 22)
        Me.radMult.Name = "radMult"
        Me.radMult.Size = New System.Drawing.Size(107, 21)
        Me.radMult.TabIndex = 0
        Me.radMult.Text = "Mutipage Tif"
        Me.radMult.UseVisualStyleBackColor = True
        '
        'chkIncludeSubs
        '
        Me.chkIncludeSubs.AutoSize = True
        Me.chkIncludeSubs.Location = New System.Drawing.Point(664, 29)
        Me.chkIncludeSubs.Name = "chkIncludeSubs"
        Me.chkIncludeSubs.Size = New System.Drawing.Size(155, 21)
        Me.chkIncludeSubs.TabIndex = 9
        Me.chkIncludeSubs.Text = "Include Sub Folders"
        Me.Tips.SetToolTip(Me.chkIncludeSubs, "Include Files from Sub Folders")
        Me.chkIncludeSubs.UseVisualStyleBackColor = True
        '
        'AIPageCnt
        '
        Me.AIPageCnt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AIPageCnt.CausesValidation = True
        Me.AIPageCnt.Location = New System.Drawing.Point(875, 23)
        Me.AIPageCnt.Name = "AIPageCnt"
        Me.AIPageCnt.Size = New System.Drawing.Size(209, 23)
        Me.AIPageCnt.TabIndex = 10
        Me.AIPageCnt.TabStop = True
        Me.AIPageCnt.Text = "Counting Pages..."
        Me.AIPageCnt.Visible = False
        '
        'chkOutputDiffFolder
        '
        Me.chkOutputDiffFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkOutputDiffFolder.AutoSize = True
        Me.chkOutputDiffFolder.Location = New System.Drawing.Point(456, 510)
        Me.chkOutputDiffFolder.Name = "chkOutputDiffFolder"
        Me.chkOutputDiffFolder.Size = New System.Drawing.Size(191, 21)
        Me.chkOutputDiffFolder.TabIndex = 11
        Me.chkOutputDiffFolder.Text = "Output to Different Folder"
        Me.chkOutputDiffFolder.UseVisualStyleBackColor = True
        '
        'txtDest
        '
        Me.txtDest.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDest.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtDest.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories
        Me.txtDest.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.PDFGrinder.My.MySettings.Default, "DstDir", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtDest.Location = New System.Drawing.Point(469, 532)
        Me.txtDest.Name = "txtDest"
        Me.txtDest.Size = New System.Drawing.Size(541, 22)
        Me.txtDest.TabIndex = 12
        Me.txtDest.Text = Global.PDFGrinder.My.MySettings.Default.DstDir
        '
        'radProcAll
        '
        Me.radProcAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radProcAll.AutoSize = True
        Me.radProcAll.Checked = True
        Me.radProcAll.Location = New System.Drawing.Point(469, 566)
        Me.radProcAll.Name = "radProcAll"
        Me.radProcAll.Size = New System.Drawing.Size(128, 21)
        Me.radProcAll.TabIndex = 13
        Me.radProcAll.TabStop = True
        Me.radProcAll.Text = "Process All files"
        Me.radProcAll.UseVisualStyleBackColor = True
        '
        'radProcSel
        '
        Me.radProcSel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radProcSel.AutoSize = True
        Me.radProcSel.Location = New System.Drawing.Point(603, 567)
        Me.radProcSel.Name = "radProcSel"
        Me.radProcSel.Size = New System.Drawing.Size(172, 21)
        Me.radProcSel.TabIndex = 14
        Me.radProcSel.Text = "Process Only Selected"
        Me.radProcSel.UseVisualStyleBackColor = True
        '
        'Tips
        '
        Me.Tips.IsBalloon = True
        '
        'btnBrowSrc
        '
        Me.btnBrowSrc.Location = New System.Drawing.Point(12, 1)
        Me.btnBrowSrc.Name = "btnBrowSrc"
        Me.btnBrowSrc.Size = New System.Drawing.Size(136, 26)
        Me.btnBrowSrc.TabIndex = 15
        Me.btnBrowSrc.Text = "Source Directory"
        Me.btnBrowSrc.UseVisualStyleBackColor = True
        '
        'cboSrcDir
        '
        Me.cboSrcDir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories
        Me.cboSrcDir.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.PDFGrinder.My.MySettings.Default, "SrcDir", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cboSrcDir.FormattingEnabled = True
        Me.cboSrcDir.Location = New System.Drawing.Point(12, 33)
        Me.cboSrcDir.Name = "cboSrcDir"
        Me.cboSrcDir.Size = New System.Drawing.Size(451, 24)
        Me.cboSrcDir.TabIndex = 16
        Me.cboSrcDir.Text = Global.PDFGrinder.My.MySettings.Default.SrcDir
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 76)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1075, 277)
        Me.TabControl1.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ugFiles)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1067, 248)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Current Directory"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ugFiles
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugFiles.DisplayLayout.Appearance = Appearance1
        Me.ugFiles.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.ugFiles.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.ugFiles.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugFiles.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.ugFiles.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugFiles.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.ugFiles.DisplayLayout.MaxColScrollRegions = 1
        Me.ugFiles.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ugFiles.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ugFiles.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.ugFiles.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ugFiles.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.ugFiles.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ugFiles.DisplayLayout.Override.CellAppearance = Appearance8
        Me.ugFiles.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.ugFiles.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.ugFiles.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.ugFiles.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.ugFiles.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.ugFiles.DisplayLayout.Override.RowAppearance = Appearance11
        Me.ugFiles.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ugFiles.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.ugFiles.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugFiles.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugFiles.Location = New System.Drawing.Point(3, 3)
        Me.ugFiles.Name = "ugFiles"
        Me.ugFiles.Size = New System.Drawing.Size(1061, 242)
        Me.ugFiles.TabIndex = 1
        Me.ugFiles.Text = "Files"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ugList)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1067, 248)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Process List"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ugList
        '
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugList.DisplayLayout.Appearance = Appearance13
        Me.ugList.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.ugList.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance14.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance14.BorderColor = System.Drawing.SystemColors.Window
        Me.ugList.DisplayLayout.GroupByBox.Appearance = Appearance14
        Appearance15.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugList.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance15
        Me.ugList.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance16.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance16.BackColor2 = System.Drawing.SystemColors.Control
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugList.DisplayLayout.GroupByBox.PromptAppearance = Appearance16
        Me.ugList.DisplayLayout.MaxColScrollRegions = 1
        Me.ugList.DisplayLayout.MaxRowScrollRegions = 1
        Appearance17.BackColor = System.Drawing.SystemColors.Window
        Appearance17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ugList.DisplayLayout.Override.ActiveCellAppearance = Appearance17
        Appearance18.BackColor = System.Drawing.SystemColors.Highlight
        Appearance18.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ugList.DisplayLayout.Override.ActiveRowAppearance = Appearance18
        Me.ugList.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ugList.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Me.ugList.DisplayLayout.Override.CardAreaAppearance = Appearance19
        Appearance20.BorderColor = System.Drawing.Color.Silver
        Appearance20.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ugList.DisplayLayout.Override.CellAppearance = Appearance20
        Me.ugList.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.ugList.DisplayLayout.Override.CellPadding = 0
        Appearance21.BackColor = System.Drawing.SystemColors.Control
        Appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance21.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance21.BorderColor = System.Drawing.SystemColors.Window
        Me.ugList.DisplayLayout.Override.GroupByRowAppearance = Appearance21
        Appearance22.TextHAlignAsString = "Left"
        Me.ugList.DisplayLayout.Override.HeaderAppearance = Appearance22
        Me.ugList.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Appearance23.BorderColor = System.Drawing.Color.Silver
        Me.ugList.DisplayLayout.Override.RowAppearance = Appearance23
        Me.ugList.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Appearance24.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ugList.DisplayLayout.Override.TemplateAddRowAppearance = Appearance24
        Me.ugList.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugList.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugList.Location = New System.Drawing.Point(3, 3)
        Me.ugList.Name = "ugList"
        Me.ugList.Size = New System.Drawing.Size(1061, 242)
        Me.ugList.TabIndex = 2
        Me.ugList.Text = "Files"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "DownScaleFactor"
        '
        'cboDownScaleFactor
        '
        Me.cboDownScaleFactor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDownScaleFactor.FormattingEnabled = True
        Me.cboDownScaleFactor.Items.AddRange(New Object() {"1 (Default)", "2", "3", "4", "5", "6", "7", "8"})
        Me.cboDownScaleFactor.Location = New System.Drawing.Point(162, 84)
        Me.cboDownScaleFactor.Name = "cboDownScaleFactor"
        Me.cboDownScaleFactor.Size = New System.Drawing.Size(121, 24)
        Me.cboDownScaleFactor.TabIndex = 6
        Me.Tips.SetToolTip(Me.cboDownScaleFactor, "-dDownScaleFactor=factor (small non-negative integer; default = 1) ")
        '
        'Mainform
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 609)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cboSrcDir)
        Me.Controls.Add(Me.btnBrowSrc)
        Me.Controls.Add(Me.radProcSel)
        Me.Controls.Add(Me.radProcAll)
        Me.Controls.Add(Me.txtDest)
        Me.Controls.Add(Me.chkOutputDiffFolder)
        Me.Controls.Add(Me.AIPageCnt)
        Me.Controls.Add(Me.chkIncludeSubs)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.chkPgCnt)
        Me.Controls.Add(Me.btnRefresh)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Mainform"
        Me.Text = "PDF Grinder"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.ugFiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.ugList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRefresh As Button
    Friend WithEvents chkPgCnt As CheckBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents bgPages As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgProcFiles As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboPagePattern As ComboBox
    Friend WithEvents radSingle As RadioButton
    Friend WithEvents radMult As RadioButton
    Friend WithEvents cboDPI As ComboBox
    Friend WithEvents chkIncludeSubs As CheckBox
    Friend WithEvents AIPageCnt As Infragistics.Win.UltraActivityIndicator.UltraActivityIndicator
    Friend WithEvents Label2 As Label
    Friend WithEvents chkOutputDiffFolder As CheckBox
    Friend WithEvents txtDest As TextBox
    Friend WithEvents radProcAll As RadioButton
    Friend WithEvents radProcSel As RadioButton
    Friend WithEvents Tips As ToolTip
    Friend WithEvents btnBrowSrc As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ugFiles As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ugList As Infragistics.Win.UltraWinGrid.UltraGrid
    Public WithEvents cboSrcDir As ComboBox
    Friend WithEvents cboDownScaleFactor As ComboBox
    Friend WithEvents Label3 As Label
End Class
