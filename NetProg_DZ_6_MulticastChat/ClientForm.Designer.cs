namespace NetProg_DZ_6_MulticastChat
{
	partial class ClientForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			menuStrip1 = new MenuStrip();
			файлToolStripMenuItem = new ToolStripMenuItem();
			редактироватьКонфигToolStripMenuItem = new ToolStripMenuItem();
			выходToolStripMenuItem = new ToolStripMenuItem();
			splitContainer1 = new SplitContainer();
			groupBox1 = new GroupBox();
			tableLayoutPanel1 = new TableLayoutPanel();
			richTextBoxMessages = new RichTextBox();
			richTextBoxToWrite = new RichTextBox();
			groupBox2 = new GroupBox();
			listBoxClients = new ListBox();
			menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			groupBox1.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(800, 24);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { редактироватьКонфигToolStripMenuItem, выходToolStripMenuItem });
			файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			файлToolStripMenuItem.Size = new Size(48, 20);
			файлToolStripMenuItem.Text = "Файл";
			// 
			// редактироватьКонфигToolStripMenuItem
			// 
			редактироватьКонфигToolStripMenuItem.Name = "редактироватьКонфигToolStripMenuItem";
			редактироватьКонфигToolStripMenuItem.Size = new Size(198, 22);
			редактироватьКонфигToolStripMenuItem.Text = "Редактировать конфиг";
			редактироватьКонфигToolStripMenuItem.Click += EditConfigToolStripMenuItem_Click;
			// 
			// выходToolStripMenuItem
			// 
			выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			выходToolStripMenuItem.Size = new Size(198, 22);
			выходToolStripMenuItem.Text = "Выход";
			выходToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 24);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(groupBox1);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(groupBox2);
			splitContainer1.Size = new Size(800, 426);
			splitContainer1.SplitterDistance = 560;
			splitContainer1.SplitterWidth = 2;
			splitContainer1.TabIndex = 1;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(tableLayoutPanel1);
			groupBox1.Dock = DockStyle.Fill;
			groupBox1.Location = new Point(0, 0);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(560, 426);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Чат";
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.Controls.Add(richTextBoxMessages, 0, 0);
			tableLayoutPanel1.Controls.Add(richTextBoxToWrite, 0, 1);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(3, 19);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
			tableLayoutPanel1.Size = new Size(554, 404);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// richTextBoxMessages
			// 
			richTextBoxMessages.Dock = DockStyle.Fill;
			richTextBoxMessages.Location = new Point(3, 3);
			richTextBoxMessages.Name = "richTextBoxMessages";
			richTextBoxMessages.ReadOnly = true;
			richTextBoxMessages.Size = new Size(548, 276);
			richTextBoxMessages.TabIndex = 0;
			richTextBoxMessages.Text = "";
			// 
			// richTextBoxToWrite
			// 
			richTextBoxToWrite.Dock = DockStyle.Fill;
			richTextBoxToWrite.Location = new Point(3, 285);
			richTextBoxToWrite.Name = "richTextBoxToWrite";
			richTextBoxToWrite.Size = new Size(548, 116);
			richTextBoxToWrite.TabIndex = 1;
			richTextBoxToWrite.Text = "";
			richTextBoxToWrite.KeyDown += richTextBoxToWrite_KeyDown;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(listBoxClients);
			groupBox2.Dock = DockStyle.Fill;
			groupBox2.Location = new Point(0, 0);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(238, 426);
			groupBox2.TabIndex = 0;
			groupBox2.TabStop = false;
			groupBox2.Text = "Клиенты";
			// 
			// listBoxClients
			// 
			listBoxClients.Dock = DockStyle.Fill;
			listBoxClients.FormattingEnabled = true;
			listBoxClients.ItemHeight = 15;
			listBoxClients.Location = new Point(3, 19);
			listBoxClients.Name = "listBoxClients";
			listBoxClients.Size = new Size(232, 404);
			listBoxClients.TabIndex = 0;
			// 
			// ClientForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(splitContainer1);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "ClientForm";
			Text = "Чат Мультикаст";
			FormClosing += ClientForm_FormClosing;
			Load += ClientForm_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			groupBox2.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem файлToolStripMenuItem;
		private ToolStripMenuItem редактироватьКонфигToolStripMenuItem;
		private ToolStripMenuItem выходToolStripMenuItem;
		private SplitContainer splitContainer1;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private TableLayoutPanel tableLayoutPanel1;
		private RichTextBox richTextBoxMessages;
		private RichTextBox richTextBoxToWrite;
		private ListBox listBoxClients;
	}
}
