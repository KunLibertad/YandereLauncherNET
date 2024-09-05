Imports System.Net
Imports SevenZip
Imports System.IO
Imports System.ComponentModel
Imports System.Security.Principal
Public Class Form1
    Public WithEvents downloader As WebClient
    Public WithEvents extractor As SevenZipExtractor
    Public CurrentExecDir As String = AppDomain.CurrentDomain.BaseDirectory
    Dim ActivityLedFunc As Boolean = False
    Private sw As Stopwatch
    Dim EnableDebug As Boolean = False
    Dim DebugWindow As New frmDebugView
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.MenuStrip1.Renderer = New MyRender()

    End Sub
    Function IsUserAdministrator() As Boolean
        'Esta funcion nos indica si el programa se esta ejecutando como administrador o como un usuario normal. 
        Try
            Dim identity As WindowsIdentity = WindowsIdentity.GetCurrent()
            Dim principal As New WindowsPrincipal(identity)
            Return principal.IsInRole(WindowsBuiltInRole.Administrator)
        Catch ex As UnauthorizedAccessException
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Esto es de rutina. si encontramos el archivo ys.zip lo podemos eliminar.
        'Eso si se quiere tener una subversion hay que dar la opcion para el usuario
        If File.Exists($"{CurrentExecDir}\YS.zip") Then File.Delete($"{CurrentExecDir}\YS.zip")
        'Obtenemos la version mas reciente de yandere simulator checando si hay una version nueva del launcher
        CheckVersionFunc()
        'Checar si el usuario esta ejecutando el launcher como un Administrador
        If IsUserAdministrator() = True Then
            MsgBox("You are currently running this launcher as admin. this is not the suggested use of the launcher", MsgBoxStyle.Exclamation, "Kun's Yandere Simulator Launcher")
            Me.Text = "Kun's Yandere Simulator Launcher - <!!!>"
        End If
        'Checar si el juego esta en el directorio primario
        If My.Settings.InitialSetup = True Then
            Select Case MsgBox("This is the first time that you have open the launcher. do you want to download Yandere Simulator?", MsgBoxStyle.YesNoCancel, "Kun's Yandere Simulator Launcher")
                Case MsgBoxResult.Yes
                    DownloadFunction()
                Case MsgBoxResult.No
                    CheckExec()
            End Select
            My.Settings.InitialSetup = False
            My.Settings.Save()
        Else
            'Checamos si el ejecutable esta disponible para ejecutar
            CheckExec()
        End If
    End Sub

    Private Sub CheckExec()
        'checar si se encuentra el ejecutable del juego en el directorio raiz del programa
        If File.Exists($"{CurrentExecDir}\YandereSimulator.exe") Then
            If Button1.Enabled = False Then Button1.Enabled = True
            Button1.Text = "Play"
        Else
            Button1.Text = "Download"
        End If
    End Sub

    Private Sub CheckVersionFunc()
        Dim DownloadVerString As String
        Dim WebClientDS As New WebClient
        Try
            DownloadVerString = WebClientDS.DownloadString(New Uri("https://www.yanderesimulator.com/version.txt"))
        Catch ex As Exception
            Label1.Text = "Unable to find update"
            Exit Sub
        End Try

        ' Checar si la versión preliminar está vacía
        If String.IsNullOrEmpty(My.Settings.CurrentYandereVersion) Then
            My.Settings.CurrentYandereVersion = DownloadVerString
            My.Settings.Save()
        ElseIf Not DownloadVerString.Equals(My.Settings.CurrentYandereVersion) Then
            UpdateAvailableToolStripMenuItem.Enabled = True
            My.Settings.CurrentYandereVersion = DownloadVerString
            My.Settings.Save()
            UpdateAvailableToolStripMenuItem.Text = "New update available!"
            UpdateAvailableToolStripMenuItem.Enabled = False
            Button1.Text = "Update! (Hold shift and click this button to run the current version)"
        Else
            UpdateAvailableToolStripMenuItem.Text = "Your software is up to date."
            UpdateAvailableToolStripMenuItem.Enabled = False
        End If
    End Sub

    Sub DownloadFunction()
        sw = New Stopwatch
        Button1.Enabled = False
        Button1.Text = "Please Wait..."
        Label1.Text = "0000"
        downloader = New WebClient
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        sw.Start()
        downloader.DownloadFileAsync(New Uri("https://yanderesimulator.com/dl/latest.zip"), $"{CurrentExecDir}\YS.zip")
    End Sub

    Private Sub downloader_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles downloader.DownloadProgressChanged
        Dim bytesReceived As Long = e.BytesReceived
        Dim totalBytes As Long = e.TotalBytesToReceive
        Dim percentage As Integer = e.ProgressPercentage

        Dim elapsedTime As TimeSpan = sw.Elapsed
        Dim downloadRateKBps As Double = (bytesReceived / 1024) / elapsedTime.TotalSeconds ' kilobytes per second
        Dim remainingBytes As Long = totalBytes - bytesReceived
        Dim estimatedTimeRemaining As Double = remainingBytes / (downloadRateKBps * 1024) ' seconds

        Dim estimatedTimeRemainingMinutes As Integer = Math.Floor(estimatedTimeRemaining / 60)
        Dim estimatedTimeRemainingSeconds As Integer = Math.Floor(estimatedTimeRemaining Mod 60)
        pbDownload.Value = e.ProgressPercentage
        Label1.Text = $"{percentage}% Downloaded | {bytesReceived} bytes of {totalBytes} | {Format(downloadRateKBps, "0")} KBPS{vbCrLf}{estimatedTimeRemainingMinutes}:{Format(estimatedTimeRemainingSeconds, "00")} minutes to complete"
    End Sub

    Private Sub downloader_DownloadFileCompleted(sender As Object, e As AsyncCompletedEventArgs) Handles downloader.DownloadFileCompleted
        sw.Stop()
        ExtractYandereSimulator()
    End Sub
    Private Sub ExtractYandereSimulator()
        Select Case Environment.Is64BitProcess
            Case True
                SevenZip.SevenZipExtractor.SetLibraryPath($"{CurrentExecDir}\x64\7z.dll")
            Case False
                SevenZip.SevenZipExtractor.SetLibraryPath($"{CurrentExecDir}\x86\7z.dll")
        End Select
        extractor = New SevenZip.SevenZipExtractor($"{CurrentExecDir}\YS.zip")
        extractor.ExtractArchive(CurrentExecDir)
    End Sub

    Private Sub extractor_FileExtractionStarted(sender As Object, e As FileInfoEventArgs) Handles extractor.FileExtractionStarted
        Invoke(Sub()
                   Label1.Text = "Extracting files..."
               End Sub)
    End Sub

    Private Sub extractor_FileExtractionFinished(sender As Object, e As FileInfoEventArgs) Handles extractor.FileExtractionFinished
        Invoke(Sub()
                   Label1.Text = "Finished Extraction!"
                   Button1.Text = "Play"
                   Button1.Enabled = True
               End Sub)
    End Sub

    Private Sub extractor_Extracting(sender As Object, e As ProgressEventArgs) Handles extractor.Extracting
        Invoke(Sub()
                   Label1.Text = e.PercentDelta.ToString
               End Sub)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case Button1.Text
            Case "Download"
                DownloadFunction()
                PictureBox1.Visible = False
            Case "Play"
                If My.Computer.Keyboard.ShiftKeyDown = True Then EnableDebug = True Else EnableDebug = False
                PlayGame(EnableDebug)
            Case "Update! (Hold shift and click this button to run the current version)"
                If My.Computer.Keyboard.AltKeyDown = True Then PlayGame(False) Else DownloadFunction()
        End Select
    End Sub

    Private Sub PlayGame(UseDebug As Boolean)
        Dim P As New Process
        P.StartInfo.FileName = $"{CurrentExecDir}\YandereSimulator.exe"
        P.StartInfo.UseShellExecute = False
        P.StartInfo.RedirectStandardError = True
        P.StartInfo.RedirectStandardInput = False
        P.StartInfo.RedirectStandardOutput = True
        AddHandler P.ErrorDataReceived, AddressOf P_ErrorDataReceived
        AddHandler P.OutputDataReceived, AddressOf P_OutputDataReceived
        Select Case UseDebug
            Case True
                DebugWindow.Show()
                P.Start()
                P.WaitForExit()
                DebugWindow.AddTextToTheLog(P.ExitCode)
            Case False
                P.Start()
                P.WaitForExitAsync()
        End Select
    End Sub

    Private Sub P_OutputDataReceived(sender As Object, e As DataReceivedEventArgs)
        Invoke(Sub()
                   DebugWindow.AddTextToTheLog(e.Data)
               End Sub)
    End Sub

    Private Sub P_ErrorDataReceived(sender As Object, e As DataReceivedEventArgs)
        Invoke(Sub()
                   DebugWindow.AddTextToTheLog(e.Data)
               End Sub)
    End Sub

    Private Sub EditStudentjsonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditStudentjsonToolStripMenuItem.Click
        StudentEditor.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start(New ProcessStartInfo With {
    .FileName = "steam://rungameid/2379780",
    .UseShellExecute = True
})
    End Sub

    Private Sub DeleteGameDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteGameDataToolStripMenuItem.Click
        DeleteGameData()
    End Sub

    Private Sub DeleteGameData()
        Select Case MsgBox("Are you sure to delete all the Yandere Simulator contents?", MsgBoxStyle.YesNo, "Kun's Yandere Simulator Launcher")
            Case MsgBoxResult.Yes
                Try
                    File.Delete($"{CurrentExecDir}\YandereSimulator.exe")
                    File.Delete($"{CurrentExecDir}\UnityPlayer.dll")
                    File.Delete($"{CurrentExecDir}\UnityCrashHandler64.exe")
                    File.Delete($"{CurrentExecDir}\README.txt")
                    Directory.Delete($"{CurrentExecDir}\MonoBleedingEdge", True)
                    Directory.Delete($"{CurrentExecDir}\YandereSimulator_Data", True)
                    MsgBox("Deletion complete!", MsgBoxStyle.Exclamation, "Kun's Yandere Simulator Launcher")
                    Button1.Text = "Download"
                Catch ex As Exception
                    MsgBox("No Game Files found", MsgBoxStyle.Critical, "Kun's Yandere Simulator Launcher")
                End Try
            Case MsgBoxResult.No
                Exit Sub
        End Select
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        dlgAbout.ShowDialog()
    End Sub
End Class
