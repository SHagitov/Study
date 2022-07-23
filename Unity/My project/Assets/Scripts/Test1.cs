using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    public Transform objToFollow;
    private Vector3 deltaPos;

    void Start()
    {
        deltaPos = transform.position - objToFollow.position;
    }

    void Update()
    {
        transform.position = objToFollow.position + deltaPos;
    }
}
