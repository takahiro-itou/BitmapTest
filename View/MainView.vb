Public Class MainView

Private Sub RunCommand()
''--------------------------------------------------------------------
''    指定したコマンドを実行する。
''--------------------------------------------------------------------
Dim imgCanvas As System.Drawing.Bitmap
Dim grpCanvas As System.Drawing.Graphics

    imgCanvas = New System.Drawing.Bitmap(300, 300)
    grpCanvas = System.Drawing.Graphics.FromImage(imgCanvas)

    grpCanvas.FillRectangle(Brushes.Black, grpCanvas.VisibleClipBounds)
    grpCanvas.DrawRectangle(Pens.Yellow, 50, 30, 100, 60)
    grpCanvas.DrawPie(Pens.Red, 60, 10, 80, 80, 30, 300)
    grpCanvas.Dispose()

    picView.Image = imgCanvas
End Sub


Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles _
            mnuFileExit.Click
''--------------------------------------------------------------------
''    メニュー「ファイル」－「終了」
''--------------------------------------------------------------------

    Application.Exit()
End Sub


Private Sub mnuRunCommand_Click(sender As Object, e As EventArgs) Handles _
            mnuRunCommand.Click
''--------------------------------------------------------------------
''    メニュー「実行」－「コマンドを実行」
''--------------------------------------------------------------------

    RunCommand()
End Sub

End Class
