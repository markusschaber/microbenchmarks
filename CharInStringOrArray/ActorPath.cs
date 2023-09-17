// This contains some code derived from Akka.NET, and thus is licensed under Apache 2.0 license
// as long as it's complex enough that copyright even applies.
//-----------------------------------------------------------------------
// <copyright file="ActorPath.cs" company="Akka.NET Project">
//     Copyright (C) 2009-2023 Lightbend Inc. <http://www.lightbend.com>
//     Copyright (C) 2013-2023 .NET Foundation <https://github.com/akkadotnet/akka.net>
//     Copyright (C) 2023 Markus Schaber <https://github.com/markusschaber/>
// </copyright>
//-----------------------------------------------------------------------

using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace CharInStringOrArray
{
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.Net70)]
    public class ActorPath
    {

        /// <summary>
        /// INTERNAL API
        /// </summary>
        internal const string ValidSymbolString = "\"-_.*$+:@&=,!~';()";
        /// <summary>
        /// INTERNAL API
        /// </summary>
        internal static readonly char[] ValidSymbolArray = ValidSymbolString.ToCharArray();

        [Params('a', '5', '$', '/')]
        public char Character;

        private static readonly bool[] ValidAscii = Enumerable.Range(0, 128).Select(i => IsValidCharStringContains((char)i))
            .ToArray();

        private static bool IsValidCharStringContains(char c) => (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') ||
                                                                 (c >= '0' && c <= '9') || ValidSymbolString.Contains(c);

        private static bool IsValidCharArrayContains(char c) => (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') ||
                                                                (c >= '0' && c <= '9') || ValidSymbolArray.Contains(c);
        private static bool IsValidCharBoolMap(char c) => c < 128 && ValidAscii[c];

        private static bool IsValidCharBoolMapBitwise(char c) => (c & 0xFFF8) == 0 && ValidAscii[c];

        [Benchmark]
        public bool VerifyStringContains() => IsValidCharStringContains(Character);

        [Benchmark(Baseline = true)]
        public bool VerifyArrayContains() => IsValidCharArrayContains(Character);

        [Benchmark]
        public bool VerifyCharBoolMap() => IsValidCharBoolMap(Character);

        [Benchmark]
        public bool VerifyCharBoolMapBitwise() => IsValidCharBoolMapBitwise(Character);
    }
}
