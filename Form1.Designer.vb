<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConversions
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
        Me.lblConversion = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.cboConversionType = New System.Windows.Forms.ComboBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblConversion
        '
        Me.lblConversion.AutoSize = True
        Me.lblConversion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.lblConversion.Location = New System.Drawing.Point(55, 42)
        Me.lblConversion.Name = "lblConversion"
        Me.lblConversion.Size = New System.Drawing.Size(75, 16)
        Me.lblConversion.TabIndex = 0
        Me.lblConversion.Text = "Conversion"
        Me.lblConversion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblFrom.Location = New System.Drawing.Point(55, 102)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(39, 15)
        Me.lblFrom.TabIndex = 1
        Me.lblFrom.Text = "From:"
        Me.lblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(58, 165)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 2
        Me.lblTo.Text = "To:"
        Me.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(136, 162)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.ReadOnly = True
        Me.txtTo.Size = New System.Drawing.Size(152, 20)
        Me.txtTo.TabIndex = 3
        Me.txtTo.TabStop = False
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(136, 97)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(152, 20)
        Me.txtFrom.TabIndex = 2
        '
        'cboConversionType
        '
        Me.cboConversionType.FormattingEnabled = True
        Me.cboConversionType.Location = New System.Drawing.Point(136, 42)
        Me.cboConversionType.Name = "cboConversionType"
        Me.cboConversionType.Size = New System.Drawing.Size(152, 21)
        Me.cboConversionType.TabIndex = 1
        Me.cboConversionType.Text = "Select conversion type"
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.LawnGreen
        Me.btnConvert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConvert.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.btnConvert.FlatAppearance.BorderSize = 2
        Me.btnConvert.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnConvert.Location = New System.Drawing.Point(45, 246)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(105, 23)
        Me.btnConvert.TabIndex = 3
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Red
        Me.btnClear.Location = New System.Drawing.Point(193, 245)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'frmConversions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(618, 637)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.cboConversionType)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.lblConversion)
        Me.Name = "frmConversions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "x"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblConversion As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblFrom As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents txtTo As TextBox
    Friend WithEvents txtFrom As TextBox
    Friend WithEvents cboConversionType As ComboBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
End Class
