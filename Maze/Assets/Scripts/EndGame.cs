using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

public GameObject Player;
public Collision playerCollision;
public AudioClip audioClip;
public Vector3 vector3;
  public void OnCollisionEnter(Collision collision){
     Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "Player"){
            AudioSource.PlayClipAtPoint(audioClip,vector3);
            //Algo para parar o Jogador e fazer ele não se mover
            
            Player.SetActive(false);
            Application.Quit();
        }
        
 }

    // Update is called once per frame
    void Update()
    {
        OnCollisionEnter(playerCollision);
    }
}
