namespace WpfApplication1
{
    public class LemerRandomSequence
    {
        private double a, m, R0, Rprev, X;

        LemerRandomSequence(double a, double m, double R0)
        {
            this.a = a;
            this.m = m;
            this.R0 = R0;  
            this.Rprev = R0;
        }
        
        public double Next()
        {
            Rprev = (a * Rprev) % m;
            X = Rprev / m;
            return X;
        }

        public void Reset()
        {
            Rprev = R0;
        }

        public double CurrentX()
        {        
            return X;
        }
        
        public double CurrentR()
        {
            return Rprev;
        }

        public double getM()
        {
            return m;
        }
    }
}