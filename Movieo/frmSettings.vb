﻿Public Class frmSettings

#Region "Base"

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set position/size of window
        Top = Movieo.ClientRectangle.Top + 23
        Left = Movieo.ClientRectangle.Left
        Size = Movieo.ClientSize

        'General
        chkAlwaysOnTop.Checked = My.Settings.doOnTop
        chkShowRating.Checked = My.Settings.doRatingOnPoster
        cmboboxWatchedMovies.SelectedIndex = My.Settings.doWatchedMovies

        'Quality
        chkShowMovieQuality.Checked = My.Settings.doQualityOnPoster

        'Playback
        chckPlayFullscr.Checked = My.Settings.doFullScr

        'Features
        chckDownloadBtn.Checked = My.Settings.doDownloadBtn
        chckUserComments.Checked = My.Settings.doUserComments

        'Database
        chckBackupDb.Checked = My.Settings.doBackupDb
        txtDbDir.Text = Movieo.pathBackupDatabase

        'Miscellaneous
        chckAutoUpdate.Checked = My.Settings.doAutoUpdate
    End Sub

    'Close window image
    Private Sub MeClose_MouseMove(sender As Object, e As MouseEventArgs) Handles MeClose.MouseMove
        MeClose.Image = My.Resources.PopupCloseH
    End Sub

    Private Sub MeClose_MouseLeave(sender As Object, e As EventArgs) Handles MeClose.MouseLeave
        MeClose.Image = My.Resources.PopupCloseL
    End Sub

    Private Sub MeClose_MouseClick(sender As Object, e As EventArgs) Handles MeClose.Click
        My.Settings.Reload()
        Close()
    End Sub

    'Prevent lag on scroll
    Private Sub MyBase_Scroll(sender As Object, e As ScrollEventArgs) Handles MyBase.Scroll
        sender.update()
    End Sub

#End Region

#Region "General"

    Private Sub chkAlwaysOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles chkAlwaysOnTop.CheckedChanged
        My.Settings.doOnTop = chkAlwaysOnTop.Checked
        Movieo.TopMost = True
    End Sub

    Private Sub chkShowRating_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowRating.CheckedChanged
        My.Settings.doRatingOnPoster = chkShowRating.Checked
    End Sub

    Private Sub cmboTxtWatchedMovies_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles cmboTxtWatchedMovies.ClickButtonArea
        cmboboxWatchedMovies.DroppedDown = True
    End Sub

    Private Sub cmboboxWatchedMovies_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboboxWatchedMovies.SelectedIndexChanged
        cmboTxtWatchedMovies.Text = cmboboxWatchedMovies.SelectedItem.ToString
        My.Settings.doWatchedMovies = cmboboxWatchedMovies.SelectedIndex
    End Sub

#End Region

#Region "Quality"

    Private Sub chkShowMovieQuality_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowMovieQuality.CheckedChanged
        My.Settings.doQualityOnPoster = chkShowMovieQuality.Checked
    End Sub

#End Region

#Region "Playback"

    Private Sub chckPlayFullscr_CheckedChanged(Sender As Object, e As EventArgs) Handles chckPlayFullscr.CheckedChanged
        My.Settings.doFullScr = chckPlayFullscr.Checked
    End Sub

#End Region

#Region "Features"

    Private Sub chckDownloadBtn_CheckedChanged(Sender As Object, e As EventArgs) Handles chckDownloadBtn.CheckedChanged
        My.Settings.doDownloadBtn = chckDownloadBtn.Checked
    End Sub

    Private Sub chckUserComments_CheckedChanged(Sender As Object, e As EventArgs) Handles chckUserComments.CheckedChanged
        My.Settings.doUserComments = chckUserComments.Checked
    End Sub

#End Region

