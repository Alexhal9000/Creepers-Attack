<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.gamesong = New AxWMPLib.AxWindowsMediaPlayer()
        Me.bosstimer = New System.Windows.Forms.Timer(Me.components)
        Me.boss1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.laser = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ship = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gamemainsong = New AxWMPLib.AxWindowsMediaPlayer()
        Me.bosshp = New System.Windows.Forms.Label()
        CType(Me.gamesong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.boss1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.laser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ship, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gamemainsong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Lavender
        Me.Button1.Location = New System.Drawing.Point(245, 276)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 35)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "START"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 1
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'Timer4
        '
        Me.Timer4.Interval = 50
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Lavender
        Me.Button2.Location = New System.Drawing.Point(411, 276)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 35)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "MENU"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'gamesong
        '
        Me.gamesong.Enabled = True
        Me.gamesong.Location = New System.Drawing.Point(27, 368)
        Me.gamesong.Name = "gamesong"
        Me.gamesong.OcxState = CType(resources.GetObject("gamesong.OcxState"), System.Windows.Forms.AxHost.State)
        Me.gamesong.Size = New System.Drawing.Size(125, 50)
        Me.gamesong.TabIndex = 13
        Me.gamesong.Visible = False
        '
        'bosstimer
        '
        Me.bosstimer.Interval = 1
        '
        'boss1
        '
        Me.boss1.Image = Global.WindowsApplication1.My.Resources.Resources.good_creeper_king_final
        Me.boss1.Location = New System.Drawing.Point(321, 21)
        Me.boss1.Name = "boss1"
        Me.boss1.Size = New System.Drawing.Size(156, 148)
        Me.boss1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.boss1.TabIndex = 14
        Me.boss1.TabStop = False
        Me.boss1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.keys1
        Me.PictureBox2.Location = New System.Drawing.Point(207, 360)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(404, 204)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'laser
        '
        Me.laser.BackColor = System.Drawing.Color.Transparent
        Me.laser.Image = Global.WindowsApplication1.My.Resources.Resources.laser
        Me.laser.Location = New System.Drawing.Point(354, 99)
        Me.laser.Name = "laser"
        Me.laser.Size = New System.Drawing.Size(19, 354)
        Me.laser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.laser.TabIndex = 10
        Me.laser.TabStop = False
        Me.laser.Visible = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.WindowsApplication1.My.Resources.Resources.creeper
        Me.PictureBox9.Location = New System.Drawing.Point(704, 21)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(77, 72)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 8
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.Visible = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.WindowsApplication1.My.Resources.Resources.creeper
        Me.PictureBox8.Location = New System.Drawing.Point(608, 21)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(77, 72)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 7
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Visible = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.WindowsApplication1.My.Resources.Resources.creeper
        Me.PictureBox7.Location = New System.Drawing.Point(514, 21)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(77, 72)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 6
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Visible = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.WindowsApplication1.My.Resources.Resources.creeper
        Me.PictureBox6.Location = New System.Drawing.Point(417, 21)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(77, 72)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 5
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.WindowsApplication1.My.Resources.Resources.creeper
        Me.PictureBox5.Location = New System.Drawing.Point(321, 21)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(77, 72)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.WindowsApplication1.My.Resources.Resources.creeper
        Me.PictureBox4.Location = New System.Drawing.Point(224, 21)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(77, 72)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WindowsApplication1.My.Resources.Resources.creeper
        Me.PictureBox3.Location = New System.Drawing.Point(125, 21)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(77, 72)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'ship
        '
        Me.ship.BackColor = System.Drawing.Color.Transparent
        Me.ship.Image = Global.WindowsApplication1.My.Resources.Resources.ship
        Me.ship.Location = New System.Drawing.Point(321, 454)
        Me.ship.Name = "ship"
        Me.ship.Size = New System.Drawing.Size(85, 84)
        Me.ship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ship.TabIndex = 1
        Me.ship.TabStop = False
        Me.ship.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.creeper
        Me.PictureBox1.Location = New System.Drawing.Point(26, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'gamemainsong
        '
        Me.gamemainsong.Enabled = True
        Me.gamemainsong.Location = New System.Drawing.Point(27, 276)
        Me.gamemainsong.Name = "gamemainsong"
        Me.gamemainsong.OcxState = CType(resources.GetObject("gamemainsong.OcxState"), System.Windows.Forms.AxHost.State)
        Me.gamemainsong.Size = New System.Drawing.Size(125, 47)
        Me.gamemainsong.TabIndex = 15
        Me.gamemainsong.Visible = False
        '
        'bosshp
        '
        Me.bosshp.AutoSize = True
        Me.bosshp.BackColor = System.Drawing.Color.Transparent
        Me.bosshp.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bosshp.ForeColor = System.Drawing.Color.LightGreen
        Me.bosshp.Location = New System.Drawing.Point(698, 33)
        Me.bosshp.Name = "bosshp"
        Me.bosshp.Size = New System.Drawing.Size(0, 39)
        Me.bosshp.TabIndex = 16
        Me.bosshp.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.fondogame1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(817, 563)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bosshp)
        Me.Controls.Add(Me.gamemainsong)
        Me.Controls.Add(Me.boss1)
        Me.Controls.Add(Me.gamesong)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.laser)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.ship)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.gamesong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.boss1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.laser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ship, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gamemainsong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ship As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents laser As System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents gamesong As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents boss1 As System.Windows.Forms.PictureBox
    Friend WithEvents bosstimer As System.Windows.Forms.Timer
    Friend WithEvents gamemainsong As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents bosshp As System.Windows.Forms.Label

End Class
