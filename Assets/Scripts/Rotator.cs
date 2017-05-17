using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
    public Vector3 rotator = new Vector3(0,0,0);
    
	void Update () {
        transform.Rotate(rotator);
	}
}
