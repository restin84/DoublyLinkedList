using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList {
  class Program {
    static void Main(string[] args) {
      DoublyLinkedList<int> test1 = new DoublyLinkedList<int>();
      test1.InsertInBack(1);
      test1.InsertInBack(2);
      test1.InsertInBack(3);
      test1.InsertInBack(4);
      test1.PrintListBackToFront();
      test1.PrintListFrontToBack();
      DoublyLinkedList<int> test2 = new DoublyLinkedList<int>();
      test2.InsertInFront(4);
      test2.InsertInFront(3);
      test2.InsertInBack(5);
      test2.InsertInFront(2);
      test2.InsertInBack(6);
      test2.PrintListFrontToBack();
      test2.PrintListBackToFront();
      test1.RemoveAtIndex(2);
      test2.RemoveAtIndex(3);
      test1.PrintListFrontToBack();
      test2.PrintListFrontToBack();
      Console.ReadKey();
    }
  }
}
