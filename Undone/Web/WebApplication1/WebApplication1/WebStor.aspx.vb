﻿Public Class WebStor
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click
        Dim url As String = " "
        url = Request.ApplicationPath
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim url As String = " "
        url = Request.ApplicationPath
    End Sub
End Class