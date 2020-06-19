using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UIElements;

public class Door : MonoBehaviour
{
    bool isOpen = false;

    private void Start()
    {
        //transform.Rotate(0, 90, 0);
        //Quaternion rot = Quaternion.Euler(0, 90, 0);
        //transform.rotation = Quaternion.Slerp(transform.rotation, rot, Time.deltaTime);

        //Position - Vector3
        //Rotation - Quaternion

        //transform.eulerAngles = new Vector3(x, y, z);
    }

    private void Update()
    {

        if (isOpen)
        {

            if (transform.eulerAngles.y < 90)
            {
                transform.Rotate(0, 2, 0);
            }
        }
        if (!isOpen)
        {

            if (transform.eulerAngles.y>1)
            {
                transform.Rotate(0, -2, 0);              
            }
        }
        //print(transform.eulerAngles.y);





    }

    public void OpenDoor()
    {
        isOpen =!isOpen;
        //print(isOpen);
    }
}
