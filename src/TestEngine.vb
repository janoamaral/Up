Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Text.RegularExpressions

Public Class TestEngine


    Public Structure History
        Dim Timestamp As Date
        Dim StatusHTTP As Boolean
        Dim StatusICMP As Boolean
    End Structure

    Public Property Host As String = "logico.com.ar"
    Public Property Historial As New List(Of History)
    Public Property Timeout As Integer = 5000
    Public Property LastTest As New History
    Public ReadOnly Property PruebasRealizadas As Integer = 0
    Public ReadOnly Property PruebasFallidas As Integer = 0
    Public Property TrySSL As Boolean = False



    Public Sub New()
        Dim tmp As History
        tmp.StatusICMP = False
        tmp.StatusHTTP = False
        tmp.Timestamp = Now()
        LastTest = tmp
    End Sub



    ''' <summary>
    ''' Envia una solicitud web a la URL y verifica el codigo de respuesta
    ''' </summary>
    ''' <returns>TRUE si la web esta activa, FALSE en cualquier otro caso</returns>
    Public Function GetHTTPStatus(Optional TrySSL As Boolean = False) As Boolean

        Dim regex As Regex = New Regex("(http|https):\/\/[\w\-_]+(\.[\w\-_]+)+([\w\-\.,@?^=%&amp;:/~\+#]*[\w\-\@?^=%&amp;/~\+#])?")
        Dim match As Match = regex.Match(Host)
        Dim addr As String

        If Not match.Success Then
            If TrySSL Then
                addr = "https://" & Host & "/"
            Else
                addr = "http://" & Host & "/"
            End If

        Else
            addr = Host
        End If


        Try
            Dim wr As HttpWebRequest = CType(WebRequest.Create(addr), HttpWebRequest)
            wr.Timeout = Timeout
            wr.AllowAutoRedirect = True

            Dim wRes As HttpWebResponse = CType(wr.GetResponse(), HttpWebResponse)

            If wRes.StatusCode = HttpStatusCode.OK Then
                wRes.Close()
                Return True
            End If
        Catch e As WebException

            If (e.Message.Contains("SSL")) Then
                Return True
            End If

            Return False
        Catch e As Exception
            Return False
        End Try

        Return False
    End Function




    Public Function GetICMPStatus() As Boolean
        Try
            ' Host Name resolution to IP

            Dim regex As Regex = New Regex("\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b")
            Dim match As Match = regex.Match(Host)
            Dim ip As String

            If Not match.Success Then
                Dim addr As IPHostEntry = Dns.GetHostEntry(GetSanitizedHost)
                ip = addr.AddressList(0).ToString
            Else
                ip = GetSanitizedHost()
            End If


            Dim ping As New Ping
            Dim result As PingReply

            Dim startTime As Date = Now()
            result = ping.Send(ip, Timeout)
            Dim stopTime As Date = Now()
            Dim duration As TimeSpan = stopTime - startTime
            Debug.Print(duration.TotalMilliseconds & "ms")

            If result.Status = IPStatus.Success Then
                Return True
            Else
                Return False
            End If



        Catch ex As System.Net.Sockets.SocketException
            Return False
        Catch ex As System.Exception
            Return False
        End Try

        Return False
    End Function


    Public Sub Test()
        Dim resultado As History
        resultado.StatusHTTP = GetHTTPStatus()
        If (TrySSL) And (Not resultado.StatusHTTP) Then
            resultado.StatusHTTP = GetHTTPStatus(True)
        End If
        resultado.StatusICMP = GetICMPStatus()
        resultado.Timestamp = Now()
        LastTest = resultado
        Historial.Add(resultado)

        If Not resultado.StatusHTTP Or Not resultado.StatusICMP Then
            _PruebasFallidas += 1
        End If

        _PruebasRealizadas += 1
    End Sub


    Public Function SaveHistoryToFile(ByVal path As String) As Boolean

        Dim historyEntry As History
        Dim content As String = ""

        content &= "HTTP; ICMP; HORA" & vbCrLf


        For Each historyEntry In Historial
            If historyEntry.StatusHTTP Then content &= 1 & "; " Else content &= 0 & "; "
            If historyEntry.StatusHTTP Then content &= 1 & "; " Else content &= 0 & "; "
            content &= historyEntry.Timestamp.ToString & vbCrLf
        Next



        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(path.Replace(":", "-"), False)
        file.Write(content)
        file.Close()

        Return True

    End Function

    Public Function SaveLastHistoryEntry(ByVal path As String) As Boolean

        Dim content As String = ""

        If Not My.Computer.FileSystem.FileExists(path) Then
            content &= "HTTP; ICMP; HORA" & vbCrLf
        End If

        If LastTest.StatusHTTP Then content &= 1 & "; " Else content &= 0 & "; "
        If LastTest.StatusHTTP Then content &= 1 & "; " Else content &= 0 & "; "
        content &= LastTest.Timestamp.ToString & vbCrLf

        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(path, True)
        file.Write(content)
        file.Close()

        Return True
    End Function

    Public Function GetSanitizedHost() As String
        Dim addr As String
        addr = Host.Replace("https://", "").Replace("http://", "").Replace("/", "").Trim
        If addr.LastIndexOf(":") >= 0 Then
            addr = addr.Substring(0, addr.LastIndexOf(":"))
        End If

        Return addr
    End Function

End Class
