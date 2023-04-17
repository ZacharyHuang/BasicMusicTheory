namespace BasicMusicTheory
{
    public class Key
    {
        public static IReadOnlyDictionary<int, Key> DeltaSemitonesToKey = new Dictionary<int, Key>()
        {
            { 0, Key.C },
            { 1, Key.CSharp },
            { 2, Key.D },
            { 3, Key.EFlat },
            { 4, Key.E },
            { 5, Key.F },
            { 6, Key.FSharp },
            { 7, Key.G },
            { 8, Key.AFlat },
            { 9, Key.A },
            { 10, Key.BFlat },
            { 11, Key.B }
        };

        public int DeltaSemitonesToC { get { return Alphabet.DeltaSemitonesToC + Accidental.DeltaSemitones; } }
        public Interval IntervalToC { get { return new Interval(DeltaSemitonesToC); } }
        public MusicalAlphabet Alphabet { get; }
        public Accidental Accidental { get; }

        private Key(MusicalAlphabet alphabet, Accidental accidental)
        {
            Alphabet = alphabet;
            Accidental = accidental;
        }

        public static Key Parse(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException("text");
            }

            text = text.Trim();

            if (string.IsNullOrEmpty(text))
            {
                throw new FormatException();
            }

            MusicalAlphabet alphabet;
            Accidental accidental;

            if (text.Length == 1)
            {
                alphabet = MusicalAlphabet.Parse(text);
                accidental = Accidental.Natural;
            }
            else
            {
                alphabet = MusicalAlphabet.Parse(text.Substring(0, 1));
                accidental = Accidental.Parse(text.Substring(1));
            }

            return new Key(alphabet, accidental);
        }

        public override string ToString()
        {
            return $"{Alphabet}{Accidental}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj is Key)
            {
                return this == (Key)obj;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Alphabet.GetHashCode() ^ Accidental.GetHashCode();
        }

        public static bool operator ==(Key a, Key b)
        {
            return a.Alphabet == b.Alphabet && a.Accidental == b.Accidental;
        }

        public static bool operator !=(Key a, Key b)
        {
            return !(a == b);
        }

        #region Static Predefined Keys
        public static Key C = new Key(MusicalAlphabet.C, Accidental.Natural);
        public static Key CSharp = new Key(MusicalAlphabet.C, Accidental.Sharp);
        public static Key CDoubleSharp = new Key(MusicalAlphabet.C, Accidental.DoubleSharp);
        public static Key CFlat = new Key(MusicalAlphabet.C, Accidental.Flat);
        public static Key CDoubleFlat = new Key(MusicalAlphabet.C, Accidental.DoubleFlat);
        public static Key D = new Key(MusicalAlphabet.D, Accidental.Natural);
        public static Key DSharp = new Key(MusicalAlphabet.D, Accidental.Sharp);
        public static Key DDoubleSharp = new Key(MusicalAlphabet.D, Accidental.DoubleSharp);
        public static Key DFlat = new Key(MusicalAlphabet.D, Accidental.Flat);
        public static Key DDoubleFlat = new Key(MusicalAlphabet.D, Accidental.DoubleFlat);
        public static Key E = new Key(MusicalAlphabet.E, Accidental.Natural);
        public static Key ESharp = new Key(MusicalAlphabet.E, Accidental.Sharp);
        public static Key EDoubleSharp = new Key(MusicalAlphabet.E, Accidental.DoubleSharp);
        public static Key EFlat = new Key(MusicalAlphabet.E, Accidental.Flat);
        public static Key EDoubleFlat = new Key(MusicalAlphabet.E, Accidental.DoubleFlat);
        public static Key F = new Key(MusicalAlphabet.F, Accidental.Natural);
        public static Key FSharp = new Key(MusicalAlphabet.F, Accidental.Sharp);
        public static Key FDoubleSharp = new Key(MusicalAlphabet.F, Accidental.DoubleSharp);
        public static Key FFlat = new Key(MusicalAlphabet.F, Accidental.Flat);
        public static Key FDoubleFlat = new Key(MusicalAlphabet.F, Accidental.DoubleFlat);
        public static Key G = new Key(MusicalAlphabet.G, Accidental.Natural);
        public static Key GSharp = new Key(MusicalAlphabet.G, Accidental.Sharp);
        public static Key GDoubleSharp = new Key(MusicalAlphabet.G, Accidental.DoubleSharp);
        public static Key GFlat = new Key(MusicalAlphabet.G, Accidental.Flat);
        public static Key GDoubleFlat = new Key(MusicalAlphabet.G, Accidental.DoubleFlat);
        public static Key A = new Key(MusicalAlphabet.A, Accidental.Natural);
        public static Key ASharp = new Key(MusicalAlphabet.A, Accidental.Sharp);
        public static Key ADoubleSharp = new Key(MusicalAlphabet.A, Accidental.DoubleSharp);
        public static Key AFlat = new Key(MusicalAlphabet.A, Accidental.Flat);
        public static Key ADoubleFlat = new Key(MusicalAlphabet.A, Accidental.DoubleFlat);
        public static Key B = new Key(MusicalAlphabet.B, Accidental.Natural);
        public static Key BSharp = new Key(MusicalAlphabet.B, Accidental.Sharp);
        public static Key BDoubleSharp = new Key(MusicalAlphabet.B, Accidental.DoubleSharp);
        public static Key BFlat = new Key(MusicalAlphabet.B, Accidental.Flat);
        public static Key BDoubleFlat = new Key(MusicalAlphabet.B, Accidental.DoubleFlat);
        #endregion
    }
}