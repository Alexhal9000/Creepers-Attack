<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.scoresboard = New System.Windows.Forms.Button()
        Me.menusong = New AxWMPLib.AxWindowsMediaPlayer()
        Me.introvideo = New AxWMPLib.AxWindowsMediaPlayer()
        Me.endvideo = New System.Windows.Forms.Timer(Me.components)
        Me.skipbutton = New System.Windows.Forms.Button()
        CType(Me.menusong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.introvideo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.CadetBlue
        Me.Button1.Location = New System.Drawing.Point(146, 244)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(230, 54)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "PLAY"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'scoresboard
        '
        Me.scoresboard.BackColor = System.Drawing.Color.Transparent
        Me.scoresboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.scoresboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.scoresboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.scoresboard.Font = New System.Drawing.Font("Microsoft JhengHei UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoresboard.ForeColor = System.Drawing.Color.LightGray
        Me.scoresboard.Location = New System.Drawing.Point(146, 326)
        Me.scoresboard.Name = "scoresboard"
        Me.scoresboard.Size = New System.Drawing.Size(230, 54)
        Me.scoresboard.TabIndex = 1
        Me.scoresboard.Text = "leaderboard"
        Me.scoresboard.UseVisualStyleBackColor = False
        '
        'menusong
        '
        Me.menusong.Enabled = True
        Me.menusong.Location = New System.Drawing.Point(-2, 545)
        Me.menusong.Name = "menusong"
        Me.menusong.OcxState = CType(resources.GetObject("menusong.OcxState"), System.Windows.Forms.AxHost.State)
        Me.menusong.Size = New System.Drawing.Size(230, 78)
        Me.menusong.TabIndex = 2
        Me.menusong.Visible = False
        '
        'introvideo
        '
        Me.introvideo.Enabled = True
        Me.introvideo.Location = New System.Drawing.Point(-2, 0)
        Me.introvideo.Name = "introvideo"
        Me.introvideo.OcxState = CType(resources.GetObject("introvideo.OcxState"), System.Windows.Forms.AxHost.State)
        Me.introvideo.Size = New System.Drawing.Size(835, 602)
        Me.introvideo.TabIndex = 3
        '
        'endvideo
        '
        Me.endvideo.Enabled = True
        '
        'skipbutton
        '
        Me.skipbutton.BackColor = System.Drawing.Color.Transparent
        Me.skipbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.skipbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.skipbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.skipbutton.Location = New System.Drawing.Point(661, 541)
        Me.skipbutton.Name = "skipbutton"
        Me.skipbutton.Size = New System.Drawing.Size(157, 36)
        Me.skipbutton.TabIndex = 4
        Me.skipbutton.Text = "SKIP"
        Me.skipbutton.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.fondo
        Me.ClientSize = New System.Drawing.Size(833, 600)
        Me.Controls.Add(Me.skipbutton)
        Me.Controls.Add(Me.introvideo)
        Me.Controls.Add(Me.menusong)
        Me.Controls.Add(Me.scoresboard)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.menusong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.introvideo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents scoresboard As System.Windows.Forms.Button
    Friend WithEvents menusong As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents introvideo As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents endvideo As System.Windows.Forms.Timer
    Friend WithEvents skipbutton As System.Windows.Forms.Button
End Class
