namespace Zork_WinFB
{
    partial class InventoryManager
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
            this.selectfileButton = new System.Windows.Forms.Button();
            this.fileLabel = new System.Windows.Forms.Label();
            this.filenameTextBox = new System.Windows.Forms.TextBox();
            this.worldViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.PlayersTabPage = new System.Windows.Forms.TabPage();
            this.DeletePlayerButton = new System.Windows.Forms.Button();
            this.AddPlayerButton = new System.Windows.Forms.Button();
            this.PlayersListBox = new System.Windows.Forms.ListBox();
            this.PlayersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WorldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemsTabPage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PlayerNameLabel = new System.Windows.Forms.Label();
            this.PlayerNameTextBox = new System.Windows.Forms.TextBox();
            this.PlayerHealthTextBox = new System.Windows.Forms.TextBox();
            this.PlayerHealthLabel = new System.Windows.Forms.Label();
            this.PlayerScoreTextBox = new System.Windows.Forms.TextBox();
            this.PlayerScoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).BeginInit();
            this.MainTabControl.SuspendLayout();
            this.PlayersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorldBindingSource)).BeginInit();
            this.ItemsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // selectfileButton
            // 
            this.selectfileButton.Location = new System.Drawing.Point(759, 9);
            this.selectfileButton.Name = "selectfileButton";
            this.selectfileButton.Size = new System.Drawing.Size(29, 23);
            this.selectfileButton.TabIndex = 0;
            this.selectfileButton.Text = "...";
            this.selectfileButton.UseVisualStyleBackColor = true;
            this.selectfileButton.Click += new System.EventHandler(this.SelectfileButton_Click);
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(12, 13);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(26, 13);
            this.fileLabel.TabIndex = 1;
            this.fileLabel.Text = "File:";
            this.fileLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // filenameTextBox
            // 
            this.filenameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.worldViewModelBindingSource, "Filename", true));
            this.filenameTextBox.Location = new System.Drawing.Point(44, 9);
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.Size = new System.Drawing.Size(709, 20);
            this.filenameTextBox.TabIndex = 2;
            // 
            // worldViewModelBindingSource
            // 
            this.worldViewModelBindingSource.DataSource = typeof(Zork_WinFB.ViewModels.WorldViewModel);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "World Files (*json)|*.json";
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.PlayersTabPage);
            this.MainTabControl.Controls.Add(this.ItemsTabPage);
            this.MainTabControl.Location = new System.Drawing.Point(15, 35);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(773, 403);
            this.MainTabControl.TabIndex = 3;
            // 
            // PlayersTabPage
            // 
            this.PlayersTabPage.Controls.Add(this.PlayerScoreTextBox);
            this.PlayersTabPage.Controls.Add(this.PlayerScoreLabel);
            this.PlayersTabPage.Controls.Add(this.PlayerHealthTextBox);
            this.PlayersTabPage.Controls.Add(this.PlayerHealthLabel);
            this.PlayersTabPage.Controls.Add(this.PlayerNameTextBox);
            this.PlayersTabPage.Controls.Add(this.PlayerNameLabel);
            this.PlayersTabPage.Controls.Add(this.DeletePlayerButton);
            this.PlayersTabPage.Controls.Add(this.AddPlayerButton);
            this.PlayersTabPage.Controls.Add(this.PlayersListBox);
            this.PlayersTabPage.Location = new System.Drawing.Point(4, 22);
            this.PlayersTabPage.Name = "PlayersTabPage";
            this.PlayersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PlayersTabPage.Size = new System.Drawing.Size(765, 377);
            this.PlayersTabPage.TabIndex = 0;
            this.PlayersTabPage.Text = "Players";
            this.PlayersTabPage.UseVisualStyleBackColor = true;
            // 
            // DeletePlayerButton
            // 
            this.DeletePlayerButton.Location = new System.Drawing.Point(160, 341);
            this.DeletePlayerButton.Name = "DeletePlayerButton";
            this.DeletePlayerButton.Size = new System.Drawing.Size(75, 23);
            this.DeletePlayerButton.TabIndex = 2;
            this.DeletePlayerButton.Text = "&Delete";
            this.DeletePlayerButton.UseVisualStyleBackColor = true;
            // 
            // AddPlayerButton
            // 
            this.AddPlayerButton.Location = new System.Drawing.Point(25, 341);
            this.AddPlayerButton.Name = "AddPlayerButton";
            this.AddPlayerButton.Size = new System.Drawing.Size(75, 23);
            this.AddPlayerButton.TabIndex = 1;
            this.AddPlayerButton.Text = "&Add...";
            this.AddPlayerButton.UseVisualStyleBackColor = true;
            // 
            // PlayersListBox
            // 
            this.PlayersListBox.DataSource = this.PlayersBindingSource;
            this.PlayersListBox.DisplayMember = "Name";
            this.PlayersListBox.FormattingEnabled = true;
            this.PlayersListBox.Location = new System.Drawing.Point(25, 6);
            this.PlayersListBox.Name = "PlayersListBox";
            this.PlayersListBox.Size = new System.Drawing.Size(210, 329);
            this.PlayersListBox.TabIndex = 0;
            // 
            // PlayersBindingSource
            // 
            this.PlayersBindingSource.DataMember = "Players";
            this.PlayersBindingSource.DataSource = this.WorldBindingSource;
            // 
            // WorldBindingSource
            // 
            this.WorldBindingSource.DataMember = "World";
            this.WorldBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // ItemsTabPage
            // 
            this.ItemsTabPage.Controls.Add(this.button1);
            this.ItemsTabPage.Controls.Add(this.button2);
            this.ItemsTabPage.Controls.Add(this.ItemsListBox);
            this.ItemsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ItemsTabPage.Name = "ItemsTabPage";
            this.ItemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTabPage.Size = new System.Drawing.Size(765, 377);
            this.ItemsTabPage.TabIndex = 1;
            this.ItemsTabPage.Text = "Items";
            this.ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "&Add...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.DataSource = this.itemsBindingSource;
            this.ItemsListBox.DisplayMember = "Name";
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(6, 3);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(187, 303);
            this.ItemsListBox.TabIndex = 0;
            this.ItemsListBox.ValueMember = "Name";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.WorldBindingSource;
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.AutoSize = true;
            this.PlayerNameLabel.Location = new System.Drawing.Point(250, 6);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(35, 13);
            this.PlayerNameLabel.TabIndex = 3;
            this.PlayerNameLabel.Text = "&Name";
            // 
            // PlayerNameTextBox
            // 
            this.PlayerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PlayersBindingSource, "Name", true));
            this.PlayerNameTextBox.Location = new System.Drawing.Point(253, 23);
            this.PlayerNameTextBox.Name = "PlayerNameTextBox";
            this.PlayerNameTextBox.Size = new System.Drawing.Size(239, 20);
            this.PlayerNameTextBox.TabIndex = 4;
            // 
            // PlayerHealthTextBox
            // 
            this.PlayerHealthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PlayersBindingSource, "Health", true));
            this.PlayerHealthTextBox.Location = new System.Drawing.Point(253, 69);
            this.PlayerHealthTextBox.Name = "PlayerHealthTextBox";
            this.PlayerHealthTextBox.Size = new System.Drawing.Size(88, 20);
            this.PlayerHealthTextBox.TabIndex = 6;
            // 
            // PlayerHealthLabel
            // 
            this.PlayerHealthLabel.AutoSize = true;
            this.PlayerHealthLabel.Location = new System.Drawing.Point(250, 52);
            this.PlayerHealthLabel.Name = "PlayerHealthLabel";
            this.PlayerHealthLabel.Size = new System.Drawing.Size(41, 13);
            this.PlayerHealthLabel.TabIndex = 5;
            this.PlayerHealthLabel.Text = "&Health:";
            // 
            // PlayerScoreTextBox
            // 
            this.PlayerScoreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PlayersBindingSource, "Score", true));
            this.PlayerScoreTextBox.Location = new System.Drawing.Point(253, 114);
            this.PlayerScoreTextBox.Name = "PlayerScoreTextBox";
            this.PlayerScoreTextBox.Size = new System.Drawing.Size(88, 20);
            this.PlayerScoreTextBox.TabIndex = 8;
            // 
            // PlayerScoreLabel
            // 
            this.PlayerScoreLabel.AutoSize = true;
            this.PlayerScoreLabel.Location = new System.Drawing.Point(250, 97);
            this.PlayerScoreLabel.Name = "PlayerScoreLabel";
            this.PlayerScoreLabel.Size = new System.Drawing.Size(38, 13);
            this.PlayerScoreLabel.TabIndex = 7;
            this.PlayerScoreLabel.Text = "&Score:";
            // 
            // InventoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.filenameTextBox);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.selectfileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InventoryManager";
            this.Text = "Inventorymanager";
            this.Load += new System.EventHandler(this.InventoryManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).EndInit();
            this.MainTabControl.ResumeLayout(false);
            this.PlayersTabPage.ResumeLayout(false);
            this.PlayersTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorldBindingSource)).EndInit();
            this.ItemsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectfileButton;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.TextBox filenameTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource worldViewModelBindingSource;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage PlayersTabPage;
        private System.Windows.Forms.TabPage ItemsTabPage;
        private System.Windows.Forms.Button DeletePlayerButton;
        private System.Windows.Forms.Button AddPlayerButton;
        private System.Windows.Forms.ListBox PlayersListBox;
        private System.Windows.Forms.BindingSource WorldBindingSource;
        private System.Windows.Forms.BindingSource PlayersBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.TextBox PlayerScoreTextBox;
        private System.Windows.Forms.Label PlayerScoreLabel;
        private System.Windows.Forms.TextBox PlayerHealthTextBox;
        private System.Windows.Forms.Label PlayerHealthLabel;
        private System.Windows.Forms.TextBox PlayerNameTextBox;
        private System.Windows.Forms.Label PlayerNameLabel;
    }
}

