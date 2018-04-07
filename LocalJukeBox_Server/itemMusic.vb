Public Class itemMusic
    Public Property fileName As String = ""
    Public Property id As Integer = 0
    Public Property voteOK As Integer = 0
    Public Property voteNOK As Integer = 0

    Private _voteTotal As Integer
    ReadOnly Property voteTotal As Integer
        Get
            Return voteOK - voteNOK
        End Get
    End Property

    Public Sub resetVotes()
        voteOK = 0
        voteNOK = 0
    End Sub

End Class
