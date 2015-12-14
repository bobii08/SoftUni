using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03.AsynchronousTimer
{
    public class AsyncTimer
    {
        private int ticks;
        private int interval;

        public AsyncTimer(Action action, int ticks, int interval)
        {
            this.Action = action;
            this.Ticks = ticks;
            this.Interval = interval;
        }

        public Action Action { get; set; }

        public int Ticks
        {
            get { return this.ticks; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("ticks", "Ticks must be non-negative.");
                }

                this.ticks = value;
            }
        }

        public int Interval
        {
            get { return this.interval; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("interval", "Interval must be positive.");
                }

                this.interval = value;
            }
        }

        public void Run()
        {
            while (this.Ticks > 0)
            {
                Thread.Sleep(this.Interval);
                this.Action();
                this.Ticks -= 1;
            }
        }
    }
}
