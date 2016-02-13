<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container
        Me.TT = New System.Windows.Forms.ToolTip(Me.components)
        Me.check = New System.Windows.Forms.Button
        Me.Status = New System.Windows.Forms.StatusStrip
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.mainMenu = New System.Windows.Forms.MenuStrip
        Me.menuGame = New System.Windows.Forms.ToolStripMenuItem
        Me.menuNewGame = New System.Windows.Forms.ToolStripMenuItem
        Me.menuExit = New System.Windows.Forms.ToolStripMenuItem
        Me.menuOptions = New System.Windows.Forms.ToolStripMenuItem
        Me.menuOperation = New System.Windows.Forms.ToolStripMenuItem
        Me.menuAddition = New System.Windows.Forms.ToolStripMenuItem
        Me.menuSubtraction = New System.Windows.Forms.ToolStripMenuItem
        Me.menuMultiplication = New System.Windows.Forms.ToolStripMenuItem
        Me.menuDivision = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.menuOpAS = New System.Windows.Forms.ToolStripMenuItem
        Me.menuOpMD = New System.Windows.Forms.ToolStripMenuItem
        Me.menuAll = New System.Windows.Forms.ToolStripMenuItem
        Me.menuRange = New System.Windows.Forms.ToolStripMenuItem
        Me.range15 = New System.Windows.Forms.ToolStripMenuItem
        Me.range19 = New System.Windows.Forms.ToolStripMenuItem
        Me.range110 = New System.Windows.Forms.ToolStripMenuItem
        Me.range125 = New System.Windows.Forms.ToolStripMenuItem
        Me.range1000 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.rangeCustom = New System.Windows.Forms.ToolStripTextBox
        Me.menuTimer = New System.Windows.Forms.ToolStripMenuItem
        Me.timerTimer = New System.Windows.Forms.ToolStripTextBox
        Me.SetNumProbs = New System.Windows.Forms.ToolStripMenuItem
        Me.set5 = New System.Windows.Forms.ToolStripMenuItem
        Me.set10 = New System.Windows.Forms.ToolStripMenuItem
        Me.set25 = New System.Windows.Forms.ToolStripMenuItem
        Me.set100 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.setCustom = New System.Windows.Forms.ToolStripTextBox
        Me.menuView = New System.Windows.Forms.ToolStripMenuItem
        Me.viewToolbars = New System.Windows.Forms.ToolStripMenuItem
        Me.viewOperation = New System.Windows.Forms.ToolStripMenuItem
        Me.viewStatistics = New System.Windows.Forms.ToolStripMenuItem
        Me.menuAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.aboutAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.aboutTerms = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.Problems = New System.Windows.Forms.TableLayoutPanel
        Me.prob1 = New System.Windows.Forms.Label
        Me.prob2 = New System.Windows.Forms.Label
        Me.prob5 = New System.Windows.Forms.Label
        Me.prob3 = New System.Windows.Forms.Label
        Me.prob4 = New System.Windows.Forms.Label
        Me.UserInteraction = New System.Windows.Forms.TableLayoutPanel
        Me.answer = New System.Windows.Forms.TextBox
        Me.statisticsToolbar = New System.Windows.Forms.ToolStrip
        Me.RightWrong = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.Percent = New System.Windows.Forms.ToolStripLabel
        Me.toolbarScore = New System.Windows.Forms.ToolStripLabel
        Me.toolbarSeperatorTimer = New System.Windows.Forms.ToolStripSeparator
        Me.toolbarTime = New System.Windows.Forms.ToolStripLabel
        Me.toolbarProbsLeft = New System.Windows.Forms.ToolStripLabel
        Me.informationToolbar = New System.Windows.Forms.ToolStrip
        Me.toolbarOp = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.toolbarOptions = New System.Windows.Forms.ToolStripLabel
        Me.ContMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Countdown = New System.Windows.Forms.Timer(Me.components)
        Me.Status.SuspendLayout()
        Me.mainMenu.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.Problems.SuspendLayout()
        Me.UserInteraction.SuspendLayout()
        Me.statisticsToolbar.SuspendLayout()
        Me.informationToolbar.SuspendLayout()
        Me.SuspendLayout()
        '
        'TT
        '
        Me.TT.AutoPopDelay = 5000
        Me.TT.InitialDelay = 250
        Me.TT.ReshowDelay = 100
        '
        'check
        '
        Me.check.Location = New System.Drawing.Point(98, 3)
        Me.check.Name = "check"
        Me.check.Size = New System.Drawing.Size(54, 26)
        Me.check.TabIndex = 7
        Me.check.Text = "Chec&k"
        Me.TT.SetToolTip(Me.check, "Click or press enter to check your answer.")
        Me.check.UseVisualStyleBackColor = True
        '
        'Status
        '
        Me.Status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        Me.Status.Location = New System.Drawing.Point(0, 180)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(384, 22)
        Me.Status.TabIndex = 0
        Me.Status.Text = "StatusBar"
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(32, 17)
        Me.StatusLabel.Text = "Status"
        '
        'mainMenu
        '
        Me.mainMenu.Dock = System.Windows.Forms.DockStyle.None
        Me.mainMenu.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuGame, Me.menuOptions, Me.menuView, Me.menuAbout})
        Me.mainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mainMenu.Name = "mainMenu"
        Me.mainMenu.Size = New System.Drawing.Size(384, 26)
        Me.mainMenu.TabIndex = 1
        Me.mainMenu.Text = "Menu"
        '
        'menuGame
        '
        Me.menuGame.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuNewGame, Me.menuExit})
        Me.menuGame.Name = "menuGame"
        Me.menuGame.Size = New System.Drawing.Size(52, 22)
        Me.menuGame.Text = "&Game"
        '
        'menuNewGame
        '
        Me.menuNewGame.Name = "menuNewGame"
        Me.menuNewGame.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.menuNewGame.Size = New System.Drawing.Size(186, 22)
        Me.menuNewGame.Text = "&New Game"
        '
        'menuExit
        '
        Me.menuExit.Name = "menuExit"
        Me.menuExit.ShortcutKeyDisplayString = "Alt+F4"
        Me.menuExit.Size = New System.Drawing.Size(186, 22)
        Me.menuExit.Text = "E&xit"
        '
        'menuOptions
        '
        Me.menuOptions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuOperation, Me.menuRange, Me.menuTimer, Me.SetNumProbs})
        Me.menuOptions.Name = "menuOptions"
        Me.menuOptions.Size = New System.Drawing.Size(66, 22)
        Me.menuOptions.Text = "&Options"
        '
        'menuOperation
        '
        Me.menuOperation.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuAddition, Me.menuSubtraction, Me.menuMultiplication, Me.menuDivision, Me.ToolStripSeparator2, Me.menuOpAS, Me.menuOpMD, Me.menuAll})
        Me.menuOperation.Name = "menuOperation"
        Me.menuOperation.Size = New System.Drawing.Size(188, 22)
        Me.menuOperation.Text = "&Operation"
        '
        'menuAddition
        '
        Me.menuAddition.Name = "menuAddition"
        Me.menuAddition.Size = New System.Drawing.Size(236, 22)
        Me.menuAddition.Text = "&Addition"
        '
        'menuSubtraction
        '
        Me.menuSubtraction.Name = "menuSubtraction"
        Me.menuSubtraction.Size = New System.Drawing.Size(236, 22)
        Me.menuSubtraction.Text = "&Subtraction"
        '
        'menuMultiplication
        '
        Me.menuMultiplication.Name = "menuMultiplication"
        Me.menuMultiplication.Size = New System.Drawing.Size(236, 22)
        Me.menuMultiplication.Text = "&Multiplication"
        '
        'menuDivision
        '
        Me.menuDivision.Name = "menuDivision"
        Me.menuDivision.Size = New System.Drawing.Size(236, 22)
        Me.menuDivision.Text = "&Division"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(233, 6)
        '
        'menuOpAS
        '
        Me.menuOpAS.Name = "menuOpAS"
        Me.menuOpAS.Size = New System.Drawing.Size(236, 22)
        Me.menuOpAS.Text = "Add&ition and Subtraction"
        '
        'menuOpMD
        '
        Me.menuOpMD.Name = "menuOpMD"
        Me.menuOpMD.Size = New System.Drawing.Size(236, 22)
        Me.menuOpMD.Text = "Multiplic&ation and Division"
        '
        'menuAll
        '
        Me.menuAll.Name = "menuAll"
        Me.menuAll.Size = New System.Drawing.Size(236, 22)
        Me.menuAll.Text = "All"
        '
        'menuRange
        '
        Me.menuRange.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.range15, Me.range19, Me.range110, Me.range125, Me.range1000, Me.ToolStripSeparator1, Me.rangeCustom})
        Me.menuRange.Name = "menuRange"
        Me.menuRange.Size = New System.Drawing.Size(188, 22)
        Me.menuRange.Text = "&Range"
        '
        'range15
        '
        Me.range15.Name = "range15"
        Me.range15.Size = New System.Drawing.Size(160, 22)
        Me.range15.Text = "Up to 5"
        '
        'range19
        '
        Me.range19.Name = "range19"
        Me.range19.Size = New System.Drawing.Size(160, 22)
        Me.range19.Text = "Up to 9"
        '
        'range110
        '
        Me.range110.Name = "range110"
        Me.range110.Size = New System.Drawing.Size(160, 22)
        Me.range110.Text = "Up to 10"
        '
        'range125
        '
        Me.range125.Name = "range125"
        Me.range125.Size = New System.Drawing.Size(160, 22)
        Me.range125.Text = "Up to 25"
        '
        'range1000
        '
        Me.range1000.Name = "range1000"
        Me.range1000.Size = New System.Drawing.Size(160, 22)
        Me.range1000.Text = "Up to 100"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(157, 6)
        '
        'rangeCustom
        '
        Me.rangeCustom.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rangeCustom.Name = "rangeCustom"
        Me.rangeCustom.Size = New System.Drawing.Size(100, 24)
        '
        'menuTimer
        '
        Me.menuTimer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.timerTimer})
        Me.menuTimer.Name = "menuTimer"
        Me.menuTimer.Size = New System.Drawing.Size(188, 22)
        Me.menuTimer.Text = "&Timer"
        '
        'timerTimer
        '
        Me.timerTimer.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timerTimer.Name = "timerTimer"
        Me.timerTimer.Size = New System.Drawing.Size(100, 26)
        '
        'SetNumProbs
        '
        Me.SetNumProbs.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.set5, Me.set10, Me.set25, Me.set100, Me.ToolStripSeparator3, Me.setCustom})
        Me.SetNumProbs.Name = "SetNumProbs"
        Me.SetNumProbs.Size = New System.Drawing.Size(188, 22)
        Me.SetNumProbs.Text = "Set # of &Problems"
        '
        'set5
        '
        Me.set5.Name = "set5"
        Me.set5.Size = New System.Drawing.Size(160, 22)
        Me.set5.Text = "&5"
        '
        'set10
        '
        Me.set10.Name = "set10"
        Me.set10.Size = New System.Drawing.Size(160, 22)
        Me.set10.Text = "&10"
        '
        'set25
        '
        Me.set25.Name = "set25"
        Me.set25.Size = New System.Drawing.Size(160, 22)
        Me.set25.Text = "&25"
        '
        'set100
        '
        Me.set100.Name = "set100"
        Me.set100.Size = New System.Drawing.Size(160, 22)
        Me.set100.Text = "1&00"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(157, 6)
        '
        'setCustom
        '
        Me.setCustom.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.setCustom.Name = "setCustom"
        Me.setCustom.Size = New System.Drawing.Size(100, 26)
        '
        'menuView
        '
        Me.menuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.viewToolbars})
        Me.menuView.Name = "menuView"
        Me.menuView.Size = New System.Drawing.Size(49, 22)
        Me.menuView.Text = "&View"
        '
        'viewToolbars
        '
        Me.viewToolbars.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.viewOperation, Me.viewStatistics})
        Me.viewToolbars.Name = "viewToolbars"
        Me.viewToolbars.Size = New System.Drawing.Size(130, 22)
        Me.viewToolbars.Text = "&Toolbars"
        '
        'viewOperation
        '
        Me.viewOperation.Checked = True
        Me.viewOperation.CheckState = System.Windows.Forms.CheckState.Checked
        Me.viewOperation.Name = "viewOperation"
        Me.viewOperation.Size = New System.Drawing.Size(136, 22)
        Me.viewOperation.Text = "&Operation"
        '
        'viewStatistics
        '
        Me.viewStatistics.Checked = True
        Me.viewStatistics.CheckState = System.Windows.Forms.CheckState.Checked
        Me.viewStatistics.Name = "viewStatistics"
        Me.viewStatistics.Size = New System.Drawing.Size(136, 22)
        Me.viewStatistics.Text = "&Statistics"
        '
        'menuAbout
        '
        Me.menuAbout.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.aboutAbout, Me.aboutTerms})
        Me.menuAbout.Name = "menuAbout"
        Me.menuAbout.Size = New System.Drawing.Size(56, 22)
        Me.menuAbout.Text = "&About"
        '
        'aboutAbout
        '
        Me.aboutAbout.Name = "aboutAbout"
        Me.aboutAbout.Size = New System.Drawing.Size(204, 22)
        Me.aboutAbout.Text = "About This Program..."
        '
        'aboutTerms
        '
        Me.aboutTerms.Name = "aboutTerms"
        Me.aboutTerms.Size = New System.Drawing.Size(204, 22)
        Me.aboutTerms.Text = "Terms of Use"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Problems)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.UserInteraction)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Status)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(384, 202)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(384, 278)
        Me.ToolStripContainer1.TabIndex = 2
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.mainMenu)
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.statisticsToolbar)
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.informationToolbar)
        '
        'Problems
        '
        Me.Problems.ColumnCount = 1
        Me.Problems.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Problems.Controls.Add(Me.prob1, 0, 0)
        Me.Problems.Controls.Add(Me.prob2, 0, 1)
        Me.Problems.Controls.Add(Me.prob5, 0, 4)
        Me.Problems.Controls.Add(Me.prob3, 0, 2)
        Me.Problems.Controls.Add(Me.prob4, 0, 3)
        Me.Problems.Location = New System.Drawing.Point(12, 7)
        Me.Problems.Name = "Problems"
        Me.Problems.RowCount = 5
        Me.Problems.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.62069!))
        Me.Problems.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.37931!))
        Me.Problems.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.Problems.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.Problems.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.Problems.Size = New System.Drawing.Size(211, 138)
        Me.Problems.TabIndex = 9
        '
        'prob1
        '
        Me.prob1.AutoSize = True
        Me.prob1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prob1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.prob1.Location = New System.Drawing.Point(3, 0)
        Me.prob1.Name = "prob1"
        Me.prob1.Size = New System.Drawing.Size(52, 23)
        Me.prob1.TabIndex = 1
        Me.prob1.Text = "prob1"
        Me.prob1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'prob2
        '
        Me.prob2.AutoSize = True
        Me.prob2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prob2.Location = New System.Drawing.Point(3, 34)
        Me.prob2.Name = "prob2"
        Me.prob2.Size = New System.Drawing.Size(55, 23)
        Me.prob2.TabIndex = 2
        Me.prob2.Text = "prob2"
        Me.prob2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'prob5
        '
        Me.prob5.AutoSize = True
        Me.prob5.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prob5.Location = New System.Drawing.Point(3, 104)
        Me.prob5.Name = "prob5"
        Me.prob5.Size = New System.Drawing.Size(55, 23)
        Me.prob5.TabIndex = 5
        Me.prob5.Text = "prob5"
        Me.prob5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'prob3
        '
        Me.prob3.AutoSize = True
        Me.prob3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prob3.Location = New System.Drawing.Point(3, 58)
        Me.prob3.Name = "prob3"
        Me.prob3.Size = New System.Drawing.Size(55, 23)
        Me.prob3.TabIndex = 3
        Me.prob3.Text = "prob3"
        Me.prob3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'prob4
        '
        Me.prob4.AutoSize = True
        Me.prob4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prob4.Location = New System.Drawing.Point(3, 81)
        Me.prob4.Name = "prob4"
        Me.prob4.Size = New System.Drawing.Size(55, 23)
        Me.prob4.TabIndex = 4
        Me.prob4.Text = "prob4"
        Me.prob4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'UserInteraction
        '
        Me.UserInteraction.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserInteraction.ColumnCount = 2
        Me.UserInteraction.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.90476!))
        Me.UserInteraction.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.09524!))
        Me.UserInteraction.Controls.Add(Me.answer, 0, 0)
        Me.UserInteraction.Controls.Add(Me.check, 1, 0)
        Me.UserInteraction.Location = New System.Drawing.Point(229, 7)
        Me.UserInteraction.Name = "UserInteraction"
        Me.UserInteraction.RowCount = 1
        Me.UserInteraction.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.UserInteraction.Size = New System.Drawing.Size(155, 34)
        Me.UserInteraction.TabIndex = 8
        '
        'answer
        '
        Me.answer.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answer.Location = New System.Drawing.Point(3, 3)
        Me.answer.Name = "answer"
        Me.answer.Size = New System.Drawing.Size(84, 26)
        Me.answer.TabIndex = 6
        '
        'statisticsToolbar
        '
        Me.statisticsToolbar.Dock = System.Windows.Forms.DockStyle.None
        Me.statisticsToolbar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statisticsToolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RightWrong, Me.ToolStripSeparator5, Me.Percent, Me.toolbarScore, Me.toolbarSeperatorTimer, Me.toolbarTime, Me.toolbarProbsLeft})
        Me.statisticsToolbar.Location = New System.Drawing.Point(3, 26)
        Me.statisticsToolbar.Name = "statisticsToolbar"
        Me.statisticsToolbar.Size = New System.Drawing.Size(258, 25)
        Me.statisticsToolbar.TabIndex = 0
        '
        'RightWrong
        '
        Me.RightWrong.Name = "RightWrong"
        Me.RightWrong.Size = New System.Drawing.Size(79, 22)
        Me.RightWrong.Text = "RightWrong"
        Me.RightWrong.ToolTipText = "How many you got right and wrong"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'Percent
        '
        Me.Percent.Name = "Percent"
        Me.Percent.Size = New System.Drawing.Size(19, 22)
        Me.Percent.Text = "%"
        Me.Percent.ToolTipText = "Your current percentage"
        '
        'toolbarScore
        '
        Me.toolbarScore.Name = "toolbarScore"
        Me.toolbarScore.Size = New System.Drawing.Size(29, 22)
        Me.toolbarScore.Text = "pts."
        '
        'toolbarSeperatorTimer
        '
        Me.toolbarSeperatorTimer.Name = "toolbarSeperatorTimer"
        Me.toolbarSeperatorTimer.Size = New System.Drawing.Size(6, 25)
        '
        'toolbarTime
        '
        Me.toolbarTime.Name = "toolbarTime"
        Me.toolbarTime.Size = New System.Drawing.Size(39, 22)
        Me.toolbarTime.Text = "timer"
        Me.toolbarTime.ToolTipText = "Your time left"
        '
        'toolbarProbsLeft
        '
        Me.toolbarProbsLeft.Name = "toolbarProbsLeft"
        Me.toolbarProbsLeft.Size = New System.Drawing.Size(68, 22)
        Me.toolbarProbsLeft.Text = "probsLeft"
        '
        'informationToolbar
        '
        Me.informationToolbar.Dock = System.Windows.Forms.DockStyle.None
        Me.informationToolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolbarOp, Me.ToolStripSeparator6, Me.toolbarOptions})
        Me.informationToolbar.Location = New System.Drawing.Point(3, 51)
        Me.informationToolbar.Name = "informationToolbar"
        Me.informationToolbar.Size = New System.Drawing.Size(140, 25)
        Me.informationToolbar.TabIndex = 2
        '
        'toolbarOp
        '
        Me.toolbarOp.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolbarOp.Name = "toolbarOp"
        Me.toolbarOp.Size = New System.Drawing.Size(68, 22)
        Me.toolbarOp.Text = "Operation"
        Me.toolbarOp.ToolTipText = "The operation"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'toolbarOptions
        '
        Me.toolbarOptions.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolbarOptions.Name = "toolbarOptions"
        Me.toolbarOptions.Size = New System.Drawing.Size(54, 22)
        Me.toolbarOptions.Text = "Options"
        Me.toolbarOptions.ToolTipText = "Options you selected"
        '
        'ContMenu
        '
        Me.ContMenu.Name = "ContextMenuStrip1"
        Me.ContMenu.Size = New System.Drawing.Size(61, 4)
        '
        'Countdown
        '
        Me.Countdown.Interval = 1000
        '
        'Main
        '
        Me.AcceptButton = Me.check
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 278)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.MainMenuStrip = Me.mainMenu
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Title"
        Me.Status.ResumeLayout(False)
        Me.Status.PerformLayout()
        Me.mainMenu.ResumeLayout(False)
        Me.mainMenu.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.Problems.ResumeLayout(False)
        Me.Problems.PerformLayout()
        Me.UserInteraction.ResumeLayout(False)
        Me.UserInteraction.PerformLayout()
        Me.statisticsToolbar.ResumeLayout(False)
        Me.statisticsToolbar.PerformLayout()
        Me.informationToolbar.ResumeLayout(False)
        Me.informationToolbar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TT As System.Windows.Forms.ToolTip
    Friend WithEvents Status As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents menuGame As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuNewGame As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuOperation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuRange As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuTimer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetNumProbs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAddition As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuSubtraction As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuMultiplication As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuDivision As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents range15 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents range110 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents range125 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents range1000 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rangeCustom As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents setCustom As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuOpAS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuOpMD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents range19 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents timerTimer As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents set5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents set10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents set25 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents set100 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents aboutAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents aboutTerms As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ContMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents statisticsToolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents RightWrong As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Percent As System.Windows.Forms.ToolStripLabel
    Friend WithEvents prob5 As System.Windows.Forms.Label
    Friend WithEvents prob4 As System.Windows.Forms.Label
    Friend WithEvents prob3 As System.Windows.Forms.Label
    Friend WithEvents prob2 As System.Windows.Forms.Label
    Friend WithEvents prob1 As System.Windows.Forms.Label
    Friend WithEvents menuView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents viewToolbars As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents viewStatistics As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents check As System.Windows.Forms.Button
    Friend WithEvents viewOperation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents informationToolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents toolbarOp As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Countdown As System.Windows.Forms.Timer
    Friend WithEvents toolbarTime As System.Windows.Forms.ToolStripLabel
    Friend WithEvents toolbarSeperatorTimer As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolbarOptions As System.Windows.Forms.ToolStripLabel
    Friend WithEvents toolbarProbsLeft As System.Windows.Forms.ToolStripLabel
    Friend WithEvents toolbarScore As System.Windows.Forms.ToolStripLabel
    Friend WithEvents UserInteraction As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents answer As System.Windows.Forms.TextBox
    Friend WithEvents Problems As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents menuAll As System.Windows.Forms.ToolStripMenuItem

End Class
