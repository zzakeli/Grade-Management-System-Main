﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForgot
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
        p_login = New Panel()
        pb_wid = New PictureBox()
        txtb_userid = New TextBox()
        enterbttn = New Button()
        Gerald3 = New gerald.Gerald()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        Gerald2 = New gerald.Gerald()
        PictureBox1 = New PictureBox()
        txtb_password = New TextBox()
        Gerald1 = New gerald.Gerald()
        lbl_invalid = New Label()
        p_wid = New gerald.Gerald()
        p_wpassword = New gerald.Gerald()
        p_base = New Panel()
        ds_forgot = New PictureBox()
        PictureBox5 = New PictureBox()
        p_changepass = New Panel()
        btn_eye = New PictureBox()
        txtb_confirmpassword = New TextBox()
        Gerald12 = New gerald.Gerald()
        txtb_newpassword = New TextBox()
        PictureBox4 = New PictureBox()
        Gerald4 = New gerald.Gerald()
        Label1 = New Label()
        Label2 = New Label()
        btn_confirm = New Button()
        Gerald17 = New gerald.Gerald()
        p_verification = New Panel()
        lbl_wrongcode = New Label()
        btn_back = New PictureBox()
        txtb_c6 = New TextBox()
        Gerald11 = New gerald.Gerald()
        txtb_c5 = New TextBox()
        Gerald10 = New gerald.Gerald()
        txtb_c4 = New TextBox()
        Gerald7 = New gerald.Gerald()
        txtb_c3 = New TextBox()
        Gerald6 = New gerald.Gerald()
        txtb_c2 = New TextBox()
        Gerald5 = New gerald.Gerald()
        txtb_c1 = New TextBox()
        lbl_verification = New Label()
        lbl_codesent = New Label()
        bg_code = New gerald.Gerald()
        btn_verify = New Button()
        btnbg_verify = New gerald.Gerald()
        p_wc6 = New gerald.Gerald()
        p_wc5 = New gerald.Gerald()
        p_wc4 = New gerald.Gerald()
        p_wc3 = New gerald.Gerald()
        p_wc2 = New gerald.Gerald()
        p_wc1 = New gerald.Gerald()
        lbl_besure = New Label()
        lbl_ready = New Label()
        p_forgotpass = New Panel()
        pb_emailerror = New PictureBox()
        lbl_resetpass = New Label()
        lbl_emailme = New Label()
        txtb_email = New TextBox()
        btn_reset = New Button()
        Gerald8 = New gerald.Gerald()
        PictureBox8 = New PictureBox()
        Gerald9 = New gerald.Gerald()
        pb_wemail = New gerald.Gerald()
        lbl_fpass = New Label()
        lbl_login = New Label()
        lbl_welcome = New Label()
        btn_forgotpass = New Button()
        btnbg_forgotpass = New gerald.Gerald()
        bg_fpass = New gerald.Gerald()
        btn_signin = New Button()
        btnbg_signin = New gerald.Gerald()
        bg_signin = New gerald.Gerald()
        ds_login = New PictureBox()
        p_login.SuspendLayout()
        CType(pb_wid, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        p_base.SuspendLayout()
        CType(ds_forgot, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        p_changepass.SuspendLayout()
        CType(btn_eye, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        p_verification.SuspendLayout()
        CType(btn_back, ComponentModel.ISupportInitialize).BeginInit()
        p_forgotpass.SuspendLayout()
        CType(pb_emailerror, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(ds_login, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' p_login
        ' 
        p_login.BackColor = Color.White
        p_login.CausesValidation = False
        p_login.Controls.Add(pb_wid)
        p_login.Controls.Add(txtb_userid)
        p_login.Controls.Add(enterbttn)
        p_login.Controls.Add(Gerald3)
        p_login.Controls.Add(PictureBox3)
        p_login.Controls.Add(PictureBox2)
        p_login.Controls.Add(Gerald2)
        p_login.Controls.Add(PictureBox1)
        p_login.Controls.Add(txtb_password)
        p_login.Controls.Add(Gerald1)
        p_login.Controls.Add(lbl_invalid)
        p_login.Controls.Add(p_wid)
        p_login.Controls.Add(p_wpassword)
        p_login.Location = New Point(0, 0)
        p_login.Margin = New Padding(4, 4, 4, 4)
        p_login.Name = "p_login"
        p_login.Size = New Size(438, 750)
        p_login.TabIndex = 0
        ' 
        ' pb_wid
        ' 
        pb_wid.BackColor = Color.Transparent
        pb_wid.Image = My.Resources.Resources.icon_exclamationcircle
        pb_wid.Location = New Point(361, 282)
        pb_wid.Margin = New Padding(4, 4, 4, 4)
        pb_wid.Name = "pb_wid"
        pb_wid.Size = New Size(25, 25)
        pb_wid.SizeMode = PictureBoxSizeMode.Zoom
        pb_wid.TabIndex = 22
        pb_wid.TabStop = False
        pb_wid.Visible = False
        ' 
        ' txtb_userid
        ' 
        txtb_userid.BackColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        txtb_userid.BorderStyle = BorderStyle.None
        txtb_userid.Font = New Font("Segoe UI", 9F)
        txtb_userid.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        txtb_userid.Location = New Point(100, 311)
        txtb_userid.Margin = New Padding(4, 4, 4, 4)
        txtb_userid.Name = "txtb_userid"
        txtb_userid.PlaceholderText = "User ID"
        txtb_userid.Size = New Size(264, 24)
        txtb_userid.TabIndex = 7
        ' 
        ' enterbttn
        ' 
        enterbttn.BackColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        enterbttn.BackgroundImageLayout = ImageLayout.None
        enterbttn.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        enterbttn.FlatStyle = FlatStyle.Flat
        enterbttn.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        enterbttn.ForeColor = Color.White
        enterbttn.Location = New Point(110, 544)
        enterbttn.Margin = New Padding(4, 4, 4, 4)
        enterbttn.Name = "enterbttn"
        enterbttn.Size = New Size(220, 38)
        enterbttn.TabIndex = 0
        enterbttn.Text = "LOG IN"
        enterbttn.UseVisualStyleBackColor = False
        ' 
        ' Gerald3
        ' 
        Gerald3.BackColor = Color.White
        Gerald3.BorderRadius = 40
        Gerald3.ForeColor = Color.Black
        Gerald3.GradientAngle = 90F
        Gerald3.GradientBottomColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        Gerald3.GradientTopColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        Gerald3.Location = New Point(94, 538)
        Gerald3.Margin = New Padding(4, 4, 4, 4)
        Gerald3.Name = "Gerald3"
        Gerald3.Size = New Size(250, 50)
        Gerald3.TabIndex = 6
        Gerald3.Text = "Gerald3"
        Gerald3.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.PLP_LOGO
        PictureBox3.Location = New Point(172, 139)
        PictureBox3.Margin = New Padding(4, 4, 4, 4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(95, 95)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.icon_id
        PictureBox2.Location = New Point(64, 315)
        PictureBox2.Margin = New Padding(4, 4, 4, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(21, 21)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Gerald2
        ' 
        Gerald2.BackColor = Color.White
        Gerald2.BorderRadius = 20
        Gerald2.FlatAppearance.BorderColor = Color.Red
        Gerald2.ForeColor = Color.Black
        Gerald2.GradientAngle = 90F
        Gerald2.GradientBottomColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald2.GradientTopColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald2.Location = New Point(44, 300)
        Gerald2.Margin = New Padding(4, 4, 4, 4)
        Gerald2.Name = "Gerald2"
        Gerald2.Size = New Size(350, 50)
        Gerald2.TabIndex = 4
        Gerald2.Text = "Gerald2"
        Gerald2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.icon_lock
        PictureBox1.Location = New Point(64, 390)
        PictureBox1.Margin = New Padding(4, 4, 4, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(21, 21)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' txtb_password
        ' 
        txtb_password.BackColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        txtb_password.BorderStyle = BorderStyle.None
        txtb_password.Font = New Font("Segoe UI", 9F)
        txtb_password.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        txtb_password.Location = New Point(100, 388)
        txtb_password.Margin = New Padding(4, 4, 4, 4)
        txtb_password.Name = "txtb_password"
        txtb_password.PasswordChar = "•"c
        txtb_password.PlaceholderText = "Password"
        txtb_password.Size = New Size(264, 24)
        txtb_password.TabIndex = 0
        ' 
        ' Gerald1
        ' 
        Gerald1.BackColor = Color.White
        Gerald1.BorderRadius = 20
        Gerald1.ForeColor = Color.Black
        Gerald1.GradientAngle = 90F
        Gerald1.GradientBottomColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald1.GradientTopColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald1.Location = New Point(44, 375)
        Gerald1.Margin = New Padding(4, 4, 4, 4)
        Gerald1.Name = "Gerald1"
        Gerald1.Size = New Size(350, 50)
        Gerald1.TabIndex = 1
        Gerald1.Text = "Gerald1"
        Gerald1.UseVisualStyleBackColor = False
        ' 
        ' lbl_invalid
        ' 
        lbl_invalid.AutoSize = True
        lbl_invalid.Font = New Font("Microsoft Sans Serif", 8.25F)
        lbl_invalid.ForeColor = Color.FromArgb(CByte(202), CByte(48), CByte(48))
        lbl_invalid.Location = New Point(44, 439)
        lbl_invalid.Margin = New Padding(4, 0, 4, 0)
        lbl_invalid.Name = "lbl_invalid"
        lbl_invalid.Size = New Size(181, 20)
        lbl_invalid.TabIndex = 0
        lbl_invalid.Text = "Invalid ID or Password."
        lbl_invalid.Visible = False
        ' 
        ' p_wid
        ' 
        p_wid.BackColor = Color.White
        p_wid.BorderRadius = 21
        p_wid.FlatAppearance.BorderColor = Color.Red
        p_wid.ForeColor = Color.Black
        p_wid.GradientAngle = 90F
        p_wid.GradientBottomColor = Color.FromArgb(CByte(202), CByte(48), CByte(48))
        p_wid.GradientTopColor = Color.FromArgb(CByte(202), CByte(48), CByte(48))
        p_wid.Location = New Point(40, 296)
        p_wid.Margin = New Padding(4, 4, 4, 4)
        p_wid.Name = "p_wid"
        p_wid.Size = New Size(356, 56)
        p_wid.TabIndex = 8
        p_wid.Text = "Gerald13"
        p_wid.UseVisualStyleBackColor = False
        p_wid.Visible = False
        ' 
        ' p_wpassword
        ' 
        p_wpassword.BackColor = Color.White
        p_wpassword.BorderRadius = 21
        p_wpassword.FlatAppearance.BorderColor = Color.Red
        p_wpassword.ForeColor = Color.Black
        p_wpassword.GradientAngle = 90F
        p_wpassword.GradientBottomColor = Color.FromArgb(CByte(202), CByte(48), CByte(48))
        p_wpassword.GradientTopColor = Color.FromArgb(CByte(202), CByte(48), CByte(48))
        p_wpassword.Location = New Point(40, 371)
        p_wpassword.Margin = New Padding(4, 4, 4, 4)
        p_wpassword.Name = "p_wpassword"
        p_wpassword.Size = New Size(356, 56)
        p_wpassword.TabIndex = 9
        p_wpassword.Text = "Gerald14"
        p_wpassword.UseVisualStyleBackColor = False
        p_wpassword.Visible = False
        ' 
        ' p_base
        ' 
        p_base.BackgroundImage = My.Resources.Resources.PLPBG
        p_base.BackgroundImageLayout = ImageLayout.Center
        p_base.CausesValidation = False
        p_base.Controls.Add(ds_forgot)
        p_base.Controls.Add(PictureBox5)
        p_base.Controls.Add(p_changepass)
        p_base.Controls.Add(p_verification)
        p_base.Controls.Add(p_login)
        p_base.Controls.Add(lbl_besure)
        p_base.Controls.Add(lbl_ready)
        p_base.Controls.Add(p_forgotpass)
        p_base.Controls.Add(lbl_fpass)
        p_base.Controls.Add(lbl_login)
        p_base.Controls.Add(lbl_welcome)
        p_base.Controls.Add(btn_forgotpass)
        p_base.Controls.Add(btnbg_forgotpass)
        p_base.Controls.Add(bg_fpass)
        p_base.Controls.Add(btn_signin)
        p_base.Controls.Add(btnbg_signin)
        p_base.Controls.Add(bg_signin)
        p_base.Controls.Add(ds_login)
        p_base.Location = New Point(0, 0)
        p_base.Margin = New Padding(4, 4, 4, 4)
        p_base.Name = "p_base"
        p_base.Size = New Size(1000, 750)
        p_base.TabIndex = 1
        ' 
        ' ds_forgot
        ' 
        ds_forgot.BackColor = Color.Transparent
        ds_forgot.Image = My.Resources.Resources.dropshadow_left
        ds_forgot.Location = New Point(1000, 0)
        ds_forgot.Margin = New Padding(4, 4, 4, 4)
        ds_forgot.Name = "ds_forgot"
        ds_forgot.Size = New Size(96, 761)
        ds_forgot.SizeMode = PictureBoxSizeMode.StretchImage
        ds_forgot.TabIndex = 21
        ds_forgot.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.Location = New Point(959, 4)
        PictureBox5.Margin = New Padding(4, 4, 4, 4)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(38, 38)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 19
        PictureBox5.TabStop = False
        ' 
        ' p_changepass
        ' 
        p_changepass.BackColor = Color.White
        p_changepass.CausesValidation = False
        p_changepass.Controls.Add(btn_eye)
        p_changepass.Controls.Add(txtb_confirmpassword)
        p_changepass.Controls.Add(Gerald12)
        p_changepass.Controls.Add(txtb_newpassword)
        p_changepass.Controls.Add(PictureBox4)
        p_changepass.Controls.Add(Gerald4)
        p_changepass.Controls.Add(Label1)
        p_changepass.Controls.Add(Label2)
        p_changepass.Controls.Add(btn_confirm)
        p_changepass.Controls.Add(Gerald17)
        p_changepass.Location = New Point(1000, 0)
        p_changepass.Margin = New Padding(4, 4, 4, 4)
        p_changepass.Name = "p_changepass"
        p_changepass.Size = New Size(438, 750)
        p_changepass.TabIndex = 18
        ' 
        ' btn_eye
        ' 
        btn_eye.Image = My.Resources.Resources.icon_eye
        btn_eye.Location = New Point(62, 371)
        btn_eye.Margin = New Padding(4, 4, 4, 4)
        btn_eye.Name = "btn_eye"
        btn_eye.Size = New Size(25, 25)
        btn_eye.SizeMode = PictureBoxSizeMode.Zoom
        btn_eye.TabIndex = 23
        btn_eye.TabStop = False
        ' 
        ' txtb_confirmpassword
        ' 
        txtb_confirmpassword.BackColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        txtb_confirmpassword.BorderStyle = BorderStyle.None
        txtb_confirmpassword.Font = New Font("Segoe UI", 9F)
        txtb_confirmpassword.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        txtb_confirmpassword.Location = New Point(105, 442)
        txtb_confirmpassword.Margin = New Padding(4, 4, 4, 4)
        txtb_confirmpassword.Name = "txtb_confirmpassword"
        txtb_confirmpassword.PlaceholderText = "Confirm Password"
        txtb_confirmpassword.Size = New Size(264, 24)
        txtb_confirmpassword.TabIndex = 21
        ' 
        ' Gerald12
        ' 
        Gerald12.BackColor = Color.White
        Gerald12.BorderRadius = 20
        Gerald12.ForeColor = Color.Black
        Gerald12.GradientAngle = 90F
        Gerald12.GradientBottomColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald12.GradientTopColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald12.Location = New Point(44, 430)
        Gerald12.Margin = New Padding(4, 4, 4, 4)
        Gerald12.Name = "Gerald12"
        Gerald12.Size = New Size(350, 50)
        Gerald12.TabIndex = 22
        Gerald12.Text = "Gerald12"
        Gerald12.UseVisualStyleBackColor = False
        ' 
        ' txtb_newpassword
        ' 
        txtb_newpassword.BackColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        txtb_newpassword.BorderStyle = BorderStyle.None
        txtb_newpassword.Font = New Font("Segoe UI", 9F)
        txtb_newpassword.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        txtb_newpassword.Location = New Point(105, 371)
        txtb_newpassword.Margin = New Padding(4, 4, 4, 4)
        txtb_newpassword.Name = "txtb_newpassword"
        txtb_newpassword.PlaceholderText = "New Password"
        txtb_newpassword.Size = New Size(264, 24)
        txtb_newpassword.TabIndex = 7
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.icon_leftarrow
        PictureBox4.Location = New Point(25, 25)
        PictureBox4.Margin = New Padding(4, 4, 4, 4)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(30, 30)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 20
        PictureBox4.TabStop = False
        ' 
        ' Gerald4
        ' 
        Gerald4.BackColor = Color.White
        Gerald4.BorderRadius = 20
        Gerald4.ForeColor = Color.Black
        Gerald4.GradientAngle = 90F
        Gerald4.GradientBottomColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald4.GradientTopColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald4.Location = New Point(44, 359)
        Gerald4.Margin = New Padding(4, 4, 4, 4)
        Gerald4.Name = "Gerald4"
        Gerald4.Size = New Size(350, 50)
        Gerald4.TabIndex = 8
        Gerald4.Text = "Gerald4"
        Gerald4.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        Label1.Location = New Point(29, 206)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(369, 41)
        Label1.TabIndex = 8
        Label1.Text = "RESET YOUR PASSWORD"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        Label2.Location = New Point(38, 259)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(350, 63)
        Label2.TabIndex = 7
        Label2.Text = "You have successfully verified yourself." & vbCrLf & "Please fill out the following to reset and create" & vbCrLf & "a new password."
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btn_confirm
        ' 
        btn_confirm.BackColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        btn_confirm.BackgroundImageLayout = ImageLayout.None
        btn_confirm.Enabled = False
        btn_confirm.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        btn_confirm.FlatStyle = FlatStyle.Flat
        btn_confirm.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_confirm.ForeColor = Color.White
        btn_confirm.Location = New Point(105, 546)
        btn_confirm.Margin = New Padding(4, 4, 4, 4)
        btn_confirm.Name = "btn_confirm"
        btn_confirm.Size = New Size(220, 38)
        btn_confirm.TabIndex = 0
        btn_confirm.Text = "CONFIRM"
        btn_confirm.UseVisualStyleBackColor = False
        ' 
        ' Gerald17
        ' 
        Gerald17.BackColor = Color.White
        Gerald17.BorderRadius = 40
        Gerald17.Enabled = False
        Gerald17.ForeColor = Color.Black
        Gerald17.GradientAngle = 90F
        Gerald17.GradientBottomColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        Gerald17.GradientTopColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        Gerald17.Location = New Point(89, 540)
        Gerald17.Margin = New Padding(4, 4, 4, 4)
        Gerald17.Name = "Gerald17"
        Gerald17.Size = New Size(250, 50)
        Gerald17.TabIndex = 6
        Gerald17.Text = "Gerald3"
        Gerald17.UseVisualStyleBackColor = False
        ' 
        ' p_verification
        ' 
        p_verification.BackColor = Color.White
        p_verification.CausesValidation = False
        p_verification.Controls.Add(lbl_wrongcode)
        p_verification.Controls.Add(btn_back)
        p_verification.Controls.Add(txtb_c6)
        p_verification.Controls.Add(Gerald11)
        p_verification.Controls.Add(txtb_c5)
        p_verification.Controls.Add(Gerald10)
        p_verification.Controls.Add(txtb_c4)
        p_verification.Controls.Add(Gerald7)
        p_verification.Controls.Add(txtb_c3)
        p_verification.Controls.Add(Gerald6)
        p_verification.Controls.Add(txtb_c2)
        p_verification.Controls.Add(Gerald5)
        p_verification.Controls.Add(txtb_c1)
        p_verification.Controls.Add(lbl_verification)
        p_verification.Controls.Add(lbl_codesent)
        p_verification.Controls.Add(bg_code)
        p_verification.Controls.Add(btn_verify)
        p_verification.Controls.Add(btnbg_verify)
        p_verification.Controls.Add(p_wc6)
        p_verification.Controls.Add(p_wc5)
        p_verification.Controls.Add(p_wc4)
        p_verification.Controls.Add(p_wc3)
        p_verification.Controls.Add(p_wc2)
        p_verification.Controls.Add(p_wc1)
        p_verification.Location = New Point(1000, 0)
        p_verification.Margin = New Padding(4, 4, 4, 4)
        p_verification.Name = "p_verification"
        p_verification.Size = New Size(438, 750)
        p_verification.TabIndex = 10
        ' 
        ' lbl_wrongcode
        ' 
        lbl_wrongcode.AutoSize = True
        lbl_wrongcode.Font = New Font("Microsoft Sans Serif", 8.25F)
        lbl_wrongcode.ForeColor = Color.FromArgb(CByte(202), CByte(48), CByte(48))
        lbl_wrongcode.Location = New Point(166, 444)
        lbl_wrongcode.Margin = New Padding(4, 0, 4, 0)
        lbl_wrongcode.Name = "lbl_wrongcode"
        lbl_wrongcode.Size = New Size(102, 20)
        lbl_wrongcode.TabIndex = 27
        lbl_wrongcode.Text = "Invalid code!"
        lbl_wrongcode.Visible = False
        ' 
        ' btn_back
        ' 
        btn_back.Image = My.Resources.Resources.icon_leftarrow
        btn_back.Location = New Point(25, 25)
        btn_back.Margin = New Padding(4, 4, 4, 4)
        btn_back.Name = "btn_back"
        btn_back.Size = New Size(30, 30)
        btn_back.SizeMode = PictureBoxSizeMode.Zoom
        btn_back.TabIndex = 20
        btn_back.TabStop = False
        ' 
        ' txtb_c6
        ' 
        txtb_c6.BackColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        txtb_c6.BorderStyle = BorderStyle.None
        txtb_c6.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtb_c6.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        txtb_c6.Location = New Point(350, 390)
        txtb_c6.Margin = New Padding(4, 4, 4, 4)
        txtb_c6.MaxLength = 1
        txtb_c6.Name = "txtb_c6"
        txtb_c6.Size = New Size(50, 28)
        txtb_c6.TabIndex = 19
        txtb_c6.TextAlign = HorizontalAlignment.Center
        ' 
        ' Gerald11
        ' 
        Gerald11.BackColor = Color.White
        Gerald11.BorderRadius = 20
        Gerald11.ForeColor = Color.Black
        Gerald11.GradientAngle = 90F
        Gerald11.GradientBottomColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald11.GradientTopColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald11.Location = New Point(350, 375)
        Gerald11.Margin = New Padding(4, 4, 4, 4)
        Gerald11.Name = "Gerald11"
        Gerald11.Size = New Size(50, 56)
        Gerald11.TabIndex = 18
        Gerald11.Text = "Gerald2"
        Gerald11.UseVisualStyleBackColor = False
        ' 
        ' txtb_c5
        ' 
        txtb_c5.BackColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        txtb_c5.BorderStyle = BorderStyle.None
        txtb_c5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtb_c5.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        txtb_c5.Location = New Point(288, 390)
        txtb_c5.Margin = New Padding(4, 4, 4, 4)
        txtb_c5.MaxLength = 1
        txtb_c5.Name = "txtb_c5"
        txtb_c5.Size = New Size(50, 28)
        txtb_c5.TabIndex = 17
        txtb_c5.TextAlign = HorizontalAlignment.Center
        ' 
        ' Gerald10
        ' 
        Gerald10.BackColor = Color.White
        Gerald10.BorderRadius = 20
        Gerald10.ForeColor = Color.Black
        Gerald10.GradientAngle = 90F
        Gerald10.GradientBottomColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald10.GradientTopColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald10.Location = New Point(288, 375)
        Gerald10.Margin = New Padding(4, 4, 4, 4)
        Gerald10.Name = "Gerald10"
        Gerald10.Size = New Size(50, 56)
        Gerald10.TabIndex = 16
        Gerald10.Text = "Gerald2"
        Gerald10.UseVisualStyleBackColor = False
        ' 
        ' txtb_c4
        ' 
        txtb_c4.BackColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        txtb_c4.BorderStyle = BorderStyle.None
        txtb_c4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtb_c4.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        txtb_c4.Location = New Point(225, 390)
        txtb_c4.Margin = New Padding(4, 4, 4, 4)
        txtb_c4.MaxLength = 1
        txtb_c4.Name = "txtb_c4"
        txtb_c4.Size = New Size(50, 28)
        txtb_c4.TabIndex = 15
        txtb_c4.TextAlign = HorizontalAlignment.Center
        ' 
        ' Gerald7
        ' 
        Gerald7.BackColor = Color.White
        Gerald7.BorderRadius = 20
        Gerald7.ForeColor = Color.Black
        Gerald7.GradientAngle = 90F
        Gerald7.GradientBottomColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald7.GradientTopColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald7.Location = New Point(225, 375)
        Gerald7.Margin = New Padding(4, 4, 4, 4)
        Gerald7.Name = "Gerald7"
        Gerald7.Size = New Size(50, 56)
        Gerald7.TabIndex = 14
        Gerald7.Text = "Gerald2"
        Gerald7.UseVisualStyleBackColor = False
        ' 
        ' txtb_c3
        ' 
        txtb_c3.BackColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        txtb_c3.BorderStyle = BorderStyle.None
        txtb_c3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtb_c3.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        txtb_c3.Location = New Point(162, 390)
        txtb_c3.Margin = New Padding(4, 4, 4, 4)
        txtb_c3.MaxLength = 1
        txtb_c3.Name = "txtb_c3"
        txtb_c3.Size = New Size(50, 28)
        txtb_c3.TabIndex = 13
        txtb_c3.TextAlign = HorizontalAlignment.Center
        ' 
        ' Gerald6
        ' 
        Gerald6.BackColor = Color.White
        Gerald6.BorderRadius = 20
        Gerald6.ForeColor = Color.Black
        Gerald6.GradientAngle = 90F
        Gerald6.GradientBottomColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald6.GradientTopColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald6.Location = New Point(162, 375)
        Gerald6.Margin = New Padding(4, 4, 4, 4)
        Gerald6.Name = "Gerald6"
        Gerald6.Size = New Size(50, 56)
        Gerald6.TabIndex = 12
        Gerald6.Text = "Gerald2"
        Gerald6.UseVisualStyleBackColor = False
        ' 
        ' txtb_c2
        ' 
        txtb_c2.BackColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        txtb_c2.BorderStyle = BorderStyle.None
        txtb_c2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtb_c2.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        txtb_c2.Location = New Point(100, 390)
        txtb_c2.Margin = New Padding(4, 4, 4, 4)
        txtb_c2.MaxLength = 1
        txtb_c2.Name = "txtb_c2"
        txtb_c2.Size = New Size(50, 28)
        txtb_c2.TabIndex = 11
        txtb_c2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Gerald5
        ' 
        Gerald5.BackColor = Color.White
        Gerald5.BorderRadius = 20
        Gerald5.ForeColor = Color.Black
        Gerald5.GradientAngle = 90F
        Gerald5.GradientBottomColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald5.GradientTopColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald5.Location = New Point(100, 375)
        Gerald5.Margin = New Padding(4, 4, 4, 4)
        Gerald5.Name = "Gerald5"
        Gerald5.Size = New Size(50, 56)
        Gerald5.TabIndex = 10
        Gerald5.Text = "Gerald2"
        Gerald5.UseVisualStyleBackColor = False
        ' 
        ' txtb_c1
        ' 
        txtb_c1.BackColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        txtb_c1.BorderStyle = BorderStyle.None
        txtb_c1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtb_c1.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        txtb_c1.Location = New Point(38, 390)
        txtb_c1.Margin = New Padding(4, 4, 4, 4)
        txtb_c1.MaxLength = 1
        txtb_c1.Name = "txtb_c1"
        txtb_c1.Size = New Size(50, 28)
        txtb_c1.TabIndex = 9
        txtb_c1.TextAlign = HorizontalAlignment.Center
        ' 
        ' lbl_verification
        ' 
        lbl_verification.AutoSize = True
        lbl_verification.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_verification.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        lbl_verification.Location = New Point(104, 224)
        lbl_verification.Margin = New Padding(4, 0, 4, 0)
        lbl_verification.Name = "lbl_verification"
        lbl_verification.Size = New Size(223, 41)
        lbl_verification.TabIndex = 8
        lbl_verification.Text = "VERIFICATION"
        ' 
        ' lbl_codesent
        ' 
        lbl_codesent.AutoSize = True
        lbl_codesent.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_codesent.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        lbl_codesent.Location = New Point(29, 274)
        lbl_codesent.Margin = New Padding(4, 0, 4, 0)
        lbl_codesent.Name = "lbl_codesent"
        lbl_codesent.Size = New Size(363, 63)
        lbl_codesent.TabIndex = 7
        lbl_codesent.Text = "A code has been sent to the email you provided." & vbCrLf & "Enter it here to verify your identity and reset" & vbCrLf & "your password."
        lbl_codesent.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' bg_code
        ' 
        bg_code.BackColor = Color.White
        bg_code.BorderRadius = 20
        bg_code.ForeColor = Color.Black
        bg_code.GradientAngle = 90F
        bg_code.GradientBottomColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        bg_code.GradientTopColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        bg_code.Location = New Point(38, 375)
        bg_code.Margin = New Padding(4, 4, 4, 4)
        bg_code.Name = "bg_code"
        bg_code.Size = New Size(50, 56)
        bg_code.TabIndex = 4
        bg_code.Text = "Gerald2"
        bg_code.UseVisualStyleBackColor = False
        ' 
        ' btn_verify
        ' 
        btn_verify.BackColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        btn_verify.BackgroundImageLayout = ImageLayout.None
        btn_verify.Enabled = False
        btn_verify.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        btn_verify.FlatStyle = FlatStyle.Flat
        btn_verify.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_verify.ForeColor = Color.White
        btn_verify.Location = New Point(110, 492)
        btn_verify.Margin = New Padding(4, 4, 4, 4)
        btn_verify.Name = "btn_verify"
        btn_verify.Size = New Size(220, 38)
        btn_verify.TabIndex = 0
        btn_verify.Text = "VERIFY"
        btn_verify.UseVisualStyleBackColor = False
        ' 
        ' btnbg_verify
        ' 
        btnbg_verify.BackColor = Color.White
        btnbg_verify.BorderRadius = 40
        btnbg_verify.Enabled = False
        btnbg_verify.ForeColor = Color.Black
        btnbg_verify.GradientAngle = 90F
        btnbg_verify.GradientBottomColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        btnbg_verify.GradientTopColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        btnbg_verify.Location = New Point(94, 486)
        btnbg_verify.Margin = New Padding(4, 4, 4, 4)
        btnbg_verify.Name = "btnbg_verify"
        btnbg_verify.Size = New Size(250, 50)
        btnbg_verify.TabIndex = 6
        btnbg_verify.Text = "Gerald3"
        btnbg_verify.UseVisualStyleBackColor = False
        ' 
        ' p_wc6
        ' 
        p_wc6.BackColor = Color.White
        p_wc6.BorderRadius = 20
        p_wc6.ForeColor = Color.Black
        p_wc6.GradientAngle = 90F
        p_wc6.GradientBottomColor = Color.FromArgb(CByte(202), CByte(48), CByte(48))
        p_wc6.GradientTopColor = Color.FromArgb(CByte(202), CByte(48), CByte(48))
        p_wc6.Location = New Point(346, 371)
        p_wc6.Margin = New Padding(4, 4, 4, 4)
        p_wc6.Name = "p_wc6"
        p_wc6.Size = New Size(56, 62)
        p_wc6.TabIndex = 26
        p_wc6.Text = "Gerald2"
        p_wc6.UseVisualStyleBackColor = False
        p_wc6.Visible = False
        ' 
        ' p_wc5
        ' 
        p_wc5.BackColor = Color.White
        p_wc5.BorderRadius = 20
        p_wc5.ForeColor = Color.Black
        p_wc5.GradientAngle = 90F
        p_wc5.GradientBottomColor = Color.FromArgb(CByte(202), CByte(48), CByte(48))
        p_wc5.GradientTopColor = Color.FromArgb(CByte(202), CByte(48), CByte(48))
        p_wc5.Location = New Point(284, 371)
        p_wc5.Margin = New Padding(4, 4, 4, 4)
        p_wc5.Name = "p_wc5"
        p_wc5.Size = New Size(56, 62)
        p_wc5.TabIndex = 25
        p_wc5.Text = "Gerald2"
        p_wc5.UseVisualStyleBackColor = False
        p_wc5.Visible = False
        ' 
        ' p_wc4
        ' 
        p_wc4.BackColor = Color.White
        p_wc4.BorderRadius = 20
        p_wc4.ForeColor = Color.Black
        p_wc4.GradientAngle = 90F
        p_wc4.GradientBottomColor = Color.FromArgb(CByte(202), CByte(48), CByte(48))
        p_wc4.GradientTopColor = Color.FromArgb(CByte(202), CByte(48), CByte(48))
        p_wc4.Location = New Point(221, 371)
        p_wc4.Margin = New Padding(4, 4, 4, 4)
        p_wc4.Name = "p_wc4"
        p_wc4.Size = New Size(56, 62)
        p_wc4.TabIndex = 24
        p_wc4.Text = "Gerald2"
        p_wc4.UseVisualStyleBackColor = False
        p_wc4.Visible = False
        ' 
        ' p_wc3
        ' 
        p_wc3.BackColor = Color.White
        p_wc3.BorderRadius = 20
        p_wc3.ForeColor = Color.Black
        p_wc3.GradientAngle = 90F
        p_wc3.GradientBottomColor = Color.FromArgb(CByte(202), CByte(48), CByte(48))
        p_wc3.GradientTopColor = Color.FromArgb(CByte(202), CByte(48), CByte(48))
        p_wc3.Location = New Point(159, 371)
        p_wc3.Margin = New Padding(4, 4, 4, 4)
        p_wc3.Name = "p_wc3"
        p_wc3.Size = New Size(56, 62)
        p_wc3.TabIndex = 23
        p_wc3.Text = "Gerald2"
        p_wc3.UseVisualStyleBackColor = False
        p_wc3.Visible = False
        ' 
        ' p_wc2
        ' 
        p_wc2.BackColor = Color.White
        p_wc2.BorderRadius = 20
        p_wc2.ForeColor = Color.Black
        p_wc2.GradientAngle = 90F
        p_wc2.GradientBottomColor = Color.FromArgb(CByte(202), CByte(48), CByte(48))
        p_wc2.GradientTopColor = Color.FromArgb(CByte(202), CByte(48), CByte(48))
        p_wc2.Location = New Point(96, 371)
        p_wc2.Margin = New Padding(4, 4, 4, 4)
        p_wc2.Name = "p_wc2"
        p_wc2.Size = New Size(56, 62)
        p_wc2.TabIndex = 22
        p_wc2.Text = "Gerald2"
        p_wc2.UseVisualStyleBackColor = False
        p_wc2.Visible = False
        ' 
        ' p_wc1
        ' 
        p_wc1.BackColor = Color.White
        p_wc1.BorderRadius = 20
        p_wc1.ForeColor = Color.Black
        p_wc1.GradientAngle = 90F
        p_wc1.GradientBottomColor = Color.FromArgb(CByte(202), CByte(48), CByte(48))
        p_wc1.GradientTopColor = Color.FromArgb(CByte(202), CByte(48), CByte(48))
        p_wc1.Location = New Point(34, 371)
        p_wc1.Margin = New Padding(4, 4, 4, 4)
        p_wc1.Name = "p_wc1"
        p_wc1.Size = New Size(56, 62)
        p_wc1.TabIndex = 21
        p_wc1.Text = "Gerald2"
        p_wc1.UseVisualStyleBackColor = False
        p_wc1.Visible = False
        ' 
        ' lbl_besure
        ' 
        lbl_besure.AutoSize = True
        lbl_besure.BackColor = Color.Transparent
        lbl_besure.Enabled = False
        lbl_besure.Font = New Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_besure.ForeColor = Color.White
        lbl_besure.Location = New Point(55, 298)
        lbl_besure.Margin = New Padding(4, 0, 4, 0)
        lbl_besure.Name = "lbl_besure"
        lbl_besure.Size = New Size(437, 76)
        lbl_besure.TabIndex = 11
        lbl_besure.Text = "Be sure to properly remember your" & vbCrLf & "login credentials!"
        lbl_besure.TextAlign = ContentAlignment.MiddleCenter
        lbl_besure.Visible = False
        ' 
        ' lbl_ready
        ' 
        lbl_ready.AutoSize = True
        lbl_ready.BackColor = Color.Transparent
        lbl_ready.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_ready.ForeColor = Color.White
        lbl_ready.Location = New Point(69, 222)
        lbl_ready.Margin = New Padding(4, 0, 4, 0)
        lbl_ready.Name = "lbl_ready"
        lbl_ready.Size = New Size(413, 61)
        lbl_ready.TabIndex = 10
        lbl_ready.Text = "READY TO LOGIN?"
        lbl_ready.Visible = False
        ' 
        ' p_forgotpass
        ' 
        p_forgotpass.BackColor = Color.White
        p_forgotpass.CausesValidation = False
        p_forgotpass.Controls.Add(pb_emailerror)
        p_forgotpass.Controls.Add(lbl_resetpass)
        p_forgotpass.Controls.Add(lbl_emailme)
        p_forgotpass.Controls.Add(txtb_email)
        p_forgotpass.Controls.Add(btn_reset)
        p_forgotpass.Controls.Add(Gerald8)
        p_forgotpass.Controls.Add(PictureBox8)
        p_forgotpass.Controls.Add(Gerald9)
        p_forgotpass.Controls.Add(pb_wemail)
        p_forgotpass.Location = New Point(1000, 0)
        p_forgotpass.Margin = New Padding(4, 4, 4, 4)
        p_forgotpass.Name = "p_forgotpass"
        p_forgotpass.Size = New Size(438, 750)
        p_forgotpass.TabIndex = 9
        ' 
        ' pb_emailerror
        ' 
        pb_emailerror.BackColor = Color.Transparent
        pb_emailerror.Image = My.Resources.Resources.icon_exclamationcircle
        pb_emailerror.Location = New Point(358, 352)
        pb_emailerror.Margin = New Padding(4, 4, 4, 4)
        pb_emailerror.Name = "pb_emailerror"
        pb_emailerror.Size = New Size(25, 25)
        pb_emailerror.SizeMode = PictureBoxSizeMode.Zoom
        pb_emailerror.TabIndex = 23
        pb_emailerror.TabStop = False
        pb_emailerror.Visible = False
        ' 
        ' lbl_resetpass
        ' 
        lbl_resetpass.AutoSize = True
        lbl_resetpass.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_resetpass.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        lbl_resetpass.Location = New Point(28, 225)
        lbl_resetpass.Margin = New Padding(4, 0, 4, 0)
        lbl_resetpass.Name = "lbl_resetpass"
        lbl_resetpass.Size = New Size(369, 41)
        lbl_resetpass.TabIndex = 8
        lbl_resetpass.Text = "RESET YOUR PASSWORD"
        ' 
        ' lbl_emailme
        ' 
        lbl_emailme.AutoSize = True
        lbl_emailme.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_emailme.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        lbl_emailme.Location = New Point(41, 274)
        lbl_emailme.Margin = New Padding(4, 0, 4, 0)
        lbl_emailme.Name = "lbl_emailme"
        lbl_emailme.Size = New Size(338, 42)
        lbl_emailme.TabIndex = 7
        lbl_emailme.Text = "Enter your email address or username and" & vbCrLf & "we’ll send you a code to reset your password"
        lbl_emailme.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtb_email
        ' 
        txtb_email.BackColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        txtb_email.BorderStyle = BorderStyle.None
        txtb_email.Font = New Font("Segoe UI", 9F)
        txtb_email.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        txtb_email.Location = New Point(109, 386)
        txtb_email.Margin = New Padding(4, 4, 4, 4)
        txtb_email.Name = "txtb_email"
        txtb_email.PlaceholderText = "Email"
        txtb_email.Size = New Size(264, 24)
        txtb_email.TabIndex = 0
        ' 
        ' btn_reset
        ' 
        btn_reset.BackColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        btn_reset.BackgroundImageLayout = ImageLayout.None
        btn_reset.Enabled = False
        btn_reset.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        btn_reset.FlatStyle = FlatStyle.Flat
        btn_reset.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_reset.ForeColor = Color.White
        btn_reset.Location = New Point(109, 486)
        btn_reset.Margin = New Padding(4, 4, 4, 4)
        btn_reset.Name = "btn_reset"
        btn_reset.Size = New Size(220, 38)
        btn_reset.TabIndex = 0
        btn_reset.Text = "RESET PASSWORD"
        btn_reset.UseVisualStyleBackColor = False
        ' 
        ' Gerald8
        ' 
        Gerald8.BackColor = Color.White
        Gerald8.BorderRadius = 40
        Gerald8.ForeColor = Color.Black
        Gerald8.GradientAngle = 90F
        Gerald8.GradientBottomColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        Gerald8.GradientTopColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        Gerald8.Location = New Point(92, 480)
        Gerald8.Margin = New Padding(4, 4, 4, 4)
        Gerald8.Name = "Gerald8"
        Gerald8.Size = New Size(250, 50)
        Gerald8.TabIndex = 6
        Gerald8.Text = "Gerald3"
        Gerald8.UseVisualStyleBackColor = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = My.Resources.Resources.icon_envelope
        PictureBox8.Location = New Point(66, 388)
        PictureBox8.Margin = New Padding(4, 4, 4, 4)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(21, 21)
        PictureBox8.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox8.TabIndex = 2
        PictureBox8.TabStop = False
        ' 
        ' Gerald9
        ' 
        Gerald9.BackColor = Color.White
        Gerald9.BorderRadius = 20
        Gerald9.ForeColor = Color.Black
        Gerald9.GradientAngle = 90F
        Gerald9.GradientBottomColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald9.GradientTopColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald9.Location = New Point(42, 371)
        Gerald9.Margin = New Padding(4, 4, 4, 4)
        Gerald9.Name = "Gerald9"
        Gerald9.Size = New Size(350, 50)
        Gerald9.TabIndex = 4
        Gerald9.Text = "Gerald2"
        Gerald9.UseVisualStyleBackColor = False
        ' 
        ' pb_wemail
        ' 
        pb_wemail.BackColor = Color.White
        pb_wemail.BorderRadius = 21
        pb_wemail.FlatAppearance.BorderColor = Color.Red
        pb_wemail.ForeColor = Color.Black
        pb_wemail.GradientAngle = 90F
        pb_wemail.GradientBottomColor = Color.FromArgb(CByte(202), CByte(48), CByte(48))
        pb_wemail.GradientTopColor = Color.FromArgb(CByte(202), CByte(48), CByte(48))
        pb_wemail.Location = New Point(39, 368)
        pb_wemail.Margin = New Padding(4, 4, 4, 4)
        pb_wemail.Name = "pb_wemail"
        pb_wemail.Size = New Size(356, 56)
        pb_wemail.TabIndex = 23
        pb_wemail.Text = "Gerald13"
        pb_wemail.UseVisualStyleBackColor = False
        pb_wemail.Visible = False
        ' 
        ' lbl_fpass
        ' 
        lbl_fpass.AutoSize = True
        lbl_fpass.BackColor = Color.Transparent
        lbl_fpass.Enabled = False
        lbl_fpass.Font = New Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_fpass.ForeColor = Color.White
        lbl_fpass.Location = New Point(636, 482)
        lbl_fpass.Margin = New Padding(4, 0, 4, 0)
        lbl_fpass.Name = "lbl_fpass"
        lbl_fpass.Size = New Size(154, 30)
        lbl_fpass.TabIndex = 8
        lbl_fpass.Text = "FORGOT YOUR PASSWORD?" & vbCrLf & "RESET IT HERE"
        lbl_fpass.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl_login
        ' 
        lbl_login.AutoSize = True
        lbl_login.BackColor = Color.Transparent
        lbl_login.Enabled = False
        lbl_login.Font = New Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_login.ForeColor = Color.White
        lbl_login.Location = New Point(494, 281)
        lbl_login.Margin = New Padding(4, 0, 4, 0)
        lbl_login.Name = "lbl_login"
        lbl_login.Size = New Size(438, 76)
        lbl_login.TabIndex = 1
        lbl_login.Text = "Log in and access, view, or manage" & vbCrLf & "grades and classes."
        lbl_login.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl_welcome
        ' 
        lbl_welcome.AutoSize = True
        lbl_welcome.BackColor = Color.Transparent
        lbl_welcome.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_welcome.ForeColor = Color.White
        lbl_welcome.Location = New Point(550, 206)
        lbl_welcome.Margin = New Padding(4, 0, 4, 0)
        lbl_welcome.Name = "lbl_welcome"
        lbl_welcome.Size = New Size(329, 76)
        lbl_welcome.TabIndex = 0
        lbl_welcome.Text = "WELCOME!"
        ' 
        ' btn_forgotpass
        ' 
        btn_forgotpass.BackColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        btn_forgotpass.BackgroundImageLayout = ImageLayout.None
        btn_forgotpass.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        btn_forgotpass.FlatStyle = FlatStyle.Flat
        btn_forgotpass.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_forgotpass.ForeColor = Color.White
        btn_forgotpass.Location = New Point(608, 435)
        btn_forgotpass.Margin = New Padding(4, 4, 4, 4)
        btn_forgotpass.Name = "btn_forgotpass"
        btn_forgotpass.Size = New Size(220, 38)
        btn_forgotpass.TabIndex = 7
        btn_forgotpass.Text = "FORGOT PASSWORD"
        btn_forgotpass.UseVisualStyleBackColor = False
        ' 
        ' btnbg_forgotpass
        ' 
        btnbg_forgotpass.BackColor = Color.White
        btnbg_forgotpass.BorderRadius = 40
        btnbg_forgotpass.ForeColor = Color.Black
        btnbg_forgotpass.GradientAngle = 90F
        btnbg_forgotpass.GradientBottomColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        btnbg_forgotpass.GradientTopColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        btnbg_forgotpass.Location = New Point(594, 431)
        btnbg_forgotpass.Margin = New Padding(4, 4, 4, 4)
        btnbg_forgotpass.Name = "btnbg_forgotpass"
        btnbg_forgotpass.Size = New Size(244, 44)
        btnbg_forgotpass.TabIndex = 7
        btnbg_forgotpass.Text = "Gerald4"
        btnbg_forgotpass.UseVisualStyleBackColor = False
        ' 
        ' bg_fpass
        ' 
        bg_fpass.BackColor = Color.White
        bg_fpass.BorderRadius = 40
        bg_fpass.ForeColor = Color.Black
        bg_fpass.GradientAngle = 90F
        bg_fpass.GradientBottomColor = Color.White
        bg_fpass.GradientTopColor = Color.White
        bg_fpass.Location = New Point(591, 429)
        bg_fpass.Margin = New Padding(4, 4, 4, 4)
        bg_fpass.Name = "bg_fpass"
        bg_fpass.Size = New Size(250, 50)
        bg_fpass.TabIndex = 7
        bg_fpass.Text = "Gerald4"
        bg_fpass.UseVisualStyleBackColor = False
        ' 
        ' btn_signin
        ' 
        btn_signin.BackColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        btn_signin.BackgroundImageLayout = ImageLayout.None
        btn_signin.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        btn_signin.FlatStyle = FlatStyle.Flat
        btn_signin.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_signin.ForeColor = Color.White
        btn_signin.Location = New Point(170, 441)
        btn_signin.Margin = New Padding(4, 4, 4, 4)
        btn_signin.Name = "btn_signin"
        btn_signin.Size = New Size(220, 38)
        btn_signin.TabIndex = 15
        btn_signin.Text = "SIGN IN"
        btn_signin.UseVisualStyleBackColor = False
        btn_signin.Visible = False
        ' 
        ' btnbg_signin
        ' 
        btnbg_signin.BackColor = Color.White
        btnbg_signin.BorderRadius = 40
        btnbg_signin.ForeColor = Color.Black
        btnbg_signin.GradientAngle = 90F
        btnbg_signin.GradientBottomColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        btnbg_signin.GradientTopColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        btnbg_signin.Location = New Point(156, 438)
        btnbg_signin.Margin = New Padding(4, 4, 4, 4)
        btnbg_signin.Name = "btnbg_signin"
        btnbg_signin.Size = New Size(244, 44)
        btnbg_signin.TabIndex = 16
        btnbg_signin.Text = "Gerald4"
        btnbg_signin.UseVisualStyleBackColor = False
        btnbg_signin.Visible = False
        ' 
        ' bg_signin
        ' 
        bg_signin.BackColor = Color.White
        bg_signin.BorderRadius = 40
        bg_signin.ForeColor = Color.Black
        bg_signin.GradientAngle = 90F
        bg_signin.GradientBottomColor = Color.White
        bg_signin.GradientTopColor = Color.White
        bg_signin.Location = New Point(154, 435)
        bg_signin.Margin = New Padding(4, 4, 4, 4)
        bg_signin.Name = "bg_signin"
        bg_signin.Size = New Size(250, 50)
        bg_signin.TabIndex = 17
        bg_signin.Text = "Gerald4"
        bg_signin.UseVisualStyleBackColor = False
        bg_signin.Visible = False
        ' 
        ' ds_login
        ' 
        ds_login.BackColor = Color.Transparent
        ds_login.Image = My.Resources.Resources.dropshadow_right
        ds_login.Location = New Point(372, 0)
        ds_login.Margin = New Padding(4, 4, 4, 4)
        ds_login.Name = "ds_login"
        ds_login.Size = New Size(96, 761)
        ds_login.SizeMode = PictureBoxSizeMode.StretchImage
        ds_login.TabIndex = 20
        ds_login.TabStop = False
        ' 
        ' LoginForgot
        ' 
        AllowDrop = True
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 750)
        Controls.Add(p_base)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 4, 4, 4)
        Name = "LoginForgot"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginForgot"
        p_login.ResumeLayout(False)
        p_login.PerformLayout()
        CType(pb_wid, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        p_base.ResumeLayout(False)
        p_base.PerformLayout()
        CType(ds_forgot, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        p_changepass.ResumeLayout(False)
        p_changepass.PerformLayout()
        CType(btn_eye, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        p_verification.ResumeLayout(False)
        p_verification.PerformLayout()
        CType(btn_back, ComponentModel.ISupportInitialize).EndInit()
        p_forgotpass.ResumeLayout(False)
        p_forgotpass.PerformLayout()
        CType(pb_emailerror, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(ds_login, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents p_login As Panel
    Friend WithEvents p_base As Panel
    Friend WithEvents lbl_invalid As Label
    Friend WithEvents Gerald1 As gerald.Gerald
    Friend WithEvents txtb_password As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Gerald2 As gerald.Gerald
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Gerald3 As gerald.Gerald
    Friend WithEvents enterbttn As Button
    Friend WithEvents lbl_welcome As Label
    Friend WithEvents bg_fpass As gerald.Gerald
    Friend WithEvents btnbg_forgotpass As gerald.Gerald
    Friend WithEvents lbl_fpass As Label
    Friend WithEvents btn_forgotpass As Button
    Friend WithEvents p_forgotpass As Panel
    Friend WithEvents lbl_emailme As Label
    Friend WithEvents txtb_email As TextBox
    Friend WithEvents btn_reset As Button
    Friend WithEvents Gerald8 As gerald.Gerald
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Gerald9 As gerald.Gerald
    Friend WithEvents lbl_resetpass As Label
    Friend WithEvents lbl_login As Label
    Friend WithEvents lbl_besure As Label
    Friend WithEvents lbl_ready As Label
    Friend WithEvents btn_signin As Button
    Friend WithEvents btnbg_signin As gerald.Gerald
    Friend WithEvents bg_signin As gerald.Gerald
    Friend WithEvents p_verification As Panel
    Friend WithEvents lbl_verification As Label
    Friend WithEvents lbl_codesent As Label
    Friend WithEvents btn_verify As Button
    Friend WithEvents btnbg_verify As gerald.Gerald
    Friend WithEvents txtb_c1 As TextBox
    Friend WithEvents bg_code As gerald.Gerald
    Friend WithEvents txtb_c6 As TextBox
    Friend WithEvents Gerald11 As gerald.Gerald
    Friend WithEvents txtb_c5 As TextBox
    Friend WithEvents Gerald10 As gerald.Gerald
    Friend WithEvents txtb_c4 As TextBox
    Friend WithEvents Gerald7 As gerald.Gerald
    Friend WithEvents txtb_c3 As TextBox
    Friend WithEvents Gerald6 As gerald.Gerald
    Friend WithEvents txtb_c2 As TextBox
    Friend WithEvents Gerald5 As gerald.Gerald
    Friend WithEvents btn_back As PictureBox
    Friend WithEvents p_changepass As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_confirm As Button
    Friend WithEvents Gerald17 As gerald.Gerald
    Friend WithEvents txtb_newpassword As TextBox
    Friend WithEvents Gerald4 As gerald.Gerald
    Friend WithEvents txtb_confirmpassword As TextBox
    Friend WithEvents Gerald12 As gerald.Gerald
    Friend WithEvents btn_eye As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents ds_login As PictureBox
    Friend WithEvents ds_forgot As PictureBox
    Friend WithEvents txtb_userid As TextBox
    Friend WithEvents p_wid As gerald.Gerald
    Friend WithEvents pb_wid As PictureBox
    Friend WithEvents p_wpassword As gerald.Gerald
    Friend WithEvents pb_emailerror As PictureBox
    Friend WithEvents pb_wemail As gerald.Gerald
    Friend WithEvents p_wc1 As gerald.Gerald
    Friend WithEvents p_wc6 As gerald.Gerald
    Friend WithEvents p_wc5 As gerald.Gerald
    Friend WithEvents p_wc4 As gerald.Gerald
    Friend WithEvents p_wc3 As gerald.Gerald
    Friend WithEvents p_wc2 As gerald.Gerald
    Friend WithEvents lbl_wrongcode As Label
End Class
