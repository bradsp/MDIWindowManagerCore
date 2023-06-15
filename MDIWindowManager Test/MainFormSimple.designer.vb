<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFormSimple
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        MainMenu1 = New MenuStrip()
        FileMenuItem = New ToolStripMenuItem()
        FileExitMenuItem = New ToolStripMenuItem()
        SampleMenuItem = New ToolStripMenuItem()
        SampleShowAdvMenuItem = New ToolStripMenuItem()
        SampleShowAltTabsMenuItem = New ToolStripMenuItem()
        SampleShowCustomPaintMenuItem = New ToolStripMenuItem()
        MainMenu1.SuspendLayout()
        SuspendLayout()
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
        ' MainFormSimple
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(766, 509)
        IsMdiContainer = True
        KeyPreview = True
        MainMenuStrip = MainMenu1
        Margin = New Padding(4, 3, 4, 3)
        Name = "MainFormSimple"
        Text = "MDIWindowManager Sample (Simple)"
        MainMenu1.ResumeLayout(False)
        MainMenu1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents MainMenu1 As MenuStrip
    Friend WithEvents FileMenuItem As ToolStripMenuItem
    Friend WithEvents FileExitMenuItem As ToolStripMenuItem
    Friend WithEvents SampleMenuItem As ToolStripMenuItem
    Friend WithEvents SampleShowAdvMenuItem As ToolStripMenuItem
    Friend WithEvents WindowManagerPanel1 As MDIWindowManager.WindowManagerPanel
    Friend WithEvents SampleShowAltTabsMenuItem As ToolStripMenuItem
    Friend WithEvents SampleShowCustomPaintMenuItem As ToolStripMenuItem
End Class
