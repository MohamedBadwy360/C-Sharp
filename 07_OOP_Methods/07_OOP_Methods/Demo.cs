namespace _07_OOP_Methods
{
    // callee
    public class Demo
    {
        // Method Syntax: 
        // <access-modifier> <return-type> <method-name>(<parameters list>)
        // {
        //     <method-body> / series of statements
        // }

        public void DoSomething()
        {
            Console.WriteLine("Do Something......");
        }

        public int DoSomething2()
        {
            return 10;
        }

        // age is a parameter
        public void DoSomething3(int age)
        {
            Console.WriteLine($"Age: {age}");
        }

        // pass by value => age will be copied to a new memory location and the original value will not be changed
        public void DoSomething4(int age)
        {
            age = age + 3;
        }

        // pass by reference => age will be passed by reference and the original value will be changed but the variable must be initialized before passing it to the method
        public void DoSomething5(ref int age)
        {
            age = age + 3;
        }


        // pass by out => age will be passed by reference and the original value will be changed but the variable can be uninitialized before passing it to the method
        public void DoSomething6(out int age)
        {
            // should be initialized before using it in the method 
            age = 10;
            age = age + 3;
        }



        // Method Signature: Method Name + Parameter Type + Order of Parameters
        // Method Overloading: Same method name with different parameters (A common way of implementing Polymorphism)
        // Method Overriding: Same method name with same parameters in parent and child classes

        public void DoSomething7(int x, double y)   // Method Overloading
        {

        }

        public void DoSomething7(double y, int x)   // Method Overloading
        {

        }

        // local method => a method inside another method
        public void DoSomething8()
        {
            LocalMethod();

            void LocalMethod()
            {
                Console.WriteLine("Local Method");
            }
        }

        public void PrintIsEven(int[] nums)
        {
            foreach (var num in nums)
            {
                if (IsEven(num))
                {
                    Console.WriteLine($"{num} is even");
                }
            }

            // local method => a method inside another method => can't be accessed outside the method
            bool IsEven(int num)
            {
                return num % 2 == 0;
            }
        }


        // Expression Bodied Methods
        public int Add(int x, int y) => x + y;  // single line method body => no need for curly braces


        // Static Method => a method that belongs to the class and not to the object of the class
        // Static methods can be called without creating an object of the class 
        // Static methods can access static data members and can change the value of it but can't access non-static members 

        public static void DoSomething9()
        {
            Console.WriteLine("Do Something 9......");
        }
    }
}
