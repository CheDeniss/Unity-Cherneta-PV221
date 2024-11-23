using UnityEngine;

public class SpawnerScript : MonoBehaviour
{

    [SerializeField]
    private GameObject pipePrefab;
    private float pipeSpawnePeriod = 4.0f;
    private float pipeTimeout;

    void Start()
    {
        pipeTimeout = pipeSpawnePeriod;
    }

    // Update is called once per frame
    void Update()
    {
        pipeTimeout -= Time.deltaTime;
        if (pipeTimeout <= 0.0f )
        {
            SpawnPipe();
            pipeTimeout = pipeSpawnePeriod;
        }
    }

    private void SpawnPipe()
    {
        GameObject pipe = GameObject.Instantiate( pipePrefab );
        pipe.transform.position = this.transform.position;
    }
        

}
