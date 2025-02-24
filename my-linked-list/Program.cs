using MyLinkedListCollection;
using System;

    MyLinkedList linkedList = new MyLinkedList();
    linkedList.Add(10);
    linkedList.Add(20);
    linkedList.Add(30);
    linkedList.Print();

    linkedList.Add(2, 40);
    linkedList.Print();
    linkedList[1] = 15;
    linkedList.Print();
