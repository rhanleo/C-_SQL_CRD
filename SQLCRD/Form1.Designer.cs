namespace SQLCRD
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_title = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_author = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_description = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TITLE";
            // 
            // txtbox_title
            // 
            this.txtbox_title.Location = new System.Drawing.Point(112, 103);
            this.txtbox_title.Name = "txtbox_title";
            this.txtbox_title.Size = new System.Drawing.Size(214, 22);
            this.txtbox_title.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(112, 338);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "ADD";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Location = new System.Drawing.Point(366, 103);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(926, 255);
            this.dgv.TabIndex = 3;
            this.dgv.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "AUTHOR";
            // 
            // txtbox_author
            // 
            this.txtbox_author.Location = new System.Drawing.Point(112, 144);
            this.txtbox_author.Name = "txtbox_author";
            this.txtbox_author.Size = new System.Drawing.Size(214, 22);
            this.txtbox_author.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "DESCRIPTION";
            // 
            // txtbox_description
            // 
            this.txtbox_description.Location = new System.Drawing.Point(112, 184);
            this.txtbox_description.Multiline = true;
            this.txtbox_description.Name = "txtbox_description";
            this.txtbox_description.Size = new System.Drawing.Size(214, 139);
            this.txtbox_description.TabIndex = 1;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(193, 338);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(274, 338);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_title.Location = new System.Drawing.Point(281, 21);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(752, 58);
            this.lbl_title.TabIndex = 4;
            this.lbl_title.Text = "ULTIMATE SUCCESS BOOKS ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 578);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txtbox_description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_author);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_title);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Name = "Form1";
            this.Text = "SQLCRD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_title;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_author;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_description;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lbl_title;
    }
}

