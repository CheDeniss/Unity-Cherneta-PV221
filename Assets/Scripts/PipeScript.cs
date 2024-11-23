using UnityEngine;

public class PipeScript : MonoBehaviour
{
    private float speed = 1.0f;
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(speed * Time.deltaTime * Vector2.left);
    }
}
