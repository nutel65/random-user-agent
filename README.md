Credits to https://github.com/csharp-leaf/Leaf.xNet - I took the code from there, removed anything else besides user agent randomizer. I also updated some of the code to generate user agents that look more recent (the original code generated the strings that look 5 year old).

## Linux
compiles with `csc` compiler on linux:
```bash
$ csc RandomUserAgent.cs
$ wine RandomUserAgent.exe
0100:fixme:ntdll:NtQuerySystemInformation info_class SYSTEM_PERFORMANCE_INFORMATION # Can't remove this line though
Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.2358.122 Safari/537.36% 
```
