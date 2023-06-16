Public Class MainFormSimple
    Friend WithEvents MainMenu1 As MenuStrip
    Friend WithEvents FileMenuItem As ToolStripMenuItem
    Friend WithEvents SampleMenuItem As ToolStripMenuItem
    Friend WithEvents WindowManagerPanel1 As MDIWindowManager.WindowManagerPanel
    Friend WithEvents FileExitMenuItem As ToolStripMenuItem
    Friend WithEvents SampleShowAdvMenuItem As ToolStripMenuItem
    Friend WithEvents SampleShowAltTabsMenuItem As ToolStripMenuItem
    Friend WithEvents SampleShowCustomPaintMenuItem As ToolStripMenuItem
    Private Sub MainFormSimple_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MainMenu1 = New MenuStrip()
        FileMenuItem = New ToolStripMenuItem()
        FileExitMenuItem = New ToolStripMenuItem()
        SampleMenuItem = New ToolStripMenuItem()
        SampleShowAdvMenuItem = New ToolStripMenuItem()
        SampleShowAltTabsMenuItem = New ToolStripMenuItem()
        SampleShowCustomPaintMenuItem = New ToolStripMenuItem()
        MainMenu1.SuspendLayout()
        ' 
        ' MainMenu1
        ' 
        MainMenu1.Items.AddRange(New ToolStripItem() {FileMenuItem, SampleMenuItem})
        MainMenu1.Location = New Point(0, 0)
        MainMenu1.Name = "MainMenu1"
        MainMenu1.Size = New Size(200, 24)
        MainMenu1.TabIndex = 0
        ' 
        ' FileMenuItem
        ' 
        FileMenuItem.DropDownItems.AddRange(New ToolStripItem() {FileExitMenuItem})
        FileMenuItem.Name = "FileMenuItem"
        FileMenuItem.Size = New Size(37, 20)
        FileMenuItem.Text = "&File"
        ' 
        ' FileExitMenuItem
        ' 
        FileExitMenuItem.Name = "FileExitMenuItem"
        FileExitMenuItem.Size = New Size(93, 22)
        FileExitMenuItem.Text = "E&xit"
        ' 
        ' SampleMenuItem
        ' 
        SampleMenuItem.DropDownItems.AddRange(New ToolStripItem() {SampleShowAdvMenuItem, SampleShowAltTabsMenuItem, SampleShowCustomPaintMenuItem})
        SampleMenuItem.Name = "SampleMenuItem"
        SampleMenuItem.Size = New Size(58, 20)
        SampleMenuItem.Text = "&Sample"
        ' 
        ' SampleShowAdvMenuItem
        ' 
        SampleShowAdvMenuItem.Name = "SampleShowAdvMenuItem"
        SampleShowAdvMenuItem.Size = New Size(231, 22)
        SampleShowAdvMenuItem.Text = "Show Advanced Sample..."
        ' 
        ' SampleShowAltTabsMenuItem
        ' 
        SampleShowAltTabsMenuItem.Name = "SampleShowAltTabsMenuItem"
        SampleShowAltTabsMenuItem.Size = New Size(231, 22)
        SampleShowAltTabsMenuItem.Text = "Show Alternate Tabs Sample..."
        ' 
        ' SampleShowCustomPaintMenuItem
        ' 
        SampleShowCustomPaintMenuItem.Name = "SampleShowCustomPaintMenuItem"
        SampleShowCustomPaintMenuItem.Size = New Size(231, 22)
        SampleShowCustomPaintMenuItem.Text = "Show Custom Paint Sample..."
        '
        'Windowmanagerpanel
        '

        Controls.Add(MainMenu1)
        Controls.Add(WindowManagerPanel1)
        MainMenuStrip = MainMenu1
        MainMenu1.ResumeLayout(False)
        MainMenu1.PerformLayout()
        ResumeLayout(False)

        'load a bunch of mdi children
        For count As Integer = 1 To 10
            Dim frm As New ChildForm1

            frm.Text = "Window " + CStr(count)
            frm.TextBox1.Text = "I am Form " + CStr(count)

            frm.MdiParent = Me

            'If AutoDetectMdiChildren property were False this would be
            'the only line of code that is different than regular old mdi.
            'WindowManagerPanel1.AddWindow(frm)

            frm.Show()
        Next count

        'set the focus on the first mdi child
        Me.MdiChildren(0).BringToFront()
        'Equivalent method: 
        'WindowManagerPanel1.SetActiveWindow(0)
        'it is recommended (though not necessary) to use the WindowManager methods

    End Sub

    Private Sub FileExitMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles FileExitMenuItem.Click

        Me.Close()

    End Sub

    Private Sub SampleShowAdvMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SampleShowAdvMenuItem.Click

        Dim frm As New MainFormAdvanced

        frm.Show()

    End Sub

    Private Sub SampleShowAltTabsMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SampleShowAltTabsMenuItem.Click

        Dim frm As New MainFormAltTabs

        frm.Show()

    End Sub

    Private Sub SampleShowCustomPaintMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SampleShowCustomPaintMenuItem.Click

        Dim frm As New MainFormCustomPaint

        frm.Show()

    End Sub

End Class