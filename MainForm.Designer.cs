/*
 * Создано в SharpDevelop.
 * Пользователь: denis
 * Дата: 23.03.2022
 * Время: 21:20
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Jornal
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button_Update;
		private System.Windows.Forms.Button button_NewOrder;
		private System.Windows.Forms.Button button_Edit;
		private System.Windows.Forms.Button button_Delete;
		private System.Windows.Forms.DataGridView Grid_Order;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStrip_Delete;
		private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
		private System.Windows.Forms.Button button_CopyResult;
		private System.Windows.Forms.Button button_Result;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ToolStripMenuItem результатToolStripMenuItem;
		private System.Windows.Forms.RichTextBox richTextBox_Result;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem добавитьБЛЦБToolStripMenuItem;
		private System.Windows.Forms.Button button_ColorFinish;
		private System.Windows.Forms.Button button_ColorInWork;
		private System.Windows.Forms.Button button_ColorDialog;
		private System.Windows.Forms.ColorDialog colorDialog;
		private System.Windows.Forms.Timer timer_Color;
		private System.Windows.Forms.Button button_ClearColor;
		private System.Windows.Forms.CheckBox checkBox_Finished;
		private System.Windows.Forms.CheckBox checkBox_InWork;
		private System.Windows.Forms.CheckBox checkBox_DateDay;
		private System.Windows.Forms.ToolStripMenuItem цветToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem вРаботеToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem готовоToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem другойЦветToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem снятьВыделениеToolStripMenuItem;
		private System.Windows.Forms.TextBox textBox_Searh;
		private System.Windows.Forms.Button button_Searh;
		private System.Windows.Forms.CheckBox checkBox_StrictSearh;
		private System.Windows.Forms.Button button_Sent;
		private System.Windows.Forms.CheckBox checkBox_Sent;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem добавитьБЛЦБToolStripMenuItem1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.button_Update = new System.Windows.Forms.Button();
			this.button_NewOrder = new System.Windows.Forms.Button();
			this.button_Edit = new System.Windows.Forms.Button();
			this.button_Delete = new System.Windows.Forms.Button();
			this.Grid_Order = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStrip_Delete = new System.Windows.Forms.ToolStripSeparator();
			this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.результатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.вРаботеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.готовоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.другойЦветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.снятьВыделениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.добавитьБЛЦБToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.checkBox_Sent = new System.Windows.Forms.CheckBox();
			this.button_Sent = new System.Windows.Forms.Button();
			this.checkBox_StrictSearh = new System.Windows.Forms.CheckBox();
			this.textBox_Searh = new System.Windows.Forms.TextBox();
			this.button_Searh = new System.Windows.Forms.Button();
			this.checkBox_Finished = new System.Windows.Forms.CheckBox();
			this.checkBox_InWork = new System.Windows.Forms.CheckBox();
			this.checkBox_DateDay = new System.Windows.Forms.CheckBox();
			this.button_ClearColor = new System.Windows.Forms.Button();
			this.button_ColorDialog = new System.Windows.Forms.Button();
			this.button_ColorFinish = new System.Windows.Forms.Button();
			this.button_ColorInWork = new System.Windows.Forms.Button();
			this.richTextBox_Result = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button_Result = new System.Windows.Forms.Button();
			this.button_CopyResult = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.добавитьБЛЦБToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colorDialog = new System.Windows.Forms.ColorDialog();
			this.timer_Color = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.Grid_Order)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_Update
			// 
			this.button_Update.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button_Update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Update.BackgroundImage")));
			this.button_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_Update.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.button_Update.Location = new System.Drawing.Point(12, 32);
			this.button_Update.Name = "button_Update";
			this.button_Update.Size = new System.Drawing.Size(57, 58);
			this.button_Update.TabIndex = 0;
			this.button_Update.Text = " ";
			this.button_Update.UseVisualStyleBackColor = false;
			this.button_Update.Click += new System.EventHandler(this.Button_UpdateClick);
			// 
			// button_NewOrder
			// 
			this.button_NewOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button_NewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_NewOrder.Location = new System.Drawing.Point(85, 39);
			this.button_NewOrder.Name = "button_NewOrder";
			this.button_NewOrder.Size = new System.Drawing.Size(88, 45);
			this.button_NewOrder.TabIndex = 1;
			this.button_NewOrder.Text = "Новая заявка";
			this.button_NewOrder.UseVisualStyleBackColor = false;
			this.button_NewOrder.Click += new System.EventHandler(this.Button_NewOrderClick);
			// 
			// button_Edit
			// 
			this.button_Edit.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_Edit.Location = new System.Drawing.Point(180, 39);
			this.button_Edit.Name = "button_Edit";
			this.button_Edit.Size = new System.Drawing.Size(101, 45);
			this.button_Edit.TabIndex = 2;
			this.button_Edit.Text = "Редактировать";
			this.button_Edit.UseVisualStyleBackColor = false;
			this.button_Edit.Click += new System.EventHandler(this.Button_EditClick);
			// 
			// button_Delete
			// 
			this.button_Delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_Delete.Location = new System.Drawing.Point(287, 39);
			this.button_Delete.Name = "button_Delete";
			this.button_Delete.Size = new System.Drawing.Size(91, 45);
			this.button_Delete.TabIndex = 3;
			this.button_Delete.Text = "Удалить";
			this.button_Delete.UseVisualStyleBackColor = false;
			this.button_Delete.Click += new System.EventHandler(this.Button_DeleteClick);
			// 
			// Grid_Order
			// 
			this.Grid_Order.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.Grid_Order.AllowUserToAddRows = false;
			this.Grid_Order.AllowUserToDeleteRows = false;
			this.Grid_Order.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.Grid_Order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.Grid_Order.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.Grid_Order.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.Grid_Order.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Grid_Order.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
			this.Grid_Order.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
			this.Grid_Order.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Grid_Order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.Grid_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Grid_Order.ContextMenuStrip = this.contextMenuStrip1;
			this.Grid_Order.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkCyan;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.Grid_Order.DefaultCellStyle = dataGridViewCellStyle2;
			this.Grid_Order.GridColor = System.Drawing.SystemColors.Control;
			this.Grid_Order.Location = new System.Drawing.Point(12, 139);
			this.Grid_Order.MultiSelect = false;
			this.Grid_Order.Name = "Grid_Order";
			this.Grid_Order.ReadOnly = true;
			this.Grid_Order.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Grid_Order.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Grid_Order.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.Grid_Order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.Grid_Order.Size = new System.Drawing.Size(1575, 359);
			this.Grid_Order.TabIndex = 4;
			this.Grid_Order.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Grid_OrderMouseDown);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripSeparator1,
			this.toolStrip_Delete,
			this.редактироватьToolStripMenuItem,
			this.результатToolStripMenuItem,
			this.удалитьToolStripMenuItem,
			this.цветToolStripMenuItem,
			this.добавитьБЛЦБToolStripMenuItem1});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(161, 126);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
			// 
			// toolStrip_Delete
			// 
			this.toolStrip_Delete.Name = "toolStrip_Delete";
			this.toolStrip_Delete.Size = new System.Drawing.Size(157, 6);
			// 
			// редактироватьToolStripMenuItem
			// 
			this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
			this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.редактироватьToolStripMenuItem.Text = "Редактировать";
			this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.РедактироватьToolStripMenuItemClick);
			// 
			// результатToolStripMenuItem
			// 
			this.результатToolStripMenuItem.Name = "результатToolStripMenuItem";
			this.результатToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.результатToolStripMenuItem.Text = "Результат";
			this.результатToolStripMenuItem.Click += new System.EventHandler(this.РезультатToolStripMenuItemClick);
			// 
			// удалитьToolStripMenuItem
			// 
			this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
			this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.удалитьToolStripMenuItem.Text = "Удалить";
			this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.УдалитьToolStripMenuItemClick);
			// 
			// цветToolStripMenuItem
			// 
			this.цветToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.вРаботеToolStripMenuItem,
			this.готовоToolStripMenuItem,
			this.toolStripMenuItem1,
			this.другойЦветToolStripMenuItem,
			this.снятьВыделениеToolStripMenuItem});
			this.цветToolStripMenuItem.Name = "цветToolStripMenuItem";
			this.цветToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.цветToolStripMenuItem.Text = "Цвет";
			// 
			// вРаботеToolStripMenuItem
			// 
			this.вРаботеToolStripMenuItem.Name = "вРаботеToolStripMenuItem";
			this.вРаботеToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.вРаботеToolStripMenuItem.Text = "В работе";
			this.вРаботеToolStripMenuItem.Click += new System.EventHandler(this.ВРаботеToolStripMenuItemClick);
			// 
			// готовоToolStripMenuItem
			// 
			this.готовоToolStripMenuItem.Name = "готовоToolStripMenuItem";
			this.готовоToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.готовоToolStripMenuItem.Text = "Готово";
			this.готовоToolStripMenuItem.Click += new System.EventHandler(this.ГотовоToolStripMenuItemClick);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
			this.toolStripMenuItem1.Text = "Отгружено";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1Click);
			// 
			// другойЦветToolStripMenuItem
			// 
			this.другойЦветToolStripMenuItem.Name = "другойЦветToolStripMenuItem";
			this.другойЦветToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.другойЦветToolStripMenuItem.Text = "Другой цвет...";
			this.другойЦветToolStripMenuItem.Click += new System.EventHandler(this.ДругойЦветToolStripMenuItemClick);
			// 
			// снятьВыделениеToolStripMenuItem
			// 
			this.снятьВыделениеToolStripMenuItem.Name = "снятьВыделениеToolStripMenuItem";
			this.снятьВыделениеToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.снятьВыделениеToolStripMenuItem.Text = "Снять выделение";
			this.снятьВыделениеToolStripMenuItem.Click += new System.EventHandler(this.СнятьВыделениеToolStripMenuItemClick);
			// 
			// добавитьБЛЦБToolStripMenuItem1
			// 
			this.добавитьБЛЦБToolStripMenuItem1.Name = "добавитьБЛЦБToolStripMenuItem1";
			this.добавитьБЛЦБToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
			this.добавитьБЛЦБToolStripMenuItem1.Text = "Добавить БЛЦБ";
			this.добавитьБЛЦБToolStripMenuItem1.Click += new System.EventHandler(this.ДобавитьБЛЦБToolStripMenuItem1Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.checkBox_Sent);
			this.panel1.Controls.Add(this.button_Sent);
			this.panel1.Controls.Add(this.checkBox_StrictSearh);
			this.panel1.Controls.Add(this.textBox_Searh);
			this.panel1.Controls.Add(this.button_Searh);
			this.panel1.Controls.Add(this.checkBox_Finished);
			this.panel1.Controls.Add(this.checkBox_InWork);
			this.panel1.Controls.Add(this.checkBox_DateDay);
			this.panel1.Controls.Add(this.button_ClearColor);
			this.panel1.Controls.Add(this.button_ColorDialog);
			this.panel1.Controls.Add(this.button_ColorFinish);
			this.panel1.Controls.Add(this.button_ColorInWork);
			this.panel1.Controls.Add(this.richTextBox_Result);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.button_Result);
			this.panel1.Controls.Add(this.button_CopyResult);
			this.panel1.Controls.Add(this.button_Edit);
			this.panel1.Controls.Add(this.button_Delete);
			this.panel1.Controls.Add(this.button_NewOrder);
			this.panel1.Controls.Add(this.button_Update);
			this.panel1.Controls.Add(this.menuStrip1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1599, 133);
			this.panel1.TabIndex = 5;
			// 
			// checkBox_Sent
			// 
			this.checkBox_Sent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox_Sent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBox_Sent.ForeColor = System.Drawing.SystemColors.Highlight;
			this.checkBox_Sent.Location = new System.Drawing.Point(344, 104);
			this.checkBox_Sent.Name = "checkBox_Sent";
			this.checkBox_Sent.Size = new System.Drawing.Size(91, 24);
			this.checkBox_Sent.TabIndex = 24;
			this.checkBox_Sent.Text = "Отгружено";
			this.checkBox_Sent.UseVisualStyleBackColor = true;
			this.checkBox_Sent.CheckedChanged += new System.EventHandler(this.CheckBox_SentCheckedChanged);
			// 
			// button_Sent
			// 
			this.button_Sent.BackColor = System.Drawing.SystemColors.Highlight;
			this.button_Sent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_Sent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_Sent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button_Sent.Location = new System.Drawing.Point(1485, 27);
			this.button_Sent.Name = "button_Sent";
			this.button_Sent.Size = new System.Drawing.Size(81, 46);
			this.button_Sent.TabIndex = 23;
			this.button_Sent.Text = "Отгружено";
			this.button_Sent.UseVisualStyleBackColor = false;
			this.button_Sent.Click += new System.EventHandler(this.Button_SentClick);
			// 
			// checkBox_StrictSearh
			// 
			this.checkBox_StrictSearh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox_StrictSearh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBox_StrictSearh.Location = new System.Drawing.Point(1128, 99);
			this.checkBox_StrictSearh.Name = "checkBox_StrictSearh";
			this.checkBox_StrictSearh.Size = new System.Drawing.Size(146, 24);
			this.checkBox_StrictSearh.TabIndex = 22;
			this.checkBox_StrictSearh.Text = "Точное совпадение";
			this.checkBox_StrictSearh.UseVisualStyleBackColor = true;
			// 
			// textBox_Searh
			// 
			this.textBox_Searh.Location = new System.Drawing.Point(1128, 77);
			this.textBox_Searh.Name = "textBox_Searh";
			this.textBox_Searh.Size = new System.Drawing.Size(113, 20);
			this.textBox_Searh.TabIndex = 21;
			this.textBox_Searh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_SearhKeyDown);
			// 
			// button_Searh
			// 
			this.button_Searh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_Searh.Location = new System.Drawing.Point(1247, 77);
			this.button_Searh.Name = "button_Searh";
			this.button_Searh.Size = new System.Drawing.Size(54, 21);
			this.button_Searh.TabIndex = 20;
			this.button_Searh.Text = "Поиск";
			this.button_Searh.UseVisualStyleBackColor = true;
			this.button_Searh.Click += new System.EventHandler(this.Button_SearhClick);
			// 
			// checkBox_Finished
			// 
			this.checkBox_Finished.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox_Finished.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBox_Finished.ForeColor = System.Drawing.Color.Green;
			this.checkBox_Finished.Location = new System.Drawing.Point(266, 104);
			this.checkBox_Finished.Name = "checkBox_Finished";
			this.checkBox_Finished.Size = new System.Drawing.Size(72, 24);
			this.checkBox_Finished.TabIndex = 19;
			this.checkBox_Finished.Text = "Готово";
			this.checkBox_Finished.UseVisualStyleBackColor = true;
			this.checkBox_Finished.CheckedChanged += new System.EventHandler(this.CheckBox_FinishedCheckedChanged);
			// 
			// checkBox_InWork
			// 
			this.checkBox_InWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox_InWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBox_InWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.checkBox_InWork.Location = new System.Drawing.Point(180, 103);
			this.checkBox_InWork.Name = "checkBox_InWork";
			this.checkBox_InWork.Size = new System.Drawing.Size(80, 25);
			this.checkBox_InWork.TabIndex = 18;
			this.checkBox_InWork.Text = "В работе";
			this.checkBox_InWork.UseVisualStyleBackColor = true;
			this.checkBox_InWork.CheckedChanged += new System.EventHandler(this.CheckBox_InWorkCheckedChanged);
			// 
			// checkBox_DateDay
			// 
			this.checkBox_DateDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox_DateDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBox_DateDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.checkBox_DateDay.Location = new System.Drawing.Point(13, 102);
			this.checkBox_DateDay.Name = "checkBox_DateDay";
			this.checkBox_DateDay.Size = new System.Drawing.Size(125, 24);
			this.checkBox_DateDay.TabIndex = 17;
			this.checkBox_DateDay.Text = "Период: 1 день";
			this.checkBox_DateDay.UseVisualStyleBackColor = true;
			this.checkBox_DateDay.CheckedChanged += new System.EventHandler(this.CheckBox_DateDayCheckedChanged);
			// 
			// button_ClearColor
			// 
			this.button_ClearColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_ClearColor.Location = new System.Drawing.Point(1311, 87);
			this.button_ClearColor.Name = "button_ClearColor";
			this.button_ClearColor.Size = new System.Drawing.Size(168, 34);
			this.button_ClearColor.TabIndex = 16;
			this.button_ClearColor.Text = "Снять выделение";
			this.button_ClearColor.UseVisualStyleBackColor = true;
			this.button_ClearColor.Click += new System.EventHandler(this.Button_ClearColorClick);
			// 
			// button_ColorDialog
			// 
			this.button_ColorDialog.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button_ColorDialog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_ColorDialog.BackgroundImage")));
			this.button_ColorDialog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button_ColorDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_ColorDialog.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.button_ColorDialog.Location = new System.Drawing.Point(1498, 83);
			this.button_ColorDialog.Name = "button_ColorDialog";
			this.button_ColorDialog.Size = new System.Drawing.Size(52, 40);
			this.button_ColorDialog.TabIndex = 15;
			this.button_ColorDialog.UseVisualStyleBackColor = false;
			this.button_ColorDialog.Click += new System.EventHandler(this.Button_ColorDialogClick);
			// 
			// button_ColorFinish
			// 
			this.button_ColorFinish.BackColor = System.Drawing.Color.Green;
			this.button_ColorFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_ColorFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_ColorFinish.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button_ColorFinish.Location = new System.Drawing.Point(1398, 27);
			this.button_ColorFinish.Name = "button_ColorFinish";
			this.button_ColorFinish.Size = new System.Drawing.Size(81, 46);
			this.button_ColorFinish.TabIndex = 14;
			this.button_ColorFinish.Text = "Готово";
			this.button_ColorFinish.UseVisualStyleBackColor = false;
			this.button_ColorFinish.Click += new System.EventHandler(this.Button_ColorFinishClick);
			// 
			// button_ColorInWork
			// 
			this.button_ColorInWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.button_ColorInWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_ColorInWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_ColorInWork.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button_ColorInWork.Location = new System.Drawing.Point(1311, 27);
			this.button_ColorInWork.Name = "button_ColorInWork";
			this.button_ColorInWork.Size = new System.Drawing.Size(81, 46);
			this.button_ColorInWork.TabIndex = 13;
			this.button_ColorInWork.Text = "В работе";
			this.button_ColorInWork.UseVisualStyleBackColor = false;
			this.button_ColorInWork.Click += new System.EventHandler(this.Button_ColorInWorkClick);
			// 
			// richTextBox_Result
			// 
			this.richTextBox_Result.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.richTextBox_Result.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.richTextBox_Result.ForeColor = System.Drawing.Color.Red;
			this.richTextBox_Result.Location = new System.Drawing.Point(495, 27);
			this.richTextBox_Result.Name = "richTextBox_Result";
			this.richTextBox_Result.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
			this.richTextBox_Result.Size = new System.Drawing.Size(627, 103);
			this.richTextBox_Result.TabIndex = 10;
			this.richTextBox_Result.Text = "";
			this.richTextBox_Result.WordWrap = false;
			// 
			// button1
			// 
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.button1.Location = new System.Drawing.Point(1206, 25);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(47, 47);
			this.button1.TabIndex = 8;
			this.button1.Text = " ";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button_Result
			// 
			this.button_Result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_Result.Location = new System.Drawing.Point(401, 40);
			this.button_Result.Name = "button_Result";
			this.button_Result.Size = new System.Drawing.Size(88, 44);
			this.button_Result.TabIndex = 6;
			this.button_Result.Text = "Результат";
			this.button_Result.UseVisualStyleBackColor = true;
			this.button_Result.Click += new System.EventHandler(this.Button_ResultClick);
			// 
			// button_CopyResult
			// 
			this.button_CopyResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button_CopyResult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_CopyResult.BackgroundImage")));
			this.button_CopyResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button_CopyResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_CopyResult.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.button_CopyResult.Location = new System.Drawing.Point(1141, 27);
			this.button_CopyResult.Name = "button_CopyResult";
			this.button_CopyResult.Size = new System.Drawing.Size(48, 46);
			this.button_CopyResult.TabIndex = 7;
			this.button_CopyResult.Text = " ";
			this.button_CopyResult.UseVisualStyleBackColor = false;
			this.button_CopyResult.Click += new System.EventHandler(this.Button_CopyResultClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.добавитьБЛЦБToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1599, 24);
			this.menuStrip1.TabIndex = 12;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// добавитьБЛЦБToolStripMenuItem
			// 
			this.добавитьБЛЦБToolStripMenuItem.Name = "добавитьБЛЦБToolStripMenuItem";
			this.добавитьБЛЦБToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
			this.добавитьБЛЦБToolStripMenuItem.Text = "Добавить БЛЦБ";
			this.добавитьБЛЦБToolStripMenuItem.Click += new System.EventHandler(this.ДобавитьБЛЦБToolStripMenuItemClick);
			// 
			// colorDialog
			// 
			this.colorDialog.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			// 
			// timer_Color
			// 
			this.timer_Color.Enabled = true;
			this.timer_Color.Interval = 500;
			this.timer_Color.Tick += new System.EventHandler(this.Timer_ColorTick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1599, 536);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.Grid_Order);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Журнал заявок";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.Grid_Order)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);

		}
		}
		}
	

