Public Class Form1
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
<<<<<<< HEAD
        ' Define the conversion rates
        Const DollarToPound As Double =
        Const EuroToPound As Double =
        Const ZlotyToPound As Double =
        Const HryvniaToPound As Double =
        Const LeuToPound As Double = 

        ' Get the input value
=======




>>>>>>> 5db9ee842e9e047a124fd68091faadf881a585a9
        Dim inputValue As Double = Double.Parse(txtFrom.Text)


        Dim convertedValue As Double

        Select Case FromM.SelectedItem.ToString()
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


<<<<<<< HEAD
        ' Display the converted value
=======
>>>>>>> 5db9ee842e9e047a124fd68091faadf881a585a9
        txtTo.Text = convertedValue.ToString("F2") & " £"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FromM.Items.AddRange({"Dollars", "Pounds", "Euro", "Zloty", "Hryvnia", "Leu"})
    End Sub

    Private Sub ToM_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub FromM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FromM.SelectedIndexChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtTo_TextChanged(sender As Object, e As EventArgs) Handles txtTo.TextChanged

    End Sub

    Private Sub txtFrom_TextChanged(sender As Object, e As EventArgs) Handles txtFrom.TextChanged

    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        If txtPrice.Text = "" Then
            Const DollarToPound As Double = 0.72
            Const EuroToPound As Double = 0.86
            Const ZlotyToPound As Double = 0.19
            Const HryvniaToPound As Double = 0.03
            Const LeuToPound As Double = 0.18
        Else
            DollarToPound = (txtPrice.Text)
            EuroToPound = (txtPrice.Text)
            ZlotyToPound = (txtPrice.Text)
            HryvniaToPound = (txtPrice.Text)
            LeuToPound = (txtPrice.Text)
        End If
    End Sub
End Class