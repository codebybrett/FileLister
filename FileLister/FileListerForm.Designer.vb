<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileListerForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FileListerForm))
        Me.FileListBox = New System.Windows.Forms.ListBox()
        Me.FileListBoxContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlsPnl = New System.Windows.Forms.Panel()
        Me.RemoveBtn = New System.Windows.Forms.Button()
        Me.FormatCbo = New System.Windows.Forms.ComboBox()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.CopyBtn = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileListBoxContextMenu.SuspendLayout()
        Me.ControlsPnl.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FileListBox
        '
        Me.FileListBox.AllowDrop = True
        Me.FileListBox.ContextMenuStrip = Me.FileListBoxContextMenu
        Me.FileListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FileListBox.FormattingEnabled = True
        Me.FileListBox.ItemHeight = 29
        Me.FileListBox.Location = New System.Drawing.Point(0, 45)
        Me.FileListBox.Name = "FileListBox"
        Me.FileListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.FileListBox.Size = New System.Drawing.Size(1236, 707)
        Me.FileListBox.TabIndex = 0
        '
        'FileListBoxContextMenu
        '
        Me.FileListBoxContextMenu.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.FileListBoxContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.FileListBoxContextMenu.Name = "FileListBoxContextMenu"
        Me.FileListBoxContextMenu.Size = New System.Drawing.Size(157, 46)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(156, 42)
        Me.ToolStripMenuItem1.Text = "Paste"
        '
        'ControlsPnl
        '
        Me.ControlsPnl.Controls.Add(Me.RemoveBtn)
        Me.ControlsPnl.Controls.Add(Me.FormatCbo)
        Me.ControlsPnl.Controls.Add(Me.ClearBtn)
        Me.ControlsPnl.Controls.Add(Me.CopyBtn)
        Me.ControlsPnl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ControlsPnl.Location = New System.Drawing.Point(0, 653)
        Me.ControlsPnl.Name = "ControlsPnl"
        Me.ControlsPnl.Size = New System.Drawing.Size(1236, 99)
        Me.ControlsPnl.TabIndex = 1
        '
        'RemoveBtn
        '
        Me.RemoveBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RemoveBtn.Location = New System.Drawing.Point(175, 16)
        Me.RemoveBtn.Name = "RemoveBtn"
        Me.RemoveBtn.Size = New System.Drawing.Size(161, 63)
        Me.RemoveBtn.TabIndex = 3
        Me.RemoveBtn.Text = "Remove"
        Me.RemoveBtn.UseVisualStyleBackColor = True
        '
        'FormatCbo
        '
        Me.FormatCbo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FormatCbo.FormattingEnabled = True
        Me.FormatCbo.Location = New System.Drawing.Point(379, 16)
        Me.FormatCbo.Name = "FormatCbo"
        Me.FormatCbo.Size = New System.Drawing.Size(639, 37)
        Me.FormatCbo.TabIndex = 2
        '
        'ClearBtn
        '
        Me.ClearBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ClearBtn.Location = New System.Drawing.Point(12, 16)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(148, 63)
        Me.ClearBtn.TabIndex = 1
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'CopyBtn
        '
        Me.CopyBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CopyBtn.Location = New System.Drawing.Point(1050, 16)
        Me.CopyBtn.Name = "CopyBtn"
        Me.CopyBtn.Size = New System.Drawing.Size(159, 63)
        Me.CopyBtn.TabIndex = 0
        Me.CopyBtn.Text = "Copy"
        Me.CopyBtn.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1236, 45)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripSeparator3, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.toolStripSeparator4, Me.SelectAllToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(75, 41)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(277, 6)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(280, 42)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(280, 42)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(277, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(280, 42)
        Me.SelectAllToolStripMenuItem.Text = "Select &All"
        '
        'FileListerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1236, 752)
        Me.Controls.Add(Me.ControlsPnl)
        Me.Controls.Add(Me.FileListBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FileListerForm"
        Me.Text = "File Lister - drag or paste files onto list, copy to clipboard"
        Me.FileListBoxContextMenu.ResumeLayout(False)
        Me.ControlsPnl.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FileListBox As ListBox
    Friend WithEvents ControlsPnl As Panel
    Friend WithEvents ClearBtn As Button
    Friend WithEvents CopyBtn As Button
    Friend WithEvents FormatCbo As ComboBox
    Friend WithEvents RemoveBtn As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileListBoxContextMenu As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
