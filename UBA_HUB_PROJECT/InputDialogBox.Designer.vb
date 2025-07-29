<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InputDialogBox
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
        Me.lblCoordinator_ORG = New System.Windows.Forms.Label()
        Me.cmbxVillage_INPUT = New System.Windows.Forms.ComboBox()
        Me.lblactivity_INPUT = New System.Windows.Forms.Label()
        Me.cmbxAct_INPUT = New System.Windows.Forms.ComboBox()
        Me.lblDate_INPUT = New System.Windows.Forms.Label()
        Me.DateTimePicker_INPUT = New System.Windows.Forms.DateTimePicker()
        Me.btnSubmit_INPUT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCoordinator_ORG
        '
        Me.lblCoordinator_ORG.AutoSize = True
        Me.lblCoordinator_ORG.Font = New System.Drawing.Font("Sitka Heading", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoordinator_ORG.Location = New System.Drawing.Point(144, 55)
        Me.lblCoordinator_ORG.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCoordinator_ORG.Name = "lblCoordinator_ORG"
        Me.lblCoordinator_ORG.Size = New System.Drawing.Size(118, 47)
        Me.lblCoordinator_ORG.TabIndex = 7
        Me.lblCoordinator_ORG.Text = "Village"
        '
        'cmbxVillage_INPUT
        '
        Me.cmbxVillage_INPUT.AutoCompleteCustomSource.AddRange(New String() {"Maloya", "Buterla", "Badheri", "Kajheri", "Attawa"})
        Me.cmbxVillage_INPUT.Font = New System.Drawing.Font("Sitka Small", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxVillage_INPUT.FormattingEnabled = True
        Me.cmbxVillage_INPUT.Items.AddRange(New Object() {"Maloya", "Buterla", "Badheri", "Kajheri", "Attawa"})
        Me.cmbxVillage_INPUT.Location = New System.Drawing.Point(402, 61)
        Me.cmbxVillage_INPUT.Name = "cmbxVillage_INPUT"
        Me.cmbxVillage_INPUT.Size = New System.Drawing.Size(284, 32)
        Me.cmbxVillage_INPUT.TabIndex = 8
        '
        'lblactivity_INPUT
        '
        Me.lblactivity_INPUT.AutoSize = True
        Me.lblactivity_INPUT.Font = New System.Drawing.Font("Sitka Heading", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblactivity_INPUT.Location = New System.Drawing.Point(144, 121)
        Me.lblactivity_INPUT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblactivity_INPUT.Name = "lblactivity_INPUT"
        Me.lblactivity_INPUT.Size = New System.Drawing.Size(130, 47)
        Me.lblactivity_INPUT.TabIndex = 9
        Me.lblactivity_INPUT.Text = "Activity"
        '
        'cmbxAct_INPUT
        '
        Me.cmbxAct_INPUT.AutoCompleteCustomSource.AddRange(New String() {"Dr. Amardeep Kaur (Village: Maloya)", "Dr. Arshdeep Kaur (Village: Buterla)", "Dr. Rishu (Village: Badheri)", "Dr. Gurjeet Virk Sidhu (Village Kajheri)", "Dr. Kanika Sofat (Village: Attawa)"})
        Me.cmbxAct_INPUT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbxAct_INPUT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbxAct_INPUT.Font = New System.Drawing.Font("Sitka Small", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxAct_INPUT.FormattingEnabled = True
        Me.cmbxAct_INPUT.Location = New System.Drawing.Point(402, 127)
        Me.cmbxAct_INPUT.Name = "cmbxAct_INPUT"
        Me.cmbxAct_INPUT.Size = New System.Drawing.Size(284, 32)
        Me.cmbxAct_INPUT.TabIndex = 10
        '
        'lblDate_INPUT
        '
        Me.lblDate_INPUT.AutoSize = True
        Me.lblDate_INPUT.Font = New System.Drawing.Font("Sitka Heading", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate_INPUT.Location = New System.Drawing.Point(144, 184)
        Me.lblDate_INPUT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate_INPUT.Name = "lblDate_INPUT"
        Me.lblDate_INPUT.Size = New System.Drawing.Size(85, 47)
        Me.lblDate_INPUT.TabIndex = 11
        Me.lblDate_INPUT.Text = "Date"
        '
        'DateTimePicker_INPUT
        '
        Me.DateTimePicker_INPUT.Font = New System.Drawing.Font("Sitka Small", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_INPUT.Location = New System.Drawing.Point(402, 192)
        Me.DateTimePicker_INPUT.Name = "DateTimePicker_INPUT"
        Me.DateTimePicker_INPUT.Size = New System.Drawing.Size(284, 27)
        Me.DateTimePicker_INPUT.TabIndex = 12
        Me.DateTimePicker_INPUT.Value = New Date(2025, 4, 14, 0, 0, 0, 0)
        '
        'btnSubmit_INPUT
        '
        Me.btnSubmit_INPUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit_INPUT.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit_INPUT.Location = New System.Drawing.Point(315, 253)
        Me.btnSubmit_INPUT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSubmit_INPUT.Name = "btnSubmit_INPUT"
        Me.btnSubmit_INPUT.Size = New System.Drawing.Size(162, 50)
        Me.btnSubmit_INPUT.TabIndex = 25
        Me.btnSubmit_INPUT.Text = "Submit"
        Me.btnSubmit_INPUT.UseVisualStyleBackColor = True
        '
        'InputDialogBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 356)
        Me.Controls.Add(Me.btnSubmit_INPUT)
        Me.Controls.Add(Me.DateTimePicker_INPUT)
        Me.Controls.Add(Me.lblDate_INPUT)
        Me.Controls.Add(Me.cmbxAct_INPUT)
        Me.Controls.Add(Me.lblactivity_INPUT)
        Me.Controls.Add(Me.cmbxVillage_INPUT)
        Me.Controls.Add(Me.lblCoordinator_ORG)
        Me.Name = "InputDialogBox"
        Me.Text = "Please enter necessary details:-"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCoordinator_ORG As Label
    Friend WithEvents cmbxVillage_INPUT As ComboBox
    Friend WithEvents lblactivity_INPUT As Label
    Friend WithEvents cmbxAct_INPUT As ComboBox
    Friend WithEvents lblDate_INPUT As Label
    Friend WithEvents DateTimePicker_INPUT As DateTimePicker
    Friend WithEvents btnSubmit_INPUT As Button
End Class
