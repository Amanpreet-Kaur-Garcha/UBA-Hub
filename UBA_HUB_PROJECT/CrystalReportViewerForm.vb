' CrystalReportViewerForm.vb
Imports CrystalDecisions.CrystalReports.Engine

Public Class CrystalReportViewerForm
    Public Sub New(ByVal report As ReportDocument)
        InitializeComponent()
        CrystalReportViewer1.ReportSource = report
        CrystalReportViewer1.Zoom(100)
    End Sub
End Class
