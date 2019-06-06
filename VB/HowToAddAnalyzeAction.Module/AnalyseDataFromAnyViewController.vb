Imports DevExpress.ExpressApp.DC
Imports System.ComponentModel
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.PivotChart
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.ExpressApp.Model

Namespace HowToAddAnalyzeAction.Module
    Partial Public Class AnalyseDataFromAnyViewController
        Inherits ViewController

        Public Sub New()
            InitializeComponent()
            RegisterActions(components)
        End Sub

        Private Sub AnalyseDataFromAnyViewController_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Activated
            analyseDataAction.Active("VisibleInReports") = CType(View.Model.Application.BOModel.GetClass(View.ObjectTypeInfo.Type), IModelClassReportsVisibility).IsVisibleInReports
        End Sub

        Private Sub analyseDataAction_Execute(ByVal sender As Object, ByVal e As SimpleActionExecuteEventArgs) Handles analyseDataAction.Execute
            Dim objectSpaceInternal As IObjectSpace = Application.CreateObjectSpace(GetType(Analysis))
            Dim obj As Analysis = objectSpaceInternal.CreateObject(Of Analysis)()
            obj.DataType = View.ObjectTypeInfo.Type
            obj.Name = "Analysis: " & View.Caption & " " & Date.Now.ToString()
            e.ShowViewParameters.CreatedView = Application.CreateDetailView(objectSpaceInternal, obj)
            e.ShowViewParameters.TargetWindow = TargetWindow.Default
            e.ShowViewParameters.Context = TemplateContext.View
        End Sub
    End Class
    Public Class AssignAnalysisDataSourceViewController
        Inherits AnalysisDataBindController

        Protected Overrides Sub OnActivated()
            MyBase.OnActivated()
            Dim obj As Analysis = TryCast(View.CurrentObject, Analysis)
            'Allow data source loading if the ObjectTypeName property is specified
            If obj.ObjectTypeName IsNot Nothing Then
                analysisEditor.IsDataSourceReady = True
                UpdateBindUnbindActionsState()
            End If
        End Sub
    End Class
End Namespace
