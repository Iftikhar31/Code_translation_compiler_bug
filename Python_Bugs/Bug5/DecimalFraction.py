>>> x = Fraction(1, 3)
>>> f"{x:_>010f}"
Traceback (most recent call last):
  File "<python-input-2>", line 1, in <module>
    f"{x:_>010f}"
      ^^^^^^^^^^
  File "/home/sk/src/cpython/Lib/fractions.py", line 600, in __format__
    raise ValueError(
    ...<2 lines>...
    )
ValueError: Invalid format specifier '_>010f' for object of type 'Fraction'
>>> f"{float(x):_>010f}"
'__0.333333'
