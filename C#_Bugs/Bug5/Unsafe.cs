unsafe record Base
{
    public Base(int* x, int* y) {}
}

unsafe record C1(int x, S s) : Base(&x, &s.f)
{
    public int x = default;
    public S s = default;
}

struct S
{
    public int f;    
}
