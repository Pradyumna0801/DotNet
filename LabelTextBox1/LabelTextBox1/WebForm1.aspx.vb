Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim q As Integer = Convert.ToInt32(TextBox2.Text)
        Dim r As Integer = Convert.ToInt32(TextBox3.Text)
        Dim am As Integer = q * r
        TextBox4.Text = am
        Dim dis As Integer = am * 10 / 100
        TextBox5.Text = dis

        Dim na As Integer = am - dis
        TextBox6.Text = na


    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""




    End Sub
End Class