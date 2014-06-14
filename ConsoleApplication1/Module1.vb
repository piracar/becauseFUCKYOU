Imports System.Net
Imports System.IO

Module Module1

    Sub Main(args As String())
        'username, password, user to follow
        Dim username = args(0)
        Dim password = args(1)
        Dim channel = args(2)
        Dim proxy = args(3)
        login(username, password, channel, proxy)
    End Sub

    Dim dicksinmybutt As CookieContainer

    Public Sub FollowDitUser(ByVal username As String, ByVal usertofollow As String)
        Try
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(String.Format("http://api.twitch.tv/kraken/users/{0}/follows/channels/{1}", username, usertofollow)), HttpWebRequest)
            Dim response As HttpWebResponse
            request.KeepAlive = True
            request.Headers.Add("Origin", "http://api.twitch.tv")
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/32.0.1700.76 Safari/537.36"
            request.ContentType = "application/x-www-form-urlencoded"
            request.Accept = "application/vnd.twitchtv.v2+json"


            request.CookieContainer = dicksinmybutt

            Dim merp As String = dicksinmybutt.GetCookieHeader(New Uri("http://www.twitch.tv/"))
            Dim dicks As String = GetStringBetween(merp, "api_token=", "; lo")


            request.Headers.Add("X-Requested-With", "XMLHttpRequest")
            request.Headers.Add("X-Http-Method-Override", "PUT")

            request.Headers.Add("Twitch-Api-Token", dicks)

            request.Method = "POST"
            request.ServicePoint.Expect100Continue = False

            Dim body As String = "src=profile&on_site=1"
            Dim postBytes As Byte() = System.Text.Encoding.UTF8.GetBytes(body)
            request.ContentLength = postBytes.Length
            Dim stream As Stream = request.GetRequestStream()
            stream.Write(postBytes, 0, postBytes.Length)
            stream.Close()

            response = DirectCast(request.GetResponse(), HttpWebResponse)
        Catch ex As Exception
            End
        End Try
       

    End Sub
    Dim authcode As String = ""
    Public Sub login(ByVal username As String, ByVal password As String, ByVal followuser As String, ByVal proxy As String)
        Try
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create("https://secure.twitch.tv/user/login"), HttpWebRequest)
            Dim response As HttpWebResponse
            Dim tempCookies As New CookieContainer
            Dim lellel As String() = proxy.Split(":")
            Dim port As Integer = lellel(1)
            Dim ip As String = lellel(0)
            '  request.Proxy = New WebProxy(ip, port)
            request.KeepAlive = True
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8"
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/32.0.1700.76 Safari/537.36"

            response = DirectCast(request.GetResponse(), HttpWebResponse)
            Dim streamweb As Stream = response.GetResponseStream()
            Dim readstreamweb As New StreamReader(streamweb)
            While readstreamweb.Peek >= 0
                Dim verp As String = readstreamweb.ReadToEnd
                verp = GetStringBetween(verp, "class=""js-login-form login_form "" method=""post""", "</div>")
                authcode = GetStringBetween(verp, "<input name=""authenticity_token"" type=""hidden"" value=""", """ />")
            End While





            request = DirectCast(WebRequest.Create("https://secure.twitch.tv/user/login"), HttpWebRequest)

            request.KeepAlive = True
            request.Headers.Set(HttpRequestHeader.CacheControl, "max-age=0")
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8"
            request.Headers.Add("Origin", "http://www.twitch.tv")
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/32.0.1700.76 Safari/537.36"
            request.ContentType = "application/x-www-form-urlencoded"

            request.CookieContainer = tempCookies
            request.Method = "POST"
            request.ServicePoint.Expect100Continue = False

            Dim body As String = "utf8=%E2%9C%93&authenticity_token=" & authcode & "D&redirect_on_login=http%3A%2F%2Fwww.twitch.tv%2F&embed_form=false&user%5Blogin%5D=" & username & "&user%5Bpassword%5D=" & password & ""
            Dim postBytes As Byte() = System.Text.Encoding.UTF8.GetBytes(body)
            request.ContentLength = postBytes.Length
            Dim stream As Stream = request.GetRequestStream()
            stream.Write(postBytes, 0, postBytes.Length)
            stream.Close()


            Dim postresponse As HttpWebResponse

            postresponse = DirectCast(request.GetResponse(), HttpWebResponse)
            tempCookies.Add(postresponse.Cookies)
            dicksinmybutt = tempCookies
            FollowDitUser(username, followuser)
        Catch ex As Exception
            End
        End Try

    End Sub
    Public Function GetStringBetween(ByVal source As String, ByVal start As String, ByVal [end] As String) As String
        Dim startIndex As Integer = source.IndexOf(start)
        If startIndex <> -1 Then
            Dim endIndex As Integer = source.IndexOf([end], startIndex + 1)
            If endIndex <> -1 Then
                Return source.Substring(startIndex + start.Length, endIndex - startIndex - start.Length)
            End If
        End If
        Return String.Empty
    End Function
End Module
