using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameOfLifeSimulation
{
    class CancellableTask
    {
        Task task;
        CancellationTokenSource cancellationTokenSource;
        public CancellableTask(Action action) {
            cancellationTokenSource = new CancellationTokenSource();
            task = new Task(action, cancellationTokenSource.Token);
        }

        public void Start()
        {
            task.Start();
        }

        public void Cancel()
        {
            cancellationTokenSource.Cancel();
            cancellationTokenSource.Dispose();
        }
    }
}
