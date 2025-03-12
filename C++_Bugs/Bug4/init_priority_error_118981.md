This test case causes GCC 15.0.1 to quit at compiling the second occurrence
of "[[gnu::init_priority(99)]" with message:
{standard input}:131506: Error: symbol `_GLOBAL__sub_I.00099_tzdb.cc' is already defined. For more information, please refer https://gcc.gnu.org/bugzilla/show_bug.cgi?id=118981
