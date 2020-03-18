Public Class Form1

    Private Sub DiscROMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscROMToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub ISOFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ISOFileToolStripMenuItem.Click
        OpenFileDialog2.ShowDialog()
    End Sub

    Private Sub SoundToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SoundToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub StartGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartGameToolStripMenuItem.Click
        Form7.Show()
    End Sub

    Private Sub GraphicToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GraphicToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub ControllerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControllerToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub BiosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BiosToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Form6.Show()
    End Sub
End Class