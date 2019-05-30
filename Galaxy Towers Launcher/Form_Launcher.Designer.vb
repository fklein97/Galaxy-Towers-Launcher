<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Launcher
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListBox_status = New System.Windows.Forms.ListBox()
        Me.Button_play = New System.Windows.Forms.Button()
        Me.Button_forceUpdate = New System.Windows.Forms.Button()
        Me.Button_close = New System.Windows.Forms.Button()
        Me.ProgressBar_update = New System.Windows.Forms.ProgressBar()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Galaxy_Towers_Launcher.My.Resources.Resources._4e191dea_10e6_47be_8c79_ea722aeb2f12
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(438, 215)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ListBox_status
        '
        Me.ListBox_status.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ListBox_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox_status.ForeColor = System.Drawing.Color.White
        Me.ListBox_status.FormattingEnabled = True
        Me.ListBox_status.Location = New System.Drawing.Point(12, 233)
        Me.ListBox_status.Name = "ListBox_status"
        Me.ListBox_status.Size = New System.Drawing.Size(438, 236)
        Me.ListBox_status.TabIndex = 1
        '
        'Button_play
        '
        Me.Button_play.BackColor = System.Drawing.Color.White
        Me.Button_play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_play.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_play.ForeColor = System.Drawing.Color.Black
        Me.Button_play.Location = New System.Drawing.Point(254, 518)
        Me.Button_play.Name = "Button_play"
        Me.Button_play.Size = New System.Drawing.Size(196, 64)
        Me.Button_play.TabIndex = 2
        Me.Button_play.Text = "Play!"
        Me.Button_play.UseVisualStyleBackColor = False
        '
        'Button_forceUpdate
        '
        Me.Button_forceUpdate.BackColor = System.Drawing.Color.White
        Me.Button_forceUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button_forceUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_forceUpdate.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_forceUpdate.ForeColor = System.Drawing.Color.Black
        Me.Button_forceUpdate.Location = New System.Drawing.Point(12, 518)
        Me.Button_forceUpdate.Name = "Button_forceUpdate"
        Me.Button_forceUpdate.Size = New System.Drawing.Size(196, 64)
        Me.Button_forceUpdate.TabIndex = 3
        Me.Button_forceUpdate.Text = "Force Update!"
        Me.Button_forceUpdate.UseVisualStyleBackColor = False
        '
        'Button_close
        '
        Me.Button_close.BackColor = System.Drawing.Color.Red
        Me.Button_close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_close.ForeColor = System.Drawing.Color.White
        Me.Button_close.Location = New System.Drawing.Point(423, 12)
        Me.Button_close.Name = "Button_close"
        Me.Button_close.Size = New System.Drawing.Size(27, 26)
        Me.Button_close.TabIndex = 4
        Me.Button_close.Text = "X"
        Me.Button_close.UseVisualStyleBackColor = False
        '
        'ProgressBar_update
        '
        Me.ProgressBar_update.Location = New System.Drawing.Point(12, 475)
        Me.ProgressBar_update.Name = "ProgressBar_update"
        Me.ProgressBar_update.Size = New System.Drawing.Size(438, 15)
        Me.ProgressBar_update.TabIndex = 5
        Me.ProgressBar_update.Visible = False
        '
        'Form_Launcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(462, 594)
        Me.Controls.Add(Me.ProgressBar_update)
        Me.Controls.Add(Me.Button_close)
        Me.Controls.Add(Me.Button_forceUpdate)
        Me.Controls.Add(Me.Button_play)
        Me.Controls.Add(Me.ListBox_status)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Launcher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Galaxy Towers Launcher"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListBox_status As ListBox
    Friend WithEvents Button_play As Button
    Friend WithEvents Button_forceUpdate As Button
    Friend WithEvents Button_close As Button
    Friend WithEvents ProgressBar_update As ProgressBar
End Class
