enum State
{
	Idle,
	Running,
	Stopped
}

static class Program
{
	public static void Main(string[] args)
	{
		var currentState = State.Idle;

		while (true)
		{
			Console.WriteLine($"Current state: {currentState}");

			if (currentState == State.Idle)
				currentState = State.Running;
			else if (currentState == State.Running)
				currentState = State.Stopped;
			else if (currentState == State.Stopped)
				currentState = State.Idle;
			
			Thread.Sleep(1000);
		}
	}
}