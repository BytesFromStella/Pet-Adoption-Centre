namespace PetAdoptionCentre;
public class AdoptionCentre {
    public string AdoptPet() {
        Console.WriteLine("Get yo dogs, cats and whatever else here. Whatchu want?");
        Console.WriteLine("1. Dog");
        Console.WriteLine("2. Cat");
        Console.WriteLine("3. Bird");
        Console.WriteLine("9. Other");
        Console.WriteLine("0. Exit");
        Console.WriteLine("Choose and pick which one you want:");
        int choice = int.Parse(Console.ReadLine() ?? "0"); // Nulling to 0 for safety, if something invalid is written
        Pet adoptedPet; // This is the pet that will be adopted, if any

        switch (choice) {
            case 0:
                Console.WriteLine("Okke bye then.");
                return "exit";
            case 1:
                Console.WriteLine("A dawg? Sure.");
                Console.WriteLine("What is the name of the dog?");
                string dogName = Console.ReadLine() ?? "none"; 

                Console.WriteLine("What's its age?");
                int dogAge = int.Parse(Console.ReadLine() ?? "0");

                Console.WriteLine("What breed is the dog?");
                string dogType = Console.ReadLine() ?? "none";

                Console.WriteLine("Is it adopted? (true/false)");
                bool dogIsAdopted = bool.Parse(Console.ReadLine() ?? "false");

                Console.WriteLine("What is the health of this dog? (Number from 1-10)");
                string dogHealth = Console.ReadLine() ?? "0";

                adoptedPet = new Dog(dogName, dogAge, dogType, dogIsAdopted, dogHealth);
                break;
            case 2:
                Console.WriteLine("A kitty? Sure.");
                Console.WriteLine("What is the name of the cat?");
                string catName = Console.ReadLine() ?? "none"; 

                Console.WriteLine("What's its age?");
                int catAge = int.Parse(Console.ReadLine() ?? "0");

                Console.WriteLine("What breed is the cat?");
                string catType = Console.ReadLine() ?? "none";

                Console.WriteLine("Is it adopted? (true/false)");
                bool catIsAdopted = bool.Parse(Console.ReadLine() ?? "false");

                Console.WriteLine("What is the health of this cat? (Number from 1-10)");
                string catHealth = Console.ReadLine() ?? "0";

                adoptedPet = new Cat(catName, catAge, catType, catIsAdopted, catHealth);
                break;
            case 3:
                Console.WriteLine("A birb? Sure.");
                Console.WriteLine("What is the name of the bird?");
                string birdName = Console.ReadLine() ?? "none"; 

                Console.WriteLine("What's it's age?");
                int birdAge = int.Parse(Console.ReadLine() ?? "0");

                Console.WriteLine("What type of bird is it?");
                string birdType = Console.ReadLine() ?? "none";

                Console.WriteLine("Is it adopted? (true/false)");
                bool birdIsAdopted = bool.Parse(Console.ReadLine() ?? "false");

                Console.WriteLine("What is the health of this bird? (Number from 1-10)");
                string birdHealth = Console.ReadLine() ?? "0";

                adoptedPet = new Bird(birdName, birdAge, birdType, birdIsAdopted, birdHealth);
                break;
            case 9:
                Console.WriteLine("Idunno what this is, but sure.");
                Console.WriteLine("What is the name of the mysterious creature?");
                string otherName = Console.ReadLine() ?? "none"; 

                Console.WriteLine("What's it's age?");
                int otherAge = int.Parse(Console.ReadLine() ?? "0"); 
                
                Console.WriteLine("What is the type of this creature?");
                string otherType = Console.ReadLine() ?? "none"; 
                
                Console.WriteLine("Is it adopted? (true/false)");
                bool otherIsAdopted = bool.Parse(Console.ReadLine() ?? "false"); 
                
                Console.WriteLine("What is the health of this... creature? (Number from 1-10)");
                string otherHealth = Console.ReadLine() ?? "0";

                adoptedPet = new OtherPet(otherName, otherAge, otherType, otherIsAdopted, otherHealth);
                break;
            default:
                Console.WriteLine("Huh? Try that again, but make it comprehensible.");
                return "none";
        }

        

        string output = $"You have adopted a {adoptedPet.GetType().Name} named {adoptedPet.Name}.";
        Console.WriteLine(output);

        return output;
    }

}
