﻿
namespace L_4._2
{
    partial class CreatingDataTable
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
            this.AddRowButton = new System.Windows.Forms.Button();
            this.TableGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TableGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AddRowButton
            // 
            this.AddRowButton.Location = new System.Drawing.Point(13, 13);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(132, 41);
            this.AddRowButton.TabIndex = 0;
            this.AddRowButton.Text = "Add Row";
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // TableGrid
            // 
            this.TableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TableGrid.Location = new System.Drawing.Point(0, 210);
            this.TableGrid.Name = "TableGrid";
            this.TableGrid.Size = new System.Drawing.Size(800, 240);
            this.TableGrid.TabIndex = 1;
            // 
            // CreatingDataTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TableGrid);
            this.Controls.Add(this.AddRowButton);
            this.Name = "CreatingDataTable";
            this.Text = "CreatingDataTable";
            this.Load += new System.EventHandler(this.CreatingDataTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddRowButton;
        private System.Windows.Forms.DataGridView TableGrid;
    }
}

