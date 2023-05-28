namespace CarDealership.WinForms
{
    public record SearchOption(string Description, SearchType By)
    {
        public override string ToString()
        {
            return Description;
        }
    }
}
