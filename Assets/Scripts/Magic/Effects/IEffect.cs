using UnityEngine;

public interface IEffect 
{
    public void Apply(IEffectable efffectable);
}

public interface IEffectable { }
