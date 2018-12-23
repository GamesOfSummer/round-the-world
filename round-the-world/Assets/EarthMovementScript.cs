using UnityEngine;

public class EarthMovementScript : MonoBehaviour
{
    float timeCounter = 0;
    float radiusDistance = 0;

    float RotateSpeed = 3.0F;
    float _angle = 3.0F;

    private void Start()
    {
        InvokeRepeating("ChangeRadius", 1.0F, 1.0F);
    }

    // Update is called once per frame
    void Update()
    {
        _angle += RotateSpeed * Time.deltaTime;
        transform.position = new Vector2(Mathf.Sin(_angle), Mathf.Cos(_angle)) * radiusDistance;
    }

    void ChangeRadius()
    {
        radiusDistance = Random.Range(1, 5);
    }

}