#Region "Database"

    Private Sub chckBackupDb_CheckedChanged(sender As Object, e As EventArgs) Handles chckBackupDb.CheckedChanged
        My.Settings.doBackupDb = chckBackupDb.Checked
    End Sub

    Private Sub btnDbExport_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnDbExport.ClickButtonArea
        Dim ab As New SaveFileDialog
        If ab.ShowDialog = DialogResult.OK Then
            Try
                Movieo.NetDl.DownloadFile(Movieo.linkMovieDatabase, ab.FileName)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub imgOpenFolder_Click(Sender As Object, e As EventArgs) Handles imgOpenFolder.Click
        Movieo.ShowFile(txtDbDir.Text)
    End Sub

    Private Sub imgOpenFolder_MouseMove(Sender As Object, e As MouseEventArgs) Handles imgOpenFolder.MouseMove
        imgOpenFolder.Image = My.Resources.BrowseIconH
    End Sub

    Private Sub imgOpenFolder_MouseLeave(Sender As Object, e As EventArgs) Handles imgOpenFolder.MouseLeave
        imgOpenFolder.Image = My.Resources.BrowseIconL
    End Sub

#End Region

#Region "Miscellaneous"

    Private Sub chckAutoUpdate_CheckedChanged(Sender As Object, e As EventArgs) Handles chckAutoUpdate.CheckedChanged
        My.Settings.doAutoUpdate = chckAutoUpdate.Checked
    End Sub

#End Region

#Region "Save Settings / Reset Settings / Flush Databases"

    Private Sub btnSaveSettings_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnSaveSettings.ClickButtonArea
        My.Settings.Save()
        showNotification("✔ Your settings have been saved.")
    End Sub

    Private Sub btnResetSettings_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnResetSettings.ClickButtonArea
        If Movieo.ShowPopupYesNo("Confirmation", "Are you sure you want to reset all your settings to default?", Me) = MsgBoxResult.Yes Then
            My.Settings.Reset()
            showNotification("Settings restored to default.")
            If Movieo.ShowPopupYesNo("Restart Required", "You may need to restart Movieo for some settings to take effect. Restart now?", Me) = MsgBoxStyle.YesNo Then
                Application.Restart()
            End If
        End If
    End Sub

    Private Sub btnResetAllDatabases_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnResetAllDatabases.ClickButtonArea
        If Movieo.ShowPopupYesNo("Confirmation", "Are you sure you want to delete all movies in your library? You will not be able to recover them.", Me) = MsgBoxResult.Yes Then
            Movieo.CreateEmptyListFiles()
            showNotification("Your library have been wiped.")
            Movieo.ShowPopupOk("Restart Required", "You must restart Movieo to apply these changes.", Me)
            Application.Restart()
        End If
    End Sub

#End Region

#Region "Highlight Buttons"

    Private Sub HighlightButtons_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnSaveSettings.MouseMove, btnResetSettings.MouseMove, btnResetAllDatabases.MouseMove, btnDbExport.MouseMove
        Sender.ForeColor = Color.White
        Sender.BorderColor = Color.White
        Sender.ColorFillSolid = Color.FromArgb(52, 59, 71)
    End Sub

    Private Sub HighlightButtons_MouseLeave(sender As Object, e As EventArgs) Handles btnSaveSettings.MouseLeave, btnResetSettings.MouseLeave, btnResetAllDatabases.MouseLeave, btnDbExport.MouseLeave
        sender.ForeColor = Color.FromArgb(172, 180, 191)
        sender.BorderColor = Color.FromArgb(172, 180, 191)
        sender.ColorFillSolid = Color.Transparent
    End Sub

#End Region

#Region "Notification Message"

    Private Sub HideSettingsConfirmation_Tick(sender As Object, e As EventArgs) Handles timerHideNotifications.Tick
        lblSuccessText.Visible = False
        timerHideNotifications.Enabled = False
    End Sub

    Private Sub HideSettingsConfirmation_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles lblSuccessText.ClickButtonArea
        lblSuccessText.Visible = False
        timerHideNotifications.Enabled = False
    End Sub

    Public Sub showNotification(message As String)
        lblSuccessText.Text = message
        Dim myFont As New Font(lblSuccessText.Font.FontFamily, lblSuccessText.Font.Size)
        Dim mySize = lblSuccessText.CreateGraphics.MeasureString(message, myFont)
        lblSuccessText.Width = CType(Math.Round(mySize.Width, 0), Integer) + 20
        lblSuccessText.Height = CType(Math.Round(mySize.Height, 0), Integer) + 14
        lblSuccessText.Location = New Point((ClientSize.Width - lblSuccessText.Width) \ 2, -1)
        lblSuccessText.Visible = True
        lblSuccessText.Visible = True
        timerHideNotifications.Enabled = True
    End Sub

#End Region

End Class