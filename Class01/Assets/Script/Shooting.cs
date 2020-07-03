using UnityEngine;

public class Shooting : MonoBehaviour
{

    public GameObject Bullet,ShootingPos;
       

   

    private void Update()
    {



        /*if (Input.GetKeyDown("space"))
        {
            GameObject bulletCopy = Instantiate(Bullet);
            bulletCopy.transform.position = ShootingPos.transform.position;
            bulletCopy.GetComponent<Rigidbody>().AddForce(ShootingPos.transform.position * 15, ForceMode.Impulse);
        }*/


    }

    public void Firee()
    {      
            
        GameObject sho = Instantiate(Bullet, transform.position, transform.rotation);
        sho.GetComponent<Rigidbody>().AddForce(transform.forward * 2000);
        Destroy(sho, 2);                
        
     

}
}
