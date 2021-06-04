
namespace I002
{
    partial class ChangeProduct
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.TxtAddProduct = new System.Windows.Forms.TextBox();
            this.LabNameProduct = new System.Windows.Forms.Label();
            this.BtnChangeProduct = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.ButtonClose);
            this.MainPanel.Controls.Add(this.TxtAddProduct);
            this.MainPanel.Controls.Add(this.LabNameProduct);
            this.MainPanel.Controls.Add(this.BtnChangeProduct);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(731, 104);
            this.MainPanel.TabIndex = 2;
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.Red;
            this.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonClose.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonClose.ForeColor = System.Drawing.Color.White;
            this.ButtonClose.Location = new System.Drawing.Point(686, 2);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(34, 33);
            this.ButtonClose.TabIndex = 35;
            this.ButtonClose.Text = "X";
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // TxtAddProduct
            // 
            this.TxtAddProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAddProduct.Location = new System.Drawing.Point(207, 49);
            this.TxtAddProduct.Name = "TxtAddProduct";
            this.TxtAddProduct.Size = new System.Drawing.Size(272, 29);
            this.TxtAddProduct.TabIndex = 8;
            this.TxtAddProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabNameProduct
            // 
            this.LabNameProduct.AutoSize = true;
            this.LabNameProduct.Location = new System.Drawing.Point(16, 49);
            this.LabNameProduct.Name = "LabNameProduct";
            this.LabNameProduct.Size = new System.Drawing.Size(185, 21);
            this.LabNameProduct.TabIndex = 7;
            this.LabNameProduct.Text = "Наименование товара:";
            // 
            // BtnChangeProduct
            // 
            this.BtnChangeProduct.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnChangeProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChangeProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnChangeProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChangeProduct.ForeColor = System.Drawing.Color.Black;
            this.BtnChangeProduct.Location = new System.Drawing.Point(485, 49);
            this.BtnChangeProduct.Name = "BtnChangeProduct";
            this.BtnChangeProduct.Size = new System.Drawing.Size(149, 30);
            this.BtnChangeProduct.TabIndex = 0;
            this.BtnChangeProduct.Text = "Изменить";
            this.BtnChangeProduct.UseVisualStyleBackColor = false;
            this.BtnChangeProduct.Click += new System.EventHandler(this.BtnChangeProduct_Click);
            // 
            // ChangeProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 104);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangeProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование продукта";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TextBox TxtAddProduct;
        private System.Windows.Forms.Label LabNameProduct;
        private System.Windows.Forms.Button BtnChangeProduct;
        private System.Windows.Forms.Button ButtonClose;
    }
}