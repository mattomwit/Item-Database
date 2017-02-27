using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour {
    public GameObject bulletPrefab;

    public override void OnStartLocalPlayer()
    {
        GetComponent<MeshRenderer>().material.color = Color.green;
    }

	void Update () {
        if (!isLocalPlayer)
            return;    
            
            var x = Input.GetAxis("Horizontal") * 0.1f;
            var z = Input.GetAxis("Vertical") * 0.1f;
            transform.Translate(x, 0, z);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CmdFire();
        }
    }
    [Command]
    void CmdFire()
    {
        var bullet = (GameObject)Instantiate(bulletPrefab, transform.position - transform.forward, Quaternion.identity);
        bullet.GetComponent<Rigidbody>().velocity = -transform.forward * 4;
        NetworkServer.Spawn(bullet);
        Destroy(bullet, 2.0f);
    }
}
