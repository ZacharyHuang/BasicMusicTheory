namespace BasicMusicTheory
{
    public class MusicalAlphabet
    {
        public int DeltaSemitonesToC { get; private set; }
        public Interval IntervalToC { get { return new Interval(DeltaSemitonesToC); } }
        public int Number { get; private set; }
        public string Text { get; private set; }

        private MusicalAlphabet(int deltaSemitonesToC, int number, string text)
        {
            DeltaSemitonesToC = deltaSemitonesToC;
            Number = number;
            Text = text;
        }

        public static MusicalAlphabet Parse(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException("text");
            }

            switch (text)
            {
                case "C":
                case "c":
                    return C;
                case "D":
                case "d":
                    return D;
                case "E":
                case "e":
                    return E;
                case "F":
                case "f":
                    return F;
                case "G":
                case "g":
                    return G;
                case "A":
                case "a":
                    return A;
                case "B":
                case "b":
                    return B;
                default :
                    throw new FormatException();
            }
        }

        public override string ToString()
        {
            return Text;
        }

        public static MusicalAlphabet C = new MusicalAlphabet(0, 1, "C");
        public static MusicalAlphabet D = new MusicalAlphabet(2, 2, "D");
        public static MusicalAlphabet E = new MusicalAlphabet(4, 3, "E");
        public static MusicalAlphabet F = new MusicalAlphabet(5, 4, "F");
        public static MusicalAlphabet G = new MusicalAlphabet(7, 5, "G");
        public static MusicalAlphabet A = new MusicalAlphabet(9, 6, "A");
        public static MusicalAlphabet B = new MusicalAlphabet(11, 7, "B");

    }
}
