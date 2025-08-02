namespace WinDirVis
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
            this.dirList = new System.Windows.Forms.DataGridView();
            this.colFolder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dirList)).BeginInit();
            this.SuspendLayout();
            // 
            // dirList
            // 
            this.dirList.AllowUserToDeleteRows = false;
            this.dirList.AllowUserToOrderColumns = true;
            this.dirList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dirList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFolder});
            this.dirList.Location = new System.Drawing.Point(12, 12);
            this.dirList.Name = "dirList";
            this.dirList.ReadOnly = true;
            this.dirList.Size = new System.Drawing.Size(537, 537);
            this.dirList.TabIndex = 0;
            // 
            // colFolder
            // 
            this.colFolder.HeaderText = "Folder";
            this.colFolder.Name = "colFolder";
            this.colFolder.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dirList);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dirList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dirList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFolder;
    }
}

