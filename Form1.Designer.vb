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
        Me.lblConversion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblConversion.Location = New System.Drawing.Point(24, 20)
        Me.lblConversion.Name = "lblConversion"
        Me.lblConversion.Size = New System.Drawing.Size(140, 21)
        Me.lblConversion.TabIndex = 0
        Me.lblConversion.Text = "Conversion Type:"
        Me.lblConversion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblFrom.Location = New System.Drawing.Point(24, 80)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(44, 19)
        Me.lblFrom.TabIndex = 1
        Me.lblFrom.Text = "From:"
        Me.lblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblTo.Location = New System.Drawing.Point(24, 140)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(29, 19)
        Me.lblTo.TabIndex = 2
        Me.lblTo.Text = "To:"
        Me.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(136, 138)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.ReadOnly = True
        Me.txtTo.BackColor = System.Drawing.Color.FromArgb(245, 245, 245)
        Me.txtTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTo.Size = New System.Drawing.Size(200, 23)
        Me.txtTo.TabIndex = 3
        Me.txtTo.TabStop = False
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(136, 80)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFrom.Size = New System.Drawing.Size(200, 23)
        Me.txtFrom.TabIndex = 2
        '
        'cboConversionType
        '
        Me.cboConversionType.FormattingEnabled = True
        Me.cboConversionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConversionType.Location = New System.Drawing.Point(170, 20)
        Me.cboConversionType.Name = "cboConversionType"
        Me.cboConversionType.Size = New System.Drawing.Size(200, 23)
        Me.cboConversionType.TabIndex = 1
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.FromArgb(46, 204, 113)
        Me.btnConvert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConvert.FlatAppearance.BorderSize = 0
        Me.btnConvert.ForeColor = System.Drawing.Color.White
        Me.btnConvert.Location = New System.Drawing.Point(136, 190)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(95, 30)
        Me.btnConvert.TabIndex = 3
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(149, 165, 166)
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(245, 190)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 30)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'frmConversions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(420, 250)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.cboConversionType)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.lblConversion)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmConversions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unit Converter"
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
