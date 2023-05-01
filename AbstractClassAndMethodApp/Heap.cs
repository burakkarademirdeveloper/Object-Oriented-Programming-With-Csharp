
public abstract class Heap
{
    //filed
    protected SortedSet<int> _list;

    public Heap()
    {
        _list = new SortedSet<int>();
    }

    public void Insert(int item)
    {
        _list.Add(item);
    }

    //Abstract method : 
    public abstract int Extract(); // Abstract methodun tanımlandığı class abstract olmalı. Tanımlanan method ezilerek yapılacağı görevler tanımlanmalı. Abstract class new'lenmediği için kalıtımla bu işlemler sağlanmalı.
}
