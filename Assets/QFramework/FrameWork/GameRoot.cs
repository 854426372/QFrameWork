using QFrameWork.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFrameWork;

public class GameRoot : MonoBehaviour
{
    private static GameRoot _instance;

    public static GameRoot Instance { get => _instance;  }
    public BaseManager mBaseManager;
    private void Awake()
    {
        _instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
    private void Start() {
        mBaseManager = new BaseManager(this);
    }
    private void Update() {
        
    }
    private void OnDestroy() {
    }
}
