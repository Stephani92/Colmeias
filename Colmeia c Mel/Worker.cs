using System;

namespace Colmeia_c_Mel
{
    class Worker
    {
        public Worker(int Weight, string[] jobsICando)
        {
            this.Weight = Weight;
            this.jobsICanDo = jobsICando;
            
        }

        public double Weight;
       
        private string currenteJob = "";
        public string CurrenteJob
        {
            get
            {
                return currenteJob;
            }
        }
        private string[] jobsICanDo;
        private int shiftstoWork;
        private int shiftsWorked;
        public int ShiftLeft
        {
            get
            {
                return shiftstoWork - shiftsWorked;
            }
        }
        public bool DoThisJob(string job, int numberOfShifts)
        {
            if (!String.IsNullOrEmpty(currenteJob))
            {
                return false;
            }
            for (int i = 0; i < jobsICanDo.Length; i++)
            {
                if (jobsICanDo[i] == job)
                {
                    currenteJob = job;
                    this.shiftstoWork = numberOfShifts;
                    shiftsWorked = 0;
                    return true;
                }
            }
            return false;
        }

        public double GetHeney()
        {
            double BeeToHard;
            double calcHoney;
            if (ShiftLeft == 0)
            {
                calcHoney = 7.5;
            }
            else
            {
                calcHoney = ShiftLeft + 9;
            }
            if (Weight >= 150)
            {
                calcHoney += calcHoney * 0.35;
            }
            return  calcHoney;
        }
        public bool WorkOneShift()
        {
            if (String.IsNullOrEmpty(currenteJob))
            {
                return false;
            }
            shiftsWorked++;
            if (shiftsWorked > shiftstoWork)
            {
                shiftsWorked = 0;
                shiftstoWork = 0;
                currenteJob = "";
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}