public class ExampleClass{
    public int MyProperty { get; set; }

    public void MyMethod() {
        int x = 5;
        //Error: Using unassigned local variable 'y'
        int y = x + z; 
        int z = 10;
    }
}