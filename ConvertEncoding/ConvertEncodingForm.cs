using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace ConvertEncoding
{
    public partial class ConvertEncodingForm : Form
    {
        public delegate void delSetMaxProgressBar(int nMax);
        public delegate void delPerformStep();

        string[] strEncoding = { "EUCKR", "UTF-8" };
        public enum Type
        {
            EUCKR,
            UTF8,
        }

        ConvertProcess cp;

        public ConvertEncodingForm()
        {
            InitializeComponent();
        }
        
        private void ConvertEncodingForm_Load(object sender, EventArgs e)
        {
            // ConvertProcess 
            cp = new ConvertProcess();

            // progress Bar
            this.progressBar.Style = ProgressBarStyle.Continuous;
            cp.PerformStep = new delPerformStep(PerformStep);
            cp.SetMaxProgressBar= new delSetMaxProgressBar(SetMaxProgrssBar);

            // 확장자 초기화
            this.fileExBox.Text = "txt;h;hh;cpp";

            // 콤보 박스 초기화
            this.encodingFromBox.Items.AddRange(strEncoding);
            this.encodingFromBox.SelectedIndex = 0;
        }

        private void SetMaxProgrssBar(int nMax)
        {
            this.progressBar.Maximum = nMax;
            this.progressBar.Step = 1;
            this.progressBar.Value = 0;
        }
        private void PerformStep()
        {
            this.progressBar.PerformStep();
            this.progrssBarText.Text = "Total : " + this.progressBar.Maximum.ToString() + " / Done : " + this.progressBar.Value.ToString();
            this.progrssBarText.Refresh();
        }

        private void encodingFromBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.encodingFromBox.SelectedIndex)
            {
                case (int)Type.EUCKR:
                    {
                        this.encodingToBox.Text = strEncoding[(int)Type.UTF8];
                    }
                    break;
                case (int)Type.UTF8:
                    {
                        this.encodingToBox.Text = strEncoding[(int)Type.EUCKR];
                    }
                    break;
            }
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.folderBox.Text = this.folderBrowserDialog.SelectedPath;
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            // Folder Path 체크
            if (0 == this.folderBox.Text.Length)
            {
                MessageBox.Show("Select Folder!");
                return;
            }
            if ((File.GetAttributes(this.folderBox.Text) & FileAttributes.Directory) != FileAttributes.Directory)
            {
                MessageBox.Show("Select Folder!");
                return;
            }

            // file extension 체크
            string[] fileExtensions = this.fileExBox.Text.Split(';');
            if (0 >= fileExtensions.Count())
            {
                MessageBox.Show("File Extension is Null");
                return;
            }

            cp.FileSearch(this.folderBox.Text, fileExtensions);
            cp.ConvertingProcess(this.encodingFromBox.SelectedIndex);
        }
    }
}
