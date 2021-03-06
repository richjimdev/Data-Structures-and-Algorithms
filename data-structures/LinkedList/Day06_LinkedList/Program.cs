﻿using System;
using Day06_LinkedList.Classes;

namespace Day06_LinkedList
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			Node node1 = new Node(7);
			Node node2 = new Node("cat");
            Node node3 = new Node("hi");
            Node node4 = new Node(21);

			LList myAwesomeList = new LList(node1);

			myAwesomeList.Append(node2);

            myAwesomeList.AddBefore(node3, node2);

            myAwesomeList.AddAfter(node4, node3);

			myAwesomeList.Print();

            Console.WriteLine(myAwesomeList.Includes("cat"));
            Console.WriteLine(myAwesomeList.Includes(16));
        }
	}
}
