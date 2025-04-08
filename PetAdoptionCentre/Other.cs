namespace PetAdoptionCentre {
    public class OtherPet(string name, int age, string type, bool isAdopted, string health) 
                          :Pet(name, age, type, isAdopted, health) {

        // You have to use override when defining abstract implied methods when inheriting
        public override void Speak() { 
            Console.WriteLine("Meowoof! Or something..."); // Uhhhh...
        }

    }
}   