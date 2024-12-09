public class MyClass
{
    public int MyProperty { get; set; } = 0; // Initialize the property with a default value

    public void MyMethod()
    {
        // Initialize the property before using it.
        int value = this.MyProperty * 2;
    }
}
// Or use a constructor to set value:
public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int myProperty)
    {
        MyProperty = myProperty;
    }

    public void MyMethod()
    {
        int value = this.MyProperty * 2;
    }
} 