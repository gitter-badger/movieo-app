﻿Public Class PopupBackground
    Private Sub FadeBackground_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Me.Size = New Size(Odeum_Movies.Size)
    End Sub
End Class