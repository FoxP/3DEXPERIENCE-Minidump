<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.ProgressBarMain = New System.Windows.Forms.ProgressBar()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.lbDescription_2 = New System.Windows.Forms.Label()
        Me.lbDescription_1 = New System.Windows.Forms.Label()
        Me.PanelMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbStatus
        '
        Me.lbStatus.AutoSize = True
        Me.lbStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStatus.Location = New System.Drawing.Point(10, 10)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(133, 15)
        Me.lbStatus.TabIndex = 0
        Me.lbStatus.Text = "Generating minidump..."
        '
        'ProgressBarMain
        '
        Me.ProgressBarMain.Location = New System.Drawing.Point(13, 36)
        Me.ProgressBarMain.Name = "ProgressBarMain"
        Me.ProgressBarMain.Size = New System.Drawing.Size(368, 15)
        Me.ProgressBarMain.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBarMain.TabIndex = 1
        Me.ProgressBarMain.Value = 70
        '
        'PanelMain
        '
        Me.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelMain.Controls.Add(Me.lbDescription_2)
        Me.PanelMain.Controls.Add(Me.lbDescription_1)
        Me.PanelMain.Location = New System.Drawing.Point(13, 64)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(368, 70)
        Me.PanelMain.TabIndex = 2
        '
        'lbDescription_2
        '
        Me.lbDescription_2.AutoSize = True
        Me.lbDescription_2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDescription_2.Location = New System.Drawing.Point(2, 46)
        Me.lbDescription_2.Name = "lbDescription_2"
        Me.lbDescription_2.Size = New System.Drawing.Size(278, 15)
        Me.lbDescription_2.TabIndex = 1
        Me.lbDescription_2.Text = "Please just wait, this operation may take a moment."
        '
        'lbDescription_1
        '
        Me.lbDescription_1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDescription_1.Location = New System.Drawing.Point(2, 3)
        Me.lbDescription_1.Name = "lbDescription_1"
        Me.lbDescription_1.Size = New System.Drawing.Size(359, 35)
        Me.lbDescription_1.TabIndex = 0
        Me.lbDescription_1.Text = "The Incident Report Manager is trying to get unexpected behavior context of the g" &
    "uarded application."
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 146)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.ProgressBarMain)
        Me.Controls.Add(Me.lbStatus)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "3DEXPERIENCE - Incident Report Manager Message"
        Me.TopMost = True
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbStatus As Label
    Friend WithEvents ProgressBarMain As ProgressBar
    Friend WithEvents PanelMain As Panel
    Friend WithEvents lbDescription_1 As Label
    Friend WithEvents lbDescription_2 As Label
End Class
