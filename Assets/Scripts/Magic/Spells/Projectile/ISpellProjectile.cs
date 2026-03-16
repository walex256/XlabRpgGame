using UnityEngine;

using System.Collections.Generic;



    public interface ISpellProjectile    
    {
        public void Initialize(Vector3 targetPosition, float speed, IReadOnlyList<IEffect> effects);


    }
