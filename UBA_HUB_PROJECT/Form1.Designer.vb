<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelHead_Home = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblReportHead_HOME = New System.Windows.Forms.Label()
        Me.lblUBAHead_HOME = New System.Windows.Forms.Label()
        Me.lblTeams_HOME = New System.Windows.Forms.Label()
        Me.PanelVillage_HOME = New System.Windows.Forms.Panel()
        Me.btnVillage_HOME = New System.Windows.Forms.Button()
        Me.picbxVillage_HOME = New System.Windows.Forms.PictureBox()
        Me.PanelOrg_HOME = New System.Windows.Forms.Panel()
        Me.btnOrg_Home = New System.Windows.Forms.Button()
        Me.picbxOrg_HOME = New System.Windows.Forms.PictureBox()
        Me.btnActivity_HOME = New System.Windows.Forms.Button()
        Me.PanelSmallDown_HOME = New System.Windows.Forms.Panel()
        Me.PanelHead_Home.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelVillage_HOME.SuspendLayout()
        CType(Me.picbxVillage_HOME, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelOrg_HOME.SuspendLayout()
        CType(Me.picbxOrg_HOME, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelHead_Home
        '
        Me.PanelHead_Home.BackColor = System.Drawing.Color.DarkGreen
        Me.PanelHead_Home.Controls.Add(Me.PictureBox2)
        Me.PanelHead_Home.Controls.Add(Me.PictureBox1)
        Me.PanelHead_Home.Controls.Add(Me.lblReportHead_HOME)
        Me.PanelHead_Home.Controls.Add(Me.lblUBAHead_HOME)
        Me.PanelHead_Home.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHead_Home.ForeColor = System.Drawing.Color.White
        Me.PanelHead_Home.Location = New System.Drawing.Point(0, 0)
        Me.PanelHead_Home.Name = "PanelHead_Home"
        Me.PanelHead_Home.Size = New System.Drawing.Size(1142, 154)
        Me.PanelHead_Home.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.UBA_HUB_PROJECT.My.Resources.Resources.gandhi
        Me.PictureBox2.Location = New System.Drawing.Point(1008, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(131, 121)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UBA_HUB_PROJECT.My.Resources.Resources.Jayate
        Me.PictureBox1.Location = New System.Drawing.Point(3, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 121)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblReportHead_HOME
        '
        Me.lblReportHead_HOME.AutoSize = True
        Me.lblReportHead_HOME.BackColor = System.Drawing.Color.DarkGreen
        Me.lblReportHead_HOME.Font = New System.Drawing.Font("Sitka Subheading", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportHead_HOME.ForeColor = System.Drawing.Color.White
        Me.lblReportHead_HOME.Location = New System.Drawing.Point(122, 99)
        Me.lblReportHead_HOME.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReportHead_HOME.Name = "lblReportHead_HOME"
        Me.lblReportHead_HOME.Size = New System.Drawing.Size(821, 40)
        Me.lblReportHead_HOME.TabIndex = 3
        Me.lblReportHead_HOME.Text = "A Report Management System, where all five villages connect."
        '
        'lblUBAHead_HOME
        '
        Me.lblUBAHead_HOME.AutoSize = True
        Me.lblUBAHead_HOME.BackColor = System.Drawing.Color.DarkGreen
        Me.lblUBAHead_HOME.Font = New System.Drawing.Font("Sitka Subheading", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUBAHead_HOME.ForeColor = System.Drawing.Color.White
        Me.lblUBAHead_HOME.Location = New System.Drawing.Point(69, 0)
        Me.lblUBAHead_HOME.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUBAHead_HOME.Name = "lblUBAHead_HOME"
        Me.lblUBAHead_HOME.Size = New System.Drawing.Size(959, 104)
        Me.lblUBAHead_HOME.TabIndex = 2
        Me.lblUBAHead_HOME.Text = "Unnat Bharat Abhiyan HUB"
        '
        'lblTeams_HOME
        '
        Me.lblTeams_HOME.AutoSize = True
        Me.lblTeams_HOME.Font = New System.Drawing.Font("Sitka Subheading", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeams_HOME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTeams_HOME.Location = New System.Drawing.Point(448, 157)
        Me.lblTeams_HOME.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTeams_HOME.Name = "lblTeams_HOME"
        Me.lblTeams_HOME.Size = New System.Drawing.Size(224, 81)
        Me.lblTeams_HOME.TabIndex = 10
        Me.lblTeams_HOME.Text = "TEAMS"
        '
        'PanelVillage_HOME
        '
        Me.PanelVillage_HOME.BackColor = System.Drawing.Color.White
        Me.PanelVillage_HOME.Controls.Add(Me.btnVillage_HOME)
        Me.PanelVillage_HOME.Controls.Add(Me.picbxVillage_HOME)
        Me.PanelVillage_HOME.Location = New System.Drawing.Point(118, 262)
        Me.PanelVillage_HOME.Name = "PanelVillage_HOME"
        Me.PanelVillage_HOME.Size = New System.Drawing.Size(383, 432)
        Me.PanelVillage_HOME.TabIndex = 11
        '
        'btnVillage_HOME
        '
        Me.btnVillage_HOME.BackColor = System.Drawing.Color.DarkGreen
        Me.btnVillage_HOME.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVillage_HOME.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVillage_HOME.Font = New System.Drawing.Font("Sitka Subheading", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVillage_HOME.ForeColor = System.Drawing.Color.White
        Me.btnVillage_HOME.Location = New System.Drawing.Point(24, 350)
        Me.btnVillage_HOME.Name = "btnVillage_HOME"
        Me.btnVillage_HOME.Size = New System.Drawing.Size(336, 68)
        Me.btnVillage_HOME.TabIndex = 1
        Me.btnVillage_HOME.Text = "Village Coordinator"
        Me.btnVillage_HOME.UseVisualStyleBackColor = False
        '
        'picbxVillage_HOME
        '
        Me.picbxVillage_HOME.Image = Global.UBA_HUB_PROJECT.My.Resources.Resources.Village_Coordinator_Home
        Me.picbxVillage_HOME.Location = New System.Drawing.Point(24, 15)
        Me.picbxVillage_HOME.Name = "picbxVillage_HOME"
        Me.picbxVillage_HOME.Size = New System.Drawing.Size(336, 329)
        Me.picbxVillage_HOME.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbxVillage_HOME.TabIndex = 0
        Me.picbxVillage_HOME.TabStop = False
        '
        'PanelOrg_HOME
        '
        Me.PanelOrg_HOME.BackColor = System.Drawing.Color.White
        Me.PanelOrg_HOME.Controls.Add(Me.btnOrg_Home)
        Me.PanelOrg_HOME.Controls.Add(Me.picbxOrg_HOME)
        Me.PanelOrg_HOME.Location = New System.Drawing.Point(620, 262)
        Me.PanelOrg_HOME.Name = "PanelOrg_HOME"
        Me.PanelOrg_HOME.Size = New System.Drawing.Size(383, 432)
        Me.PanelOrg_HOME.TabIndex = 12
        '
        'btnOrg_Home
        '
        Me.btnOrg_Home.BackColor = System.Drawing.Color.DarkGreen
        Me.btnOrg_Home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOrg_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrg_Home.Font = New System.Drawing.Font("Sitka Subheading", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrg_Home.ForeColor = System.Drawing.Color.White
        Me.btnOrg_Home.Location = New System.Drawing.Point(24, 350)
        Me.btnOrg_Home.Name = "btnOrg_Home"
        Me.btnOrg_Home.Size = New System.Drawing.Size(336, 68)
        Me.btnOrg_Home.TabIndex = 1
        Me.btnOrg_Home.Text = "Organising Team"
        Me.btnOrg_Home.UseVisualStyleBackColor = False
        '
        'picbxOrg_HOME
        '
        Me.picbxOrg_HOME.Image = Global.UBA_HUB_PROJECT.My.Resources.Resources.Organizing_Home
        Me.picbxOrg_HOME.Location = New System.Drawing.Point(24, 15)
        Me.picbxOrg_HOME.Name = "picbxOrg_HOME"
        Me.picbxOrg_HOME.Size = New System.Drawing.Size(336, 329)
        Me.picbxOrg_HOME.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbxOrg_HOME.TabIndex = 0
        Me.picbxOrg_HOME.TabStop = False
        '
        'btnActivity_HOME
        '
        Me.btnActivity_HOME.BackColor = System.Drawing.Color.DarkGreen
        Me.btnActivity_HOME.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActivity_HOME.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActivity_HOME.Font = New System.Drawing.Font("Sitka Subheading", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActivity_HOME.ForeColor = System.Drawing.Color.White
        Me.btnActivity_HOME.Location = New System.Drawing.Point(400, 743)
        Me.btnActivity_HOME.Name = "btnActivity_HOME"
        Me.btnActivity_HOME.Size = New System.Drawing.Size(327, 81)
        Me.btnActivity_HOME.TabIndex = 13
        Me.btnActivity_HOME.Text = "Activities"
        Me.btnActivity_HOME.UseVisualStyleBackColor = False
        '
        'PanelSmallDown_HOME
        '
        Me.PanelSmallDown_HOME.BackColor = System.Drawing.Color.DarkGreen
        Me.PanelSmallDown_HOME.Location = New System.Drawing.Point(61, 717)
        Me.PanelSmallDown_HOME.Name = "PanelSmallDown_HOME"
        Me.PanelSmallDown_HOME.Size = New System.Drawing.Size(1005, 11)
        Me.PanelSmallDown_HOME.TabIndex = 14
        '
        'formMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1142, 837)
        Me.Controls.Add(Me.PanelSmallDown_HOME)
        Me.Controls.Add(Me.btnActivity_HOME)
        Me.Controls.Add(Me.PanelOrg_HOME)
        Me.Controls.Add(Me.PanelVillage_HOME)
        Me.Controls.Add(Me.lblTeams_HOME)
        Me.Controls.Add(Me.PanelHead_Home)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "formMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UBA HUB - Home"
        Me.PanelHead_Home.ResumeLayout(False)
        Me.PanelHead_Home.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelVillage_HOME.ResumeLayout(False)
        CType(Me.picbxVillage_HOME, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelOrg_HOME.ResumeLayout(False)
        CType(Me.picbxOrg_HOME, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelHead_Home As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblReportHead_HOME As Label
    Friend WithEvents lblUBAHead_HOME As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblTeams_HOME As Label
    Friend WithEvents PanelVillage_HOME As Panel
    Friend WithEvents picbxVillage_HOME As PictureBox
    Friend WithEvents btnVillage_HOME As Button
    Friend WithEvents PanelOrg_HOME As Panel
    Friend WithEvents btnOrg_Home As Button
    Friend WithEvents picbxOrg_HOME As PictureBox
    Friend WithEvents btnActivity_HOME As Button
    Friend WithEvents PanelSmallDown_HOME As Panel
End Class
