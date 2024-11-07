namespace _27._2_Mængder;

public interface INondestructiveSet<T>
{

	public INondestructiveSet<T> Intersection(INondestructiveSet<T> nondestructiveSet);
	public INondestructiveSet<T> Union(INondestructiveSet<T> nondestructiveSet);
	public INondestructiveSet<T> Difference(INondestructiveSet<T> nondestructiveSet);
	public bool IsDisjoint(INondestructiveSet<T> nondestructiveSet);
	public bool IsSubset(INondestructiveSet<T> nondestructiveSet);


}