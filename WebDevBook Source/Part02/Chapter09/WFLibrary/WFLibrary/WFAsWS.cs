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

namespace WFLibrary
{
	public sealed partial class WFAsWS: SequentialWorkflowActivity
	{
		public WFAsWS()
		{
			InitializeComponent();
		}

        public static DependencyProperty webServiceInputActivity1_nInput1Property = DependencyProperty.Register("webServiceInputActivity1_nInput1", typeof(System.Int32), typeof(WFLibrary.WFAsWS));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public Int32 webServiceInputActivity1_nInput1
        {
            get
            {
                return ((int)(base.GetValue(WFLibrary.WFAsWS.webServiceInputActivity1_nInput1Property)));
            }
            set
            {
                base.SetValue(WFLibrary.WFAsWS.webServiceInputActivity1_nInput1Property, value);
            }
        }

        public static DependencyProperty webServiceInputActivity1_InputReceived1Event = DependencyProperty.Register("webServiceInputActivity1_InputReceived1", typeof(System.EventHandler), typeof(WFLibrary.WFAsWS));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Handlers")]
        public event EventHandler webServiceInputActivity1_InputReceived1
        {
            add
            {
                base.AddHandler(webServiceInputActivity1_InputReceived1Event, value);
            }
            remove
            {
                base.RemoveHandler(webServiceInputActivity1_InputReceived1Event, value);
            }
        }

        public static DependencyProperty webServiceInputActivity1_Roles1Property = DependencyProperty.Register("webServiceInputActivity1_Roles1", typeof(System.Workflow.Activities.WorkflowRoleCollection), typeof(WFLibrary.WFAsWS));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Activity")]
        public WorkflowRoleCollection webServiceInputActivity1_Roles1
        {
            get
            {
                return ((System.Workflow.Activities.WorkflowRoleCollection)(base.GetValue(WFLibrary.WFAsWS.webServiceInputActivity1_Roles1Property)));
            }
            set
            {
                base.SetValue(WFLibrary.WFAsWS.webServiceInputActivity1_Roles1Property, value);
            }
        }

        public static DependencyProperty _ageProperty = DependencyProperty.Register("_age", typeof(System.Int32), typeof(WFLibrary.WFAsWS));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public Int32 _age
        {
            get
            {
                return ((int)(base.GetValue(WFLibrary.WFAsWS._ageProperty)));
            }
            set
            {
                base.SetValue(WFLibrary.WFAsWS._ageProperty, value);
            }
        }

        private void codeActivity1_ExecuteCode(object sender, EventArgs e)
        {

        }

        public static DependencyProperty _centigradeProperty = DependencyProperty.Register("_centigrade", typeof(System.Double), typeof(WFLibrary.WFAsWS));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public Double _centigrade
        {
            get
            {
                return ((double)(base.GetValue(WFLibrary.WFAsWS._centigradeProperty)));
            }
            set
            {
                base.SetValue(WFLibrary.WFAsWS._centigradeProperty, value);
            }
        }

        public static DependencyProperty _farenheitProperty = DependencyProperty.Register("_farenheit", typeof(System.Double), typeof(WFLibrary.WFAsWS));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public Double _farenheit
        {
            get
            {
                return ((double)(base.GetValue(WFLibrary.WFAsWS._farenheitProperty)));
            }
            set
            {
                base.SetValue(WFLibrary.WFAsWS._farenheitProperty, value);
            }
        }

        private void codeActivity1_ExecuteCode_1(object sender, EventArgs e)
        {
            _farenheit = ((9 * _centigrade) / 5) + 32;
        }
	}

}
