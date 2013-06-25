<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class comandcentre
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(comandcentre))
        Me.taskman = New System.Windows.Forms.Button()
        Me.ctrlpanel = New System.Windows.Forms.Button()
        Me.shutdown = New System.Windows.Forms.Button()
        Me.exitwindow = New System.Windows.Forms.Button()
        Me.restart = New System.Windows.Forms.Button()
        Me.abort = New System.Windows.Forms.Button()
        Me.about = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'taskman
        '
        Me.taskman.Location = New System.Drawing.Point(6, 39)
        Me.taskman.Name = "taskman"
        Me.taskman.Size = New System.Drawing.Size(176, 27)
        Me.taskman.TabIndex = 0
        Me.taskman.Text = "Task Manager"
        Me.taskman.UseVisualStyleBackColor = True
        '
        'ctrlpanel
        '
        Me.ctrlpanel.Location = New System.Drawing.Point(6, 6)
        Me.ctrlpanel.Name = "ctrlpanel"
        Me.ctrlpanel.Size = New System.Drawing.Size(176, 27)
        Me.ctrlpanel.TabIndex = 1
        Me.ctrlpanel.Text = "Control Panel"
        Me.ctrlpanel.UseVisualStyleBackColor = True
        '
        'shutdown
        '
        Me.shutdown.Location = New System.Drawing.Point(6, 6)
        Me.shutdown.Name = "shutdown"
        Me.shutdown.Size = New System.Drawing.Size(176, 27)
        Me.shutdown.TabIndex = 2
        Me.shutdown.Text = "Shutdown"
        Me.shutdown.UseVisualStyleBackColor = True
        '
        'exitwindow
        '
        Me.exitwindow.Location = New System.Drawing.Point(6, 6)
        Me.exitwindow.Name = "exitwindow"
        Me.exitwindow.Size = New System.Drawing.Size(176, 27)
        Me.exitwindow.TabIndex = 3
        Me.exitwindow.Text = "Exit"
        Me.exitwindow.UseVisualStyleBackColor = True
        '
        'restart
        '
        Me.restart.Location = New System.Drawing.Point(6, 39)
        Me.restart.Name = "restart"
        Me.restart.Size = New System.Drawing.Size(176, 27)
        Me.restart.TabIndex = 4
        Me.restart.Text = "Restart"
        Me.restart.UseVisualStyleBackColor = True
        '
        'abort
        '
        Me.abort.Location = New System.Drawing.Point(6, 72)
        Me.abort.Name = "abort"
        Me.abort.Size = New System.Drawing.Size(176, 27)
        Me.abort.TabIndex = 5
        Me.abort.Text = "Abort Shutdown"
        Me.abort.UseVisualStyleBackColor = True
        '
        'about
        '
        Me.about.Location = New System.Drawing.Point(6, 39)
        Me.about.Name = "about"
        Me.about.Size = New System.Drawing.Size(176, 27)
        Me.about.TabIndex = 6
        Me.about.Text = "About"
        Me.about.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(196, 134)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.shutdown)
        Me.TabPage1.Controls.Add(Me.restart)
        Me.TabPage1.Controls.Add(Me.abort)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(188, 108)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Power"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ctrlpanel)
        Me.TabPage2.Controls.Add(Me.taskman)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(188, 202)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Advanced"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.exitwindow)
        Me.TabPage3.Controls.Add(Me.about)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(188, 108)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "About"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'comandcentre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(215, 154)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "comandcentre"
        Me.Opacity = 0.75R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Command Centre"
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents taskman As System.Windows.Forms.Button
    Friend WithEvents ctrlpanel As System.Windows.Forms.Button
    Friend WithEvents shutdown As System.Windows.Forms.Button
    Friend WithEvents exitwindow As System.Windows.Forms.Button
    Friend WithEvents restart As System.Windows.Forms.Button
    Friend WithEvents abort As System.Windows.Forms.Button
    Friend WithEvents about As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage

End Class
