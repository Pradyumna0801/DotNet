Imports System.Data.SqlClient
Imports System.Reflection.Emit

Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ID As Int32 = TextBox1.Text
        Dim Name As String = TextBox2.Text
        Dim City As String = TextBox3.Text

        Dim con As New SqlConnection()
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\WebApplication2\WebApplication2\App_Data\Database1.mdf;Integrated Security=True"

        Try
            con.Open()
            Console.WriteLine("Connection success")
            Label4.Text = "Connection Success"
            Dim query As String = "insert into StudentInfo values('" & ID & "','" & Name & "','" & City & "')"
            Dim cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()

            Label4.Text = "Data inserted"

            con.Close()




        Catch ex As Exception
            Console.WriteLine("Connection Success" + ex.Message)
            Label4.Text = "data Not inserted" + ex.Message

        Finally
            Response.Redirect(Request.RawUrl)
        End Try






    End Sub
End Class