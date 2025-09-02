<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = _
            New System.ComponentModel.ComponentResourceManager(GetType(MainView))

        mnuMain = New MenuStrip()
        mnuFile = New ToolStripMenuItem()
        mnuFileExit = New ToolStripMenuItem()
        mnuRun = New ToolStripMenuItem()
        mnuRunCommand = New ToolStripMenuItem()

        dlgOpen = New OpenFileDialog()

        picView = New PictureBox()
        CType(picView, ComponentModel.ISupportInitialize).BeginInit()
        mnuMain.SuspendLayout()
        Me.SuspendLayout()

        '
        ' mnuMain
        '
        resources.ApplyResources(mnuMain, "mnuMain")
        mnuMain.Items.AddRange(New ToolStripItem() {mnuFile, mnuRun})
        mnuMain.Name = "mnuMain"
        '
        ' mnuFile
        '
        resources.ApplyResources(mnuFile, "mnuFile")
        mnuFile.DropDownItems.AddRange(New ToolStripItem() {mnuFileExit})
        mnuFile.Name = "mnuFile"
        '
        ' mnuFileExit
        '
        resources.ApplyResources(mnuFileExit, "mnuFileExit")
        mnuFileExit.Name = "mnuFileExit"
        '
        ' mnuRun
        '
        resources.ApplyResources(mnuRun, "mnuRun")
        mnuRun.DropDownItems.AddRange(New ToolStripItem() {mnuRunCommand})
        mnuRun.Name = "mnuRun"
        '
        ' mnuRunCommand
        '
        resources.ApplyResources(mnuRunCommand, "mnuRunCommand")
        mnuRunCommand.Name = "mnuRunCommand"

        '
        ' dlgOpen
        '
        resources.ApplyResources(dlgOpen, "dlgOpen")
        dlgOpen.FileName = "dlgOpen"

        '
        ' picView
        '
        resources.ApplyResources(picView, "picView")
        picView.Name = "picView"
        picView.TabStop = False

        '
        ' MainView
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(mnuMain)
        Me.Controls.Add(picView)
        Me.MainMenuStrip = mnuMain
        Me.Name = "MainView"

        mnuMain.ResumeLayout(False)
        CType(picView, ComponentModel.ISupportInitialize).EndInit()
        mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuRun As ToolStripMenuItem
    Friend WithEvents mnuRunCommand As ToolStripMenuItem

    Friend WithEvents dlgOpen As OpenFileDialog

    Friend WithEvents picView As PictureBox

End Class
