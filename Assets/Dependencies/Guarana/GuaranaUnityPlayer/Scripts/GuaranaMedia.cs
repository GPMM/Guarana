using UnityEngine;

public abstract class GuaranaMedia : MonoBehaviour
{
    protected virtual bool IsPrepared { get; }

    protected virtual void Prepare() { }
    
    protected virtual void Load() { }

    protected virtual void Show() { }
}