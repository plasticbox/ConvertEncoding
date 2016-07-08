using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace ConvertEncoding
{
    class ConvertProcess
    {
        public ConvertEncodingForm.delSetMaxProgressBar SetMaxProgressBar;
        public ConvertEncodingForm.delPerformStep PerformStep;

        // 코드페이지 번호 http://msdn.microsoft.com/ko-kr/library/system.text.encoding.aspx
        int euckrCodepage = 51949;

        // 인코딩을 편리하게 해주기 위해서 인코딩클래스 변수 만듬
        System.Text.Encoding utf8;
        System.Text.Encoding euckr;

        // 변환할 리스트
        List<string> convertList;

        public ConvertProcess()
        {
            this.utf8 = System.Text.Encoding.UTF8;
            this.euckr = System.Text.Encoding.GetEncoding(euckrCodepage);
            this.convertList = new List<string>();
        }

        public void FileSearch(string sDir, string[] fileExtensions)
        {
            this.convertList.Clear();
            try
            {
                foreach (string sExtension in fileExtensions)
                {
                    foreach (string searchFile in Directory.GetFiles(sDir, "*." + sExtension, SearchOption.AllDirectories))
                    {
                        this.convertList.Add(searchFile);
                    }
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
            finally
            {
                SetMaxProgressBar(this.convertList.Count());
            }
        }

        public void ConvertingProcess(int nIndex)
        {
            switch (nIndex)
            {
                case (int)ConvertEncodingForm.Type.EUCKR:
                    {
                        foreach (string filePath in this.convertList)
                        {
                            this.convertEuckrToUtf8(filePath);
                            PerformStep();
                        }
                    }
                    break;
                case (int)ConvertEncodingForm.Type.UTF8:
                    {
                        foreach (string filePath in this.convertList)
                        {
                            this.convetUtf8ToEuckr(filePath);
                            PerformStep();
                        }
                    }
                    break;
            }
        }

        public bool convertEuckrToUtf8(string filePath)
        {
            System.IO.FileInfo file = new System.IO.FileInfo(filePath);
            if (false == file.Exists)
            {
                return false;
            }
            if (Encoding.ASCII != ConvertProcess.GetEncoding(filePath))
            {
                return false;
            }

            string strContents = System.IO.File.ReadAllText(filePath, System.Text.Encoding.Default);

            byte[] arrUTFContents = utf8.GetBytes(strContents);
            byte[] arrResult = Encoding.UTF8.GetPreamble().Concat(arrUTFContents).ToArray();

            try
            {
                System.IO.File.WriteAllBytes(filePath, arrResult);

                System.IO.FileInfo newFile = new System.IO.FileInfo(filePath);
                newFile.Attributes     = file.Attributes;
                newFile.CreationTime   = file.CreationTime;
                newFile.LastAccessTime = file.LastAccessTime;
                newFile.LastWriteTime  = file.LastWriteTime;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }


            return true;
        }

        public bool convetUtf8ToEuckr(string filePath)
        {
            System.IO.FileInfo file = new System.IO.FileInfo(filePath);
            if (false == file.Exists)
            {
                return false;
            }
            if (Encoding.UTF8 != ConvertProcess.GetEncoding(filePath))
            {
                return false;
            }

            string strContents = System.IO.File.ReadAllText(filePath, utf8);

            byte[] arrEUCKRContents = euckr.GetBytes(strContents);

            try
            {
                System.IO.File.WriteAllBytes(filePath, arrEUCKRContents);

                System.IO.FileInfo newFile = new System.IO.FileInfo(filePath);
                newFile.Attributes     = file.Attributes;
                newFile.CreationTime   = file.CreationTime;
                newFile.LastAccessTime = file.LastAccessTime;
                newFile.LastWriteTime  = file.LastWriteTime;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }

            return true;
        }

        public static Encoding GetEncoding(string filename)
        {
            // Read the BOM
            var bom = new byte[4];
            using (var file = new FileStream(filename, FileMode.Open)) file.Read(bom, 0, 4);

            // Analyze the BOM
            if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76) return Encoding.UTF7;
            if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf) return Encoding.UTF8;
            if (bom[0] == 0xff && bom[1] == 0xfe) return Encoding.Unicode; //UTF-16LE
            if (bom[0] == 0xfe && bom[1] == 0xff) return Encoding.BigEndianUnicode; //UTF-16BE
            if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff) return Encoding.UTF32;
            return Encoding.ASCII;
        }
    }
}
