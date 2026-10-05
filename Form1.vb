Public Class frmConversions
    ' conversionTable: 2D array storing conversion metadata.
    ' Columns: 0 = display name, 1 = from unit, 2 = to unit, 3 = multiplier (string)
    Dim conversionTable(,) As String = {
                                           {"Miles to kilometres", "Miles", "Kilometres", "1.6093"},
                                           {"Kilometres to miles", "Kilometres", "Miles", "0.6214"},
                                           {"Feet to metres", "Feet", "Metres", "0.3048"},
                                           {"Metres to feet", "Metres", "Feet", "3.2808"},
                                           {"Inches to centimetres", "Inches", "Centimetres", "2.54"},
                                           {"Centimetres to inches", "Centimetres", "Inches", "0.3937"}
                                       }

    ' Form load event: populate the conversion type combo box from the table
    Private Sub frmConversions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 0 To conversionTable.GetLength(0) - 1
            cboConversionType.Items.Add(conversionTable(i, 0))
        Next i
    End Sub

    ' Convert button click: validate inputs then perform conversion
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        ' Validate input before attempting conversion
        If (IsValidData()) Then
            ' Convert text input to Decimal safely (IsDecimal already validated)
            Dim fromLength As Decimal = Convert.ToDecimal(txtFrom.Text)
            ' Get the selected conversion row index
            Dim selectedConversion As Integer = cboConversionType.SelectedIndex
            ' Multiplier stored as string in table; convert to Decimal for calculation
            Dim multiplier As Decimal = Convert.ToDecimal(conversionTable(selectedConversion, 3))
            ' Perform conversion and display result
            Dim toLength As Decimal = fromLength * multiplier
            txtTo.Text = toLength.ToString()
        End If
    End Sub

    ' Clear button: reset form controls to their initial state
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If (cboConversionType.SelectedIndex <> -1) Then
            cboConversionType.SelectedIndex = -1
            cboConversionType.Text = "Select conversion type"
        End If
        txtFrom.Clear()
        txtTo.Clear()
        cboConversionType.Focus()
    End Sub

    '========================
    ' Data validation helpers
    '========================
    ' Returns True only if all individual validations pass
    Public Function IsValidData() As Boolean
        ' Ensure a conversion is selected, the 'From' field is present and is a decimal
        Return IsSelected(cboConversionType, "'Conversion'") _
            And IsPresent(txtFrom, "'From'") _
            And IsDecimal(txtFrom, "'From'")
    End Function

    ' Check that a combo box has a selection. Uses the passed control and message text.
    ' Parameters:
    '   cboBox - the ComboBox to check
    '   text - friendly field name used in validation messages
    Public Function IsSelected(ByVal cboBox As ComboBox, ByVal text As String) As Boolean
        If (cboBox.SelectedIndex = -1) Then
            MessageBox.Show(text + " is a required field.", "Entry Error")
            cboBox.Focus()
            Return False
        End If
        Return True
    End Function

    ' Check that the TextBox contains any text (not empty)
    ' Parameters:
    '   textBox - the TextBox to check
    '   text - friendly field name used in validation messages
    Public Function IsPresent(ByVal textBox As TextBox, ByVal text As String) As Boolean
        If (textBox.Text = "") Then
            MessageBox.Show(text + " is a required field.", "Entry Error")
            textBox.Focus()
            Return False
        End If
        Return True
    End Function

    ' Check that the TextBox contains a value that can be parsed to Decimal
    ' Returns True if parse succeeds, otherwise shows error and returns False
    Public Function IsDecimal(ByVal textBox As TextBox, ByVal text As String) As Boolean
        Try
            Convert.ToDecimal(textBox.Text)
            Return True
        Catch ex As Exception
            MessageBox.Show(text + " must be a decimal number.", "Entry Error")
            textBox.Focus()
            Return False
        End Try
    End Function

End Class
