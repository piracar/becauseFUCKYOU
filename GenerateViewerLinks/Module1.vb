Imports System.Net
Imports System.IO
Imports Newtonsoft.Json.Linq

Module Module1

    Sub Main(args As String())

        Dim jason As String = ""
        Dim ChannelName = args(0)

        Dim request As HttpWebRequest = DirectCast(WebRequest.Create("https://api.twitch.tv/api/channels/" & ChannelName & "/access_token.json"), HttpWebRequest)
        request.Timeout = 2000
        Dim response As HttpWebResponse
        request.KeepAlive = True
        request.Headers.Set(HttpRequestHeader.CacheControl, "max-age=0")
        request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8"
        request.UserAgent = "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/32.0.1700.107 Safari/537.36"

        response = DirectCast(request.GetResponse(), HttpWebResponse)
        Dim streamweb As Stream = response.GetResponseStream()
        Dim readstreamweb As New StreamReader(streamweb)
        While readstreamweb.Peek >= 0
            Dim verp As String = readstreamweb.ReadToEnd
            jason = verp
        End While

        Dim o As JObject = JObject.Parse(jason)
        Dim Token As String = o.SelectToken("token")
        Dim Sig As String = o.SelectToken("sig")



        Dim dicks As String = String.Format("http://usher.twitch.tv/select/{0}.json?allow_source=true&nauthsig={1}&private_code=null&type=any&nauth={2}&p=801601", ChannelName, Sig, Token)



        'Dim request2 As HttpWebRequest = DirectCast(WebRequest.Create(dicks), HttpWebRequest)
        'Dim response2 As HttpWebResponse
        'request2.KeepAlive = True
        'request2.Headers.Set(HttpRequestHeader.CacheControl, "max-age=0")
        'request2.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8"
        'request2.UserAgent = "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/32.0.1700.107 Safari/537.36"

        'response2 = DirectCast(request2.GetResponse(), HttpWebResponse)
        'Dim streamweb2 As Stream = response2.GetResponseStream()
        'Dim readstreamweb2 As New StreamReader(streamweb2)
        'While readstreamweb2.Peek >= 0
        'Dim verp As String = readstreamweb2.ReadLine
        'If verp.Contains("mobile/index") Then
        'Console.WriteLine(verp)
        'End If
        'End While

        Dim JsonRequestTwitch As HttpWebRequest = DirectCast(WebRequest.Create(dicks), HttpWebRequest)

        Dim JsonResponseTwitch As HttpWebResponse = DirectCast(JsonRequestTwitch.GetResponse(), HttpWebResponse)
        Dim MobileStream As String

        Using reader As New StreamReader(JsonResponseTwitch.GetResponseStream())
            Dim lines As New List(Of String)()
            While reader.Peek() >= 0
                lines.Add(reader.ReadLine())
            End While
            MobileStream = lines(lines.Count - 1)
        End Using
        Console.WriteLine(MobileStream)

    End Sub

End Module
