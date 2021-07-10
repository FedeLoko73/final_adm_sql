Module Module1
    Public Const cadcon As String = "Data Source=DESKTOP-T1Q1K9P\SQLEXPRESS;Initial Catalog=farias_practica1;User ID=sa;Password=caterina"
    Public Sub ejecutarsql(ByVal sql As String)
        Dim Conexion As SqlClient.SqlConnection
        Dim Comando As SqlClient.SqlCommand
        Conexion = New SqlClient.SqlConnection()
        Conexion.ConnectionString = cadcon
        Conexion.Open()
        Comando = New SqlClient.SqlCommand()
        Comando.Connection = Conexion
        Comando.CommandType = CommandType.Text
        Comando.CommandText = sql
        Comando.ExecuteNonQuery()
    End Sub
    Public Sub recuperardatos(ByVal sql As String, ByRef tabla As DataTable)
        Dim Conexion As SqlClient.SqlConnection
        Dim Comando As SqlClient.SqlCommand
        Conexion = New SqlClient.SqlConnection()
        Conexion.ConnectionString = cadcon
        Conexion.Open()
        Comando = New SqlClient.SqlCommand()
        Comando.Connection = Conexion
        Comando.CommandType = CommandType.Text
        Comando.CommandText = sql
        tabla.Load(Comando.ExecuteReader)
    End Sub
    Public operacion As String = "Alta"
    Public legajobus As Integer
    Public codmateriabus As String


End Module
