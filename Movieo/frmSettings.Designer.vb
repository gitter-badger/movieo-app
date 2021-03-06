﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.Splitter1g = New System.Windows.Forms.Label()
        Me.chckBackupDb = New System.Windows.Forms.CheckBox()
        Me.txtDbDir = New System.Windows.Forms.TextBox()
        Me.chckUserComments = New System.Windows.Forms.CheckBox()
        Me.chckAutoUpdate = New System.Windows.Forms.CheckBox()
        Me.lblHeaderMisc = New System.Windows.Forms.Label()
        Me.Splitter1f = New System.Windows.Forms.Label()
        Me.lblHeaderDb = New System.Windows.Forms.Label()
        Me.Splitter1d = New System.Windows.Forms.Label()
        Me.chckDownloadBtn = New System.Windows.Forms.CheckBox()
        Me.lblSettingsFeatures = New System.Windows.Forms.Label()
        Me.Splitter1c = New System.Windows.Forms.Label()
        Me.chckPlayFullscr = New System.Windows.Forms.CheckBox()
        Me.lblHeaderPlayBck = New System.Windows.Forms.Label()
        Me.cmboBoxWatchedMoviesPanel = New System.Windows.Forms.Panel()
        Me.cmboTxtWatchedMovies = New CButtonLib.CButton()
        Me.cmboboxWatchedMovies = New System.Windows.Forms.ComboBox()
        Me.lblHeaderGeneral = New System.Windows.Forms.Label()
        Me.Splitter1a = New System.Windows.Forms.Label()
        Me.lblWatchedMovies = New System.Windows.Forms.Label()
        Me.lblSettings = New System.Windows.Forms.Label()
        Me.Splitter1b = New System.Windows.Forms.Label()
        Me.lblDbDir = New System.Windows.Forms.Label()
        Me.timerHideNotifications = New System.Windows.Forms.Timer(Me.components)
        Me.chkAlwaysOnTop = New System.Windows.Forms.CheckBox()
        Me.chkShowRating = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkShowMovieQuality = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSuccessText = New CButtonLib.CButton()
        Me.btnResetAllDatabases = New CButtonLib.CButton()
        Me.btnResetSettings = New CButtonLib.CButton()
        Me.btnSaveSettings = New CButtonLib.CButton()
        Me.btnDbExport = New CButtonLib.CButton()
        Me.txtDbDirBg = New CButtonLib.CButton()
        Me.MeClose = New System.Windows.Forms.PictureBox()
        Me.imgOpenFolder = New System.Windows.Forms.PictureBox()
        Me.cmboBoxWatchedMoviesPanel.SuspendLayout()
        CType(Me.MeClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgOpenFolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Splitter1g
        '
        Me.Splitter1g.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Splitter1g.AutoSize = True
        Me.Splitter1g.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Splitter1g.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Splitter1g.Location = New System.Drawing.Point(161, 1297)
        Me.Splitter1g.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1g.MinimumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1g.Name = "Splitter1g"
        Me.Splitter1g.Size = New System.Drawing.Size(750, 32)
        Me.Splitter1g.TabIndex = 100000000
        Me.Splitter1g.Text = "-------------------------------------------------------------------------"
        '
        'chckBackupDb
        '
        Me.chckBackupDb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chckBackupDb.AutoSize = True
        Me.chckBackupDb.Checked = True
        Me.chckBackupDb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chckBackupDb.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckBackupDb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.chckBackupDb.Location = New System.Drawing.Point(170, 998)
        Me.chckBackupDb.Name = "chckBackupDb"
        Me.chckBackupDb.Size = New System.Drawing.Size(194, 25)
        Me.chckBackupDb.TabIndex = 7
        Me.chckBackupDb.Text = "Create backup database"
        Me.chckBackupDb.UseVisualStyleBackColor = True
        '
        'txtDbDir
        '
        Me.txtDbDir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDbDir.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtDbDir.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDbDir.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtDbDir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtDbDir.Location = New System.Drawing.Point(400, 1041)
        Me.txtDbDir.Name = "txtDbDir"
        Me.txtDbDir.ReadOnly = True
        Me.txtDbDir.Size = New System.Drawing.Size(396, 19)
        Me.txtDbDir.TabIndex = 8
        '
        'chckUserComments
        '
        Me.chckUserComments.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chckUserComments.AutoSize = True
        Me.chckUserComments.Checked = True
        Me.chckUserComments.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chckUserComments.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckUserComments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.chckUserComments.Location = New System.Drawing.Point(170, 852)
        Me.chckUserComments.Name = "chckUserComments"
        Me.chckUserComments.Size = New System.Drawing.Size(179, 25)
        Me.chckUserComments.TabIndex = 6
        Me.chckUserComments.Text = "Show user comments"
        Me.chckUserComments.UseVisualStyleBackColor = True
        '
        'chckAutoUpdate
        '
        Me.chckAutoUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chckAutoUpdate.AutoSize = True
        Me.chckAutoUpdate.Checked = True
        Me.chckAutoUpdate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chckAutoUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckAutoUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.chckAutoUpdate.Location = New System.Drawing.Point(171, 1252)
        Me.chckAutoUpdate.Name = "chckAutoUpdate"
        Me.chckAutoUpdate.Size = New System.Drawing.Size(229, 25)
        Me.chckAutoUpdate.TabIndex = 17
        Me.chckAutoUpdate.Text = "Check for updates on startup"
        Me.chckAutoUpdate.UseVisualStyleBackColor = True
        '
        'lblHeaderMisc
        '
        Me.lblHeaderMisc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblHeaderMisc.AutoSize = True
        Me.lblHeaderMisc.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderMisc.ForeColor = System.Drawing.Color.White
        Me.lblHeaderMisc.Location = New System.Drawing.Point(165, 1200)
        Me.lblHeaderMisc.MaximumSize = New System.Drawing.Size(750, 0)
        Me.lblHeaderMisc.MinimumSize = New System.Drawing.Size(750, 0)
        Me.lblHeaderMisc.Name = "lblHeaderMisc"
        Me.lblHeaderMisc.Size = New System.Drawing.Size(750, 30)
        Me.lblHeaderMisc.TabIndex = 100000000
        Me.lblHeaderMisc.Text = "Miscellaneous"
        '
        'Splitter1f
        '
        Me.Splitter1f.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Splitter1f.AutoSize = True
        Me.Splitter1f.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Splitter1f.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Splitter1f.Location = New System.Drawing.Point(161, 1147)
        Me.Splitter1f.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1f.MinimumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1f.Name = "Splitter1f"
        Me.Splitter1f.Size = New System.Drawing.Size(750, 32)
        Me.Splitter1f.TabIndex = 100000000
        Me.Splitter1f.Text = "-------------------------------------------------------------------------"
        '
        'lblHeaderDb
        '
        Me.lblHeaderDb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblHeaderDb.AutoSize = True
        Me.lblHeaderDb.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderDb.ForeColor = System.Drawing.Color.White
        Me.lblHeaderDb.Location = New System.Drawing.Point(165, 951)
        Me.lblHeaderDb.MaximumSize = New System.Drawing.Size(750, 0)
        Me.lblHeaderDb.MinimumSize = New System.Drawing.Size(750, 0)
        Me.lblHeaderDb.Name = "lblHeaderDb"
        Me.lblHeaderDb.Size = New System.Drawing.Size(750, 30)
        Me.lblHeaderDb.TabIndex = 100000000
        Me.lblHeaderDb.Text = "Database"
        '
        'Splitter1d
        '
        Me.Splitter1d.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Splitter1d.AutoSize = True
        Me.Splitter1d.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Splitter1d.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Splitter1d.Location = New System.Drawing.Point(161, 900)
        Me.Splitter1d.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1d.MinimumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1d.Name = "Splitter1d"
        Me.Splitter1d.Size = New System.Drawing.Size(750, 32)
        Me.Splitter1d.TabIndex = 100000000
        Me.Splitter1d.Text = "-------------------------------------------------------------------------"
        '
        'chckDownloadBtn
        '
        Me.chckDownloadBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chckDownloadBtn.AutoSize = True
        Me.chckDownloadBtn.Checked = True
        Me.chckDownloadBtn.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chckDownloadBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckDownloadBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.chckDownloadBtn.Location = New System.Drawing.Point(170, 811)
        Me.chckDownloadBtn.Name = "chckDownloadBtn"
        Me.chckDownloadBtn.Size = New System.Drawing.Size(228, 25)
        Me.chckDownloadBtn.TabIndex = 5
        Me.chckDownloadBtn.Text = "Download button for movies"
        Me.chckDownloadBtn.UseVisualStyleBackColor = True
        '
        'lblSettingsFeatures
        '
        Me.lblSettingsFeatures.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSettingsFeatures.AutoSize = True
        Me.lblSettingsFeatures.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettingsFeatures.ForeColor = System.Drawing.Color.White
        Me.lblSettingsFeatures.Location = New System.Drawing.Point(165, 761)
        Me.lblSettingsFeatures.MaximumSize = New System.Drawing.Size(750, 0)
        Me.lblSettingsFeatures.MinimumSize = New System.Drawing.Size(750, 0)
        Me.lblSettingsFeatures.Name = "lblSettingsFeatures"
        Me.lblSettingsFeatures.Size = New System.Drawing.Size(750, 30)
        Me.lblSettingsFeatures.TabIndex = 100000000
        Me.lblSettingsFeatures.Text = "Features"
        '
        'Splitter1c
        '
        Me.Splitter1c.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Splitter1c.AutoSize = True
        Me.Splitter1c.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Splitter1c.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Splitter1c.Location = New System.Drawing.Point(161, 706)
        Me.Splitter1c.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1c.MinimumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1c.Name = "Splitter1c"
        Me.Splitter1c.Size = New System.Drawing.Size(750, 32)
        Me.Splitter1c.TabIndex = 100000000
        Me.Splitter1c.Text = "-------------------------------------------------------------------------"
        '
        'chckPlayFullscr
        '
        Me.chckPlayFullscr.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chckPlayFullscr.AutoSize = True
        Me.chckPlayFullscr.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckPlayFullscr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.chckPlayFullscr.Location = New System.Drawing.Point(169, 656)
        Me.chckPlayFullscr.Name = "chckPlayFullscr"
        Me.chckPlayFullscr.Size = New System.Drawing.Size(256, 25)
        Me.chckPlayFullscr.TabIndex = 4
        Me.chckPlayFullscr.Text = "Always start playing in fullscreen"
        Me.chckPlayFullscr.UseVisualStyleBackColor = True
        '
        'lblHeaderPlayBck
        '
        Me.lblHeaderPlayBck.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblHeaderPlayBck.AutoSize = True
        Me.lblHeaderPlayBck.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderPlayBck.ForeColor = System.Drawing.Color.White
        Me.lblHeaderPlayBck.Location = New System.Drawing.Point(165, 604)
        Me.lblHeaderPlayBck.MaximumSize = New System.Drawing.Size(750, 0)
        Me.lblHeaderPlayBck.MinimumSize = New System.Drawing.Size(750, 0)
        Me.lblHeaderPlayBck.Name = "lblHeaderPlayBck"
        Me.lblHeaderPlayBck.Size = New System.Drawing.Size(750, 30)
        Me.lblHeaderPlayBck.TabIndex = 100000000
        Me.lblHeaderPlayBck.Text = "Playback"
        '
        'cmboBoxWatchedMoviesPanel
        '
        Me.cmboBoxWatchedMoviesPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmboBoxWatchedMoviesPanel.BackColor = System.Drawing.Color.Transparent
        Me.cmboBoxWatchedMoviesPanel.Controls.Add(Me.cmboTxtWatchedMovies)
        Me.cmboBoxWatchedMoviesPanel.Location = New System.Drawing.Point(401, 345)
        Me.cmboBoxWatchedMoviesPanel.Name = "cmboBoxWatchedMoviesPanel"
        Me.cmboBoxWatchedMoviesPanel.Size = New System.Drawing.Size(135, 31)
        Me.cmboBoxWatchedMoviesPanel.TabIndex = 100000004
        '
        'cmboTxtWatchedMovies
        '
        Me.cmboTxtWatchedMovies.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmboTxtWatchedMovies.BackColor = System.Drawing.Color.Transparent
        Me.cmboTxtWatchedMovies.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cmboTxtWatchedMovies.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cmboTxtWatchedMovies.Corners.All = 2
        Me.cmboTxtWatchedMovies.Corners.LowerLeft = 2
        Me.cmboTxtWatchedMovies.Corners.LowerRight = 2
        Me.cmboTxtWatchedMovies.Corners.UpperLeft = 2
        Me.cmboTxtWatchedMovies.Corners.UpperRight = 2
        Me.cmboTxtWatchedMovies.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmboTxtWatchedMovies.DesignerSelected = False
        Me.cmboTxtWatchedMovies.DimFactorClick = 0
        Me.cmboTxtWatchedMovies.DimFactorHover = 0
        Me.cmboTxtWatchedMovies.FillType = CButtonLib.CButton.eFillType.Solid
        Me.cmboTxtWatchedMovies.FocalPoints.CenterPtX = 0!
        Me.cmboTxtWatchedMovies.FocalPoints.CenterPtY = 0!
        Me.cmboTxtWatchedMovies.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.cmboTxtWatchedMovies.ImageIndex = 0
        Me.cmboTxtWatchedMovies.Location = New System.Drawing.Point(0, 0)
        Me.cmboTxtWatchedMovies.Name = "cmboTxtWatchedMovies"
        Me.cmboTxtWatchedMovies.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.cmboTxtWatchedMovies.SideImage = CType(resources.GetObject("cmboTxtWatchedMovies.SideImage"), System.Drawing.Image)
        Me.cmboTxtWatchedMovies.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmboTxtWatchedMovies.SideImageSize = New System.Drawing.Size(17, 18)
        Me.cmboTxtWatchedMovies.Size = New System.Drawing.Size(134, 30)
        Me.cmboTxtWatchedMovies.TabIndex = 3
        Me.cmboTxtWatchedMovies.Text = "Fade"
        Me.cmboTxtWatchedMovies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmboTxtWatchedMovies.TextMargin = New System.Windows.Forms.Padding(4, 2, 2, 2)
        Me.cmboTxtWatchedMovies.TextShadow = System.Drawing.Color.White
        Me.cmboTxtWatchedMovies.TextShadowShow = False
        '
        'cmboboxWatchedMovies
        '
        Me.cmboboxWatchedMovies.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmboboxWatchedMovies.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmboboxWatchedMovies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboboxWatchedMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmboboxWatchedMovies.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.cmboboxWatchedMovies.ForeColor = System.Drawing.Color.White
        Me.cmboboxWatchedMovies.FormattingEnabled = True
        Me.cmboboxWatchedMovies.Items.AddRange(New Object() {"Fade", "Hide", "Show"})
        Me.cmboboxWatchedMovies.Location = New System.Drawing.Point(401, 349)
        Me.cmboboxWatchedMovies.Name = "cmboboxWatchedMovies"
        Me.cmboboxWatchedMovies.Size = New System.Drawing.Size(134, 27)
        Me.cmboboxWatchedMovies.TabIndex = 100000003
        Me.cmboboxWatchedMovies.TabStop = False
        Me.cmboboxWatchedMovies.Visible = False
        '
        'lblHeaderGeneral
        '
        Me.lblHeaderGeneral.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblHeaderGeneral.AutoSize = True
        Me.lblHeaderGeneral.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderGeneral.ForeColor = System.Drawing.Color.White
        Me.lblHeaderGeneral.Location = New System.Drawing.Point(163, 203)
        Me.lblHeaderGeneral.MaximumSize = New System.Drawing.Size(750, 0)
        Me.lblHeaderGeneral.MinimumSize = New System.Drawing.Size(750, 0)
        Me.lblHeaderGeneral.Name = "lblHeaderGeneral"
        Me.lblHeaderGeneral.Size = New System.Drawing.Size(750, 30)
        Me.lblHeaderGeneral.TabIndex = 100000000
        Me.lblHeaderGeneral.Text = "General"
        '
        'Splitter1a
        '
        Me.Splitter1a.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Splitter1a.AutoSize = True
        Me.Splitter1a.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Splitter1a.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Splitter1a.Location = New System.Drawing.Point(160, 152)
        Me.Splitter1a.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1a.MinimumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1a.Name = "Splitter1a"
        Me.Splitter1a.Size = New System.Drawing.Size(750, 32)
        Me.Splitter1a.TabIndex = 100000000
        Me.Splitter1a.Text = "-------------------------------------------------------------------------"
        '
        'lblWatchedMovies
        '
        Me.lblWatchedMovies.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblWatchedMovies.AutoSize = True
        Me.lblWatchedMovies.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWatchedMovies.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblWatchedMovies.Location = New System.Drawing.Point(165, 348)
        Me.lblWatchedMovies.MaximumSize = New System.Drawing.Size(750, 0)
        Me.lblWatchedMovies.MinimumSize = New System.Drawing.Size(750, 0)
        Me.lblWatchedMovies.Name = "lblWatchedMovies"
        Me.lblWatchedMovies.Size = New System.Drawing.Size(750, 21)
        Me.lblWatchedMovies.TabIndex = 100000000
        Me.lblWatchedMovies.Text = "Watched movies"
        '
        'lblSettings
        '
        Me.lblSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSettings.AutoSize = True
        Me.lblSettings.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSettings.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettings.ForeColor = System.Drawing.Color.White
        Me.lblSettings.Location = New System.Drawing.Point(468, 96)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(141, 45)
        Me.lblSettings.TabIndex = 100000000
        Me.lblSettings.Text = "Settings"
        '
        'Splitter1b
        '
        Me.Splitter1b.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Splitter1b.AutoSize = True
        Me.Splitter1b.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Splitter1b.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Splitter1b.Location = New System.Drawing.Point(160, 393)
        Me.Splitter1b.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1b.MinimumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1b.Name = "Splitter1b"
        Me.Splitter1b.Size = New System.Drawing.Size(750, 32)
        Me.Splitter1b.TabIndex = 100000008
        Me.Splitter1b.Text = "-------------------------------------------------------------------------"
        '
        'lblDbDir
        '
        Me.lblDbDir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDbDir.AutoSize = True
        Me.lblDbDir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDbDir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblDbDir.Location = New System.Drawing.Point(165, 1040)
        Me.lblDbDir.MaximumSize = New System.Drawing.Size(750, 0)
        Me.lblDbDir.MinimumSize = New System.Drawing.Size(750, 0)
        Me.lblDbDir.Name = "lblDbDir"
        Me.lblDbDir.Size = New System.Drawing.Size(750, 21)
        Me.lblDbDir.TabIndex = 100000000
        Me.lblDbDir.Text = "Database Directory"
        '
        'timerHideNotifications
        '
        Me.timerHideNotifications.Interval = 4000
        '
        'chkAlwaysOnTop
        '
        Me.chkAlwaysOnTop.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkAlwaysOnTop.AutoSize = True
        Me.chkAlwaysOnTop.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAlwaysOnTop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.chkAlwaysOnTop.Location = New System.Drawing.Point(168, 257)
        Me.chkAlwaysOnTop.Name = "chkAlwaysOnTop"
        Me.chkAlwaysOnTop.Size = New System.Drawing.Size(127, 25)
        Me.chkAlwaysOnTop.TabIndex = 100000057
        Me.chkAlwaysOnTop.Text = "Always on top"
        Me.chkAlwaysOnTop.UseVisualStyleBackColor = True
        '
        'chkShowRating
        '
        Me.chkShowRating.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkShowRating.AutoSize = True
        Me.chkShowRating.Checked = True
        Me.chkShowRating.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowRating.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowRating.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.chkShowRating.Location = New System.Drawing.Point(168, 302)
        Me.chkShowRating.Name = "chkShowRating"
        Me.chkShowRating.Size = New System.Drawing.Size(190, 25)
        Me.chkShowRating.TabIndex = 100000058
        Me.chkShowRating.Text = "Show rating on posters"
        Me.chkShowRating.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(161, 549)
        Me.Label1.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Label1.MinimumSize = New System.Drawing.Size(750, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(750, 32)
        Me.Label1.TabIndex = 100000060
        Me.Label1.Text = "-------------------------------------------------------------------------"
        '
        'chkShowMovieQuality
        '
        Me.chkShowMovieQuality.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkShowMovieQuality.AutoSize = True
        Me.chkShowMovieQuality.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowMovieQuality.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.chkShowMovieQuality.Location = New System.Drawing.Point(171, 499)
        Me.chkShowMovieQuality.Name = "chkShowMovieQuality"
        Me.chkShowMovieQuality.Size = New System.Drawing.Size(212, 25)
        Me.chkShowMovieQuality.TabIndex = 100000059
        Me.chkShowMovieQuality.Text = "Show movie quality on list"
        Me.chkShowMovieQuality.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(163, 447)
        Me.Label2.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Label2.MinimumSize = New System.Drawing.Size(750, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(750, 30)
        Me.Label2.TabIndex = 100000061
        Me.Label2.Text = "Quality"
        '
        'lblSuccessText
        '
        Me.lblSuccessText.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSuccessText.BorderColor = System.Drawing.Color.Transparent
        Me.lblSuccessText.ColorFillSolid = System.Drawing.Color.Transparent
        Me.lblSuccessText.Corners.All = 2
        Me.lblSuccessText.Corners.LowerLeft = 2
        Me.lblSuccessText.Corners.LowerRight = 2
        Me.lblSuccessText.Corners.UpperLeft = 2
        Me.lblSuccessText.Corners.UpperRight = 2
        Me.lblSuccessText.DesignerSelected = False
        Me.lblSuccessText.DimFactorClick = 0
        Me.lblSuccessText.DimFactorHover = 0
        Me.lblSuccessText.FillType = CButtonLib.CButton.eFillType.Solid
        Me.lblSuccessText.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!)
        Me.lblSuccessText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblSuccessText.ImageIndex = 0
        Me.lblSuccessText.Location = New System.Drawing.Point(527, 1333)
        Me.lblSuccessText.Name = "lblSuccessText"
        Me.lblSuccessText.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.lblSuccessText.Size = New System.Drawing.Size(372, 35)
        Me.lblSuccessText.TabIndex = 22
        Me.lblSuccessText.Text = "✔ Your settings have been saved."
        Me.lblSuccessText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSuccessText.TextShadowShow = False
        Me.lblSuccessText.Visible = False
        '
        'btnResetAllDatabases
        '
        Me.btnResetAllDatabases.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnResetAllDatabases.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnResetAllDatabases.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnResetAllDatabases.Corners.All = 2
        Me.btnResetAllDatabases.Corners.LowerLeft = 2
        Me.btnResetAllDatabases.Corners.LowerRight = 2
        Me.btnResetAllDatabases.Corners.UpperLeft = 2
        Me.btnResetAllDatabases.Corners.UpperRight = 2
        Me.btnResetAllDatabases.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResetAllDatabases.DesignerSelected = False
        Me.btnResetAllDatabases.DimFactorClick = 0
        Me.btnResetAllDatabases.DimFactorHover = 0
        Me.btnResetAllDatabases.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnResetAllDatabases.Font = New System.Drawing.Font("Segoe UI Semibold", 11.5!)
        Me.btnResetAllDatabases.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnResetAllDatabases.ImageIndex = 0
        Me.btnResetAllDatabases.Location = New System.Drawing.Point(171, 1332)
        Me.btnResetAllDatabases.Name = "btnResetAllDatabases"
        Me.btnResetAllDatabases.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnResetAllDatabases.Size = New System.Drawing.Size(131, 35)
        Me.btnResetAllDatabases.TabIndex = 21
        Me.btnResetAllDatabases.Text = "Flush Libraries"
        Me.btnResetAllDatabases.TextShadowShow = False
        '
        'btnResetSettings
        '
        Me.btnResetSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnResetSettings.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnResetSettings.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnResetSettings.Corners.All = 2
        Me.btnResetSettings.Corners.LowerLeft = 2
        Me.btnResetSettings.Corners.LowerRight = 2
        Me.btnResetSettings.Corners.UpperLeft = 2
        Me.btnResetSettings.Corners.UpperRight = 2
        Me.btnResetSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResetSettings.DesignerSelected = False
        Me.btnResetSettings.DimFactorClick = 0
        Me.btnResetSettings.DimFactorHover = 0
        Me.btnResetSettings.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnResetSettings.Font = New System.Drawing.Font("Segoe UI Semibold", 11.5!)
        Me.btnResetSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnResetSettings.ImageIndex = 0
        Me.btnResetSettings.Location = New System.Drawing.Point(308, 1332)
        Me.btnResetSettings.Name = "btnResetSettings"
        Me.btnResetSettings.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnResetSettings.Size = New System.Drawing.Size(144, 35)
        Me.btnResetSettings.TabIndex = 20
        Me.btnResetSettings.Text = "Restore Defaults"
        Me.btnResetSettings.TextShadowShow = False
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSaveSettings.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnSaveSettings.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnSaveSettings.Corners.All = 2
        Me.btnSaveSettings.Corners.LowerLeft = 2
        Me.btnSaveSettings.Corners.LowerRight = 2
        Me.btnSaveSettings.Corners.UpperLeft = 2
        Me.btnSaveSettings.Corners.UpperRight = 2
        Me.btnSaveSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveSettings.DesignerSelected = False
        Me.btnSaveSettings.DimFactorClick = 0
        Me.btnSaveSettings.DimFactorHover = 0
        Me.btnSaveSettings.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnSaveSettings.Font = New System.Drawing.Font("Segoe UI Semibold", 11.5!)
        Me.btnSaveSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnSaveSettings.ImageIndex = 0
        Me.btnSaveSettings.Location = New System.Drawing.Point(458, 1332)
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnSaveSettings.Size = New System.Drawing.Size(62, 35)
        Me.btnSaveSettings.TabIndex = 19
        Me.btnSaveSettings.Text = "Save"
        Me.btnSaveSettings.TextShadowShow = False
        '
        'btnDbExport
        '
        Me.btnDbExport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDbExport.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnDbExport.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnDbExport.Corners.All = 2
        Me.btnDbExport.Corners.LowerLeft = 2
        Me.btnDbExport.Corners.LowerRight = 2
        Me.btnDbExport.Corners.UpperLeft = 2
        Me.btnDbExport.Corners.UpperRight = 2
        Me.btnDbExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDbExport.DesignerSelected = False
        Me.btnDbExport.DimFactorClick = 0
        Me.btnDbExport.DimFactorHover = 0
        Me.btnDbExport.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnDbExport.Font = New System.Drawing.Font("Segoe UI Semibold", 11.5!)
        Me.btnDbExport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnDbExport.ImageIndex = 0
        Me.btnDbExport.Location = New System.Drawing.Point(169, 1088)
        Me.btnDbExport.Name = "btnDbExport"
        Me.btnDbExport.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnDbExport.Size = New System.Drawing.Size(142, 35)
        Me.btnDbExport.TabIndex = 9
        Me.btnDbExport.Text = "Export Database"
        Me.btnDbExport.TextShadowShow = False
        '
        'txtDbDirBg
        '
        Me.txtDbDirBg.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDbDirBg.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtDbDirBg.ColorFillSolid = System.Drawing.Color.Transparent
        Me.txtDbDirBg.Corners.All = 2
        Me.txtDbDirBg.Corners.LowerLeft = 2
        Me.txtDbDirBg.Corners.LowerRight = 2
        Me.txtDbDirBg.Corners.UpperLeft = 2
        Me.txtDbDirBg.Corners.UpperRight = 2
        Me.txtDbDirBg.DesignerSelected = False
        Me.txtDbDirBg.DimFactorClick = 0
        Me.txtDbDirBg.DimFactorHover = 0
        Me.txtDbDirBg.Enabled = False
        Me.txtDbDirBg.FillType = CButtonLib.CButton.eFillType.Solid
        Me.txtDbDirBg.ImageIndex = 0
        Me.txtDbDirBg.Location = New System.Drawing.Point(393, 1038)
        Me.txtDbDirBg.Name = "txtDbDirBg"
        Me.txtDbDirBg.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.txtDbDirBg.Size = New System.Drawing.Size(410, 26)
        Me.txtDbDirBg.TabIndex = 100000020
        Me.txtDbDirBg.TabStop = False
        Me.txtDbDirBg.Text = ""
        '
        'MeClose
        '
        Me.MeClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MeClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MeClose.Image = Global.Movieo.My.Resources.Resources.PopupCloseL
        Me.MeClose.Location = New System.Drawing.Point(1035, 12)
        Me.MeClose.Name = "MeClose"
        Me.MeClose.Size = New System.Drawing.Size(28, 28)
        Me.MeClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MeClose.TabIndex = 100000055
        Me.MeClose.TabStop = False
        '
        'imgOpenFolder
        '
        Me.imgOpenFolder.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.imgOpenFolder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgOpenFolder.Image = Global.Movieo.My.Resources.Resources.BrowseIconL
        Me.imgOpenFolder.Location = New System.Drawing.Point(812, 1042)
        Me.imgOpenFolder.Name = "imgOpenFolder"
        Me.imgOpenFolder.Size = New System.Drawing.Size(20, 18)
        Me.imgOpenFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgOpenFolder.TabIndex = 100000021
        Me.imgOpenFolder.TabStop = False
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(0, 70)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1109, 561)
        Me.Controls.Add(Me.cmboBoxWatchedMoviesPanel)
        Me.Controls.Add(Me.cmboboxWatchedMovies)
        Me.Controls.Add(Me.lblWatchedMovies)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkShowMovieQuality)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkShowRating)
        Me.Controls.Add(Me.chkAlwaysOnTop)
        Me.Controls.Add(Me.MeClose)
        Me.Controls.Add(Me.lblSuccessText)
        Me.Controls.Add(Me.Splitter1g)
        Me.Controls.Add(Me.btnResetAllDatabases)
        Me.Controls.Add(Me.btnResetSettings)
        Me.Controls.Add(Me.btnSaveSettings)
        Me.Controls.Add(Me.btnDbExport)
        Me.Controls.Add(Me.chckBackupDb)
        Me.Controls.Add(Me.txtDbDir)
        Me.Controls.Add(Me.txtDbDirBg)
        Me.Controls.Add(Me.chckUserComments)
        Me.Controls.Add(Me.chckAutoUpdate)
        Me.Controls.Add(Me.lblHeaderMisc)
        Me.Controls.Add(Me.Splitter1f)
        Me.Controls.Add(Me.lblHeaderDb)
        Me.Controls.Add(Me.Splitter1d)
        Me.Controls.Add(Me.chckDownloadBtn)
        Me.Controls.Add(Me.lblSettingsFeatures)
        Me.Controls.Add(Me.Splitter1c)
        Me.Controls.Add(Me.chckPlayFullscr)
        Me.Controls.Add(Me.lblHeaderPlayBck)
        Me.Controls.Add(Me.lblHeaderGeneral)
        Me.Controls.Add(Me.Splitter1a)
        Me.Controls.Add(Me.lblSettings)
        Me.Controls.Add(Me.imgOpenFolder)
        Me.Controls.Add(Me.lblDbDir)
        Me.Controls.Add(Me.Splitter1b)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSettings"
        Me.Opacity = 0.98R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.cmboBoxWatchedMoviesPanel.ResumeLayout(False)
        CType(Me.MeClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgOpenFolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Splitter1g As Label
    Friend WithEvents btnResetAllDatabases As CButtonLib.CButton
    Friend WithEvents btnResetSettings As CButtonLib.CButton
    Friend WithEvents btnSaveSettings As CButtonLib.CButton
    Friend WithEvents chckBackupDb As CheckBox
    Friend WithEvents txtDbDir As TextBox
    Friend WithEvents txtDbDirBg As CButtonLib.CButton
    Friend WithEvents chckUserComments As CheckBox
    Friend WithEvents chckAutoUpdate As CheckBox
    Friend WithEvents lblHeaderMisc As Label
    Friend WithEvents Splitter1f As Label
    Friend WithEvents lblHeaderDb As Label
    Friend WithEvents Splitter1d As Label
    Friend WithEvents chckDownloadBtn As CheckBox
    Friend WithEvents lblSettingsFeatures As Label
    Friend WithEvents Splitter1c As Label
    Friend WithEvents chckPlayFullscr As CheckBox
    Friend WithEvents lblHeaderPlayBck As Label
    Friend WithEvents cmboBoxWatchedMoviesPanel As Panel
    Friend WithEvents cmboTxtWatchedMovies As CButtonLib.CButton
    Friend WithEvents cmboboxWatchedMovies As ComboBox
    Friend WithEvents lblHeaderGeneral As Label
    Friend WithEvents Splitter1a As Label
    Friend WithEvents lblWatchedMovies As Label
    Friend WithEvents lblSettings As Label
    Friend WithEvents Splitter1b As Label
    Friend WithEvents imgOpenFolder As PictureBox
    Friend WithEvents lblDbDir As Label
    Friend WithEvents timerHideNotifications As Timer
    Friend WithEvents btnDbExport As CButtonLib.CButton
    Friend WithEvents MeClose As PictureBox
    Friend WithEvents chkAlwaysOnTop As CheckBox
    Friend WithEvents chkShowRating As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkShowMovieQuality As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSuccessText As CButtonLib.CButton
End Class
