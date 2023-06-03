using UnityEngine;

public interface IHitable
{
   void Hit(float damage, Transform hitSource);
}
