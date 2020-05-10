using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QFrameWork
{
    public partial class TransformSimplify : MonoBehaviour
    {
        public static void AddChild(Transform tran,Transform childTran)
        {
            childTran.SetParent(tran);
        }
    }
}