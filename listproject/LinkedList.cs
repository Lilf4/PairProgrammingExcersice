using System.Linq.Expressions;
using System.Text;

namespace LinkedListProject
{
	public class LinkedList
	{
		public Element? first;

		public int Count { get { return count; } }
		private int count = 0;
		public void addFirst(int num)
		{
			var new_element = new Element(num);
			if (first != null)
			{
				new_element.next = new Element(first);
			}

			first = new_element;
			count++;
		}

		public void removeFirst()
		{
			first = first.next;
			count--;
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("LinkedList: ");
			if (first != null)
			{
				var currElement = first;
				for (int i = 0; i < Count; i++)
				{
					stringBuilder.Append(currElement.data.ToString());
					if (currElement.next != null)
					{
						stringBuilder.Append(", ");
						currElement = currElement.next;
					}
				}
			}
			else
			{
				stringBuilder.Append("Empty");
			}
			return stringBuilder.ToString();
		}

		public void Sort()
		{
			if (IsSorted()) return;
			
			while (!IsSorted())
			{
				var currElement = first;
				for (int i = 0; i < Count - 1; i++)
				{
					if (currElement.data > currElement.next.data)
					{
						var temp = currElement.data;
						currElement.data = currElement.next.data;
						currElement.next.data = temp;
					}
					currElement = currElement.next;
				}
			}
		}

		public bool IsSorted()
		{
			if (first == null) return true;
			var currElement = first;
			for (int i = 0; i < Count; i++)
			{
				if (currElement.next == null) return true;
				if (currElement.data > currElement.next.data)
				{
					return false;
				}
				currElement = currElement.next;
			}
			return true;
		}

		public class Element
		{
			public int data;
			public Element? next;
			public Element(int new_data)
			{
				data = new_data;
			}
			public Element(Element to_copy = null)
			{
				if (to_copy != null)
				{
					data = to_copy.data;
					next = to_copy.next;
				}
			}
		}
	}
}