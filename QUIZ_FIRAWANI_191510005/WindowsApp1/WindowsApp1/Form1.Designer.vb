<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CboxAPCH = New System.Windows.Forms.CheckBox()
        Me.CboxNUP = New System.Windows.Forms.CheckBox()
        Me.CboxBA = New System.Windows.Forms.CheckBox()
        Me.CboxN = New System.Windows.Forms.CheckBox()
        Me.CboxBP = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtJlhAPCH = New System.Windows.Forms.TextBox()
        Me.TxtJlhNUP = New System.Windows.Forms.TextBox()
        Me.TxtJlhBA = New System.Windows.Forms.TextBox()
        Me.TxtJlhN = New System.Windows.Forms.TextBox()
        Me.TxtJlhBP = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnHitung = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblTBayar = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(315, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rumah Makan"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtJlhBP)
        Me.GroupBox1.Controls.Add(Me.TxtJlhN)
        Me.GroupBox1.Controls.Add(Me.TxtJlhBA)
        Me.GroupBox1.Controls.Add(Me.TxtJlhNUP)
        Me.GroupBox1.Controls.Add(Me.TxtJlhAPCH)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CboxBP)
        Me.GroupBox1.Controls.Add(Me.CboxN)
        Me.GroupBox1.Controls.Add(Me.CboxBA)
        Me.GroupBox1.Controls.Add(Me.CboxNUP)
        Me.GroupBox1.Controls.Add(Me.CboxAPCH)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(68, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(713, 243)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu Makanan"
        '
        'CboxAPCH
        '
        Me.CboxAPCH.AutoSize = True
        Me.CboxAPCH.Location = New System.Drawing.Point(6, 42)
        Me.CboxAPCH.Name = "CboxAPCH"
        Me.CboxAPCH.Size = New System.Drawing.Size(257, 29)
        Me.CboxAPCH.TabIndex = 0
        Me.CboxAPCH.Text = "Ayam Penyet Cabe Hijau"
        Me.CboxAPCH.UseVisualStyleBackColor = True
        '
        'CboxNUP
        '
        Me.CboxNUP.AutoSize = True
        Me.CboxNUP.Location = New System.Drawing.Point(6, 77)
        Me.CboxNUP.Name = "CboxNUP"
        Me.CboxNUP.Size = New System.Drawing.Size(189, 29)
        Me.CboxNUP.TabIndex = 1
        Me.CboxNUP.Text = "Nasi Udang Petai"
        Me.CboxNUP.UseVisualStyleBackColor = True
        '
        'CboxBA
        '
        Me.CboxBA.AutoSize = True
        Me.CboxBA.Location = New System.Drawing.Point(6, 112)
        Me.CboxBA.Name = "CboxBA"
        Me.CboxBA.Size = New System.Drawing.Size(144, 29)
        Me.CboxBA.TabIndex = 2
        Me.CboxBA.Text = "Bakso Atom"
        Me.CboxBA.UseVisualStyleBackColor = True
        '
        'CboxN
        '
        Me.CboxN.AutoSize = True
        Me.CboxN.Location = New System.Drawing.Point(6, 147)
        Me.CboxN.Name = "CboxN"
        Me.CboxN.Size = New System.Drawing.Size(106, 29)
        Me.CboxN.TabIndex = 3
        Me.CboxN.Text = "Nasi 3T"
        Me.CboxN.UseVisualStyleBackColor = True
        '
        'CboxBP
        '
        Me.CboxBP.AutoSize = True
        Me.CboxBP.Location = New System.Drawing.Point(6, 182)
        Me.CboxBP.Name = "CboxBP"
        Me.CboxBP.Size = New System.Drawing.Size(160, 29)
        Me.CboxBP.TabIndex = 4
        Me.CboxBP.Text = "Bebek Penyet"
        Me.CboxBP.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(456, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Rp. 25.000.-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(456, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Rp. 28.000.-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(456, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Rp. 20.000.-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(456, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Rp. 18.000.-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(456, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Rp. 25.000.-"
        '
        'TxtJlhAPCH
        '
        Me.TxtJlhAPCH.Location = New System.Drawing.Point(608, 47)
        Me.TxtJlhAPCH.Name = "TxtJlhAPCH"
        Me.TxtJlhAPCH.Size = New System.Drawing.Size(48, 30)
        Me.TxtJlhAPCH.TabIndex = 10
        '
        'TxtJlhNUP
        '
        Me.TxtJlhNUP.Location = New System.Drawing.Point(607, 83)
        Me.TxtJlhNUP.Name = "TxtJlhNUP"
        Me.TxtJlhNUP.Size = New System.Drawing.Size(49, 30)
        Me.TxtJlhNUP.TabIndex = 11
        '
        'TxtJlhBA
        '
        Me.TxtJlhBA.Location = New System.Drawing.Point(607, 119)
        Me.TxtJlhBA.Name = "TxtJlhBA"
        Me.TxtJlhBA.Size = New System.Drawing.Size(49, 30)
        Me.TxtJlhBA.TabIndex = 12
        '
        'TxtJlhN
        '
        Me.TxtJlhN.Location = New System.Drawing.Point(607, 155)
        Me.TxtJlhN.Name = "TxtJlhN"
        Me.TxtJlhN.Size = New System.Drawing.Size(49, 30)
        Me.TxtJlhN.TabIndex = 13
        '
        'TxtJlhBP
        '
        Me.TxtJlhBP.Location = New System.Drawing.Point(607, 191)
        Me.TxtJlhBP.Name = "TxtJlhBP"
        Me.TxtJlhBP.Size = New System.Drawing.Size(49, 30)
        Me.TxtJlhBP.TabIndex = 14
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnKeluar)
        Me.GroupBox2.Controls.Add(Me.BtnReset)
        Me.GroupBox2.Controls.Add(Me.BtnHitung)
        Me.GroupBox2.Location = New System.Drawing.Point(291, 324)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(490, 111)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proses"
        '
        'BtnHitung
        '
        Me.BtnHitung.Location = New System.Drawing.Point(59, 46)
        Me.BtnHitung.Name = "BtnHitung"
        Me.BtnHitung.Size = New System.Drawing.Size(105, 33)
        Me.BtnHitung.TabIndex = 0
        Me.BtnHitung.Text = "Hitung"
        Me.BtnHitung.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(196, 46)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(105, 32)
        Me.BtnReset.TabIndex = 1
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Location = New System.Drawing.Point(329, 46)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(104, 32)
        Me.BtnKeluar.TabIndex = 2
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(63, 464)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 29)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Total Bayar :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(216, 468)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 25)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Rp"
        '
        'LblTBayar
        '
        Me.LblTBayar.Location = New System.Drawing.Point(281, 469)
        Me.LblTBayar.Name = "LblTBayar"
        Me.LblTBayar.Size = New System.Drawing.Size(261, 26)
        Me.LblTBayar.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 577)
        Me.Controls.Add(Me.LblTBayar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Menu Makanan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtJlhBP As TextBox
    Friend WithEvents TxtJlhN As TextBox
    Friend WithEvents TxtJlhBA As TextBox
    Friend WithEvents TxtJlhNUP As TextBox
    Friend WithEvents TxtJlhAPCH As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CboxBP As CheckBox
    Friend WithEvents CboxN As CheckBox
    Friend WithEvents CboxBA As CheckBox
    Friend WithEvents CboxNUP As CheckBox
    Friend WithEvents CboxAPCH As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents BtnHitung As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LblTBayar As TextBox
End Class
