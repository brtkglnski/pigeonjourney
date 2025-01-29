using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class CloudSpawnerScript2 : MonoBehaviour
{
    public float moveSpeed = 10;
public float deadZone = -30;
// Start is called once before the first execution of Update after the MonoBehaviour is created
void Start()
{

}

// Update is called once per frame
void Update()
{
    transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

    if (transform.position.x < deadZone)
    {
        Destroy(gameObject);
    }
}
}