Imports System.Data.SqlClient

Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Name As String = TextBox1.Text
        Dim Course As String = TextBox2.Text
        Dim City As String = TextBox3.Text

        Dim con As New SqlConnection()
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\WebApplication3\WebApplication3\App_Data\Database1.mdf;Integrated Security=True"

        Try
            con.Open()
            Console.WriteLine("Connection Success")

            Dim query As String = "insert into StudentInfo1 values ('" & Name & "','" & Course & "','" & City & "')"
            Dim cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            Console.WriteLine("Connection Success" + ex.Message)

        Finally
            Response.Redirect(Request.RawUrl)
        End Try
    End Sub
End Class