using Unity.Entities;

public class CustomWorld
{
	protected static World WorldVar;
	public static World World => WorldVar ?? World.DefaultGameObjectInjectionWorld;
}
