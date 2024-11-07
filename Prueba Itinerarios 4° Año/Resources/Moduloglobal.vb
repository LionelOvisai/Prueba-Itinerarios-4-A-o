Imports System.Data
Imports System.Data.OleDb
Module Moduloglobal
    'Public cone2 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lionel-Ovisai\source\repos\Prueba Itinerarios 4° Año\Prueba Itinerarios 4° Año\Examen4veo.accdb")
    Public conec1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Examen4veo.accdb")
    Public cmd As New OleDbCommand
    Public ds As New DataSet
    Public da As New OleDbDataAdapter(cmd)
    Public nombre As String
    Public res As Integer
    Public restext(1) As String
    Public pre As Integer
    Public recep3(3) As String
    Public res7(7) As Integer
    Public admin As Integer
    Public origin, verexa As Integer




    Sub conectar()
        Try
            cmd.Connection = conec1
            conec1.Open()


        Catch ex As Exception

            MsgBox("Error al conectar con base de datos")



        End Try

    End Sub
    Sub desconectar()
        Try
            conec1.Close()

        Catch ex As Exception
            MsgBox("error al Desconectar la Base de Datos")
        End Try
    End Sub
    Sub controldupli(apenom As String)
        If ds.Tables.Contains("dupli") Then
            ds.Tables.Remove("dupli")
        End If
        cmd.CommandText = "SELECT * FROM Alumnos WHERE Alumnos.Apenom = '" & apenom & "'"
        conectar()
        da.Fill(ds, "dupli")
        desconectar()
    End Sub
    Sub actual(Apenom As String)
        If ds.Tables.Contains("alumno") Then
            ds.Tables.Remove("alumno")
        End If
        cmd.CommandText = "SELECT a.Idal FROM Alumnos a WHERE a.Apenom = '" & Apenom & "'"
        conectar()
        da.Fill(ds, "alumno")
        desconectar()
    End Sub
    Sub yatieneres()
        If ds.Tables.Contains("respre") Then
            ds.Tables.Remove("respre")
        End If
        cmd.CommandText = "SELECT Contest.* FROM Contest WHERE Contest.Idal = " & ds.Tables("alumno").Rows(0).Item(0) & " AND Contest.Idpreg = " & pre
        conectar()
        da.Fill(ds, "respre")
        desconectar()

    End Sub
    Sub cargares()
        If ds.Tables("respre").Rows.Count > 0 Then
            cmd.CommandText = "UPDATE Contest SET Idres = " & res & " WHERE Contest.Idal = " & ds.Tables("alumno").Rows(0).Item(0) & " AND Contest.Idpreg = " & pre
        Else
            cmd.CommandText = "INSERT INTO Contest (Idal, Idpreg , Idres) values ( " & ds.Tables("alumno").Rows(0).Item(0) & " , " & pre & " , " & res & ")"
        End If
        conectar()
        cmd.ExecuteNonQuery()
        desconectar()
    End Sub
    Sub cargares3(cpreg As Integer)
        pre = 3

        cmd.CommandText = "INSERT INTO Contest (Idal, Idpreg , Idres) values ( " & ds.Tables("alumno").Rows(0).Item(0) & " , " & pre & " , " & res & ")"
        conectar()
        cmd.ExecuteNonQuery()
        desconectar()
    End Sub
    Sub cargares3gra()
        Dim nres As Integer
        For i As Integer = 0 To 3
            Select Case recep3(i)
                Case "PM"
                    res = nres + 7

                    cargares3(i)

                Case "PRO"
                    res = nres + 8

                    cargares3(i)

                Case "FAL"
                    res = nres + 9

                    cargares3(i)

                Case "RAM"
                    res = nres + 10

                    cargares3(i)

            End Select
            nres += 4

        Next
    End Sub
    Sub cargares7()
        pre = 7
        For i As Integer = 0 To 7
            If res7(i) <> 0 Then
                cmd.CommandText = "INSERT INTO Contest (Idal, Idpreg , Idres) values ( " & ds.Tables("alumno").Rows(0).Item(0) & " , " & pre & " , " & res7(i) & ")"
                conectar()
                cmd.ExecuteNonQuery()
                desconectar()
            End If
        Next
    End Sub
    Sub cargarestext(valor As Integer)
        If valor = 0 Then
            pre = 9
        Else
            pre = 10
        End If
        cmd.CommandText = "INSERT INTO Respuestas (Idpreg , Detalle) values (" & pre & " , '" & restext(valor) & "')"
        conectar()
        cmd.ExecuteNonQuery()
        desconectar()
        busca9o10()
        cargares()
    End Sub
    Sub busca9o10()
        If ds.Tables.Contains("ultimas") Then
            ds.Tables.Remove("ultimas")
        End If
        If pre = 9 Then
            cmd.CommandText = "SELECT r.Idres FROM Respuestas r WHERE r.Idpreg = " & pre & " AND r.Detalle = '" & restext(0) & "'"

        Else
            cmd.CommandText = "SELECT r.Idres FROM Respuestas r WHERE r.Idpreg = " & pre & " AND r.Detalle = '" & restext(1) & "'"

        End If
        conectar()
        da.Fill(ds, "ultimas")
        desconectar()
        res = ds.Tables("ultimas").Rows(0).Item(0)
        yatieneres()

    End Sub

End Module
