using System.Collections;



DoubleLinkedList<string> colorList = new()
{
    "red",
    "blue",
    "yellow",
    "green",
    "purple"
};


/////////// Вывод элементов в обратном порядке ///////////
foreach(var item in colorList)
{
    Console.WriteLine($"{item.Value}");
}

public class Node<T>
{
    public T Value { get; set; }
    public Node<T>? Next { get; set; }
    public Node<T>? Previous { get; set; }

    public Node(T value)
    {
        Value = value;
    }
}
public class DoubleLinkedList<T>: IEnumerable<T>
{
    public Node<T>? Root { get; set; }
    public int Count { get; set; }

/////////// Добавление в конец списка ///////////
    public void Add(T nodeValueToAdd)
    {
        var nodeToAdd = new Node<T>(nodeValueToAdd);
        
        if(Root is null) Root = nodeToAdd;
        else
        {
            nodeToAdd.Next = Root;
            Root.Previous = nodeToAdd;
            Root = nodeToAdd;
        }

        Count++;

    }

/////////// Поиск элемента по значению ///////////
    public Node<T> FindByValue(T valueToFind)
    {
        if(Root is null) return null;
        if(EqualityComparer<T>.Default.Equals(Root.Value, valueToFind)) return Root;

        var currentNode = Root;

        while(currentNode is not null)
        {
                if(EqualityComparer<T>.Default.Equals(currentNode.Value, valueToFind)) return currentNode;
                currentNode = currentNode.Next;
        }

        return null;
    }    

/////////// Удаление элемента из списка ///////////
    public void Remove(T valueToRemove)
    {
        if(Root is null) return;

        var nodeToRemove = FindByValue(valueToRemove);
        if(nodeToRemove is null) return;

        var nextNode = nodeToRemove.Next;
        var prevNode = nodeToRemove.Previous;

        if(prevNode is not null) prevNode.Next = nextNode;
        if(nextNode is not null) nextNode.Previous = prevNode;

        Root = nextNode;

        Count--;
    }
    public IEnumerator<Node<T>> GetEnumerator()
    {
        var currentNode = Root;

        while(currentNode is not null)
        {
            yield return currentNode;
            currentNode = currentNode.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        throw new NotImplementedException();
    }

}

