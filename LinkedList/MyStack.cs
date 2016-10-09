public class StackElement {
	public int Value {get;set;}
	public int MaxValue {get;set;}
}

public class MaxValueStack
{
    private StackElement[] stack;
    private int count = 0;
    private int capacity;

    public MaxValueStack(int capacity)
    {
        this.capacity = capacity;
        stack = new StackElement[capacity];
    }

    public void Push(int value)
    {
        if (count < capacity)
        {
            if (count == 0)
            {
                stack[count] = new StackElement() {Value = value, MaxValue = value};
                count++;
            }
            else
            {
                StackElement element = new StackElement();
                element.Value = value;
                if (value < stack[count - 1].MaxValue)
                    element.MaxValue = stack[count - 1].MaxValue;
                else element.MaxValue = value;
                stack[count] = element;
                count++;
            }
        }
    }

    public int Pop()
    {
        if (count != 0)
        {
            count --;
            return stack[count].Value;
        }
        return -1;
    }

    public int GetMaxValue
        ()
    {
        return stack[count-1].MaxValue;
    }
}
