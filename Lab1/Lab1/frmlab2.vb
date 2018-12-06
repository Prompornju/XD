Public Class frmlab2

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtvis.TextChanged

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculat.Click
        Dim vis, com, sum, CommitionVistra, Commitioncomputer, Commition As Double
        vis = txtvis.Text
        com = txtCom.Text

        sum = vis + com

        CommitionVistra = Val(vis * 5) / 100
        Commitioncomputer = Val(com * 10) / 100

        lblSum.Text = sum
        lblCommitionVistra.Text = CommitionVistra
        lblCommitioncomputer.Text = Commitioncomputer
        lblCommition.Text = CommitionVistra + Commitioncomputer

    End Sub

    Private Sub frmlab2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class