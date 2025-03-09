MyStruct? myStruct = await GetStructAsync();
MyStruct s1 = myStruct.Value;

static async Task<MyStruct?> GetStructAsync()
{
    await Task.Yield();
    return new MyStruct();
}

struct MyStruct { }
