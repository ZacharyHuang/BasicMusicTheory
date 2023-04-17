namespace BasicMusicTheory
{
    public class Accidental
    {
        public int DeltaSemitones { get; }
        private string displayText;

        private Accidental(int deltaSemitones, string displayText)
        {
            this.DeltaSemitones = deltaSemitones;
            this.displayText = displayText;
        }

        public static Accidental Natural = new Accidental(0, "");
        public static Accidental Sharp = new Accidental(1, "#");
        public static Accidental DoubleSharp = new Accidental(1, "x");
        public static Accidental Flat = new Accidental(-1, "b");
        public static Accidental DoubleFlat = new Accidental(-1, "bb");

        public static Accidental Parse(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException("text");
            }

            text = text.Trim();
            
            if (string.IsNullOrEmpty(text))
            {
                return Natural;
            }

            switch (text)
            {
                case "#":
                    return Sharp;
                case "b":
                    return Flat;
                case "x":
                    return DoubleSharp;
                case "bb":
                    return DoubleFlat;
                default:
                    throw new FormatException();
            }
        }

        public override string ToString()
        {
            return displayText;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj is Accidental)
            {
                return this == (Accidental)obj;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return DeltaSemitones;
        }

        public static bool operator ==(Accidental a, Accidental b)
        {
            return a.DeltaSemitones == b.DeltaSemitones;
        }

        public static bool operator !=(Accidental a, Accidental b)
        {
            return a.DeltaSemitones != b.DeltaSemitones;
        }
    }
}
