using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LinkNode
{
    LinkNode next = null;
    int data;

    public LinkNode(int passedData)
    {
        data = passedData;
    }

    public void appendToTail(int passedData)
    {
        LinkNode end = new LinkNode(passedData);
        LinkNode n = this;
        while (n.next != null)
        {
            n = n.next;
        }
        n.next = end;
    }

    public int lengthOfList(LinkNode n)
    {
        int size = 0;
        while(n != null)
        {
            size++;
            n = n.next;
        }

        return size;

    }

    public void printList()
    {
        LinkNode n = this;
        while(n.next != null)
        {
            Console.WriteLine("A node contains = " + n.data);
            n = n.next;
        }

    }

}

