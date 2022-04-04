using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float panSpeed = 10f;
    public float panBorderThickness = 10f;

    private bool doMovement = true;

    public float scrollSpeed = 5f;

    public float minY = 10f;
    public float maxY = 80f;

    public float minYt = 1f;
    public float maxYt = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!doMovement)
            return;

        if(Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness)
        {
            transform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);

           
            
        }
        if(Input.GetKey("s") || Input.mousePosition.y <=  panBorderThickness)
        {
            transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
        
        }
        if(Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
        {
            transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
        }
        if(Input.GetKey("a") || Input.mousePosition.x <=  panBorderThickness)
        {
            transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
        }
         Vector3 clampedPos = transform.position;
        clampedPos.z = Mathf.Clamp(clampedPos.z,-10f , 0f);
        clampedPos.x = Mathf.Clamp(clampedPos.x,-3f , 2f);
        transform.position = clampedPos;

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        Vector3 pos = transform.position;
        pos.y -= scroll * 1000 * scrollSpeed * Time.deltaTime;
        pos.y = Mathf.Clamp (pos.y, minY, maxY);
        transform.position = pos;
    }
}
