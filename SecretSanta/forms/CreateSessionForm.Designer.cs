namespace SecretSanta
{
    partial class CreateSessionForm
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
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.title = new System.Windows.Forms.Label();
            this.buttonsLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.createButton = new System.Windows.Forms.Button();
            this.inputLayout = new System.Windows.Forms.TableLayoutPanel();
            this.nameLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.locationLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.yourNameLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.yourNameLabel = new System.Windows.Forms.Label();
            this.yourNameTextBox = new System.Windows.Forms.TextBox();
            this.yourEmailLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.yourEmailLabel = new System.Windows.Forms.Label();
            this.yourEmailTextBox = new System.Windows.Forms.TextBox();
            this.mainLayout.SuspendLayout();
            this.buttonsLayout.SuspendLayout();
            this.inputLayout.SuspendLayout();
            this.nameLayout.SuspendLayout();
            this.locationLayout.SuspendLayout();
            this.yourNameLayout.SuspendLayout();
            this.yourEmailLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(this.title, 0, 0);
            this.mainLayout.Controls.Add(this.buttonsLayout, 0, 2);
            this.mainLayout.Controls.Add(this.inputLayout, 0, 1);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 3;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.mainLayout.Size = new System.Drawing.Size(800, 450);
            this.mainLayout.TabIndex = 1;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(293, 21);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(214, 33);
            this.title.TabIndex = 0;
            this.title.Text = "Create Session";
            // 
            // buttonsLayout
            // 
            this.buttonsLayout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonsLayout.AutoSize = true;
            this.buttonsLayout.Controls.Add(this.createButton);
            this.buttonsLayout.Location = new System.Drawing.Point(359, 414);
            this.buttonsLayout.Name = "buttonsLayout";
            this.buttonsLayout.Size = new System.Drawing.Size(81, 29);
            this.buttonsLayout.TabIndex = 2;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(3, 3);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // inputLayout
            // 
            this.inputLayout.ColumnCount = 1;
            this.inputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inputLayout.Controls.Add(this.nameLayout, 0, 0);
            this.inputLayout.Controls.Add(this.locationLayout, 0, 1);
            this.inputLayout.Controls.Add(this.yourNameLayout, 0, 2);
            this.inputLayout.Controls.Add(this.yourEmailLayout, 0, 3);
            this.inputLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputLayout.Location = new System.Drawing.Point(3, 79);
            this.inputLayout.Name = "inputLayout";
            this.inputLayout.RowCount = 5;
            this.inputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.inputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.inputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.inputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.inputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inputLayout.Size = new System.Drawing.Size(794, 325);
            this.inputLayout.TabIndex = 3;
            // 
            // nameLayout
            // 
            this.nameLayout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLayout.AutoSize = true;
            this.nameLayout.Controls.Add(this.nameLabel);
            this.nameLayout.Controls.Add(this.nameTextBox);
            this.nameLayout.Location = new System.Drawing.Point(272, 5);
            this.nameLayout.Name = "nameLayout";
            this.nameLayout.Size = new System.Drawing.Size(250, 26);
            this.nameLayout.TabIndex = 4;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(3, 6);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(47, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // locationLayout
            // 
            this.locationLayout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationLayout.AutoSize = true;
            this.locationLayout.Controls.Add(this.locationLabel);
            this.locationLayout.Controls.Add(this.locationTextBox);
            this.locationLayout.Location = new System.Drawing.Point(265, 41);
            this.locationLayout.Name = "locationLayout";
            this.locationLayout.Size = new System.Drawing.Size(263, 26);
            this.locationLayout.TabIndex = 5;
            // 
            // locationLabel
            // 
            this.locationLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(3, 6);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(51, 13);
            this.locationLabel.TabIndex = 0;
            this.locationLabel.Text = "Location:";
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(60, 3);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(200, 20);
            this.locationTextBox.TabIndex = 1;
            // 
            // yourNameLayout
            // 
            this.yourNameLayout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yourNameLayout.AutoSize = true;
            this.yourNameLayout.Controls.Add(this.yourNameLabel);
            this.yourNameLayout.Controls.Add(this.yourNameTextBox);
            this.yourNameLayout.Location = new System.Drawing.Point(260, 77);
            this.yourNameLayout.Name = "yourNameLayout";
            this.yourNameLayout.Size = new System.Drawing.Size(273, 26);
            this.yourNameLayout.TabIndex = 6;
            // 
            // yourNameLabel
            // 
            this.yourNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.yourNameLabel.AutoSize = true;
            this.yourNameLabel.Location = new System.Drawing.Point(3, 6);
            this.yourNameLabel.Name = "yourNameLabel";
            this.yourNameLabel.Size = new System.Drawing.Size(61, 13);
            this.yourNameLabel.TabIndex = 0;
            this.yourNameLabel.Text = "Your name:";
            // 
            // yourNameTextBox
            // 
            this.yourNameTextBox.Location = new System.Drawing.Point(70, 3);
            this.yourNameTextBox.Name = "yourNameTextBox";
            this.yourNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.yourNameTextBox.TabIndex = 1;
            // 
            // yourEmailLayout
            // 
            this.yourEmailLayout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yourEmailLayout.AutoSize = true;
            this.yourEmailLayout.Controls.Add(this.yourEmailLabel);
            this.yourEmailLayout.Controls.Add(this.yourEmailTextBox);
            this.yourEmailLayout.Location = new System.Drawing.Point(261, 113);
            this.yourEmailLayout.Name = "yourEmailLayout";
            this.yourEmailLayout.Size = new System.Drawing.Size(271, 26);
            this.yourEmailLayout.TabIndex = 7;
            // 
            // yourEmailLabel
            // 
            this.yourEmailLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.yourEmailLabel.AutoSize = true;
            this.yourEmailLabel.Location = new System.Drawing.Point(3, 6);
            this.yourEmailLabel.Name = "yourEmailLabel";
            this.yourEmailLabel.Size = new System.Drawing.Size(59, 13);
            this.yourEmailLabel.TabIndex = 0;
            this.yourEmailLabel.Text = "Your email:";
            // 
            // yourEmailTextBox
            // 
            this.yourEmailTextBox.Location = new System.Drawing.Point(68, 3);
            this.yourEmailTextBox.Name = "yourEmailTextBox";
            this.yourEmailTextBox.Size = new System.Drawing.Size(200, 20);
            this.yourEmailTextBox.TabIndex = 1;
            // 
            // CreateSessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainLayout);
            this.Name = "CreateSessionForm";
            this.Text = "Secret Santa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateSessionForm_FormClosed);
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            this.buttonsLayout.ResumeLayout(false);
            this.inputLayout.ResumeLayout(false);
            this.inputLayout.PerformLayout();
            this.nameLayout.ResumeLayout(false);
            this.nameLayout.PerformLayout();
            this.locationLayout.ResumeLayout(false);
            this.locationLayout.PerformLayout();
            this.yourNameLayout.ResumeLayout(false);
            this.yourNameLayout.PerformLayout();
            this.yourEmailLayout.ResumeLayout(false);
            this.yourEmailLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.FlowLayoutPanel buttonsLayout;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TableLayoutPanel inputLayout;
        private System.Windows.Forms.FlowLayoutPanel nameLayout;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.FlowLayoutPanel locationLayout;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.FlowLayoutPanel yourNameLayout;
        private System.Windows.Forms.Label yourNameLabel;
        private System.Windows.Forms.TextBox yourNameTextBox;
        private System.Windows.Forms.FlowLayoutPanel yourEmailLayout;
        private System.Windows.Forms.Label yourEmailLabel;
        private System.Windows.Forms.TextBox yourEmailTextBox;
    }
}