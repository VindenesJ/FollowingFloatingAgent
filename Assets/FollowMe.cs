using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FollowMe : MonoBehaviour
{
    
    public GameObject target;
    private Vector3 distance = new Vector3(2, 2, 0);
    public float speed;
    private void Start() 
    {
        
    }
    private void Update()
    {
        GameObject.Find("Follower").transform.position = Vector3.Slerp(
            GameObject.Find("Follower").transform.position,
            (target.transform.position + distance), (5 * Time.deltaTime));
        Vector3 followerPosition = GameObject.Find("Follower").transform.position;
        followerPosition.y = (Mathf.Sin(Time.time) * speed) + 2;
        GameObject.Find("Follower").transform.position = new Vector3(GameObject.Find("Follower").transform.position.x, followerPosition.y, GameObject.Find("Follower").transform.position.z);
        //float newY = Mathf.Sin(Time.time * speed);
        //Debug.Log((Time.time + 15) * speed);
        //Vector3 pos = GameObject.Find("Follower").transform.position;

        //GameObject.Find("Follower").transform.position = new Vector3(pos.x, newY, pos.z);

    }
    private void FixedUpdate()
    {
        //GameObject.Find("Follower").transform.position += new Vector3(GameObject.Find("Follower").transform.position.x, (Mathf.Sin(Time.realtimeSinceStartup * verticalSpeed) * amplitude), GameObject.Find("Follower").transform.position.z);
    }
}