using System;

namespace Colmeia_c_Mel
{
    class Queen
    {
        public Queen (Worker[] workers)
        {
            this.workers = workers;
        }
        private Worker[] workers;
        private int shiftNumber = 0;
        public bool AssisgnWork( string job, int NumberOfShift)
        {
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DoThisJob(job, NumberOfShift))
                {
                    return true;
                }
            }
            return false;
        }
        public double TotalQueen;
        private void CustoTotal()
        {
            int NumbBeeWorking = 0;
            for (int i = 0; i < workers.Length; i++)
            {
                
                if (!String.IsNullOrEmpty(workers[i].CurrenteJob))
                {
                    NumbBeeWorking++;
                }
                if (NumbBeeWorking<=2)
                {
                    TotalQueen += 20;
                }
                else
                {
                    TotalQueen += 30;
                }
                TotalQueen += workers[i].GetHeney();
            }
            
        }

        public string WorkTheNextShift()
        {
            CustoTotal();
            shiftNumber++;
            string report = "Report for Shift #" + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].WorkOneShift())
                {
                    report += "Worker #" + (i + 1) + " Usou "+ workers[i].GetHeney() + " de unidades de mel. Finished the job\r\n";
                }
                else
                {
                    if (string.IsNullOrEmpty(workers[i].CurrenteJob))
                    {
                        report += "Worker #" + (i + 1) + " Usou " + workers[i].GetHeney() + " de unidades de mel. Is not working\r\n";
                    }
                    else
                    {
                        if (workers[i].ShiftLeft > 0)
                        {
                            report += "Worker #" + (i + 1) + " is doing " + workers[i].CurrenteJob
                                + " for " + workers[i].ShiftLeft + " More shifts. Usou " + workers[i].GetHeney() + " de unidades de mel\r\n";
                        }
                        else
                        {
                            report += "Worker #" + (i + 1) + " will be done with " + workers[i].CurrenteJob
                            + " after this shift." + " E usou " + workers[i].GetHeney() + " de unidades de mel \r\n";

                        }
                    }
                }
                
            }
            return report;
        }
    }
}
