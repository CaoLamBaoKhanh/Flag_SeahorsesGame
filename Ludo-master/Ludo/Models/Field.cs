namespace Ludo.Models
{
    using Ludo.Enumerations;

    public class Field
    {
        public FieldType Type { get; set; }
        public int XPos { get; set; }
        public int YPos { get; set; }
        public bool HasPawn { get; set; }

        public Field(FieldType type, int x, int y)
        {
            this.Type = type;
            this.XPos = x;
            this.YPos = y;
            this.HasPawn = false;
        }
    }
}
