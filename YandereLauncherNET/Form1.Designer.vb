<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        pbDownload = New ProgressBar()
        Label1 = New Label()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        SystemToolStripMenuItem = New ToolStripMenuItem()
        DeleteGameDataToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        EditStudentjsonToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        LinkLabel1 = New LinkLabel()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Location = New Point(12, 175)
        Button1.Name = "Button1"
        Button1.Size = New Size(374, 47)
        Button1.TabIndex = 0
        Button1.Text = "Download and Play"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' pbDownload
        ' 
        pbDownload.Location = New Point(12, 30)
        pbDownload.Name = "pbDownload"
        pbDownload.Size = New Size(374, 23)
        pbDownload.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("MS UI Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(9, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 11)
        Label1.TabIndex = 2
        Label1.Text = "Awaiting Instructions..." & vbCrLf
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, SystemToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.RenderMode = ToolStripRenderMode.System
        MenuStrip1.Size = New Size(398, 24)
        MenuStrip1.TabIndex = 3
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(93, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' SystemToolStripMenuItem
        ' 
        SystemToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DeleteGameDataToolStripMenuItem, ToolStripSeparator1, EditStudentjsonToolStripMenuItem})
        SystemToolStripMenuItem.Name = "SystemToolStripMenuItem"
        SystemToolStripMenuItem.Size = New Size(57, 20)
        SystemToolStripMenuItem.Text = "System"
        ' 
        ' DeleteGameDataToolStripMenuItem
        ' 
        DeleteGameDataToolStripMenuItem.Name = "DeleteGameDataToolStripMenuItem"
        DeleteGameDataToolStripMenuItem.Size = New Size(180, 22)
        DeleteGameDataToolStripMenuItem.Text = "Delete game data"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(177, 6)
        ' 
        ' EditStudentjsonToolStripMenuItem
        ' 
        EditStudentjsonToolStripMenuItem.Name = "EditStudentjsonToolStripMenuItem"
        EditStudentjsonToolStripMenuItem.Size = New Size(180, 22)
        EditStudentjsonToolStripMenuItem.Text = "Edit Students.json"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(44, 20)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(107, 22)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Yandere_Simulator_logo
        PictureBox1.Location = New Point(9, 27)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(377, 142)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 234)
        Label2.Name = "Label2"
        Label2.Size = New Size(147, 15)
        Label2.TabIndex = 5
        Label2.Text = "Wanna play a good game?"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(155, 234)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(72, 15)
        LinkLabel1.TabIndex = 6
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Play Balatro!"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        ClientSize = New Size(398, 258)
        Controls.Add(LinkLabel1)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(pbDownload)
        Controls.Add(Button1)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kun's Yandere Simulator Launcher"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents pbDownload As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SystemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteGameDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents EditStudentjsonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel

End Class
