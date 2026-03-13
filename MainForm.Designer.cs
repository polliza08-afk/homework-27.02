namespace Домашня_робота
{
    partial class MainForm
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
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            label1 = new Label();
            txtPIB = new RichTextBox();
            label2 = new Label();
            txtPhone = new RichTextBox();
            label3 = new Label();
            txtAdress = new RichTextBox();
            dgvPIB = new DataGridViewTextBoxColumn();
            dgvPhone = new DataGridViewTextBoxColumn();
            dgvAdress = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dgvPIB, dgvPhone, dgvAdress });
            dataGridView1.Location = new Point(12, 258);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(593, 286);
            dataGridView1.TabIndex = 0;
            dataGridView1.Click += SaveSubscribers_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAdd.ForeColor = Color.Blue;
            btnAdd.Location = new Point(53, 186);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 49);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Додати";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(39, 25);
            label1.TabIndex = 2;
            label1.Text = "PIB";
            // 
            // txtPIB
            // 
            txtPIB.Location = new Point(94, 12);
            txtPIB.Name = "txtPIB";
            txtPIB.Size = new Size(511, 33);
            txtPIB.TabIndex = 5;
            txtPIB.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(22, 74);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 2;
            label2.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(94, 66);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(511, 33);
            txtPhone.TabIndex = 5;
            txtPhone.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(22, 138);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 2;
            label3.Text = "Adress";
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(94, 130);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(511, 33);
            txtAdress.TabIndex = 5;
            txtAdress.Text = "";
            // 
            // dgvPIB
            // 
            dgvPIB.HeaderText = "PIB";
            dgvPIB.Name = "dgvPIB";
            dgvPIB.ReadOnly = true;
            dgvPIB.Resizable = DataGridViewTriState.True;
            dgvPIB.Width = 200;
            // 
            // dgvPhone
            // 
            dgvPhone.HeaderText = "Phone";
            dgvPhone.Name = "dgvPhone";
            dgvPhone.ReadOnly = true;
            dgvPhone.Resizable = DataGridViewTriState.True;
            dgvPhone.Width = 175;
            // 
            // dgvAdress
            // 
            dgvAdress.HeaderText = "Adress";
            dgvAdress.Name = "dgvAdress";
            dgvAdress.ReadOnly = true;
            dgvAdress.Resizable = DataGridViewTriState.True;
            dgvAdress.Width = 175;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 561);
            Controls.Add(txtAdress);
            Controls.Add(label3);
            Controls.Add(txtPhone);
            Controls.Add(label2);
            Controls.Add(txtPIB);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAdd;
        private Label label1;
        private RichTextBox txtPIB;
        private Label label2;
        private RichTextBox txtPhone;
        private Label label3;
        private RichTextBox txtAdress;
        private DataGridViewTextBoxColumn dgvPIB;
        private DataGridViewTextBoxColumn dgvPhone;
        private DataGridViewTextBoxColumn dgvAdress;
    }
}
