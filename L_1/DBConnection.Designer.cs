
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
            this.Connect = new System.Windows.Forms.ToolStripButton();
            this.Disconnect = new System.Windows.Forms.ToolStripButton();
            this.ListConnection = new System.Windows.Forms.ToolStripButton();
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
            // DBConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

