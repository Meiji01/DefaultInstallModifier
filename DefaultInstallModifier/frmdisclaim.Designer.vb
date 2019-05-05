<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdisclaim
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmdisclaim))
        Me.txtDisclaim = New System.Windows.Forms.TextBox()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnDecline = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDisclaim
        '
        Me.txtDisclaim.Location = New System.Drawing.Point(12, 12)
        Me.txtDisclaim.Multiline = True
        Me.txtDisclaim.Name = "txtDisclaim"
        Me.txtDisclaim.Size = New System.Drawing.Size(542, 207)
        Me.txtDisclaim.TabIndex = 0
        Me.txtDisclaim.Text = resources.GetString("txtDisclaim.Text")
        '
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(360, 237)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(95, 26)
        Me.btnAccept.TabIndex = 1
        Me.btnAccept.Text = "&Accept"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'btnDecline
        '
        Me.btnDecline.Location = New System.Drawing.Point(461, 237)
        Me.btnDecline.Name = "btnDecline"
        Me.btnDecline.Size = New System.Drawing.Size(92, 26)
        Me.btnDecline.TabIndex = 2
        Me.btnDecline.Text = "&Decline"
        Me.btnDecline.UseVisualStyleBackColor = True
        '
        'frmdisclaim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 272)
        Me.Controls.Add(Me.btnDecline)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.txtDisclaim)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MinimizeBox = False
        Me.Name = "frmdisclaim"
        Me.Text = "User Agreement to Proceed"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDisclaim As TextBox
    Friend WithEvents btnAccept As Button
    Friend WithEvents btnDecline As Button
End Class
