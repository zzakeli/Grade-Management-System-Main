﻿Imports MySql.Data.MySqlClient

Public Class ManageDepartmentAdmin
    Private connector As New DatabaseConnector
    Private addDepartmentForm As New AddDepartmentForm
    Private modifyDepartmentForm As New ModifyDepartmentForm
    Private officialModifyDepartmentForm As New OfficialModifyDepartmentForm

    Private Sub reloadbttn_Click(sender As Object, e As EventArgs) Handles reloadbttn.Click
        Try
            connector.dataTable.Clear()
            connector.connect.Open()
            connector.query = "SELECT * FROM department;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(connector.dataTable)
            dataView.DataSource = connector.dataTable
            connector.command.ExecuteNonQuery()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Sub reloadbttn1_Click(sender As Object, e As EventArgs) Handles reloadbttn1.Click
        Try
            connector.dataTable.Clear()
            connector.connect.Open()
            connector.query = "SELECT * FROM department;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(connector.dataTable)
            dataView.DataSource = connector.dataTable
            connector.command.ExecuteNonQuery()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub
    Private Sub adddepartmentbttn_Click(sender As Object, e As EventArgs) Handles adddepartmentbttn.Click
        Dim dCount As Integer = 0
        Try
            connector.connect.Open()
            connector.query = "SELECT * FROM dept_count_history ORDER BY count DESC LIMIT 1;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                dCount = Integer.Parse(connector.reader("count").ToString())
            End While
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        addDepartmentForm.departmentIDTextBox.Text = "D" & "-" & getZeros(dCount) & (dCount + 1)
        addDepartmentForm.Visible = True
    End Sub

    Private Sub adddepartmentbttn1_Click(sender As Object, e As EventArgs) Handles adddepartmentbttn1.Click
        Dim dCount As Integer = 0
        Try
            connector.connect.Open()
            connector.query = "SELECT * FROM dept_count_history ORDER BY count DESC LIMIT 1;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                dCount = Integer.Parse(connector.reader("count").ToString())
            End While
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        addDepartmentForm.departmentIDTextBox.Text = "D" & "-" & getZeros(dCount) & (dCount + 1)
        addDepartmentForm.Visible = True
    End Sub
    Private Sub addDepartment_Click(sender As Object, e As EventArgs)

        Dim dCount = 0
        Try
            connector.connect.Open()
            connector.query = "SELECT * FROM dept_count_history ORDER BY count DESC LIMIT 1;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                dCount = Integer.Parse(connector.reader("count").ToString)
            End While
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        addDepartmentForm.departmentIDTextBox.Text = "D" & "-" & getZeros(dCount) & dCount + 1
        addDepartmentForm.Visible = True
    End Sub

    Private Function getZeros(dCount As Integer) As String
        Dim zeros As String = "000"
        Select Case dCount.ToString.Length
            Case 1
                zeros = "00"
            Case 2
                zeros = "0"
            Case 3
                zeros = ""
        End Select
        Return zeros
    End Function

    Private Sub modifyButton_Click(sender As Object, e As EventArgs)
        modifyDepartmentForm.Visible = True
    End Sub

    Private Sub ManageDepartmentAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        makeADFChild()
        makeMDFChild()
    End Sub

    Private Sub makeADFChild()
        addDepartmentForm.TopLevel = False
        addDepartmentForm.Parent = Me
        CenterADF()
        addDepartmentForm.BringToFront()
    End Sub

    Private Sub CenterADF()
        Dim x As Integer = (Me.ClientSize.Width - addDepartmentForm.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - addDepartmentForm.Height) \ 2
        addDepartmentForm.Location = New Point(x, y)
    End Sub

    Private Sub makeMDFChild()
        modifyDepartmentForm.TopLevel = False
        modifyDepartmentForm.Parent = Me
        CenterMDF()
        modifyDepartmentForm.BringToFront()
    End Sub

    Private Sub CenterMDF()
        Dim x As Integer = (Me.ClientSize.Width - modifyDepartmentForm.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - modifyDepartmentForm.Height) \ 2
        modifyDepartmentForm.Location = New Point(x, y)
    End Sub

    Private Sub ManageDepartmentAdmin_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub searchfield_Click(sender As Object, e As EventArgs) Handles searchfield.Click

    End Sub

    Private Sub searchbttn_Click(sender As Object, e As EventArgs) Handles searchbttn.Click

    End Sub

    Private Sub modifybttn_Click(sender As Object, e As EventArgs) Handles modifybttn.Click
        modifyDepartmentForm.Visible = True
    End Sub

    Private Sub modifybttn1_Click(sender As Object, e As EventArgs) Handles modifybttn1.Click
        modifyDepartmentForm.Visible = True
    End Sub
End Class