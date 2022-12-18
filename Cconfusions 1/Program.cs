// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] newList = new int[0];
int[] newList2 = new int[newList.Length +1];
newList= newList2;
newList[0] = 100; //got error out of range
Console.WriteLine(newList[0]);
if (newList == newList2)
{
    Console.WriteLine("its the same");
}

Console.WriteLine(newList2[0]); // so newList2 and newList1 share the same reference.!!!!

List<string> list = new List<string>();
list.Add("one");
list.Add("two");
foreach (string items in list._items){
    Console.WriteLine(items);
}

class List<T>
{
    public T[] _items = new T[0];   // Does't the 0 create an array of 0 slots, which can't be changed, right?
    //public T GetItemAt(int index ) => _items[index];
    public void Add(T newValue)
    {
        T[] updated = new T[_items.Length + 1]; // this creates a new array with 1+ spot than _items[T]
        for (int index = 0; index < _items.Length; index++) {   // first iteration, nothing happens
            updated[index] = _items[index];}

        updated[^1] = newValue;
        _items = updated;
    }
}