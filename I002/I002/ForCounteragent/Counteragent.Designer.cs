
namespace I002
{
    partial class Counteragent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.radioBuyer = new System.Windows.Forms.RadioButton();
            this.radioProvider = new System.Windows.Forms.RadioButton();
            this.labShow = new System.Windows.Forms.Label();
            this.BtnChange = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.LabFind = new System.Windows.Forms.Label();
            this.TxtFind = new System.Windows.Forms.TextBox();
            this.tableForCounteragents = new System.Windows.Forms.DataGridView();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableForCounteragents)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.ButtonBack);
            this.MainPanel.Controls.Add(this.ButtonClose);
            this.MainPanel.Controls.Add(this.radioBuyer);
            this.MainPanel.Controls.Add(this.radioProvider);
            this.MainPanel.Controls.Add(this.labShow);
            this.MainPanel.Controls.Add(this.BtnChange);
            this.MainPanel.Controls.Add(this.BtnDelete);
            this.MainPanel.Controls.Add(this.LabFind);
            this.MainPanel.Controls.Add(this.TxtFind);
            this.MainPanel.Controls.Add(this.tableForCounteragents);
            this.MainPanel.Controls.Add(this.BtnAdd);
            this.MainPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(813, 562);
            this.MainPanel.TabIndex = 2;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.Color.LightSalmon;
            this.ButtonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBack.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBack.ForeColor = System.Drawing.Color.Black;
            this.ButtonBack.Location = new System.Drawing.Point(10, 11);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(105, 33);
            this.ButtonBack.TabIndex = 22;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = false;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.Red;
            this.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonClose.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonClose.ForeColor = System.Drawing.Color.White;
            this.ButtonClose.Location = new System.Drawing.Point(770, 10);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(34, 33);
            this.ButtonClose.TabIndex = 21;
            this.ButtonClose.Text = "X";
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // radioBuyer
            // 
            this.radioBuyer.AutoSize = true;
            this.radioBuyer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBuyer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBuyer.Location = new System.Drawing.Point(137, 444);
            this.radioBuyer.Name = "radioBuyer";
            this.radioBuyer.Size = new System.Drawing.Size(127, 25);
            this.radioBuyer.TabIndex = 13;
            this.radioBuyer.Text = "Покупателей";
            this.radioBuyer.UseVisualStyleBackColor = true;
            this.radioBuyer.Click += new System.EventHandler(this.radioBuyer_Click);
            // 
            // radioProvider
            // 
            this.radioProvider.AutoSize = true;
            this.radioProvider.Checked = true;
            this.radioProvider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioProvider.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioProvider.Location = new System.Drawing.Point(137, 412);
            this.radioProvider.Name = "radioProvider";
            this.radioProvider.Size = new System.Drawing.Size(133, 25);
            this.radioProvider.TabIndex = 12;
            this.radioProvider.TabStop = true;
            this.radioProvider.Text = "Поставщиков";
            this.radioProvider.UseVisualStyleBackColor = true;
            this.radioProvider.Click += new System.EventHandler(this.radioProvider_Click);
            // 
            // labShow
            // 
            this.labShow.AutoSize = true;
            this.labShow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labShow.Location = new System.Drawing.Point(50, 412);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(82, 21);
            this.labShow.TabIndex = 11;
            this.labShow.Text = "Показать:";
            // 
            // BtnChange
            // 
            this.BtnChange.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChange.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnChange.ForeColor = System.Drawing.Color.Black;
            this.BtnChange.Location = new System.Drawing.Point(492, 412);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(111, 57);
            this.BtnChange.TabIndex = 8;
            this.BtnChange.Text = "Изменить контрагента";
            this.BtnChange.UseVisualStyleBackColor = false;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDelete.ForeColor = System.Drawing.Color.Black;
            this.BtnDelete.Location = new System.Drawing.Point(634, 412);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(125, 57);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "Удалить контрагента";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LabFind
            // 
            this.LabFind.AutoSize = true;
            this.LabFind.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabFind.Location = new System.Drawing.Point(45, 85);
            this.LabFind.Name = "LabFind";
            this.LabFind.Size = new System.Drawing.Size(161, 21);
            this.LabFind.TabIndex = 6;
            this.LabFind.Text = "Данные для поиска:";
            // 
            // TxtFind
            // 
            this.TxtFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFind.Location = new System.Drawing.Point(204, 81);
            this.TxtFind.Name = "TxtFind";
            this.TxtFind.Size = new System.Drawing.Size(556, 29);
            this.TxtFind.TabIndex = 5;
            this.TxtFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtFind.TextChanged += new System.EventHandler(this.TxtFind_TextChanged);
            // 
            // tableForCounteragents
            // 
            this.tableForCounteragents.AllowUserToAddRows = false;
            this.tableForCounteragents.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tableForCounteragents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableForCounteragents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableForCounteragents.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tableForCounteragents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableForCounteragents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableForCounteragents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableForCounteragents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableForCounteragents.Location = new System.Drawing.Point(49, 127);
            this.tableForCounteragents.MultiSelect = false;
            this.tableForCounteragents.Name = "tableForCounteragents";
            this.tableForCounteragents.ReadOnly = true;
            this.tableForCounteragents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableForCounteragents.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tableForCounteragents.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.tableForCounteragents.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tableForCounteragents.RowTemplate.Height = 35;
            this.tableForCounteragents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableForCounteragents.Size = new System.Drawing.Size(710, 272);
            this.tableForCounteragents.TabIndex = 4;
            this.tableForCounteragents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableForCounteragents_CellClick);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAdd.ForeColor = System.Drawing.Color.Black;
            this.BtnAdd.Location = new System.Drawing.Point(356, 412);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(114, 57);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Добавить контрагента";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // Counteragent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 562);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Counteragent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Контрагенты";
            this.Load += new System.EventHandler(this.Counteragent_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableForCounteragents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label LabFind;
        private System.Windows.Forms.TextBox TxtFind;
        private System.Windows.Forms.DataGridView tableForCounteragents;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label labShow;
        private System.Windows.Forms.RadioButton radioBuyer;
        private System.Windows.Forms.RadioButton radioProvider;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonBack;
    }
}