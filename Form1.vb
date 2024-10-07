Imports Oracle.ManagedDataAccess.Client

Public Class Form1

    Dim conn As OracleConnection

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Connection string to Oracle Database
        conn = New OracleConnection("User Id=sys;Password=sys;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=orcl)));DBA Privilege=SYSDBA;")


        Try
            ' Open the connection to the database
            conn.Open()

            ' If the connection is successful, show a message
            MessageBox.Show("Koneksi Berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            ' If the connection fails, show an error message
            MessageBox.Show("Koneksi Gagal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Close the connection if open
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

End Class
