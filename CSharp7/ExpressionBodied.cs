using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_7.CSharp7
{
    public class ExpressionBodied
    {
        //Accessors, constructors, finalizers
    }

    //public class Zombie
    //{
    //    private List<int, string> names = new List<int, string>();
    //    public Zombie(string name, int id) => names.Add(id, name);
    //    ~Zombie() => names.RemoveAll();  

    //    public string Name
    //    {
    //        get => names[id];                                 // getters
    //        set => names[id] = value;                         // setters
    //    }
           

    //}
}

//public class ArrayIndexer : Accessor
//{
//    private readonly IndexerValueGetter _getter;

//    public ArrayIndexer(IndexerValueGetter getter)
//    {
//        _getter = getter;
//    }

//    public string FieldName => _getter.Name;
//    public Type PropertyType => _getter.ValueType;
//    public PropertyInfo InnerProperty => null;
//    public Type DeclaringType => _getter.DeclaringType;
//    public string Name => _getter.Name;
//    public Type OwnerType => DeclaringType;

//    public void SetValue(object target, object propertyValue) => _getter.SetValue(target, propertyValue);

//    public object GetValue(object target) => _getter.GetValue(target);
//}

//}
