<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(660, 10)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 23)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "Button1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(12, 12)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(642, 20)
        Me.txt1.TabIndex = 1
        Me.txt1.Text = "D:\_Projet\LocalJukeBox\LocalJukeBox_Server\Music\Xan Griffin - Capricorn.mp3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 458)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.btn1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents txt1 As TextBox
End Class
