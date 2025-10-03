using System.Diagnostics;
using System.Drawing;
using WindowScrape.Types;

namespace Nucleus.Gaming
{
    public class ProcessData
    {
        private Process process;
        public bool Finished;

        public Point Position;
        private HwndObject hWnd;
        public bool HWNDRetry;
        
        public Size Size;
        public bool Setted;

        public bool Register0;

        public bool KilledMutexes;
        public long RegLong;
        public int Status;
        public float? AudioVolume;
        /// <summary>
        /// A reference to the game's process, if it's running
        /// </summary>
        public Process Process => process;

        public HwndObject HWnd
        {
            get => hWnd;
            set => hWnd = value;
        }

        public ProcessData(Process proc)
        {
            process = proc;
        }

        public void AssignProcess(Process proc)
        {
            process = proc;
        }

        public ProcessData(ProcessData other)
        {
            process = other.Process;
            Finished = other.Finished;
            HWnd = other.HWnd;
            Position = other.Position;
            HWNDRetry = other.HWNDRetry;
            Size = other.Size;
            Setted = other.Setted;
            Register0 = other.Register0;
            KilledMutexes = other.KilledMutexes;
            RegLong = other.RegLong;
            Status = other.Status;
            AudioVolume = other.AudioVolume;
        }
    }
}
