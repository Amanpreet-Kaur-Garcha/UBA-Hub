Namespace My
    Partial Friend Class MyApplication

        ' No need to override OnStartup for DPI settings in .NET Framework.
        ' DPI awareness is handled through the app.manifest file.

        ' But if you still want to handle startup logic, do it like this:
        Protected Overrides Function OnStartup(ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) As Boolean
            ' Optional: Custom logic before main form shows
            ' (No SetHighDpiMode here, as it's unsupported in .NET Framework)

            Return MyBase.OnStartup(e)
        End Function

    End Class
End Namespace
