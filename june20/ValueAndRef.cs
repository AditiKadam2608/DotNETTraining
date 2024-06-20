using System;

class ValueAndRef
{
    static void Main()
    {
        // Value type example
        int valueTypeVar = 10;
        Console.WriteLine("Value Type Example:");
        Console.WriteLine("Before method call: " + valueTypeVar);
        ChangeValueType(valueTypeVar);
        Console.WriteLine("After method call: " + valueTypeVar);

        // Reference type example
        Person referenceTypeVar = new Person { Name = "John" };
        Console.WriteLine("\nReference Type Example:");
        Console.WriteLine("Before method call: " + referenceTypeVar.Name);
        ChangeReferenceType(referenceTypeVar);
        Console.WriteLine("After method call: " + referenceTypeVar.Name);
    }

    static void ChangeValueType(int value)
    {
        value = 20;
    }

    static void ChangeReferenceType(Person p)
    {
        p.Name = "Doe";
    }

    
}

class Person
{
    public string Name { get; set; }
}
