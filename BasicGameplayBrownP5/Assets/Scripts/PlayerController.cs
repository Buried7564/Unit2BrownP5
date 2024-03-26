using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float horizontalInput;
    private float verticalInput; 
    public float speed = 10.0f;
    public float xRange = 10;
    public float zMin;
    public float zMax;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        if (transform.position.x < -10)
        {
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 10)
        {
            transform.position = new Vector3(10, transform.position.y, transform.position.z);
        }
        if (transform.position.y < zMin)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMin);
        }
        if (transform.position.y > zMax)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMax);
        }
    }
}
