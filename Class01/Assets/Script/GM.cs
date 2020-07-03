using UnityEngine;

public class GM : MonoBehaviour
{
    public GameObject TxetImg;
    




    public void CloseUI()
    {
        TxetImg.SetActive(false);
    }

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
