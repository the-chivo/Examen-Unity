using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Camerascript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject target1;
    [SerializeField] GameObject target2;
    [SerializeField] float smoothTime;
    Vector3 velocity = Vector3.zero;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 midpoint = (target1.transform.position + target2.transform.position) / 2f;
        midpoint.z = transform.position.z;
        transform.position = Vector3.SmoothDamp(transform.position, midpoint, ref velocity, smoothTime);
    }
}
