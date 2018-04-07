﻿Imports System.Xml

Public Class Form1

    Dim WithEvents myPlayer As WMPLib.WindowsMediaPlayer
    Dim myMusicList As List(Of itemMusic)
    Dim myHashMap As Dictionary(Of Integer, Integer)

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

        myPlayer = New WMPLib.WindowsMediaPlayer
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        ReadXmlFile(txt1.Text)
    End Sub

    Sub LaunchMusic(row As DataGridViewRow)
        Dim myItemMusic As itemMusic
        Dim indexInList As Integer = -1
        myPlayer.controls.stop()
        myItemMusic = TryCast(row.DataBoundItem, itemMusic)

        MsgBox(myItemMusic.fileName)
        myPlayer.URL = myItemMusic.fileName
        myPlayer.controls.play()

        If myHashMap.TryGetValue(myItemMusic.id, indexInList) Then
            myItemMusic.resetVotes()
            myMusicList.Item(indexInList - 1) = myItemMusic
            Me.ItemMusicBindingSource.ResetBindings(True)
        Else
            MsgBox("Error")
        End If
    End Sub

    Private Sub myPlayer_MediaError(ByVal pMediaObject As Object) Handles myPlayer.MediaError
        MessageBox.Show("Cannot play media file.")
    End Sub

    Private Sub myPlayer_PlayStateChange(ByVal NewState As Integer) Handles myPlayer.PlayStateChange
        If NewState = WMPLib.WMPPlayState.wmppsStopped Then
            MsgBox("Fichier terminé.")
        End If
    End Sub

    Private Sub ReadXmlFile(fullPath As String)
        Dim xmlDoc As New XmlDocument()
        Dim nodes As XmlNodeList
        Dim musicItem As itemMusic

        myMusicList = New List(Of itemMusic)
        myHashMap = New Dictionary(Of Integer, Integer)
        xmlDoc.Load(fullPath)
        nodes = xmlDoc.DocumentElement.SelectNodes("/MusicList/Music")

        For Each node As XmlNode In nodes
            musicItem = New itemMusic
            musicItem.id = node.SelectSingleNode("id").InnerText
            musicItem.fileName = node.SelectSingleNode("fileName").InnerText
            musicItem.voteOK = musicItem.id
            myMusicList.Add(musicItem)
            myHashMap.Add(musicItem.id, myMusicList.Count)
        Next
        Me.ItemMusicBindingSource.DataSource = myMusicList

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        LaunchMusic(Me.DataGridView1.Rows(e.RowIndex))
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Select Case myPlayer.playState
            Case WMPLib.WMPPlayState.wmppsPlaying
                myPlayer.controls.pause()

            Case Else
                myPlayer.controls.play()

        End Select

    End Sub
End Class
