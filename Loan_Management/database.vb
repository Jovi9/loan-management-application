Imports MySql.Data.MySqlClient

Public Class database

    ReadOnly str_con As String = ""
    ReadOnly con As New MySqlConnection(str_con)

    Public ReadOnly Property getDBCon()
        Get
            Return con
        End Get
    End Property

    Public Sub openConnection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Public Sub closeConnection()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub

End Class
