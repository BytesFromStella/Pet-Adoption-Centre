namespace PetAdoptionCentre {
    public abstract class Pet {
        public string Name { get; set; }
        public float Age { get; set; }
        public string Type { get; set; }
        public bool IsAdopted { get; set; }
        public string Health { get; set; }
        public Pet(string name, float age, string type, bool isAdopted, string health) {
            Name = name;
            Age = age;
            Type = type;
            IsAdopted = isAdopted;
            Health = health;
        }
        public abstract void Speak();
    }
}