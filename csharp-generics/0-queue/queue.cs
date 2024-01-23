public class Queue<T>
{
     public string CheckType()
    {
        return $"Queue<{typeof(T).Name}>";
    }
}