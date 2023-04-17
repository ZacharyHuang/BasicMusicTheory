namespace BasicMusicTheory
{
    public class Scale
    {
        public Key Root { get; }
        public IReadOnlyCollection<Interval> IntervalsToRoot { get; }

        public Scale(Key root, IReadOnlyCollection<Interval> intervalsToRoot)
        {
            Root = root;
            IntervalsToRoot = intervalsToRoot;
        }
    }

    public class MajorScale : Scale
    {
        public static IReadOnlyCollection<Interval> IntervalsToRoot = new Interval[] { Interval.Unison, Interval.MajorSecond, Interval.MajorThird, Interval.PerfectFourth, Interval.PerfectFifth, Interval.MajorSixth, Interval.MajorSeventh };

        private MajorScale(Key root) : base(root, MajorScale.IntervalsToRoot)
        {
        }

        public static Scale CMajor = new MajorScale(Key.C);
        public static Scale GMajor = new MajorScale(Key.G);
        public static Scale DMajor = new MajorScale(Key.D);
        public static Scale AMajor = new MajorScale(Key.A);
        public static Scale EMajor = new MajorScale(Key.E);
        public static Scale BMajor = new MajorScale(Key.B);
        public static Scale FSharpMajor = new MajorScale(Key.FSharp);
        public static Scale CSharpMajor = new MajorScale(Key.CSharp);
        public static Scale FMajor = new MajorScale(Key.F);
        public static Scale BFlatMajor = new MajorScale(Key.BFlat);
        public static Scale EFlatMajor = new MajorScale(Key.EFlat);
        public static Scale AFlatMajor = new MajorScale(Key.AFlat);
        public static Scale DFlatMajor = new MajorScale(Key.DFlat);
        public static Scale GFlatMajor = new MajorScale(Key.GFlat);
        public static Scale CFlatMajor = new MajorScale(Key.CFlat);
    }

    public class MinorScale : Scale
    {
        public static IReadOnlyCollection<Interval> IntervalsToRoot = new Interval[] { Interval.Unison, Interval.MajorSecond, Interval.MinorThird, Interval.PerfectFourth, Interval.PerfectFifth, Interval.MinorSixth, Interval.MinorSeventh };

        private MinorScale(Key root) : base(root, MinorScale.IntervalsToRoot)
        {
        }

        public static Scale AMinor = new MinorScale(Key.A);
        public static Scale EMinor = new MinorScale(Key.E);
        public static Scale BMinor = new MinorScale(Key.B);
        public static Scale FSharpMinor = new MinorScale(Key.FSharp);
        public static Scale CSharpMinor = new MinorScale(Key.CSharp);
        public static Scale GSharpMinor = new MinorScale(Key.GSharp);
        public static Scale DSharpMinor = new MinorScale(Key.DSharp);
        public static Scale ASharpMinor = new MinorScale(Key.ASharp);
        public static Scale DMinor = new MinorScale(Key.D);
        public static Scale GMinor = new MinorScale(Key.G);
        public static Scale CMinor = new MinorScale(Key.C);
        public static Scale FMinor = new MinorScale(Key.F);
        public static Scale BFlatMinor = new MinorScale(Key.BFlat);
        public static Scale EFlatMinor = new MinorScale(Key.EFlat);
        public static Scale AFlatMinor = new MinorScale(Key.AFlat);
    }

    public class HarmonicMinorScale : Scale
    {
        public static IReadOnlyCollection<Interval> IntervalsToRoot = new Interval[] { Interval.Unison, Interval.MajorSecond, Interval.MinorThird, Interval.PerfectFourth, Interval.PerfectFifth, Interval.MinorSixth, Interval.MajorSeventh };

        private HarmonicMinorScale(Key root) : base(root, HarmonicMinorScale.IntervalsToRoot)
        {
        }

        public static Scale AHarmonicMinor = new HarmonicMinorScale(Key.A);
        public static Scale EHarmonicMinor = new HarmonicMinorScale(Key.E);
        public static Scale BHarmonicMinor = new HarmonicMinorScale(Key.B);
        public static Scale FSharpHarmonicMinor = new HarmonicMinorScale(Key.FSharp);
        public static Scale CSharpHarmonicMinor = new HarmonicMinorScale(Key.CSharp);
        public static Scale GSharpHarmonicMinor = new HarmonicMinorScale(Key.GSharp);
        public static Scale DSharpHarmonicMinor = new HarmonicMinorScale(Key.DSharp);
        public static Scale ASharpHarmonicMinor = new HarmonicMinorScale(Key.ASharp);
        public static Scale DHarmonicMinor = new HarmonicMinorScale(Key.D);
        public static Scale GHarmonicMinor = new HarmonicMinorScale(Key.G);
        public static Scale CHarmonicMinor = new HarmonicMinorScale(Key.C);
        public static Scale FHarmonicMinor = new HarmonicMinorScale(Key.F);
        public static Scale BFlatHarmonicMinor = new HarmonicMinorScale(Key.BFlat);
        public static Scale EFlatHarmonicMinor = new HarmonicMinorScale(Key.EFlat);
        public static Scale AFlatHarmonicMinor = new HarmonicMinorScale(Key.AFlat);
    }

    public class MelodicMinorScale : Scale
    {
        public static IReadOnlyCollection<Interval> IntervalsToRoot = new Interval[] { Interval.Unison, Interval.MajorSecond, Interval.MinorThird, Interval.PerfectFourth, Interval.PerfectFifth, Interval.MajorSixth, Interval.MajorSeventh };

        private MelodicMinorScale(Key root) : base(root, MelodicMinorScale.IntervalsToRoot)
        {
        }

        public static Scale AMelodicMinor = new MelodicMinorScale(Key.A);
        public static Scale EMelodicMinor = new MelodicMinorScale(Key.E);
        public static Scale BMelodicMinor = new MelodicMinorScale(Key.B);
        public static Scale FSharpMelodicMinor = new MelodicMinorScale(Key.FSharp);
        public static Scale CSharpMelodicMinor = new MelodicMinorScale(Key.CSharp);
        public static Scale GSharpMelodicMinor = new MelodicMinorScale(Key.GSharp);
        public static Scale DSharpMelodicMinor = new MelodicMinorScale(Key.DSharp);
        public static Scale ASharpMelodicMinor = new MelodicMinorScale(Key.ASharp);
        public static Scale DMelodicMinor = new MelodicMinorScale(Key.D);
        public static Scale GMelodicMinor = new MelodicMinorScale(Key.G);
        public static Scale CMelodicMinor = new MelodicMinorScale(Key.C);
        public static Scale FMelodicMinor = new MelodicMinorScale(Key.F);
        public static Scale BFlatMelodicMinor = new MelodicMinorScale(Key.BFlat);
        public static Scale EFlatMelodicMinor = new MelodicMinorScale(Key.EFlat);
        public static Scale AFlatMelodicMinor = new MelodicMinorScale(Key.AFlat);
    }
}