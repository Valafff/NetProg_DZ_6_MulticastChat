namespace NetProg_DZ_6_MulticastChat
{
	partial class EditConfigForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			tableLayoutPanel1 = new TableLayoutPanel();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			textBox_ID = new TextBox();
			textBox_Name = new TextBox();
			textBox_IPMulticast = new TextBox();
			textBox_Port = new TextBox();
			button_Save = new Button();
			button_Exit = new Button();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(label1, 0, 0);
			tableLayoutPanel1.Controls.Add(label2, 0, 1);
			tableLayoutPanel1.Controls.Add(label3, 0, 2);
			tableLayoutPanel1.Controls.Add(label4, 0, 3);
			tableLayoutPanel1.Controls.Add(textBox_ID, 1, 0);
			tableLayoutPanel1.Controls.Add(textBox_Name, 1, 1);
			tableLayoutPanel1.Controls.Add(textBox_IPMulticast, 1, 2);
			tableLayoutPanel1.Controls.Add(textBox_Port, 1, 3);
			tableLayoutPanel1.Controls.Add(button_Save, 0, 4);
			tableLayoutPanel1.Controls.Add(button_Exit, 1, 4);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 5;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.Size = new Size(484, 141);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Dock = DockStyle.Fill;
			label1.Location = new Point(3, 0);
			label1.Name = "label1";
			label1.Size = new Size(236, 28);
			label1.TabIndex = 0;
			label1.Text = "ID";
			label1.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Dock = DockStyle.Fill;
			label2.Location = new Point(3, 28);
			label2.Name = "label2";
			label2.Size = new Size(236, 28);
			label2.TabIndex = 1;
			label2.Text = "Имя";
			label2.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Dock = DockStyle.Fill;
			label3.Location = new Point(3, 56);
			label3.Name = "label3";
			label3.Size = new Size(236, 28);
			label3.TabIndex = 2;
			label3.Text = "Multicast-адрес";
			label3.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Dock = DockStyle.Fill;
			label4.Location = new Point(3, 84);
			label4.Name = "label4";
			label4.Size = new Size(236, 28);
			label4.TabIndex = 3;
			label4.Text = "Порт";
			label4.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// textBox_ID
			// 
			textBox_ID.Dock = DockStyle.Fill;
			textBox_ID.Location = new Point(245, 3);
			textBox_ID.Name = "textBox_ID";
			textBox_ID.Size = new Size(236, 23);
			textBox_ID.TabIndex = 4;
			// 
			// textBox_Name
			// 
			textBox_Name.Dock = DockStyle.Fill;
			textBox_Name.Location = new Point(245, 31);
			textBox_Name.Name = "textBox_Name";
			textBox_Name.Size = new Size(236, 23);
			textBox_Name.TabIndex = 5;
			// 
			// textBox_IPMulticast
			// 
			textBox_IPMulticast.Dock = DockStyle.Fill;
			textBox_IPMulticast.Location = new Point(245, 59);
			textBox_IPMulticast.Name = "textBox_IPMulticast";
			textBox_IPMulticast.Size = new Size(236, 23);
			textBox_IPMulticast.TabIndex = 6;
			// 
			// textBox_Port
			// 
			textBox_Port.Dock = DockStyle.Fill;
			textBox_Port.Location = new Point(245, 87);
			textBox_Port.Name = "textBox_Port";
			textBox_Port.Size = new Size(236, 23);
			textBox_Port.TabIndex = 7;
			// 
			// button_Save
			// 
			button_Save.Dock = DockStyle.Fill;
			button_Save.Location = new Point(3, 115);
			button_Save.Name = "button_Save";
			button_Save.Size = new Size(236, 23);
			button_Save.TabIndex = 8;
			button_Save.Text = "Сохранить";
			button_Save.UseVisualStyleBackColor = true;
			button_Save.Click += button_Save_Click;
			// 
			// button_Exit
			// 
			button_Exit.Dock = DockStyle.Fill;
			button_Exit.Location = new Point(245, 115);
			button_Exit.Name = "button_Exit";
			button_Exit.Size = new Size(236, 23);
			button_Exit.TabIndex = 9;
			button_Exit.Text = "Закрыть окно";
			button_Exit.UseVisualStyleBackColor = true;
			button_Exit.Click += button_Exit_Click;
			// 
			// EditConfigForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(484, 141);
			Controls.Add(tableLayoutPanel1);
			Name = "EditConfigForm";
			Text = "Редактирование конфига";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox textBox_ID;
		private TextBox textBox_Name;
		private TextBox textBox_IPMulticast;
		private TextBox textBox_Port;
		private Button button_Save;
		private Button button_Exit;
	}
}