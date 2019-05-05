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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnChange = New System.Windows.Forms.Button()
        Me.btnDefault = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnLocate = New System.Windows.Forms.Button()
        Me.txtLogs = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.txtPath64 = New System.Windows.Forms.TextBox()
        Me.btnLocate64 = New System.Windows.Forms.Button()
        Me.btnWinRestore = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmflash = New System.Windows.Forms.Timer(Me.components)
        Me.btndebug = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(385, 12)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(92, 41)
        Me.btnChange.TabIndex = 4
        Me.btnChange.Text = "Apply"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'btnDefault
        '
        Me.btnDefault.Location = New System.Drawing.Point(386, 59)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(91, 41)
        Me.btnDefault.TabIndex = 5
        Me.btnDefault.Text = "Restore Previous"
        Me.btnDefault.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(386, 106)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 38)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.BackColor = System.Drawing.Color.White
        Me.txtPath.Location = New System.Drawing.Point(21, 21)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(242, 20)
        Me.txtPath.TabIndex = 0
        '
        'btnLocate
        '
        Me.btnLocate.Location = New System.Drawing.Point(269, 21)
        Me.btnLocate.Name = "btnLocate"
        Me.btnLocate.Size = New System.Drawing.Size(78, 20)
        Me.btnLocate.TabIndex = 1
        Me.btnLocate.Text = "Locate (x86)"
        Me.btnLocate.UseVisualStyleBackColor = True
        '
        'txtLogs
        '
        Me.txtLogs.BackColor = System.Drawing.Color.Black
        Me.txtLogs.ForeColor = System.Drawing.Color.Lime
        Me.txtLogs.Location = New System.Drawing.Point(21, 73)
        Me.txtLogs.Multiline = True
        Me.txtLogs.Name = "txtLogs"
        Me.txtLogs.ReadOnly = True
        Me.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLogs.Size = New System.Drawing.Size(326, 126)
        Me.txtLogs.TabIndex = 8
        '
        'txtPath64
        '
        Me.txtPath64.BackColor = System.Drawing.Color.White
        Me.txtPath64.Location = New System.Drawing.Point(21, 47)
        Me.txtPath64.Name = "txtPath64"
        Me.txtPath64.ReadOnly = True
        Me.txtPath64.Size = New System.Drawing.Size(242, 20)
        Me.txtPath64.TabIndex = 2
        '
        'btnLocate64
        '
        Me.btnLocate64.Location = New System.Drawing.Point(269, 47)
        Me.btnLocate64.Name = "btnLocate64"
        Me.btnLocate64.Size = New System.Drawing.Size(78, 20)
        Me.btnLocate64.TabIndex = 3
        Me.btnLocate64.Text = "Locate (x64)"
        Me.btnLocate64.UseVisualStyleBackColor = True
        '
        'btnWinRestore
        '
        Me.btnWinRestore.Location = New System.Drawing.Point(385, 152)
        Me.btnWinRestore.Name = "btnWinRestore"
        Me.btnWinRestore.Size = New System.Drawing.Size(91, 47)
        Me.btnWinRestore.TabIndex = 7
        Me.btnWinRestore.Text = "Restore Windows Default"
        Me.btnWinRestore.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(330, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Tool Created by MeijSoft"
        '
        'tmflash
        '
        Me.tmflash.Interval = 30
        '
        'btndebug
        '
        Me.btndebug.Location = New System.Drawing.Point(21, 196)
        Me.btndebug.Name = "btndebug"
        Me.btndebug.Size = New System.Drawing.Size(98, 26)
        Me.btndebug.TabIndex = 10
        Me.btndebug.Text = "Debug"
        Me.btndebug.UseVisualStyleBackColor = True
        Me.btndebug.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 229)
        Me.Controls.Add(Me.btndebug)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnWinRestore)
        Me.Controls.Add(Me.btnLocate64)
        Me.Controls.Add(Me.txtPath64)
        Me.Controls.Add(Me.txtLogs)
        Me.Controls.Add(Me.btnLocate)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDefault)
        Me.Controls.Add(Me.btnChange)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Opacity = 0.1R
        Me.Text = "Windows Default Installation Folder Updater"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents btnDefault As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents btnLocate As System.Windows.Forms.Button
    Friend WithEvents txtLogs As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents txtPath64 As System.Windows.Forms.TextBox
    Friend WithEvents btnLocate64 As System.Windows.Forms.Button
    Friend WithEvents btnWinRestore As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tmflash As System.Windows.Forms.Timer
    Friend WithEvents btndebug As Button
End Class
