using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QFrameWork
{
    public partial class GameObjectSimplify : MonoBehaviour
    {
        public static void Show(Transform tran)
        {
            tran.gameObject.SetActive(true);
        }
        public static void Hide(Transform tran)
        {
            tran.gameObject.SetActive(false);
        }

    }
}