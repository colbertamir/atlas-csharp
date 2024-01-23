public class Queue<T>
{
     public string CheckType()
    {
        return $"System{typeof(T).Name}";
    }
}