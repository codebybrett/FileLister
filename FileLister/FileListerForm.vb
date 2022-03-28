Public Class FileListerForm

    Private PM As FileListerPresentationModel = New FileListerPresentationModel()

    Private Sub FileListBox_DragDrop(sender As Object, e As DragEventArgs) Handles FileListBox.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim filePaths As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
            FileListBox.BeginUpdate()
            PM.AddFiles(filePaths)
            FileListBox.EndUpdate()
        End If
    End Sub

    Private Sub FileListBox_DragEnter(sender As Object, e As DragEventArgs) Handles FileListBox.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        FileListBox.BeginUpdate()
        PM.ClearFiles()
        FileListBox.EndUpdate()
    End Sub

    Private Sub RemoveBtn_Click(sender As Object, e As EventArgs) Handles RemoveBtn.Click

        ' SelectedIndicies is affected by operations upon the BindingList.
        Dim lst As New List(Of Integer)
        Dim indicies = FileListBox.SelectedIndices
        For i = 0 To (indicies.Count - 1) Step 1
            lst.Add(indicies(i))
        Next
        FileListBox.BeginUpdate()
        PM.RemoveFiles(lst)
        FileListBox.EndUpdate()

    End Sub

    Private Sub FileListerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FilesBindingSource.DataSource = PM.FilesList
        TemplateBindingSource.DataSource = PM.TemplateList

    End Sub

    Private Sub CopyBtn_Click(sender As Object, e As EventArgs) Handles CopyBtn.Click
        PM.ExportToClipboard(FormatCbo.Text)
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        PM.ExportToClipboard(FormatCbo.Text)
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        PM.PasteFromClipboard()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        PM.PasteFromClipboard()
    End Sub
End Class
