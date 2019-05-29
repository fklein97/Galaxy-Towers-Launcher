<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Launcher
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label_status = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label_status
        '
        Me.Label_status.AutoSize = True
        Me.Label_status.Location = New System.Drawing.Point(249, 184)
        Me.Label_status.Name = "Label_status"
        Me.Label_status.Size = New System.Drawing.Size(37, 13)
        Me.Label_status.TabIndex = 0
        Me.Label_status.Text = "Status"
        '
        'Form_Launcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 626)
        Me.Controls.Add(Me.Label_status)
        Me.Name = "Form_Launcher"
        Me.Text = "Galaxy Towers Launcher"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_status As Label
End Class
