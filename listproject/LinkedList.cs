using System.Linq.Expressions;

namespace LinkedListProject{
	public class LinkedList{
		public Element? first;
		public void addFirst(int num){
			var new_element = new Element(num);

			if(first != null){
				new_element.next = new Element(first);
			}

			first = new_element;
		}

		public void removeFirst(){
			first = first.next;
		}
	}

	public class Element{
		public int data;
		public Element? next;
		public Element(int new_data){
			data = new_data;
		}
		public Element(Element to_copy = null){
			if (to_copy != null){
				data = to_copy.data;
				next = to_copy.next;
			}
		}
	}
}