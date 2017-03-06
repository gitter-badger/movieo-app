﻿Imports System.Globalization
Imports System.Net
Imports System.Text.RegularExpressions

Public Class frmInfo

    Private Sub frmInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set selected tab
        Tab.SelectedTab = Movieo.InfoSelectedTab

        'Set position/size of window
        Top = 0
        Left = 0
        Size = New Size(Movieo.Size)

        'Latest changelog text
        Try
            lblChangelogFull.Text = New WebClient().DownloadString(Movieo.linkChangelog)
        Catch ex As Exception
            lblChangelogFull.Text = ex.Message
        End Try

        'Fix bug where textboxes were sometimes hidden (sent to the back of backgrounds)
        txtFormMessageBG.SendToBack()
        txtFormEmailBG.SendToBack()
    End Sub

    'Close window image
    Private Sub MeClose_MouseMove(sender As Object, e As MouseEventArgs) Handles meClose.MouseMove
        meClose.Image = My.Resources.PopupCloseH
    End Sub

    Private Sub MeClose_MouseLeave(sender As Object, e As EventArgs) Handles meClose.MouseLeave
        meClose.Image = My.Resources.PopupCloseL
    End Sub

    Private Sub MeClose_MouseClick(sender As Object, e As EventArgs) Handles meClose.MouseClick
        Close()
    End Sub

    'Tabs
    Private Sub LblAbout_Click(sender As Object, e As EventArgs) Handles lblTabAbout.Click
        Tab.SelectedTab = tabAbout
    End Sub

    Private Sub LblLegal_Click(sender As Object, e As EventArgs) Handles lblTabLegal.Click
        Tab.SelectedTab = tabLegal
    End Sub

    Private Sub LblFAQ_Click(sender As Object, e As EventArgs) Handles lblTabFAQ.Click
        Tab.SelectedTab = tabHelpFaq
    End Sub

    Private Sub LblChangelog_Click(sender As Object, e As EventArgs) Handles lblTabChangelog.Click
        Tab.SelectedTab = tabChangelog
    End Sub

    Private Sub LblContact_Click(sender As Object, e As EventArgs) Handles lblTabContact.Click
        Tab.SelectedTab = tabContact
    End Sub

    Private Sub LblAbout_MouseMove(sender As Object, e As MouseEventArgs) Handles lblTabContact.MouseMove, lblTabChangelog.MouseMove, lblTabLegal.MouseMove, lblTabFAQ.MouseMove, lblTabAbout.MouseMove
        sender.ForeColor = SelectedTabColour
    End Sub

    Private Sub LblAbout_MouseLeave(sender As Object, e As EventArgs) Handles lblTabContact.MouseLeave, lblTabChangelog.MouseLeave, lblTabLegal.MouseLeave, lblTabFAQ.MouseLeave, lblTabAbout.MouseLeave
        If sender IsNot CurrentTab Then sender.ForeColor = NonSelectedTabColour
    End Sub

    Dim CurrentTab As Object = lblTabAbout
    Dim SelectedTabColour As Color = Color.FromArgb(172, 180, 191)
    Dim NonSelectedTabColour As Color = Color.FromArgb(86, 98, 115)

    Private Sub Tab_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tab.SelectedIndexChanged
        If Tab.SelectedIndex = 0 Then
            CurrentTab = lblTabAbout
            lblTabAbout.ForeColor = SelectedTabColour
            lblTabLegal.ForeColor = NonSelectedTabColour
            lblTabFAQ.ForeColor = NonSelectedTabColour
            lblTabChangelog.ForeColor = NonSelectedTabColour
            lblTabContact.ForeColor = NonSelectedTabColour
        ElseIf Tab.SelectedIndex = 1 Then
            CurrentTab = lblTabLegal
            lblTabAbout.ForeColor = NonSelectedTabColour
            lblTabLegal.ForeColor = SelectedTabColour
            lblTabFAQ.ForeColor = NonSelectedTabColour
            lblTabChangelog.ForeColor = NonSelectedTabColour
            lblTabContact.ForeColor = NonSelectedTabColour
        ElseIf Tab.SelectedIndex = 2 Then
            CurrentTab = lblTabFAQ
            lblTabAbout.ForeColor = NonSelectedTabColour
            lblTabLegal.ForeColor = NonSelectedTabColour
            lblTabFAQ.ForeColor = SelectedTabColour
            lblTabChangelog.ForeColor = NonSelectedTabColour
            lblTabContact.ForeColor = NonSelectedTabColour
        ElseIf Tab.SelectedIndex = 3 Then
            CurrentTab = lblTabChangelog
            lblTabAbout.ForeColor = NonSelectedTabColour
            lblTabLegal.ForeColor = NonSelectedTabColour
            lblTabFAQ.ForeColor = NonSelectedTabColour
            lblTabChangelog.ForeColor = SelectedTabColour
            lblTabContact.ForeColor = NonSelectedTabColour
        ElseIf Tab.SelectedIndex = 4 Then
            CurrentTab = lblTabContact
            lblTabAbout.ForeColor = NonSelectedTabColour
            lblTabLegal.ForeColor = NonSelectedTabColour
            lblTabFAQ.ForeColor = NonSelectedTabColour
            lblTabChangelog.ForeColor = NonSelectedTabColour
            lblTabContact.ForeColor = SelectedTabColour
        End If
    End Sub

    'Data provider link
    Private Sub ImgProvider_Click(sender As Object, e As EventArgs) Handles imgDataProvider.Click
        Process.Start("http://omdbapi.com/")
    End Sub

    'Share links
    Private Sub BtnShareTw_Click(sender As Object, e As EventArgs) Handles btnShareTwitter.Click
        Process.Start("https://twitter.com/intent/tweet?text=https://twitter.com/intent/tweet?url=http%3A%2F%2Fitsmovieo.esy.es%2F&text=Watch%20your%20favourite%20movies%20with%20Odeum%20Movies!%20Download%20it%20at%20&original_referer=")
    End Sub

    Private Sub BtnShareFb_Click(sender As Object, e As EventArgs) Handles btnShareFacebook.Click
        Process.Start("https://www.facebook.com/sharer/sharer.php?u=http://itsmovieo.esy.es")
    End Sub

    'Message submit button
    Private Sub BtnSubmitForm_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnFormSubmit.ClickButtonArea
        If Not txtFormMessage.Text = "" Then
            If Not txtFormEmail.Text = "" Then
                If IsValidEmail(txtFormEmail.Text) = True Then
                    Try
                        Movieo.SendMail("Message",
                        "Message: " + vbNewLine + txtFormMessage.Text + vbNewLine + vbNewLine +
                        "From: " + vbNewLine + txtFormEmail.Text)
                        lblMessageSent.Text = "Message sent! Thank you so much ❤"
                        txtFormMessage.Text = ""
                        txtFormEmail.Text = ""
                        lblMessageSent.Visible = True
                        timerHideMessageSent.Enabled = True
                    Catch ex As Exception
                        lblMessageSent.Text = "Unable to send your message."
                        lblMessageSent.Visible = True
                        timerHideMessageSent.Enabled = True
                    End Try
                Else
                    lblMessageSent.Text = "Your email doesn't look right."
                    lblMessageSent.Visible = True
                    timerHideMessageSent.Enabled = True
                End If
            Else
                lblMessageSent.Text = "Your email cannot be blank."
                lblMessageSent.Visible = True
                timerHideMessageSent.Enabled = True
            End If
        Else
            lblMessageSent.Text = "Your message cannot be blank."
            lblMessageSent.Visible = True
            timerHideMessageSent.Enabled = True
        End If
    End Sub

    Dim invalid As Boolean = False

    Public Function IsValidEmail(strIn As String) As Boolean
        invalid = False
        If String.IsNullOrEmpty(strIn) Then Return False

        ' Use IdnMapping class to convert Unicode domain names.
        Try
            strIn = Regex.Replace(strIn, "(@)(.+)$", AddressOf Me.DomainMapper,
                                RegexOptions.None, TimeSpan.FromMilliseconds(200))
        Catch ex As RegexMatchTimeoutException
            Return False
        End Try

        If invalid Then Return False

        ' Return true if strIn is in valid e-mail format.
        Try
            Return Regex.IsMatch(strIn,
                 "^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                 "(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                 RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))
        Catch e As RegexMatchTimeoutException
            Return False
        End Try
    End Function

    Private Function DomainMapper(match As Match) As String
        'IdnMapping class with default property values.
        Dim idn As New IdnMapping()

        Dim domainName As String = match.Groups(2).Value
        Try
            domainName = idn.GetAscii(domainName)
        Catch ex As ArgumentException
            invalid = True
        End Try
        Return match.Groups(1).Value + domainName
    End Function

    Private Sub BtnSubmitForm_MouseMove(sender As Object, e As EventArgs) Handles btnFormSubmit.MouseMove, btnFormSubmit.GotFocus
        sender.ForeColor = Color.White
        sender.BorderColor = Color.White
        sender.ColorFillSolid = Color.FromArgb(52, 59, 71)
    End Sub

    Private Sub BtnSubmitForm_MouseLeave(sender As Object, e As EventArgs) Handles btnFormSubmit.MouseLeave, btnFormSubmit.LostFocus
        sender.ForeColor = Color.FromArgb(172, 180, 191)
        sender.BorderColor = Color.FromArgb(172, 180, 191)
        sender.ColorFillSolid = Color.Transparent
    End Sub

    'Confirmation text
    Private Sub HideConfirmation_Tick(sender As Object, e As EventArgs) Handles timerHideMessageSent.Tick
        lblMessageSent.Visible = False
        timerHideMessageSent.Enabled = False
    End Sub

    Private Sub lblMessageSent_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles lblMessageSent.ClickButtonArea
        lblMessageSent.Visible = False
        timerHideMessageSent.Enabled = False
    End Sub

    'Social links
    Private Sub ContactEmail_Click(sender As Object, e As EventArgs) Handles lblSocialEmail.Click
        Process.Start("mailto:" + lblSocialEmail.Text)
    End Sub

    Private Sub ContactSourceForge_Click(sender As Object, e As EventArgs) Handles lblSocialSourceForge.Click
        Process.Start("https://sourceforge.net/projects/odeum-movies-beta/")
    End Sub

    Private Sub ContactTwitter_Click(sender As Object, e As EventArgs) Handles lblSocialTwitter.Click
        Process.Start("http://twitter.com/localenvy")
    End Sub

    Private Sub TabAbout_Scroll(sender As Object, e As ScrollEventArgs) Handles tabAbout.Scroll
        tabAbout.Update()
    End Sub

    Private Sub TabHelpFaq_Scroll(sender As Object, e As ScrollEventArgs) Handles tabHelpFaq.Scroll
        tabHelpFaq.Update()
    End Sub

    Private Sub TabLegal_Scroll(sender As Object, e As ScrollEventArgs) Handles tabLegal.Scroll
        tabLegal.Update()
    End Sub

    Private Sub TabChangelog_Scroll(sender As Object, e As ScrollEventArgs) Handles tabChangelog.Scroll
        tabChangelog.Update()
    End Sub

    Private Sub TabContact_Scroll(sender As Object, e As ScrollEventArgs) Handles tabContact.Scroll
        tabContact.Update()
    End Sub

End Class