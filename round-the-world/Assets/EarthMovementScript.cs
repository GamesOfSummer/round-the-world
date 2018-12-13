using System.Collections;
using UnityEngine;

public class EarthMovementScript : MonoBehaviour
{
    float timeCounter = 0;
    float radiusDistance = 0;

    private void Start()
    {
        InvokeRepeating("ChangeRadius", 1.0F, 1.0F);
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += radiusDistance * Time.deltaTime;
        float x = Mathf.Cos(timeCounter);
        float y = Mathf.Sin(timeCounter);
        float z = 0;
        transform.position = new Vector3(x, y, z);
    }

    void ChangeRadius()
    {
        radiusDistance = Random.Range(1, 10);
    }

}
