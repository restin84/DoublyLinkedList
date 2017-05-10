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
    /// The number of elements in the list
    /// </summary>
    public int Count { get; private set; }

    /// <summary>
    /// Create a DoublyLinkedList
    /// </summary>
    /// <param name="t"></param>
    public DoublyLinkedList() {
    }

    /// <summary>
    /// Insert data in the front of the list
    /// </summary>
    /// <param name="data"></param>
    public void InsertInFront(T data) {
      DoublyLinkedListElement<T> newElement = new DoublyLinkedListElement<T>(data);
      if(head == null) { //This is the first item added
        head = newElement;
        tail = newElement;
      } else {
        head.Previous = newElement;
        newElement.Next = head;
        head = newElement;
      }
      Count++;
    }

    /// <summary>
    /// Insert data at the end of the list
    /// </summary>
    /// <param name="data"></param>
    public void InsertInBack(T data) {
      DoublyLinkedListElement<T> newElement = new DoublyLinkedListElement<T>(data);
      if(tail == null) { //This is the first item added
        tail = newElement;
        head = newElement;
      } else {
        tail.Next = newElement;
        newElement.Previous = tail;
        tail = newElement;
      }
      Count++;
    }

    /// <summary>
    /// Remove an element from the list at the given index
    /// </summary>
    /// <param name="index"></param>
    public void RemoveAtIndex(int index) {
      if (index < Count - 1) {
        if (SearchFromFront(index)) {
          RemoveIndexFromHead(index);
        } else {
          RemoveIndexFromTail(index);
        }
        Count--;
      } else {
        throw new IndexOutOfRangeException();
      }
    }

    /// <summary>
    /// Remove an element at an index by iterating forward from head
    /// </summary>
    /// <param name="index">The index to remove</param>
    private void RemoveIndexFromHead(int index) {
      DoublyLinkedListElement<T> currentElement = head;
      for(int i = 0; i < index; i++) {
        currentElement = currentElement.Next;
      }
      Remove(currentElement);
    }

    /// <summary>
    /// Remove an element at an index by iterating backward from head
    /// </summary>
    /// <param name="index">The index to remove</param>
    private void RemoveIndexFromTail(int index) {
      DoublyLinkedListElement<T> currentElement = tail;
      for(int i = Count - 1; i > index; i--) {
        currentElement = currentElement.Previous;
      }
      Remove(currentElement);
    }

    /// <summary>
    /// Remove a particular element from the list
    /// </summary>
    /// <param name="toRemove"></param>
    private void Remove(DoublyLinkedListElement<T> toRemove) {
      if(head == toRemove && tail == toRemove) {
        head = null;
        tail = null;
      } else if (toRemove == tail) {
        tail = toRemove.Previous;
      } else if (toRemove == head) {
        head = toRemove.Next;
      } else {
        toRemove.Previous.Next = toRemove.Next;
        toRemove.Next.Previous = toRemove.Previous;
      }
    }

    /// <summary>
    /// Indicates whether or not an item should be found by iterating forward from the head
    /// </summary>
    /// <param name="index"></param>
    /// <returns>true if the distance from head to index is shorter that the index from tail to index</returns>
    private bool SearchFromFront(int index) {
      return index < Count - 1 - index;
    }

    /// <summary>
    /// Display the contents of the list starting from the head element
    /// </summary>
    public void PrintListFrontToBack() {
      if (Empty()) {
        return;
      }
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
      if (Empty()) {
        return;
      }
      DoublyLinkedListElement<T> currentElement = tail;
      while(currentElement.Previous != null) {
        Console.Write("{0} ", currentElement.Data);
        currentElement = currentElement.Previous;
      }
      Console.WriteLine("{0}", currentElement.Data);
    }

    /// <summary>
    /// Determines whether or not the list is empty
    /// </summary>
    /// <returns></returns>
    public bool Empty() {
      return head == null;
    }
  }
}
