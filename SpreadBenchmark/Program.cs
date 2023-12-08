//int[] curly1 = { };
//int[] curly2 = { };
//int[] new1 = new int[0];
//int[] new2 = new int[0];
//int[] empty1 = Array.Empty<int>();
//int[] empty2 = Array.Empty<int>();
//int[] square1 = [];
//int[] square2 = [];

//Console.WriteLine(curly1 == curly2);
//Console.WriteLine(new1 == new2);
//Console.WriteLine(empty1 == empty2);
//Console.WriteLine(square1 == square2);
//Console.WriteLine(square1 == empty1);

//string sempty1 = string.Empty;
//string sempty2 = string.Empty;
//string blank1 = "";
//string blank2 = "";

//Console.WriteLine(ReferenceEquals(sempty1, sempty2));
//Console.WriteLine(ReferenceEquals(blank1, blank2));
//Console.WriteLine(ReferenceEquals(sempty1, blank2));

//int[] a1 = [1, 2, 3, 4, 5];

//int[] a2 = [.. a1];

//a2[2] = 500;

//Console.WriteLine(a1[2]);

using BenchmarkDotNet.Running;
using SpreadBenchmark;

BenchmarkRunner.Run<Tests>();