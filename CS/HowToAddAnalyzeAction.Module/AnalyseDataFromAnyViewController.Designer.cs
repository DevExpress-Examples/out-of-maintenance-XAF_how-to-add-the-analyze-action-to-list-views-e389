namespace HowToAddAnalyzeAction.Module {
	partial class AnalyseDataFromAnyViewController {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.analyseDataAction = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
			// 
			// analyseDataAction
			// 
			this.analyseDataAction.Caption = "Analyze";
			this.analyseDataAction.Category = "RecordEdit";
			this.analyseDataAction.Id = "AnalyzeData";
			this.analyseDataAction.ImageName = "BO_Analysis";
			this.analyseDataAction.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.analyseDataAction_Execute);
			// 
			// AnalyseDataFromAnyViewController
			// 
			this.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;
			this.Activated += new System.EventHandler(this.AnalyseDataFromAnyViewController_Activated);

		}

		#endregion

		private DevExpress.ExpressApp.Actions.SimpleAction analyseDataAction;
	}
}
