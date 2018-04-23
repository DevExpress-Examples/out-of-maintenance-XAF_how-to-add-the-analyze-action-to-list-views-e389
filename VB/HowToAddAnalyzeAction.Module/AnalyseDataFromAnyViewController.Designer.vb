Namespace HowToAddAnalyzeAction.Module
    Partial Public Class AnalyseDataFromAnyViewController
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.analyseDataAction = New DevExpress.ExpressApp.Actions.SimpleAction(Me.components)
            ' 
            ' analyseDataAction
            ' 
            Me.analyseDataAction.Caption = "Analyze"
            Me.analyseDataAction.Category = "RecordEdit"
            Me.analyseDataAction.Id = "AnalyzeData"
            Me.analyseDataAction.ImageName = "BO_Analysis"
'            Me.analyseDataAction.Execute += New DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(Me.analyseDataAction_Execute)
            ' 
            ' AnalyseDataFromAnyViewController
            ' 
            Me.TargetViewType = DevExpress.ExpressApp.ViewType.ListView
'            Me.Activated += New System.EventHandler(Me.AnalyseDataFromAnyViewController_Activated)

        End Sub

        #End Region

        Private WithEvents analyseDataAction As DevExpress.ExpressApp.Actions.SimpleAction
    End Class
End Namespace
