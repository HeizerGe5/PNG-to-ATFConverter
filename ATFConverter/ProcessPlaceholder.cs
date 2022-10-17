using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ATFConverter
{
    public partial class ProcessPlaceholder : UserControl
    {
        public enum FormInvokeType
        {
            Result,
            Completed,
            Disposed,
            RemoveFromStack
        }
        public delegate void FormInvoke(FormInvokeType type, object[] args);

        private string _atf;
        private string _processFilePath;
        private Process process;
        private bool _usePvrtc;
        private bool _useEtc1;
        private bool _useEtc2;
        private bool _useDXT1;
        private bool _useMipMap;
        private bool _useJpeg;
        private bool _isAll;
        private bool _isQuantization;
        private string _quantization;
        private bool _isTrim;
        private string _trim;

        public ProcessPlaceholder()
        {
            InitializeComponent();
        }

        public ProcessPlaceholder(string atf, string processFilePath)
        {
            this._atf = atf;
            this._processFilePath = processFilePath;
        }

        public void Kill()
        {
            if (process != null)
            {
                try
                {
                    process.Kill();
                    process.Close();
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message + ":" + e.StackTrace);
                }
            }
        }

        public ProcessPlaceholder(string item, string atf, string processFilePath, bool isAll, bool isPVRTC, bool isETC1, bool isDXT1, bool isMipMap, bool isJpeg, bool isETC2, bool isQuantization, string quantization, bool isTrim, string trim)
        {
            this._atf = atf;
            this._processFilePath = processFilePath;
            this._isAll = isAll;
            this._usePvrtc = isPVRTC;
            this._useEtc1 = isETC1;
            this._useDXT1 = isDXT1;
            this._useMipMap = isMipMap;
            this._useJpeg = isJpeg;
            this._useEtc2 = isETC2;
            this._isQuantization = isQuantization;
            this._quantization = quantization;
            this._isTrim = isTrim;
            this._trim = trim;

            InitializeComponent();

            ProcessStartInfo info = new ProcessStartInfo(processFilePath, String.Format("{2} {3} {4} {5} {6} -i \"{0}\" -o \"{1}\"", item, atf + ".atf", MipMap, JpegLZMA, BlockCompression, Quantization, Trim));
            info.CreateNoWindow = true;
            info.RedirectStandardOutput = true;
            info.UseShellExecute = false;

            HandleCreated += ProcessPlaceholder_HandleCreated;

            process = new Process();
            process.StartInfo = info;
            process.Exited += process_Exited;
            process.OutputDataReceived += process_OutputDataReceived;
            process.Disposed += process_Disposed;
            process.EnableRaisingEvents = true;

            labelFileName.Text = item;

            labelInfo.Text = string.Format("[DXT1:{0}], [ETC1:{1}], [ETC2:{2}], [PVRTC:{3}], [MipMap:{4}], [JPEG-XR+LZMA:{5}]", isDXT1, isETC1, isETC2, isPVRTC, isMipMap, isJpeg);
        }

        void ProcessPlaceholder_HandleCreated(object sender, EventArgs e)
        {
            process.Start();
            process.BeginOutputReadLine();
        }

        void process_Disposed(object sender, EventArgs e)
        {
            Invoke(new FormInvoke(onResult), FormInvokeType.Disposed, null);
        }

        void process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Invoke(new FormInvoke(onResult), FormInvokeType.Result, new object[] { e.Data });
        }

        void process_Exited(object sender, EventArgs e)
        {
            Invoke(new FormInvoke(onResult), FormInvokeType.Completed, null);
        }

        void onResult(FormInvokeType type, object[] args)
        {
            switch (type)
            {
                case FormInvokeType.Result:
                    if (String.IsNullOrWhiteSpace((string)args[0]) == false)
                    {
                        if (labelResult.Text.Length > 0)
                        {
                            labelOutput.Text = (string)args[0];
                        }
                        else
                        {
                            labelResult.Text = (string)args[0];
                        }
                    }
                    break;
                case FormInvokeType.Completed:
                    labelResult.Text = "[COMPLETED]";
                    pictureBox.Visible = false;
                    buttonClose.Visible = true;
                    break;
                case FormInvokeType.Disposed:
                    labelResult.Text += " [DISPOSED]";
                    break;
                case FormInvokeType.RemoveFromStack:
                    if (Parent != null)
                    {
                        Parent.Controls.Remove(this);
                    }
                    break;
            }
        }

        private void ProcessPlaceholder_Load(object sender, EventArgs e)
        {

        }

        private string MipMap { get { return _useMipMap ? "" : "-n 0,0"; } }
        private string JpegLZMA { get { return _useJpeg && (_useDXT1 || _usePvrtc || _useEtc1 || _useEtc2) ? "-r" : ""; } }
        private string BlockCompression
        {
            get
            {
                if (_useDXT1)
                {
                    return "-c d";
                }
                if (_usePvrtc)
                {
                    return "-c p";
                }
                if (_useEtc1)
                {
                    return "-c e";
                }
                if (_useEtc2)
                {
                    return "-c e2";
                }
                return "";
            }
        }
        private string Quantization
        {
            get
            {
                if (_isQuantization)
                {
                    int result;
                    if (int.TryParse(_quantization, out result))
                    {
                        return "-q " + result;
                    }
                }
                return "";
            }
        }

        private string Trim
        {
            get
            {
                if (_isTrim)
                {
                    int result;
                    if (int.TryParse(_trim, out result))
                    {
                        return "-f " + result;
                    }
                }
                return "";
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (Parent != null)
            {
                Parent.Controls.Remove(this);
            }
        }
    }
}
