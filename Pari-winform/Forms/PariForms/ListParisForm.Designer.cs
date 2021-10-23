
namespace Pari_winform.Forms.PariForms
{
    partial class ListParisForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.sv_lst_client = new System.Windows.Forms.Button();
            this.pv_lst_client = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Client_id_tb = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchinfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountofbetsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.multiplicatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pariBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Client_id_tb);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.sv_lst_client);
            this.panel1.Controls.Add(this.pv_lst_client);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 32);
            this.panel1.TabIndex = 20;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(507, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 32);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // sv_lst_client
            // 
            this.sv_lst_client.BackColor = System.Drawing.SystemColors.Control;
            this.sv_lst_client.FlatAppearance.BorderSize = 0;
            this.sv_lst_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sv_lst_client.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.sv_lst_client.Location = new System.Drawing.Point(108, 3);
            this.sv_lst_client.Name = "sv_lst_client";
            this.sv_lst_client.Size = new System.Drawing.Size(60, 27);
            this.sv_lst_client.TabIndex = 21;
            this.sv_lst_client.Text = "Suivant";
            this.sv_lst_client.UseVisualStyleBackColor = false;
            this.sv_lst_client.Click += new System.EventHandler(this.sv_lst_client_Click);
            // 
            // pv_lst_client
            // 
            this.pv_lst_client.BackColor = System.Drawing.SystemColors.Control;
            this.pv_lst_client.FlatAppearance.BorderSize = 0;
            this.pv_lst_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv_lst_client.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.pv_lst_client.Location = new System.Drawing.Point(3, 3);
            this.pv_lst_client.Name = "pv_lst_client";
            this.pv_lst_client.Size = new System.Drawing.Size(81, 27);
            this.pv_lst_client.TabIndex = 18;
            this.pv_lst_client.Text = "Precedent";
            this.pv_lst_client.UseVisualStyleBackColor = false;
            this.pv_lst_client.Click += new System.EventHandler(this.pv_lst_client_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.clientidDataGridViewTextBoxColumn,
            this.matchinfoDataGridViewTextBoxColumn,
            this.sportcategoryDataGridViewTextBoxColumn,
            this.amountofbetsDataGridViewTextBoxColumn,
            this.multiplicatorDataGridViewTextBoxColumn,
            this.creationdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pariBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(0, 61);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(541, 424);
            this.dataGridView1.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.button1.Location = new System.Drawing.Point(263, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 24);
            this.button1.TabIndex = 25;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Client_id_tb
            // 
            this.Client_id_tb.Location = new System.Drawing.Point(207, 5);
            this.Client_id_tb.Name = "Client_id_tb";
            this.Client_id_tb.Size = new System.Drawing.Size(41, 20);
            this.Client_id_tb.TabIndex = 24;
            this.Client_id_tb.Text = "Client id";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // clientidDataGridViewTextBoxColumn
            // 
            this.clientidDataGridViewTextBoxColumn.DataPropertyName = "client_id";
            this.clientidDataGridViewTextBoxColumn.HeaderText = "client_id";
            this.clientidDataGridViewTextBoxColumn.Name = "clientidDataGridViewTextBoxColumn";
            // 
            // matchinfoDataGridViewTextBoxColumn
            // 
            this.matchinfoDataGridViewTextBoxColumn.DataPropertyName = "match_info";
            this.matchinfoDataGridViewTextBoxColumn.HeaderText = "match_info";
            this.matchinfoDataGridViewTextBoxColumn.Name = "matchinfoDataGridViewTextBoxColumn";
            this.matchinfoDataGridViewTextBoxColumn.Visible = false;
            // 
            // sportcategoryDataGridViewTextBoxColumn
            // 
            this.sportcategoryDataGridViewTextBoxColumn.DataPropertyName = "sport_category";
            this.sportcategoryDataGridViewTextBoxColumn.HeaderText = "sport_category";
            this.sportcategoryDataGridViewTextBoxColumn.Name = "sportcategoryDataGridViewTextBoxColumn";
            // 
            // amountofbetsDataGridViewTextBoxColumn
            // 
            this.amountofbetsDataGridViewTextBoxColumn.DataPropertyName = "amount_of_bets";
            this.amountofbetsDataGridViewTextBoxColumn.HeaderText = "amount_of_bets";
            this.amountofbetsDataGridViewTextBoxColumn.Name = "amountofbetsDataGridViewTextBoxColumn";
            // 
            // multiplicatorDataGridViewTextBoxColumn
            // 
            this.multiplicatorDataGridViewTextBoxColumn.DataPropertyName = "multiplicator";
            this.multiplicatorDataGridViewTextBoxColumn.HeaderText = "multiplicator";
            this.multiplicatorDataGridViewTextBoxColumn.Name = "multiplicatorDataGridViewTextBoxColumn";
            // 
            // creationdateDataGridViewTextBoxColumn
            // 
            this.creationdateDataGridViewTextBoxColumn.DataPropertyName = "creation_date";
            this.creationdateDataGridViewTextBoxColumn.HeaderText = "creation_date";
            this.creationdateDataGridViewTextBoxColumn.Name = "creationdateDataGridViewTextBoxColumn";
            this.creationdateDataGridViewTextBoxColumn.Visible = false;
            // 
            // pariBindingSource
            // 
            this.pariBindingSource.DataSource = typeof(Services.Models.Pari);
            // 
            // ListParisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(541, 482);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "ListParisForm";
            this.Text = "ListParisForm";
            this.Load += new System.EventHandler(this.ListParisForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pariBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button sv_lst_client;
        private System.Windows.Forms.Button pv_lst_client;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pariBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchinfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sportcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountofbetsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn multiplicatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Client_id_tb;
    }
}