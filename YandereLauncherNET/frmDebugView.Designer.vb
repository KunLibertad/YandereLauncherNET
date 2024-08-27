<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDebugView
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
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Purple
        TextBox1.Dock = DockStyle.Fill
        TextBox1.ForeColor = Color.White
        TextBox1.Location = New Point(0, 0)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(800, 450)
        TextBox1.TabIndex = 0
        ' 
        ' frmDebugView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox1)
        Name = "frmDebugView"
        Text = "frmDebugView"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
End Class
