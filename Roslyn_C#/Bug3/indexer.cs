using System.Runtime.CompilerServices;

partial struct S1
{
    public partial int this[int x] {get=>x;}

    [IndexerName("MyName")]
    public partial int this[int x] {get;}
}
