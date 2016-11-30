//Assigment #6

//Copy this block into your Visual Studio

//Review and Redo this code line by line at home.

//Place comments on each line and describe what the code is doing

using System; //using directive that makes it so you dont have to type system.Console

namespace ConsoleApplication1 //organizer that is only meaningful within this name space
{
    public struct Pet //defines public struct
    {
        public string Name; //declares a property
        public string TypeOfPet;//declares a property
    }

    class Program //defines class
    {
        static void Main()//start of program
        {
            var numberofPets = 0;//declares a variable and sets it to 0
            var pets = new Pet[10]; //creates an array

            while (true)//start of loop
            {
                Console.Write("A)dd D)elete L)ist pets;");//shows on console
                var choice = Console.ReadLine();//reads and stores what was inputed on console

                switch (choice)//begining of options to choose from
                {
                    case "A"://when user types A 
                    case "a"://when user types a
                        {
                            Console.Write("Name :"); //show on console "Name" - allowing user to name pet 
                            var name = Console.ReadLine();//reads and stores user input

                            Console.Write("Type of pet :"); //shows on console to allow user to input type of bed
                            var typeOfPet = Console.ReadLine();//reads and stores user input

                            //always add the pet at the end of the array

                            pets[numberofPets].Name = name;//adds the name of pet to the array
                            pets[numberofPets].TypeOfPet = typeOfPet;//adds the type of pet to the array

                            numberofPets++;//increase number of pets by 1 
                            break;//end of option A/a
                       }
                    case "D"://when user types D
                    case "d"://when user types d
                        {
                            if(numberofPets==0) //if there are no pets 
                            {
                                Console.WriteLine("No Pets");//console will show "No Pets"
                                break; //end of option
                            }
                            for (var index =0; index<numberofPets;index++)//if there are pets 
                            {
                                Console.WriteLine("{0}.{1,-10}{2}", index + 1, pets[index].Name, pets[index].TypeOfPet);//console will show a number starting with 1, name of pet
                                //and type of pet
                            }
                            Console.WriteLine("Which pet to remove (1-{0})", numberofPets);//console asks which pet to delete

                            var petNumberToDelete = Console.ReadLine();//reads and stores user input
                            var indexToDelete = int.Parse(petNumberToDelete);//tells array which pet to remove
                            //Squish the array from index to the end

                            for (var index = indexToDelete - 1; index < numberofPets; index++)//removes pet from array
                            {
                                //just copy the pet from the next index into the current index
                                pets[index] = pets[index + 1];//moves pets up in array
                            }
                            //we have one less pet 
                            numberofPets--;//decreases the number of pets by 1
                            break;//end of option
                        }
                    case "L"://if user typed L
                    case "l"://if user typed l
                        {
                            if (numberofPets==0)//if there are no pets to list
                            {
                                Console.WriteLine("No pets");//console will write no pets 
                            }
                              for (int index=0; index<numberofPets; index++)//refrences array of pets
                            {
                                Console.WriteLine("{0}.{1,-10} {2}", index+1, pets[index].Name, pets[index].TypeOfPet);//console writes number of pets, names and types
                            }
                            break;// end of option
                        }
                    default://if none of the above options are selected
                        {
                            Console.WriteLine("Invalid option[{0}]", choice);//console writes "Invalid option" followed by what the user inputed
                            break;//end of option
                        }   
                }
                    }

        }
    }
}
