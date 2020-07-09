using UnityEngine;

public class GM : MonoBehaviour
{
    public GameObject TextImg;

    //public GameObject canvas;




    public void CloseUI()
    {
        TextImg.SetActive(false);
    }

    /*public void CloseCanvas()
    {
        canvas.SetActive(false);
    }*/

    public void GunTrigger(float Istrigger)
    {
        /*if (Istrigger)
        {
            GameObject.Find("Trigger").transform.Rotate(-45, 0, 0);
        }
        else
        {
            GameObject.Find("Trigger").transform.Rotate(45, 0, 0);
        }*/

        GameObject.Find("Trigger").transform.Rotate(Istrigger, 0, 0);
    }
}
