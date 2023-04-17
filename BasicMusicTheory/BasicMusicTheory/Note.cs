namespace BasicMusicTheory
{
    public class Note
    {
        public Pitch Pitch { get; set; }
        public Duration Duration { get; set; }

        public Note(Pitch pitch, Duration duration)
        {
            Pitch = pitch;
            Duration = duration;
        }

        public void Shift(Interval interval)
        {
            Pitch += interval;
        }

        public void Extend(Duration duration)
        {
            Duration += duration;
        }

        public void Shorten(Duration duration)
        {
            if (duration > Duration)
            {
                throw new InvalidOperationException("Cannot shorten a note by more than its duration.");
            }

            Duration -= duration;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj is Note)
            {
                return this == (Note)obj;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Pitch.GetHashCode() ^ Duration.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Pitch} for {Duration}";
        }

        public static Note operator +(Note note, Interval interval)
        {
            return new Note(note.Pitch + interval, note.Duration);
        }

        public static Note operator -(Note note, Interval interval)
        {
            return new Note(note.Pitch - interval, note.Duration);
        }

        public static Note operator +(Note note, Duration duration)
        {
            return new Note(note.Pitch, note.Duration + duration);
        }

        public static Note operator -(Note note, Duration duration)
        {
            if (duration > note.Duration)
            {
                throw new InvalidOperationException("Cannot shorten a note by more than its duration.");
            }

            return new Note(note.Pitch, note.Duration - duration);
        }

        public static bool operator ==(Note a, Note b)
        {
            return a.Pitch == b.Pitch && a.Duration == b.Duration;
        }

        public static bool operator !=(Note a, Note b)
        {
            return !(a == b);
        }
    }
}
