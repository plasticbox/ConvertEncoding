namespace ConvertEncoding
{
    partial class ConvertEncodingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConvertEncodingForm));
            this.folderBox = new System.Windows.Forms.TextBox();
            this.folderButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.encodingToBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.encodingFromBox = new System.Windows.Forms.ComboBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fileExBox = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.progrssBarText = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBox
            // 
            this.folderBox.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderBox.Location = new System.Drawing.Point(9, 14);
            this.folderBox.Name = "folderBox";
            this.folderBox.Size = new System.Drawing.Size(395, 23);
            this.folderBox.TabIndex = 0;
            // 
            // folderButton
            // 
            this.folderButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderButton.Location = new System.Drawing.Point(410, 12);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(90, 23);
            this.folderButton.TabIndex = 1;
            this.folderButton.Text = "Select Folder";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.encodingToBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.encodingFromBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 50);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encoding";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "From";
            // 
            // encodingToBox
            // 
            this.encodingToBox.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encodingToBox.Location = new System.Drawing.Point(231, 21);
            this.encodingToBox.Name = "encodingToBox";
            this.encodingToBox.Size = new System.Drawing.Size(155, 23);
            this.encodingToBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "To";
            // 
            // encodingFromBox
            // 
            this.encodingFromBox.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encodingFromBox.FormattingEnabled = true;
            this.encodingFromBox.Location = new System.Drawing.Point(47, 21);
            this.encodingFromBox.Name = "encodingFromBox";
            this.encodingFromBox.Size = new System.Drawing.Size(155, 23);
            this.encodingFromBox.TabIndex = 0;
            this.encodingFromBox.SelectedIndexChanged += new System.EventHandler(this.encodingFromBox_SelectedIndexChanged);
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(410, 52);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(90, 93);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fileExBox);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 49);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Extension";
            // 
            // fileExBox
            // 
            this.fileExBox.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileExBox.Location = new System.Drawing.Point(6, 20);
            this.fileExBox.Name = "fileExBox";
            this.fileExBox.Size = new System.Drawing.Size(380, 23);
            this.fileExBox.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 153);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(488, 23);
            this.progressBar.TabIndex = 6;
            // 
            // progrssBarText
            // 
            this.progrssBarText.AutoSize = true;
            this.progrssBarText.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progrssBarText.Location = new System.Drawing.Point(191, 183);
            this.progrssBarText.Name = "progrssBarText";
            this.progrssBarText.Size = new System.Drawing.Size(103, 15);
            this.progrssBarText.TabIndex = 8;
            this.progrssBarText.Text = "Total : 0 / Done : 0";
            // 
            // ConvertEncodingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 204);
            this.Controls.Add(this.progrssBarText);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.folderButton);
            this.Controls.Add(this.folderBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConvertEncodingForm";
            this.Text = "ConvertEncoding ( euckr <-> utf8 )";
            this.Load += new System.EventHandler(this.ConvertEncodingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox folderBox;
        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox encodingToBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox encodingFromBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox fileExBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label progrssBarText;
    }
}

