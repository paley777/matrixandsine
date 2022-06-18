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
        Me.btnmatrix = New System.Windows.Forms.Button()
        Me.btnsin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(301, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MAIN MENU"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnmatrix
        '
        Me.btnmatrix.Location = New System.Drawing.Point(107, 199)
        Me.btnmatrix.Name = "btnmatrix"
        Me.btnmatrix.Size = New System.Drawing.Size(194, 85)
        Me.btnmatrix.TabIndex = 1
        Me.btnmatrix.Text = "MyMATMULT"
        Me.btnmatrix.UseVisualStyleBackColor = True
        '
        'btnsin
        '
        Me.btnsin.Location = New System.Drawing.Point(450, 199)
        Me.btnsin.Name = "btnsin"
        Me.btnsin.Size = New System.Drawing.Size(194, 85)
        Me.btnsin.TabIndex = 2
        Me.btnsin.Text = "MySIN"
        Me.btnsin.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnsin)
        Me.Controls.Add(Me.btnmatrix)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tugas VB - Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnmatrix As Button
    Friend WithEvents btnsin As Button
End Class
