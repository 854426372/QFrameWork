using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QFrameWork
{
    public class EnumTypeChange 
    {
        public static int EnumToInt(object enumType)
        {
            return (int)enumType;
        }
        public static T InitToEnum<T>(int enumType)
        {
            return (T)Enum.ToObject(typeof(T), enumType);
        }
    }
}