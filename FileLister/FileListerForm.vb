Imports System.IO

Public Class FileListerForm

    Private Sub FileListBox_DragDrop(sender As Object, e As DragEventArgs) Handles FileListBox.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            Dim filePaths As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())

            For Each filePath As String In filePaths
                FileListBox.Items.Add(filePath)
            Next filePath

        End If

    End Sub

    Private Sub FileListBox_DragEnter(sender As Object, e As DragEventArgs) Handles FileListBox.DragEnter
        'SET THE PROPER ACTION FOR FILE DROP....BY USING THE FILEDROP METHOD TO COPY
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        FileListBox.Items.Clear()
    End Sub

    Private Sub RemoveBtn_Click(sender As Object, e As EventArgs) Handles RemoveBtn.Click
        Dim indicies = FileListBox.SelectedIndices
        For i = (indicies.Count - 1) To 0 Step -1
            Dim idx = indicies(i)
            FileListBox.Items.RemoveAt(idx)
        Next
    End Sub

    Private Sub FileListerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormatCbo.Items.AddRange(New Object() {"<type> ""<fullpath>""", "<typ> ""<fullpath>""", "<typ> ""<name>""", "<fullpath>", """<directory>"" ""<name>"" ""<ext>"""})
        FormatCbo.Text = "<type> ""<fullpath>"""
    End Sub

    Private Sub PasteFromClipboard()
        If My.Computer.Clipboard.ContainsFileDropList Then
            Dim dropList = My.Computer.Clipboard.GetFileDropList
            For Each filePath As String In dropList
                FileListBox.Items.Add(filePath)
            Next filePath
        End If
    End Sub

    Private Sub ExportToClipboard()

        Dim template As String = FormatCbo.Text
        Dim str As String = ""

        For Each itm In FileListBox.Items

            Dim txt As String = template

            Dim fInfo As FileInfo = My.Computer.FileSystem.GetFileInfo(itm)
            Dim isFolder = ((fInfo.Attributes And FileAttribute.Directory) = FileAttribute.Directory)


            txt = txt.Replace("<type>", If(isFolder, "folder", "  file"))
            txt = txt.Replace("<typ>", If(isFolder, "fol", "fil"))
            txt = txt.Replace("<fullpath>", itm)
            txt = txt.Replace("<directory>", fInfo.DirectoryName)
            txt = txt.Replace("<name>", fInfo.Name)
            txt = txt.Replace("<ext>", If(isFolder, "folder", fInfo.Extension))
            txt = txt.Replace("<.ext>", If(isFolder, "folder", "." + fInfo.Extension))

            str = str + txt + vbNewLine

        Next itm

        My.Computer.Clipboard.Clear()
        My.Computer.Clipboard.SetText(str)

    End Sub

    Private Sub CopyBtn_Click(sender As Object, e As EventArgs) Handles CopyBtn.Click
        ExportToClipboard()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        ExportToClipboard()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        PasteFromClipboard()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        PasteFromClipboard()
    End Sub
End Class
