﻿Public Class Form1
    Private Sub EndButton_Click(sender As Object, e As EventArgs) Handles EndButton.Click
        End
    End Sub

    Private Sub SpinButton_Click(sender As Object, e As EventArgs) Handles SpinButton.Click
        Dim generator As New Random

        CoinImage.Visible = False

        FirstNum.Text = generator.Next(0, 10)
        SecondNum.Text = generator.Next(0, 10)
        ThirdNum.Text = generator.Next(0, 10)

        If (FirstNum.Text = "7") Or (SecondNum.Text = "7") Or (ThirdNum.Text = "7") Then
            CoinImage.Visible = True
            My.Computer.Audio.Play(My.Resources.ArcadeRiff, AudioPlayMode.Background)
        End If
    End Sub
End Class
