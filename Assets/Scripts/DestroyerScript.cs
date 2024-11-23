using Unity.VisualScripting;
using UnityEngine;

public class DestroyerScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Transform pt = collision.gameObject.transform.parent;
        GameObject.Destroy(collision.gameObject);
        if (pt != null )
        {
            GameObject.Destroy(pt);
        }
    }
}
