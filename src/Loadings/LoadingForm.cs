using AxataPOS.App.Common.Interfaces;
using AxataPOS.App.Componen;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AxataPOS.App.Common
{
    public partial class LoadingForm : KryptonForm, ILoadingForm
    {
        private AxataBackgroundWorker worker;
        private object _result = null;
        private Exception _exception = null;

        public event ILoadingForm.WorkerDoWork DoWorkEvent;

        public LoadingForm()
        {
            InitializeComponent();
            this.AcceptButton = null;
            this.KeyPreview = true;
            InitBackgroundWorker();
        }

        private void InitBackgroundWorker()
        {
            worker = new();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.WorkerSupportsCancellation = false;
            worker.WorkerReportsProgress = true;
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                _exception = e.Error;
            }
            this.Exit();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            _result = DoWorkEvent?.Invoke(sender, e);
        }

        private void BaseLoadingForm_Load(object sender, EventArgs e)
        {
            this.progressBar.Focus();
            worker.RunWorkerAsync();
        }

        public virtual void Exit()
        {
            this.Close();
        }

        public void Run()
        {
            this.ShowDialog();
        }

        public object GetResult()
        {
            if (_exception != null) throw _exception;

            return _result;
        }

        public void SetWorkFunction(ILoadingForm.WorkerDoWork workFunction)
        {
            DoWorkEvent = workFunction;
        }

        public void SetTitle(string title)
        {
            this.LblTitle.Text = title;
        }

        public void SetKeterangan(string keterangan)
        {
            this.LblKeterangan.Text = keterangan;
        }

        public void CanBeCancelled(bool cancel)
        {
            worker.WorkerSupportsCancellation = cancel;
        }

        private void LoadingForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void LoadingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (worker.IsBusy && worker.WorkerSupportsCancellation)
            {
                worker.CancelAsync();
            }

            if (worker.IsBusy)
            {
                e.Cancel = true;
            }
        }
    }
}
