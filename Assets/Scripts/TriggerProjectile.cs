using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject projectileA;
    [SerializeField] GameObject projectileB;
    [SerializeField] GameObject projectileC;
    [SerializeField] GameObject projectileD;
    [SerializeField] GameObject projectileE;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            projectileA.SetActive(true);
            projectileB.SetActive(true);
            projectileC.SetActive(true);
            projectileD.SetActive(true);
            projectileE.SetActive(true);
            Destroy(gameObject);
        }
    }
}
