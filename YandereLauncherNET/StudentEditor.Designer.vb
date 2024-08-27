<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentEditor
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
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ListView1 = New ListView()
        chStudentName = New ColumnHeader()
        GroupBox1 = New GroupBox()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1048, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' ListView1
        ' 
        ListView1.BackColor = Color.FromArgb(CByte(255), CByte(172), CByte(255))
        ListView1.Columns.AddRange(New ColumnHeader() {chStudentName})
        ListView1.ForeColor = Color.Black
        ListView1.Location = New Point(0, 27)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(204, 562)
        ListView1.TabIndex = 1
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' chStudentName
        ' 
        chStudentName.Text = "Student Name"
        chStudentName.Width = 200
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Location = New Point(210, 27)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(838, 562)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Student Info"
        ' 
        ' StudentEditor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        ClientSize = New Size(1048, 592)
        Controls.Add(GroupBox1)
        Controls.Add(ListView1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "StudentEditor"
        Text = "StudentEditor"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListView1 As ListView
    Friend WithEvents chStudentName As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
End Class
