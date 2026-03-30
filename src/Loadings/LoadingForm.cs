using AxataPOS.App.Componen;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AxataPOS.App.Common;

public partial class LoadingForm : KryptonForm
{
    private readonly AxataBackgroundWorker worker = new();
    private Exception _exception = null;
    private Action<Exception> errorHandler;
    private Action callback;
    private Func<object> callbackWithResult;
    private object result = null;

    public LoadingForm()
    {
        InitializeComponent();
        this.AcceptButton = null;
        this.KeyPreview = true;
        DialogResult = DialogResult.None;

        worker.DoWork += Worker_DoWork;
        worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        worker.WorkerSupportsCancellation = false;
        worker.WorkerReportsProgress = true;
    }

    public static LoadingForm Create()
    {
        return new LoadingForm();
    }

    public LoadingForm SetCancelable(bool cancellable)
    {
        btnClose.Visible = cancellable;
        worker.WorkerSupportsCancellation = cancellable;
        Invalidate();
        return this;
    }

    public LoadingForm WithCallback(Action callback)
    {
        this.callback = callback;
        return this;
    }

    public LoadingForm WithCallback(Func<object> callback)
    {
        callbackWithResult = callback;
        this.callback = null;
        return this;
    }

    public LoadingForm OnError(Action<Exception> errorHandler)
    {
        this.errorHandler = errorHandler;
        return this;
    }

    public object Result
    {
        get
        {
            if (_exception != null) throw _exception;
            return result;
        }
    }

    public T GetResult<T>()
    {
        return (T)Result;
    }

    private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
        DialogResult = DialogResult.OK;

        if (e.Error != null)
        {
            _exception = e.Error;
            errorHandler?.Invoke(e.Error);
            DialogResult = DialogResult.No;
        }
        if (e.Cancelled)
        {
            DialogResult = DialogResult.Cancel;
        }
        this.Exit();
    }

    private void Worker_DoWork(object sender, DoWorkEventArgs e)
    {
        if (callback != null)
        {
            callback.Invoke();
            return;
        }
        if (callbackWithResult != null)
        {
            result = callbackWithResult.Invoke();
            return;
        }
        throw new InvalidOperationException("No work function provided.");
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

    public DialogResult Run()
    {
        this.ShowDialog();
        return this.DialogResult;
    }

    public void SetTitle(string title)
    {
        this.LblTitle.Text = title;
    }

    public void SetKeterangan(string keterangan)
    {
        this.LblKeterangan.Text = keterangan;
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

    private void BtnClose_Click(object sender, EventArgs e)
    {
        Close();
    }
}
