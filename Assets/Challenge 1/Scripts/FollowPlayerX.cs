using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    public GameObject proPeller;
    public float spin;
    private Vector3 offset = new Vector3(15, 5, 0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
        proPeller.transform.Rotate(new Vector3(0, 0, 1) * spin);
    }
}
