using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsapi.Shared;

namespace WinFormsapi
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private async void btnview_Click(object sender, EventArgs e)
		{
			
			var response=await RestHelper.GetAll();
			txtResponse.Text = RestHelper.formatjson(response);
			//txtResponse.Text = response;
		}
	}
}
