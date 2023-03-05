using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
   public void Load_scene(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }
}
