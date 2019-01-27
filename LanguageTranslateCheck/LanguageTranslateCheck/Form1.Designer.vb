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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.basic_display = New System.Windows.Forms.Label()
        Me.language_picker = New System.Windows.Forms.ComboBox()
        Me.exit_button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'basic_display
        '
        resources.ApplyResources(Me.basic_display, "basic_display")
        Me.basic_display.Name = "basic_display"
        '
        'language_picker
        '
        resources.ApplyResources(Me.language_picker, "language_picker")
        Me.language_picker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.language_picker.FormattingEnabled = True
        Me.language_picker.Name = "language_picker"
        '
        'exit_button
        '
        resources.ApplyResources(Me.exit_button, "exit_button")
        Me.exit_button.Name = "exit_button"
        Me.exit_button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ControlBox = False
        Me.Controls.Add(Me.exit_button)
        Me.Controls.Add(Me.language_picker)
        Me.Controls.Add(Me.basic_display)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents basic_display As Label
    Friend WithEvents language_picker As ComboBox
    Friend WithEvents exit_button As Button
End Class
