/*Interface
Interface basic 
 We create interface using interface keyword. Just like classes interface also contains properties methods , delegates or events , but only declerations and no implementation 

It is a compile time error to provide implementation for any interface member 

Interface cannot contain fields 

If a class or a struct inherits from an interface , it must provide implementation for all interface member , otherwise ,we get compile error

A class or struct can inherit from more than one interface at the same time ,but where as a class cannot inherit from more than once class at the same time.

Interface can inherit from other interfaces . A class that inherits must provide implementation for all interface members in the entire interface inheritance chain.

We cannot create an instance of an interface , but an interface reference variable can point to derived class object.
Interface members public by default 
Int id; // interface cannot contains fields
Interface naming conversion : interface names are prefixed with capital I.
interface ICustomer 
{
void print ();
}
interface I2 {
Void I2method();
}


Class customer : ICustomer ,I2
{
public void print(){
Console.WriteLine (“interface print method);
}
Public void I2Method()
{
Console.WriteLine (“I2 Method”);
}
}
Public class Program 
{
Public static void Main ()
{
Customer c1 = new Customer ();
c1.Print();
}
}
// multiple class inheritance not possible 
Example 
Customer and sample both are classes 
Public class Program: customer ,sample

interface ICustomer 
{
void print ();
}
interface ICustomer2 : ICustomer 1{
Void print 2();
}


Class customer : ICustomer2
{
public void print(){
Console.WriteLine (“interface print method);
}
Public void print2()
{
Console.WriteLine (“print 2”);
}
}
Public class Program 
{
Public static void Main ()
{
ICustomer cust = new Customer ();
cust.Print();
}
}

Explicit interface implementation 

A class inherit from 2 interfaces and both the interfaces have the same method name. How should the class implement the method for both the interfaces ?
We are using explicit interface implementation technique to solve this problem.
 Access modifiers are not allowed on explicit implemented interface members.

interface I1 { void InterfaceMethod();}
Interface I2 { void InterfaceMethod();}
Public class Program{
Void I1. InterfaceMethod(){ 
Console.WriteLine (“I1 Interface”);
}
Void I2. InterfaceMethod(){ 
Console.WriteLine (“I2 Interface”);
}
Public static void main()
{
Program P = new Program ();
((I1)P ).InterfaceMethod ();
((I2)P ).InterfaceMethod ();
}
}

Abstract classes

The abstract keyword is used to create abstract classes 


An abstract class can only be used as base class 

An abstract class cannot be sealed.
An abstract class may contain abstract members ( methods , properties, indexers, and events) , but not mandatory.

A non abstract class derived from an abstract class must provide implementation for all inherited abstract members.

If a class inherit an abstract class, there are 2 options available for that class 
Option 1 : provide implementation for all the abstract members inherited from the base abstract class 
Option 2 : if the class does not wish to provide implementation for all the abstract members inherited from the abstract class , then the class has to be marked as abstract.

abstract class customer {
Public abstract void print ();
}
Public class program : customer 
{
Public override void print () {
Console.WriteLine ( “abstract class member “);
}
Public static void main () {
Customer  c= New Program ():
c.print();
}
}
Abstract class Vs Interfaces 

About the difference between abstract classes and interfaces 

Abstract classes can have implementations for some of it’s members (Methods) but the interface cannot have implementation for any of it’s members 

 Interface cannot have fields where as abstract class can have fields 

An interface can inherit from another interface only and cannot inherit from an abstract class , where as an abstract class can inherit from another abstract class or other interface 

A class can inherit from multiple interfaces the same time , where as a class cannot inherit from multiple classes at the same time.

Abstract class members can have access modifiers where as interface members cannot have access modifiers 

 Abstract class members private by default */



