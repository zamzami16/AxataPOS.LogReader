using System;
using System.ComponentModel;

namespace AxataPOS.App.Common.Interfaces
{
    public interface ILoadingForm : IDisposable
    {
        delegate object WorkerDoWork(object sender, DoWorkEventArgs e);
        event WorkerDoWork DoWorkEvent;
        void SetTitle(string title);
        void SetKeterangan(string keterangan);
        void Run();
        object GetResult();
        void SetWorkFunction(WorkerDoWork workFunction);
        void CanBeCancelled(bool cancel);
    }
}
