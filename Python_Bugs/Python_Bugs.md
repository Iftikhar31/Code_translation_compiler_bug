# Python Bugs
### Local frame not working with global when there is collision
https://github.com/python/cpython/issues/130809

C# translator does not translate the problem correctly

C++ translator does not translate the problem correctly

Java translator does not translate the problem correctly

Rust translator does not translate the problem correctly

### Order of conditionals not correct after compilation 
https://github.com/python/cpython/issues/122821

Impossible to translate, this is an error with the representation of the code after translation. All other representations look vastly different and do not have the same problem. 
### TRACEBACK
https://github.com/python/cpython/issues/118978

Should display traceback rather than just overflow. 

C# broken, only says stack overflow. Different on OneCompiler vs Godbolt.

C++ broken, only says timeout 

Java works

Rust recursion is not supported

### Truncation on encoding
https://github.com/python/cpython/issues/101828

Randomly truncates on specific encodings when appending

C# cannot translate encoding

C++ does not have this bug

Java does not have this bug 

Rust cannot translate encoding

### destroy_gil() is not called over multiple Py_Initialize() / Py_Finalize() calls
https://github.com/python/cpython/issues/104324

Cannot be reproduced, method only exists in python. 
