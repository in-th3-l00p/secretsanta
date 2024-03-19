namespace SecretSanta.forms.controls
{
    partial class SessionUpdatePanel
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
            this.dataLayout = new System.Windows.Forms.TableLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.keyLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.wishlistLabel = new System.Windows.Forms.Label();
            this.wishlistLayout = new System.Windows.Forms.TableLayoutPanel();
            this.wishlist = new System.Windows.Forms.ListBox();
            this.buttonsLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.startButton = new System.Windows.Forms.Button();
            this.dataLayout.SuspendLayout();
            this.wishlistLayout.SuspendLayout();
            this.buttonsLayout.SuspendLayout();
            this.mainLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataLayout
            // 
            this.dataLayout.ColumnCount = 2;
            this.dataLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.dataLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dataLayout.Controls.Add(this.nameLabel, 0, 0);
            this.dataLayout.Controls.Add(this.locationLabel, 0, 1);
            this.dataLayout.Controls.Add(this.keyLabel, 0, 2);
            this.dataLayout.Controls.Add(this.nameTextBox, 1, 0);
            this.dataLayout.Controls.Add(this.locationTextBox, 1, 1);
            this.dataLayout.Controls.Add(this.keyTextBox, 1, 2);
            this.dataLayout.Controls.Add(this.wishlistLabel, 0, 3);
            this.dataLayout.Controls.Add(this.wishlistLayout, 1, 3);
            this.dataLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayout.Location = new System.Drawing.Point(3, 3);
            this.dataLayout.Name = "dataLayout";
            this.dataLayout.RowCount = 4;
            this.dataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.dataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.dataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.dataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dataLayout.Size = new System.Drawing.Size(541, 345);
            this.dataLayout.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(21, 6);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(90, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nume eveniment:";
            // 
            // locationLabel
            // 
            this.locationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(43, 31);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(45, 13);
            this.locationLabel.TabIndex = 2;
            this.locationLabel.Text = "Locatie:";
            // 
            // keyLabel
            // 
            this.keyLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(24, 56);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(84, 13);
            this.keyLabel.TabIndex = 4;
            this.keyLabel.Text = "Cod organizator:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Location = new System.Drawing.Point(135, 3);
            this.nameTextBox.MaximumSize = new System.Drawing.Size(255, 4);
            this.nameTextBox.MinimumSize = new System.Drawing.Size(4, 20);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(255, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.SessionTextChanged);
            // 
            // locationTextBox
            // 
            this.locationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationTextBox.Location = new System.Drawing.Point(135, 28);
            this.locationTextBox.MaximumSize = new System.Drawing.Size(255, 4);
            this.locationTextBox.MinimumSize = new System.Drawing.Size(4, 20);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(255, 20);
            this.locationTextBox.TabIndex = 3;
            this.locationTextBox.TextChanged += new System.EventHandler(this.SessionTextChanged);
            // 
            // keyTextBox
            // 
            this.keyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyTextBox.Location = new System.Drawing.Point(135, 53);
            this.keyTextBox.MaximumSize = new System.Drawing.Size(255, 4);
            this.keyTextBox.MinimumSize = new System.Drawing.Size(4, 20);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.ReadOnly = true;
            this.keyTextBox.Size = new System.Drawing.Size(255, 20);
            this.keyTextBox.TabIndex = 5;
            // 
            // wishlistLabel
            // 
            this.wishlistLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.wishlistLabel.AutoSize = true;
            this.wishlistLabel.Location = new System.Drawing.Point(43, 80);
            this.wishlistLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.wishlistLabel.Name = "wishlistLabel";
            this.wishlistLabel.Size = new System.Drawing.Size(46, 13);
            this.wishlistLabel.TabIndex = 6;
            this.wishlistLabel.Text = "Wishlist:";
            // 
            // wishlistLayout
            // 
            this.wishlistLayout.ColumnCount = 2;
            this.wishlistLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.wishlistLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.wishlistLayout.Controls.Add(this.wishlist, 0, 0);
            this.wishlistLayout.Controls.Add(this.buttonsLayout, 1, 0);
            this.wishlistLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wishlistLayout.Location = new System.Drawing.Point(135, 78);
            this.wishlistLayout.Name = "wishlistLayout";
            this.wishlistLayout.RowCount = 1;
            this.wishlistLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.wishlistLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.wishlistLayout.Size = new System.Drawing.Size(403, 264);
            this.wishlistLayout.TabIndex = 7;
            // 
            // wishlist
            // 
            this.wishlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wishlist.FormattingEnabled = true;
            this.wishlist.Location = new System.Drawing.Point(3, 3);
            this.wishlist.MaximumSize = new System.Drawing.Size(400, 250);
            this.wishlist.Name = "wishlist";
            this.wishlist.Size = new System.Drawing.Size(347, 250);
            this.wishlist.TabIndex = 7;
            // 
            // buttonsLayout
            // 
            this.buttonsLayout.Controls.Add(this.addButton);
            this.buttonsLayout.Controls.Add(this.removeButton);
            this.buttonsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.buttonsLayout.Location = new System.Drawing.Point(356, 3);
            this.buttonsLayout.Name = "buttonsLayout";
            this.buttonsLayout.Size = new System.Drawing.Size(44, 258);
            this.buttonsLayout.TabIndex = 8;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(41, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(3, 32);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(41, 23);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "-";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.Controls.Add(this.dataLayout, 0, 0);
            this.mainLayout.Controls.Add(this.startButton, 0, 1);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 2;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.mainLayout.Size = new System.Drawing.Size(547, 389);
            this.mainLayout.TabIndex = 6;
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startButton.Location = new System.Drawing.Point(236, 358);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // SessionUpdatePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainLayout);
            this.Name = "SessionUpdatePanel";
            this.Size = new System.Drawing.Size(547, 389);
            this.dataLayout.ResumeLayout(false);
            this.dataLayout.PerformLayout();
            this.wishlistLayout.ResumeLayout(false);
            this.buttonsLayout.ResumeLayout(false);
            this.mainLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel dataLayout;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label wishlistLabel;
        private System.Windows.Forms.TableLayoutPanel wishlistLayout;
        private System.Windows.Forms.ListBox wishlist;
        private System.Windows.Forms.FlowLayoutPanel buttonsLayout;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
    }
}
