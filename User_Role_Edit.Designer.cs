
namespace OPD_ASSIGNMENT
{
    partial class User_Role_Edit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_userrole = new System.Windows.Forms.TextBox();
            this.lbl_userrole = new System.Windows.Forms.Label();
            this.btn_ur_update = new System.Windows.Forms.Button();
            this.btn_ur_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cob_ur_status = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cob_ur_status);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_ur_delete);
            this.groupBox1.Controls.Add(this.txt_userrole);
            this.groupBox1.Controls.Add(this.lbl_userrole);
            this.groupBox1.Controls.Add(this.btn_ur_update);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 251);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UPDATE USER ROLE";
            // 
            // txt_userrole
            // 
            this.txt_userrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userrole.Location = new System.Drawing.Point(11, 68);
            this.txt_userrole.Name = "txt_userrole";
            this.txt_userrole.Size = new System.Drawing.Size(659, 30);
            this.txt_userrole.TabIndex = 6;
            // 
            // lbl_userrole
            // 
            this.lbl_userrole.AutoSize = true;
            this.lbl_userrole.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbl_userrole.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl_userrole.Location = new System.Drawing.Point(6, 40);
            this.lbl_userrole.Name = "lbl_userrole";
            this.lbl_userrole.Size = new System.Drawing.Size(106, 25);
            this.lbl_userrole.TabIndex = 7;
            this.lbl_userrole.Text = "Role Name";
            // 
            // btn_ur_update
            // 
            this.btn_ur_update.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_ur_update.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_ur_update.FlatAppearance.BorderSize = 0;
            this.btn_ur_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ur_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ur_update.ForeColor = System.Drawing.Color.White;
            this.btn_ur_update.Location = new System.Drawing.Point(342, 196);
            this.btn_ur_update.Name = "btn_ur_update";
            this.btn_ur_update.Size = new System.Drawing.Size(139, 34);
            this.btn_ur_update.TabIndex = 4;
            this.btn_ur_update.Text = "Update";
            this.btn_ur_update.UseVisualStyleBackColor = false;
            this.btn_ur_update.Click += new System.EventHandler(this.btn_ur_update_Click);
            // 
            // btn_ur_delete
            // 
            this.btn_ur_delete.BackColor = System.Drawing.Color.Red;
            this.btn_ur_delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_ur_delete.FlatAppearance.BorderSize = 0;
            this.btn_ur_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ur_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ur_delete.ForeColor = System.Drawing.Color.White;
            this.btn_ur_delete.Location = new System.Drawing.Point(531, 196);
            this.btn_ur_delete.Name = "btn_ur_delete";
            this.btn_ur_delete.Size = new System.Drawing.Size(139, 34);
            this.btn_ur_delete.TabIndex = 8;
            this.btn_ur_delete.Text = "Delete";
            this.btn_ur_delete.UseVisualStyleBackColor = false;
            this.btn_ur_delete.Click += new System.EventHandler(this.btn_ur_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(487, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "OR";
            // 
            // cob_ur_status
            // 
            this.cob_ur_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_ur_status.FormattingEnabled = true;
            this.cob_ur_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cob_ur_status.Location = new System.Drawing.Point(11, 139);
            this.cob_ur_status.Name = "cob_ur_status";
            this.cob_ur_status.Size = new System.Drawing.Size(659, 33);
            this.cob_ur_status.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(6, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Status";
            // 
            // User_Role_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 267);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "User_Role_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_Role_Edit";
            this.Load += new System.EventHandler(this.User_Role_Edit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_userrole;
        private System.Windows.Forms.Label lbl_userrole;
        private System.Windows.Forms.Button btn_ur_update;
        private System.Windows.Forms.Button btn_ur_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cob_ur_status;
    }
}