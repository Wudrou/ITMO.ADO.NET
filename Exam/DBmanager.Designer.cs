
namespace Exam
{
    partial class DBmanager
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
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.show = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox_IDorder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCustomer = new System.Windows.Forms.RadioButton();
            this.radioButtonOrder = new System.Windows.Forms.RadioButton();
            this.myDBDataSet = new Exam.MyDBDataSet();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(100, 10);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(167, 20);
            this.textBox_ID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID клиента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя";
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(100, 40);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(167, 20);
            this.textBox_FirstName.TabIndex = 3;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(100, 70);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(167, 20);
            this.textBox_LastName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Фамилия";
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(287, 57);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(80, 45);
            this.show.TabIndex = 6;
            this.show.Text = "Показать данные";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(373, 57);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(80, 45);
            this.add.TabIndex = 7;
            this.add.Text = "Добавить данные";
            this.add.UseVisualStyleBackColor = true;
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(459, 57);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(80, 45);
            this.change.TabIndex = 8;
            this.change.Text = "Редактировать";
            this.change.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(545, 57);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(80, 45);
            this.delete.TabIndex = 9;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(545, 108);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(166, 199);
            this.listBox1.TabIndex = 10;
            // 
            // textBox_IDorder
            // 
            this.textBox_IDorder.Location = new System.Drawing.Point(100, 100);
            this.textBox_IDorder.Name = "textBox_IDorder";
            this.textBox_IDorder.Size = new System.Drawing.Size(167, 20);
            this.textBox_IDorder.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Номер заказа";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(631, 57);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(80, 45);
            this.clear.TabIndex = 13;
            this.clear.Text = "Очистить таблицу";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonOrder);
            this.groupBox1.Controls.Add(this.radioButtonCustomer);
            this.groupBox1.Location = new System.Drawing.Point(287, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 38);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор данных";
            // 
            // radioButtonCustomer
            // 
            this.radioButtonCustomer.AutoSize = true;
            this.radioButtonCustomer.Location = new System.Drawing.Point(24, 15);
            this.radioButtonCustomer.Name = "radioButtonCustomer";
            this.radioButtonCustomer.Size = new System.Drawing.Size(69, 17);
            this.radioButtonCustomer.TabIndex = 0;
            this.radioButtonCustomer.TabStop = true;
            this.radioButtonCustomer.Text = "Клиенты";
            this.radioButtonCustomer.UseVisualStyleBackColor = true;
            // 
            // radioButtonOrder
            // 
            this.radioButtonOrder.AutoSize = true;
            this.radioButtonOrder.Location = new System.Drawing.Point(109, 15);
            this.radioButtonOrder.Name = "radioButtonOrder";
            this.radioButtonOrder.Size = new System.Drawing.Size(64, 17);
            this.radioButtonOrder.TabIndex = 1;
            this.radioButtonOrder.TabStop = true;
            this.radioButtonOrder.Text = "Заказы";
            this.radioButtonOrder.UseVisualStyleBackColor = true;
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "MyDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID клиента";
            this.columnHeader1.Width = 86;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя";
            this.columnHeader2.Width = 81;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Фамилия";
            this.columnHeader3.Width = 86;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID заказа";
            this.columnHeader4.Width = 89;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(17, 126);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(350, 181);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // DBmanager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 321);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_IDorder);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.change);
            this.Controls.Add(this.add);
            this.Controls.Add(this.show);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "DBmanager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBmanager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox_IDorder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonOrder;
        private System.Windows.Forms.RadioButton radioButtonCustomer;
        private MyDBDataSet myDBDataSet;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listView1;
    }
}

