using UnityEngine;

public interface IBuff 
{
    public string Id { get; }
    public void Initialize();
    public void Deinitialize();
}
