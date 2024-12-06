﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        passwordLogin = New MaskedTextBox()
        dataView = New DataGridView()
        accountIDLogin = New MaskedTextBox()
        forgotpasscodeportal = New Label()
        exitbttn = New PictureBox()
        PictureBox1 = New PictureBox()
        enterbttn = New PictureBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        CType(dataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(exitbttn, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(enterbttn, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' passwordLogin
        ' 
        passwordLogin.BackColor = Color.WhiteSmoke
        passwordLogin.BorderStyle = BorderStyle.None
        passwordLogin.Font = New Font("Tahoma", 11.0F)
        passwordLogin.ForeColor = Color.DarkGreen
        passwordLogin.Location = New Point(160, 454)
        passwordLogin.Margin = New Padding(4, 4, 4, 4)
        passwordLogin.Name = "passwordLogin"
        passwordLogin.Size = New Size(231, 27)
        passwordLogin.TabIndex = 1
        passwordLogin.TextAlign = HorizontalAlignment.Center
        passwordLogin.UseSystemPasswordChar = True
        ' 
        ' dataView
        ' 
        dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataView.Location = New Point(510, 552)
        dataView.Margin = New Padding(4, 4, 4, 4)
        dataView.Name = "dataView"
        dataView.RowHeadersWidth = 51
        dataView.Size = New Size(12, 12)
        dataView.TabIndex = 12
        dataView.Visible = False
        ' 
        ' accountIDLogin
        ' 
        accountIDLogin.BackColor = Color.WhiteSmoke
        accountIDLogin.BorderStyle = BorderStyle.None
        accountIDLogin.Font = New Font("Tahoma", 11.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        accountIDLogin.ForeColor = Color.DarkGreen
        accountIDLogin.Location = New Point(13, 13)
        accountIDLogin.Mask = "0-00-00000"
        accountIDLogin.Name = "accountIDLogin"
        accountIDLogin.PromptChar = "X"c
        accountIDLogin.Size = New Size(231, 27)
        accountIDLogin.TabIndex = 13
        accountIDLogin.TextAlign = HorizontalAlignment.Center
        ' 
        ' forgotpasscodeportal
        ' 
        forgotpasscodeportal.AutoSize = True
        forgotpasscodeportal.BackColor = Color.Transparent
        forgotpasscodeportal.Font = New Font("Calibri", 12.0F, FontStyle.Bold Or FontStyle.Underline)
        forgotpasscodeportal.ForeColor = Color.White
        forgotpasscodeportal.Location = New Point(175, 695)
        forgotpasscodeportal.Margin = New Padding(2, 0, 2, 0)
        forgotpasscodeportal.Name = "forgotpasscodeportal"
        forgotpasscodeportal.Size = New Size(205, 29)
        forgotpasscodeportal.TabIndex = 0
        forgotpasscodeportal.Text = "FORGOT PASSCODE"
        ' 
        ' exitbttn
        ' 
        exitbttn.BackColor = Color.Transparent
        exitbttn.BackgroundImage = CType(resources.GetObject("exitbttn.BackgroundImage"), Image)
        exitbttn.BackgroundImageLayout = ImageLayout.Zoom
        exitbttn.ImageLocation = ""
        exitbttn.Location = New Point(482, 12)
        exitbttn.Margin = New Padding(4, 4, 4, 4)
        exitbttn.Name = "exitbttn"
        exitbttn.Size = New Size(41, 46)
        exitbttn.SizeMode = PictureBoxSizeMode.Zoom
        exitbttn.TabIndex = 47
        exitbttn.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.ImageLocation = ""
        PictureBox1.Location = New Point(8, 695)
        PictureBox1.Margin = New Padding(4, 4, 4, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(540, 61)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 48
        PictureBox1.TabStop = False
        ' 
        ' enterbttn
        ' 
        enterbttn.BackColor = Color.Transparent
        enterbttn.BackgroundImage = CType(resources.GetObject("enterbttn.BackgroundImage"), Image)
        enterbttn.BackgroundImageLayout = ImageLayout.Stretch
        enterbttn.ImageLocation = ""
        enterbttn.Location = New Point(171, 496)
        enterbttn.Margin = New Padding(4, 4, 4, 4)
        enterbttn.Name = "enterbttn"
        enterbttn.Size = New Size(218, 114)
        enterbttn.SizeMode = PictureBoxSizeMode.Zoom
        enterbttn.TabIndex = 49
        enterbttn.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(141, 438)
        Panel1.Margin = New Padding(4, 4, 4, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(268, 62)
        Panel1.TabIndex = 50
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.WhiteSmoke
        Panel2.Controls.Add(accountIDLogin)
        Panel2.Location = New Point(113, 284)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(268, 62)
        Panel2.TabIndex = 51
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(536, 756)
        Controls.Add(enterbttn)
        Controls.Add(forgotpasscodeportal)
        Controls.Add(PictureBox1)
        Controls.Add(exitbttn)
        Controls.Add(dataView)
        Controls.Add(passwordLogin)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 4, 4, 4)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(dataView, ComponentModel.ISupportInitialize).EndInit()
        CType(exitbttn, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(enterbttn, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents passwordLogin As MaskedTextBox
    Friend WithEvents dataView As DataGridView
    Friend WithEvents accountIDLogin As MaskedTextBox
    Friend WithEvents forgotpasscodeportal As Label
    Friend WithEvents exitbttn As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents enterbttn As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel

End Class
