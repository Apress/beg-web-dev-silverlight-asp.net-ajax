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

namespace SecondWorkflowApp
{
	public sealed partial class Workflow1: SequentialWorkflowActivity
	{
		public Workflow1()
		{
			InitializeComponent();
		}

        private void codeActivity1_ExecuteCode(object sender, EventArgs e)
        {
            Console.WriteLine("You say you are " + this.ageVal + " years old? I don't believe you!");
            Console.ReadLine();
        }

        private void codeActivity2_ExecuteCode(object sender, EventArgs e)
        {
            Console.WriteLine("Hello World to you who is " + this.ageVal + " years old!");
            Console.ReadLine();
        }


	}

}
