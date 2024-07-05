Imports System.Net.Http
Imports Newtonsoft.Json.Linq


Public Class Form1


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

    '' Price text changed event handler
    'Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
    '    ' Update conversion rates based on price entered
    '    If txtPrice.Text = "" Then
    '        ' Default conversion rates
    '        DollarToPound = 0.72
    '        EuroToPound = 0.86
    '        ZlotyToPound = 0.19
    '        HryvniaToPound = 0.03
    '        LeuToPound = 0.18
    '    Else
    '        ' Set conversion rates based on entered price
    '        Dim price As Double = Double.Parse(txtPrice.Text)
    '        DollarToPound = price
    '        EuroToPound = price
    '        ZlotyToPound = price
    '        HryvniaToPound = price
    '        LeuToPound = price
    '    End If
    'End Sub




    Private Async Function BtnFetchRates_Click(sender As Object, e As EventArgs) As Task Handles BtnFetchRates.Click
        ' Your FreeCurrencyAPI key
        Dim apiKey As String = "fca_live_n0HWHDjzhCehZSYbGde3lSbmwYqW4Uk8MXqR6lJl"

        ' Clear any existing text boxes
        'For Each ctrl As Control In Me.Controls.OfType(Of TextBox)().ToList()
        '    Me.Controls.Remove(ctrl)
        'Next

        ' Fetch the currency rates
        Await FetchRatesAsync(apiKey)

        ' Check for errors
        If Not String.IsNullOrEmpty(ErrorMessage) Then
            Dim errorTextBox As New TextBox()
            errorTextBox.Text = ErrorMessage
            errorTextBox.Location = New Point(10, 10)
            errorTextBox.Width = 300
            Me.Controls.Add(errorTextBox)
            Return
        End If

        ' Display each specific currency exchange rate in a separate text box
        Dim yPos As Integer = 10

        Dim txtUSD As New TextBox()
        txtUSD.Text = "USD to Pound: " & DollarToPound.ToString()
        txtUSD.Location = New Point(10, yPos)
        txtUSD.Width = 200
        Me.Controls.Add(txtUSD)
        yPos += 30

        Dim txtEUR As New TextBox()
        txtEUR.Text = "EUR to Pound: " & EuroToPound.ToString()
        txtEUR.Location = New Point(10, yPos)
        txtEUR.Width = 200
        Me.Controls.Add(txtEUR)
        yPos += 30

        Dim txtPLN As New TextBox()
        txtPLN.Text = "PLN to Pound: " & ZlotyToPound.ToString()
        txtPLN.Location = New Point(10, yPos)
        txtPLN.Width = 200
        Me.Controls.Add(txtPLN)
        yPos += 30

        Dim txtUAH As New TextBox()
        txtUAH.Text = "UAH to Pound: " & HryvniaToPound.ToString()
        txtUAH.Location = New Point(10, yPos)
        txtUAH.Width = 200
        Me.Controls.Add(txtUAH)
        yPos += 30

        Dim txtRON As New TextBox()
        txtRON.Text = "RON to Pound: " & LeuToPound.ToString()
        txtRON.Location = New Point(10, yPos)
        txtRON.Width = 200
        Me.Controls.Add(txtRON)

        Btn1.Visible = True
    End Function

    Private Sub FromM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FromM.SelectedIndexChanged

    End Sub

    Private Sub BtnFetchRates_Click(sender As Object, e As EventArgs) Handles BtnFetchRates.Click

    End Sub
End Class