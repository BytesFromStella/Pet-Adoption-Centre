namespace PetAdoptionCentre {
    public class Dog(string name, float age, string type, bool isAdopted, string health) 
                          :Pet(name, age, type, isAdopted, health) {

        // You have to use override when defining abstract implied methods when inheriting
        public override void Speak() { 
            Console.WriteLine("Woof! Woof! Bjørk Bjørk!"); // Dog noises hehe
        }

    }
}