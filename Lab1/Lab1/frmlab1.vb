Public Class frmlab1

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click

    End Sub
    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub
    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub
    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub
    Private Sub frmlab1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles lblsalaryperyear.Click, lblNetsalary.Click, lbltax.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculat.Click
        Dim salary, salaryperyear, tax As Double
        salary = txtSalary.Text
        salary = Val(salary * 12)

        salaryperyear = Val(salary * 5) / 100

        tax = Val(salary) - Val(salaryperyear)

        lblsalaryperyear.Text = salary
        lbltax.Text = salaryperyear
        lblNetsalary.Text = tax
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
