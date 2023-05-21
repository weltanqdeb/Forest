using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;
    [SerializeField] private Transform _player;
    [SerializeField] private int _itemCount;
    void Awake()
    {
        #region Singleton
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        #endregion
    }


    private void Update()
    {
      if (_itemCount == 5)
        {
            Application.Quit();
        }
    }
    public void AddItem(Item item)
    {
        _itemCount++;
        Destroy(item.gameObject);
    }

    

}