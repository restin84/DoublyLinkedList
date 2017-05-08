using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList {
  public class DoublyLinkedListElement<T> {
    /// <summary>
    /// The data held by this DoublyLinkedListElement
    /// </summary>
    public T Data { get; private set; }

    /// <summary>
    /// A reference to the next element
    /// </summary>
    public DoublyLinkedListElement<T> Next { get; set; }

    /// <summary>
    /// A reference to the last element
    /// </summary>
    public DoublyLinkedListElement<T> Previous { get; set; }

    /// <summary>
    /// Create a new DoublyLinkedListElement
    /// </summary>
    /// <param name="data"></param>
    public DoublyLinkedListElement(T data) {
      Data = data;
    }
  }
}
