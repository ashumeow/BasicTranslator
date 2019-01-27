Imports System.ComponentModel
Imports System.Globalization
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        language_picker.Items.Add("English")
        language_picker.Items.Add("Arabic")
        language_picker.Items.Add("French (General)")
        language_picker.Items.Add("French (France)")
        language_picker.SelectedIndex = 1
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles language_picker.SelectedIndexChanged
        If language_picker.SelectedItem.ToString() = "English" Then
            ChangeLanguage("en")
            Me.AutoSize = True
        ElseIf language_picker.SelectedItem.ToString() = "French (General)" Then
            ChangeLanguage("fr-FR")
            Me.AutoSize = True
        ElseIf language_picker.SelectedItem.ToString() = "French (France)" Then
            ChangeLanguage("fr")
            Me.AutoSize = True
        ElseIf language_picker.SelectedItem.ToString() = "Arabic" Then
            ChangeLanguage("ar")
            Me.AutoSize = True
        Else
            ChangeLanguage("en")
            Me.AutoSize = True
        End If
    End Sub

    Private Sub ChangeLanguage(ByVal lang As String)
        For Each c As Control In Me.Controls
            Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(Form1))
            resources.ApplyResources(c, c.Name, New CultureInfo(lang))
        Next c
    End Sub

    Private Sub exit_button_Click(sender As Object, e As EventArgs) Handles exit_button.Click
        End
    End Sub
End Class
' Programmed By Aswini S