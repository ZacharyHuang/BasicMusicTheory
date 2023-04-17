namespace BasicMusicTheory
{
    public class Pitch
    {
        public static double A4Hz = 440;
        public Key Key { get; }
        public int Octave { get; }

        public Pitch(Key key, int octave)
        {
            Key = key;
            Octave = octave;
        }

        public Pitch(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException("text");
            }

            text = text.Trim();

            int octaveIndex = 0;
            while (octaveIndex < text.Length && !char.IsDigit(text[1]))
            {
                ++octaveIndex;
            }

            if (octaveIndex >= text.Length)
            {
                throw new FormatException();
            }
            
            Key = Key.Parse(text.Substring(0, octaveIndex));
            Octave = int.Parse(text.Substring(octaveIndex));
        }

        public int GetMidiNumberWithoutCut()
        {
            return (Octave + 1) * 12 + Key.DeltaSemitonesToC;
        }

        public int GetMidiNumber()
        {
            var midiNumber = GetMidiNumberWithoutCut();
            return midiNumber >= 21 && midiNumber <= 108 ? midiNumber : -1;
        }

        public double GetHz()
        {
            return A4Hz * Math.Pow(2, (this - Pitch.A4).TotalSemitones / 12.0);
        }

        public static Pitch Parse(string text)
        {
            return new Pitch(text);
        }

        public bool SamePitchAs(Pitch p)
        {
            if (p == null || this == null)
            {
                return false;
            }
            
            return p.GetMidiNumberWithoutCut() == this.GetMidiNumberWithoutCut();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj is Pitch)
            {
                return this == (Pitch)obj;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return GetMidiNumberWithoutCut();
        }

        public override string ToString()
        {
            return $"{Key}{Octave}";
        }

        #region Operators
        public static Interval operator -(Pitch a, Pitch b)
        {
            return new Interval((a.Octave - b.Octave) * 12 + a.Key.DeltaSemitonesToC - b.Key.DeltaSemitonesToC);
        }

        public static Pitch operator +(Pitch p, Interval i)
        {
            var octave = p.Octave;
            var deltaSemitonesToC = p.Key.DeltaSemitonesToC + i.TotalSemitones;
            while (deltaSemitonesToC < 0)
            {
                deltaSemitonesToC += 12;
                octave -= 1;
            }

            while (deltaSemitonesToC >= 12)
            {
                deltaSemitonesToC -= 12;
                octave += 1;
            }

            var key = Key.DeltaSemitonesToKey[deltaSemitonesToC];
            return new Pitch(key, octave);
        }

        public static Pitch operator -(Pitch p, Interval i)
        {
            return p + (-i);
        }

        public static bool operator ==(Pitch a, Pitch b)
        {
            return a.Key == b.Key && a.Octave == b.Octave;
        }

        public static bool operator !=(Pitch a, Pitch b)
        {
            return !(a == b);
        }

        public static bool operator >(Pitch a, Pitch b)
        {
            return a.GetMidiNumberWithoutCut() > b.GetMidiNumberWithoutCut();
        }

        public static bool operator <(Pitch a, Pitch b)
        {
            return a.GetMidiNumberWithoutCut() < b.GetMidiNumberWithoutCut();
        }

        public static bool operator >=(Pitch a, Pitch b)
        {
            return a.GetMidiNumberWithoutCut() >= b.GetMidiNumberWithoutCut();
        }

        public static bool operator <=(Pitch a, Pitch b)
        {
            return a.GetMidiNumberWithoutCut() <= b.GetMidiNumberWithoutCut();
        }
        #endregion

        #region Static Predefined Pitches
        public static Pitch C0 = new Pitch(Key.C, 0);
        public static Pitch CSharp0 = new Pitch(Key.CSharp, 0);
        public static Pitch DFlat0 = new Pitch(Key.DFlat, 0);
        public static Pitch D0 = new Pitch(Key.D, 0);
        public static Pitch DSharp0 = new Pitch(Key.DSharp, 0);
        public static Pitch EFlat0 = new Pitch(Key.EFlat, 0);
        public static Pitch E0 = new Pitch(Key.E, 0);
        public static Pitch F0 = new Pitch(Key.F, 0);
        public static Pitch FSharp0 = new Pitch(Key.FSharp, 0);
        public static Pitch GFlat0 = new Pitch(Key.GFlat, 0);
        public static Pitch G0 = new Pitch(Key.G, 0);
        public static Pitch GSharp0 = new Pitch(Key.GSharp, 0);
        public static Pitch AFlat0 = new Pitch(Key.AFlat, 0);
        public static Pitch A0 = new Pitch(Key.A, 0);
        public static Pitch ASharp0 = new Pitch(Key.ASharp, 0);
        public static Pitch BFlat0 = new Pitch(Key.BFlat, 0);
        public static Pitch B0 = new Pitch(Key.B, 0);

        public static Pitch C1 = new Pitch(Key.C, 1);
        public static Pitch CSharp1 = new Pitch(Key.CSharp, 1);
        public static Pitch DFlat1 = new Pitch(Key.DFlat, 1);
        public static Pitch D1 = new Pitch(Key.D, 1);
        public static Pitch DSharp1 = new Pitch(Key.DSharp, 1);
        public static Pitch EFlat1 = new Pitch(Key.EFlat, 1);
        public static Pitch E1 = new Pitch(Key.E, 1);
        public static Pitch F1 = new Pitch(Key.F, 1);
        public static Pitch FSharp1 = new Pitch(Key.FSharp, 1);
        public static Pitch GFlat1 = new Pitch(Key.GFlat, 1);
        public static Pitch G1 = new Pitch(Key.G, 1);
        public static Pitch GSharp1 = new Pitch(Key.GSharp, 1);
        public static Pitch AFlat1 = new Pitch(Key.AFlat, 1);
        public static Pitch A1 = new Pitch(Key.A, 1);
        public static Pitch ASharp1 = new Pitch(Key.ASharp, 1);
        public static Pitch BFlat1 = new Pitch(Key.BFlat, 1);
        public static Pitch B1 = new Pitch(Key.B, 1);
        
        public static Pitch C2 = new Pitch(Key.C, 2);
        public static Pitch CSharp2 = new Pitch(Key.CSharp, 2);
        public static Pitch DFlat2 = new Pitch(Key.DFlat, 2);
        public static Pitch D2 = new Pitch(Key.D, 2);
        public static Pitch DSharp2 = new Pitch(Key.DSharp, 2);
        public static Pitch EFlat2 = new Pitch(Key.EFlat, 2);
        public static Pitch E2 = new Pitch(Key.E, 2);
        public static Pitch F2 = new Pitch(Key.F, 2);
        public static Pitch FSharp2 = new Pitch(Key.FSharp, 2);
        public static Pitch GFlat2 = new Pitch(Key.GFlat, 2);
        public static Pitch G2 = new Pitch(Key.G, 2);
        public static Pitch GSharp2 = new Pitch(Key.GSharp, 2);
        public static Pitch AFlat2 = new Pitch(Key.AFlat, 2);
        public static Pitch A2 = new Pitch(Key.A, 2);
        public static Pitch ASharp2 = new Pitch(Key.ASharp, 2);
        public static Pitch BFlat2 = new Pitch(Key.BFlat, 2);
        public static Pitch B2 = new Pitch(Key.B, 2);
        
        public static Pitch C3 = new Pitch(Key.C, 3);
        public static Pitch CSharp3 = new Pitch(Key.CSharp, 3);
        public static Pitch DFlat3 = new Pitch(Key.DFlat, 3);
        public static Pitch D3 = new Pitch(Key.D, 3);
        public static Pitch DSharp3 = new Pitch(Key.DSharp, 3);
        public static Pitch EFlat3 = new Pitch(Key.EFlat, 3);
        public static Pitch E3 = new Pitch(Key.E, 3);
        public static Pitch F3 = new Pitch(Key.F, 3);
        public static Pitch FSharp3 = new Pitch(Key.FSharp, 3);
        public static Pitch GFlat3 = new Pitch(Key.GFlat, 3);
        public static Pitch G3 = new Pitch(Key.G, 3);
        public static Pitch GSharp3 = new Pitch(Key.GSharp, 3);
        public static Pitch AFlat3 = new Pitch(Key.AFlat, 3);
        public static Pitch A3 = new Pitch(Key.A, 3);
        public static Pitch ASharp3 = new Pitch(Key.ASharp, 3);
        public static Pitch BFlat3 = new Pitch(Key.BFlat, 3);
        public static Pitch B3 = new Pitch(Key.B, 3);
        
        public static Pitch C4 = new Pitch(Key.C, 4);
        public static Pitch CSharp4 = new Pitch(Key.CSharp, 4);
        public static Pitch DFlat4 = new Pitch(Key.DFlat, 4);
        public static Pitch D4 = new Pitch(Key.D, 4);
        public static Pitch DSharp4 = new Pitch(Key.DSharp, 4);
        public static Pitch EFlat4 = new Pitch(Key.EFlat, 4);
        public static Pitch E4 = new Pitch(Key.E, 4);
        public static Pitch F4 = new Pitch(Key.F, 4);
        public static Pitch FSharp4 = new Pitch(Key.FSharp, 4);
        public static Pitch GFlat4 = new Pitch(Key.GFlat, 4);
        public static Pitch G4 = new Pitch(Key.G, 4);
        public static Pitch GSharp4 = new Pitch(Key.GSharp, 4);
        public static Pitch AFlat4 = new Pitch(Key.AFlat, 4);
        public static Pitch A4 = new Pitch(Key.A, 4);
        public static Pitch ASharp4 = new Pitch(Key.ASharp, 4);
        public static Pitch BFlat4 = new Pitch(Key.BFlat, 4);
        public static Pitch B4 = new Pitch(Key.B, 4);
        
        public static Pitch C5 = new Pitch(Key.C, 5);
        public static Pitch CSharp5 = new Pitch(Key.CSharp, 5);
        public static Pitch DFlat5 = new Pitch(Key.DFlat, 5);
        public static Pitch D5 = new Pitch(Key.D, 5);
        public static Pitch DSharp5 = new Pitch(Key.DSharp, 5);
        public static Pitch EFlat5 = new Pitch(Key.EFlat, 5);
        public static Pitch E5 = new Pitch(Key.E, 5);
        public static Pitch F5 = new Pitch(Key.F, 5);
        public static Pitch FSharp5 = new Pitch(Key.FSharp, 5);
        public static Pitch GFlat5 = new Pitch(Key.GFlat, 5);
        public static Pitch G5 = new Pitch(Key.G, 5);
        public static Pitch GSharp5 = new Pitch(Key.GSharp, 5);
        public static Pitch AFlat5 = new Pitch(Key.AFlat, 5);
        public static Pitch A5 = new Pitch(Key.A, 5);
        public static Pitch ASharp5 = new Pitch(Key.ASharp, 5);
        public static Pitch BFlat5 = new Pitch(Key.BFlat, 5);
        public static Pitch B5 = new Pitch(Key.B, 5);
        
        public static Pitch C6 = new Pitch(Key.C, 6);
        public static Pitch CSharp6 = new Pitch(Key.CSharp, 6);
        public static Pitch DFlat6 = new Pitch(Key.DFlat, 6);
        public static Pitch D6 = new Pitch(Key.D, 6);
        public static Pitch DSharp6 = new Pitch(Key.DSharp, 6);
        public static Pitch EFlat6 = new Pitch(Key.EFlat, 6);
        public static Pitch E6 = new Pitch(Key.E, 6);
        public static Pitch F6 = new Pitch(Key.F, 6);
        public static Pitch FSharp6 = new Pitch(Key.FSharp, 6);
        public static Pitch GFlat6 = new Pitch(Key.GFlat, 6);
        public static Pitch G6 = new Pitch(Key.G, 6);
        public static Pitch GSharp6 = new Pitch(Key.GSharp, 6);
        public static Pitch AFlat6 = new Pitch(Key.AFlat, 6);
        public static Pitch A6 = new Pitch(Key.A, 6);
        public static Pitch ASharp6 = new Pitch(Key.ASharp, 6);
        public static Pitch BFlat6 = new Pitch(Key.BFlat, 6);
        public static Pitch B6 = new Pitch(Key.B, 6);
        
        public static Pitch C7 = new Pitch(Key.C, 7);
        public static Pitch CSharp7 = new Pitch(Key.CSharp, 7);
        public static Pitch DFlat7 = new Pitch(Key.DFlat, 7);
        public static Pitch D7 = new Pitch(Key.D, 7);
        public static Pitch DSharp7 = new Pitch(Key.DSharp, 7);
        public static Pitch EFlat7 = new Pitch(Key.EFlat, 7);
        public static Pitch E7 = new Pitch(Key.E, 7);
        public static Pitch F7 = new Pitch(Key.F, 7);
        public static Pitch FSharp7 = new Pitch(Key.FSharp, 7);
        public static Pitch GFlat7 = new Pitch(Key.GFlat, 7);
        public static Pitch G7 = new Pitch(Key.G, 7);
        public static Pitch GSharp7 = new Pitch(Key.GSharp, 7);
        public static Pitch AFlat7 = new Pitch(Key.AFlat, 7);
        public static Pitch A7 = new Pitch(Key.A, 7);
        public static Pitch ASharp7 = new Pitch(Key.ASharp, 7);
        public static Pitch BFlat7 = new Pitch(Key.BFlat, 7);
        public static Pitch B7 = new Pitch(Key.B, 7);
        
        public static Pitch C8 = new Pitch(Key.C, 8);
        public static Pitch CSharp8 = new Pitch(Key.CSharp, 8);
        public static Pitch DFlat8 = new Pitch(Key.DFlat, 8);
        public static Pitch D8 = new Pitch(Key.D, 8);
        public static Pitch DSharp8 = new Pitch(Key.DSharp, 8);
        public static Pitch EFlat8 = new Pitch(Key.EFlat, 8);
        public static Pitch E8 = new Pitch(Key.E, 8);
        public static Pitch F8 = new Pitch(Key.F, 8);
        public static Pitch FSharp8 = new Pitch(Key.FSharp, 8);
        public static Pitch GFlat8 = new Pitch(Key.GFlat, 8);
        public static Pitch G8 = new Pitch(Key.G, 8);
        public static Pitch GSharp8 = new Pitch(Key.GSharp, 8);
        public static Pitch AFlat8 = new Pitch(Key.AFlat, 8);
        public static Pitch A8 = new Pitch(Key.A, 8);
        public static Pitch ASharp8 = new Pitch(Key.ASharp, 8);
        public static Pitch BFlat8 = new Pitch(Key.BFlat, 8);
        public static Pitch B8 = new Pitch(Key.B, 8);
        
        #endregion
    }
}
