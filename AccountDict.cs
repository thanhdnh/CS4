using System.Collections;

class AccountDict:DictionaryBase{
    public void Add(string k, Account v){
        base.InnerHashtable.Add(k, v);
    }
    public void Remove(string k){
        base.InnerHashtable.Remove(k);
    }
    public Account Item(string k){
        return (Account)base.InnerHashtable[k];
    }
}