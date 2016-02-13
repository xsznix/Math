<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataPrompt
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.operation = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.rbtNone = New System.Windows.Forms.RadioButton
        Me.rbtTimer = New System.Windows.Forms.RadioButton
        Me.rbtSetProbs = New System.Windows.Forms.RadioButton
        Me.maximum = New System.Windows.Forms.NumericUpDown
        Me.numProbInput = New System.Windows.Forms.NumericUpDown
        Me.timerInput = New System.Windows.Forms.NumericUpDown
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.maximum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numProbInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.timerInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(237, 78)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Default"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Operation:"
        '
        'operation
        '
        Me.operation.FormattingEnabled = True
        Me.operation.Items.AddRange(New Object() {"Addition", "Subtraction", "Multiplication", "Division", "Addition and Subtraction", "Multiplication and Division", "All"})
        Me.operation.Location = New System.Drawing.Point(74, 9)
        Me.operation.Name = "operation"
        Me.operation.Size = New System.Drawing.Size(121, 21)
        Me.operation.TabIndex = 2
        Me.operation.Text = "Addition"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Maximum:"
        '
        'rbtNone
        '
        Me.rbtNone.AutoSize = True
        Me.rbtNone.Checked = True
        Me.rbtNone.Location = New System.Drawing.Point(201, 8)
        Me.rbtNone.Name = "rbtNone"
        Me.rbtNone.Size = New System.Drawing.Size(51, 17)
        Me.rbtNone.TabIndex = 5
        Me.rbtNone.TabStop = True
        Me.rbtNone.Text = "&None"
        Me.rbtNone.UseVisualStyleBackColor = True
        '
        'rbtTimer
        '
        Me.rbtTimer.AutoSize = True
        Me.rbtTimer.Location = New System.Drawing.Point(201, 31)
        Me.rbtTimer.Name = "rbtTimer"
        Me.rbtTimer.Size = New System.Drawing.Size(96, 17)
        Me.rbtTimer.TabIndex = 6
        Me.rbtTimer.Text = "&Timer (minutes)"
        Me.rbtTimer.UseVisualStyleBackColor = True
        '
        'rbtSetProbs
        '
        Me.rbtSetProbs.AutoSize = True
        Me.rbtSetProbs.Location = New System.Drawing.Point(201, 54)
        Me.rbtSetProbs.Name = "rbtSetProbs"
        Me.rbtSetProbs.Size = New System.Drawing.Size(112, 17)
        Me.rbtSetProbs.TabIndex = 7
        Me.rbtSetProbs.Text = "&Set # of Problems:"
        Me.rbtSetProbs.UseVisualStyleBackColor = True
        '
        'maximum
        '
        Me.maximum.Location = New System.Drawing.Point(74, 35)
        Me.maximum.Maximum = New Decimal(New Integer() {32627, 0, 0, 0})
        Me.maximum.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.maximum.Name = "maximum"
        Me.maximum.Size = New System.Drawing.Size(121, 20)
        Me.maximum.TabIndex = 8
        Me.maximum.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'numProbInput
        '
        Me.numProbInput.Location = New System.Drawing.Point(319, 54)
        Me.numProbInput.Maximum = New Decimal(New Integer() {32627, 0, 0, 0})
        Me.numProbInput.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numProbInput.Name = "numProbInput"
        Me.numProbInput.Size = New System.Drawing.Size(64, 20)
        Me.numProbInput.TabIndex = 9
        Me.numProbInput.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'timerInput
        '
        Me.timerInput.Location = New System.Drawing.Point(319, 31)
        Me.timerInput.Maximum = New Decimal(New Integer() {32627, 0, 0, 0})
        Me.timerInput.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.timerInput.Name = "timerInput"
        Me.timerInput.Size = New System.Drawing.Size(64, 20)
        Me.timerInput.TabIndex = 10
        Me.timerInput.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DataPrompt
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(395, 119)
        Me.Controls.Add(Me.timerInput)
        Me.Controls.Add(Me.numProbInput)
        Me.Controls.Add(Me.maximum)
        Me.Controls.Add(Me.rbtSetProbs)
        Me.Controls.Add(Me.rbtTimer)
        Me.Controls.Add(Me.rbtNone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.operation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DataPrompt"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter Data"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.maximum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numProbInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.timerInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents operation As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rbtNone As System.Windows.Forms.RadioButton
    Friend WithEvents rbtTimer As System.Windows.Forms.RadioButton
    Friend WithEvents rbtSetProbs As System.Windows.Forms.RadioButton
    Friend WithEvents maximum As System.Windows.Forms.NumericUpDown
    Friend WithEvents numProbInput As System.Windows.Forms.NumericUpDown
    Friend WithEvents timerInput As System.Windows.Forms.NumericUpDown

End Class
