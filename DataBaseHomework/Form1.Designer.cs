
namespace DataBaseHomework
{
    partial class DBCShape
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxfrstNm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxLstNm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxDress = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtBoxfrstNm
            // 
            this.txtBoxfrstNm.BackColor = System.Drawing.Color.LightGray;
            this.txtBoxfrstNm.Location = new System.Drawing.Point(29, 44);
            this.txtBoxfrstNm.Name = "txtBoxfrstNm";
            this.txtBoxfrstNm.Size = new System.Drawing.Size(162, 20);
            this.txtBoxfrstNm.TabIndex = 0;
            this.txtBoxfrstNm.TextChanged += new System.EventHandler(this.txtBoxfrstNm_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(26, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // txtBoxLstNm
            // 
            this.txtBoxLstNm.BackColor = System.Drawing.Color.LightGray;
            this.txtBoxLstNm.Location = new System.Drawing.Point(29, 112);
            this.txtBoxLstNm.Name = "txtBoxLstNm";
            this.txtBoxLstNm.Size = new System.Drawing.Size(162, 20);
            this.txtBoxLstNm.TabIndex = 2;
            this.txtBoxLstNm.TextChanged += new System.EventHandler(this.txtBoxLstNm_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(26, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            // 
            // txtBoxDress
            // 
            this.txtBoxDress.BackColor = System.Drawing.Color.LightGray;
            this.txtBoxDress.Location = new System.Drawing.Point(29, 180);
            this.txtBoxDress.Name = "txtBoxDress";
            this.txtBoxDress.Size = new System.Drawing.Size(162, 20);
            this.txtBoxDress.TabIndex = 4;
            this.txtBoxDress.TextChanged += new System.EventHandler(this.txtBoxDress_TextChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(159, 223);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 41);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register User";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(277, 223);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(100, 41);
            this.btnUpdateUser.TabIndex = 7;
            this.btnUpdateUser.Text = "Update user list";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(207, 44);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(322, 156);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Address";
            // 
            // DBCShape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(556, 298);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxDress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxLstNm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxfrstNm);
            this.Name = "DBCShape";
            this.Text = "DBCShape";
            this.Load += new System.EventHandler(this.DBCShape_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxfrstNm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxLstNm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxDress;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

