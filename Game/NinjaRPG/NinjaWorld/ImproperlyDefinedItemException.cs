﻿namespace NinjaWorld
{
    using System;

    public class ImproperlyDefinedItemException : ApplicationException
    {
        public ImproperlyDefinedItemException(string msg)
            : base(msg)
        {
        }

        public ImproperlyDefinedItemException(string msg, Exception innerEx)
            : base(msg, innerEx)
        {
        }
    }
}