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
        Me.boneco = New System.Windows.Forms.PictureBox()
        Me.boneca = New System.Windows.Forms.PictureBox()
        Me.Movimento = New System.Windows.Forms.Timer(Me.components)
        Me.inimigo2 = New System.Windows.Forms.PictureBox()
        Me.inimigo0 = New System.Windows.Forms.PictureBox()
        Me.inimigo1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Boss = New System.Windows.Forms.PictureBox()
        Me.lbBoss = New System.Windows.Forms.Label()
        Me.bHp = New System.Windows.Forms.Label()
        Me.bkcBHp = New System.Windows.Forms.Label()
        Me.espinho0 = New System.Windows.Forms.Label()
        Me.espinho3 = New System.Windows.Forms.Label()
        Me.espinho2 = New System.Windows.Forms.Label()
        Me.espinho1 = New System.Windows.Forms.Label()
        Me.espinho5 = New System.Windows.Forms.Label()
        Me.espinho4 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.picos = New System.Windows.Forms.Timer(Me.components)
        Me.calhau = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Onda = New System.Windows.Forms.Timer(Me.components)
        Me.stab = New System.Windows.Forms.Label()
        Me.slash = New System.Windows.Forms.Label()
        Me.wavee = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.boneco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.boneca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inimigo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inimigo0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inimigo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Boss, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.calhau, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wavee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'boneco
        '
        Me.boneco.BackColor = System.Drawing.Color.Transparent
        Me.boneco.Image = Global.WindowsApplication1.My.Resources.Resources.idle___Cópia
        Me.boneco.Location = New System.Drawing.Point(28, 383)
        Me.boneco.Name = "boneco"
        Me.boneco.Size = New System.Drawing.Size(115, 138)
        Me.boneco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.boneco.TabIndex = 0
        Me.boneco.TabStop = False
        '
        'boneca
        '
        Me.boneca.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.boneca.Location = New System.Drawing.Point(170, 364)
        Me.boneca.Name = "boneca"
        Me.boneca.Size = New System.Drawing.Size(73, 120)
        Me.boneca.TabIndex = 0
        Me.boneca.TabStop = False
        '
        'Movimento
        '
        Me.Movimento.Interval = 10
        '
        'inimigo2
        '
        Me.inimigo2.BackColor = System.Drawing.Color.Transparent
        Me.inimigo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.inimigo2.Image = Global.WindowsApplication1.My.Resources.Resources.minionwalk
        Me.inimigo2.Location = New System.Drawing.Point(921, 601)
        Me.inimigo2.Name = "inimigo2"
        Me.inimigo2.Size = New System.Drawing.Size(113, 138)
        Me.inimigo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.inimigo2.TabIndex = 1
        Me.inimigo2.TabStop = False
        Me.inimigo2.Visible = False
        '
        'inimigo0
        '
        Me.inimigo0.BackColor = System.Drawing.Color.Transparent
        Me.inimigo0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.inimigo0.Image = Global.WindowsApplication1.My.Resources.Resources.minionwalk
        Me.inimigo0.Location = New System.Drawing.Point(921, 336)
        Me.inimigo0.Name = "inimigo0"
        Me.inimigo0.Size = New System.Drawing.Size(113, 138)
        Me.inimigo0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.inimigo0.TabIndex = 2
        Me.inimigo0.TabStop = False
        Me.inimigo0.Visible = False
        '
        'inimigo1
        '
        Me.inimigo1.BackColor = System.Drawing.Color.Transparent
        Me.inimigo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.inimigo1.Image = Global.WindowsApplication1.My.Resources.Resources.minionwalk
        Me.inimigo1.Location = New System.Drawing.Point(921, 96)
        Me.inimigo1.Name = "inimigo1"
        Me.inimigo1.Size = New System.Drawing.Size(113, 138)
        Me.inimigo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.inimigo1.TabIndex = 3
        Me.inimigo1.TabStop = False
        Me.inimigo1.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 23)
        Me.Label1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(12, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 23)
        Me.Label2.TabIndex = 5
        '
        'Boss
        '
        Me.Boss.BackColor = System.Drawing.Color.Transparent
        Me.Boss.Image = Global.WindowsApplication1.My.Resources.Resources.demonioidle
        Me.Boss.Location = New System.Drawing.Point(505, 207)
        Me.Boss.Name = "Boss"
        Me.Boss.Size = New System.Drawing.Size(206, 433)
        Me.Boss.TabIndex = 7
        Me.Boss.TabStop = False
        Me.Boss.Visible = False
        '
        'lbBoss
        '
        Me.lbBoss.BackColor = System.Drawing.Color.Transparent
        Me.lbBoss.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBoss.Location = New System.Drawing.Point(381, 31)
        Me.lbBoss.Name = "lbBoss"
        Me.lbBoss.Size = New System.Drawing.Size(59, 23)
        Me.lbBoss.TabIndex = 8
        Me.lbBoss.Text = "Boss"
        Me.lbBoss.Visible = False
        '
        'bHp
        '
        Me.bHp.BackColor = System.Drawing.Color.Green
        Me.bHp.Location = New System.Drawing.Point(455, 31)
        Me.bHp.Name = "bHp"
        Me.bHp.Size = New System.Drawing.Size(380, 23)
        Me.bHp.TabIndex = 9
        Me.bHp.Visible = False
        '
        'bkcBHp
        '
        Me.bkcBHp.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bkcBHp.Location = New System.Drawing.Point(455, 31)
        Me.bkcBHp.Name = "bkcBHp"
        Me.bkcBHp.Size = New System.Drawing.Size(380, 10)
        Me.bkcBHp.TabIndex = 10
        Me.bkcBHp.Visible = False
        '
        'espinho0
        '
        Me.espinho0.BackColor = System.Drawing.Color.Transparent
        Me.espinho0.Image = Global.WindowsApplication1.My.Resources.Resources.progetil
        Me.espinho0.Location = New System.Drawing.Point(382, 349)
        Me.espinho0.Name = "espinho0"
        Me.espinho0.Size = New System.Drawing.Size(25, 25)
        Me.espinho0.TabIndex = 11
        Me.espinho0.Visible = False
        '
        'espinho3
        '
        Me.espinho3.Location = New System.Drawing.Point(771, 349)
        Me.espinho3.Name = "espinho3"
        Me.espinho3.Size = New System.Drawing.Size(25, 25)
        Me.espinho3.TabIndex = 12
        Me.espinho3.Visible = False
        '
        'espinho2
        '
        Me.espinho2.Location = New System.Drawing.Point(382, 567)
        Me.espinho2.Name = "espinho2"
        Me.espinho2.Size = New System.Drawing.Size(25, 25)
        Me.espinho2.TabIndex = 13
        Me.espinho2.Visible = False
        '
        'espinho1
        '
        Me.espinho1.Location = New System.Drawing.Point(382, 448)
        Me.espinho1.Name = "espinho1"
        Me.espinho1.Size = New System.Drawing.Size(25, 25)
        Me.espinho1.TabIndex = 14
        Me.espinho1.Visible = False
        '
        'espinho5
        '
        Me.espinho5.Location = New System.Drawing.Point(771, 567)
        Me.espinho5.Name = "espinho5"
        Me.espinho5.Size = New System.Drawing.Size(25, 25)
        Me.espinho5.TabIndex = 16
        Me.espinho5.Visible = False
        '
        'espinho4
        '
        Me.espinho4.Location = New System.Drawing.Point(771, 448)
        Me.espinho4.Name = "espinho4"
        Me.espinho4.Size = New System.Drawing.Size(25, 25)
        Me.espinho4.TabIndex = 17
        Me.espinho4.Visible = False
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(21, 70)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(39, 13)
        Me.label9.TabIndex = 18
        Me.label9.Text = "Label9"
        '
        'picos
        '
        Me.picos.Interval = 1500
        '
        'calhau
        '
        Me.calhau.BackColor = System.Drawing.Color.Transparent
        Me.calhau.Image = Global.WindowsApplication1.My.Resources.Resources.pedra
        Me.calhau.Location = New System.Drawing.Point(110, -41)
        Me.calhau.Name = "calhau"
        Me.calhau.Size = New System.Drawing.Size(108, 152)
        Me.calhau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.calhau.TabIndex = 19
        Me.calhau.TabStop = False
        Me.calhau.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(274, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Label6"
        '
        'Onda
        '
        Me.Onda.Interval = 1800
        '
        'stab
        '
        Me.stab.BackColor = System.Drawing.Color.White
        Me.stab.Location = New System.Drawing.Point(140, 448)
        Me.stab.Name = "stab"
        Me.stab.Size = New System.Drawing.Size(44, 10)
        Me.stab.TabIndex = 22
        Me.stab.Visible = False
        '
        'slash
        '
        Me.slash.BackColor = System.Drawing.Color.White
        Me.slash.Location = New System.Drawing.Point(156, 383)
        Me.slash.Name = "slash"
        Me.slash.Size = New System.Drawing.Size(14, 138)
        Me.slash.TabIndex = 23
        Me.slash.Visible = False
        '
        'wavee
        '
        Me.wavee.BackColor = System.Drawing.Color.Transparent
        Me.wavee.Image = Global.WindowsApplication1.My.Resources.Resources.onda
        Me.wavee.Location = New System.Drawing.Point(11, 480)
        Me.wavee.Name = "wavee"
        Me.wavee.Size = New System.Drawing.Size(1161, 63)
        Me.wavee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.wavee.TabIndex = 24
        Me.wavee.TabStop = False
        Me.wavee.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(2, 694)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 900)
        Me.Panel1.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(497, 373)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(181, 55)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "START"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(432, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(339, 55)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "DORK SOULS"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Location = New System.Drawing.Point(262, 193)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(638, 470)
        Me.Panel3.TabIndex = 5
        Me.Panel3.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(98, 266)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(433, 55)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "MENU PRINCIPAL"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(171, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(288, 55)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "GANHASTE"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Location = New System.Drawing.Point(262, 180)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(638, 470)
        Me.Panel2.TabIndex = 2
        Me.Panel2.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(98, 266)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(468, 55)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "TENTA OUTRA VEZ"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(171, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(296, 55)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "MORRESTE"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.nivel1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1184, 861)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.wavee)
        Me.Controls.Add(Me.boneco)
        Me.Controls.Add(Me.slash)
        Me.Controls.Add(Me.stab)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.inimigo2)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.espinho4)
        Me.Controls.Add(Me.espinho5)
        Me.Controls.Add(Me.espinho1)
        Me.Controls.Add(Me.espinho2)
        Me.Controls.Add(Me.espinho3)
        Me.Controls.Add(Me.espinho0)
        Me.Controls.Add(Me.lbBoss)
        Me.Controls.Add(Me.bHp)
        Me.Controls.Add(Me.bkcBHp)
        Me.Controls.Add(Me.Boss)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.inimigo1)
        Me.Controls.Add(Me.inimigo0)
        Me.Controls.Add(Me.calhau)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.boneco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.boneca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inimigo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inimigo0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inimigo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Boss, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.calhau, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wavee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents boneco As System.Windows.Forms.PictureBox
    Friend WithEvents boneca As System.Windows.Forms.PictureBox
    Friend WithEvents Movimento As System.Windows.Forms.Timer
    Friend WithEvents inimigo2 As System.Windows.Forms.PictureBox
    Friend WithEvents inimigo0 As System.Windows.Forms.PictureBox
    Friend WithEvents inimigo1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Boss As System.Windows.Forms.PictureBox
    Friend WithEvents lbBoss As System.Windows.Forms.Label
    Friend WithEvents bHp As System.Windows.Forms.Label
    Friend WithEvents bkcBHp As System.Windows.Forms.Label
    Friend WithEvents espinho0 As System.Windows.Forms.Label
    Friend WithEvents espinho3 As System.Windows.Forms.Label
    Friend WithEvents espinho2 As System.Windows.Forms.Label
    Friend WithEvents espinho1 As System.Windows.Forms.Label
    Friend WithEvents espinho5 As System.Windows.Forms.Label
    Friend WithEvents espinho4 As System.Windows.Forms.Label
    Friend WithEvents label9 As System.Windows.Forms.Label
    Friend WithEvents picos As System.Windows.Forms.Timer
    Friend WithEvents calhau As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Onda As System.Windows.Forms.Timer
    Friend WithEvents stab As System.Windows.Forms.Label
    Friend WithEvents slash As System.Windows.Forms.Label
    Friend WithEvents wavee As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label

End Class
