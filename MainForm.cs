
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;



namespace Jornal
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();		

			LoadData();
		
			
		}
		private	void Grid_OrderMouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right) {
				DataGridView.HitTestInfo hit = Grid_Order.HitTest(e.X, e.Y);
				if (hit.Type == DataGridViewHitTestType.Cell) {
					Grid_Order.CurrentCell = Grid_Order[hit.ColumnIndex, hit.RowIndex];
					contextMenuStrip1.Show(Grid_Order, e.X, e.Y);
				}   
			}
		}
		
		
		private void ConnectAccess(string query)
		{	
			ConnectionStringSettings conString;
			conString = ConfigurationManager.ConnectionStrings["pathdb"];		
			
			try {
				OleDbConnection dbConn = new OleDbConnection(conString.ConnectionString);
				OleDbCommand dbCommand = new OleDbCommand(query, dbConn);
				dbCommand.Connection = dbConn;
				dbCommand.CommandText = query;				
				dbConn.Open();
				dbCommand.ExecuteNonQuery();
				dbConn.Close();
			} catch {
			
				MessageBox.Show("Не удалось подключиться к Базе Данных, программа будет закрыта", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Environment.Exit(0);
			}	
		}
		
		
		private void LoadData()
		{
			ConnectionStringSettings conString;
			conString = ConfigurationManager.ConnectionStrings["pathdb"];
			//string connectionString = "provider = Microsoft.Jet.OLEDB.4.0;Data Source=OrderDB.mdb";
			try {
				OleDbConnection dbConn = new OleDbConnection(conString.ConnectionString);			
				string query = "SELECT * FROM Orders";				
				OleDbCommand dbCommand = new OleDbCommand(query, dbConn);
				OleDbDataAdapter da = new OleDbDataAdapter();
				DataTable dt = new DataTable();	
				DataSet ds = new DataSet();
				dbCommand.Connection = dbConn;
				dbCommand.CommandText = query;
				dbConn.Open();
				da.SelectCommand = dbCommand;
				da.Fill(ds);
				dt = ds.Tables[0];
				Grid_Order.DataSource = dt;
				this.Grid_Order.Columns["Код"].Visible = false;
				this.Grid_Order.Columns["Color"].Visible = false;
				this.Grid_Order.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
							
				dbConn.Close();
				//RefrechColor();
				
				
			} catch {
				
				MessageBox.Show("Не удалось подключиться к Базе Данных, программа будет закрыта", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Environment.Exit(0);
			}			
		}
	
		private void LoadDataSortDay()
		{
			checkBox_Finished.Checked = false;
			checkBox_InWork.Checked = false;
			checkBox_Sent.Checked = false;
			LoadData();
			DateTime dt;
			if (checkBox_DateDay.Checked) {
				for (int i = (Grid_Order.Rows.Count - 1); i >= 0; i--) {
					DateTime.TryParse(Grid_Order.Rows[i].Cells[1].Value.ToString(), out dt);
					if (DateTime.Now.DayOfYear - dt.DayOfYear > 0) {
						Grid_Order.Rows.RemoveAt(i);
						//i += 1;
					} 
				}	
			} else {
				LoadData();
			}
		}
		private void LoadInWork()
		{
			checkBox_DateDay.Checked = false;
			checkBox_Finished.Checked = false;
			checkBox_Sent.Checked = false;
			if (checkBox_InWork.Checked) {	
				
				for (int i = (Grid_Order.Rows.Count - 1); i >= 0; i--) {
					int color = ColorFromDB(i);		
					int numColors = 0;
					if (color != -1) {
						numColors = Convert.ToInt32(Grid_Order.Rows[i].Cells[14].Value);
					}
			
					if (numColors != -65536) {
						Grid_Order.Rows.RemoveAt(i);
					}
				
				}		
				
			} else {
				LoadData();
			}
			
		}
		
		private void LoadFinished()
		{
			
			checkBox_DateDay.Checked = false;
			checkBox_InWork.Checked = false;
			checkBox_Sent.Checked = false;
			if (checkBox_Finished.Checked) {	
				
				for (int i = (Grid_Order.Rows.Count - 1); i >= 0; i--) {
					
					int color = ColorFromDB(i);		
					int numColors = 0;
				
					if (color != -1) {
						numColors = Convert.ToInt32(Grid_Order.Rows[i].Cells[14].Value);
					}
				
					if (numColors != -16744384) {
						Grid_Order.Rows.RemoveAt(i);
					}				
				}		
				
			} else {
				LoadData();
			}
		}
		private void LoadSented()
		{
			checkBox_DateDay.Checked = false;
			checkBox_InWork.Checked = false;
			checkBox_Finished.Checked = false;
			if (checkBox_Sent.Checked) {	
				
				for (int i = (Grid_Order.Rows.Count - 1); i >= 0; i--) {
					
					int color = ColorFromDB(i);		
					int numColors = 0;
				
					if (color != -1) {
						numColors = Convert.ToInt32(Grid_Order.Rows[i].Cells[14].Value);
					}
				
					if (numColors != -16744256) {
						Grid_Order.Rows.RemoveAt(i);
					}				
				}		
				
			} else {
				LoadData();
			}
		
		}
				
		private void RefrechColor()
		{
			for (int i = 0; i < Grid_Order.Rows.Count - 1; i++) {
				
				int color = ColorFromDB(i);
				if (color != -1) {					
					this.Grid_Order.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(color);
					this.Grid_Order.Rows[i].DefaultCellStyle.ForeColor = Color.White;
				}
				if (color == -1) {
					this.Grid_Order.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
				}
			}
		}
		private void UpdateDataGrid()
		{
			checkBox_InWork.Checked = false;
			checkBox_Finished.Checked = false;
			checkBox_Sent.Checked = false;
			
			
			if (checkBox_DateDay.Checked) {
				
				LoadDataSortDay();
			} else
				LoadData();
			
		}
		private void Searh()
		{
			bool flagSearh = true;
			for (int i = 0; i < Grid_Order.RowCount; i++) {
				
				for (int j = 0; j < Grid_Order.ColumnCount; j++)
					if (Grid_Order.Rows[i].Cells[j].Value != null && textBox_Searh.Text != "") {
						if (Grid_Order.Rows[i].Cells[j].Value.ToString() == textBox_Searh.Text && checkBox_StrictSearh.Checked) {						                         
							Grid_Order.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
							flagSearh = false;
							break;
						} else if (Grid_Order.Rows[i].Cells[j].Value.ToString().ToUpper().Contains(textBox_Searh.Text.Trim().ToUpper()) && checkBox_StrictSearh.Checked == false) {
							Grid_Order.ClearSelection();
							
							Grid_Order.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
							flagSearh = false;
							break;
						}
					}
			} 
			if (flagSearh) {
				MessageBox.Show("Не найдено", "Поиск...", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		private void AddBLCB()
		{
			string numSpec, numBLCB;
			Form_BLCB addBLCB = new Form_BLCB();
			
			addBLCB.ShowDialog();
			
			if (addBLCB.DialogResult == DialogResult.OK) {
				
				numSpec = addBLCB.tBNumSpec;
				numBLCB = addBLCB.tBBLCB;
				
				string getKey = "SELECT Код FROM Orders WHERE Спецификация =" + "'" + numSpec + "'";
				ConnectionStringSettings conString;
				conString = ConfigurationManager.ConnectionStrings["pathdb"];					
				string key;	
				try {
					OleDbConnection dbConn = new OleDbConnection(conString.ConnectionString);
					OleDbCommand dbCommand = new OleDbCommand(getKey, dbConn);
					dbConn.Open();
					OleDbDataReader dbReader = dbCommand.ExecuteReader();
					dbReader.Read();
					key = Convert.ToString(dbReader[0]);					
					
					string query = "UPDATE Orders set БЛЦБ='" + numBLCB + "' WHERE Код = " + key;
					MessageBox.Show("Номер БЛЦБ успешно добавлен", "Номер БЛЦБ...", MessageBoxButtons.OK, MessageBoxIcon.Information);			
					ConnectAccess(query);				
				
					LoadData();
					for (int i = 0; i < Grid_Order.RowCount; i++)
						if (Convert.ToString(Grid_Order.Rows[i].Cells[0].Value) == key) {							
							checkBox_DateDay.Checked = false;
							Grid_Order.ClearSelection();								
							//Grid_Order.Rows[i].Selected = true;
							Grid_Order.Rows[i].DefaultCellStyle.BackColor = Color.Coral;
							Grid_Order.FirstDisplayedScrollingRowIndex = i;
						}
					
					
				} catch {
					
					MessageBox.Show("Не удалось найти Спецификацию №" + numSpec + "\n" + "Номер БЛЦБ не добавлен!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void AddBLCB_In_DB()
		{
			Add_BLCB addBLCBDB = new Add_BLCB();
			
			string NumberBLCB, NameManager, NumberSpec;
			int key = Convert.ToInt32(this.Grid_Order.CurrentRow.Cells[0].Value);			
			NameManager = Convert.ToString(this.Grid_Order.CurrentRow.Cells[2].Value);
			NumberSpec = Convert.ToString(this.Grid_Order.CurrentRow.Cells[3].Value);
			NumberBLCB = Convert.ToString(this.Grid_Order.CurrentRow.Cells[13].Value);
			addBLCBDB.NumberBLCB = NumberBLCB;
			addBLCBDB.LabelInfoBLCB = "Добавить к заявке менеджера  " + NameManager + "\n" + "\t" + "\t" + "  Спецификация №" + NumberSpec + "  БЛЦБ №";
			addBLCBDB.ShowDialog();
			if (addBLCBDB.DialogResult == DialogResult.OK) {
				NumberBLCB = addBLCBDB.NumberBLCB;
				key = Convert.ToInt32(this.Grid_Order.CurrentRow.Cells[0].Value);	
				try {
					string query = "UPDATE Orders set БЛЦБ='" + NumberBLCB + "' WHERE Код = " + key;
					MessageBox.Show("Номер БЛЦБ успешно добавлен", "Номер БЛЦБ...", MessageBoxButtons.OK, MessageBoxIcon.Information);			
					ConnectAccess(query);	
					UpdateDataGrid();
				} catch {
					MessageBox.Show("Номер БЛЦБ не добавлен!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		
		private void ColorRow(int color, int key)
		{
			this.Grid_Order.Rows[key].DefaultCellStyle.BackColor = Color.FromArgb(color);
		}
		private void ColorInDB(int color)
		{
			if (this.Grid_Order.Rows.Count != 0) {
				int key = Convert.ToInt32(this.Grid_Order.CurrentRow.Cells[0].Value);
				ConnectionStringSettings conString;
				conString = ConfigurationManager.ConnectionStrings["pathdb"];	
				string getKey = "SELECT Код FROM Orders";				
				
				OleDbConnection dbConn = new OleDbConnection(conString.ConnectionString);
				OleDbCommand dbCommand = new OleDbCommand(getKey, dbConn);
				dbConn.Open();
				OleDbDataReader dbReader = dbCommand.ExecuteReader();
				dbReader.Read();
					
				string query = "UPDATE Orders set Color='" + color + "' WHERE Код = " + key;
				ConnectAccess(query);	
			
			}
				
		}
		private int ColorFromDB(int key)
		{
			if ((this.Grid_Order.Rows[key].Cells[14].Value) != DBNull.Value) {
				int color = Convert.ToInt32(this.Grid_Order.Rows[key].Cells[14].Value);
				return color;
			} else {
				return -1;
			}
		}
		
		private void ScrollToRow()
		{
			int rowIndex;
		
			rowIndex = Grid_Order.CurrentRow.Index;
			Grid_Order.FirstDisplayedScrollingRowIndex = rowIndex;
		}
		
		private void NewOrd()
		{
			ClearTextResult();
			Form_NewOrder newOrder = new Form_NewOrder();			
			string data, manager, numberOfSpec, client, cut, steelGrade, sheetCount, thStr, weight, size;
			int lenghtCut;
			double thickness, priceResult;
			
				
			newOrder.ShowDialog();
			
			
			if (newOrder.DialogResult == DialogResult.OK) {	
				
				//String
				data = newOrder.textBox_MyDate.Text;
				manager = newOrder.textBox_Manager.Text;
				numberOfSpec = newOrder.textBox_NumSpec.Text;
				client = newOrder.textBox_Client.Text;
				cut = newOrder.comboBox_Cut.Text;
				steelGrade = newOrder.comboBox_SteelGreed.Text;
				sheetCount = newOrder.textBox_SheetCount.Text;
				size = newOrder.comboBox_Size.Text;
				//Integer
				lenghtCut = Convert.ToInt32(newOrder.textBox_LengthCut.Text);
				//Doudle
				//thickness = newOrder.comboBox_Thickness.Text;
				thickness = Double.Parse(newOrder.comboBox_Thickness.Text.Replace('.', ','));
				thStr = newOrder.comboBox_Thickness.Text.Replace('.', ',');
				//weight = double.Parse(newOrder.textBox_Weight.Text.Replace('.', ','));
				weight = newOrder.textBox_Weight.Text;
				bool flagCut = true;
				
				
				if (newOrder.comboBox_Cut.Text == "Лазер" & lenghtCut < 500 & thickness <= 6) {
					string queryPrice = "SELECT * FROM PriceLL500";
					
					ConnectionStringSettings conString;
					conString = ConfigurationManager.ConnectionStrings["pathdb"];
					
					string price;
					
					OleDbConnection dbConn = new OleDbConnection(conString.ConnectionString);
					OleDbCommand dbCommand = new OleDbCommand(queryPrice, dbConn);
					dbConn.Open();
					OleDbDataReader dbReader = dbCommand.ExecuteReader();
					dbReader.Read();
					price = Convert.ToString(dbReader[thStr]);
					priceResult = Convert.ToDouble(price) * lenghtCut;
					
					string query = "INSERT INTO Orders (Дата, Менеджер, Спецификация, Заказчик, Вид_резки, Марка_стали, Толщина, Размер_листа, Ход, Вес, Кол_во_листов, Стоимость) " +
					               "VALUES('" + data + "','" + manager + "','" + numberOfSpec + "', '" + client + "', '" + cut + "', '" + steelGrade + "', '" + thickness +
					               "', '" + size + "', '" + lenghtCut + "', '" + weight + "', '" + sheetCount + "','" + priceResult + "'  )";
								
					ConnectAccess(query);
					flagCut = false;
						
					
				} else if (newOrder.comboBox_Cut.Text == "Лазер" & lenghtCut >= 500 & thickness <= 6) {
					string queryPrice = "SELECT * FROM PriceLM500";
					
					ConnectionStringSettings conString;
					conString = ConfigurationManager.ConnectionStrings["pathdb"];
					
					string price;
					
					OleDbConnection dbConn = new OleDbConnection(conString.ConnectionString);
					OleDbCommand dbCommand = new OleDbCommand(queryPrice, dbConn);
					dbConn.Open();
					OleDbDataReader dbReader = dbCommand.ExecuteReader();
					dbReader.Read();
					price = Convert.ToString(dbReader[thStr]);
					priceResult = Convert.ToDouble(price) * lenghtCut;
					
					string query = "INSERT INTO Orders (Дата, Менеджер, Спецификация, Заказчик, Вид_резки, Марка_стали, Толщина, Размер_листа, Ход, Вес, Кол_во_листов, Стоимость) " +
					               "VALUES('" + data + "','" + manager + "','" + numberOfSpec + "', '" + client + "', '" + cut + "', '" + steelGrade + "', '" + thickness +
					               "', '" + size + "', '" + lenghtCut + "', '" + weight + "', '" + sheetCount + "','" + priceResult + "'  )";
								
					ConnectAccess(query);
					flagCut = false;
				}
				
				if (newOrder.comboBox_Cut.Text == "Плазма" & thickness >= 2 & thickness <= 30) {
					string queryPrice = "SELECT * FROM PriceP";
					ConnectionStringSettings conString;
					conString = ConfigurationManager.ConnectionStrings["pathdb"];
					
					string price;
					
					OleDbConnection dbConn = new OleDbConnection(conString.ConnectionString);
					OleDbCommand dbCommand = new OleDbCommand(queryPrice, dbConn);
					dbConn.Open();
					OleDbDataReader dbReader = dbCommand.ExecuteReader();
					dbReader.Read();
					price = Convert.ToString(dbReader[thStr]);
					priceResult = Convert.ToDouble(price) * lenghtCut;
					
					string query = "INSERT INTO Orders (Дата, Менеджер, Спецификация, Заказчик, Вид_резки, Марка_стали, Толщина, Размер_листа, Ход, Вес, Кол_во_листов, Стоимость) " +
					               "VALUES('" + data + "','" + manager + "','" + numberOfSpec + "', '" + client + "', '" + cut + "', '" + steelGrade + "', '" + thickness +
					               "', '" + size + "', '" + lenghtCut + "', '" + weight + "', '" + sheetCount + "','" + priceResult + "'  )";
							
					ConnectAccess(query);
					flagCut = false;
				}
				if (newOrder.comboBox_Cut.Text == "Газо-кислородная" & thickness >= 16 & thickness <= 80) {
					string queryPrice = "SELECT * FROM PriceG";
					ConnectionStringSettings conString;
					conString = ConfigurationManager.ConnectionStrings["pathdb"];
					
					string price;
					
					OleDbConnection dbConn = new OleDbConnection(conString.ConnectionString);
					OleDbCommand dbCommand = new OleDbCommand(queryPrice, dbConn);
					dbConn.Open();
					OleDbDataReader dbReader = dbCommand.ExecuteReader();
					dbReader.Read();
					price = Convert.ToString(dbReader[thStr]);
					priceResult = Convert.ToDouble(price) * lenghtCut;
					
					string query = "INSERT INTO Orders (Дата, Менеджер, Спецификация, Заказчик, Вид_резки, Марка_стали, Толщина, Размер_листа, Ход, Вес, Кол_во_листов, Стоимость) " +
					               "VALUES('" + data + "','" + manager + "','" + numberOfSpec + "', '" + client + "', '" + cut + "', '" + steelGrade + "', '" + thickness +
					               "', '" + size + "', '" + lenghtCut + "', '" + weight + "', '" + sheetCount + "','" + priceResult + "'  )";
							
					ConnectAccess(query);
					flagCut = false;
				}
				if (flagCut) {
					MessageBox.Show("Не подходящие параметры для выбранного инструмента", "Внимание...", MessageBoxButtons.OK, MessageBoxIcon.Information);
					NewOrd();
				}
				
				UpdateDataGrid();
			}
		}
		
		private void Delete()
		{
			{//Кнопка удалить___________________________________________________
				if (this.Grid_Order.Rows.Count != 0) {
					int key;
					string managerName;
					key = Convert.ToInt32(this.Grid_Order.CurrentRow.Cells[0].Value);
					managerName = Convert.ToString(this.Grid_Order.CurrentRow.Cells[2].Value);
					DialogResult resDel = MessageBox.Show("Вы действительно хотите удалить заявку менеджера" + " " + managerName + "?", "Удаление...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			
					if (resDel == DialogResult.OK) {				
						string query = "DELETE FROM Orders WHERE Код=" + key;
						ConnectAccess(query);
						UpdateDataGrid();		
					}			
				}
			}
		}
		private void Edit()
		{
			if (this.Grid_Order.Rows.Count != 0) {
				Form_NewOrder newOrder = new Form_NewOrder();			
				string data, manager, numberOfSpec, client, cut, steelGrade, sheetCount, thStr, weight, size;
				int lenghtCut, key;
				double thickness, priceResult;
				//Автозаполнение полей формы из GridView
				newOrder.tBManager = Convert.ToString(this.Grid_Order.CurrentRow.Cells[2].Value);
				newOrder.tBNSpec = Convert.ToString(this.Grid_Order.CurrentRow.Cells[3].Value);
				newOrder.tBClient = Convert.ToString(this.Grid_Order.CurrentRow.Cells[4].Value);
				newOrder.cBCut = Convert.ToString(this.Grid_Order.CurrentRow.Cells[5].Value);
				newOrder.cBSteelGrade = Convert.ToString(this.Grid_Order.CurrentRow.Cells[6].Value);
				newOrder.cBThickness = Convert.ToString(this.Grid_Order.CurrentRow.Cells[7].Value);
				newOrder.cBSize = Convert.ToString(this.Grid_Order.CurrentRow.Cells[8].Value);
				newOrder.tBLenCut = Convert.ToString(this.Grid_Order.CurrentRow.Cells[9].Value);
				newOrder.tBWeight = Convert.ToString(this.Grid_Order.CurrentRow.Cells[10].Value);
				newOrder.tBSheetCount = Convert.ToString(this.Grid_Order.CurrentRow.Cells[11].Value);	
				bool flagCut = true;
				ClearTextResult();
				key = Convert.ToInt32(this.Grid_Order.CurrentRow.Cells[0].Value);
				
				newOrder.ShowDialog();
				if (newOrder.DialogResult == DialogResult.OK) {					
					//String
					data = newOrder.textBox_MyDate.Text;
					manager = newOrder.textBox_Manager.Text;
					numberOfSpec = newOrder.textBox_NumSpec.Text;
					client = newOrder.textBox_Client.Text;
					cut = newOrder.comboBox_Cut.Text;
					steelGrade = newOrder.comboBox_SteelGreed.Text;
					sheetCount = newOrder.textBox_SheetCount.Text;
					size = newOrder.comboBox_Size.Text;
					//Integer
					lenghtCut = Convert.ToInt32(newOrder.textBox_LengthCut.Text);
					//Doudle
					//thickness = newOrder.comboBox_Thickness.Text;
					thickness = Double.Parse(newOrder.comboBox_Thickness.Text.Replace('.', ','));
					thStr = newOrder.comboBox_Thickness.Text.Replace('.', ',');
					//weight = double.Parse(newOrder.textBox_Weight.Text.Replace('.', ','));
					weight = newOrder.textBox_Weight.Text;
					if (newOrder.comboBox_Cut.Text == "Лазер" & thickness <= 6) {
						if (lenghtCut < 500) {
							string queryPrice = "SELECT * FROM PriceLL500";					
							ConnectionStringSettings conString;
							conString = ConfigurationManager.ConnectionStrings["pathdb"];					
							string price;					
							OleDbConnection dbConn = new OleDbConnection(conString.ConnectionString);
							OleDbCommand dbCommand = new OleDbCommand(queryPrice, dbConn);
							dbConn.Open();
							OleDbDataReader dbReader = dbCommand.ExecuteReader();
							dbReader.Read();
							price = Convert.ToString(dbReader[thStr]);
							priceResult = Convert.ToDouble(price) * lenghtCut;
					
							string query = "UPDATE Orders set Менеджер='" + manager + "',Спецификация='" + numberOfSpec + "',Заказчик='" +
							               client + "', Вид_резки='" + cut + "', Марка_стали= '" + steelGrade + "',Толщина='" + thickness + "', Размер_листа='" +
							               size + "', Ход='" + lenghtCut + "', Вес='" + weight + "', Кол_во_листов='" + sheetCount + "', Стоимость='" + priceResult + "' WHERE Код = " + key;
								
							ConnectAccess(query);
							flagCut = false;
					
						
					
						} else if (lenghtCut >= 500) {
							string queryPrice = "SELECT * FROM PriceLM500";
					
							ConnectionStringSettings conString;
							conString = ConfigurationManager.ConnectionStrings["pathdb"];
					
							string price;
					
							OleDbConnection dbConn = new OleDbConnection(conString.ConnectionString);
							OleDbCommand dbCommand = new OleDbCommand(queryPrice, dbConn);
							dbConn.Open();
							OleDbDataReader dbReader = dbCommand.ExecuteReader();
							dbReader.Read();
							price = Convert.ToString(dbReader[thStr]);
							priceResult = Convert.ToDouble(price) * lenghtCut;
					
							string query = "UPDATE Orders set Менеджер='" + manager + "',Спецификация='" + numberOfSpec + "',Заказчик='" +
							               client + "', Вид_резки='" + cut + "', Марка_стали= '" + steelGrade + "',Толщина='" + thickness + "', Размер_листа='" +
							               size + "', Ход='" + lenghtCut + "', Вес='" + weight + "', Кол_во_листов='" + sheetCount + "', Стоимость='" + priceResult + "' WHERE Код = " + key;
								
							ConnectAccess(query);
							flagCut = false;
						}
				
					}
				
				
					if (newOrder.comboBox_Cut.Text == "Плазма" & thickness >= 2 & thickness <= 30) {
						string queryPrice = "SELECT * FROM PriceP";
						ConnectionStringSettings conString;
						conString = ConfigurationManager.ConnectionStrings["pathdb"];
					
						string price;
					
						OleDbConnection dbConn = new OleDbConnection(conString.ConnectionString);
						OleDbCommand dbCommand = new OleDbCommand(queryPrice, dbConn);
						dbConn.Open();
						OleDbDataReader dbReader = dbCommand.ExecuteReader();
						dbReader.Read();
						price = Convert.ToString(dbReader[thStr]);
						priceResult = Convert.ToDouble(price) * lenghtCut;
					
						string query = "UPDATE Orders set Менеджер='" + manager + "',Спецификация='" + numberOfSpec + "',Заказчик='" +
						               client + "', Вид_резки='" + cut + "', Марка_стали= '" + steelGrade + "',Толщина='" + thickness + "', Размер_листа='" +
						               size + "', Ход='" + lenghtCut + "', Вес='" + weight + "', Кол_во_листов='" + sheetCount + "', Стоимость='" + priceResult + "' WHERE Код = " + key;
							
						ConnectAccess(query);
						flagCut = false;
					} 
					if (newOrder.comboBox_Cut.Text == "Газо-кислородная" & thickness >= 16 & thickness <= 80) {
						string queryPrice = "SELECT * FROM PriceG";
						ConnectionStringSettings conString;
						conString = ConfigurationManager.ConnectionStrings["pathdb"];
					
						string price;
					
						OleDbConnection dbConn = new OleDbConnection(conString.ConnectionString);
						OleDbCommand dbCommand = new OleDbCommand(queryPrice, dbConn);
						dbConn.Open();
						OleDbDataReader dbReader = dbCommand.ExecuteReader();
						dbReader.Read();
						price = Convert.ToString(dbReader[thStr]);
						priceResult = Convert.ToDouble(price) * lenghtCut;
					
						string query = "UPDATE Orders set Менеджер='" + manager + "',Спецификация='" + numberOfSpec + "',Заказчик='" +
						               client + "', Вид_резки='" + cut + "', Марка_стали= '" + steelGrade + "',Толщина='" + thickness + "', Размер_листа='" +
						               size + "', Ход='" + lenghtCut + "', Вес='" + weight + "', Кол_во_листов='" + sheetCount + "', Стоимость='" + priceResult + "' WHERE Код = " + key;
							
						ConnectAccess(query);
						flagCut = false;
					
					}
					if (flagCut) {
						MessageBox.Show("Не подходящие параметры для выбранного инструмента", "Внимание...", MessageBoxButtons.OK, MessageBoxIcon.Information);
						Edit();
					}
				
					UpdateDataGrid();
				}
			}
		}
		private void PrintResult()
		{
			if (this.Grid_Order.Rows.Count != 0) {
				Form_NewOrder newOrder = new Form_NewOrder();			
			
				string stellGrade, thickness, size, sheetCount, weight, priceR, cut;
				cut = Convert.ToString(this.Grid_Order.CurrentRow.Cells[5].Value);
				stellGrade = Convert.ToString(this.Grid_Order.CurrentRow.Cells[6].Value);
				thickness = Convert.ToString(this.Grid_Order.CurrentRow.Cells[7].Value);
				size = Convert.ToString(this.Grid_Order.CurrentRow.Cells[8].Value);		
				sheetCount = Convert.ToString(this.Grid_Order.CurrentRow.Cells[11].Value);	
				weight = (Convert.ToString(this.Grid_Order.CurrentRow.Cells[10].Value).Replace('.', ','));
				priceR = Convert.ToString(this.Grid_Order.CurrentRow.Cells[12].Value);
				if (richTextBox_Result.Text.Length == 0) {
					richTextBox_Result.Text = "Лист " + thickness + "x" + size + "," + "\t" + "Сталь " + stellGrade + "," + "\t" + sheetCount + " шт," + "\t" + "Вес " + weight + " кг." + "\t" + "Резка " + priceR + " руб." + "\t" + "резка " + cut + "\n";
				} else {
					
					richTextBox_Result.Text = richTextBox_Result.Text + "Лист " + thickness + "x" + size + "," + "\t" + "Сталь " + stellGrade + "," + "\t" + sheetCount + " шт," + "\t" + "Вес " + weight + " кг." + "\t" + "Резка " + priceR + " руб." + "\t" + "резка " + cut + "\n";
				}
			}
		}
		private void ClearTextResult()
		{
			richTextBox_Result.Text = "";
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
						
			
		}
		void Button_UpdateClick(object sender, EventArgs e)
		{
			UpdateDataGrid();
			
		}
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			const string message =
				"Вы хотите закрыть Журнал заявок?";
			const string caption = "Выход...";
			var result = MessageBox.Show(message, caption,
				             MessageBoxButtons.YesNo,
				             MessageBoxIcon.Question);
			if (result == DialogResult.No) {
				e.Cancel = true;
			}
		}
		void Button_NewOrderClick(object sender, EventArgs e)
		{
			NewOrd();
		}
		void Button_DeleteClick(object sender, EventArgs e)
		{//Кнопка удалить___________________________________________________
			Delete();
		}
		void Button_EditClick(object sender, EventArgs e)
		{//Кнопка редактирования_________________________________
			Edit();
		}
		void Grid_OrderMouseDoubleClick(object sender, MouseEventArgs e)
		{
			Edit();
		}
		void РедактироватьToolStripMenuItemClick(object sender, EventArgs e)
		{
			
			Edit();
		}
		void УдалитьToolStripMenuItemClick(object sender, EventArgs e)
		{
			
			Delete();
		}
		
		
		void Button_ResultClick(object sender, EventArgs e)
		{
			PrintResult();
		}
		void Button_CopyResultClick(object sender, EventArgs e)
		{
			if (richTextBox_Result.Text.Length != 0) {
				//Clipboard.SetText(richTextBox_Result.Text);
				DataObject dto = new DataObject();
				dto.SetText(richTextBox_Result.Rtf, TextDataFormat.Rtf);
				dto.SetText(richTextBox_Result.Text, TextDataFormat.UnicodeText);				
				Clipboard.Clear();
				Clipboard.SetDataObject(dto);				
			}
			
		}
		
		void РезультатToolStripMenuItemClick(object sender, EventArgs e)
		{
			PrintResult();
		}
		void Button1Click(object sender, EventArgs e)
		{
			ClearTextResult();
		}
		
		void CheckBox_DateCheckedChanged(object sender, EventArgs e)
		{
	
		}
		void CheckBox_DateDayCheckedChanged(object sender, EventArgs e)
		{
			LoadDataSortDay();
		}
		void MenuStrip1ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
	
		}
		void ДобавитьБЛЦБToolStripMenuItemClick(object sender, EventArgs e)
		{
			AddBLCB();
			//ScrollToRow();
		}
		void Button_ColorInWorkClick(object sender, EventArgs e)
		{
			if (this.Grid_Order.Rows.Count != 0) {
				this.Grid_Order.CurrentRow.DefaultCellStyle.ForeColor = Color.White;
				int key = Convert.ToInt32(this.Grid_Order.CurrentRow.Index);
				ColorInDB(-65536);
				ColorRow(-65536, key);
				UpdateDataGrid();
			}
			
			
		}
		void Button_ColorFinishClick(object sender, EventArgs e)
		{
			if (this.Grid_Order.Rows.Count != 0) {
				this.Grid_Order.CurrentRow.DefaultCellStyle.ForeColor = Color.White;
				int key = Convert.ToInt32(this.Grid_Order.CurrentRow.Index);
				ColorInDB(-16744384);
				ColorRow(-16744384, key);
				UpdateDataGrid();
			}
			
			
		}
		void Button_SentClick(object sender, EventArgs e)
		{
			if (this.Grid_Order.Rows.Count != 0) {
				this.Grid_Order.CurrentRow.DefaultCellStyle.ForeColor = Color.White;
				int key = Convert.ToInt32(this.Grid_Order.CurrentRow.Index);
				ColorInDB(-16744256);
				ColorRow(-16744256, key);
				UpdateDataGrid();
			}
		}
		void Button_ColorDialogClick(object sender, EventArgs e)
		{
			if (this.Grid_Order.Rows.Count != 0) {
				if (colorDialog.ShowDialog() == DialogResult.OK) {		
					int color = colorDialog.Color.ToArgb();
					int key = Convert.ToInt32(this.Grid_Order.CurrentRow.Index);
					ColorInDB(color);		
					button_ColorDialog.BackColor = System.Drawing.Color.FromArgb(color);
					//this.Grid_Order.CurrentRow.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(color);
					//this.Grid_Order.CurrentRow.DefaultCellStyle.ForeColor = Color.White;	
					ColorRow(color, key);
					UpdateDataGrid();
				}
				
			}
				
		}
		void Timer_ColorTick(object sender, EventArgs e)
		{
			RefrechColor();
		}
		void Button_ClearColorClick(object sender, EventArgs e)
		{
			if (this.Grid_Order.Rows.Count != 0) {
				ColorInDB(-1);
				UpdateDataGrid();
			}
	
		}
		void CheckBox_InWorkCheckedChanged(object sender, EventArgs e)
		{
			LoadInWork();
		}
		void CheckBox_FinishedCheckedChanged(object sender, EventArgs e)
		{
			LoadFinished();
		}
		void CheckBox_SentCheckedChanged(object sender, EventArgs e)
		{
			LoadSented();
		}
		void ВРаботеToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (this.Grid_Order.Rows.Count != 0) {
				this.Grid_Order.CurrentRow.DefaultCellStyle.ForeColor = Color.White;
				int key = Convert.ToInt32(this.Grid_Order.CurrentRow.Index);
				ColorInDB(-65536);
				ColorRow(-65536, key);
				UpdateDataGrid();
			}
			
		}
		void ГотовоToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (this.Grid_Order.Rows.Count != 0) {
				this.Grid_Order.CurrentRow.DefaultCellStyle.ForeColor = Color.White;
				int key = Convert.ToInt32(this.Grid_Order.CurrentRow.Index);
				ColorInDB(-16744384);
				ColorRow(-16744384, key);
				UpdateDataGrid();
			}
		}
		void ToolStripMenuItem1Click(object sender, EventArgs e)
		{
			if (this.Grid_Order.Rows.Count != 0) {
				this.Grid_Order.CurrentRow.DefaultCellStyle.ForeColor = Color.White;
				int key = Convert.ToInt32(this.Grid_Order.CurrentRow.Index);
				ColorInDB(-16744256);
				ColorRow(-16744256, key);
				UpdateDataGrid();
			}
		}
		void ДругойЦветToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (this.Grid_Order.Rows.Count != 0) {
				if (colorDialog.ShowDialog() == DialogResult.OK) {		
					int color = colorDialog.Color.ToArgb();
					int key = Convert.ToInt32(this.Grid_Order.CurrentRow.Index);
					ColorInDB(color);		
					button_ColorDialog.BackColor = System.Drawing.Color.FromArgb(color);
					ColorRow(color, key);
					UpdateDataGrid();		
				}	
			}
		}
		void СнятьВыделениеToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (this.Grid_Order.Rows.Count != 0) {
				ColorInDB(-1);
				UpdateDataGrid();
			}
		}
		void Button_SearhClick(object sender, EventArgs e)
		{
			Searh();
		}
		
		void TextBox_SearhKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				Searh();
			}
			if (e.KeyCode == Keys.Escape) {
				textBox_Searh.Text = "";
			}
		}
		void ДобавитьБЛЦБToolStripMenuItem1Click(object sender, EventArgs e)
		{
			AddBLCB_In_DB();
		}
		
	}
}

