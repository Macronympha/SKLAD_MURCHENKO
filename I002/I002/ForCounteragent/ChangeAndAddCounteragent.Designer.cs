
namespace I002
{
    partial class ChangeAndAddCounteragent
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
            this.TxtInn = new System.Windows.Forms.MaskedTextBox();
            this.TxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAdress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMiddleName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LabName = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.LabSurname = new System.Windows.Forms.Label();
            this.BtnForAction = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.ButtonClose);
            this.MainPanel.Controls.Add(this.TxtInn);
            this.MainPanel.Controls.Add(this.TxtPhone);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.TxtAdress);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.TxtMiddleName);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.TxtName);
            this.MainPanel.Controls.Add(this.LabName);
            this.MainPanel.Controls.Add(this.TxtSurname);
            this.MainPanel.Controls.Add(this.LabSurname);
            this.MainPanel.Controls.Add(this.BtnForAction);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(451, 447);
            this.MainPanel.TabIndex = 2;
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.Red;
            this.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonClose.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonClose.ForeColor = System.Drawing.Color.White;
            this.ButtonClose.Location = new System.Drawing.Point(408, 10);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(34, 33);
            this.ButtonClose.TabIndex = 20;
            this.ButtonClose.Text = "X";
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // TxtInn
            // 
            this.TxtInn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtInn.Location = new System.Drawing.Point(165, 307);
            this.TxtInn.Mask = "000000000000";
            this.TxtInn.Name = "TxtInn";
            this.TxtInn.Size = new System.Drawing.Size(210, 29);
            this.TxtInn.TabIndex = 19;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtPhone.Location = new System.Drawing.Point(165, 258);
            this.TxtPhone.Mask = "0 (999) 000-0000";
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(210, 29);
            this.TxtPhone.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(60, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Телефон:";
            // 
            // TxtAdress
            // 
            this.TxtAdress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAdress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtAdress.Location = new System.Drawing.Point(165, 210);
            this.TxtAdress.Name = "TxtAdress";
            this.TxtAdress.Size = new System.Drawing.Size(210, 29);
            this.TxtAdress.TabIndex = 16;
            this.TxtAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(80, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Адрес:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(92, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "ИНН:";
            // 
            // TxtMiddleName
            // 
            this.TxtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMiddleName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtMiddleName.Location = new System.Drawing.Point(165, 165);
            this.TxtMiddleName.Name = "TxtMiddleName";
            this.TxtMiddleName.Size = new System.Drawing.Size(210, 29);
            this.TxtMiddleName.TabIndex = 12;
            this.TxtMiddleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(53, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Отчество:";
            // 
            // TxtName
            // 
            this.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtName.Location = new System.Drawing.Point(165, 119);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(210, 29);
            this.TxtName.TabIndex = 10;
            this.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabName
            // 
            this.LabName.AutoSize = true;
            this.LabName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabName.Location = new System.Drawing.Point(96, 120);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(47, 21);
            this.LabName.TabIndex = 9;
            this.LabName.Text = "Имя:";
            // 
            // TxtSurname
            // 
            this.TxtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSurname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtSurname.Location = new System.Drawing.Point(165, 76);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(210, 29);
            this.TxtSurname.TabIndex = 8;
            this.TxtSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabSurname
            // 
            this.LabSurname.AutoSize = true;
            this.LabSurname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabSurname.Location = new System.Drawing.Point(60, 77);
            this.LabSurname.Name = "LabSurname";
            this.LabSurname.Size = new System.Drawing.Size(84, 21);
            this.LabSurname.TabIndex = 7;
            this.LabSurname.Text = "Фамилия:";
            // 
            // BtnForAction
            // 
            this.BtnForAction.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnForAction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnForAction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnForAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnForAction.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnForAction.ForeColor = System.Drawing.Color.Black;
            this.BtnForAction.Location = new System.Drawing.Point(197, 370);
            this.BtnForAction.Name = "BtnForAction";
            this.BtnForAction.Size = new System.Drawing.Size(116, 39);
            this.BtnForAction.TabIndex = 0;
            this.BtnForAction.Text = "Добавить";
            this.BtnForAction.UseVisualStyleBackColor = false;
            this.BtnForAction.Click += new System.EventHandler(this.BtnForAction_Click);
            // 
            // ChangeAndAddCounteragent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 447);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangeAndAddCounteragent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование пользователя";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label LabSurname;
        private System.Windows.Forms.Button BtnForAction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtAdress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMiddleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LabName;
        private System.Windows.Forms.MaskedTextBox TxtPhone;
        private System.Windows.Forms.MaskedTextBox TxtInn;
        private System.Windows.Forms.Button ButtonClose;
    }
}