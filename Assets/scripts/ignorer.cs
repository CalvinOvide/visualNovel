using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changement_de_scene : MonoBehaviour
{
  public void OnClick()
  {
    SceneManager.LoadScene("1bis");
  }
}
