Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Activities
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\UBA_HUB\UBA_HUB_PROJECT_FINALLLLLLLLLLLLLLLLL\UBA_Dtbse.accdb")
    Dim dt As New DataTable()
    Dim da As New OleDbDataAdapter()
    Dim reader As OleDbDataReader

    ' ON LOAD
    Private Sub Activities_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillVillageComboBox()
        FillActivityComboBox()
        FillYearComboBox()
    End Sub

    ' COMBOBOX FILLERS
    Private Sub FillVillageComboBox()
        cmbxVillage_ACT.Items.Clear()
        cmbxVillage_ACT.Items.Add("ALL")
        Dim cmd As New OleDbCommand("SELECT DISTINCT Village FROM UBA_Drives_Data ORDER BY Village", conn)
        conn.Open()
        reader = cmd.ExecuteReader()
        While reader.Read()
            cmbxVillage_ACT.Items.Add(reader("Village").ToString())
        End While
        conn.Close()
        cmbxVillage_ACT.SelectedItem = "ALL"
    End Sub

    Private Sub FillActivityComboBox()
        cmbxActivity_ACT.Items.Clear()
        cmbxActivity_ACT.Items.Add("ALL")
        Dim cmd As New OleDbCommand("SELECT DISTINCT Activity FROM UBA_Drives_Data ORDER BY Activity", conn)
        conn.Open()
        reader = cmd.ExecuteReader()
        While reader.Read()
            cmbxActivity_ACT.Items.Add(reader("Activity").ToString())
        End While
        conn.Close()
        cmbxActivity_ACT.SelectedItem = "ALL"
    End Sub

    Private Sub FillYearComboBox()
        cmbxYear_ACT.Items.Clear()
        cmbxYear_ACT.Items.Add("ALL")
        Dim cmd As New OleDbCommand("SELECT DISTINCT Year(Date_of_act) FROM UBA_Drives_Data ORDER BY Year(Date_of_act) DESC", conn)
        conn.Open()
        reader = cmd.ExecuteReader()
        While reader.Read()
            cmbxYear_ACT.Items.Add(reader(0).ToString())
        End While
        conn.Close()
        cmbxYear_ACT.SelectedItem = "ALL"
    End Sub

    ' RESET BUTTON
    Private Sub btnReset_ACT_Click(sender As Object, e As EventArgs) Handles btnReset_ACT.Click
        cmbxVillage_ACT.SelectedItem = "ALL"
        cmbxActivity_ACT.SelectedItem = "ALL"
        cmbxYear_ACT.SelectedItem = "ALL"
        Grid_ACT.DataSource = Nothing
        Grid_ACT.Columns.Clear()
        dt.Clear()
    End Sub

    ' SHOW BUTTON
    Private Sub btnShow_ACT_Click(sender As Object, e As EventArgs) Handles btnShow_ACT.Click
        Dim villageFilter As String = cmbxVillage_ACT.Text.Trim()
        Dim activityFilter As String = cmbxActivity_ACT.Text.Trim()
        Dim yearFilter As String = cmbxYear_ACT.Text.Trim()

        Dim query As String = "SELECT ID, Village, Activity, Date_of_act AS [Date], Year(Date_of_act) AS [Year], Final_Description AS [Description] FROM UBA_Drives_Data WHERE 1=1"

        If villageFilter <> "ALL" Then
            query &= " AND Village = ?"
        End If
        If activityFilter <> "ALL" Then
            query &= " AND Activity = ?"
        End If
        If yearFilter <> "ALL" Then
            query &= " AND Year(Date_of_act) = ?"
        End If

        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\UBA_HUB\UBA_HUB_PROJECT_FINALLLLLLLLLLLLLLLLL\UBA_Dtbse.accdb")
            Using cmd As New OleDbCommand(query, conn)
                If villageFilter <> "ALL" Then
                    cmd.Parameters.AddWithValue("?", villageFilter)
                End If
                If activityFilter <> "ALL" Then
                    cmd.Parameters.AddWithValue("?", activityFilter)
                End If
                If yearFilter <> "ALL" Then
                    cmd.Parameters.AddWithValue("?", yearFilter)
                End If

                Dim dt As New DataTable()
                Dim adapter As New OleDbDataAdapter(cmd)
                adapter.Fill(dt)

                Grid_ACT.Columns.Clear()
                Grid_ACT.DataSource = dt
                Grid_ACT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                If Grid_ACT.Columns.Contains("Date") Then
                    Grid_ACT.Columns("Date").DefaultCellStyle.Format = "dd-MMM-yyyy"
                End If

                If Grid_ACT.Columns.Contains("ID") Then
                    Grid_ACT.Columns("ID").Visible = False
                End If
            End Using
        End Using
    End Sub

    ' VIEW DETAILS
    Private Sub btnViewDetails_ACT_Click(sender As Object, e As EventArgs) Handles btnViewDetails_ACT.Click
        If Grid_ACT.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to view details.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim selectedRow As DataGridViewRow = Grid_ACT.SelectedRows(0)
        Dim details As String = ""
        For Each cell As DataGridViewCell In selectedRow.Cells
            If cell.Visible AndAlso cell.Value IsNot Nothing Then
                details &= Grid_ACT.Columns(cell.ColumnIndex).HeaderText & ": " & cell.Value.ToString() & Environment.NewLine
            End If
        Next
        MessageBox.Show(details, "Full Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' UPDATE BUTTON
    Private Sub btnUpdate_ACT_Click(sender As Object, e As EventArgs) Handles btnUpdate_ACT.Click
        Dim updatedCount As Integer = 0
        Dim notUpdatedList As New List(Of String)

        For Each row As DataGridViewRow In Grid_ACT.Rows
            If row.IsNewRow Then Continue For

            Dim newVillage = row.Cells("Village").Value.ToString().Trim()
            Dim newActivity = row.Cells("Activity").Value.ToString().Trim()
            Dim newDate = Convert.ToDateTime(row.Cells("Date").Value).Date
            Dim newDesc = row.Cells("Description").Value.ToString().Trim()
            Dim recordID = Convert.ToInt32(row.Cells("ID").Value)

            Dim query As String = "UPDATE UBA_Drives_Data SET Village = ?, Activity = ?, Date_of_act = ?, Final_Description = ? WHERE ID = ?"

            Using con As New OleDbConnection(conn.ConnectionString)
                con.Open()
                Using cmd As New OleDbCommand(query, con)
                    cmd.Parameters.AddWithValue("?", newVillage)
                    cmd.Parameters.AddWithValue("?", newActivity)
                    cmd.Parameters.AddWithValue("?", newDate)
                    cmd.Parameters.AddWithValue("?", newDesc)
                    cmd.Parameters.AddWithValue("?", recordID)

                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        updatedCount += 1
                    Else
                        notUpdatedList.Add($"{newVillage}, {newActivity}, {newDate.ToShortDateString()}")
                    End If
                End Using
            End Using
        Next

        If notUpdatedList.Count > 0 Then
            MessageBox.Show("Changes were not updated:" & vbCrLf & String.Join(vbCrLf, notUpdatedList), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("Changes are updated successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' DELETE BUTTON
    Private Sub btnDelete_ACT_Click(sender As Object, e As EventArgs) Handles btnDelete_ACT.Click
        If Grid_ACT.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected row?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then Exit Sub

        Dim row As DataGridViewRow = Grid_ACT.SelectedRows(0)
        Dim recordID = Convert.ToInt32(row.Cells("ID").Value)

        Dim deleteQuery = "DELETE FROM UBA_Drives_Data WHERE ID = ?"
        Using cmd As New OleDbCommand(deleteQuery, conn)
            cmd.Parameters.AddWithValue("?", recordID)
            conn.Open()
            Dim rows = cmd.ExecuteNonQuery()
            conn.Close()
            If rows > 0 Then
                Grid_ACT.Rows.Remove(row)
                MessageBox.Show("Selected row deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No matching record found in database.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Using
    End Sub

    ' MAKE YEAR COLUMN READ-ONLY
    Private Sub Grid_ACT_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles Grid_ACT.DataBindingComplete
        If Grid_ACT.Columns.Contains("Year") Then
            Grid_ACT.Columns("Year").ReadOnly = True
        End If
    End Sub

    'CRYSTAL REPORT BUTTON UOPLOAD REPORT
    Private Sub btnUploadReport_Click(sender As Object, e As EventArgs) Handles btnUpload_ACT.Click
        Try
            ' Ensure a row is selected
            If Grid_ACT.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a record first.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Get selected record data
            Dim village = Grid_ACT.SelectedRows(0).Cells("Village").Value.ToString()
            Dim activity = Grid_ACT.SelectedRows(0).Cells("Activity").Value.ToString()
            Dim activityDate = Convert.ToDateTime(Grid_ACT.SelectedRows(0).Cells("Date").Value)

            ' Query to fetch full data for selected record
            Dim query = "SELECT * FROM UBA_Drives_Data WHERE Village = ? AND Activity = ? AND Date_of_act = ?"
            Dim dt As New DataTable()

            Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\UBA_HUB\UBA_HUB_PROJECT_FINALLLLLLLLLLLLLLLLL\UBA_Dtbse.accdb")
                Using cmd As New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("?", village)
                    cmd.Parameters.AddWithValue("?", activity)
                    cmd.Parameters.AddWithValue("?", activityDate)

                    Using adapter As New OleDbDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No data found for this record.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ' Load and configure the Crystal Report
            Dim rptPath As String = "D:\UBA_HUB\UBA_HUB_PROJECT_FINALLLLLLLLLLLLLLLLL\UBA_HUB_PROJECT\UBA_HUB_PROJECT\UBA-Hub_Report.rpt"

            If Not IO.File.Exists(rptPath) Then
                MessageBox.Show("Report file not found at: " & rptPath, "Missing Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim rpt As New ReportDocument()
            rpt.Load(rptPath)
            rpt.SetDataSource(dt)

            ' === Force consistent layout ===
            rpt.PrintOptions.PaperSize = PaperSize.PaperA4
            rpt.PrintOptions.PaperOrientation = PaperOrientation.Portrait
            rpt.PrintOptions.PrinterName = "" ' Avoid using a physical printer

            ' === Optional PDF Export ===
            'Dim exportPath = "C:\UBA_Report_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".pdf"
            'Dim diskOpts As New DiskFileDestinationOptions With {
            '    .DiskFileName = exportPath
            '}
            'With rpt.ExportOptions
            '    .ExportDestinationType = ExportDestinationType.DiskFile
            '    .ExportFormatType = ExportFormatType.PortableDocFormat
            '    .DestinationOptions = diskOpts
            '    .FormatOptions = New PdfRtfWordFormatOptions()
            'End With
            'rpt.Export()
            'MessageBox.Show("Report exported to: " & exportPath, "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Show in viewer
            Dim viewer As New CrystalReportViewerForm(rpt)
            viewer.Show()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
