using QFrameWork;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QFrameWork
{
    public class Hide : MonoBehaviourSimplify
    {
        private void Awake()
        {
            this.Hide();
        }

        protected override void OnBeforeDestroy()
        {
        }
    }
}