Imports System.Threading
Imports System.Net

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim TotalThread As Integer = 300
        Dim SemaphoreCount As Integer = 100
        Dim Threads As Thread() = New Thread(TotalThread - 1) {}
        Dim Sema As New Semaphore(SemaphoreCount, SemaphoreCount)

        For i As Integer = 0 To TotalThread - 1
            Threads(i) = New Thread(New ParameterizedThreadStart(Sub() UpDemViewers(TextBox1.Text)))
            Threads(i).IsBackground = True
            Threads(i).Start(Sema)
        Next
        Sema = Nothing
        Threads = Nothing
        TotalThread = Nothing
        SemaphoreCount = Nothing
    End Sub




    Dim randomIndex As Integer
    Dim rnd As New Random
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each item As String In LsbFollowAccounts.Items
            Dim dicks As String() = item.Split(":")
            randomIndex = rnd.Next(1, LsbProxies.Items.Count - 1)
            Dim dmsd As String = LsbProxies.Items(randomIndex)
            LsbProxies.Items.Remove(randomIndex)
            Dim username, password, channel, proxy As String
            username = dicks(0)
            password = dicks(1)
            channel = TextBox2.Text
            proxy = dmsd
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = "ConsoleApplication1.exe"
            pHelp.Arguments = username & " " & password & " " & channel & " " & dmsd
            pHelp.UseShellExecute = False
            pHelp.CreateNoWindow = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)

        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        For Each item As String In LsbChatAccountsOAuth.Items
            Dim dicks As String() = item.Split(";")
            Dim username, password, channel, message As String
            username = dicks(0)
            password = dicks(1)
            channel = TextBox3.Text
            message = TextBox4.Text

            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = "ChatBotTwitch.exe"
            pHelp.Arguments = username & " " & password & " " & channel & " " & message
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BackgroundWorker1.CancelAsync()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        

        For i As Integer = 0 To TextBox5.Text Step 1
            Dim t1 As New Thread(New ParameterizedThreadStart(Sub() GetUrls(TextBox6.Text)))
            t1.Start()
        Next

        GC.SuppressFinalize(Me)
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork



        Do While True
            For Each itemss In LsbURLSWithTokens.Items
                If BackgroundWorker1.CancellationPending = True Then
                    e.Cancel = True
                    Exit For
                End If
                Dim t1 As New Threading.Thread(Sub() DoShit(itemss))
                t1.Start()
            Next
        Loop

    End Sub



    Private Sub DoShit(ByVal urm As String)
        Try
asdlop:
            Dim reuqest As HttpWebRequest = CType(WebRequest.Create(urm), HttpWebRequest)
            randomIndex = rnd.Next(1, LsbViewProxies.Items.Count - 1)
            Dim dmsd As String = LsbViewProxies.Items(randomIndex)
            Dim myProxy As New WebProxy(dmsd)
            reuqest.Proxy = myProxy
            reuqest.Method = "HEAD"
            reuqest.KeepAlive = True
            Dim response = reuqest.GetResponse()

            Console.WriteLine(response.ContentLength)
            response.Close()
            '   reuqest.Abort()
            response = Nothing
            reuqest = Nothing
            myProxy = Nothing
            dmsd = Nothing
            randomIndex = Nothing
            GC.SuppressFinalize(Me)
            'Thread.CurrentThread.Abort()
        Catch ex As Exception
            GoTo asdlop
        End Try

    End Sub
    Public Sub GetUrls(ByVal ChannelName As String)
asdasd:

        Dim merpa As String = ExecuteCommand("GenerateViewerLinks.exe", ChannelName)

        If merpa.Contains("http") Then
            UpdateList(merpa)
            GC.SuppressFinalize(Me)
        Else
            GoTo asdasd
        End If
    End Sub
    Private Delegate Sub UpdateListDelegate(ByVal itemName As String)
    Private Sub UpdateList(ByVal itemName As String)
        If Me.InvokeRequired Then
            Me.Invoke(New UpdateListDelegate(AddressOf UpdateList), itemName)
        Else
            LsbURLSWithTokens.Items.Add(itemName)
        End If
    End Sub

    Public Function ExecuteCommand(ByVal filePath As String, ByVal arguments As String) As String
        Dim p As Process
        p = New Process()
        p.StartInfo.FileName = filePath
        p.StartInfo.Arguments = arguments
        p.StartInfo.CreateNoWindow = True
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.Start()
        Return p.StandardOutput.ReadToEnd()
    End Function

    Public Shared Sub UpDemViewers(ByVal ChannelName As String)
        Try
sdfsdf:

            Dim request As HttpWebRequest = DirectCast(WebRequest.Create("https://api.twitch.tv/api/channels/" & ChannelName & "?as3=t&oauth_token=3vxrmk0h14vkgbai50bpiautpbbek52"), HttpWebRequest)
            Dim response As HttpWebResponse
            request.KeepAlive = True
            request.Method = "GET"
            request.Timeout = 2000
            request.UserAgent = "Mozilla/1.0 (Windows NT 6.1; WOW64) AppleWebKit/527.36 (KHTML, like Gecko) Chrome/12.0.1700.102 Safari/538.36"
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            Console.WriteLine(response)
            response.Close()
        Catch ex As Exception
            GoTo sdfsdf
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim FileName As String = ""
        Dim dicks As New OpenFileDialog
        dicks.ShowDialog()


        FileName = dicks.FileName.ToString()
        For Each line As String In System.IO.File.ReadAllLines(FileName)
            LsbViewProxies.Items.Add(line)
        Next
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim FileName As String = ""
        Dim dicks As New OpenFileDialog
        dicks.ShowDialog()


        FileName = dicks.FileName.ToString()
        For Each line As String In System.IO.File.ReadAllLines(FileName)
            LsbProxies.Items.Add(line)
        Next
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim FileName As String = ""
        Dim dicks As New OpenFileDialog
        dicks.ShowDialog()


        FileName = dicks.FileName.ToString()
        For Each line As String In System.IO.File.ReadAllLines(FileName)
            LsbFollowAccounts.Items.Add(line)
        Next
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim FileName As String = ""
        Dim dicks As New OpenFileDialog
        dicks.ShowDialog()


        FileName = dicks.FileName.ToString()
        For Each line As String In System.IO.File.ReadAllLines(FileName)
            LsbChatAccountsOAuth.Items.Add(line)
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim webAddress As String = "http://unknowncheats.me/"
        Process.Start(webAddress)
    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs)

    End Sub
End Class
