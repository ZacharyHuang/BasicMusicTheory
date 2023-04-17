namespace BasicMusicTheory
{
    public class Interval
    {
        public int TotalSemitones { get; set; }
        
        public Interval(int semitones)
        {
            TotalSemitones = semitones;
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj is Interval)
            {
                return this == (Interval)obj;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return TotalSemitones;
        }

        public override string ToString()
        {
            return $"{TotalSemitones} semitones";
        }

        #region Operators
        public static Interval operator -(Interval i)
        {
            return new Interval(-i.TotalSemitones);
        }

        public static Interval operator +(Interval a, Interval b)
        {
            return new Interval(a.TotalSemitones + b.TotalSemitones);
        }

        public static Interval operator -(Interval a, Interval b)
        {
            return new Interval(a.TotalSemitones - b.TotalSemitones);
        }

        public static bool operator ==(Interval a, Interval b)
        {
            return a.TotalSemitones == b.TotalSemitones;
        }

        public static bool operator !=(Interval a, Interval b)
        {
            return a.TotalSemitones != b.TotalSemitones;
        }

        public static bool operator <(Interval a, Interval b)
        {
            return a.TotalSemitones < b.TotalSemitones;
        }

        public static bool operator >(Interval a, Interval b)
        {
            return a.TotalSemitones > b.TotalSemitones;
        }

        public static bool operator <=(Interval a, Interval b)
        {
            return a.TotalSemitones <= b.TotalSemitones;
        }

        public static bool operator >=(Interval a, Interval b)
        {
            return a.TotalSemitones >= b.TotalSemitones;
        }
        #endregion

        #region Static Predefined Intervals
        public static Interval Unison = new Interval(0);
        public static Interval MinorSecond = new Interval(1);
        public static Interval MajorSecond = new Interval(2);
        public static Interval MinorThird = new Interval(3);
        public static Interval MajorThird = new Interval(4);
        public static Interval PerfectFourth = new Interval(5);
        public static Interval Tritone = new Interval(6);
        public static Interval PerfectFifth = new Interval(7);
        public static Interval MinorSixth = new Interval(8);
        public static Interval MajorSixth = new Interval(9);
        public static Interval MinorSeventh = new Interval(10);
        public static Interval MajorSeventh = new Interval(11);
        public static Interval Octave = new Interval(12);
        #endregion
    }
}
