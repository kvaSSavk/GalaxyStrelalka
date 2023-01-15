using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMan : MonoBehaviour
{
    public GameObject firstGroupOriginal;
    public GameObject KamikadzeGroupOriginal;
    private GroupBase currentGroup;
    private int groupsCount = 0;
    private EnGrType [] groupTyps = {EnGrType.basaGroup, EnGrType.KamekadzeGroup};

    void Start()
    {
       CreateNewGroup();
       groupsCount++;
    }

    
    void Update()
    {
        if(currentGroup != null && currentGroup.isAlive == false)
        {
            Destroy(currentGroup.gameObject);
            if(groupsCount == groupTyps.Length) {
                SceneManager.LoadSceneAsync(SceneIDS.winSceneID);
            } else {
                CreateNewGroup(); 
                groupsCount++;
            }
        }
    }

    void CreateNewGroup() {
        if (groupTyps[groupsCount] == EnGrType.basaGroup) {
        GameObject newGroup = Instantiate(firstGroupOriginal);   
        newGroup.transform.position = transform.position;
        currentGroup = newGroup.GetComponent<FirstEnGroup>();
        } else if (groupTyps[groupsCount] == EnGrType.KamekadzeGroup){
           GameObject newGroup = Instantiate(KamikadzeGroupOriginal);   
        newGroup.transform.position = transform.position;
        currentGroup = newGroup.GetComponent<KamekadzeEnemyGroup>(); 
        }
    }
}
