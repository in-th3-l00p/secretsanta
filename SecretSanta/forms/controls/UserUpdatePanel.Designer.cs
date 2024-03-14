namespace SecretSanta.forms.controls
{
    partial class UserUpdatePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.keyLabel = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.keyLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.keyTextBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.emailTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.emailLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(571, 404);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // keyLabel
            // 
            this.keyLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(22, 56);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(29, 13);
            this.keyLabel.TabIndex = 5;
            this.keyLabel.Text = "Cod:";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyTextBox.Enabled = false;
            this.keyTextBox.Location = new System.Drawing.Point(76, 53);
            this.keyTextBox.MaximumSize = new System.Drawing.Size(400, 4);
            this.keyTextBox.MinimumSize = new System.Drawing.Size(4, 20);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.ReadOnly = true;
            this.keyTextBox.Size = new System.Drawing.Size(400, 20);
            this.keyTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailTextBox.Location = new System.Drawing.Point(76, 28);
            this.emailTextBox.MaximumSize = new System.Drawing.Size(400, 4);
            this.emailTextBox.MinimumSize = new System.Drawing.Size(4, 20);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(400, 20);
            this.emailTextBox.TabIndex = 3;
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(19, 31);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email:";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(17, 6);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nume:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Location = new System.Drawing.Point(76, 3);
            this.nameTextBox.MaximumSize = new System.Drawing.Size(400, 4);
            this.nameTextBox.MinimumSize = new System.Drawing.Size(4, 20);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(400, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // UserUpdatePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserUpdatePanel";
            this.Size = new System.Drawing.Size(571, 404);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.TextBox keyTextBox;
    }
}
