Public Class MainView

Private Sub RunCommand()
''--------------------------------------------------------------------
''    指定したコマンドを実行する。
''--------------------------------------------------------------------
Dim imgCanvas As System.Drawing.Bitmap
Dim grpCanvas As System.Drawing.Graphics
Dim imgBuffer As System.Drawing.Bitmap
Dim grpBuffer As System.Drawing.Graphics
Dim hDisplayDC As IntPtr
Dim hDC As IntPtr
Dim brushBG As SolidBrush
Dim colorBG As Color

    hDisplayDC = GetDC(IntPtr.Zero)

    imgBuffer = New System.Drawing.Bitmap(200, 100)
    grpBuffer = System.Drawing.Graphics.FromImage(imgBuffer)

    colorBG = Color.FromArgb(&HBAF0FE)
    brushBG = New SolidBrush(colorBG)
    grpBuffer.FillRectangle(brushBG, grpBuffer.VisibleClipBounds)

    hDC = grpBuffer.GetHdc()
    BitBlt(hDC, 8, 8, 184, 84, hDisplayDC,
            Screen.PrimaryScreen.Bounds.Width - 184,
            Screen.PrimaryScreen.Bounds.Height - 84,
            SRCCOPY)
    grpBuffer.ReleaseHdc(hDC)

    grpBuffer.DrawRectangle(Pens.Yellow, 50, 30, 100, 60)
    grpBuffer.DrawPie(Pens.Red, 60, 10, 80, 80, 30, 300)
    grpBuffer.Dispose()

    imgCanvas = New System.Drawing.Bitmap(300, 300)
    grpCanvas = System.Drawing.Graphics.FromImage(imgCanvas)

    colorBG = Color.FromArgb(&HC0C0C0)
    brushBG = New SolidBrush(colorBG)
    grpCanvas.FillRectangle(brushBG, grpCanvas.VisibleClipBounds)

    hDC = grpCanvas.GetHdc()
    BitBlt(hDC, 8, 8, 284, 284, hDisplayDC, 0, 0, SRCCOPY)
    grpCanvas.ReleaseHdc(hDC)

    ReleaseDC(IntPtr.Zero, hDisplayDC)

    grpCanvas.DrawImage(imgBuffer, 50, 100, 200, 100)
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
