
strings: list[str] = [
    "hello world",
    "バルーンフルーツ",
    "バルーンフィッシュ",
    "ライフアップキノコ"
]

encoding = "shift_jisx0213"

for string in strings:
    encoded_direct_null = (string + "\0").encode(encoding)
    encoded_append_null = string.encode(encoding) + "\0".encode(encoding)

    print(repr(string))
    print(" - encoded_append_null (EXPECTED!):", encoded_append_null.hex())
    print(" - encoded_direct_null:            ", encoded_direct_null.hex())
    print()
