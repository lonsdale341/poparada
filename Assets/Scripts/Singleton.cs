public class Singleton<T> where T : class, new()
{
	protected virtual void OnConstruct()
	{

	}

	protected Singleton() 
	{ 
		OnConstruct(); 
	}

	private static readonly T instance = new T();

	public static T Instance
	{ 
		get 
		{ 
			return instance; 
		}
	}
}