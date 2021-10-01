# Question 1
The question has compilation error because 'Int' is not valid type. 
After fixing type by converting it to Int32, the assertion fails because object is a reference type and variable 'a' and variable 'b' does not have same memory address (pointer).

# Question 2
The answer is provided below

### MyData Class Declaration

```CSharp
public class MyData
{
    public int MyInt;
    public string MyString;

    public override string ToString()
    {
        return $"MyInt = {MyInt}, MyString = {MyString}";
    }
}
```

### Implementation
```CSharp
private static void Question2()
{
    IList<MyData> lst = new List<MyData> {
        new MyData{MyInt = 1, MyString = "John 5"} ,
        new MyData{MyInt = 5, MyString = "John 1"} ,
        new MyData{MyInt = 2, MyString = "Jack 1"} ,
        new MyData{MyInt = 9, MyString = "Annie "} ,
        new MyData{MyInt = 5, MyString = "Brad"} ,
    };

    Console.WriteLine("Order by MyInt");
    lst.OrderBy(t => t.MyInt).ToList().ForEach(Console.WriteLine);

    Console.WriteLine();
    Console.WriteLine("Order by MyString");
    lst.OrderBy(t => t.MyString).ToList().ForEach(Console.WriteLine);

}
```

# Question 3
The answer is provided below

```CSharp
private static long Question3(long n)
{
    List<long> res = new List<long>();

    if (n < 10)
    {
        return n;
    }

    // Case 2: Start with 9 and
    // try every possible digit
    for (long i = Math.Min(9, n); i > 1; i--)
    {
        while (n % i == 0)
        {
            n = n / i;
            res.Insert(0, i);
        }
    }

    // If n could not be broken
    // in form of digits (prime factors
    // of n are greater than 9)
    if (n > 10)
    {
        return -1;
    }

    // multiply the array of values
    var smallestNum = res.Aggregate("", (a, b) => a.ToString() + b.ToString());

    return long.Parse(smallestNum);
}
```

# Question 4

Most important differences between interfaces and abstract classes are:
- Interfaces can only have abstracy methods, whereas abstract classes can have abstract and non-abstract methods.
- interfaces can be inherited multiple times, whereas abstract classes can be inherited only once
- interfaces cannot have implementation, whereas abstract class can have.
- Interfaces cannot extend classes, wherease abstract class can extend class.
- Interfaces cannot be inherited by abstract classes

I use abstract classes when I need base implementation for the inherited classes.  Otherwise, I use interfaces for abstraction.

# Question 5

The built-in equality operators (`Equals`, `operator==`, `operator!=`) on reference types implements reference equality. Overwriting them allow us to compare object by its fields/properties.

We override these methods when we want to compare object with one or more fields rather then its memory location (pointer). 

`operator==`, `operator!=`, Equals gives object/struct types a primitive feeling

**`GetHashCode()` `Equals()`**

`GetHashCode` is needed to be overriden when we use `HashTable`/`Dictionary` types. `GetHashCode` method allows a type to work correctly in hash table

`Obj1.GetHashCode() == Obj2.GetHashCode() => true` does not mean that both objects are same. In such scenario, `Equals()` function will be called to see if the objects are equal.

# Question 6
I use abstract class when I need base implementation for my class, and the base implementation by itself must not be initialized but used in subclass implementations.

I use struct when I need value semantics (value types). For example, if I need special Money type, I use Struct because It is actually a value for me. I don't want it to be represented by reference types. Value types avoid heap allocation and garbage collection overheads.

I use static classes when I need a functionality which is not associated with an object. Most common example is Console.WriteLine, which is not associated with any object. Static members and their values belong to the type itself, rather than the object.

# Question 7
Although the code is valid, Delegate types cannot have return type. They are always void.

`public delegate bool MyDelegate();` needs to be `public delegate void MyDelegate();`

### ** Delegate **
A Delegate is an abstraction of one or more function pointers. The .NET has implemented the function pointers in the form of delegates. 
Delegate's adds type safety to functions/callbacks. We can pass functions as parameters with Delegates

### ** Event **
We can subscribe / unsubscribe to delegate functions with events.
Events are dependent on delegates and cannot be created without delegates. see `public event MyDelegate MyEvent`. 

### Difference
- Delegates can use = operator for assigning single method, or += operator for assigning multiple methods
- Events can only use += operator for subscription, -= for unsubscription
- Events wraps delegates, therefore event depends on delegates.
- Delegate is a function pointer, whereas event is a notification mechanism.

Here is the complete code for event handling & subscription

### Class and Delegate Declaration
```CSharp
public delegate void MyDelegate(string e);
public class MyClass
{
    public event MyDelegate MyEvent;

    public void TriggerEvent(string s)
    {
        MyEvent.Invoke(s);
    }
}
```

### Implementation
```CSharp
MyClass mc = new MyClass();
mc.MyEvent += (string e) =>
{
    Console.WriteLine(e);
};

mc.TriggerEvent("this returns true");
```

# Question 8
`lock` is shortcut of Monitor. when we have multi-threaded application which uses same variables, we use lock (Monitor) to syncronize thread access to that variable(s). Only one thread can lock the synchronizing object at the same time.
Mutex is like a C# lock, but it can work **across multiple processes**. Mutex is about **50 times slower** then lock

# Question 9
The answer is provided below

```CSharp
public class ThreadSafeSingleton
{
    private static object _myLock = new object();
    private static ThreadSafeSingleton _singleton = null;

    private ThreadSafeSingleton() { }

    public static ThreadSafeSingleton GetInstance()
    {
        if (_singleton is null) 
        {
            lock (_myLock)
            {
                if (_singleton is null) 
                {
                    _singleton = new ThreadSafeSingleton();
                }
            }
        }

        return _singleton;
    }
}
```


# Question 10

Please see the attached solution. Please use `dotnet run ` to run application