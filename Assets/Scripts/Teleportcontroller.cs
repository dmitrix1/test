using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleportcontroller : MonoBehaviour
{
  private void OnTriggerEnter2D(Collider2D other)
  { 
    
    print("23456789");

      SceneManager.LoadScene("Dungeon");
    
    
  }
}
