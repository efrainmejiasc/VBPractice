Imports System.Net.Http
Imports System.Net.Http.Headers

Public Class RequestHTTP
    Implements IRequestHTTP

    Public Async Function ExecuteRequest() As Task(Of String) Implements IRequestHTTP.ExecuteRequest

        Dim respuesta = String.Empty

        Try
            Dim client As HttpClient = New HttpClient()
            client.DefaultRequestHeaders.Accept.Clear()
            client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))
            'client.DefaultRequestHeaders.Add("Apikey", "")
            Dim response As HttpResponseMessage = Await client.GetAsync("https://api.coindesk.com/v1/bpi/currentprice.json")

            If response.IsSuccessStatusCode Then
                respuesta = response.Content.ReadAsStringAsync().Result
            Else
                respuesta = response.StatusCode.ToString()
            End If

        Catch ex As Exception
            respuesta = ex.Message
        End Try

        Return respuesta

    End Function

End Class
