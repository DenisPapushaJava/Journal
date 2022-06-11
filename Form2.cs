/*
 * Создано в SharpDevelop.
 * Пользователь: denis
 * Дата: 10.04.2022
 * Время: 14:10
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Jornal
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form_BLCB : Form
	{
		public Form_BLCB()
		{
			InitializeComponent();	
		}
		public string tBNumSpec {
			get {
				return this.textBox_NumberOfSpec.Text;
			}
			set {
				this.textBox_NumberOfSpec.Text = value;
					
			}
		}
		public string tBBLCB {
			get {
				return this.textBox_NumBLCB.Text;
			}
			set {
				this.textBox_NumBLCB.Text = value;
			}
		
		}
		
		void Form_BLCBLoad(object sender, EventArgs e)
		{
			AcceptButton = button_addBLCB;
			CancelButton = button_CancelBLCB;
		}
		void Button_addBLCBClick(object sender, EventArgs e)
		{
			if (textBox_NumBLCB.Text.Length == 0 || textBox_NumberOfSpec.Text.Length == 0) {
				MessageBox.Show("Поля не должны быть пустыми", "Что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} else {
				DialogResult = DialogResult.OK;
				Close();
			}
			
			
	
		}
		void Button_RunBLCBClick(object sender, EventArgs e)
		{
			bool flag = false;
	
			if (textBox_BLCB_Run.Text.Length == 0) {
				MessageBox.Show("Поле не должно быть пустым", "Что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Information);	
			} else {
				//Поиск № Спецификации_______________________________________________________
				
				int countSp = Regex.Split((textBox_BLCB_Run.Text), @"\W+").Count(x => x == "Спецификация");
				
				//MessageBox.Show(Convert.ToString(countSp));
				
				string[] numS = Regex.Split(textBox_BLCB_Run.Text, "Спецификация № ");
				//for (int i = 1; i <= numS.Length - 1; ++i) {
				int i = 1;
				int loopCount = 0;
		loopBlcb:	
				
				button_Prev.Click += Button_RunBLCBClick;
				button_Next.Click += Button_RunBLCBClick;
				
			
			
				if (numS.Length < 2) {
					flag = true;
				} 
				
				
				else {
					
					
					if ((sender as Button).Name == "button_Prev"&& i>2) {
						i = i - 1;
					
					} else if (Convert.ToString((sender as Button).Name) == "button_Next"&& i< numS.Length) {
						i = i + 1;
					}	
					
					string[] numS1 = Regex.Split(numS[i], @"-");
					
					
				
				
					int k = 100 / countSp;
					progressBar_CountSpec.Step = k;
					progressBar_CountSpec.Value = i * k;
					
					if (numS1.Length < 2) {
						flag = true;
					}
					
					if (numS1[3] == "") {
						
						textBox_NumberOfSpec.Text = numS1[1] + numS1[2] + "-" + numS1[4];	
					} else {
						textBox_NumberOfSpec.Text = numS1[1] + numS1[2] + "-" + numS1[3];
					}
				}
				
				

				
				
				
				//Поиск БЛЦБ________________________________________________________________________
				string[] BLCB = Regex.Split(textBox_BLCB_Run.Text, "Заявка на отгрузку ");
				if (BLCB.Length < 2) {
					flag = true;
				} else {
					string[] BLCB1 = Regex.Split(BLCB[1], " ");
					if (BLCB1.Length < 2) {
						flag = true;
					} else {
						textBox_NumBLCB.Text = "№ " + BLCB1[1];
					}			
				
				}
				if (flag) {
					MessageBox.Show("Кажется этот текст не из Заявки на отгрузку", "Что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			if(numS.Length>=3){
					
				}
				
				if (loopCount>0) {
					loopCount++;
					goto loopBlcb;
				}
				
			}
			
		}
		void Button_ClearBLCBClick(object sender, EventArgs e)
		{
			textBox_BLCB_Run.Text = "";
		}
		
		
		
		
			
	}
}
