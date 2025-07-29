<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Activities
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
        Me.lblVillage_ACT = New System.Windows.Forms.Label()
        Me.picbxWritten_VC = New System.Windows.Forms.PictureBox()
        Me.cmbxVillage_ACT = New System.Windows.Forms.ComboBox()
        Me.lblActivity_ACT = New System.Windows.Forms.Label()
        Me.lblYear_ACT = New System.Windows.Forms.Label()
        Me.cmbxYear_ACT = New System.Windows.Forms.ComboBox()
        Me.btnDelete_ACT = New System.Windows.Forms.Button()
        Me.btnUpdate_ACT = New System.Windows.Forms.Button()
        Me.Grid_ACT = New System.Windows.Forms.DataGridView()
        Me.Village = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateGrid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnReset_ACT = New System.Windows.Forms.Button()
        Me.btnShow_ACT = New System.Windows.Forms.Button()
        Me.btnViewDetails_ACT = New System.Windows.Forms.Button()
        Me.btnUpload_ACT = New System.Windows.Forms.Button()
        Me.cmbxActivity_ACT = New System.Windows.Forms.ComboBox()
        CType(Me.picbxWritten_VC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid_ACT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblVillage_ACT
        '
        Me.lblVillage_ACT.AutoSize = True
        Me.lblVillage_ACT.Location = New System.Drawing.Point(43, 227)
        Me.lblVillage_ACT.Name = "lblVillage_ACT"
        Me.lblVillage_ACT.Size = New System.Drawing.Size(103, 35)
        Me.lblVillage_ACT.TabIndex = 0
        Me.lblVillage_ACT.Text = "Village"
        '
        'picbxWritten_VC
        '
        Me.picbxWritten_VC.Dock = System.Windows.Forms.DockStyle.Top
        Me.picbxWritten_VC.Image = Global.UBA_HUB_PROJECT.My.Resources.Resources.Modi
        Me.picbxWritten_VC.Location = New System.Drawing.Point(0, 0)
        Me.picbxWritten_VC.Name = "picbxWritten_VC"
        Me.picbxWritten_VC.Size = New System.Drawing.Size(1142, 175)
        Me.picbxWritten_VC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbxWritten_VC.TabIndex = 4
        Me.picbxWritten_VC.TabStop = False
        '
        'cmbxVillage_ACT
        '
        Me.cmbxVillage_ACT.AutoCompleteCustomSource.AddRange(New String() {"Maloya", "Buterla", "Badheri", "Kajheri", "Attawa", "ALL"})
        Me.cmbxVillage_ACT.Font = New System.Drawing.Font("Sitka Small", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxVillage_ACT.FormattingEnabled = True
        Me.cmbxVillage_ACT.Items.AddRange(New Object() {"Maloya", "Buterla", "Badheri", "Kajheri", "Attawa", "ALL"})
        Me.cmbxVillage_ACT.Location = New System.Drawing.Point(167, 233)
        Me.cmbxVillage_ACT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbxVillage_ACT.Name = "cmbxVillage_ACT"
        Me.cmbxVillage_ACT.Size = New System.Drawing.Size(310, 32)
        Me.cmbxVillage_ACT.TabIndex = 47
        '
        'lblActivity_ACT
        '
        Me.lblActivity_ACT.AutoSize = True
        Me.lblActivity_ACT.Location = New System.Drawing.Point(533, 227)
        Me.lblActivity_ACT.Name = "lblActivity_ACT"
        Me.lblActivity_ACT.Size = New System.Drawing.Size(114, 35)
        Me.lblActivity_ACT.TabIndex = 48
        Me.lblActivity_ACT.Text = "Activity"
        '
        'lblYear_ACT
        '
        Me.lblYear_ACT.AutoSize = True
        Me.lblYear_ACT.Location = New System.Drawing.Point(43, 301)
        Me.lblYear_ACT.Name = "lblYear_ACT"
        Me.lblYear_ACT.Size = New System.Drawing.Size(73, 35)
        Me.lblYear_ACT.TabIndex = 50
        Me.lblYear_ACT.Text = "Year"
        '
        'cmbxYear_ACT
        '
        Me.cmbxYear_ACT.Font = New System.Drawing.Font("Sitka Small", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxYear_ACT.FormattingEnabled = True
        Me.cmbxYear_ACT.Location = New System.Drawing.Point(167, 298)
        Me.cmbxYear_ACT.Name = "cmbxYear_ACT"
        Me.cmbxYear_ACT.Size = New System.Drawing.Size(310, 32)
        Me.cmbxYear_ACT.TabIndex = 51
        '
        'btnDelete_ACT
        '
        Me.btnDelete_ACT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete_ACT.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete_ACT.Location = New System.Drawing.Point(593, 973)
        Me.btnDelete_ACT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDelete_ACT.Name = "btnDelete_ACT"
        Me.btnDelete_ACT.Size = New System.Drawing.Size(162, 50)
        Me.btnDelete_ACT.TabIndex = 52
        Me.btnDelete_ACT.Text = "Delete"
        Me.btnDelete_ACT.UseVisualStyleBackColor = True
        '
        'btnUpdate_ACT
        '
        Me.btnUpdate_ACT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate_ACT.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate_ACT.Location = New System.Drawing.Point(371, 973)
        Me.btnUpdate_ACT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUpdate_ACT.Name = "btnUpdate_ACT"
        Me.btnUpdate_ACT.Size = New System.Drawing.Size(162, 50)
        Me.btnUpdate_ACT.TabIndex = 53
        Me.btnUpdate_ACT.Text = "Update"
        Me.btnUpdate_ACT.UseVisualStyleBackColor = True
        '
        'Grid_ACT
        '
        Me.Grid_ACT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_ACT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Village, Me.Activity, Me.DateGrid, Me.Description})
        Me.Grid_ACT.Location = New System.Drawing.Point(49, 386)
        Me.Grid_ACT.MultiSelect = False
        Me.Grid_ACT.Name = "Grid_ACT"
        Me.Grid_ACT.RowTemplate.Height = 28
        Me.Grid_ACT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid_ACT.Size = New System.Drawing.Size(1042, 558)
        Me.Grid_ACT.TabIndex = 54
        '
        'Village
        '
        Me.Village.DataPropertyName = "Village"
        Me.Village.HeaderText = "Village"
        Me.Village.Name = "Village"
        Me.Village.Width = 150
        '
        'Activity
        '
        Me.Activity.DataPropertyName = "Activity"
        Me.Activity.HeaderText = "Activity"
        Me.Activity.Name = "Activity"
        Me.Activity.Width = 180
        '
        'DateGrid
        '
        Me.DateGrid.DataPropertyName = "DateGrid"
        Me.DateGrid.HeaderText = "Date"
        Me.DateGrid.Name = "DateGrid"
        Me.DateGrid.ReadOnly = True
        Me.DateGrid.Width = 180
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.Width = 340
        '
        'btnReset_ACT
        '
        Me.btnReset_ACT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset_ACT.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset_ACT.Location = New System.Drawing.Point(539, 293)
        Me.btnReset_ACT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnReset_ACT.Name = "btnReset_ACT"
        Me.btnReset_ACT.Size = New System.Drawing.Size(162, 50)
        Me.btnReset_ACT.TabIndex = 55
        Me.btnReset_ACT.Text = "Reset"
        Me.btnReset_ACT.UseVisualStyleBackColor = True
        '
        'btnShow_ACT
        '
        Me.btnShow_ACT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShow_ACT.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow_ACT.Location = New System.Drawing.Point(740, 291)
        Me.btnShow_ACT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnShow_ACT.Name = "btnShow_ACT"
        Me.btnShow_ACT.Size = New System.Drawing.Size(162, 50)
        Me.btnShow_ACT.TabIndex = 56
        Me.btnShow_ACT.Text = "Show"
        Me.btnShow_ACT.UseVisualStyleBackColor = True
        '
        'btnViewDetails_ACT
        '
        Me.btnViewDetails_ACT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewDetails_ACT.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewDetails_ACT.Location = New System.Drawing.Point(49, 973)
        Me.btnViewDetails_ACT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnViewDetails_ACT.Name = "btnViewDetails_ACT"
        Me.btnViewDetails_ACT.Size = New System.Drawing.Size(265, 50)
        Me.btnViewDetails_ACT.TabIndex = 57
        Me.btnViewDetails_ACT.Text = "View Whole Details"
        Me.btnViewDetails_ACT.UseVisualStyleBackColor = True
        '
        'btnUpload_ACT
        '
        Me.btnUpload_ACT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpload_ACT.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload_ACT.Location = New System.Drawing.Point(815, 973)
        Me.btnUpload_ACT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUpload_ACT.Name = "btnUpload_ACT"
        Me.btnUpload_ACT.Size = New System.Drawing.Size(240, 50)
        Me.btnUpload_ACT.TabIndex = 58
        Me.btnUpload_ACT.Text = "Upload Report"
        Me.btnUpload_ACT.UseVisualStyleBackColor = True
        '
        'cmbxActivity_ACT
        '
        Me.cmbxActivity_ACT.AutoCompleteCustomSource.AddRange(New String() {"Dr. Amardeep Kaur (Village: Maloya)", "Dr. Arshdeep Kaur (Village: Buterla)", "Dr. Rishu (Village: Badheri)", "Dr. Gurjeet Virk Sidhu (Village Kajheri)", "Dr. Kanika Sofat (Village: Attawa)"})
        Me.cmbxActivity_ACT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbxActivity_ACT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbxActivity_ACT.Font = New System.Drawing.Font("Sitka Small", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxActivity_ACT.FormattingEnabled = True
        Me.cmbxActivity_ACT.Location = New System.Drawing.Point(680, 233)
        Me.cmbxActivity_ACT.Name = "cmbxActivity_ACT"
        Me.cmbxActivity_ACT.Size = New System.Drawing.Size(284, 32)
        Me.cmbxActivity_ACT.TabIndex = 59
        '
        'Activities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 35.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1142, 1050)
        Me.Controls.Add(Me.cmbxActivity_ACT)
        Me.Controls.Add(Me.btnUpload_ACT)
        Me.Controls.Add(Me.btnViewDetails_ACT)
        Me.Controls.Add(Me.btnShow_ACT)
        Me.Controls.Add(Me.btnReset_ACT)
        Me.Controls.Add(Me.Grid_ACT)
        Me.Controls.Add(Me.btnUpdate_ACT)
        Me.Controls.Add(Me.btnDelete_ACT)
        Me.Controls.Add(Me.cmbxYear_ACT)
        Me.Controls.Add(Me.lblYear_ACT)
        Me.Controls.Add(Me.lblActivity_ACT)
        Me.Controls.Add(Me.cmbxVillage_ACT)
        Me.Controls.Add(Me.picbxWritten_VC)
        Me.Controls.Add(Me.lblVillage_ACT)
        Me.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "Activities"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activities"
        CType(Me.picbxWritten_VC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid_ACT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVillage_ACT As Label
    Friend WithEvents picbxWritten_VC As PictureBox
    Friend WithEvents cmbxVillage_ACT As ComboBox
    Friend WithEvents lblActivity_ACT As Label
    Friend WithEvents lblYear_ACT As Label
    Friend WithEvents cmbxYear_ACT As ComboBox
    Friend WithEvents btnDelete_ACT As Button
    Friend WithEvents btnUpdate_ACT As Button
    Friend WithEvents Grid_ACT As DataGridView
    Friend WithEvents btnReset_ACT As Button
    Friend WithEvents btnShow_ACT As Button
    Friend WithEvents btnViewDetails_ACT As Button
    Friend WithEvents btnUpload_ACT As Button
    Friend WithEvents cmbxActivity_ACT As ComboBox
    Friend WithEvents Village As DataGridViewTextBoxColumn
    Friend WithEvents Activity As DataGridViewTextBoxColumn
    Friend WithEvents DateGrid As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
End Class
