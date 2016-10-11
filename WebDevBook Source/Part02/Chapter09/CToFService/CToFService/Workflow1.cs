using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace CToFService
{
	public sealed partial class Workflow1: SequentialWorkflowActivity
	{
		public Workflow1()
		{
			InitializeComponent();
		}

        public static DependencyProperty _centigradeProperty = DependencyProperty.Register("_centigrade", typeof(System.Double), typeof(CToFService.Workflow1));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public Double _centigrade
        {
            get
            {
                return ((double)(base.GetValue(CToFService.Workflow1._centigradeProperty)));
            }
            set
            {
                base.SetValue(CToFService.Workflow1._centigradeProperty, value);
            }
        }

        public static DependencyProperty _farenheitProperty = DependencyProperty.Register("_farenheit", typeof(System.Double), typeof(CToFService.Workflow1));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public Double _farenheit
        {
            get
            {
                return ((double)(base.GetValue(CToFService.Workflow1._farenheitProperty)));
            }
            set
            {
                base.SetValue(CToFService.Workflow1._farenheitProperty, value);
            }
        }

        private void codeActivity1_ExecuteCode(object sender, EventArgs e)
        {
            _farenheit = 32 + ((9 * _centigrade) / 5);
        }
	}

}
