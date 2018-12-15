<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm_Front
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label_Username As System.Windows.Forms.Label
    Friend WithEvents Label_Password As System.Windows.Forms.Label
    Friend WithEvents Txb_Username As System.Windows.Forms.TextBox
    Friend WithEvents Txb_Password As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm_Front))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label_Username = New System.Windows.Forms.Label()
        Me.Label_Password = New System.Windows.Forms.Label()
        Me.Txb_Username = New System.Windows.Forms.TextBox()
        Me.Txb_Password = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label_Shift = New System.Windows.Forms.Label()
        Me.Combo_Shift = New System.Windows.Forms.ComboBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(12, 90)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(251, 225)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'Label_Username
        '
        Me.Label_Username.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Username.Location = New System.Drawing.Point(299, 30)
        Me.Label_Username.Name = "Label_Username"
        Me.Label_Username.Size = New System.Drawing.Size(303, 23)
        Me.Label_Username.TabIndex = 0
        Me.Label_Username.Text = "&User name"
        Me.Label_Username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_Password
        '
        Me.Label_Password.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Password.Location = New System.Drawing.Point(299, 100)
        Me.Label_Password.Name = "Label_Password"
        Me.Label_Password.Size = New System.Drawing.Size(220, 23)
        Me.Label_Password.TabIndex = 2
        Me.Label_Password.Text = "&Password"
        Me.Label_Password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txb_Username
        '
        Me.Txb_Username.BackColor = System.Drawing.Color.PaleGreen
        Me.Txb_Username.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_Username.Location = New System.Drawing.Point(301, 59)
        Me.Txb_Username.Name = "Txb_Username"
        Me.Txb_Username.Size = New System.Drawing.Size(272, 30)
        Me.Txb_Username.TabIndex = 1
        '
        'Txb_Password
        '
        Me.Txb_Password.BackColor = System.Drawing.Color.PaleGreen
        Me.Txb_Password.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_Password.Location = New System.Drawing.Point(301, 129)
        Me.Txb_Password.Name = "Txb_Password"
        Me.Txb_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txb_Password.Size = New System.Drawing.Size(272, 30)
        Me.Txb_Password.TabIndex = 3
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.OK.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(292, 268)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(159, 47)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&OK"
        Me.OK.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(467, 268)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(159, 47)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Cancel"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Button1.BackColor = System.Drawing.Color.Navy
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(251, 74)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "FRONT OFFICE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label_Shift
        '
        Me.Label_Shift.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Shift.Location = New System.Drawing.Point(299, 180)
        Me.Label_Shift.Name = "Label_Shift"
        Me.Label_Shift.Size = New System.Drawing.Size(220, 23)
        Me.Label_Shift.TabIndex = 2
        Me.Label_Shift.Text = "&Shift"
        Me.Label_Shift.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Combo_Shift
        '
        Me.Combo_Shift.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Combo_Shift.BackColor = System.Drawing.Color.PaleGreen
        Me.Combo_Shift.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Combo_Shift.Font = New System.Drawing.Font("Tahoma", 14.25!)
        Me.Combo_Shift.ForeColor = System.Drawing.Color.DarkBlue
        Me.Combo_Shift.FormattingEnabled = True
        Me.Combo_Shift.Items.AddRange(New Object() {"Morning", "Afternoon", "Evening", "Night"})
        Me.Combo_Shift.Location = New System.Drawing.Point(301, 206)
        Me.Combo_Shift.Name = "Combo_Shift"
        Me.Combo_Shift.Size = New System.Drawing.Size(272, 31)
        Me.Combo_Shift.TabIndex = 16
        '
        'LoginForm_Front
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(662, 353)
        Me.Controls.Add(Me.Combo_Shift)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Txb_Password)
        Me.Controls.Add(Me.Label_Shift)
        Me.Controls.Add(Me.Txb_Username)
        Me.Controls.Add(Me.Label_Password)
        Me.Controls.Add(Me.Label_Username)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm_Front"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login Front Office System"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label_Shift As Label
    Friend WithEvents Combo_Shift As ComboBox
End Class
