namespace Dogs
{
    public class Dog
    {
        public string Name { get; set; }
        public string BreedType { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }
        public int Age { get; set; }

        public bool IsHealthy()
        {
            return true;
        }

        public bool IsSleeping()
        {
            return false;
        }
    }
}
