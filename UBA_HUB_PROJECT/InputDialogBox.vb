Imports System.Data.OleDb

Public Class InputDialogBox

    Public Shared SelectedVillage As String
    Public Shared SelectedActivity As String
    Public Shared SelectedDate As Date

    'SUBMIT BUTTON
    Private Sub btnSubmit_INPUT_Click(sender As Object, e As EventArgs) Handles btnSubmit_INPUT.Click

        SelectedVillage = cmbxVillage_INPUT.SelectedItem.ToString()
        SelectedActivity = cmbxAct_INPUT.SelectedItem.ToString()
        SelectedDate = DateTimePicker_INPUT.Value

        Dim frm As New Organising_Team(selectedVillage, selectedActivity, selectedDate)
        frm.Show()
        Me.Hide()
    End Sub

    'SUB FOR ACTIVITY OPTION OF COMBOBOX
    Private Sub LoadActivityList()
        Dim conn As System.Data.OleDb.OleDbConnection
        Dim cmd As System.Data.OleDb.OleDbCommand
        Dim reader As System.Data.OleDb.OleDbDataReader

        Dim queryLOAD_ACT As String = "SELECT DISTINCT Activity FROM UBA_Drives_Data ORDER BY Activity"

        conn = New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\UBA_HUB\UBA_HUB_PROJECT_FINALLLLLLLLLLLLLLLLL\UBA_Dtbse.accdb"

        cmbxAct_INPUT.Items.Clear()
        cmbxAct_INPUT.AutoCompleteCustomSource.Clear()

        cmd = New OleDb.OleDbCommand(queryLOAD_ACT, conn)

        conn.Open()
        reader = cmd.ExecuteReader()

        While reader.Read()
            Dim activityName As String = reader("Activity").ToString()
            cmbxAct_INPUT.Items.Add(activityName)
            cmbxAct_INPUT.AutoCompleteCustomSource.Add(activityName)
        End While

        conn.Close()
    End Sub

    'ON LOAD CALL THE SUB ON FORM LOAD
    Private Sub InputDialogBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadActivityList()
    End Sub

End Class