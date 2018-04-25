using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSys : MonoBehaviour {

    public GameObject player;
    // private Vector3 offset;

    public float minX;
    public float maxY;
    public float maxX;
    public float minY;

	// Use this for initialization
	void Start () {
    // offset = transform.position - player.transform.position;
	}

	// Update is called once per frame
	void LateUpdate () {
        float x = Mathf.Clamp(player.transform.position.x, minX, maxX);
        float y = Mathf.Clamp(player.transform.position.y, minY, maxY);
        gameObject.transform.position = new Vector3(x, y, gameObject.transform.position.z);
        // transform.position = player.transform.position + offset;

	}
}
