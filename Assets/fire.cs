using UnityEngine;

public class fire : MonoBehaviour
{
    public void Extinguish()
    {
        Debug.Log("Fire extinguished");
        Destroy(gameObject);
    }
}
