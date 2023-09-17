```

BenchmarkDotNet v0.13.8, Windows 11 (10.0.22621.2283/22H2/2022Update/SunValley2)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 7.0.306
  [Host]             : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  .NET 7.0           : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  .NET Framework 4.8 : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256


```
| Method                   | Job                | Runtime            | Character | Mean        | Error     | StdDev    | Ratio | RatioSD |
|------------------------- |------------------- |------------------- |---------- |------------:|----------:|----------:|------:|--------:|
| **VerifyStringContains**     | **.NET 7.0**           | **.NET 7.0**           | **$**         |   **2.1518 ns** | **0.0352 ns** | **0.0312 ns** |  **0.33** |    **0.01** |
| VerifyArrayContains      | .NET 7.0           | .NET 7.0           | $         |   6.6131 ns | 0.1094 ns | 0.1023 ns |  1.00 |    0.00 |
| VerifyCharBoolMap        | .NET 7.0           | .NET 7.0           | $         |   0.3680 ns | 0.0155 ns | 0.0145 ns |  0.06 |    0.00 |
| VerifyCharBoolMapBitwise | .NET 7.0           | .NET 7.0           | $         |   0.6315 ns | 0.0190 ns | 0.0178 ns |  0.10 |    0.00 |
|                          |                    |                    |           |             |           |           |       |         |
| VerifyStringContains     | .NET Framework 4.8 | .NET Framework 4.8 | $         |  46.7848 ns | 0.8907 ns | 0.8332 ns |  1.54 |    0.03 |
| VerifyArrayContains      | .NET Framework 4.8 | .NET Framework 4.8 | $         |  30.4361 ns | 0.6216 ns | 0.6105 ns |  1.00 |    0.00 |
| VerifyCharBoolMap        | .NET Framework 4.8 | .NET Framework 4.8 | $         |   0.3627 ns | 0.0202 ns | 0.0189 ns |  0.01 |    0.00 |
| VerifyCharBoolMapBitwise | .NET Framework 4.8 | .NET Framework 4.8 | $         |   0.8048 ns | 0.0169 ns | 0.0158 ns |  0.03 |    0.00 |
|                          |                    |                    |           |             |           |           |       |         |
| **VerifyStringContains**     | **.NET 7.0**           | **.NET 7.0**           | **/**         |   **2.0890 ns** | **0.0553 ns** | **0.0517 ns** |  **0.39** |    **0.01** |
| VerifyArrayContains      | .NET 7.0           | .NET 7.0           | /         |   5.3055 ns | 0.0728 ns | 0.0681 ns |  1.00 |    0.00 |
| VerifyCharBoolMap        | .NET 7.0           | .NET 7.0           | /         |   0.3560 ns | 0.0091 ns | 0.0081 ns |  0.07 |    0.00 |
| VerifyCharBoolMapBitwise | .NET 7.0           | .NET 7.0           | /         |   0.6243 ns | 0.0120 ns | 0.0100 ns |  0.12 |    0.00 |
|                          |                    |                    |           |             |           |           |       |         |
| VerifyStringContains     | .NET Framework 4.8 | .NET Framework 4.8 | /         | 104.4266 ns | 0.8385 ns | 0.7433 ns | 2.964 |    0.04 |
| VerifyArrayContains      | .NET Framework 4.8 | .NET Framework 4.8 | /         |  35.1944 ns | 0.3159 ns | 0.2955 ns | 1.000 |    0.00 |
| VerifyCharBoolMap        | .NET Framework 4.8 | .NET Framework 4.8 | /         |   0.3412 ns | 0.0076 ns | 0.0067 ns | 0.010 |    0.00 |
| VerifyCharBoolMapBitwise | .NET Framework 4.8 | .NET Framework 4.8 | /         |   0.7879 ns | 0.0141 ns | 0.0125 ns | 0.022 |    0.00 |
|                          |                    |                    |           |             |           |           |       |         |
| **VerifyStringContains**     | **.NET 7.0**           | **.NET 7.0**           | **5**         |   **1.2425 ns** | **0.0081 ns** | **0.0068 ns** |  **1.01** |    **0.02** |
| VerifyArrayContains      | .NET 7.0           | .NET 7.0           | 5         |   1.2313 ns | 0.0175 ns | 0.0163 ns |  1.00 |    0.00 |
| VerifyCharBoolMap        | .NET 7.0           | .NET 7.0           | 5         |   0.3474 ns | 0.0107 ns | 0.0100 ns |  0.28 |    0.01 |
| VerifyCharBoolMapBitwise | .NET 7.0           | .NET 7.0           | 5         |   0.5867 ns | 0.0114 ns | 0.0106 ns |  0.48 |    0.01 |
|                          |                    |                    |           |             |           |           |       |         |
| VerifyStringContains     | .NET Framework 4.8 | .NET Framework 4.8 | 5         |   1.2433 ns | 0.0249 ns | 0.0220 ns |  0.89 |    0.02 |
| VerifyArrayContains      | .NET Framework 4.8 | .NET Framework 4.8 | 5         |   1.4058 ns | 0.0218 ns | 0.0204 ns |  1.00 |    0.00 |
| VerifyCharBoolMap        | .NET Framework 4.8 | .NET Framework 4.8 | 5         |   0.3465 ns | 0.0155 ns | 0.0145 ns |  0.25 |    0.01 |
| VerifyCharBoolMapBitwise | .NET Framework 4.8 | .NET Framework 4.8 | 5         |   0.7870 ns | 0.0131 ns | 0.0116 ns |  0.56 |    0.01 |
|                          |                    |                    |           |             |           |           |       |         |
| **VerifyStringContains**     | **.NET 7.0**           | **.NET 7.0**           | **a**         |   **0.5741 ns** | **0.0098 ns** | **0.0087 ns** |  **0.82** |    **0.02** |
| VerifyArrayContains      | .NET 7.0           | .NET 7.0           | a         |   0.6978 ns | 0.0145 ns | 0.0136 ns |  1.00 |    0.00 |
| VerifyCharBoolMap        | .NET 7.0           | .NET 7.0           | a         |   0.3478 ns | 0.0094 ns | 0.0088 ns |  0.50 |    0.01 |
| VerifyCharBoolMapBitwise | .NET 7.0           | .NET 7.0           | a         |   0.6257 ns | 0.0141 ns | 0.0131 ns |  0.90 |    0.02 |
|                          |                    |                    |           |             |           |           |       |         |
| VerifyStringContains     | .NET Framework 4.8 | .NET Framework 4.8 | a         |   0.7846 ns | 0.0105 ns | 0.0098 ns |  0.98 |    0.02 |
| VerifyArrayContains      | .NET Framework 4.8 | .NET Framework 4.8 | a         |   0.8008 ns | 0.0161 ns | 0.0151 ns |  1.00 |    0.00 |
| VerifyCharBoolMap        | .NET Framework 4.8 | .NET Framework 4.8 | a         |   0.3437 ns | 0.0078 ns | 0.0073 ns |  0.43 |    0.01 |
| VerifyCharBoolMapBitwise | .NET Framework 4.8 | .NET Framework 4.8 | a         |   0.7831 ns | 0.0072 ns | 0.0067 ns |  0.98 |    0.02 |
