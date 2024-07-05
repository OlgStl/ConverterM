
Imports System.Net.Http
Imports Newtonsoft.Json.Linq

Module APIModule

    Public DollarToPound As Double = 0.0
    Public EuroToPound As Double = 0.0
    Public ZlotyToPound As Double = 0.0
    Public HryvniaToPound As Double = 0.0
    Public LeuToPound As Double = 0.0
    Public ErrorMessage As String = String.Empty

    Public Async Function FetchRatesAsync(apiKey As String) As Task
        ' The API endpoint URL
        Dim url As String = "https://api.freecurrencyapi.com/v1/latest?apikey=" & apiKey

        ' Create a new HttpClient instance
        Using client As New HttpClient()
            Try
                ' Send a GET request to the API
                Dim response As HttpResponseMessage = Await client.GetAsync(url)

                ' Ensure the request was successful
                response.EnsureSuccessStatusCode()

                ' Read the response content as a string
                Dim responseData As String = Await response.Content.ReadAsStringAsync()

                ' Parse the JSON response
                Dim json As JObject = JObject.Parse(responseData)

                ' Access specific data from the JSON
                Dim rates As JObject = json("data")

                ' Store specific currency exchange rates
                If rates.ContainsKey("USD") Then DollarToPound = rates("USD").Value(Of Double)
                If rates.ContainsKey("EUR") Then EuroToPound = rates("EUR").Value(Of Double)
                If rates.ContainsKey("PLN") Then ZlotyToPound = rates("PLN").Value(Of Double)
                If rates.ContainsKey("UAH") Then HryvniaToPound = rates("UAH").Value(Of Double)
                If rates.ContainsKey("RON") Then LeuToPound = rates("RON").Value(Of Double)

                ' Clear the error message
                ErrorMessage = String.Empty
            Catch ex As Exception
                ' Store the error message
                ErrorMessage = "Error: " & ex.Message
            End Try
        End Using
    End Function

End Module

