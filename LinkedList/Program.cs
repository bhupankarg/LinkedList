using System;

class Node
{
    public int data;
    public Node next;
    public Node() { }
    public Node(int data)
    {
        this.data = data;
        this.next = null;
    }
}

class LinkedList
{
    private Node head = new Node();
    public void InsertAtBegin(int data)
    {
        Node newNode = new Node(data);
        if (head.next != null)
        {
            newNode.next = head.next;
        }
        head.next = newNode;
        Console.WriteLine("{0} is inserted at begin successfully.", head.next.data);
    }

    public void InsertAtEnd(int data)
    {
        Node newNode = new Node(data);
        if (head.next != null)
        {
            Node temp = head;
            while (true)
            {
                if (temp.next == null)
                {
                    temp.next = newNode;
                    break;
                }
                temp = temp.next;
            }
        }
        else
        {
            head.next = newNode;
        }
        Console.WriteLine("{0} is inserted at end successfully.", data);
    }

    public void RemoveFromBegin()
    {
        if (head.next != null)
        {
            Node temp = head.next;
            head.next = temp.next;
            Console.WriteLine("{0} is removed from begin successfully.", temp.data);
            return;
        }
        Console.WriteLine("Error: Empty list. Nothing to remove.");
    }

    public void RemoveFromEnd()
    {
        if (head.next != null)
        {
            Node prev = head;
            Node curr = head.next;
            while (true)
            {
                if (curr.next == null)
                {
                    prev.next = null;
                    Console.WriteLine("{0} is removed from end successfully.", curr.data);
                    return;
                }
                prev = curr;
                curr = curr.next;
            }
        }
        Console.WriteLine("Error: Empty list. Nothing to remove.");
    }

    public void DisplayList()
    {
        if (head.next != null)
        {
            Node temp = head.next;
            Console.WriteLine("The list is...");
            while (temp != null)
            {
                Console.Write("{0} ", temp.data);
                temp = temp.next;
            }
            Console.Write("\n");
        }
        else
        {
            Console.WriteLine("Error: Empty list. Nothing to display.");
        }
    }
}

namespace MainApp
{
    class Program
    {
        static void Main()
        {
            int data;
            LinkedList lList = new LinkedList();
            while (true)
            {
                Console.WriteLine("********************MAIN MENU********************");
                Console.WriteLine("1 -> Insert at begin");
                Console.WriteLine("2 -> Insert at end");
                Console.WriteLine("3 -> Remove from begin");
                Console.WriteLine("4 -> Remove from end");
                Console.WriteLine("5 -> Display LinkedList");
                Console.WriteLine("0 -> Exit menu");
                Console.WriteLine("Enter your choice...");
                Console.WriteLine("*************************************************");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        Console.Write("Enter a number to insert at begin: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        lList.InsertAtBegin(data);
                        break;
                    case 2:
                        Console.Write("Enter a number to insert at end: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        lList.InsertAtEnd(data);
                        break;
                    case 3:
                        lList.RemoveFromBegin();
                        break;
                    case 4:
                        lList.RemoveFromEnd();
                        break;
                    case 5:
                        lList.DisplayList();
                        break;
                    default:
                        Console.WriteLine("Error: Invalid choice. Enter again.");
                        break;
                }
            }
        }
    }
}
