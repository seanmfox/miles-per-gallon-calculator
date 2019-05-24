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
        Me.txtGallons = New System.Windows.Forms.TextBox()
        Me.lblGallons = New System.Windows.Forms.Label()
        Me.btnCalcMPG = New System.Windows.Forms.Button()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.lblMiles = New System.Windows.Forms.Label()
        Me.lblMPG = New System.Windows.Forms.Label()
        Me.lblTotalMPG = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtGallons
        '
        Me.txtGallons.Location = New System.Drawing.Point(282, 29)
        Me.txtGallons.Name = "txtGallons"
        Me.txtGallons.Size = New System.Drawing.Size(100, 22)
        Me.txtGallons.TabIndex = 0
        '
        'lblGallons
        '
        Me.lblGallons.AutoSize = True
        Me.lblGallons.Location = New System.Drawing.Point(63, 29)
        Me.lblGallons.Name = "lblGallons"
        Me.lblGallons.Size = New System.Drawing.Size(209, 17)
        Me.lblGallons.TabIndex = 1
        Me.lblGallons.Text = "Gallons of gas the car can hold:"
        '
        'btnCalcMPG
        '
        Me.btnCalcMPG.Location = New System.Drawing.Point(39, 221)
        Me.btnCalcMPG.Name = "btnCalcMPG"
        Me.btnCalcMPG.Size = New System.Drawing.Size(99, 60)
        Me.btnCalcMPG.TabIndex = 2
        Me.btnCalcMPG.Text = "Calculate MPG"
        Me.btnCalcMPG.UseVisualStyleBackColor = True
        '
        'txtMiles
        '
        Me.txtMiles.Location = New System.Drawing.Point(282, 80)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(100, 22)
        Me.txtMiles.TabIndex = 1
        '
        'lblMiles
        '
        Me.lblMiles.Location = New System.Drawing.Point(63, 67)
        Me.lblMiles.Name = "lblMiles"
        Me.lblMiles.Size = New System.Drawing.Size(195, 35)
        Me.lblMiles.TabIndex = 4
        Me.lblMiles.Text = "Number of miles car can be driven on full tank of gas:"
        '
        'lblMPG
        '
        Me.lblMPG.AutoSize = True
        Me.lblMPG.Location = New System.Drawing.Point(63, 132)
        Me.lblMPG.Name = "lblMPG"
        Me.lblMPG.Size = New System.Drawing.Size(111, 17)
        Me.lblMPG.TabIndex = 5
        Me.lblMPG.Text = "Miles per gallon:"
        '
        'lblTotalMPG
        '
        Me.lblTotalMPG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalMPG.Location = New System.Drawing.Point(282, 126)
        Me.lblTotalMPG.Name = "lblTotalMPG"
        Me.lblTotalMPG.Size = New System.Drawing.Size(110, 30)
        Me.lblTotalMPG.TabIndex = 6
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(179, 221)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(103, 60)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(323, 221)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(101, 60)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalcMPG
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 308)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblTotalMPG)
        Me.Controls.Add(Me.lblMPG)
        Me.Controls.Add(Me.lblMiles)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.btnCalcMPG)
        Me.Controls.Add(Me.lblGallons)
        Me.Controls.Add(Me.txtGallons)
        Me.Name = "Form1"
        Me.Text = "Miles per Gallon Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtGallons As TextBox
    Friend WithEvents lblGallons As Label
    Friend WithEvents btnCalcMPG As Button
    Friend WithEvents txtMiles As TextBox
    Friend WithEvents lblMiles As Label
    Friend WithEvents lblMPG As Label
    Friend WithEvents lblTotalMPG As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
