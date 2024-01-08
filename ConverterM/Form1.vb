Public Class Form1
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        ' Define the conversion rates
        Const DollarToPound As Double = 0.72
        Const EuroToPound As Double = 0.86
        Const ZlotyToPound As Double = 0.19
        Const HryvniaToPound As Double = 0.03
        Const LeuToPound As Double = 0.18

        ' Get the input value
        Dim inputValue As Double = Double.Parse(txtFrom.Text)

        ' Convert the input value to Pounds
        Dim convertedValue As Double

        Select Case ComboBox1.SelectedItem.ToString()
            Case "Dollars"
                convertedValue = inputValue * DollarToPound
            Case "Euro"
                convertedValue = inputValue * EuroToPound
            Case "Zloty"
                convertedValue = inputValue * ZlotyToPound
            Case "Hryvnia"
                convertedValue = inputValue * HryvniaToPound
            Case "Leu"
                convertedValue = inputValue * LeuToPound
            Case Else
                MessageBox.Show("Please select a valid currency.")
                Return
        End Select

        ' Display the converted value
        txtTo.Text = convertedValue.ToString("F2") & " £"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.AddRange({"Dollars", "Pounds", "Euro", "Zloty", "Hryvnia", "Leu"})
    End Sub
End Class