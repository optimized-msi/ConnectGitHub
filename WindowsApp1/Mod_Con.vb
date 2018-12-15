Imports System.Data.SqlClient



Friend Module Mod_Con
    Dim Con As SqlConnection
    Dim str As String = "127.0.0.1"
    Dim ds As DataSet
    Dim sql As String

    Public str As String
    Public cmd As New SqlCommand
    Public rd As SqlDataReader
    Public sqlConn As New SqlConnection

    Public varIP As String = "127.0.0.1"
    Public varDB As String = "htexfront"
    Public varUSR As String = "admin"
    Public varPWD As String = "1234"

    Sub ConDB()
        Try
            sqlConn = New SqlConnection("data source=" & varIP & ";initial catalog =" & varDB & ";user id =sa; password=" & varPWD)
            If sqlConn.State = ConnectionState.Closed Then
                sqlConn.Open()
            Else
                sqlConn.Close()
                sqlConn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(" ไม่สามารถติดต่อฐานข้อมูลได้ " & vbCrLf & Err.Description, "ERROR", MessageBoxButtons.OK)
            Exit Sub
        End Try
    End Sub

End Module
