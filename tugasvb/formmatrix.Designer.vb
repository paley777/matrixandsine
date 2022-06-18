<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formmatrix
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.matrixA_1 = New System.Windows.Forms.RichTextBox()
        Me.matrixA_2 = New System.Windows.Forms.RichTextBox()
        Me.matrixA_3 = New System.Windows.Forms.RichTextBox()
        Me.matrixA_4 = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MatrixB_4 = New System.Windows.Forms.RichTextBox()
        Me.MatrixB_3 = New System.Windows.Forms.RichTextBox()
        Me.MatrixB_2 = New System.Windows.Forms.RichTextBox()
        Me.MatrixB_1 = New System.Windows.Forms.RichTextBox()
        Me.Result_4 = New System.Windows.Forms.RichTextBox()
        Me.Result_3 = New System.Windows.Forms.RichTextBox()
        Me.Result_2 = New System.Windows.Forms.RichTextBox()
        Me.Result_1 = New System.Windows.Forms.RichTextBox()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btnkembali = New System.Windows.Forms.Button()
        Me.btnhitung = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(199, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(377, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MATRIX MULTIPLICATION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Matrix Value A"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(311, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Matrix Value B"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(617, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Result"
        '
        'matrixA_1
        '
        Me.matrixA_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matrixA_1.Location = New System.Drawing.Point(62, 168)
        Me.matrixA_1.Name = "matrixA_1"
        Me.matrixA_1.Size = New System.Drawing.Size(54, 49)
        Me.matrixA_1.TabIndex = 5
        Me.matrixA_1.Text = ""
        '
        'matrixA_2
        '
        Me.matrixA_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matrixA_2.Location = New System.Drawing.Point(148, 168)
        Me.matrixA_2.Name = "matrixA_2"
        Me.matrixA_2.Size = New System.Drawing.Size(54, 49)
        Me.matrixA_2.TabIndex = 6
        Me.matrixA_2.Text = ""
        '
        'matrixA_3
        '
        Me.matrixA_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matrixA_3.Location = New System.Drawing.Point(62, 240)
        Me.matrixA_3.Name = "matrixA_3"
        Me.matrixA_3.Size = New System.Drawing.Size(54, 49)
        Me.matrixA_3.TabIndex = 7
        Me.matrixA_3.Text = ""
        '
        'matrixA_4
        '
        Me.matrixA_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matrixA_4.Location = New System.Drawing.Point(148, 240)
        Me.matrixA_4.Name = "matrixA_4"
        Me.matrixA_4.Size = New System.Drawing.Size(54, 49)
        Me.matrixA_4.TabIndex = 8
        Me.matrixA_4.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(242, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 29)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "X"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(516, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 29)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "="
        '
        'MatrixB_4
        '
        Me.MatrixB_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatrixB_4.Location = New System.Drawing.Point(402, 240)
        Me.MatrixB_4.Name = "MatrixB_4"
        Me.MatrixB_4.Size = New System.Drawing.Size(54, 49)
        Me.MatrixB_4.TabIndex = 14
        Me.MatrixB_4.Text = ""
        '
        'MatrixB_3
        '
        Me.MatrixB_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatrixB_3.Location = New System.Drawing.Point(316, 240)
        Me.MatrixB_3.Name = "MatrixB_3"
        Me.MatrixB_3.Size = New System.Drawing.Size(54, 49)
        Me.MatrixB_3.TabIndex = 13
        Me.MatrixB_3.Text = ""
        '
        'MatrixB_2
        '
        Me.MatrixB_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatrixB_2.Location = New System.Drawing.Point(402, 168)
        Me.MatrixB_2.Name = "MatrixB_2"
        Me.MatrixB_2.Size = New System.Drawing.Size(54, 49)
        Me.MatrixB_2.TabIndex = 12
        Me.MatrixB_2.Text = ""
        '
        'MatrixB_1
        '
        Me.MatrixB_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatrixB_1.Location = New System.Drawing.Point(316, 168)
        Me.MatrixB_1.Name = "MatrixB_1"
        Me.MatrixB_1.Size = New System.Drawing.Size(54, 49)
        Me.MatrixB_1.TabIndex = 11
        Me.MatrixB_1.Text = ""
        '
        'Result_4
        '
        Me.Result_4.Enabled = False
        Me.Result_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Result_4.Location = New System.Drawing.Point(673, 240)
        Me.Result_4.Name = "Result_4"
        Me.Result_4.Size = New System.Drawing.Size(54, 49)
        Me.Result_4.TabIndex = 18
        Me.Result_4.Text = ""
        '
        'Result_3
        '
        Me.Result_3.Enabled = False
        Me.Result_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Result_3.Location = New System.Drawing.Point(587, 240)
        Me.Result_3.Name = "Result_3"
        Me.Result_3.Size = New System.Drawing.Size(54, 49)
        Me.Result_3.TabIndex = 17
        Me.Result_3.Text = ""
        '
        'Result_2
        '
        Me.Result_2.Enabled = False
        Me.Result_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Result_2.Location = New System.Drawing.Point(673, 168)
        Me.Result_2.Name = "Result_2"
        Me.Result_2.Size = New System.Drawing.Size(54, 49)
        Me.Result_2.TabIndex = 16
        Me.Result_2.Text = ""
        '
        'Result_1
        '
        Me.Result_1.Enabled = False
        Me.Result_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Result_1.Location = New System.Drawing.Point(587, 168)
        Me.Result_1.Name = "Result_1"
        Me.Result_1.Size = New System.Drawing.Size(54, 49)
        Me.Result_1.TabIndex = 15
        Me.Result_1.Text = ""
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(317, 359)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(144, 52)
        Me.btnreset.TabIndex = 19
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btnkembali
        '
        Me.btnkembali.Location = New System.Drawing.Point(486, 359)
        Me.btnkembali.Name = "btnkembali"
        Me.btnkembali.Size = New System.Drawing.Size(144, 52)
        Me.btnkembali.TabIndex = 20
        Me.btnkembali.Text = "Close"
        Me.btnkembali.UseVisualStyleBackColor = True
        '
        'btnhitung
        '
        Me.btnhitung.Location = New System.Drawing.Point(152, 359)
        Me.btnhitung.Name = "btnhitung"
        Me.btnhitung.Size = New System.Drawing.Size(144, 52)
        Me.btnhitung.TabIndex = 21
        Me.btnhitung.Text = "Calculate!"
        Me.btnhitung.UseVisualStyleBackColor = True
        '
        'formmatrix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnhitung)
        Me.Controls.Add(Me.btnkembali)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.Result_4)
        Me.Controls.Add(Me.Result_3)
        Me.Controls.Add(Me.Result_2)
        Me.Controls.Add(Me.Result_1)
        Me.Controls.Add(Me.MatrixB_4)
        Me.Controls.Add(Me.MatrixB_3)
        Me.Controls.Add(Me.MatrixB_2)
        Me.Controls.Add(Me.MatrixB_1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.matrixA_4)
        Me.Controls.Add(Me.matrixA_3)
        Me.Controls.Add(Me.matrixA_2)
        Me.Controls.Add(Me.matrixA_1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "formmatrix"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formmatrix"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents matrixA_1 As RichTextBox
    Friend WithEvents matrixA_2 As RichTextBox
    Friend WithEvents matrixA_3 As RichTextBox
    Friend WithEvents matrixA_4 As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents MatrixB_4 As RichTextBox
    Friend WithEvents MatrixB_3 As RichTextBox
    Friend WithEvents MatrixB_2 As RichTextBox
    Friend WithEvents MatrixB_1 As RichTextBox
    Friend WithEvents Result_4 As RichTextBox
    Friend WithEvents Result_3 As RichTextBox
    Friend WithEvents Result_2 As RichTextBox
    Friend WithEvents Result_1 As RichTextBox
    Friend WithEvents btnreset As Button
    Friend WithEvents btnkembali As Button
    Friend WithEvents btnhitung As Button
End Class
