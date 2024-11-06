namespace test;
using LinkedListProject;

public class UnitTest1
{
    [Fact]
    public void LinkedListConstructorTest()
    {
		var list = new LinkedList();
		Assert.NotNull(list);
    }

	[Fact]
    public void LinkedListNewFirstElementStructureTest()
    {
		var list = new LinkedList();
		list.addFirst(2);
		Assert.Equal(2, list.first.data);
		Assert.Null(list.first.next);
    }

	[Fact]
	public void LinkedListAddOneElement(){
		var list = new LinkedList();
		list.addFirst(1);
		Assert.Equal(1, list.first.data);
	}

	[Fact]
	public void LinkedListAddMultipleElements(){
		var list = new LinkedList();
		list.addFirst(3);
		list.addFirst(5);
		list.addFirst(1);

		Assert.Equal(1, list.first.data);
		Assert.Equal(5, list.first.next.data);
		Assert.Equal(3, list.first.next.next.data);
	}

	[Fact]
	public void LinkedListRemoveOneElement(){
		var list = new LinkedList();
		list.addFirst(5);
		Assert.Equal(5, list.first.data);
		
		list.removeFirst();
		Assert.Null(list.first);
	}
}