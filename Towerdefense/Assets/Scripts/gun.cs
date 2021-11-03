
using UnityEngine;

public class gun : MonoBehaviour
{

    public Camera fpscam;
    public float damage = 10f;
    public float range = 100f;
    public ParticleSystem muzzleflash;
    public GameObject impacteffect;
    public float firerate = 15f;
    private float nextshot = 0f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextshot)
        {
            nextshot = Time.time + 1f / firerate;
            shoot();
        }

        void shoot()
        {
            RaycastHit hit;
            if(Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit, range))
            {
                muzzleflash.Play();

                Debug.Log(hit.transform.name);
                Target target = hit.transform.GetComponent<Target>();

                if(target != null)
                {
                    target.TakeDamge(damage);
                }

                GameObject impactGO = Instantiate(impacteffect, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(impactGO, 2f);
            }
        }




    }
}
