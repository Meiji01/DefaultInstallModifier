Public Class frmdisclaim

    Public accepted As Boolean
    Public rejected As Boolean

    Private Sub frmdisclaim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.rejected = True
        Me.accepted = False
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Me.accepted = True
        Me.rejected = False
        Me.Close()
    End Sub

    Private Sub btnDecline_Click(sender As Object, e As EventArgs) Handles btnDecline.Click
        Me.accepted = False
        Me.rejected = True
        Me.Close()
    End Sub
End Class