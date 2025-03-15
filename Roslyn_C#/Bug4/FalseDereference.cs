var d = new Derived { Foo = new object() };

_ = (object)d switch
{
    Derived { Foo: 4 } => 0,
    // ⚠️ CS8602 Dereference of a possibly null reference.
    //                     ↓
    Base { Foo: { } f } => f.GetHashCode(),
    _ => 0,
};

public class Base
{
    public object? Foo { get; set; }
}

public class Derived : Base;
