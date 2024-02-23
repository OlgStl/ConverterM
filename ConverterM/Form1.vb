Public Class Form1

    ' Variables to store conversion rates
    Public DollarToPound As Double
    Public EuroToPound As Double
    Public ZlotyToPound As Double
    Public HryvniaToPound As Double
    Public LeuToPound As Double

    ' Convert button click event handler
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        ' Get input value
        Dim inputValue As Double = Double.Parse(txtFrom.Text)
        ' Convert input based on selected currency
        Select Case FromM.SelectedItem.ToString()
            Case "Dollars"
                txtTo.Text = (inputValue * DollarToPound).ToString("F2") & " £"
            Case "Euro"
                txtTo.Text = (inputValue * EuroToPound).ToString("F2") & " £"
            Case "Zloty"
                txtTo.Text = (inputValue * ZlotyToPound).ToString("F2") & " £"
            Case "Hryvnia"
                txtTo.Text = (inputValue * HryvniaToPound).ToString("F2") & " £"
            Case "Leu"
                txtTo.Text = (inputValue * LeuToPound).ToString("F2") & " £"
            Case Else
                MessageBox.Show("Please select a valid currency.")
        End Select
    End Sub

    ' Form load event handler
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FromM.Items.AddRange({"Dollars", "Pounds", "Euro", "Zloty", "Hryvnia", "Leu"})
    End Sub

    ' Price text changed event handler
    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        ' Update conversion rates based on price entered
        If txtPrice.Text = "" Then
            ' Default conversion rates
            DollarToPound = 0.72
            EuroToPound = 0.86
            ZlotyToPound = 0.19
            HryvniaToPound = 0.03
            LeuToPound = 0.18
        Else
            ' Set conversion rates based on entered price
            Dim price As Double = Double.Parse(txtPrice.Text)
            DollarToPound = price
            EuroToPound = price
            ZlotyToPound = price
            HryvniaToPound = price
            LeuToPound = price
        End If
    End Sub

End Class