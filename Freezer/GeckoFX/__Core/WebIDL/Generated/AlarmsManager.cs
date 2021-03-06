namespace Gecko.WebIDL
{
    using System;
    
    
    internal class AlarmsManager : WebIDLBase
    {
        
        public AlarmsManager(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports GetAll()
        {
            return this.CallMethod<nsISupports>("getAll");
        }
        
        public nsISupports Add(object date, string respectTimezone)
        {
            return this.CallMethod<nsISupports>("add", date, respectTimezone);
        }
        
        public nsISupports Add(object date, string respectTimezone, object data)
        {
            return this.CallMethod<nsISupports>("add", date, respectTimezone, data);
        }
        
        public void Remove(uint id)
        {
            this.CallVoidMethod("remove", id);
        }
    }
}
