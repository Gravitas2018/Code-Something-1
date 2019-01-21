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

    void appendToTail(int passedData)
    {
        LinkNode end = new LinkNode(passedData);
        LinkNode n = this;
        while (n.next != null)
        {
            n = n.next;
        }
        n.next = end;
    }

}

