Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Module Librerias

    Public Conexion As SqlConnection = New SqlConnection("Data Source=SERVER-BUSSINES\SQLIDEAL;Initial Catalog=CRM_Ideal;Persist Security Info=True;User ID=bussines;Password=Alliance2017*")
    'New SqlConnection("Data Source=DESKTOP-9E469F2\DEVELOPER;Initial Catalog=CRM_IDEAL;Persist Security Info=True;User ID=sa;Password=Ulquiorra10")
    Public Cmd As SqlCommand
    Public Query As String      'scrip utilizado en la consulta0
    Public Tabla As String      'tabla utilizada en la consulta
    Public Id_Bus, Id_Moral As String     'resultado de busqueda
    Public Menu As String       'opciones del menu
    Public Activar As String    'Activar opciones del programa hijo
    Public Vendedor As String   'El id del vendedor
    Public Permiso, IdUsu As String   'El tipo de permiso para el usuario
    Public Actividad As String  'El nombre de la actividad


    Public Sub AsignarPermiso()

    End Sub

    Public Class Conexion_Dt
        Public Da As SqlDataAdapter = New SqlDataAdapter
        Public Dt As DataTable = New DataTable()

        Public Sub conectar()
            Try
                Conexion.Open()
            Catch ex As Exception
                MessageBox.Show("ERROR AL CONECTAR")
            Finally
                Conexion.Close()
            End Try
        End Sub
        Public Sub desconectarse()
            Try
                Conexion.Close()
                Da.Dispose()
                Dt.Clear()

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

        Public Sub LlenarGrilla(ByVal Sql As String, ByVal Tabla As String)
            Try
                Dt.Clear()
                Da = New SqlDataAdapter(Sql, Conexion)
                Da.Fill(Dt)
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                Conexion.Close()
            End Try
        End Sub
    End Class

    Public Class Conexion_Ds
        Private Cmb As SqlCommandBuilder
        Public Ds As DataSet = New DataSet()
        Public Da As SqlDataAdapter

        Public Sub conectar()
            Try
                Conexion.Open()
            Catch ex As Exception
                MessageBox.Show("ERROR AL CONECTAR")
            Finally
                Conexion.Close()
            End Try
        End Sub

        Public Sub Consultar(ByVal Sql As String, ByVal Tabla As String)
            Ds.Tables.Clear()
            Da = New SqlDataAdapter(Sql, Conexion)
            Cmb = New SqlCommandBuilder(Da)
            Da.Fill(Ds, Tabla)
        End Sub

        Function Insertar(ByVal sql)
            Conexion.Open()
            Cmd = New SqlCommand(sql, Conexion)
            Dim i As Integer = Cmd.ExecuteNonQuery
            Conexion.Close()
            If (i > 0) Then
                Return True
            Else
                Return False
            End If
        End Function

        Function Actualizar(ByVal Tabla, ByVal Campos, ByVal Condicion)
            Conexion.Open()
            Dim Actualiza As String = "Update " + Tabla + " Set " + Campos + " Where " + Condicion
            Cmd = New SqlCommand(Actualiza, Conexion)
            Dim i As Integer = Cmd.ExecuteNonQuery
            Conexion.Close()
            If (i > 0) Then
                Return True
            Else
                Return False
            End If
        End Function
    End Class

    Public Class Conexion_Dr
        Public dr As SqlClient.SqlDataReader

        Public Sub conectarse()
            Try
                Conexion.Open()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

        Public Sub desconectarse()
            Try
                Conexion.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

        Public Sub LlenarCombo(ByVal Sql As String, ByVal Cb As ComboBox)
            Try
                Conexion.Open()
                Cmd = New SqlCommand(Sql, Conexion)
                dr = Cmd.ExecuteReader()
                Cb.Items.Add("")
                While dr.Read
                    Cb.Items.Add(dr.Item(0))
                End While
                    dr.Close()
                    Conexion.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

        Public Sub Consultar(ByVal Sql As String)
            Try
                Conexion.Open()
                Cmd = New SqlCommand(Sql, Conexion)
                dr = Cmd.ExecuteReader()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

        Function Insertar(ByVal sql)
            Cmd = New SqlCommand(sql, Conexion)
            Dim i As Integer = Cmd.ExecuteNonQuery
            Conexion.Close()
            If (i > 0) Then
                Return True
            Else
                Return False
            End If
        End Function

        Function Actualizar(ByVal Tabla, ByVal Campos, ByVal Condicion)
            Dim Actualiza As String = "Update " + Tabla + " Set " + Campos + " Where " + Condicion
            Cmd = New SqlCommand(Actualiza, Conexion)
            Dim i As Integer = Cmd.ExecuteNonQuery
            Conexion.Close()
            If (i > 0) Then
                Return True
            Else
                Return False
            End If
        End Function
    End Class

    Sub CambiaColorDgv(ByVal Dvg As DataGridView)
        Try
            With Dvg
                .RowsDefaultCellStyle.BackColor = Color.LightBlue
                .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            End With
        Catch ex As Exception
        End Try
    End Sub

End Module
