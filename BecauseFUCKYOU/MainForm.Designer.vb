<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LsbProxies = New System.Windows.Forms.ListBox()
        Me.LsbFollowAccounts = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.LsbChatAccountsOAuth = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.LsbViewProxies = New System.Windows.Forms.ListBox()
        Me.LsbURLSWithTokens = New System.Windows.Forms.ListBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(417, 371)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(203, 88)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Increase Page Views"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Channel Name:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(92, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(183, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Start!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button9)
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.LsbProxies)
        Me.GroupBox2.Controls.Add(Me.LsbFollowAccounts)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(681, 179)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Follow Channel"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(342, 146)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(95, 23)
        Me.Button9.TabIndex = 21
        Me.Button9.Text = "Load Accounts"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(571, 146)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(95, 23)
        Me.Button8.TabIndex = 20
        Me.Button8.Text = "Load Proxies"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Channel Name:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(92, 16)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'LsbProxies
        '
        Me.LsbProxies.FormattingEnabled = True
        Me.LsbProxies.Location = New System.Drawing.Point(443, 19)
        Me.LsbProxies.Name = "LsbProxies"
        Me.LsbProxies.Size = New System.Drawing.Size(223, 121)
        Me.LsbProxies.TabIndex = 2
        '
        'LsbFollowAccounts
        '
        Me.LsbFollowAccounts.FormattingEnabled = True
        Me.LsbFollowAccounts.Location = New System.Drawing.Point(214, 19)
        Me.LsbFollowAccounts.Name = "LsbFollowAccounts"
        Me.LsbFollowAccounts.Size = New System.Drawing.Size(223, 121)
        Me.LsbFollowAccounts.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(9, 42)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(183, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Start!"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Button10)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.LsbChatAccountsOAuth)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 371)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(399, 198)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Chat Bot"
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(296, 172)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(95, 23)
        Me.Button10.TabIndex = 22
        Me.Button10.Text = "Load Accounts"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Message:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(9, 66)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(223, 71)
        Me.TextBox4.TabIndex = 9
        '
        'LsbChatAccountsOAuth
        '
        Me.LsbChatAccountsOAuth.FormattingEnabled = True
        Me.LsbChatAccountsOAuth.Location = New System.Drawing.Point(238, 19)
        Me.LsbChatAccountsOAuth.Name = "LsbChatAccountsOAuth"
        Me.LsbChatAccountsOAuth.Size = New System.Drawing.Size(153, 147)
        Me.LsbChatAccountsOAuth.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Channel Name:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(92, 21)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 6
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(9, 143)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(223, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Start!"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Button7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.TextBox6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.TextBox5)
        Me.GroupBox4.Controls.Add(Me.LsbViewProxies)
        Me.GroupBox4.Controls.Add(Me.LsbURLSWithTokens)
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Controls.Add(Me.Button6)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 197)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(576, 168)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Increase LIVE viewers"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(475, 133)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(95, 23)
        Me.Button7.TabIndex = 19
        Me.Button7.Text = "Load Proxies"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Channel Name:"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(92, 16)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(76, 20)
        Me.TextBox6.TabIndex = 17
        Me.TextBox6.Text = "Twitch"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "ViewAmount:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(92, 42)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(76, 20)
        Me.TextBox5.TabIndex = 15
        Me.TextBox5.Text = "300"
        '
        'LsbViewProxies
        '
        Me.LsbViewProxies.FormattingEnabled = True
        Me.LsbViewProxies.Location = New System.Drawing.Point(347, 19)
        Me.LsbViewProxies.Name = "LsbViewProxies"
        Me.LsbViewProxies.Size = New System.Drawing.Size(223, 108)
        Me.LsbViewProxies.TabIndex = 14
        '
        'LsbURLSWithTokens
        '
        Me.LsbURLSWithTokens.FormattingEnabled = True
        Me.LsbURLSWithTokens.Location = New System.Drawing.Point(221, 19)
        Me.LsbURLSWithTokens.Name = "LsbURLSWithTokens"
        Me.LsbURLSWithTokens.Size = New System.Drawing.Size(120, 108)
        Me.LsbURLSWithTokens.TabIndex = 13
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(9, 134)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(159, 23)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Stop!"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(9, 105)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(159, 23)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Start!"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(9, 76)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(159, 23)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "Generate Links"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Disabled until oauth login is fixed"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(417, 462)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(281, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Created by DrWhat. Credits to DevCore, Daizee, Joepie91"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(417, 475)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(142, 13)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "http://UnKnoWnCheaTs.me"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(218, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Viewers: "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 579)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "CuntTrollPanel"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LsbFollowAccounts As System.Windows.Forms.ListBox
    Friend WithEvents LsbProxies As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents LsbChatAccountsOAuth As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LsbURLSWithTokens As System.Windows.Forms.ListBox
    Friend WithEvents LsbViewProxies As System.Windows.Forms.ListBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
