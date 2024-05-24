using System;
namespace NumberSet;

public class Set{
  public class ElementAlreadyInSetException : Exception{}
  public class ElementNotInSetException : Exception{}
  public class EmptySetException : Exception{}

  private List<int> intElements = new List<int>();
  private int evenCount;

  public Set(){
    intElements = new List<int>();
    evenCount = 0;
  }

  public static bool IsEven(int x){
    return x % 2 == 0;
  }

  public void InsertElement(int x){
    if(IsElementInTheSet(x)){
      throw new ElementAlreadyInSetException();
    }
    intElements.Add(x);  
    if(IsEven(x)){
      evenCount++;
    }
  }

  public bool IsElementInTheSet(int x){
    return intElements.Contains(x);
  }

  public void RemoveElement(int x){
    if(!IsElementInTheSet(x)){
      throw new ElementNotInSetException();
    }
    intElements.Remove(x);
    if(IsEven(x)){
      evenCount--;
    } 
  }

  public bool IsEmpty(){
    return intElements.Count == 0;
  }

  public int GetRandomElement(){
    if(IsEmpty()){
      throw new EmptySetException();
    }
    return intElements[new Random().Next(intElements.Count)];
  }

  public int GetEvenCount(){
    return evenCount;
  }

  public void PrintElements(){
    foreach(int x in intElements){
      Console.Write(x + " ");
    }
    Console.WriteLine();
  }
  
}
