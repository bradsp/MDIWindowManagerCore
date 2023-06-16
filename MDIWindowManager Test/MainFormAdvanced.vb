Public Class MainFormAdvanced
    Inherits Form

    Private Enum SampleViewMode
        Simple
        AdvancedBottom
        AdvancedRight
        AdvancedLeft
    End Enum

    Private m_useWindowManager As Boolean = True
    Friend WithEvents ViewTabStyleMenuItemSep1 As ToolStripMenuItem
    Friend WithEvents ViewTabStylesMoreInfoMenuItem As ToolStripMenuItem
    Friend WithEvents ViewShowCloseButtonMenuItem As ToolStripMenuItem
    Friend WithEvents ViewShowIconsMenuItem As ToolStripMenuItem
    Friend WithEvents ViewButtonStylesMenuItem As ToolStripMenuItem
    Friend WithEvents ViewButtonStylesStandardMenuItem As ToolStripMenuItem
    Friend WithEvents ViewButtonStylesSystemMenuItem As ToolStripMenuItem
    Friend WithEvents ViewButtonStylesProMenuItem As ToolStripMenuItem
    Private m_viewMode As SampleViewMode

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents StatusBar1 As StatusStrip
    Friend WithEvents MainMenu1 As MenuStrip
    Friend WithEvents ToolBar1 As ToolStrip
    Friend WithEvents ToolBoxPanel As Panel
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ToolBoxSplitter As Splitter
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents WindowManagerPanel1 As MDIWindowManager.WindowManagerPanel
    Friend WithEvents FileMenuItem As ToolStripMenuItem
    Friend WithEvents WindowMenuItem As ToolStripMenuItem
    Friend WithEvents FileNewMenuItem As ToolStripMenuItem
    Friend WithEvents FileOpenMenuItem As ToolStripMenuItem
    Friend WithEvents FileMenuItemSep1 As ToolStripMenuItem
    Friend WithEvents FileExitMenuItem As ToolStripMenuItem
    Friend WithEvents WindowHTileMenuItem As ToolStripMenuItem
    Friend WithEvents WindowTileMenuItem As ToolStripMenuItem
    Friend WithEvents WindowPopOutMenuItem As ToolStripMenuItem
    Friend WithEvents WindowMenuItemSep1 As ToolStripMenuItem
    Friend WithEvents WindowCloseAllMenuItem As ToolStripMenuItem
    Friend WithEvents WindowMenuItemSep2 As ToolStripMenuItem
    Friend WithEvents ViewMenuItem As ToolStripMenuItem
    Friend WithEvents ViewSimpleMenuItem As ToolStripMenuItem
    Friend WithEvents ViewAdvRightMenuItem As ToolStripMenuItem
    Friend WithEvents ViewAdvBottomMenuItem As ToolStripMenuItem
    Friend WithEvents ViewAdvLeftMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ToolBoxLabel As Label
    Friend WithEvents ViewMenuSep1 As ToolStripMenuItem
    Friend WithEvents ShowToolboxMenuItem As ToolStripMenuItem
    Friend WithEvents ToolBoxInfoLabel1 As Label
    Friend WithEvents ToolBoxInfoLabel2 As Label
    Friend WithEvents FileNewTButton As ToolStripButton
    Friend WithEvents FileOpenTButton As ToolStripButton
    Friend WithEvents WindowMoreWindowsMenuItem As ToolStripMenuItem
    Friend WithEvents ClassicMdiWindowMenuItem As ToolStripMenuItem
    Friend WithEvents ClassicMdiWindowCascadeMenuItem As ToolStripMenuItem
    Friend WithEvents ClassicMdiWindowTileHorizMenuItem As ToolStripMenuItem
    Friend WithEvents ClassicMdiWindowTileVertMenuItem As ToolStripMenuItem
    Friend WithEvents ViewMenuItemSep2 As ToolStripMenuItem
    Friend WithEvents SwitchToClassicMdiMenuItem As ToolStripMenuItem
    Friend WithEvents ViewShowLayoutButtonsMenuItem As ToolStripMenuItem
    Friend WithEvents ViewMenuSep4 As ToolStripMenuItem
    Friend WithEvents ViewMenuItemSep3 As ToolStripMenuItem
    Friend WithEvents ViewTabStylesMenuItem As ToolStripMenuItem
    Friend WithEvents ViewTabStylesClassicMenuItem As ToolStripMenuItem
    Friend WithEvents ViewTabStylesModernMenuItem As ToolStripMenuItem
    Friend WithEvents ViewTabStylesFlatHiliteMenuItem As ToolStripMenuItem
    Friend WithEvents ViewTabStylesAngledHiliteMenuItem As ToolStripMenuItem
    Friend WithEvents ViewAppearanceMenuItem As ToolStripMenuItem
    Friend WithEvents ViewShowTitleMenuItem As ToolStripMenuItem
    Friend WithEvents HelpMenuItem As ToolStripMenuItem
    Friend WithEvents HelpTopicsMenuItem As ToolStripMenuItem
    Friend WithEvents HelpAboutMenuItem As ToolStripMenuItem
    Friend WithEvents HelpMenuSep1 As ToolStripMenuItem

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFormAdvanced))
        Me.StatusBar1 = New StatusStrip
        Me.MainMenu1 = New MenuStrip With {
            .AllowMerge = True
        }
        Me.FileMenuItem = New ToolStripMenuItem
        Me.FileNewMenuItem = New ToolStripMenuItem
        Me.FileOpenMenuItem = New ToolStripMenuItem
        Me.FileMenuItemSep1 = New ToolStripMenuItem
        Me.FileExitMenuItem = New ToolStripMenuItem
        Me.ViewMenuItem = New ToolStripMenuItem
        Me.ViewSimpleMenuItem = New ToolStripMenuItem
        Me.ViewAdvRightMenuItem = New ToolStripMenuItem
        Me.ViewAdvBottomMenuItem = New ToolStripMenuItem
        Me.ViewAdvLeftMenuItem = New ToolStripMenuItem
        Me.ViewMenuSep1 = New ToolStripMenuItem
        Me.ViewAppearanceMenuItem = New ToolStripMenuItem
        Me.ViewTabStylesMenuItem = New ToolStripMenuItem
        Me.ViewTabStylesClassicMenuItem = New ToolStripMenuItem
        Me.ViewTabStylesModernMenuItem = New ToolStripMenuItem
        Me.ViewTabStylesFlatHiliteMenuItem = New ToolStripMenuItem
        Me.ViewTabStylesAngledHiliteMenuItem = New ToolStripMenuItem
        Me.ViewTabStyleMenuItemSep1 = New ToolStripMenuItem
        Me.ViewTabStylesMoreInfoMenuItem = New ToolStripMenuItem
        Me.ViewButtonStylesMenuItem = New ToolStripMenuItem
        Me.ViewButtonStylesStandardMenuItem = New ToolStripMenuItem
        Me.ViewButtonStylesSystemMenuItem = New ToolStripMenuItem
        Me.ViewButtonStylesProMenuItem = New ToolStripMenuItem
        Me.ViewMenuItemSep3 = New ToolStripMenuItem
        Me.ViewShowTitleMenuItem = New ToolStripMenuItem
        Me.ViewShowIconsMenuItem = New ToolStripMenuItem
        Me.ViewShowLayoutButtonsMenuItem = New ToolStripMenuItem
        Me.ViewShowCloseButtonMenuItem = New ToolStripMenuItem
        Me.ViewMenuSep4 = New ToolStripMenuItem
        Me.ShowToolboxMenuItem = New ToolStripMenuItem
        Me.ViewMenuItemSep2 = New ToolStripMenuItem
        Me.SwitchToClassicMdiMenuItem = New ToolStripMenuItem
        Me.WindowMenuItem = New ToolStripMenuItem
        Me.WindowHTileMenuItem = New ToolStripMenuItem
        Me.WindowTileMenuItem = New ToolStripMenuItem
        Me.WindowPopOutMenuItem = New ToolStripMenuItem
        Me.WindowMenuItemSep1 = New ToolStripMenuItem
        Me.WindowCloseAllMenuItem = New ToolStripMenuItem
        Me.WindowMenuItemSep2 = New ToolStripMenuItem
        Me.WindowMoreWindowsMenuItem = New ToolStripMenuItem
        Me.ClassicMdiWindowMenuItem = New ToolStripMenuItem
        Me.ClassicMdiWindowCascadeMenuItem = New ToolStripMenuItem
        Me.ClassicMdiWindowTileHorizMenuItem = New ToolStripMenuItem
        Me.ClassicMdiWindowTileVertMenuItem = New ToolStripMenuItem
        Me.HelpMenuItem = New ToolStripMenuItem
        Me.HelpTopicsMenuItem = New ToolStripMenuItem
        Me.HelpMenuSep1 = New ToolStripMenuItem
        Me.HelpAboutMenuItem = New ToolStripMenuItem
        Me.ToolBar1 = New ToolStrip
        Me.FileNewTButton = New ToolStripButton
        Me.FileOpenTButton = New ToolStripButton
        Me.ImageList1 = New ImageList(Me.components)
        Me.ToolBoxPanel = New Panel
        Me.ToolBoxInfoLabel2 = New Label
        Me.ToolBoxInfoLabel1 = New Label
        Me.ToolBoxLabel = New Label
        Me.Button4 = New Button
        Me.Button3 = New Button
        Me.Button2 = New Button
        Me.Button1 = New Button
        Me.ToolBoxSplitter = New Splitter
        Me.ToolTip1 = New ToolTip(Me.components)
        Me.WindowManagerPanel1 = New MDIWindowManager.WindowManagerPanel
        Me.ToolBoxPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New Point(0, 457)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Size = New Size(697, 16)
        Me.StatusBar1.TabIndex = 4
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New ToolStripMenuItem() {Me.FileMenuItem, Me.ViewMenuItem, Me.WindowMenuItem, Me.ClassicMdiWindowMenuItem, Me.HelpMenuItem})
        '
        'FileMenuItem
        '
        Me.FileMenuItem.DropDownItems.AddRange(New ToolStripMenuItem() {Me.FileNewMenuItem, Me.FileOpenMenuItem, Me.FileMenuItemSep1, Me.FileExitMenuItem})
        Me.FileMenuItem.Text = "&File"
        '
        'FileNewMenuItem
        '
        Me.FileNewMenuItem.ShortcutKeys = Shortcut.CtrlN
        Me.FileNewMenuItem.Text = "&New"
        '
        'FileOpenMenuItem
        '
        Me.FileOpenMenuItem.ShortcutKeys = Shortcut.CtrlO
        Me.FileOpenMenuItem.Text = "&Open..."
        '
        'FileMenuItemSep1
        '
        Me.FileMenuItemSep1.Text = "-"
        '
        'FileExitMenuItem
        '
        Me.FileExitMenuItem.Text = "E&xit"
        '
        'ViewMenuItem
        '
        Me.ViewMenuItem.DropDownItems.AddRange(New ToolStripMenuItem() {Me.ViewSimpleMenuItem, Me.ViewAdvRightMenuItem, Me.ViewAdvBottomMenuItem, Me.ViewAdvLeftMenuItem, Me.ViewMenuSep1, Me.ViewAppearanceMenuItem, Me.ViewMenuSep4, Me.ShowToolboxMenuItem, Me.ViewMenuItemSep2, Me.SwitchToClassicMdiMenuItem})
        Me.ViewMenuItem.Text = "&View"
        '
        'ViewSimpleMenuItem
        '
        Me.ViewSimpleMenuItem.CheckState = CheckState.Checked
        Me.ViewSimpleMenuItem.Text = "Simple"
        '
        'ViewAdvRightMenuItem
        '
        Me.ViewAdvRightMenuItem.CheckState = CheckState.Checked
        Me.ViewAdvRightMenuItem.Text = "Advanced View (Right)"
        '
        'ViewAdvBottomMenuItem
        '
        Me.ViewAdvBottomMenuItem.CheckState = CheckState.Checked
        Me.ViewAdvBottomMenuItem.Text = "Advanced View (Bottom)"
        '
        'ViewAdvLeftMenuItem
        '
        Me.ViewAdvLeftMenuItem.CheckState = CheckState.Checked
        Me.ViewAdvLeftMenuItem.Text = "Advanced View (Left)"
        '
        'ViewMenuSep1
        '
        Me.ViewMenuSep1.Text = "-"
        '
        'ViewAppearanceMenuItem
        '
        Me.ViewAppearanceMenuItem.DropDownItems.AddRange(New ToolStripMenuItem() {Me.ViewTabStylesMenuItem, Me.ViewButtonStylesMenuItem, Me.ViewMenuItemSep3, Me.ViewShowTitleMenuItem, Me.ViewShowIconsMenuItem, Me.ViewShowLayoutButtonsMenuItem, Me.ViewShowCloseButtonMenuItem})
        Me.ViewAppearanceMenuItem.Text = "Appearance"
        '
        'ViewTabStylesMenuItem
        '
        Me.ViewTabStylesMenuItem.DropDownItems.AddRange(New ToolStripMenuItem() {Me.ViewTabStylesClassicMenuItem, Me.ViewTabStylesModernMenuItem, Me.ViewTabStylesFlatHiliteMenuItem, Me.ViewTabStylesAngledHiliteMenuItem, Me.ViewTabStyleMenuItemSep1, Me.ViewTabStylesMoreInfoMenuItem})
        Me.ViewTabStylesMenuItem.Text = "Tab Style"
        '
        'ViewTabStylesClassicMenuItem
        '
        Me.ViewTabStylesClassicMenuItem.CheckState = CheckState.Checked
        Me.ViewTabStylesClassicMenuItem.Text = "Classic"
        '
        'ViewTabStylesModernMenuItem
        '
        Me.ViewTabStylesModernMenuItem.CheckState = CheckState.Checked
        Me.ViewTabStylesModernMenuItem.Text = "Modern"
        '
        'ViewTabStylesFlatHiliteMenuItem
        '
        Me.ViewTabStylesFlatHiliteMenuItem.CheckState = CheckState.Checked
        Me.ViewTabStylesFlatHiliteMenuItem.Text = "FlatHilite"
        '
        'ViewTabStylesAngledHiliteMenuItem
        '
        Me.ViewTabStylesAngledHiliteMenuItem.CheckState = CheckState.Checked
        Me.ViewTabStylesAngledHiliteMenuItem.Text = "AngledHilite"
        '
        'ViewTabStyleMenuItemSep1
        '
        Me.ViewTabStyleMenuItemSep1.Text = "-"
        '
        'ViewTabStylesMoreInfoMenuItem
        '
        Me.ViewTabStylesMoreInfoMenuItem.Text = "More info..."
        '
        'ViewButtonStylesMenuItem
        '
        Me.ViewButtonStylesMenuItem.DropDownItems.AddRange(New ToolStripMenuItem() {Me.ViewButtonStylesStandardMenuItem, Me.ViewButtonStylesSystemMenuItem, Me.ViewButtonStylesProMenuItem})
        Me.ViewButtonStylesMenuItem.Text = "Button Style"
        '
        'ViewButtonStylesStandardMenuItem
        '
        Me.ViewButtonStylesStandardMenuItem.CheckState = CheckState.Checked
        Me.ViewButtonStylesStandardMenuItem.Text = "Standard"
        '
        'ViewButtonStylesSystemMenuItem
        '
        Me.ViewButtonStylesSystemMenuItem.CheckState = CheckState.Checked
        Me.ViewButtonStylesSystemMenuItem.Text = "System"
        '
        'ViewButtonStylesProMenuItem
        '
        Me.ViewButtonStylesProMenuItem.CheckState = CheckState.Checked
        Me.ViewButtonStylesProMenuItem.Text = "Professional"
        '
        'ViewMenuItemSep3
        '
        Me.ViewMenuItemSep3.Text = "-"
        '
        'ViewShowTitleMenuItem
        '
        Me.ViewShowTitleMenuItem.Text = "Show Title"
        '
        'ViewShowIconsMenuItem
        '
        Me.ViewShowIconsMenuItem.Text = "Show Icons"
        '
        'ViewShowLayoutButtonsMenuItem
        '
        Me.ViewShowLayoutButtonsMenuItem.Text = "Show Window Layout Buttons"
        '
        'ViewShowCloseButtonMenuItem
        '
        Me.ViewShowCloseButtonMenuItem.Text = "Show Close Button"
        '
        'ViewMenuSep4
        '
        Me.ViewMenuSep4.Text = "-"
        '
        'ShowToolboxMenuItem
        '
        Me.ShowToolboxMenuItem.Text = "Show Toolbox"
        '
        'ViewMenuItemSep2
        '
        Me.ViewMenuItemSep2.Text = "-"
        '
        'SwitchToClassicMdiMenuItem
        '
        Me.SwitchToClassicMdiMenuItem.Text = "Switch to Classic MDI"
        '
        'WindowMenuItem
        '
        Me.WindowMenuItem.DropDownItems.AddRange(New ToolStripMenuItem() {Me.WindowHTileMenuItem, Me.WindowTileMenuItem, Me.WindowPopOutMenuItem, Me.WindowMenuItemSep1, Me.WindowCloseAllMenuItem, Me.WindowMenuItemSep2, Me.WindowMoreWindowsMenuItem})
        Me.WindowMenuItem.Text = "&Window"
        '
        'WindowHTileMenuItem
        '
        Me.WindowHTileMenuItem.Text = "New &Horizontal Tab Group"
        '
        'WindowTileMenuItem
        '
        Me.WindowTileMenuItem.Text = "&Tile or Untile Current Window"
        '
        'WindowPopOutMenuItem
        '
        Me.WindowPopOutMenuItem.Text = "&Pop Out Current Window"
        '
        'WindowMenuItemSep1
        '
        Me.WindowMenuItemSep1.Text = "-"
        '
        'WindowCloseAllMenuItem
        '
        Me.WindowCloseAllMenuItem.Text = "Close A&ll"
        '
        'WindowMenuItemSep2
        '
        Me.WindowMenuItemSep2.Text = "-"
        '
        'WindowMoreWindowsMenuItem
        '
        Me.WindowMoreWindowsMenuItem.Text = "&Windows..."
        '
        'ClassicMdiWindowMenuItem
        '
        'Me.ClassicMdiWindowMenuItem.MdiList = True
        Me.ClassicMdiWindowMenuItem.DropDownItems.AddRange(New ToolStripMenuItem() {Me.ClassicMdiWindowCascadeMenuItem, Me.ClassicMdiWindowTileHorizMenuItem, Me.ClassicMdiWindowTileVertMenuItem})
        Me.ClassicMdiWindowMenuItem.Text = "&Window"
        '
        'ClassicMdiWindowCascadeMenuItem
        '
        Me.ClassicMdiWindowCascadeMenuItem.Text = "Cascade"
        '
        'ClassicMdiWindowTileHorizMenuItem
        '
        Me.ClassicMdiWindowTileHorizMenuItem.Text = "Tile Horizontally"
        '
        'ClassicMdiWindowTileVertMenuItem
        '
        Me.ClassicMdiWindowTileVertMenuItem.Text = "Tile Vertically"
        '
        'HelpMenuItem
        '
        Me.HelpMenuItem.DropDownItems.AddRange(New ToolStripMenuItem() {Me.HelpTopicsMenuItem, Me.HelpMenuSep1, Me.HelpAboutMenuItem})
        Me.HelpMenuItem.Text = "Help"
        '
        'HelpTopicsMenuItem
        '
        Me.HelpTopicsMenuItem.Text = "Online Documentation"
        '
        'HelpMenuSep1
        '
        Me.HelpMenuSep1.Text = "-"
        '
        'HelpAboutMenuItem
        '
        Me.HelpAboutMenuItem.Text = "About MDIWindowManager Sample"
        '
        'ToolBar1
        '
        'Me.ToolBar1.GripStyle = 
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Items.AddRange(New ToolStripButton() {Me.FileNewTButton, Me.FileOpenTButton})
        'Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowItemToolTips = True
        Me.ToolBar1.Size = New Size(697, 28)
        Me.ToolBar1.TabIndex = 8
        'Me.ToolBar1.LayoutStyle = ToolBarTextAlign.Right
        '
        'FileNewTButton
        '
        Me.FileNewTButton.ImageIndex = 0
        Me.FileNewTButton.Name = "FileNewTButton"
        Me.FileNewTButton.ToolTipText = "New"
        '
        'FileOpenTButton
        '
        Me.FileOpenTButton.ImageIndex = 1
        Me.FileOpenTButton.Name = "FileOpenTButton"
        Me.FileOpenTButton.ToolTipText = "Open"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        Me.ImageList1.TransparentColor = Color.Silver
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        '
        'ToolBoxPanel
        '
        Me.ToolBoxPanel.BorderStyle = BorderStyle.Fixed3D
        Me.ToolBoxPanel.Controls.Add(Me.ToolBoxInfoLabel2)
        Me.ToolBoxPanel.Controls.Add(Me.ToolBoxInfoLabel1)
        Me.ToolBoxPanel.Controls.Add(Me.ToolBoxLabel)
        Me.ToolBoxPanel.Controls.Add(Me.Button4)
        Me.ToolBoxPanel.Controls.Add(Me.Button3)
        Me.ToolBoxPanel.Controls.Add(Me.Button2)
        Me.ToolBoxPanel.Controls.Add(Me.Button1)
        Me.ToolBoxPanel.Dock = DockStyle.Left
        Me.ToolBoxPanel.Location = New Point(0, 28)
        Me.ToolBoxPanel.Name = "ToolBoxPanel"
        Me.ToolBoxPanel.Size = New Size(100, 429)
        Me.ToolBoxPanel.TabIndex = 10
        '
        'ToolBoxInfoLabel2
        '
        Me.ToolBoxInfoLabel2.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
                    Or AnchorStyles.Right), AnchorStyles)
        Me.ToolBoxInfoLabel2.Location = New Point(5, 291)
        Me.ToolBoxInfoLabel2.Name = "ToolBoxInfoLabel2"
        Me.ToolBoxInfoLabel2.Size = New Size(87, 126)
        Me.ToolBoxInfoLabel2.TabIndex = 6
        Me.ToolBoxInfoLabel2.Text = "For instance, a toolbox like this could be used to switch the ""Axilliary Window"" " &
            "property of MDIWindowManager."
        '
        'ToolBoxInfoLabel1
        '
        Me.ToolBoxInfoLabel1.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
                    Or AnchorStyles.Right), AnchorStyles)
        Me.ToolBoxInfoLabel1.Location = New Point(5, 190)
        Me.ToolBoxInfoLabel1.Name = "ToolBoxInfoLabel1"
        Me.ToolBoxInfoLabel1.Size = New Size(87, 97)
        Me.ToolBoxInfoLabel1.TabIndex = 5
        Me.ToolBoxInfoLabel1.Text = "This toolbox is not a feature of MDIWindowManager. It is simply a panel docked to" &
            " the side of the MDI parent."
        '
        'ToolBoxLabel
        '
        Me.ToolBoxLabel.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
                    Or AnchorStyles.Right), AnchorStyles)
        Me.ToolBoxLabel.BackColor = SystemColors.ControlDark
        Me.ToolBoxLabel.ForeColor = SystemColors.ControlLightLight
        Me.ToolBoxLabel.Location = New Point(2, 2)
        Me.ToolBoxLabel.Name = "ToolBoxLabel"
        Me.ToolBoxLabel.Size = New Size(92, 14)
        Me.ToolBoxLabel.TabIndex = 4
        Me.ToolBoxLabel.Text = "Toolbox"
        '
        'Button4
        '
        Me.Button4.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
                    Or AnchorStyles.Right), AnchorStyles)
        Me.Button4.Image = Global.MDIWindowManager_Test.My.Resources.Resources.Calender_2
        Me.Button4.ImageAlign = ContentAlignment.MiddleLeft
        Me.Button4.Location = New Point(8, 142)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New Size(104, 40)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Tasks"
        Me.Button4.TextImageRelation = TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
                    Or AnchorStyles.Right), AnchorStyles)
        Me.Button3.Image = Global.MDIWindowManager_Test.My.Resources.Resources.Calender_1
        Me.Button3.ImageAlign = ContentAlignment.MiddleLeft
        Me.Button3.Location = New Point(8, 102)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New Size(104, 40)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Calendar"
        Me.Button3.TextImageRelation = TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
                    Or AnchorStyles.Right), AnchorStyles)
        Me.Button2.Image = Global.MDIWindowManager_Test.My.Resources.Resources.Books_2
        Me.Button2.ImageAlign = ContentAlignment.MiddleLeft
        Me.Button2.Location = New Point(8, 62)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New Size(104, 40)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Contacts"
        Me.Button2.TextImageRelation = TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
                    Or AnchorStyles.Right), AnchorStyles)
        Me.Button1.Image = Global.MDIWindowManager_Test.My.Resources.Resources.LETTER
        Me.Button1.ImageAlign = ContentAlignment.MiddleLeft
        Me.Button1.Location = New Point(8, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New Size(104, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Inbox"
        Me.Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ToolBoxSplitter
        '
        Me.ToolBoxSplitter.Location = New Point(100, 28)
        Me.ToolBoxSplitter.Name = "ToolBoxSplitter"
        Me.ToolBoxSplitter.Size = New Size(4, 429)
        Me.ToolBoxSplitter.TabIndex = 18
        Me.ToolBoxSplitter.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ToolBoxSplitter, "Test Horizontal Reposition Adjustment")
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 0
        Me.ToolTip1.AutoPopDelay = 10000
        Me.ToolTip1.InitialDelay = 0
        Me.ToolTip1.ReshowDelay = 0
        '
        'WindowManagerPanel1
        '
        Me.WindowManagerPanel1.AllowUserVerticalRepositioning = False
        Me.WindowManagerPanel1.AutoDetectMdiChildWindows = True
        Me.WindowManagerPanel1.AutoHide = False
        Me.WindowManagerPanel1.ButtonRenderMode = MDIWindowManager.ButtonRenderMode.Professional
        Me.WindowManagerPanel1.DisableCloseAction = False
        Me.WindowManagerPanel1.DisableHTileAction = False
        Me.WindowManagerPanel1.DisablePopoutAction = False
        Me.WindowManagerPanel1.DisableTileAction = False
        Me.WindowManagerPanel1.EnableTabPaintEvent = False
        Me.WindowManagerPanel1.ForeColor = SystemColors.ControlText
        Me.WindowManagerPanel1.Location = New Point(106, 30)
        Me.WindowManagerPanel1.MinMode = False
        Me.WindowManagerPanel1.Name = "WindowManagerPanel1"
        Me.WindowManagerPanel1.Orientation = MDIWindowManager.WindowManagerOrientation.Top
        Me.WindowManagerPanel1.ShowCloseButton = True
        Me.WindowManagerPanel1.ShowIcons = True
        Me.WindowManagerPanel1.ShowLayoutButtons = False
        Me.WindowManagerPanel1.ShowTitle = True
        Me.WindowManagerPanel1.Size = New Size(589, 42)
        Me.WindowManagerPanel1.Style = MDIWindowManager.TabStyle.AngledHiliteTabs
        Me.WindowManagerPanel1.TabIndex = 32
        Me.WindowManagerPanel1.TabRenderMode = MDIWindowManager.TabsProvider.Standard
        Me.WindowManagerPanel1.Text = "Open Items"
        Me.WindowManagerPanel1.TitleBackColor = SystemColors.ControlDark
        Me.WindowManagerPanel1.TitleForeColor = SystemColors.ControlLightLight
        '
        'MainFormAdvanced
        '
        Me.AutoScaleBaseSize = New Size(5, 13)
        Me.ClientSize = New Size(697, 473)
        Me.Controls.Add(Me.WindowManagerPanel1)
        Me.Controls.Add(Me.ToolBoxSplitter)
        Me.Controls.Add(Me.ToolBoxPanel)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.ToolBar1)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MainMenu1
        Me.Name = "MainFormAdvanced"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "MDIWindowManager Sample (Advanced)"
        Me.ToolBoxPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.ToolBoxPanel.Visible = False

        InitializeSampleView()

    End Sub

    Private Sub InitializeSampleView()

        If m_useWindowManager Then
            InitializeUsingWindowManager()
        Else
            InitializeUsingClassicMDI()
        End If

    End Sub

    Private Sub InitializeUsingWindowManager()

        'enable WindowManagerPanel
        Me.WindowManagerPanel1.AutoDetectMdiChildWindows = True
        Me.WindowManagerPanel1.Visible = True

        'show our Window Menu (see WindowMenuItem_Popup for more details)
        Me.WindowMenuItem.Visible = True
        'hide the Classic MDI Window Menu if it's visible.
        Me.ClassicMdiWindowMenuItem.Visible = False

        'set up the look and feel of our sample
        SetupWindowManagerProperties(SampleViewMode.AdvancedBottom)

        LoadStartPage()
        LoadSampleWindows()

        'set focus on the first window
        'you can also simply use Form.Show/Form.BringToFront, but this lessens flicker
        Me.WindowManagerPanel1.SetActiveWindow(0)

    End Sub

    Private Sub InitializeUsingClassicMDI()

        'disable WindowManagerPanel
        Me.WindowManagerPanel1.AutoDetectMdiChildWindows = False
        Me.WindowManagerPanel1.Visible = False

        'hide our special Window Menu
        Me.WindowMenuItem.Visible = False
        'show the Classic MDI Window Menu
        Me.ClassicMdiWindowMenuItem.Visible = True

        'set up the look and feel of our sample
        SetupWindowManagerProperties(SampleViewMode.Simple)

        LoadStartPage()
        LoadSampleWindows()
        LoadAuxWindow()

        Me.LayoutMdi(MdiLayout.Cascade)

        'set focus on the first window
        Me.MdiChildren(0).BringToFront()

    End Sub

    Private Sub CloseAllChildren()

        If m_useWindowManager Then
            Me.WindowManagerPanel1.CloseAllWindows()
        Else
            For Each frm As Form In Me.MdiChildren
                frm.Close()
            Next frm
        End If

    End Sub

    Private Sub AddChildWindow(ByVal frm As Form)

        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub LoadStartPage()

        Dim frm As New ChildFormIntro

        AddChildWindow(frm)

    End Sub

    Private Sub LoadSampleWindows()

        For count As Integer = 1 To 10
            Dim frm As New ChildForm1

            frm.Text = "Window " + CStr(count)
            frm.TextBox1.Text = "I am Form " + CStr(count)

            AddChildWindow(frm)
        Next count

    End Sub

    Private Sub LoadAuxWindow()

        Dim frm As New ChildAuxForm

        AddChildWindow(frm)

    End Sub

    Private Sub DoFileNew()

        AddChildWindow(New ChildForm2)

    End Sub

    Private Sub DoFileOpen()

        Dim dlg As New OpenFileDialog

        dlg.Filter = "Text Files|*.txt|All Files|*.*"

        If dlg.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            Dim frm As New ChildForm2

            AddChildWindow(frm)

            Dim sr As New System.IO.StreamReader(dlg.FileName, System.Text.Encoding.Default)

            frm.TextBox1.Text = sr.ReadToEnd()

            sr.Close()
        End If

    End Sub

    Private Sub FileNewMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileNewMenuItem.Click

        DoFileNew()

    End Sub

    Private Sub FileOpenMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileOpenMenuItem.Click

        DoFileOpen()

    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As ToolStripItemClickedEventArgs) Handles ToolBar1.ItemClicked


        If e.ClickedItem Is FileNewTButton Then
            DoFileNew()
        ElseIf e.ClickedItem Is FileOpenTButton Then
            DoFileOpen()
        End If

    End Sub

    Private Sub FileExitMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileExitMenuItem.Click

        Me.Close()

    End Sub

    Private Sub WindowMenuItem_Popup(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowMenuItem.DropDownOpened


        'We can use the features of WindowManager to load up
        'a list of all the windows.

        'remove all the old items from the menu
        For index As Integer = Me.WindowMenuItem.DropDownItems.Count - 1 To 0 Step -1
            Dim mnu As ToolStripMenuItem = Me.WindowMenuItem.DropDownItems.Item(index)

            If TypeOf mnu Is MDIWindowManager.WrappedWindowMenuItem Then
                Me.WindowMenuItem.DropDownItems.Remove(mnu)
            End If
        Next index

        'get the first 9 window items and add them to the menu
        Dim menuItems As ToolStripMenuItem() = Me.WindowManagerPanel1.GetAllWindowsMenu(9, True)

        If Not menuItems Is Nothing AndAlso menuItems.Length > 0 Then
            Me.WindowMenuItem.DropDownItems.AddRange(menuItems)
        End If

        'ensure the "more windows" menu item is positioned at the bottom of the menu

    End Sub

    Private Sub WindowHTileMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowHTileMenuItem.Click

        Me.WindowManagerPanel1.HTileWrappedWindow(Me.WindowManagerPanel1.GetActiveWindow())

    End Sub

    Private Sub WindowTileMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowTileMenuItem.Click

        Me.WindowManagerPanel1.TileOrUntileWrappedWindow(Me.WindowManagerPanel1.GetActiveWindow())

    End Sub

    Private Sub WindowPopOutMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowPopOutMenuItem.Click

        Me.WindowManagerPanel1.PopOutWrappedWindow(Me.WindowManagerPanel1.GetActiveWindow())

    End Sub

    Private Sub WindowCloseAllMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowCloseAllMenuItem.Click

        CloseAllChildren()

    End Sub

    Private Sub WindowMoreWindowsMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowMoreWindowsMenuItem.Click

        Me.WindowManagerPanel1.ShowAllWindowsDialog()

    End Sub

    Private Sub ClassicMdiWindowCascadeMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassicMdiWindowCascadeMenuItem.Click

        LayoutMdi(MdiLayout.Cascade)

    End Sub

    Private Sub ClassicMdiWindowTileHorizMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassicMdiWindowTileHorizMenuItem.Click

        LayoutMdi(MdiLayout.TileHorizontal)

    End Sub

    Private Sub ClassicMdiWindowTileVertMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassicMdiWindowTileVertMenuItem.Click

        LayoutMdi(MdiLayout.TileVertical)

    End Sub

    Private Sub ViewSimpleMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ViewSimpleMenuItem.Click

        SetupWindowManagerProperties(SampleViewMode.Simple)

    End Sub

    Private Sub ViewAdvBottomMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ViewAdvBottomMenuItem.Click

        SetupWindowManagerProperties(SampleViewMode.AdvancedBottom)

    End Sub

    Private Sub ViewAdvRightMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ViewAdvRightMenuItem.Click

        SetupWindowManagerProperties(SampleViewMode.AdvancedRight)

    End Sub

    Private Sub ViewAdvLeftMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ViewAdvLeftMenuItem.Click

        SetupWindowManagerProperties(SampleViewMode.AdvancedLeft)

    End Sub

    Private Sub ViewShowTitleMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewShowTitleMenuItem.Click

        Me.WindowManagerPanel1.ShowTitle = Not Me.WindowManagerPanel1.ShowTitle

        If Me.WindowManagerPanel1.ShowTitle Then
            Me.WindowManagerPanel1.Height = 42
        Else
            Me.WindowManagerPanel1.Height = 26
        End If

    End Sub

    Private Sub ViewShowLayoutButtons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewShowLayoutButtonsMenuItem.Click

        Me.WindowManagerPanel1.ShowLayoutButtons = Not Me.WindowManagerPanel1.ShowLayoutButtons

    End Sub

    Private Sub ViewShowCloseButtonMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewShowCloseButtonMenuItem.Click

        Me.WindowManagerPanel1.ShowCloseButton = Not Me.WindowManagerPanel1.ShowCloseButton

    End Sub

    Private Sub ViewShowIconsMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewShowIconsMenuItem.Click

        Me.WindowManagerPanel1.ShowIcons = Not Me.WindowManagerPanel1.ShowIcons

    End Sub

    Private Sub ViewTabStylesClassicMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewTabStylesClassicMenuItem.Click

        Me.WindowManagerPanel1.Style = MDIWindowManager.TabStyle.ClassicTabs

    End Sub

    Private Sub ViewTabStylesModernMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewTabStylesModernMenuItem.Click

        Me.WindowManagerPanel1.Style = MDIWindowManager.TabStyle.ModernTabs

    End Sub

    Private Sub ViewTabStylesFlatHiliteMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewTabStylesFlatHiliteMenuItem.Click

        Me.WindowManagerPanel1.Style = MDIWindowManager.TabStyle.FlatHiliteTabs

    End Sub

    Private Sub ViewTabStylesAngledHiliteMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewTabStylesAngledHiliteMenuItem.Click

        Me.WindowManagerPanel1.Style = MDIWindowManager.TabStyle.AngledHiliteTabs

    End Sub

    Private Sub ViewButtonStylesStandardMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewButtonStylesStandardMenuItem.Click

        Me.WindowManagerPanel1.ButtonRenderMode = MDIWindowManager.ButtonRenderMode.Standard

    End Sub

    Private Sub ViewButtonStylesSystemMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewButtonStylesSystemMenuItem.Click

        Me.WindowManagerPanel1.ButtonRenderMode = MDIWindowManager.ButtonRenderMode.System

    End Sub

    Private Sub ViewButtonStylesProMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewButtonStylesProMenuItem.Click

        Me.WindowManagerPanel1.ButtonRenderMode = MDIWindowManager.ButtonRenderMode.Professional

    End Sub

    Private Sub ShowToolboxMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolboxMenuItem.Click

        Me.ToolBoxPanel.Visible = Not Me.ToolBoxPanel.Visible
        Me.ToolBoxSplitter.Visible = Me.ToolBoxPanel.Visible

    End Sub

    Private Sub SwitchToClassicMdiMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SwitchToClassicMdiMenuItem.Click

        CloseAllChildren()
        m_useWindowManager = Not m_useWindowManager
        InitializeSampleView()

    End Sub

    Private Sub ViewMenuItem_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles ViewMenuItem.DropDownOpened

        Me.ViewSimpleMenuItem.Enabled = m_useWindowManager
        Me.ViewAdvRightMenuItem.Enabled = m_useWindowManager
        Me.ViewAdvBottomMenuItem.Enabled = m_useWindowManager
        Me.ViewAdvLeftMenuItem.Enabled = m_useWindowManager
        Me.ViewAppearanceMenuItem.Enabled = m_useWindowManager

        Me.ViewSimpleMenuItem.Checked = False
        Me.ViewAdvRightMenuItem.Checked = False
        Me.ViewAdvBottomMenuItem.Checked = False
        Me.ViewAdvLeftMenuItem.Checked = False

        Select Case m_viewMode
            Case SampleViewMode.Simple
                Me.ViewSimpleMenuItem.Checked = True
            Case SampleViewMode.AdvancedRight
                Me.ViewAdvRightMenuItem.Checked = True
            Case SampleViewMode.AdvancedBottom
                Me.ViewAdvBottomMenuItem.Checked = True
            Case SampleViewMode.AdvancedLeft
                Me.ViewAdvLeftMenuItem.Checked = True
        End Select

        Me.ViewShowTitleMenuItem.Checked = Me.WindowManagerPanel1.ShowTitle
        Me.ViewShowIconsMenuItem.Checked = Me.WindowManagerPanel1.ShowIcons
        Me.ViewShowLayoutButtonsMenuItem.Checked = Me.WindowManagerPanel1.ShowLayoutButtons
        Me.ViewShowCloseButtonMenuItem.Checked = Me.WindowManagerPanel1.ShowCloseButton
        Me.ShowToolboxMenuItem.Checked = Me.ToolBoxPanel.Visible

        Me.ViewTabStylesClassicMenuItem.Checked = False
        Me.ViewTabStylesModernMenuItem.Checked = False
        Me.ViewTabStylesFlatHiliteMenuItem.Checked = False
        Me.ViewTabStylesAngledHiliteMenuItem.Checked = False

        Select Case Me.WindowManagerPanel1.Style
            Case MDIWindowManager.TabStyle.ClassicTabs
                Me.ViewTabStylesClassicMenuItem.Checked = True
            Case MDIWindowManager.TabStyle.ModernTabs
                Me.ViewTabStylesModernMenuItem.Checked = True
            Case MDIWindowManager.TabStyle.FlatHiliteTabs
                Me.ViewTabStylesFlatHiliteMenuItem.Checked = True
            Case MDIWindowManager.TabStyle.AngledHiliteTabs
                Me.ViewTabStylesAngledHiliteMenuItem.Checked = True
        End Select

        Me.ViewButtonStylesStandardMenuItem.Checked = False
        Me.ViewButtonStylesSystemMenuItem.Checked = False
        Me.ViewButtonStylesProMenuItem.Checked = False

        Select Case Me.WindowManagerPanel1.ButtonRenderMode
            Case MDIWindowManager.ButtonRenderMode.Standard
                Me.ViewButtonStylesStandardMenuItem.Checked = True
            Case MDIWindowManager.ButtonRenderMode.System
                Me.ViewButtonStylesSystemMenuItem.Checked = True
            Case MDIWindowManager.ButtonRenderMode.Professional
                Me.ViewButtonStylesProMenuItem.Checked = True
        End Select

        If m_useWindowManager Then
            SwitchToClassicMdiMenuItem.Text = "Switch to Classic MDI"
        Else
            SwitchToClassicMdiMenuItem.Text = "Switch to MDIWindowManager"
        End If

    End Sub

    Private Sub SetupWindowManagerProperties(ByVal viewMode As SampleViewMode)

        Select Case viewMode
            Case SampleViewMode.Simple
                Me.ToolBoxPanel.Width = 100

                'get rid of the docked aux window... see other Cases below for more info
                If Not Me.WindowManagerPanel1.AuxiliaryWindow Is Nothing Then
                    Me.WindowManagerPanel1.AuxiliaryWindow.Close()
                    Me.WindowManagerPanel1.AuxiliaryWindow = Nothing
                End If

                With Me.WindowManagerPanel1
                    .Orientation = MDIWindowManager.WindowManagerOrientation.Top

                    'the following properties are normally set at design-time, but since
                    'we're showing different samples let's do the work here
                    .AllowUserVerticalRepositioning = False
                    .Top = .GetMDIClientAreaBounds.Top
                    .ShowTitle = False
                    .Height = 26
                    .AutoHide = True
                End With
            Case SampleViewMode.AdvancedBottom, SampleViewMode.AdvancedRight, SampleViewMode.AdvancedLeft
                Me.ToolBoxPanel.Width = 100

                With Me.WindowManagerPanel1
                    'these properties are normally set at design-time, but since
                    'we're showing different samples let's do the work here
                    .ShowTitle = True
                    .Height = 42
                    .AutoHide = False

                    Select Case viewMode
                        Case SampleViewMode.AdvancedBottom
                            .Orientation = MDIWindowManager.WindowManagerOrientation.Bottom
                            .AllowUserVerticalRepositioning = True
                            .Top = 200
                        Case SampleViewMode.AdvancedRight
                            .Orientation = MDIWindowManager.WindowManagerOrientation.Right
                            .AllowUserVerticalRepositioning = False
                            .Top = .GetMDIClientAreaBounds.Top
                            .Width = 450
                        Case SampleViewMode.AdvancedLeft
                            .Orientation = MDIWindowManager.WindowManagerOrientation.Left
                            .AllowUserVerticalRepositioning = False
                            .Top = .GetMDIClientAreaBounds.Top
                            .Width = 450
                    End Select

                    'set up an "aux" window that will be managed by WindowManagerPanel, but is
                    'not shown in the Tabs... instead it is docked as a sort of appendage in order
                    'to achieve the look and feel of 2 and 3-pane apps like Outlook.
                    If Me.WindowManagerPanel1.AuxiliaryWindow Is Nothing Then
                        Dim frm As New ChildAuxForm

                        frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None

                        Me.WindowManagerPanel1.AuxiliaryWindow = frm

                        frm.Show()
                    End If

                    If viewMode = SampleViewMode.AdvancedBottom Then
                        .AutoHide = True
                    Else
                        .AutoHide = False
                    End If
                End With
        End Select

        m_viewMode = viewMode

    End Sub

    Private Sub HelpTopicsMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpTopicsMenuItem.Click

        Process.Start("http://www.cflashsoft.com/progs/mdiwinman/")

    End Sub

    Private Sub HelpAboutMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HelpAboutMenuItem.Click

        MsgBox("Control: " & System.Reflection.Assembly.GetAssembly(Me.WindowManagerPanel1.GetType()).GetName().FullName _
            & vbCrLf & "Test App: " & System.Reflection.Assembly.GetExecutingAssembly().FullName)

    End Sub

    Private Sub ViewTabStylesMoreInfoMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewTabStylesMoreInfoMenuItem.Click

        MsgBox("These are the default tab styles provided by WindowManagerPanel. You can customize or completely handle how tabs are drawn via the <<TabPaint>> event (see Custom Paint Sample)." & vbCrLf & vbCrLf _
            & "Additionally, you can also create totally custom 'TabProviders.' MDIWindowManager currently contains an additional TabProvider called SystemTabsProvider, which uses the standard .NET TabControl to present the tabs (see Alternate Tabs Sample). " _
            & "For convenience, you can accomplish the same shown by the Alternate Tabs Sample by using TabRenderMode property in the designer." & vbCrLf & vbCrLf _
            , MsgBoxStyle.Information)

    End Sub

End Class