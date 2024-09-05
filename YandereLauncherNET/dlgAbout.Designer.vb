<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgAbout
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgAbout))
        OKButton = New Button()
        Label1 = New Label()
        TextBox1 = New TextBox()
        LinkLabel1 = New LinkLabel()
        LinkLabel2 = New LinkLabel()
        SuspendLayout()
        ' 
        ' OKButton
        ' 
        OKButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        OKButton.DialogResult = DialogResult.Cancel
        OKButton.FlatStyle = FlatStyle.Flat
        OKButton.Location = New Point(381, 278)
        OKButton.Margin = New Padding(4, 3, 4, 3)
        OKButton.Name = "OKButton"
        OKButton.Size = New Size(88, 27)
        OKButton.TabIndex = 1
        OKButton.Text = "&Aceptar"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(206, 135)
        Label1.TabIndex = 2
        Label1.Text = "Yandere Simulator Launcher" & vbCrLf & "Written in VB.NET" & vbCrLf & "By Marco Antonio AKA ""KunLibertad""" & vbCrLf & "--2024--" & vbCrLf & vbCrLf & "Using 7z for extractor" & vbCrLf & vbCrLf & "Game by YandereDev" & vbCrLf & vbCrLf
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        TextBox1.Location = New Point(13, 148)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.ScrollBars = ScrollBars.Vertical
        TextBox1.Size = New Size(456, 124)
        TextBox1.TabIndex = 3
        TextBox1.Text = resources.GetString("TextBox1.Text")
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(314, 114)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(156, 15)
        LinkLabel1.TabIndex = 4
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "www.yanderesimulator.com"
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.Location = New Point(13, 290)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(85, 15)
        LinkLabel2.TabIndex = 5
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "GitHub Project"
        ' 
        ' dlgAbout
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        ClientSize = New Size(483, 318)
        Controls.Add(LinkLabel2)
        Controls.Add(LinkLabel1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(OKButton)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "dlgAbout"
        Padding = New Padding(10)
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "About Kun's Yandere Simulator Launcher"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents OKButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel

End Class
