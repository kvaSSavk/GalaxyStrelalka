using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gamemenuProduser : MonoBehaviour
{

    public void starter() 
    {
        SceneManager.LoadSceneAsync(SceneIDS.levelSceneID);
    }
}
