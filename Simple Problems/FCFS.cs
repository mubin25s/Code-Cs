using System;
using System.Collections.Generic;

namespace SimpleProblems
{
	public class Process
	{
		public int Id;
		public int Arrival;
		public int Burst;
		public int Start;
		public int Completion;
		public int Waiting => Start - Arrival;
		public int Turnaround => Completion - Arrival;
	}

	public static class FCFS
	{
		public static void Run()
		{
			Console.WriteLine("FCFS Scheduling (First-Come First-Served)");

			int n;
			Console.Write("Enter number of processes: ");
			if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
			{
				Console.WriteLine("Invalid number. Exiting.");
				return;
			}

			var processes = new List<Process>(n);
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine($"Process #{i + 1}:");
				int at, bt;
				Console.Write("  Arrival time: ");
				while (!int.TryParse(Console.ReadLine(), out at) || at < 0)
					Console.Write("  Invalid. Enter non-negative integer for arrival: ");
				Console.Write("  Burst time: ");
				while (!int.TryParse(Console.ReadLine(), out bt) || bt <= 0)
					Console.Write("  Invalid. Enter positive integer for burst: ");

				processes.Add(new Process { Id = i + 1, Arrival = at, Burst = bt });
			}

			// FCFS: sort by arrival, then by Id to stabilize
			processes.Sort((a, b) => a.Arrival != b.Arrival ? a.Arrival.CompareTo(b.Arrival) : a.Id.CompareTo(b.Id));

			int currentTime = 0;
			foreach (var p in processes)
			{
				p.Start = Math.Max(currentTime, p.Arrival);
				p.Completion = p.Start + p.Burst;
				currentTime = p.Completion;
			}

			Console.WriteLine();
			Console.WriteLine("PID\tArrival\tBurst\tStart\tCompletion\tWaiting\tTurnaround");
			double totalWaiting = 0, totalTurnaround = 0;
			foreach (var p in processes)
			{
				Console.WriteLine($"P{p.Id}\t{p.Arrival}\t{p.Burst}\t{p.Start}\t{p.Completion}\t\t{p.Waiting}\t\t{p.Turnaround}");
				totalWaiting += p.Waiting;
				totalTurnaround += p.Turnaround;
			}

			Console.WriteLine();
			Console.WriteLine($"Average waiting time: {totalWaiting / n:F2}");
			Console.WriteLine($"Average turnaround time: {totalTurnaround / n:F2}");

			// Simple Gantt-like output
			Console.WriteLine();
			Console.WriteLine("Gantt chart:");
			// Print timeline markers
			foreach (var p in processes)
			{
				Console.Write($"|  P{p.Id}  ");
			}
			Console.WriteLine("|");
			// Print time markers
			foreach (var p in processes)
			{
				Console.Write($"{p.Start,3}     ");
			}
			Console.WriteLine(processes.Count > 0 ? $"{processes[processes.Count - 1].Completion,3}" : "0");
		}
	}
}

