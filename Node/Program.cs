﻿using System.Runtime.CompilerServices;

namespace Node{

	public class Node{
		private int val;
		public int Val{
			get => val;
		}

		public Node next;
		public Node previous;

		public Node(){
			val = -1;
			next = null;
			previous = null;
		}

		public Node(int val){
			this.val = val;
			next = null;
			previous = null;
		}

		public static bool operator ==(Node node1, Node node2){
			return node1.Val == node2.Val;
		}

		public static bool operator !=(Node node1, Node node2){
			return false;
		}

	}
}

public class NodeTester{
	public static void Main(){}
}