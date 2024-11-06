namespace test;

using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using LinkedListProject;

public class UnitTest1
{
    [Fact]
    public void ConstructorTest()
    {
		var list = new LinkedList();
		Assert.NotNull(list);
    }

	[Fact]
    public void NewFirstElementStructureTest()
    {
		var list = new LinkedList();
		list.addFirst(2);
		Assert.Equal(2, list.first.data);
		Assert.Null(list.first.next);
    }

	[Fact]
	public void AddOneElement(){
		var list = new LinkedList();
		list.addFirst(1);
		Assert.Equal(1, list.first.data);
	}

	[Fact]
	public void AddMultipleElements(){
		var list = new LinkedList();
		list.addFirst(3);
		list.addFirst(5);
		list.addFirst(1);

		Assert.Equal(1, list.first.data);
		Assert.Equal(5, list.first.next.data);
		Assert.Equal(3, list.first.next.next.data);
	}

	[Fact]
	public void RemoveOneElement(){
		var list = new LinkedList();
		list.addFirst(5);
		Assert.Equal(5, list.first.data);
		
		list.removeFirst();
		Assert.Null(list.first);
	}
	[Fact]
	public void AddTwoRemoveOneElement(){
		var list = new LinkedList();
		list.addFirst(3);
		list.addFirst(7);

		Assert.Equal(7, list.first.data);

		list.removeFirst();

		Assert.Equal(3, list.first.data);
		Assert.Null(list.first.next);
	}

	[Fact]
	public void AddingToCount(){
		var list = new LinkedList();
		Assert.Equal(0,list.Count);
		list.addFirst(2);
		Assert.Equal(1,list.Count);
	}
	
	[Fact]
	public void RemovingFromCount(){
		var list = new LinkedList();
		list.addFirst(2);
		list.addFirst(5);

		list.removeFirst();

		Assert.Equal(1,list.Count);
	}

	[Fact]
	public void ToStringTest()
	{
		var list = new LinkedList();
		Assert.Equal("LinkedList: Empty", list.ToString());

		list.addFirst(3);
		list.addFirst(8);
		list.addFirst(1);

		Assert.Equal("LinkedList: 1, 8, 3", list.ToString());
	}

	[Theory]
	[InlineData (1, 2, 3, true)]
	[InlineData (4, 3, 2, false)]
	public void IsSorted(int a, int b, int c, bool result){
		var list = new LinkedList();

		list.addFirst(c);
		list.addFirst(b);
		list.addFirst(a);

		Assert.Equal(result, list.IsSorted());
	}
	[Fact] 
	public void IsEmptySorted(){
		var list = new LinkedList();
		Assert.True(list.IsSorted());
	}

	[Fact]
	public void LLSortEmpty(){
		var list = new LinkedList();
		list.Sort();
		Assert.True(list.IsSorted());
	}

	[Fact]
	public void LLSort(){
		var list = new LinkedList();
		list.addFirst(5);
		list.addFirst(2);
		list.addFirst(9);
		list.addFirst(1);
		list.addFirst(4);
		list.Sort();
		Assert.True(list.IsSorted());
	}
}