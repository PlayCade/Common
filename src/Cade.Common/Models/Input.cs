namespace Cade.Common.Models
{
    public class Input
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public InputType Type { get; set; }
        public bool Active { get; set; }
        public int Player { get; set; }
    }

    public enum InputType
    {
        Button
    }
}   