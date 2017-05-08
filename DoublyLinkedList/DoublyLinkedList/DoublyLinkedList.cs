using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList {
  /// <summary>
  /// Doubly linked list implementation
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public class DoublyLinkedList<T> {

    /// <summary>
    /// Reference to the first element in the list
    /// </summary>
    private DoublyLinkedListElement<T> head;

    /// <summary>
    /// Reference to the last element in the list
    /// </summary>
    private DoublyLinkedListElement<T> tail;

    /// <summary>
    /// Create a DoublyLinkedList
    /// </summary>
    /// <param name="t"></param>
    public DoublyLinkedList(T t) {
      head = new DoublyLinkedListElement<T>(t);
      tail = head;
    }

    /// <summary>
    /// Insert data in the front of the list
    /// </summary>
    /// <param name="data"></param>
    public void InsertInFront(T data) {
      DoublyLinkedListElement<T> newElement = new DoublyLinkedListElement<T>(data);
      head.Previous = newElement;
      newElement.Next = head;
      head = newElement;
    }

    /// <summary>
    /// Insert data at the end of the list
    /// </summary>
    /// <param name="data"></param>
    public void InsertInBack(T data) {
      DoublyLinkedListElement<T> newElement = new DoublyLinkedListElement<T>(data);
      tail.Next = newElement;
      newElement.Previous = tail;
      tail = newElement;
    }

    /// <summary>
    /// Display the contents of the list starting from the head element
    /// </summary>
    public void PrintListFrontToBack() {
      DoublyLinkedListElement<T> currentElement = head;
      while(currentElement.Next != null) {
        Console.Write("{0} ", currentElement.Data);
        currentElement = currentElement.Next;
      }
      Console.WriteLine("{0}", currentElement.Data);
    }

    /// <summary>
    /// Display the contents of the list starting from the tail element
    /// </summary>
    public void PrintListBackToFront() {
      DoublyLinkedListElement<T> currentElement = tail;
      while(currentElement.Previous != null) {
        Console.Write("{0} ", currentElement.Data);
        currentElement = currentElement.Previous;
      }
      Console.WriteLine("{0}", currentElement.Data);
    }
  }
}
