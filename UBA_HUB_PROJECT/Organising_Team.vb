Imports System.Data.OleDb

Public Class Organising_Team
    Private originalRawDesc As String = ""
    Private village As String
    Private activity As String
    Private activityDate As Date

    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim reader As OleDbDataReader

    ' CONSTRUCTOR TO RECEIVE VALUES
    Public Sub New(selectedVillage As String, selectedActivity As String, selectedDate As Date)
        InitializeComponent()
        village = selectedVillage
        activity = selectedActivity
        activityDate = selectedDate
    End Sub

    ' RESET BUTTON
    Private Sub btnReset_ORG_Click(sender As Object, e As EventArgs) Handles btnReset_ORG.Click
        txtNeed_ORG.Text = ""
        txtFinalDescription_ORG.Text = ""
    End Sub

    ' SUBMIT BUTTON
    Private Sub btnSubmit_ORG_Click(sender As Object, e As EventArgs) Handles btnSubmit_ORG.Click
        ' Check if Raw Description was modified
        If txtDescDisplay_ORG.Text.Trim() <> originalRawDesc.Trim() Then
            MessageBox.Show("You modified 'Raw Description', but it will NOT be saved to the database." & vbCrLf &
                            "Only 'Need' and 'Final Description' will be updated.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        Dim need As String = txtNeed_ORG.Text.Trim()
        Dim finalDesc As String = txtFinalDescription_ORG.Text.Trim()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\UBA_HUB\UBA_HUB_PROJECT_FINALLLLLLLLLLLLLLLLL\UBA_Dtbse.accdb")

        Dim querySubmit As String = "UPDATE UBA_Drives_Data SET [Need] = ?, [Final_Description] = ? WHERE [Village] = ? AND [Activity] = ? AND [Date_of_act] = ?"
        cmd = New OleDbCommand(querySubmit, conn)

        cmd.Parameters.AddWithValue("?", need)
        cmd.Parameters.AddWithValue("?", finalDesc)
        cmd.Parameters.AddWithValue("?", village)
        cmd.Parameters.AddWithValue("?", activity)
        cmd.Parameters.AddWithValue("?", activityDate)

        conn.Open()
        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
        conn.Close()

        If rowsAffected > 0 Then
            MessageBox.Show("Report submitted successfully!" & vbCrLf &
                            "Note: Only 'Need' and 'Final Description' were saved." & vbCrLf &
                            "'Raw Description' is shown for reference only and was not updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to update the record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Me.Close()
    End Sub

    ' ON LOAD EVENT - Load data into form
    Private Sub Organising_Team_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\UBA_HUB\UBA_HUB_PROJECT_FINALLLLLLLLLLLLLLLLL\UBA_Dtbse.accdb")

        Dim queryLoad As String = "SELECT * FROM UBA_Drives_Data WHERE Village=? AND Activity=? AND [Date_of_act]=?"
        cmd = New OleDbCommand(queryLoad, conn)

        cmd.Parameters.AddWithValue("?", village)
        cmd.Parameters.AddWithValue("?", activity)
        cmd.Parameters.AddWithValue("?", activityDate)

        conn.Open()
        reader = cmd.ExecuteReader()

        If reader IsNot Nothing AndAlso reader.Read() Then
            lblVillageDisplay_ORG.Text = reader("Village").ToString()
            lblCoordinatorDisplay_ORG.Text = reader("Coordinator").ToString()
            lblActivityDisplay_ORG.Text = reader("Activity").ToString()
            lblDateDisplay_ORG.Text = Convert.ToDateTime(reader("Date_of_act")).ToShortDateString()
            lblEmailDisplay_ORG.Text = reader("Email_ID").ToString()

            txtDescDisplay_ORG.Text = reader("Raw_Description").ToString()
            originalRawDesc = txtDescDisplay_ORG.Text ' Store original value for later comparison

            txtNeed_ORG.Text = reader("Need").ToString()
            txtFinalDescription_ORG.Text = reader("Final_Description").ToString()
        Else
            MessageBox.Show("No data found for the selected input.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        End If

        conn.Close()

        ' Allow user to view/edit Raw Description (but it won't be saved)
        txtDescDisplay_ORG.ReadOnly = False
    End Sub
End Class
