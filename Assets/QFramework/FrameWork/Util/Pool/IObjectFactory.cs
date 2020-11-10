using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QFrameWork
{
    public interface IObjectFactory<T>
    {
        T Create();
    }
}