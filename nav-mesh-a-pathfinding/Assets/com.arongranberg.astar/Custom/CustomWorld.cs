using Unity.Entities;

public class CustomWorld
{
	protected static World _world;
	public static World World => _world ?? World.DefaultGameObjectInjectionWorld;
}
