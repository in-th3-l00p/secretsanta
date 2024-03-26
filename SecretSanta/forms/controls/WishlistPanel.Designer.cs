namespace SecretSanta.forms.controls
{
    partial class WishlistPanel
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
            this.chosenWishlist = new System.Windows.Forms.ListBox();
            this.chosenWishlistLabel = new System.Windows.Forms.Label();
            this.buttonsLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.wishlistLabel = new System.Windows.Forms.Label();
            this.wishlist = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.buttonsLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.Controls.Add(this.chosenWishlist, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.chosenWishlistLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonsLayout, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.wishlistLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.wishlist, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(648, 537);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chosenWishlist
            // 
            this.chosenWishlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chosenWishlist.FormattingEnabled = true;
            this.chosenWishlist.Location = new System.Drawing.Point(91, 253);
            this.chosenWishlist.MaximumSize = new System.Drawing.Size(400, 250);
            this.chosenWishlist.Name = "chosenWishlist";
            this.chosenWishlist.Size = new System.Drawing.Size(400, 244);
            this.chosenWishlist.TabIndex = 11;
            // 
            // chosenWishlistLabel
            // 
            this.chosenWishlistLabel.AutoSize = true;
            this.chosenWishlistLabel.Location = new System.Drawing.Point(3, 250);
            this.chosenWishlistLabel.Name = "chosenWishlistLabel";
            this.chosenWishlistLabel.Size = new System.Drawing.Size(82, 13);
            this.chosenWishlistLabel.TabIndex = 10;
            this.chosenWishlistLabel.Text = "Chosen wishlist:";
            // 
            // buttonsLayout
            // 
            this.buttonsLayout.Controls.Add(this.addButton);
            this.buttonsLayout.Controls.Add(this.removeButton);
            this.buttonsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.buttonsLayout.Location = new System.Drawing.Point(604, 3);
            this.buttonsLayout.Name = "buttonsLayout";
            this.buttonsLayout.Size = new System.Drawing.Size(41, 244);
            this.buttonsLayout.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(41, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(3, 32);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(41, 23);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "-";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // wishlistLabel
            // 
            this.wishlistLabel.AutoSize = true;
            this.wishlistLabel.Location = new System.Drawing.Point(3, 0);
            this.wishlistLabel.Name = "wishlistLabel";
            this.wishlistLabel.Size = new System.Drawing.Size(46, 13);
            this.wishlistLabel.TabIndex = 0;
            this.wishlistLabel.Text = "Wishlist:";
            // 
            // wishlist
            // 
            this.wishlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wishlist.FormattingEnabled = true;
            this.wishlist.Location = new System.Drawing.Point(91, 3);
            this.wishlist.MaximumSize = new System.Drawing.Size(400, 250);
            this.wishlist.Name = "wishlist";
            this.wishlist.Size = new System.Drawing.Size(400, 244);
            this.wishlist.TabIndex = 1;
            this.wishlist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.wishlist_MouseDoubleClick);
            // 
            // WishlistPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WishlistPanel";
            this.Size = new System.Drawing.Size(648, 537);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.buttonsLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label wishlistLabel;
        private System.Windows.Forms.ListBox wishlist;
        private System.Windows.Forms.FlowLayoutPanel buttonsLayout;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label chosenWishlistLabel;
        private System.Windows.Forms.ListBox chosenWishlist;
    }
}
