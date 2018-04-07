<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VoteOKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VoteNOKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VoteTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemMusicBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnParcourir = New System.Windows.Forms.Button()
        Me.txt2 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemMusicBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(660, 10)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 23)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "ReadFile"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(12, 12)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(642, 20)
        Me.txt1.TabIndex = 1
        Me.txt1.Text = "D:\_Projet\LocalJukeBox\LocalJukeBox_Server\LocalJukeBox_Server\musicList.xml"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.FileNameDataGridViewTextBoxColumn, Me.VoteOKDataGridViewTextBoxColumn, Me.VoteNOKDataGridViewTextBoxColumn, Me.VoteTotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ItemMusicBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 67)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(722, 379)
        Me.DataGridView1.TabIndex = 2
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(800, 50)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(75, 23)
        Me.btn2.TabIndex = 3
        Me.btn2.Text = "Play/Pause"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(800, 111)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(75, 23)
        Me.btn3.TabIndex = 4
        Me.btn3.Text = "Next"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FileNameDataGridViewTextBoxColumn
        '
        Me.FileNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FileNameDataGridViewTextBoxColumn.DataPropertyName = "fileName"
        Me.FileNameDataGridViewTextBoxColumn.HeaderText = "fileName"
        Me.FileNameDataGridViewTextBoxColumn.Name = "FileNameDataGridViewTextBoxColumn"
        Me.FileNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VoteOKDataGridViewTextBoxColumn
        '
        Me.VoteOKDataGridViewTextBoxColumn.DataPropertyName = "voteOK"
        Me.VoteOKDataGridViewTextBoxColumn.HeaderText = "voteOK"
        Me.VoteOKDataGridViewTextBoxColumn.Name = "VoteOKDataGridViewTextBoxColumn"
        Me.VoteOKDataGridViewTextBoxColumn.ReadOnly = True
        Me.VoteOKDataGridViewTextBoxColumn.Visible = False
        '
        'VoteNOKDataGridViewTextBoxColumn
        '
        Me.VoteNOKDataGridViewTextBoxColumn.DataPropertyName = "voteNOK"
        Me.VoteNOKDataGridViewTextBoxColumn.HeaderText = "voteNOK"
        Me.VoteNOKDataGridViewTextBoxColumn.Name = "VoteNOKDataGridViewTextBoxColumn"
        Me.VoteNOKDataGridViewTextBoxColumn.ReadOnly = True
        Me.VoteNOKDataGridViewTextBoxColumn.Visible = False
        '
        'VoteTotalDataGridViewTextBoxColumn
        '
        Me.VoteTotalDataGridViewTextBoxColumn.DataPropertyName = "voteTotal"
        Me.VoteTotalDataGridViewTextBoxColumn.HeaderText = "voteTotal"
        Me.VoteTotalDataGridViewTextBoxColumn.Name = "VoteTotalDataGridViewTextBoxColumn"
        Me.VoteTotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemMusicBindingSource
        '
        Me.ItemMusicBindingSource.DataSource = GetType(LocalJukeBox_Server.itemMusic)
        '
        'btnParcourir
        '
        Me.btnParcourir.Location = New System.Drawing.Point(660, 39)
        Me.btnParcourir.Name = "btnParcourir"
        Me.btnParcourir.Size = New System.Drawing.Size(75, 23)
        Me.btnParcourir.TabIndex = 5
        Me.btnParcourir.Text = "Parcourir"
        Me.btnParcourir.UseVisualStyleBackColor = True
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(12, 41)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(642, 20)
        Me.txt2.TabIndex = 6
        Me.txt2.Text = "C:\Users\Godefroy\Downloads"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 458)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.btnParcourir)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.btn1)
        Me.Name = "frmMain"
        Me.Text = "LocalJukeBox"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemMusicBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents txt1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ItemMusicBindingSource As BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FileNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VoteOKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VoteNOKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VoteTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btnParcourir As Button
    Friend WithEvents txt2 As TextBox
End Class
