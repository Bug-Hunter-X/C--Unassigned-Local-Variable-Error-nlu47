public class ExampleClass{
    public int MyProperty { get; set; }

    public void MyMethod() {
        int x = 5;
        int z = 10; // Assign z before using it
        int y = x + z; 
    }
}