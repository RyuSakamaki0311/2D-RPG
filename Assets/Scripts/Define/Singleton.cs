using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private Singleton() { }
    public static T Instanfce { get; private set; }
    public static bool IsValid => Instanfce != null;
}
