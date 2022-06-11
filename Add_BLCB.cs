
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Jornal
{
	/// <summary>
	/// Description of Add_BLCB.
	/// </summary>
	public partial class Add_BLCB : Form
	{
		public Add_BLCB()
		{
			
			InitializeComponent();			
			
		}
		public string LabelInfoBLCB {		
			get {
				return label_InfoBLCB.Text;
			}
			set {
				this.label_InfoBLCB.Text = value;
			}
		}
		public string NumberBLCB {
			get {
				return textBox_NumberBLCB.Text;
			}
			set {
				this.textBox_NumberBLCB.Text = value;
			}
		}
		void Add_BLCBLoad(object sender, EventArgs e)
		{
			AcceptButton = button_OK_BLCB;
			CancelButton = button_CancelAddBLCB;
		}
		void Button_OK_BLCBClick(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
