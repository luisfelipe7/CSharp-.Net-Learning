using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MySecondApplication.Exercises.Three
{
  public class StackSystem
  {
    private readonly Stack<object> Stack;


    public StackSystem()
    {
      this.Stack = new Stack<object>();
    }

    public void Push(object element)
    {
      if (element != null)
      {
        this.Stack.Push(element);
        Console.WriteLine("\n Element added sucessfully " + element);
      }
      else
      {
        throw new InvalidOperationException("The element to add can't be null");
      }
    }

    public void Pop()
    {
      if (this.Stack.Count > 0)
      {
        object removedElement = this.Stack.Pop();
        Console.WriteLine("\n Element removed sucessfully " + removedElement);
      }
      else
      {
        throw new InvalidOperationException("The stack is empty, so operation can't be applied");
      }
    }

    public void Clear()
    {
      this.Stack.Clear();
      Console.WriteLine("\n Stack cleared sucessfully");
    }

    public void DisplayActualStack()
    {
      Console.WriteLine("\n Actual Elements in the Stack (Printing from end to start):");
      if (this.Stack.Count != 0)
      {
        foreach (var element in this.Stack)
        {
          Console.WriteLine("Element: " + element);
        }
      }
      else
      {
        Console.WriteLine("\n The Stack is Empty");
      }
    }

  }
}

