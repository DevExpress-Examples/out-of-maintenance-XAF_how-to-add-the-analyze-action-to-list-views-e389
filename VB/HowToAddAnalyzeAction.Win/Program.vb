Imports System.Configuration

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Win
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl

Namespace HowToAddAnalyzeAction.Win
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            EditModelPermission.AlwaysGranted = System.Diagnostics.Debugger.IsAttached
            Dim winApplication As New HowToAddAnalyzeActionWindowsFormsApplication()
            If ConfigurationManager.ConnectionStrings("ConnectionString") IsNot Nothing Then
                winApplication.ConnectionString = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
            End If
            Try
    DevExpress.ExpressApp.Xpo.InMemoryDataStoreProvider.Register()
                winApplication.ConnectionString = DevExpress.ExpressApp.Xpo.InMemoryDataStoreProvider.ConnectionString
                winApplication.Setup()
                winApplication.Start()
            Catch e As Exception
                winApplication.HandleException(e)
            End Try
        End Sub
    End Class
End Namespace
