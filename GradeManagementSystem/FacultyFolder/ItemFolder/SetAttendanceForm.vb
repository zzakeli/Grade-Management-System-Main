﻿Imports System.Security.Permissions
Imports MySql.Data.MySqlClient
Public Class SetAttendanceForm
    Private connector As New DatabaseConnector
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Visible = False
    End Sub

    Private Sub numDaysButton_Click(sender As Object, e As EventArgs) Handles numDaysButton.Click
        Dim classID As String = LoginForgot.gradingSheet.classChooseBox.Text
        Dim itemID As String = getItemID()
        Dim itemName As String = "A1"
        Dim days As Integer = Integer.Parse(numDaysTextBox.Text)
        Try
            connector.connect.Close()
            connector.connect.Open()
            connector.query = "INSERT INTO item VALUES('" & itemID & "','" & itemName & "','Attendance'," & days & ",'" & GradingSheet.getTerm & "','" & classID & "');"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            LoginForgot.gradingSheet.attendanceButton.Enabled = False
            Me.Visible = False
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error numDaysButton_Click")
        End Try
        setScores()
        GradingSheet.AttMaxTextBox.Text = "No. of days: " & days
    End Sub

    Private Sub setScores()
        Dim classID As String = LoginForgot.gradingSheet.classChooseBox.Text
        Dim enrollID(getEnrollSize(classID) - 1) As String
        Try
            connector.connect.Open()
            connector.query = "SELECT enrollment_id FROM enrollment WHERE class_id = '" & classID & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            Dim i As Integer
            While connector.reader.Read
                If (Not connector.reader("enrollment_id").ToString.Equals("")) Then
                    enrollID(i) = connector.reader("enrollment_id").ToString
                    i += 1
                End If
            End While
            connector.reader.Close()

            For j As Integer = 0 To enrollID.Length - 1
                If (Not enrollID(j).Equals("")) Then
                    connector.query = "INSERT INTO attendance VALUES ('" & enrollID(j) & "',0,0,'" & classID & "','" & GradingSheet.getTerm & "');"
                    connector.command.CommandText = connector.query
                    connector.command.ExecuteNonQuery()
                End If
            Next
            connector.connect.Close()
        Catch ex As MySqlException
            connector.reader.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error setScores")
        End Try
    End Sub

    Private Function getEnrollSize(classID As String) As Integer
        Try
            connector.connect.Open()
            connector.query = "SELECT COUNT(enrollment_id) AS enrollment_id FROM enrollment WHERE class_id = '" & classID & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                Dim classIDCount As Integer = Integer.Parse(connector.reader("enrollment_id").ToString)
                connector.reader.Close()
                connector.connect.Close()
                Return classIDCount
            End While
            connector.reader.Close()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.reader.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error getEnrollSize")
        End Try
        Return 0
    End Function

    Private Function getEnrollmentID(rowIndex As Integer) As String
        Dim classID As String = LoginForgot.gradingSheet.classChooseBox.Text
        Dim studentID As String = GradingSheet.studentInfoDataView.Rows(rowIndex).Cells(0).Value.ToString()
        Try
            connector.connect.Open()
            connector.query = "SELECT enrollment_id FROM enrollment WHERE student_id = '" & studentID & "' AND class_id = '" & classID & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If (Not connector.reader("enrollment_id").ToString.Equals("")) Then
                    Dim enrollmentID As String = connector.reader("enrollment_id").ToString
                    connector.connect.Close()
                    connector.reader.Close()
                    Return enrollmentID
                End If
            End While
            connector.reader.Close()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.reader.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error getEnrollmentID")
        End Try
        Return Nothing
    End Function

    Private Function getItemID() As String
        Dim iCount As Integer = 0
        Dim itemID As String = ""
        Try
            connector.connect.Open()
            connector.query = "SELECT * FROM item_count_history ORDER BY count DESC LIMIT 1;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If (Not connector.reader("count").ToString.Equals("")) Then
                    iCount = Integer.Parse(connector.reader("count").ToString) + 1
                End If
            End While
            connector.reader.Close()
            itemID = "item" & getZeros(iCount) & (iCount)
            connector.query = "INSERT INTO item_count_history VALUES();"
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            connector.reader.Close()
            Return itemID
        Catch ex As MySqlException
            connector.connect.Close()
            connector.reader.Close()
            MessageBox.Show("Database Error getItemID()")
        End Try
        Return itemID
    End Function

    Private Function getZeros(iCount As Integer) As String
        Dim zeros As String = "000"
        Select Case iCount.ToString.Length
            Case 1
                zeros = "00"
            Case 2
                zeros = "0"
            Case 3
                zeros = ""
        End Select
        Return zeros
    End Function
End Class