﻿namespace TechTalk.SpecFlow.Assist.ValueRetrievers
{
    public class ByteValueRetriever
    {
        public virtual byte GetValue(string value)
        {
            byte returnValue;
            byte.TryParse(value, out returnValue);
            return returnValue;
        }
    }
}