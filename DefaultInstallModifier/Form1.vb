Public Class Form1
    Public currentis64 As Boolean

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtPath.Text = ""
        txtPath64.Text = Nothing
        txtLogs.Text = ""
    End Sub

    Private Sub btnLocate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocate.Click
        FolderBrowserDialog1.ShowDialog()
        txtPath.Text = FolderBrowserDialog1.SelectedPath.ToString
    End Sub

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        Dim proceed As MsgBoxResult
        proceed = MsgBox("Microsoft does not support changing the location of the Program Files folder. It states that if you change the location of the Program Files folder, you may experience problems with some Microsoft programs or with some software updates. DO YOU WANT TO PROCEED?", vbYesNo, "Warning!")
        If proceed = vbNo Then
            GoTo cnld
            Exit Sub
        End If
        Dim oldRegister As String
        Dim oldRegister2 As String
        'get previous value
        txtLogs.AppendText("64 Bit Mode: " & currentis64.ToString & vbCrLf)
        txtLogs.AppendText("Old registry value: ")
        oldRegister = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\", "ProgramFilesDir", Nothing)
        oldRegister2 = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\", "ProgramFilesDir (x86)", "unavailable")
        txtLogs.AppendText(oldRegister & vbCrLf)


        'backup old registry for x64
        txtLogs.AppendText("Backing up old values... " & vbCrLf)
        If currentis64 = True Then
            'if no key created yet then enter IF statement, else Skip
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\WDIFU\", "ProgBackup(x64)", Nothing) Is Nothing Then
                My.Computer.Registry.CurrentUser.CreateSubKey("SOFTWARE\WDIFU\")
                'My.Computer.Registry.SetValue("HKEY_CURRENT_USER\TestKey", "ProgBackup", oldRegister)
            End If
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\WDIFU\", "ProgBackup(x64)", oldRegister)

            'backup old registry for x86
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\WDIFU\", "ProgBackup(x86)", Nothing) Is Nothing Then
                My.Computer.Registry.CurrentUser.CreateSubKey("SOFTWARE\WDIFU\")
                'My.Computer.Registry.SetValue("HKEY_CURRENT_USER\TestKey", "ProgBackup", oldRegister)
            End If
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\WDIFU\", "ProgBackup(x86)", oldRegister2)
        Else
            'backup old registry for x86
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\WDIFU\", "ProgBackup(x86)", Nothing) Is Nothing Then
                My.Computer.Registry.CurrentUser.CreateSubKey("SOFTWARE\WDIFU\")
                'My.Computer.Registry.SetValue("HKEY_CURRENT_USER\TestKey", "ProgBackup", oldRegister)
            End If
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\WDIFU\", "ProgBackup(x86)", oldRegister)
        End If
        txtLogs.AppendText("Backing up old values success..." & vbCrLf)

        Try
            'update registry using the new value
            Dim get86value As String
            Dim get64values As String
            get86value = txtPath.Text
            get64values = txtPath64.Text
            txtLogs.AppendText("Updating values..." & vbCrLf)
            If currentis64 = True Then
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion", "ProgramFilesDir (x86)", get86value)
                'My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\WDIFU", "progtest(x86)", get86value)
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion", "ProgramFilesDir", get64values)
                'My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\WDIFU", "progtest", get64values)
            Else
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion", "ProgramFilesDir", get86value)
                'My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\WDIFU", "progtest", get86value)
            End If
            txtLogs.AppendText("Update success..." & vbCrLf)
            Exit Sub
        Catch ex As Exception
            txtLogs.AppendText(vbCrLf & "With error: " & ex.Message)
        End Try
cnld:
        MsgBox("Cancelled!", vbOKOnly, "Cancelled!")
    End Sub

    Function checkbit() As Boolean
        Dim bitTag As Boolean
        Try
            txtLogs.AppendText("Check windows version" & vbCrLf)
            If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\", "ProgramFilesDir (x86)", Nothing) Is Nothing Then
                txtLogs.AppendText("Windows is 32 Bit (IA-32)" & vbCrLf)
                bitTag = False
            Else
                bitTag = True
                txtLogs.AppendText("Windows is 64 Bit (amd64)" & vbCrLf)
            End If
            checkbit = bitTag
        Catch ex As Exception
            txtLogs.AppendText(vbCrLf & "Fatal Error: " & ex.Message)
        End Try
    End Function


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmflash.Enabled = True
        Debug.Print("Loaded...")
        Debug.Print("Opacity: " & Me.Opacity)
        txtLogs.AppendText("Now in github: https://github.com/Meiji01/DefaultInstallModifier" & vbCrLf)
        If checkbit() = True Then
            txtPath64.Enabled = True
            btnLocate64.Enabled = True
            currentis64 = True
            txtPath64.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\", "ProgramFilesDir", Nothing)
            txtPath.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\", "ProgramFilesDir (x86)", "unavailable")
        Else
            txtPath64.Enabled = False
            btnLocate64.Enabled = False
            currentis64 = False
            txtPath.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\", "ProgramFilesDir", Nothing)
        End If
    End Sub

    Private Sub btnLocate64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocate64.Click
        FolderBrowserDialog1.ShowDialog()
        txtPath64.Text = FolderBrowserDialog1.SelectedPath.ToString
    End Sub

    Private Sub txtPath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPath.TextChanged
        If txtPath.Text <> Nothing Then
            btnChange.Enabled = True
        Else
            btnChange.Enabled = False
        End If
    End Sub

    Private Sub txtPath64_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPath64.TextChanged
        If txtPath64.Text <> Nothing Then
            btnChange.Enabled = True
        Else
            btnChange.Enabled = False
        End If
    End Sub

    Private Sub btnDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDefault.Click
        txtPath64.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\WDIFU", "ProgBackup(x64)", Nothing)
        txtPath.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\WDIFU", "ProgBackup(x86)", Nothing)
    End Sub

    Private Sub btnWinRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWinRestore.Click
        If currentis64 = True Then
            txtPath64.Text = "C:\Program Files"
            txtPath.Text = "C:\Program Files (x86)"
            Debug.Print("Windows restored..")
        Else
            txtPath64.Text = Nothing
            txtPath.Text = "C:\Program Files"
        End If
        txtLogs.AppendText("Windows Default Loaded" & vbCrLf)
        MsgBox("Windows default value restored. Dont forget to apply the settings.", vbOKOnly, "MeijSoft")
    End Sub

    Private Sub tmflash_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmflash.Tick
        Dim x As Double
        x = Me.Opacity
        If Me.Opacity <= 0.99 Then
            x = x + 0.02
            Me.Opacity = x
            Debug.Print("Opacity: " & x)
        Else
            '    MsgBox("done")
            tmflash.Enabled = False
        End If
    End Sub
End Class
