# Python Bugs
### Local frame not working with global when there is collision
https://github.com/python/cpython/issues/130809

This bug is a bug to do with “PyFrame_LocalsToFast”. There is a collision error when colliding with a local variable, removing both Pyframe and local variables. This error comes from the implementation of PyFrame which is an error with how the PyFrame is implemented. This is not necessarily a compilation error, it could be a language error. This bug cannot be translated to all the other languages because PyFrame_LocalsToFast does not have an equivalent in the other languages, or at least not one that the AI can convert correctly. Therefor, this bug is untestable with the current AI model we are using, and might even not exist in other languages. 
C# translator does not translate the problem correctly

C++ translator does not translate the problem correctly

Java translator does not translate the problem correctly

Rust translator does not translate the problem correctly

### Order of conditionals not correct after compilation 
https://github.com/python/cpython/issues/122821

This is an error with the translation of a while loop. There is an inconsistency in the location of the while loop in the iterations. This is definitely a compiler error, the compiler is translating this to machine code weirdly. We can see this problem in godbolt. The code is translated correctly into all the other languages, but the error is not replicated. Each language translates code very differently, therefore machine code equivalencies are very rare if not impossible. 
### TRACEBACK
https://github.com/python/cpython/issues/118978

This a bug for an older version of python where the traceback is lost if the stack gets too big on recursion. This bug is reflected in C++ and C#, but not Java. Something to note that while it does translate to C++, C# and Java, it is not replicable in Rust. Rust does not support recursion well and so this problem is completely untranslatable to Rust. This is the perfect example for our database. It is an error that exists in python, and when translated, C++ and C# also displays this bug. This shows that cross language bugs definitely do exist. This might not necessarily be a “compiler” bug but this proves that our method does catch bugs. 

C# broken, only says stack overflow. Different on OneCompiler vs Godbolt.

C++ broken, only says timeout 

Java works

Rust recursion is not supported

### Truncation on encoding
https://github.com/python/cpython/issues/101828

This problem happens when you try to use the shift_jfix encoding in Python. This is a language specific encoding that is not the same in C++ or C#. Therefore it is not possible to translate this encoding into C# or C++ with the code translator. It is possible that there is a correct encoding equivalent in those languages and that the AI does not know it. The problem is translatable to Java, but the error does not exist there.

C# cannot translate encoding

C++ does not have this bug

Java does not have this bug 

Rust cannot translate encoding

### destroy_gil() is not called over multiple Py_Initialize() / Py_Finalize() calls
https://github.com/python/cpython/issues/104324

This problem is not translatable, and not only that, it requires a lot of specific domain knowledge that I do not have about python. Many bugs are like this with multi-threading where we do not have the domain knowledge applicable to even understand the bug. It is possible with extensive research into the language we can understand, but we cannot in good conscience say there is even a bug if we do not understand it. Even if we do translate, destroy_gil is not translatable to other languages. 

Cannot be reproduced, method only exists in python. 
