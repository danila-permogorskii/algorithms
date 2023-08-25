namespace FiniteStateMachine_Hierarchical;

enum State
{
	Idle,
	Walking,
	Running,
	Jumping
}

internal static class Program
{
	public static void Main()
	{
		var transitions = new Dictionary<State, List<State>>
		{
			{ State.Idle, new() { State.Walking, State.Running, State.Jumping } },
			{ State.Walking, new() { State.Idle, State.Running } },
			{ State.Running, new() { State.Idle, State.Walking, State.Jumping } },
			{ State.Jumping, new() { State.Idle } },
		};

		var currentState = State.Idle;

		while(true)
		{
			Console.WriteLine($"Current state: {currentState}");

			var possibleTransitions = transitions[currentState];
			var randomIndex = new Random().Next(possibleTransitions.Count);
			currentState = possibleTransitions[randomIndex];
			
			Thread.Sleep(1000);
		}
	}
}