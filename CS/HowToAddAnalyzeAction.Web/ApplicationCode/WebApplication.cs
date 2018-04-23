using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.ExpressApp.Web;

namespace HowToAddAnalyzeAction.Web {
	public partial class HowToAddAnalyzeActionAspNetApplication : WebApplication {
        protected override void CreateDefaultObjectSpaceProvider(CreateCustomObjectSpaceProviderEventArgs args) {
            args.ObjectSpaceProvider = new XPObjectSpaceProvider(args.ConnectionString, args.Connection, true);
        }
		private DevExpress.ExpressApp.SystemModule.SystemModule module1;
		private DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule module2;
		private HowToAddAnalyzeAction.Module.HowToAddAnalyzeActionModule module3;
		private HowToAddAnalyzeAction.Module.Web.HowToAddAnalyzeActionAspNetModule module4;
		private DevExpress.ExpressApp.Security.SecurityModule securityModule1;
		private DevExpress.ExpressApp.Security.SecuritySimple securitySimple1;
		private DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule module6;
		private DevExpress.ExpressApp.Security.AuthenticationActiveDirectory authenticationActiveDirectory1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private DevExpress.ExpressApp.PivotChart.Web.PivotChartAspNetModule pivotChartAspNetModule1;
		private HowToAddAnalyzeAction.Module.HowToAddAnalyzeActionModule howToAddAnalyzeActionModule1;
		private DevExpress.ExpressApp.PivotChart.PivotChartModuleBase pivotChartModuleBase1;
		private DevExpress.ExpressApp.Validation.ValidationModule module5;

		public HowToAddAnalyzeActionAspNetApplication() {
			InitializeComponent();
		}

		private void HowToAddAnalyzeActionAspNetApplication_DatabaseVersionMismatch(object sender, DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs e) {
			if(System.Diagnostics.Debugger.IsAttached) {
				e.Updater.Update();
				e.Handled = true;
			}
			else {
				throw new InvalidOperationException(
					"The application cannot connect to the specified database, because the latter doesn't exist or its version is older than that of the application.\r\n" +
					"The automatical update is disabled, because the application was started without debugging.\r\n" +
					"You should start the application under Visual Studio, or modify the " +
					"source code of the 'DatabaseVersionMismatch' event handler to enable automatic database update, " +
					"or manually create a database with the help of the 'DBUpdater' tool.");
			}
		}

		private void InitializeComponent() {
			this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
			this.module2 = new DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule();
			this.module3 = new HowToAddAnalyzeAction.Module.HowToAddAnalyzeActionModule();
			this.module4 = new HowToAddAnalyzeAction.Module.Web.HowToAddAnalyzeActionAspNetModule();
			this.module5 = new DevExpress.ExpressApp.Validation.ValidationModule();
			this.module6 = new DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule();
			this.securityModule1 = new DevExpress.ExpressApp.Security.SecurityModule();
			this.securitySimple1 = new DevExpress.ExpressApp.Security.SecuritySimple();
			this.authenticationActiveDirectory1 = new DevExpress.ExpressApp.Security.AuthenticationActiveDirectory();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.pivotChartAspNetModule1 = new DevExpress.ExpressApp.PivotChart.Web.PivotChartAspNetModule();
			this.howToAddAnalyzeActionModule1 = new HowToAddAnalyzeAction.Module.HowToAddAnalyzeActionModule();
			this.pivotChartModuleBase1 = new DevExpress.ExpressApp.PivotChart.PivotChartModuleBase();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// module3
			// 
			this.module3.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.BaseImpl.Person));
			// 
			// module5
			// 
			this.module5.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.Validation.RuleSetValidationResult));
			this.module5.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.Validation.RuleSetValidationResultItem));
			this.module5.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.Validation.RulePropertyValueProperties));
			this.module5.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.Validation.RuleRequiredFieldProperties));
			this.module5.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.Validation.RuleFromBoolPropertyProperties));
			this.module5.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.Validation.RuleRangeProperties));
			this.module5.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.Validation.RuleValueComparisonProperties));
			this.module5.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.Validation.RuleStringComparisonProperties));
			this.module5.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.Validation.RuleRegularExpressionProperties));
			this.module5.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.Validation.RuleCriteriaProperties));
			this.module5.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.Validation.RuleSearchObjectProperties));
			this.module5.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.Validation.RuleObjectExistsProperties));
			this.module5.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.Validation.RuleUniqueValueProperties));
			this.module5.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.Validation.RuleIsReferencedProperties));
			// 
			// securitySimple1
			// 
			this.securitySimple1.Authentication = this.authenticationActiveDirectory1;
			this.securitySimple1.UserType = typeof(DevExpress.Persistent.BaseImpl.BasicUser);
			// 
			// authenticationActiveDirectory1
			// 
			this.authenticationActiveDirectory1.CreateUserAutomatically = true;
			this.authenticationActiveDirectory1.UserType = typeof(DevExpress.Persistent.BaseImpl.BasicUser);
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "Data Source=(local);Initial Catalog=HowToAddAnalyzeAction;Integrated Security=SSP" +
				"I;Pooling=false";
			this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
			// 
			// howToAddAnalyzeActionModule1
			// 
			this.howToAddAnalyzeActionModule1.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.BaseImpl.Person));
			// 
			// HowToAddAnalyzeActionAspNetApplication
			// 
			this.ApplicationName = "HowToAddAnalyzeAction";
			this.Connection = this.sqlConnection1;
			this.Modules.Add(this.module1);
			this.Modules.Add(this.module2);
			this.Modules.Add(this.module6);
			this.Modules.Add(this.module3);
			this.Modules.Add(this.module4);
			this.Modules.Add(this.module5);
			this.Modules.Add(this.securityModule1);
			this.Modules.Add(this.pivotChartModuleBase1);
			this.Modules.Add(this.pivotChartAspNetModule1);
			this.Security = this.securitySimple1;
			this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>(this.HowToAddAnalyzeActionAspNetApplication_DatabaseVersionMismatch);
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}
	}
}
