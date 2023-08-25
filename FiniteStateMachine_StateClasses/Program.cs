namespace FiniteStateMachine_StateClasses;

interface IState
{
	void Enter();
	void Update();
	void Exit();
}

class IdleState : IState
{
	public void Enter() => Console.WriteLine("Entering Idle state");
	public void Update() => Console.WriteLine("Idle state updating");
	public void Exit() => Console.WriteLine("Exiting Idle state");
}

class RunningState : IState
{
	public void Enter() => Console.WriteLine("Entering Running state");
	public void Update() => Console.WriteLine("Running state updating");
	public void Exit() => Console.WriteLine("Exiting Running state");
}

class StoppedState : IState
{
	public void Enter() => Console.WriteLine("Entering Stopped state");
	public void Update() => Console.WriteLine("Stopped state updating");
	public void Exit() => Console.WriteLine("Exiting Stopped state");
}

class StateMachine
{
	private IState currentState;

	public void Update() => currentState.Update();
	
	public StateMachine()
	{
		currentState = new IdleState();
		currentState.Enter();
	}

	public void ChangeState(IState newState)
	{
		currentState.Exit();
		currentState = newState;
		currentState.Enter();
	}
}

internal static class Program {
	
	public static void Main()
	{
		var stateMachine = new StateMachine();

		while (true)
		{
			stateMachine.Update();
			
			Thread.Sleep(1000);
		}
	}
}