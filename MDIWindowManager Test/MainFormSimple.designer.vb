Imports System.Windows.Forms.Design

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainFormSimple
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        SuspendLayout()
        ' 
        ' MainFormSimple
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(766, 509)
        IsMdiContainer = True
        KeyPreview = True
        Margin = New Padding(4, 3, 4, 3)
        Name = "MainFormSimple"
        Text = "MDIWindowManager Sample (Simple)"
        ResumeLayout(False)
    End Sub

End Class
