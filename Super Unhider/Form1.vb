Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i = 1 To ListBox1.Items.Count
            Process.Start("cmd", "/c attrib -s -h """ & ListBox1.SelectedItem.ToString & """")
            If ListBox1.SelectedIndex = ListBox1.Items.Count - 1 Then
                Exit For
            Else
                ListBox1.SelectedIndex = ListBox1.SelectedIndex + +1
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            For Each sFile As String In OpenFileDialog1.FileNames
                Dim pos As Integer = sFile.LastIndexOf("\"c)
                Dim File As String = Replace(sFile.ToString, System.IO.Path.GetFileName(sFile), "g" & System.IO.Path.GetFileName(sFile))
                Me.ListBox1.Items.Add(File)
                ListBox1.SelectedIndex = ListBox1.SelectedIndex + +1
            Next
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For Each sFile As String In OpenFileDialog1.FileNames
            Process.Start("cmd", "/c rename """ & Replace(sFile.ToString, System.IO.Path.GetFileName(sFile), "g" & System.IO.Path.GetFileName(sFile)) & """ " & System.IO.Path.GetFileName(sFile))
            If ListBox1.SelectedIndex = ListBox1.Items.Count - 1 Then
                Exit For
            Else
                ListBox1.SelectedIndex = ListBox1.SelectedIndex + +1
            End If
        Next
    End Sub
End Class
