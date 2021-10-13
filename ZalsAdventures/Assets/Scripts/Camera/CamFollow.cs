using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{

    public Transform target;
    public float radius;
    public float x, y, z;
    public float camTheta, camPhi;
    public float currX, currY;
    public float PI = 3.14f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            currX = Input.mousePosition.x;
            currY = Input.mousePosition.y;
        }
    }

    private void LateUpdate()
    {
        transform.position = new Vector3(target.transform.position.x + 2, target.transform.position.y + 2, target.transform.position.z - 10);
        
        /*
        if(Input.GetMouseButton(1))
        {
            radius = Mathf.Sqrt(Mathf.Pow(transform.position.x, 2) + Mathf.Pow(transform.position.y, 2) + Mathf.Pow(transform.position.z, 2));

            camTheta += (currX - Input.mousePosition.x) * 0.005f * Time.deltaTime;
            camPhi += (currY - Input.mousePosition.y) * 0.005f * Time.deltaTime;

            if (camPhi <= 0)
                camPhi = 0 + 0.001f;
            if (camPhi >= PI)
                camPhi = PI - 0.001f;

            x = radius * Mathf.Sin(camTheta) * Mathf.Sin(camPhi);
            z = radius * Mathf.Cos(camTheta) * Mathf.Sin(camPhi);
            y = radius * Mathf.Cos(camPhi);

            transform.Translate(new Vector3(x, y, z));
        }
        */
    }
}
