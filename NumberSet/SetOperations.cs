namespace NumberSet;

public class SetOperations
{
  private readonly Set set1;

  public SetOperations()
  {
    set1 = new Set();
  }

  public void RunOperations(){
    int choice = 0;
    Console.WriteLine("=====================================");
    Console.WriteLine("WELCOME TO THE INTEGER NUMBERS SET :)");
    Console.WriteLine("=====================================");
    Console.WriteLine("choose an operation to perform below:");
    do{
        try{
            Console.WriteLine("1. Insert element");
            Console.WriteLine("2. Remove element");
            Console.WriteLine("3. Check if element is in the set");
            Console.WriteLine("4. Print elements");
            Console.WriteLine("5. Check if set is empty");
            Console.WriteLine("6. Get a random element");
            Console.WriteLine("7. Get the count of even numbers");
            Console.WriteLine("8. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
              switch(choice){
                case 1:
                    Console.Write("Enter element to insert: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    set1.InsertElement(x);
                    break;
                case 2:
                    Console.Write("Enter element to remove: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    set1.RemoveElement(x);
                    break;
                case 3:
                    Console.Write("Enter element to check: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    if(set1.IsElementInTheSet(x)){
                        Console.WriteLine("Element is in the set");
                    }
                    else{
                        throw new Set.ElementNotInSetException();
                    }
                    break;
                case 4:
                    set1.PrintElements();
                    break;
                case 5:
                    if(!set1.IsEmpty()){
                        Console.WriteLine("Set is not empty");
                    }
                    else{
                        throw new Set.EmptySetException();
                    }
                    break;
                case 6:
                    int randomElement = set1.GetRandomElement();
                    Console.WriteLine("Random element is: " + randomElement);
                    break;
                case 7:
                    int evenCount = set1.GetEvenCount();
                    Console.WriteLine("The count of even numbers is: " + evenCount);
                    break;
                case 8:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
              }
        }
        catch (Set.ElementAlreadyInSetException){
            Console.WriteLine("Element already exists in the set");  
        }
        catch (Set.ElementNotInSetException){
            Console.WriteLine("Element does not exist in the set");
        }
        catch (Set.EmptySetException){
            Console.WriteLine("Set is empty");
        }
        catch (FormatException){
            Console.WriteLine("Invalid input. Please enter a number");
        }
      }while(choice != 8);
   }
}

