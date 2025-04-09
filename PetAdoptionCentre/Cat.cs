namespace PetAdoptionCentre {
    public class Cat : Pet {
        public Cat(string name, int age, string type, bool isAdopted, string health) : 
                base(name, age, type, isAdopted, health) {
            // Constructor for Cat class
        }

        // You have to use override when defining abstract implied methods when inheriting
        public override void Speak() { 
            Console.WriteLine("Meow moew mewow!"); // Cat noises hehehe
        }

    }
}   