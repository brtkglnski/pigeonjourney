using UnityEngine;

public class CloudSpawnScript : MonoBehaviour
{

    public GameObject cloud;
    public float spawnRatec = 3;
    public float timerc = 0;
    public float heightOffsetc = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if (timerc < spawnRatec)
        {
            timerc += +Time.deltaTime;
        }
        else
        {
            spawnCloud();
            timerc = 0;
        }


    }
    void spawnCloud()
    {
        float lowestPoint = transform.position.y - heightOffsetc;
        float highestPoint = transform.position.y + heightOffsetc;

        Instantiate(cloud, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
