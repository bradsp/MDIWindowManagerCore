# MDIWindowManager
MDIWindowManager is a control that allows you to create MDI applications using a modern Tabbed Document Interface. The control works on traditional MDI forms and does not require that children be derived from some proprietary base class or implement some special interface or framework. The goal of MDIWindowManager was complete transparency and absolute ease of use all while supporting advanced features such as tiling.

MDIWindowManager is a control that can be added to your MDI Parent forms to achieve the Tabbed Document Interface seen in many modern applications.

Not a beta.
Very stable at this point and already in use in several in-house business applications.
Fully Open Source, not a commercial pre-release.

Mature and complete features:

    Completely transparent and non-intrusive. There is no complex "framework" locking you into a particular technology... windows do not need to derive from some base class and no code changes need to be done on either the child windows or in MDI child loading code.
    Built-in support for various window layouts, Tile Vertically, Tile Horizontally, Pop out to desktop... all while keeping the Tabbed Interface aesthetic (no title bar on child windows, no overlapping windows, etc).
    Supports CTRL+TAB forward and reverse window switching.
    Supports advanced 2 and 3-pane views without forcing the user to implement their windows as UserControls.
    Supports minimizing the window manager (in multi-pane scenarios) in a novel way.
    Built-in "Windows" menu that can be cloned and added to your parent form. Furthermore, since MDI Children are still MDI Children under the scenes, there is full support for menu merging.
    Supports several tab styles including the intrinsic Windows/.NET tab control and custom painting of tabs.
    
This was originally published on CodePlex (https://archive.codeplex.com/?p=mdiwinman). Copied here to save the sourcecode before CodePlex was shutdown.
