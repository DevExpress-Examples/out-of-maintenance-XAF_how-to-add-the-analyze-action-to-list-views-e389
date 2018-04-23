using DevExpress.ExpressApp.DC;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.PivotChart;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Model;

namespace HowToAddAnalyzeAction.Module {
	public partial class AnalyseDataFromAnyViewController : ViewController {
		public AnalyseDataFromAnyViewController() {
			InitializeComponent();
			RegisterActions(components);
		}

		private void AnalyseDataFromAnyViewController_Activated(object sender, EventArgs e) {
			analyseDataAction.Active["VisibleInReports"] =
		                    ((IModelClassReportsVisibility)View.Model.Application.BOModel.GetClass(
                                                           View.ObjectTypeInfo.Type)).IsVisibleInReports;
		}

		private void analyseDataAction_Execute(object sender, SimpleActionExecuteEventArgs e) {
			IObjectSpace objectSpaceInternal = Application.CreateObjectSpace();
			Analysis obj = objectSpaceInternal.CreateObject<Analysis>();
			obj.DataType = View.ObjectTypeInfo.Type;
			obj.Name = "Analysis: " + View.Caption + " " + DateTime.Now.ToString();
			e.ShowViewParameters.CreatedView = Application.CreateDetailView(objectSpaceInternal, obj);
			e.ShowViewParameters.TargetWindow = TargetWindow.Default;
			e.ShowViewParameters.Context = TemplateContext.View;
		}
	}
	public class AssignAnalysisDataSourceViewController : AnalysisDataBindController {
		protected override void OnActivated() {
			base.OnActivated();
			Analysis obj = View.CurrentObject as Analysis;
			//Allow data source loading if the ObjectTypeName property is specified
			if(obj.ObjectTypeName != null) {
				analysisEditor.IsDataSourceReady = true;
				UpdateBindUnbindActionsState();
			}
		}
	}
}
