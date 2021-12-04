<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.KeyGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KeyCalculateButton = New System.Windows.Forms.Button()
        Me.PublicKeyTextBox = New System.Windows.Forms.TextBox()
        Me.PrivateKeyTextBox = New System.Windows.Forms.TextBox()
        Me.PublicLabel = New System.Windows.Forms.Label()
        Me.PrivateLabel = New System.Windows.Forms.Label()
        Me.qKeyTextBox = New System.Windows.Forms.TextBox()
        Me.pKeyTextBox = New System.Windows.Forms.TextBox()
        Me.QLabel = New System.Windows.Forms.Label()
        Me.PLabel = New System.Windows.Forms.Label()
        Me.EncryptionGroupBox = New System.Windows.Forms.GroupBox()
        Me.EncrpytMsgListBox = New System.Windows.Forms.ListBox()
        Me.EncryptMsgLabel = New System.Windows.Forms.Label()
        Me.IntegerConvListBox = New System.Windows.Forms.ListBox()
        Me.IntegerLabel = New System.Windows.Forms.Label()
        Me.EncryptButton = New System.Windows.Forms.Button()
        Me.PlaintextLabel = New System.Windows.Forms.Label()
        Me.MessageEncryptTextBox = New System.Windows.Forms.TextBox()
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.eEncryptTextBox = New System.Windows.Forms.TextBox()
        Me.nEncryptTextBox = New System.Windows.Forms.TextBox()
        Me.eLabel = New System.Windows.Forms.Label()
        Me.nLabel = New System.Windows.Forms.Label()
        Me.PublicEnterLabel = New System.Windows.Forms.Label()
        Me.DecryptGroupBox = New System.Windows.Forms.GroupBox()
        Me.DecryptMsgListBox = New System.Windows.Forms.ListBox()
        Me.DecryptMSGLabel = New System.Windows.Forms.Label()
        Me.DecryptIntListBox = New System.Windows.Forms.ListBox()
        Me.DecryptIntLabel = New System.Windows.Forms.Label()
        Me.DecryptButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MessageDecryptTextBox = New System.Windows.Forms.TextBox()
        Me.DecryptLabel = New System.Windows.Forms.Label()
        Me.dDecryptTextBox = New System.Windows.Forms.TextBox()
        Me.dDecryptLabel = New System.Windows.Forms.Label()
        Me.PrivateDecryptLabel = New System.Windows.Forms.Label()
        Me.eDecryptTextBox = New System.Windows.Forms.TextBox()
        Me.nDecryptTextBox = New System.Windows.Forms.TextBox()
        Me.eDecryptLabel = New System.Windows.Forms.Label()
        Me.nDecryptLabel = New System.Windows.Forms.Label()
        Me.PublicDecryptLabel = New System.Windows.Forms.Label()
        Me.CreationLabel = New System.Windows.Forms.Label()
        Me.InfoLabel = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.KeyGroupBox.SuspendLayout()
        Me.EncryptionGroupBox.SuspendLayout()
        Me.DecryptGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'KeyGroupBox
        '
        Me.KeyGroupBox.Controls.Add(Me.Label1)
        Me.KeyGroupBox.Controls.Add(Me.KeyCalculateButton)
        Me.KeyGroupBox.Controls.Add(Me.PublicKeyTextBox)
        Me.KeyGroupBox.Controls.Add(Me.PrivateKeyTextBox)
        Me.KeyGroupBox.Controls.Add(Me.PublicLabel)
        Me.KeyGroupBox.Controls.Add(Me.PrivateLabel)
        Me.KeyGroupBox.Controls.Add(Me.qKeyTextBox)
        Me.KeyGroupBox.Controls.Add(Me.pKeyTextBox)
        Me.KeyGroupBox.Controls.Add(Me.QLabel)
        Me.KeyGroupBox.Controls.Add(Me.PLabel)
        Me.KeyGroupBox.Location = New System.Drawing.Point(13, 13)
        Me.KeyGroupBox.Name = "KeyGroupBox"
        Me.KeyGroupBox.Size = New System.Drawing.Size(385, 137)
        Me.KeyGroupBox.TabIndex = 0
        Me.KeyGroupBox.TabStop = False
        Me.KeyGroupBox.Text = "Key Generator"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Please enter two large prime numbers"
        '
        'KeyCalculateButton
        '
        Me.KeyCalculateButton.Location = New System.Drawing.Point(29, 100)
        Me.KeyCalculateButton.Name = "KeyCalculateButton"
        Me.KeyCalculateButton.Size = New System.Drawing.Size(100, 23)
        Me.KeyCalculateButton.TabIndex = 8
        Me.KeyCalculateButton.Text = "Calculate Key"
        Me.KeyCalculateButton.UseVisualStyleBackColor = True
        '
        'PublicKeyTextBox
        '
        Me.PublicKeyTextBox.Location = New System.Drawing.Point(236, 74)
        Me.PublicKeyTextBox.Name = "PublicKeyTextBox"
        Me.PublicKeyTextBox.ReadOnly = True
        Me.PublicKeyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PublicKeyTextBox.TabIndex = 7
        '
        'PrivateKeyTextBox
        '
        Me.PrivateKeyTextBox.Location = New System.Drawing.Point(236, 47)
        Me.PrivateKeyTextBox.Name = "PrivateKeyTextBox"
        Me.PrivateKeyTextBox.ReadOnly = True
        Me.PrivateKeyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrivateKeyTextBox.TabIndex = 6
        '
        'PublicLabel
        '
        Me.PublicLabel.AutoSize = True
        Me.PublicLabel.Location = New System.Drawing.Point(151, 77)
        Me.PublicLabel.Name = "PublicLabel"
        Me.PublicLabel.Size = New System.Drawing.Size(84, 13)
        Me.PublicLabel.TabIndex = 5
        Me.PublicLabel.Text = "Public Key (n,e):"
        '
        'PrivateLabel
        '
        Me.PrivateLabel.AutoSize = True
        Me.PrivateLabel.Location = New System.Drawing.Point(151, 50)
        Me.PrivateLabel.Name = "PrivateLabel"
        Me.PrivateLabel.Size = New System.Drawing.Size(79, 13)
        Me.PrivateLabel.TabIndex = 4
        Me.PrivateLabel.Text = "Private Key (d):"
        '
        'qKeyTextBox
        '
        Me.qKeyTextBox.Location = New System.Drawing.Point(29, 74)
        Me.qKeyTextBox.Name = "qKeyTextBox"
        Me.qKeyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.qKeyTextBox.TabIndex = 3
        '
        'pKeyTextBox
        '
        Me.pKeyTextBox.Location = New System.Drawing.Point(29, 47)
        Me.pKeyTextBox.Name = "pKeyTextBox"
        Me.pKeyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.pKeyTextBox.TabIndex = 2
        '
        'QLabel
        '
        Me.QLabel.AutoSize = True
        Me.QLabel.Location = New System.Drawing.Point(7, 77)
        Me.QLabel.Name = "QLabel"
        Me.QLabel.Size = New System.Drawing.Size(16, 13)
        Me.QLabel.TabIndex = 1
        Me.QLabel.Text = "q:"
        '
        'PLabel
        '
        Me.PLabel.AutoSize = True
        Me.PLabel.Location = New System.Drawing.Point(7, 50)
        Me.PLabel.Name = "PLabel"
        Me.PLabel.Size = New System.Drawing.Size(16, 13)
        Me.PLabel.TabIndex = 0
        Me.PLabel.Text = "p:"
        '
        'EncryptionGroupBox
        '
        Me.EncryptionGroupBox.BackColor = System.Drawing.SystemColors.Control
        Me.EncryptionGroupBox.Controls.Add(Me.EncrpytMsgListBox)
        Me.EncryptionGroupBox.Controls.Add(Me.EncryptMsgLabel)
        Me.EncryptionGroupBox.Controls.Add(Me.IntegerConvListBox)
        Me.EncryptionGroupBox.Controls.Add(Me.IntegerLabel)
        Me.EncryptionGroupBox.Controls.Add(Me.EncryptButton)
        Me.EncryptionGroupBox.Controls.Add(Me.PlaintextLabel)
        Me.EncryptionGroupBox.Controls.Add(Me.MessageEncryptTextBox)
        Me.EncryptionGroupBox.Controls.Add(Me.MessageLabel)
        Me.EncryptionGroupBox.Controls.Add(Me.eEncryptTextBox)
        Me.EncryptionGroupBox.Controls.Add(Me.nEncryptTextBox)
        Me.EncryptionGroupBox.Controls.Add(Me.eLabel)
        Me.EncryptionGroupBox.Controls.Add(Me.nLabel)
        Me.EncryptionGroupBox.Controls.Add(Me.PublicEnterLabel)
        Me.EncryptionGroupBox.Location = New System.Drawing.Point(13, 156)
        Me.EncryptionGroupBox.Name = "EncryptionGroupBox"
        Me.EncryptionGroupBox.Size = New System.Drawing.Size(385, 254)
        Me.EncryptionGroupBox.TabIndex = 1
        Me.EncryptionGroupBox.TabStop = False
        Me.EncryptionGroupBox.Text = "Encryption"
        '
        'EncrpytMsgListBox
        '
        Me.EncrpytMsgListBox.FormattingEnabled = True
        Me.EncrpytMsgListBox.Location = New System.Drawing.Point(206, 145)
        Me.EncrpytMsgListBox.Name = "EncrpytMsgListBox"
        Me.EncrpytMsgListBox.Size = New System.Drawing.Size(120, 95)
        Me.EncrpytMsgListBox.TabIndex = 12
        '
        'EncryptMsgLabel
        '
        Me.EncryptMsgLabel.AutoSize = True
        Me.EncryptMsgLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EncryptMsgLabel.Location = New System.Drawing.Point(203, 128)
        Me.EncryptMsgLabel.Name = "EncryptMsgLabel"
        Me.EncryptMsgLabel.Size = New System.Drawing.Size(122, 13)
        Me.EncryptMsgLabel.TabIndex = 11
        Me.EncryptMsgLabel.Text = "Encrypted Message:"
        '
        'IntegerConvListBox
        '
        Me.IntegerConvListBox.FormattingEnabled = True
        Me.IntegerConvListBox.Location = New System.Drawing.Point(13, 145)
        Me.IntegerConvListBox.Name = "IntegerConvListBox"
        Me.IntegerConvListBox.Size = New System.Drawing.Size(120, 95)
        Me.IntegerConvListBox.TabIndex = 10
        '
        'IntegerLabel
        '
        Me.IntegerLabel.AutoSize = True
        Me.IntegerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntegerLabel.Location = New System.Drawing.Point(10, 128)
        Me.IntegerLabel.Name = "IntegerLabel"
        Me.IntegerLabel.Size = New System.Drawing.Size(118, 13)
        Me.IntegerLabel.TabIndex = 9
        Me.IntegerLabel.Text = "Integer Conversion:"
        '
        'EncryptButton
        '
        Me.EncryptButton.Location = New System.Drawing.Point(205, 81)
        Me.EncryptButton.Name = "EncryptButton"
        Me.EncryptButton.Size = New System.Drawing.Size(120, 23)
        Me.EncryptButton.TabIndex = 8
        Me.EncryptButton.Text = "Encrypt Message"
        Me.EncryptButton.UseVisualStyleBackColor = True
        '
        'PlaintextLabel
        '
        Me.PlaintextLabel.AutoSize = True
        Me.PlaintextLabel.Location = New System.Drawing.Point(203, 39)
        Me.PlaintextLabel.Name = "PlaintextLabel"
        Me.PlaintextLabel.Size = New System.Drawing.Size(156, 13)
        Me.PlaintextLabel.TabIndex = 7
        Me.PlaintextLabel.Text = "Please enter one word at a time"
        '
        'MessageEncryptTextBox
        '
        Me.MessageEncryptTextBox.Location = New System.Drawing.Point(206, 55)
        Me.MessageEncryptTextBox.Name = "MessageEncryptTextBox"
        Me.MessageEncryptTextBox.Size = New System.Drawing.Size(120, 20)
        Me.MessageEncryptTextBox.TabIndex = 6
        '
        'MessageLabel
        '
        Me.MessageLabel.AutoSize = True
        Me.MessageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageLabel.Location = New System.Drawing.Point(203, 26)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(114, 13)
        Me.MessageLabel.TabIndex = 5
        Me.MessageLabel.Text = "Plaintext Message:"
        '
        'eEncryptTextBox
        '
        Me.eEncryptTextBox.Location = New System.Drawing.Point(29, 81)
        Me.eEncryptTextBox.Name = "eEncryptTextBox"
        Me.eEncryptTextBox.Size = New System.Drawing.Size(100, 20)
        Me.eEncryptTextBox.TabIndex = 4
        '
        'nEncryptTextBox
        '
        Me.nEncryptTextBox.Location = New System.Drawing.Point(29, 55)
        Me.nEncryptTextBox.Name = "nEncryptTextBox"
        Me.nEncryptTextBox.Size = New System.Drawing.Size(100, 20)
        Me.nEncryptTextBox.TabIndex = 3
        '
        'eLabel
        '
        Me.eLabel.AutoSize = True
        Me.eLabel.Location = New System.Drawing.Point(7, 84)
        Me.eLabel.Name = "eLabel"
        Me.eLabel.Size = New System.Drawing.Size(16, 13)
        Me.eLabel.TabIndex = 2
        Me.eLabel.Text = "e:"
        '
        'nLabel
        '
        Me.nLabel.AutoSize = True
        Me.nLabel.Location = New System.Drawing.Point(6, 58)
        Me.nLabel.Name = "nLabel"
        Me.nLabel.Size = New System.Drawing.Size(16, 13)
        Me.nLabel.TabIndex = 1
        Me.nLabel.Text = "n:"
        '
        'PublicEnterLabel
        '
        Me.PublicEnterLabel.AutoSize = True
        Me.PublicEnterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PublicEnterLabel.Location = New System.Drawing.Point(6, 26)
        Me.PublicEnterLabel.Name = "PublicEnterLabel"
        Me.PublicEnterLabel.Size = New System.Drawing.Size(166, 13)
        Me.PublicEnterLabel.TabIndex = 0
        Me.PublicEnterLabel.Text = "Public Key of the form (n,e):"
        '
        'DecryptGroupBox
        '
        Me.DecryptGroupBox.Controls.Add(Me.DecryptMsgListBox)
        Me.DecryptGroupBox.Controls.Add(Me.DecryptMSGLabel)
        Me.DecryptGroupBox.Controls.Add(Me.DecryptIntListBox)
        Me.DecryptGroupBox.Controls.Add(Me.DecryptIntLabel)
        Me.DecryptGroupBox.Controls.Add(Me.DecryptButton)
        Me.DecryptGroupBox.Controls.Add(Me.Label2)
        Me.DecryptGroupBox.Controls.Add(Me.MessageDecryptTextBox)
        Me.DecryptGroupBox.Controls.Add(Me.DecryptLabel)
        Me.DecryptGroupBox.Controls.Add(Me.dDecryptTextBox)
        Me.DecryptGroupBox.Controls.Add(Me.dDecryptLabel)
        Me.DecryptGroupBox.Controls.Add(Me.PrivateDecryptLabel)
        Me.DecryptGroupBox.Controls.Add(Me.eDecryptTextBox)
        Me.DecryptGroupBox.Controls.Add(Me.nDecryptTextBox)
        Me.DecryptGroupBox.Controls.Add(Me.eDecryptLabel)
        Me.DecryptGroupBox.Controls.Add(Me.nDecryptLabel)
        Me.DecryptGroupBox.Controls.Add(Me.PublicDecryptLabel)
        Me.DecryptGroupBox.Location = New System.Drawing.Point(416, 63)
        Me.DecryptGroupBox.Name = "DecryptGroupBox"
        Me.DecryptGroupBox.Size = New System.Drawing.Size(375, 268)
        Me.DecryptGroupBox.TabIndex = 2
        Me.DecryptGroupBox.TabStop = False
        Me.DecryptGroupBox.Text = "Decryption"
        '
        'DecryptMsgListBox
        '
        Me.DecryptMsgListBox.FormattingEnabled = True
        Me.DecryptMsgListBox.Location = New System.Drawing.Point(204, 153)
        Me.DecryptMsgListBox.Name = "DecryptMsgListBox"
        Me.DecryptMsgListBox.Size = New System.Drawing.Size(120, 95)
        Me.DecryptMsgListBox.TabIndex = 24
        '
        'DecryptMSGLabel
        '
        Me.DecryptMSGLabel.AutoSize = True
        Me.DecryptMSGLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecryptMSGLabel.Location = New System.Drawing.Point(201, 136)
        Me.DecryptMSGLabel.Name = "DecryptMSGLabel"
        Me.DecryptMSGLabel.Size = New System.Drawing.Size(123, 13)
        Me.DecryptMSGLabel.TabIndex = 23
        Me.DecryptMSGLabel.Text = "Decrypted Message:"
        '
        'DecryptIntListBox
        '
        Me.DecryptIntListBox.FormattingEnabled = True
        Me.DecryptIntListBox.Location = New System.Drawing.Point(13, 153)
        Me.DecryptIntListBox.Name = "DecryptIntListBox"
        Me.DecryptIntListBox.Size = New System.Drawing.Size(120, 95)
        Me.DecryptIntListBox.TabIndex = 22
        '
        'DecryptIntLabel
        '
        Me.DecryptIntLabel.AutoSize = True
        Me.DecryptIntLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecryptIntLabel.Location = New System.Drawing.Point(10, 136)
        Me.DecryptIntLabel.Name = "DecryptIntLabel"
        Me.DecryptIntLabel.Size = New System.Drawing.Size(113, 13)
        Me.DecryptIntLabel.TabIndex = 21
        Me.DecryptIntLabel.Text = "Decrypted Integer:"
        '
        'DecryptButton
        '
        Me.DecryptButton.Location = New System.Drawing.Point(205, 91)
        Me.DecryptButton.Name = "DecryptButton"
        Me.DecryptButton.Size = New System.Drawing.Size(120, 23)
        Me.DecryptButton.TabIndex = 20
        Me.DecryptButton.Text = "Decrypt Message"
        Me.DecryptButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(202, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Please enter one word at a time"
        '
        'MessageDecryptTextBox
        '
        Me.MessageDecryptTextBox.Location = New System.Drawing.Point(205, 64)
        Me.MessageDecryptTextBox.Name = "MessageDecryptTextBox"
        Me.MessageDecryptTextBox.Size = New System.Drawing.Size(120, 20)
        Me.MessageDecryptTextBox.TabIndex = 18
        '
        'DecryptLabel
        '
        Me.DecryptLabel.AutoSize = True
        Me.DecryptLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecryptLabel.Location = New System.Drawing.Point(202, 24)
        Me.DecryptLabel.Name = "DecryptLabel"
        Me.DecryptLabel.Size = New System.Drawing.Size(122, 13)
        Me.DecryptLabel.TabIndex = 17
        Me.DecryptLabel.Text = "Encrypted Message:"
        '
        'dDecryptTextBox
        '
        Me.dDecryptTextBox.Location = New System.Drawing.Point(29, 107)
        Me.dDecryptTextBox.Name = "dDecryptTextBox"
        Me.dDecryptTextBox.Size = New System.Drawing.Size(100, 20)
        Me.dDecryptTextBox.TabIndex = 16
        '
        'dDecryptLabel
        '
        Me.dDecryptLabel.AutoSize = True
        Me.dDecryptLabel.Location = New System.Drawing.Point(10, 110)
        Me.dDecryptLabel.Name = "dDecryptLabel"
        Me.dDecryptLabel.Size = New System.Drawing.Size(16, 13)
        Me.dDecryptLabel.TabIndex = 15
        Me.dDecryptLabel.Text = "d:"
        '
        'PrivateDecryptLabel
        '
        Me.PrivateDecryptLabel.AutoSize = True
        Me.PrivateDecryptLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrivateDecryptLabel.Location = New System.Drawing.Point(6, 91)
        Me.PrivateDecryptLabel.Name = "PrivateDecryptLabel"
        Me.PrivateDecryptLabel.Size = New System.Drawing.Size(143, 13)
        Me.PrivateDecryptLabel.TabIndex = 10
        Me.PrivateDecryptLabel.Text = "Private Key Parameters:"
        '
        'eDecryptTextBox
        '
        Me.eDecryptTextBox.Location = New System.Drawing.Point(29, 68)
        Me.eDecryptTextBox.Name = "eDecryptTextBox"
        Me.eDecryptTextBox.Size = New System.Drawing.Size(100, 20)
        Me.eDecryptTextBox.TabIndex = 9
        '
        'nDecryptTextBox
        '
        Me.nDecryptTextBox.Location = New System.Drawing.Point(29, 42)
        Me.nDecryptTextBox.Name = "nDecryptTextBox"
        Me.nDecryptTextBox.Size = New System.Drawing.Size(100, 20)
        Me.nDecryptTextBox.TabIndex = 8
        '
        'eDecryptLabel
        '
        Me.eDecryptLabel.AutoSize = True
        Me.eDecryptLabel.Location = New System.Drawing.Point(10, 71)
        Me.eDecryptLabel.Name = "eDecryptLabel"
        Me.eDecryptLabel.Size = New System.Drawing.Size(16, 13)
        Me.eDecryptLabel.TabIndex = 7
        Me.eDecryptLabel.Text = "e:"
        '
        'nDecryptLabel
        '
        Me.nDecryptLabel.AutoSize = True
        Me.nDecryptLabel.Location = New System.Drawing.Point(10, 45)
        Me.nDecryptLabel.Name = "nDecryptLabel"
        Me.nDecryptLabel.Size = New System.Drawing.Size(16, 13)
        Me.nDecryptLabel.TabIndex = 6
        Me.nDecryptLabel.Text = "n:"
        '
        'PublicDecryptLabel
        '
        Me.PublicDecryptLabel.AutoSize = True
        Me.PublicDecryptLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PublicDecryptLabel.Location = New System.Drawing.Point(6, 24)
        Me.PublicDecryptLabel.Name = "PublicDecryptLabel"
        Me.PublicDecryptLabel.Size = New System.Drawing.Size(166, 13)
        Me.PublicDecryptLabel.TabIndex = 5
        Me.PublicDecryptLabel.Text = "Public Key of the form (n,e):"
        '
        'CreationLabel
        '
        Me.CreationLabel.AutoSize = True
        Me.CreationLabel.Location = New System.Drawing.Point(416, 33)
        Me.CreationLabel.Name = "CreationLabel"
        Me.CreationLabel.Size = New System.Drawing.Size(133, 13)
        Me.CreationLabel.TabIndex = 3
        Me.CreationLabel.Text = "Created by Travis Schauer"
        '
        'InfoLabel
        '
        Me.InfoLabel.AutoSize = True
        Me.InfoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoLabel.Location = New System.Drawing.Point(413, 13)
        Me.InfoLabel.Name = "InfoLabel"
        Me.InfoLabel.Size = New System.Drawing.Size(273, 13)
        Me.InfoLabel.TabIndex = 4
        Me.InfoLabel.Text = "This program demonstrates basic RSA methods"
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.SystemColors.Control
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ClearButton.Location = New System.Drawing.Point(416, 337)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(375, 72)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "Clear All"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(552, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(196, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "April 2021, Youngstown State University"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 421)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.InfoLabel)
        Me.Controls.Add(Me.CreationLabel)
        Me.Controls.Add(Me.DecryptGroupBox)
        Me.Controls.Add(Me.EncryptionGroupBox)
        Me.Controls.Add(Me.KeyGroupBox)
        Me.Name = "MainForm"
        Me.Text = "RSA Methods"
        Me.KeyGroupBox.ResumeLayout(False)
        Me.KeyGroupBox.PerformLayout()
        Me.EncryptionGroupBox.ResumeLayout(False)
        Me.EncryptionGroupBox.PerformLayout()
        Me.DecryptGroupBox.ResumeLayout(False)
        Me.DecryptGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KeyGroupBox As GroupBox
    Friend WithEvents PublicKeyTextBox As TextBox
    Friend WithEvents PrivateKeyTextBox As TextBox
    Friend WithEvents PublicLabel As Label
    Friend WithEvents PrivateLabel As Label
    Friend WithEvents qKeyTextBox As TextBox
    Friend WithEvents pKeyTextBox As TextBox
    Friend WithEvents QLabel As Label
    Friend WithEvents PLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents KeyCalculateButton As Button
    Friend WithEvents EncryptionGroupBox As GroupBox
    Friend WithEvents eLabel As Label
    Friend WithEvents nLabel As Label
    Friend WithEvents PublicEnterLabel As Label
    Friend WithEvents eEncryptTextBox As TextBox
    Friend WithEvents nEncryptTextBox As TextBox
    Friend WithEvents PlaintextLabel As Label
    Friend WithEvents MessageEncryptTextBox As TextBox
    Friend WithEvents MessageLabel As Label
    Friend WithEvents EncryptButton As Button
    Friend WithEvents IntegerConvListBox As ListBox
    Friend WithEvents IntegerLabel As Label
    Friend WithEvents EncrpytMsgListBox As ListBox
    Friend WithEvents EncryptMsgLabel As Label
    Friend WithEvents DecryptGroupBox As GroupBox
    Friend WithEvents PrivateDecryptLabel As Label
    Friend WithEvents eDecryptTextBox As TextBox
    Friend WithEvents nDecryptTextBox As TextBox
    Friend WithEvents eDecryptLabel As Label
    Friend WithEvents nDecryptLabel As Label
    Friend WithEvents PublicDecryptLabel As Label
    Friend WithEvents dDecryptTextBox As TextBox
    Friend WithEvents dDecryptLabel As Label
    Friend WithEvents DecryptMsgListBox As ListBox
    Friend WithEvents DecryptMSGLabel As Label
    Friend WithEvents DecryptIntListBox As ListBox
    Friend WithEvents DecryptIntLabel As Label
    Friend WithEvents DecryptButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents MessageDecryptTextBox As TextBox
    Friend WithEvents DecryptLabel As Label
    Friend WithEvents CreationLabel As Label
    Friend WithEvents InfoLabel As Label
    Friend WithEvents ClearButton As Button
    Friend WithEvents Label3 As Label
End Class
