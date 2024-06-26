using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public Vector3 currentRotation;
    public Vector3 anglesToRotate;

    // Start is called before the first frame update
    void Start()
    {
        currentRotation = new Vector3 (currentRotation.x % 360f, currentRotation.y % 360f, currentRotation.z % 360f);

        Quaternion rotationY = Quaternion.AngleAxis(currentRotation.y, new Vector3(0f, 1f, 0f));

        Quaternion rotationX = Quaternion.AngleAxis(currentRotation.x, new Vector3(1f, 0f, 0f));

        Quaternion rotationZ = Quaternion.AngleAxis(currentRotation.z, new Vector3(0f, 0f, 1f));

        this.transform.rotation = rotationY * rotationX * rotationZ;
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion rotationY = Quaternion.AngleAxis(anglesToRotate.y * Time.deltaTime, new Vector3(0f, 1f, 0f));

        Quaternion rotationX = Quaternion.AngleAxis(anglesToRotate.x * Time.deltaTime, new Vector3(1f, 0f, 0f));

        Quaternion rotationZ = Quaternion.AngleAxis(anglesToRotate.z * Time.deltaTime, new Vector3(0f, 0f, 1f));

        this.transform.rotation = rotationY * rotationX * rotationZ * this.transform.rotation;
    }
}
