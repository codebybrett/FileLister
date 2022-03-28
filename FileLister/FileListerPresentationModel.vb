Imports System.IO
Imports System.ComponentModel
Public Class FileListerPresentationModel

    Private ReadOnly _filesList As BindingList(Of String)
    Private ReadOnly _templateList As BindingList(Of String)

    ReadOnly Property FilesList
        Get
            Return _filesList
        End Get
    End Property

    ReadOnly Property TemplateList
        Get
            Return _templateList
        End Get
    End Property

    Public Sub New()

        _filesList = New BindingList(Of String)

        _templateList = New BindingList(Of String) From {
            """<fullpath>""",
            "<fullpath>",
            """<filename>""",
            """<name><itemtype>""",
            """<directory>""<tab>""<name>""<tab>""<itemtype>""",
            "<type> ""<fullpath>""",
            "<typ> ""<fullpath>""",
            "<typ> ""<filename>"""
        }

    End Sub

    Public Sub AddFiles(fileList As String())
        For Each filePath As String In fileList
            _filesList.Add(filePath)
        Next filePath
    End Sub

    Public Sub ClearFiles()
        _filesList.Clear()
    End Sub

    Public Sub RemoveFiles(lst As List(Of Integer))
        lst.Sort()
        lst.Reverse()
        For Each idx In lst
            _filesList.RemoveAt(idx)
        Next
    End Sub

    Public Sub ExportToClipboard(template As String)

        Dim str As String = ""

        ' For Each itm In FileListBox.Items
        For Each itm In _filesList

            Dim txt As String = template

            Dim fInfo As FileInfo = My.Computer.FileSystem.GetFileInfo(itm)
            Dim isFolder = ((fInfo.Attributes And FileAttribute.Directory) = FileAttribute.Directory)

            Dim sDir = fInfo.DirectoryName + "\"
            Dim sNameExt = fInfo.Name
            Dim sExt = fInfo.Extension

            ' Make \ the extension for folders - simplifies parsing outputs.
            If isFolder Then
                sExt = "\"
                sNameExt += "\"
            End If

            txt = txt.Replace("<type>", If(isFolder, "folder", "  file"))
            txt = txt.Replace("<typ>", If(isFolder, "fol", "fil"))
            txt = txt.Replace("<fullpath>", itm)
            txt = txt.Replace("<directory>", sDir)
            txt = txt.Replace("<filename>", fInfo.Name)

            ' Strips extension off name. When modifying ensure it works with directories.
            If txt.Contains("<name>") Then
                Dim pos = -1
                Dim idx = sNameExt.IndexOf(sExt)
                Do While (idx >= 0 And idx < sNameExt.Length)
                    pos = idx
                    idx = sNameExt.IndexOf(sExt, idx + 1)
                Loop
                If pos >= 0 Then
                    txt = txt.Replace("<name>", sNameExt.Substring(0, pos))
                End If
            End If

            txt = txt.Replace("<itemtype>", sExt)
            txt = txt.Replace("<tab>", vbTab)

            str = str + txt + vbNewLine

        Next itm

        My.Computer.Clipboard.Clear()
        If str <> "" Then
            My.Computer.Clipboard.SetText(str)
        End If

    End Sub

    Public Sub PasteFromClipboard()
        If My.Computer.Clipboard.ContainsFileDropList Then
            Dim dropList = My.Computer.Clipboard.GetFileDropList
            For Each filePath As String In dropList
                _filesList.Add(filePath)
            Next filePath
        End If
    End Sub

End Class
