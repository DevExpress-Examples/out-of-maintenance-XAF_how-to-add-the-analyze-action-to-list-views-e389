Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Xpo
Imports System.ComponentModel
Imports DevExpress.ExpressApp.Web

Namespace HowToAddAnalyzeAction.Web
    Partial Public Class HowToAddAnalyzeActionAspNetApplication
        Inherits WebApplication

        Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
            args.ObjectSpaceProvider = New XPObjectSpaceProvider(args.ConnectionString, args.Connection, True)
        End Sub
        Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
        Private module2 As DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule
        Private module3 As HowToAddAnalyzeAction.Module.HowToAddAnalyzeActionModule
        Private module4 As HowToAddAnalyzeAction.Module.Web.HowToAddAnalyzeActionAspNetModule
        Private securityModule1 As DevExpress.ExpressApp.Security.SecurityModule
        Private securitySimple1 As DevExpress.ExpressApp.Security.SecuritySimple
        Private module6 As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
        Private authenticationActiveDirectory1 As DevExpress.ExpressApp.Security.AuthenticationActiveDirectory
        Private sqlConnection1 As System.Data.SqlClient.SqlConnection
        Private pivotChartAspNetModule1 As DevExpress.ExpressApp.PivotChart.Web.PivotChartAspNetModule
        Private howToAddAnalyzeActionModule1 As HowToAddAnalyzeAction.Module.HowToAddAnalyzeActionModule
        Private pivotChartModuleBase1 As DevExpress.ExpressApp.PivotChart.PivotChartModuleBase
        Private module5 As DevExpress.ExpressApp.Validation.ValidationModule

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub HowToAddAnalyzeActionAspNetApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
            If System.Diagnostics.Debugger.IsAttached Then
                e.Updater.Update()
                e.Handled = True
            Else
                Throw New InvalidOperationException("The application cannot connect to the specified database, because the latter doesn't exist or its version is older than that of the application." & vbCrLf & "The automatical update is disabled, because the application was started without debugging." & vbCrLf & "You should start the application under Visual Studio, or modify the " & "source code of the 'DatabaseVersionMismatch' event handler to enable automatic database update, " & "or manually create a database with the help of the 'DBUpdater' tool.")
            End If
        End Sub

        Private Sub InitializeComponent()
            Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
            Me.module2 = New DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule()
            Me.module3 = New HowToAddAnalyzeAction.Module.HowToAddAnalyzeActionModule()
            Me.module4 = New HowToAddAnalyzeAction.Module.Web.HowToAddAnalyzeActionAspNetModule()
            Me.module5 = New DevExpress.ExpressApp.Validation.ValidationModule()
            Me.module6 = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule()
            Me.securityModule1 = New DevExpress.ExpressApp.Security.SecurityModule()
            Me.securitySimple1 = New DevExpress.ExpressApp.Security.SecuritySimple()
            Me.authenticationActiveDirectory1 = New DevExpress.ExpressApp.Security.AuthenticationActiveDirectory()
            Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection()
            Me.pivotChartAspNetModule1 = New DevExpress.ExpressApp.PivotChart.Web.PivotChartAspNetModule()
            Me.howToAddAnalyzeActionModule1 = New HowToAddAnalyzeAction.Module.HowToAddAnalyzeActionModule()
            Me.pivotChartModuleBase1 = New DevExpress.ExpressApp.PivotChart.PivotChartModuleBase()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' module3
            ' 
            Me.module3.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.Person))
            ' 
            ' module5
            ' 
            Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleSetValidationResult))
            Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleSetValidationResultItem))
            Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RulePropertyValueProperties))
            Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleRequiredFieldProperties))
            Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleFromBoolPropertyProperties))
            Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleRangeProperties))
            Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleValueComparisonProperties))
            Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleStringComparisonProperties))
            Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleRegularExpressionProperties))
            Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleCriteriaProperties))
            Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleSearchObjectProperties))
            Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleObjectExistsProperties))
            Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleUniqueValueProperties))
            Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleIsReferencedProperties))
            ' 
            ' securitySimple1
            ' 
            Me.securitySimple1.Authentication = Me.authenticationActiveDirectory1
            Me.securitySimple1.UserType = GetType(DevExpress.Persistent.BaseImpl.BasicUser)
            ' 
            ' authenticationActiveDirectory1
            ' 
            Me.authenticationActiveDirectory1.CreateUserAutomatically = True
            Me.authenticationActiveDirectory1.UserType = GetType(DevExpress.Persistent.BaseImpl.BasicUser)
            ' 
            ' sqlConnection1
            ' 
            Me.sqlConnection1.ConnectionString = "Data Source=(local);Initial Catalog=HowToAddAnalyzeAction;Integrated Security=SSP" & "I;Pooling=false"
            Me.sqlConnection1.FireInfoMessageEventOnUserErrors = False
            ' 
            ' howToAddAnalyzeActionModule1
            ' 
            Me.howToAddAnalyzeActionModule1.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.Person))
            ' 
            ' HowToAddAnalyzeActionAspNetApplication
            ' 
            Me.ApplicationName = "HowToAddAnalyzeAction"
            Me.Connection = Me.sqlConnection1
            Me.Modules.Add(Me.module1)
            Me.Modules.Add(Me.module2)
            Me.Modules.Add(Me.module6)
            Me.Modules.Add(Me.module3)
            Me.Modules.Add(Me.module4)
            Me.Modules.Add(Me.module5)
            Me.Modules.Add(Me.securityModule1)
            Me.Modules.Add(Me.pivotChartModuleBase1)
            Me.Modules.Add(Me.pivotChartAspNetModule1)
            Me.Security = Me.securitySimple1
'            Me.DatabaseVersionMismatch += New System.EventHandler(Of DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs)(Me.HowToAddAnalyzeActionAspNetApplication_DatabaseVersionMismatch)
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
    End Class
End Namespace
