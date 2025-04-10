using System;
using PetAdoptionCentre;
class Program() {
    static void Main(string[] args) {
        
        // This is so simple that I auto-completed most of this
        AdoptionCentre adoptionCentre = new AdoptionCentre();

        string result = adoptionCentre.AdoptPet(); // Call the method to adopt a pet
        if (result == "exit") {
            Console.WriteLine("Exiting the program. Goodbye!");
        } else {
            adoptionCentre.AdoptPet();
        }

    }
} 