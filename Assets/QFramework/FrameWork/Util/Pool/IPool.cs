using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QFrameWork
{
    public interface IPool<T>
    {
        T Allocate();                                          //分配
        bool Recycle(T obj);                                   //回收利用
    }
}