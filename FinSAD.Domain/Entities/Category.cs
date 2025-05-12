namespace FinSAD.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsCustom { get; set; }

        public void Create() { }
        public void Edit() { }
        public void Delete() { }
    }
}