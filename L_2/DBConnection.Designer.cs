
namespace L_1
{
    partial class DBConnection
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBConnection));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ListConnection = new System.Windows.Forms.ToolStripButton();
            this.Connect = new System.Windows.Forms.ToolStripButton();
            this.Disconnect = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListConnection,
            this.Connect,
            this.Disconnect});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ListConnection
            // 
            this.ListConnection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ListConnection.Image = ((System.Drawing.Image)(resources.GetObject("ListConnection.Image")));
            this.ListConnection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ListConnection.Name = "ListConnection";
            this.ListConnection.Size = new System.Drawing.Size(92, 22);
            this.ListConnection.Text = "List connection";
            this.ListConnection.Click += new System.EventHandler(this.ListConnection_Click);
            // 
            // Connect
            // 
            this.Connect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Connect.Image = ((System.Drawing.Image)(resources.GetObject("Connect.Image")));
            this.Connect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(56, 22);
            this.Connect.Text = "Connect";
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Disconnect
            // 
            this.Disconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Disconnect.Image = ((System.Drawing.Image)(resources.GetObject("Disconnect.Image")));
            this.Disconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(70, 22);
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сколько продуктов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сколько продуктов";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Список продуктов";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(156, 65);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(180, 143);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название продукта";
            this.columnHeader1.Width = 113;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(356, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 29);
            this.button3.TabIndex = 5;
            this.button3.Text = "Транзакция";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DBConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DBConnection";
            this.Text = "DBConnection";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Connect;
        private System.Windows.Forms.ToolStripButton Disconnect;
        private System.Windows.Forms.ToolStripButton ListConnection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button button3;
    }
}

