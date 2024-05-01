Imports System.Data.SqlClient

Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        ' Replace with your connection string information
        Dim connectionString As String = "Data Source=LAPTOP-EJRMOJDJ\MSSQLSERVER01;Initial Catalog=Data1;Integrated Security=True"
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim queryString As String = "SELECT * FROM users"
        Dim dataAdapter As New SqlDataAdapter(queryString, connection)
        Dim dataTable As New DataTable()
        dataAdapter.Fill(dataTable)

        ' Bind the DataTable to the GridView
        GridView1.DataSource = dataTable
        GridView1.DataBind()


    End Sub


End Class