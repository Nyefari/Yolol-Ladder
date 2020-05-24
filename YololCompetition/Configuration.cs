﻿using CommandLine;

#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.

namespace YololCompetition
{
    public class Configuration
    {
        [Option('t', "token-var", Required = true, HelpText = "Environment var the token is stored in")]
        public string TokenEnvVar { get; set; }

        [Option('p', "prefix", Required = true, HelpText = "Prefix Character")]
        public char Prefix { get; set; }

        [Option('d', "db", Required = true, HelpText = "Database Connection String")]
        public string DatabaseConnectionString { get; set; }

        [Option("duration", Required = false, HelpText = "How long each challenge should last in hours", Default = (uint)72)]
        public uint ChallengeDurationHours { get; set; }

        [Option("test_iters", Required = false, HelpText = "Set max lines executed per test case", Default = (uint)1000)]
        public uint MaxTestIters { get; set; }

        [Option("test_iters_overflow", Required = false, HelpText = "How many extra iters (across all tests) may be used", Default = (uint)10000)]
        public uint MaxItersOverflow { get; set; }
    }
}
