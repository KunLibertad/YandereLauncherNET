Public NotInheritable Class dlgAbout

    Private Sub dlgAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OKButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start(New ProcessStartInfo With {
    .FileName = "https://www.yanderesimulator.com",
    .UseShellExecute = True
})
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start(New ProcessStartInfo With {
    .FileName = "https://github.com/KunLibertad/YandereLauncherNET",
    .UseShellExecute = True
})
    End Sub
End Class
