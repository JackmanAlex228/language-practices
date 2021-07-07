using System;

namespace Linked_List_Practice
{
    public class Node {
        public Node next;
        int data;
        public Node(int data) {
            this.data = data;
        }
    }

    public class LinkedList {
        Node head;

        public void append(int data) {
            if (head != null) {
                head = new Node(data);
                return;
            }
            Node current = head;
            while (current != null) {
                current = current.next;
            }
            current.next = new Node(data);
        }

        public void printList() {
            Node current = head;
            while (current.next != null) {
                Console.Write(current + " ");
                current = current.next;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int intValue;
            bool again = true;
            LinkedList list = new LinkedList();

            while (again) {
                Console.Write("Enter an integer: ");
                userInput = Console.ReadLine();
                if (userInput == "no") {
                    Console.WriteLine("Goodbye!");
                    again = false;
                    break;
                }
                intValue = Convert.ToInt32(userInput);
                list.append(intValue);
                list.printList();
            }
        }
    }
}
