using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limitsScripts : MonoBehaviour
{
    [SerializeField] string leftLimitTag;
    [SerializeField] string rightLimitTag;
    [SerializeField] string topLimitTag;
    [SerializeField] string bottomLimitTag;
    float gap = 1.001f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Vector3 newPosition = transform.position;

        if(other.name== leftLimitTag)
        {
            newPosition.x = GameObject.Find("limitRight").GetComponent<Transform>().position.x - gap;
            transform.position = newPosition;
        }
        else if(other.name== rightLimitTag)
        {
            newPosition.x = GameObject.Find("limitLeft").GetComponent<Transform>().position.x + gap;
            transform.position = newPosition;
        }
        else if( other.name== topLimitTag)
        {
            newPosition.y = GameObject.Find("limitBottom").GetComponent<Transform>().position.y + gap;
            transform.position = newPosition;
        }
        else if(other.name==bottomLimitTag)
        {
            newPosition.y = GameObject.Find("limitTop").GetComponent<Transform>().position.y - gap;
            transform.position = newPosition;
        }
    }
}
