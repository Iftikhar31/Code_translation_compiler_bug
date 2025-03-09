#nullable enable

Int32 i;
C? c = null;

if (c is not null)
{
    c = c.NoTuple();    // No warning (as expected)
}

if (c is not null)
{
    (c, i) = c.Tuple(); // Unexpected CS8602 warning on 'c'
}

class C
{
    public C? NoTuple() => throw new NotImplementedException();

    public (C?, Int32) Tuple() => throw new NotImplementedException();
}
