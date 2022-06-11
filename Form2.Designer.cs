/*
 * Создано в SharpDevelop.
 * Пользователь: denis
 * Дата: 10.04.2022
 * Время: 14:10
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Jornal
{
	partial class Form_BLCB
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		
		private System.Windows.Forms.TextBox textBox_BLCB_Run;
		private System.Windows.Forms.Button button_RunBLCB;
		private System.Windows.Forms.Label label_BLCB_past;
		private System.Windows.Forms.TextBox textBox_NumberOfSpec;
		private System.Windows.Forms.Label label_Path;
		private System.Windows.Forms.TextBox textBox_NumBLCB;
		private System.Windows.Forms.Label label_NumSpec;
		private System.Windows.Forms.Label label_BLCB;
		private System.Windows.Forms.Button button_addBLCB;
		private System.Windows.Forms.Button button_CancelBLCB;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button_ClearBLCB;
		private System.Windows.Forms.Button button_Next;
		private System.Windows.Forms.Button button_Prev;
		public System.Windows.Forms.ProgressBar progressBar_CountSpec;
		
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BLCB));
			this.textBox_BLCB_Run = new System.Windows.Forms.TextBox();
			this.button_RunBLCB = new System.Windows.Forms.Button();
			this.label_BLCB_past = new System.Windows.Forms.Label();
			this.textBox_NumberOfSpec = new System.Windows.Forms.TextBox();
			this.label_Path = new System.Windows.Forms.Label();
			this.textBox_NumBLCB = new System.Windows.Forms.TextBox();
			this.label_NumSpec = new System.Windows.Forms.Label();
			this.label_BLCB = new System.Windows.Forms.Label();
			this.button_addBLCB = new System.Windows.Forms.Button();
			this.button_CancelBLCB = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.progressBar_CountSpec = new System.Windows.Forms.ProgressBar();
			this.button_Next = new System.Windows.Forms.Button();
			this.button_Prev = new System.Windows.Forms.Button();
			this.button_ClearBLCB = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox_BLCB_Run
			// 
			this.textBox_BLCB_Run.Location = new System.Drawing.Point(12, 49);
			this.textBox_BLCB_Run.Multiline = true;
			this.textBox_BLCB_Run.Name = "textBox_BLCB_Run";
			this.textBox_BLCB_Run.Size = new System.Drawing.Size(392, 155);
			this.textBox_BLCB_Run.TabIndex = 0;
			// 
			// button_RunBLCB
			// 
			this.button_RunBLCB.Location = new System.Drawing.Point(249, 227);
			this.button_RunBLCB.Name = "button_RunBLCB";
			this.button_RunBLCB.Size = new System.Drawing.Size(144, 34);
			this.button_RunBLCB.TabIndex = 1;
			this.button_RunBLCB.Text = "Обработать";
			this.button_RunBLCB.UseVisualStyleBackColor = true;
			this.button_RunBLCB.Click += new System.EventHandler(this.Button_RunBLCBClick);
			// 
			// label_BLCB_past
			// 
			this.label_BLCB_past.Location = new System.Drawing.Point(40, 23);
			this.label_BLCB_past.Name = "label_BLCB_past";
			this.label_BLCB_past.Size = new System.Drawing.Size(303, 23);
			this.label_BLCB_past.TabIndex = 2;
			this.label_BLCB_past.Text = "Вставить сюда текст из Заявки на отгрузку PDF";
			// 
			// textBox_NumberOfSpec
			// 
			this.textBox_NumberOfSpec.Location = new System.Drawing.Point(3, 31);
			this.textBox_NumberOfSpec.Name = "textBox_NumberOfSpec";
			this.textBox_NumberOfSpec.Size = new System.Drawing.Size(125, 20);
			this.textBox_NumberOfSpec.TabIndex = 3;
			// 
			// label_Path
			// 
			this.label_Path.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label_Path.Location = new System.Drawing.Point(153, 34);
			this.label_Path.Name = "label_Path";
			this.label_Path.Size = new System.Drawing.Size(87, 20);
			this.label_Path.TabIndex = 4;
			this.label_Path.Text = "<<<------------->>>";
			// 
			// textBox_NumBLCB
			// 
			this.textBox_NumBLCB.Location = new System.Drawing.Point(269, 31);
			this.textBox_NumBLCB.Name = "textBox_NumBLCB";
			this.textBox_NumBLCB.Size = new System.Drawing.Size(121, 20);
			this.textBox_NumBLCB.TabIndex = 5;
			// 
			// label_NumSpec
			// 
			this.label_NumSpec.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label_NumSpec.Location = new System.Drawing.Point(14, 10);
			this.label_NumSpec.Name = "label_NumSpec";
			this.label_NumSpec.Size = new System.Drawing.Size(100, 18);
			this.label_NumSpec.TabIndex = 6;
			this.label_NumSpec.Text = "№ Спецификации";
			// 
			// label_BLCB
			// 
			this.label_BLCB.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label_BLCB.Location = new System.Drawing.Point(269, 10);
			this.label_BLCB.Name = "label_BLCB";
			this.label_BLCB.Size = new System.Drawing.Size(100, 18);
			this.label_BLCB.TabIndex = 7;
			this.label_BLCB.Text = "№ БЛЦБ";
			// 
			// button_addBLCB
			// 
			this.button_addBLCB.Location = new System.Drawing.Point(12, 433);
			this.button_addBLCB.Name = "button_addBLCB";
			this.button_addBLCB.Size = new System.Drawing.Size(144, 34);
			this.button_addBLCB.TabIndex = 8;
			this.button_addBLCB.Text = "Добавить БЛЦБ";
			this.button_addBLCB.UseVisualStyleBackColor = true;
			this.button_addBLCB.Click += new System.EventHandler(this.Button_addBLCBClick);
			// 
			// button_CancelBLCB
			// 
			this.button_CancelBLCB.Location = new System.Drawing.Point(249, 433);
			this.button_CancelBLCB.Name = "button_CancelBLCB";
			this.button_CancelBLCB.Size = new System.Drawing.Size(144, 34);
			this.button_CancelBLCB.TabIndex = 9;
			this.button_CancelBLCB.Text = "Выход";
			this.button_CancelBLCB.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.progressBar_CountSpec);
			this.panel1.Controls.Add(this.button_Next);
			this.panel1.Controls.Add(this.button_Prev);
			this.panel1.Controls.Add(this.textBox_NumBLCB);
			this.panel1.Controls.Add(this.label_BLCB);
			this.panel1.Controls.Add(this.textBox_NumberOfSpec);
			this.panel1.Controls.Add(this.label_Path);
			this.panel1.Controls.Add(this.label_NumSpec);
			this.panel1.Location = new System.Drawing.Point(12, 304);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(393, 110);
			this.panel1.TabIndex = 10;
			// 
			// progressBar_CountSpec
			// 
			this.progressBar_CountSpec.Location = new System.Drawing.Point(3, 53);
			this.progressBar_CountSpec.Name = "progressBar_CountSpec";
			this.progressBar_CountSpec.Size = new System.Drawing.Size(125, 14);
			this.progressBar_CountSpec.TabIndex = 9;
			// 
			// button_Next
			// 
			this.button_Next.Location = new System.Drawing.Point(74, 73);
			this.button_Next.Name = "button_Next";
			this.button_Next.Size = new System.Drawing.Size(40, 23);
			this.button_Next.TabIndex = 8;
			this.button_Next.Tag = "inc";
			this.button_Next.Text = ">>";
			this.button_Next.UseVisualStyleBackColor = true;
			// 
			// button_Prev
			// 
			this.button_Prev.Location = new System.Drawing.Point(14, 73);
			this.button_Prev.Name = "button_Prev";
			this.button_Prev.Size = new System.Drawing.Size(40, 23);
			this.button_Prev.TabIndex = 7;
			this.button_Prev.Tag = "dec";
			this.button_Prev.Text = "<<";
			this.button_Prev.UseVisualStyleBackColor = true;
			// 
			// button_ClearBLCB
			// 
			this.button_ClearBLCB.BackColor = System.Drawing.SystemColors.Control;
			this.button_ClearBLCB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_ClearBLCB.BackgroundImage")));
			this.button_ClearBLCB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button_ClearBLCB.ForeColor = System.Drawing.SystemColors.Control;
			this.button_ClearBLCB.Location = new System.Drawing.Point(185, 227);
			this.button_ClearBLCB.Name = "button_ClearBLCB";
			this.button_ClearBLCB.Size = new System.Drawing.Size(35, 34);
			this.button_ClearBLCB.TabIndex = 11;
			this.button_ClearBLCB.Text = " ";
			this.button_ClearBLCB.UseVisualStyleBackColor = false;
			this.button_ClearBLCB.Click += new System.EventHandler(this.Button_ClearBLCBClick);
			// 
			// Form_BLCB
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 491);
			this.Controls.Add(this.button_ClearBLCB);
			this.Controls.Add(this.button_CancelBLCB);
			this.Controls.Add(this.button_addBLCB);
			this.Controls.Add(this.label_BLCB_past);
			this.Controls.Add(this.button_RunBLCB);
			this.Controls.Add(this.textBox_BLCB_Run);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximumSize = new System.Drawing.Size(430, 530);
			this.MinimumSize = new System.Drawing.Size(430, 530);
			this.Name = "Form_BLCB";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Добавить БЛЦБ";
			this.Load += new System.EventHandler(this.Form_BLCBLoad);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
