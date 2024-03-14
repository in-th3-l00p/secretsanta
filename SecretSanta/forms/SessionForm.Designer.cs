namespace SecretSanta
{
    partial class SessionForm
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
            this.listLayout = new System.Windows.Forms.TableLayoutPanel();
            this.buttonsLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.usersList = new System.Windows.Forms.ListView();
            this.sessionUpdatePanel = new SecretSanta.forms.controls.SessionUpdatePanel();
            this.mainLayout.SuspendLayout();
            this.listLayout.SuspendLayout();
            this.buttonsLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 227F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(this.listLayout, 0, 0);
            this.mainLayout.Controls.Add(this.sessionUpdatePanel, 1, 0);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 1;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.Size = new System.Drawing.Size(800, 450);
            this.mainLayout.TabIndex = 0;
            // 
            // listLayout
            // 
            this.listLayout.ColumnCount = 1;
            this.listLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.listLayout.Controls.Add(this.buttonsLayout, 0, 1);
            this.listLayout.Controls.Add(this.usersList, 0, 0);
            this.listLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLayout.Location = new System.Drawing.Point(3, 3);
            this.listLayout.Name = "listLayout";
            this.listLayout.RowCount = 2;
            this.listLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.listLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.listLayout.Size = new System.Drawing.Size(221, 444);
            this.listLayout.TabIndex = 0;
            // 
            // buttonsLayout
            // 
            this.buttonsLayout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonsLayout.AutoSize = true;
            this.buttonsLayout.Controls.Add(this.AddButton);
            this.buttonsLayout.Controls.Add(this.RemoveButton);
            this.buttonsLayout.Location = new System.Drawing.Point(29, 408);
            this.buttonsLayout.Name = "buttonsLayout";
            this.buttonsLayout.Size = new System.Drawing.Size(162, 29);
            this.buttonsLayout.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Enabled = false;
            this.RemoveButton.Location = new System.Drawing.Point(84, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // usersList
            // 
            this.usersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersList.HideSelection = false;
            this.usersList.Location = new System.Drawing.Point(3, 3);
            this.usersList.Name = "usersList";
            this.usersList.Size = new System.Drawing.Size(215, 395);
            this.usersList.TabIndex = 1;
            this.usersList.UseCompatibleStateImageBehavior = false;
            this.usersList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.usersList_ItemSelectionChanged);
            // 
            // sessionUpdatePanel
            // 
            this.sessionUpdatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sessionUpdatePanel.Location = new System.Drawing.Point(230, 3);
            this.sessionUpdatePanel.Name = "sessionUpdatePanel";
            this.sessionUpdatePanel.Session = null;
            this.sessionUpdatePanel.SessionKey = null;
            this.sessionUpdatePanel.Size = new System.Drawing.Size(567, 444);
            this.sessionUpdatePanel.TabIndex = 1;
            // 
            // SessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainLayout);
            this.Name = "SessionForm";
            this.Text = "Secret Santa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SessionForm_FormClosed);
            this.mainLayout.ResumeLayout(false);
            this.listLayout.ResumeLayout(false);
            this.listLayout.PerformLayout();
            this.buttonsLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.TableLayoutPanel listLayout;
        private System.Windows.Forms.FlowLayoutPanel buttonsLayout;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.ListView usersList;
        private forms.controls.SessionUpdatePanel sessionUpdatePanel;
    }
}