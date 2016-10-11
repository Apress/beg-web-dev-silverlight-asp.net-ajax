using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace WFLibrary
{
    public interface IWFAsWS
    {
        double CToF(double nInput);
    }
        
	partial class WFAsWS
	{
		#region Designer generated code
		
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
		private void InitializeComponent()
		{
            this.CanModifyActivities = true;
            System.Workflow.ComponentModel.ActivityBind activitybind1 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding1 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.ComponentModel.ActivityBind activitybind2 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding2 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            this.webServiceOutputActivity1 = new System.Workflow.Activities.WebServiceOutputActivity();
            this.codeActivity1 = new System.Workflow.Activities.CodeActivity();
            this.webServiceInputActivity1 = new System.Workflow.Activities.WebServiceInputActivity();
            // 
            // webServiceOutputActivity1
            // 
            this.webServiceOutputActivity1.InputActivityName = "webServiceInputActivity1";
            this.webServiceOutputActivity1.Name = "webServiceOutputActivity1";
            activitybind1.Name = "WFAsWS";
            activitybind1.Path = "_farenheit";
            workflowparameterbinding1.ParameterName = "(ReturnValue)";
            workflowparameterbinding1.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            this.webServiceOutputActivity1.ParameterBindings.Add(workflowparameterbinding1);
            // 
            // codeActivity1
            // 
            this.codeActivity1.Name = "codeActivity1";
            this.codeActivity1.ExecuteCode += new System.EventHandler(this.codeActivity1_ExecuteCode_1);
            // 
            // webServiceInputActivity1
            // 
            this.webServiceInputActivity1.InterfaceType = typeof(WFLibrary.IWFAsWS);
            this.webServiceInputActivity1.IsActivating = true;
            this.webServiceInputActivity1.MethodName = "CToF";
            this.webServiceInputActivity1.Name = "webServiceInputActivity1";
            activitybind2.Name = "WFAsWS";
            activitybind2.Path = "_centigrade";
            workflowparameterbinding2.ParameterName = "nInput";
            workflowparameterbinding2.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
            this.webServiceInputActivity1.ParameterBindings.Add(workflowparameterbinding2);
            // 
            // WFAsWS
            // 
            this.Activities.Add(this.webServiceInputActivity1);
            this.Activities.Add(this.codeActivity1);
            this.Activities.Add(this.webServiceOutputActivity1);
            this.Name = "WFAsWS";
            this.CanModifyActivities = false;

		}

		#endregion

        private CodeActivity codeActivity1;
        private WebServiceOutputActivity webServiceOutputActivity1;
        private WebServiceInputActivity webServiceInputActivity1;










    }
}
