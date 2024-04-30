using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    [SerializeField] Vector3 offset = new Vector3(10,2,0);
    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
