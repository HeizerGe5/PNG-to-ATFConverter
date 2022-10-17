using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ATFConverter
{
    public partial class MainForm : Form
    {

        private bool extractedFile = false;
        private string processFilePath;
        private bool lastCheckJpeg;

        public MainForm()
        {

            InitializeComponent();
            //**********
            InitializeCovertor();
            this.FormClosed += MainForm_FormClosed;
        }

        void InitializeCovertor()
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var filePath = Path.Combine(currentDirectory, "png2atf.exe");
            if (File.Exists(filePath) == false)
            {
                processFilePath = Path.GetTempFileName();
                extractedFile = true;
                byte[] png2atf = Properties.Resources.png2atf;
                File.WriteAllBytes(processFilePath, png2atf);
            }
            else
            {
                processFilePath = "png2atf.exe";
            }
        }

        void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (stack.Controls.Count > 0)
            {
                var en = stack.Controls.GetEnumerator();
                while (en.MoveNext())
                {
                    var p = (ProcessPlaceholder)en.Current;
                    p.Kill();
                }
            }
            if (extractedFile)
            {
                if (processFilePath != null)
                {
                    if (File.Exists(processFilePath))
                    {
                        try
                        {
                            File.Delete(processFilePath);
                        }
                        catch (Exception exc)
                        {
                            Debug.WriteLine(exc.Message + ":" + exc.StackTrace);
                        }
                    }
                }
            }
        }

        private void MainFormLoad(object sender, EventArgs e)
        {

        }

        private void OnDragDropSpace(object sender, DragEventArgs e)
        {
            //Console.WriteLine("Drop"); 
        }

        private void OnFormDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Link : DragDropEffects.None;
        }

        private void OnFormDragDrop(object sender, DragEventArgs e)
        {
            //Console.WriteLine("FormDrop");
            var array = e.Data.GetData(DataFormats.FileDrop);
            Convert(array as Array);
            this.Activate();
        }

        private void Convert(Array array)
        {
            if (array == null) return;
            foreach (string item in array)
            {
                var png = ".png";
                var i = item.LastIndexOf(".png");
                if (i != item.Length - png.Length)
                    continue;

                var atf = item.Remove(item.Length - png.Length, png.Length);

                ProcessPlaceholder placeholder;

                if (checkSETC1.Checked)
                {
                    placeholder = new ProcessPlaceholder(item, atf + textAndroid.Text, processFilePath, false, false, true, false, mipMapCheckBox.Checked, checkJPEGLZMA.Checked, false, checkBoxQuantization.Checked, textBoxQuantization.Text, checkBoxTrim.Checked, textBoxTrim.Text);
                    stack.Controls.Add(placeholder);
                    placeholder.Width = stack.Width - 12;
                }

                if (checkSETC2.Checked)
                {
                    placeholder = new ProcessPlaceholder(item, atf + textAndroid.Text, processFilePath, false, false, false, false, mipMapCheckBox.Checked, checkJPEGLZMA.Checked, true, checkBoxQuantization.Checked, textBoxQuantization.Text, checkBoxTrim.Checked, textBoxTrim.Text);
                    stack.Controls.Add(placeholder);
                    placeholder.Width = stack.Width - 12;
                }

                if (checkSDXT1.Checked)
                {
                    placeholder = new ProcessPlaceholder(item, atf + textWinMac.Text, processFilePath, false, false, false, true, mipMapCheckBox.Checked, checkJPEGLZMA.Checked, false, checkBoxQuantization.Checked, textBoxQuantization.Text, checkBoxTrim.Checked, textBoxTrim.Text);
                    stack.Controls.Add(placeholder);
                    placeholder.Width = stack.Width - 12;
                }

                if (checkSPVRTC.Checked)
                {
                    placeholder = new ProcessPlaceholder(item, atf + textIOS.Text, processFilePath, false, true, false, false, mipMapCheckBox.Checked, checkJPEGLZMA.Checked, false, checkBoxQuantization.Checked, textBoxQuantization.Text, checkBoxTrim.Checked, textBoxTrim.Text);
                    stack.Controls.Add(placeholder);
                    placeholder.Width = stack.Width - 12;
                }

                if (radioNone.Checked == false)
                {
                    placeholder = new ProcessPlaceholder(item, atf, processFilePath, radioAllPlatforms.Checked, radioIOS.Checked, radioAndroidETC1.Checked, radioWinMac.Checked, mipMapCheckBox.Checked, checkJPEGLZMA.Checked, radioAndroidETC2.Checked, checkBoxQuantization.Checked, textBoxQuantization.Text, checkBoxTrim.Checked, textBoxTrim.Text);
                    stack.Controls.Add(placeholder);
                    placeholder.Width = stack.Width - 12;
                }
            }
        }

        private void OnResizeStack(object sender, EventArgs e)
        {
            var enumerator = stack.Controls.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var current = (ProcessPlaceholder)enumerator.Current;
                current.Width = stack.Width - 12;
            }
        }

        private void OnChangeNone(object sender, EventArgs e)
        {
            if (radioAllPlatforms.Checked || radioNone.Checked)
            {
                checkJPEGLZMA.Enabled = false;
                lastCheckJpeg = checkJPEGLZMA.Checked;
                checkJPEGLZMA.Checked = true;
            }
            else
            {
                checkJPEGLZMA.Enabled = true;
                checkJPEGLZMA.Checked = lastCheckJpeg;
            }
        }
    }
}
