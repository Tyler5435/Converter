Public Class frmConversions
    Dim conversionTable(,) As String = {
                                           {"Miles to kilometres", "Miles", "Kilometres", "1.6093"},
                                           {"Kilometres to miles", "Kilometres", "Miles", "0.6214"},
                                           {"Feet to metres", "Feet", "Metres", "0.3048"},
                                           {"Metres to feet", "Metres", "Feet", "3.2808"},
                                           {"Inches to centimetres", "Inches", "Centimetres", "2.54"},
                                           {"Centimetres to inches", "Centimetres", "Inches", "0.3937"}
                                       }

    Private Sub frmConversions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 0 To conversionTable.GetLength(0) - 1
            cboConversionType.Items.Add(conversionTable(i, 0))
        Next i
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        ' Validate input before attempting conversion
        If (IsValidData()) Then
            Dim fromLength As Decimal = Convert.ToDecimal(txtFrom.Text)
            Dim selectedConversion As Integer = cboConversionType.SelectedIndex
            Dim multiplier As Decimal = Convert.ToDecimal(conversionTable(selectedConversion, 3))
            Dim toLength As Decimal = fromLength * multiplier
            txtTo.Text = toLength.ToString()
        End If
    End Sub

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
    Public Function IsSelected(ByVal cboBox As ComboBox, ByVal text As String) As Boolean
        If (cboBox.SelectedIndex = -1) Then
            MessageBox.Show(text + " is a required field.", "Entry Error")
            cboBox.Focus()
            Return False
        End If
        Return True
    End Function

    ' Check that the TextBox contains any text (not empty)
    Public Function IsPresent(ByVal textBox As TextBox, ByVal text As String) As Boolean
        If (textBox.Text = "") Then
            MessageBox.Show(text + " is a required field.", "Entry Error")
            textBox.Focus()
            Return False
        End If
        Return True
    End Function

    ' Check that the TextBox contains a value that can be parsed to Decimal
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
