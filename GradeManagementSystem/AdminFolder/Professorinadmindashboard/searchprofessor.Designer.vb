﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class searchprofessor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(searchprofessor))
        PictureBox1 = New PictureBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Label5 = New Label()
        Button2 = New Button()
        DataGridView1 = New DataGridView()
        Label4 = New Label()

        TextBox1 = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()

        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(585, 174)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(40, 34)
        PictureBox1.TabIndex = 60
        PictureBox1.TabStop = False
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.DarkSeaGreen
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Segoe UI", 10F)
        TextBox2.Location = New Point(259, 174)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(326, 34)
        TextBox2.TabIndex = 59
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Small", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(91, 178)
        Label3.Name = "Label3"
        Label3.Size = New Size(169, 26)
        Label3.TabIndex = 58
        Label3.Text = "Professor Name:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sitka Small", 6F, FontStyle.Bold)
        Label5.ForeColor = Color.DarkGreen
        Label5.Location = New Point(1142, 58)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 18)
        Label5.TabIndex = 57
        Label5.Text = "First Semester"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Green
        Button2.BackgroundImageLayout = ImageLayout.None
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Sitka Text Semibold", 7F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(1211, 663)
        Button2.Name = "Button2"
        Button2.Size = New Size(107, 43)
        Button2.TabIndex = 56
        Button2.Text = "DASHBOARD"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(91, 240)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(1219, 404)
        DataGridView1.TabIndex = 55
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Sitka Small", 6F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkGreen
        Label4.Location = New Point(1142, 37)
        Label4.Name = "Label4"
        Label4.Size = New Size(168, 18)
        Label4.TabIndex = 54
        Label4.Text = "School Year: 2024 - 2025"

        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.DarkSeaGreen
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Segoe UI", 10F)
        TextBox1.Location = New Point(258, 134)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(191, 34)
        TextBox1.TabIndex = 52
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Small", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(91, 138)
        Label2.Name = "Label2"
        Label2.Size = New Size(137, 26)
        Label2.TabIndex = 51
        Label2.Text = "Professor ID:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Small", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(67, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(212, 32)
        Label1.TabIndex = 50
        Label1.Text = "P R O F E S S O R"
        ' 
        ' searchprofessor
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1385, 743)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(Label5)
        Controls.Add(Button2)
        Controls.Add(DataGridView1)
        Controls.Add(Label4)

        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "searchprofessor"
        Text = "searchprofessor"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()

        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
