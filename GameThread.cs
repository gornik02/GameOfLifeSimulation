using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameOfLifeSimulation
{
    class GameThread
    {
        private Thread thread;

        public GameThread(Action action)
        {
            thread = new Thread(() => LoopAction(action));
        }

        public void StartThread()
        {
            thread.Start();
        }

        public void StopThread()
        {
            thread.Abort();
        }

        private void LoopAction(Action action)
        {
            while (true)
            {
                action();
            }
        }
    }
}
