namespace BasicMusicTheory
{
    public class Duration
    {
        public double TotalBeats { get; }

        public Duration(double beats)
        {
            this.TotalBeats = beats;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj is Duration)
            {
                return this == (Duration)obj;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return TotalBeats.GetHashCode();
        }

        public override string ToString()
        {
            return $"{TotalBeats} beat";
        }

        #region Operators
        public static Duration operator +(Duration a, Duration b)
        {
            return new Duration(a.TotalBeats + b.TotalBeats);
        }

        public static Duration operator -(Duration a, Duration b)
        {
            return new Duration(a.TotalBeats - b.TotalBeats);
        }

        public static Duration operator *(Duration a, double b)
        {
            return new Duration(a.TotalBeats * b);
        }

        public static Duration operator /(Duration a, double b)
        {
            return new Duration(a.TotalBeats / b);
        }

        public static bool operator ==(Duration a, Duration b)
        {
            return a.TotalBeats == b.TotalBeats;
        }

        public static bool operator !=(Duration a, Duration b)
        {
            return a.TotalBeats != b.TotalBeats;
        }

        public static bool operator <(Duration a, Duration b)
        {
            return a.TotalBeats < b.TotalBeats;
        }

        public static bool operator >(Duration a, Duration b)
        {
            return a.TotalBeats > b.TotalBeats;
        }

        public static bool operator <=(Duration a, Duration b)
        {
            return a.TotalBeats <= b.TotalBeats;
        }

        public static bool operator >=(Duration a, Duration b)
        {
            return a.TotalBeats >= b.TotalBeats;
        }
        #endregion

        #region Static Predefined Pitches
        public static Duration Whole = new Duration(4);
        public static Duration Half = new Duration(2);
        public static Duration Quarter = new Duration(1);
        public static Duration Eighth = new Duration(0.5);
        public static Duration Sixteenth = new Duration(0.25);
        public static Duration ThirtySecond = new Duration(0.125);
        public static Duration SixtyFourth = new Duration(0.0625);
        public static Duration OneHundredTwentyEighth = new Duration(0.03125);
        #endregion
    }
}