using UnityEngine;

public abstract class AbstractProduct<TProduct> : MonoBehaviour
{
    public abstract void Initialize(TProduct product);
}