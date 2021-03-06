//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.3.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class MyTestEntity {

    public EntitasRedux.Tests.Performance.NameAgeComponent NameAge { get { return (EntitasRedux.Tests.Performance.NameAgeComponent)GetComponent(MyTestComponentsLookup.NameAge); } }
    public bool HasNameAge { get { return HasComponent(MyTestComponentsLookup.NameAge); } }

    public void AddNameAge(int newAge, string newName) {
        var index = MyTestComponentsLookup.NameAge;
        var component = (EntitasRedux.Tests.Performance.NameAgeComponent)CreateComponent(index, typeof(EntitasRedux.Tests.Performance.NameAgeComponent));
        component.age = newAge;
        component.name = newName;
        AddComponent(index, component);
    }

    public void ReplaceNameAge(int newAge, string newName) {
        var index = MyTestComponentsLookup.NameAge;
        var component = (EntitasRedux.Tests.Performance.NameAgeComponent)CreateComponent(index, typeof(EntitasRedux.Tests.Performance.NameAgeComponent));
        component.age = newAge;
        component.name = newName;
        ReplaceComponent(index, component);
    }

	public void CopyNameAgeTo(EntitasRedux.Tests.Performance.NameAgeComponent copyComponent) {
        var index = MyTestComponentsLookup.NameAge;
        var component = (EntitasRedux.Tests.Performance.NameAgeComponent)CreateComponent(index, typeof(EntitasRedux.Tests.Performance.NameAgeComponent));
        component.age = copyComponent.age;
        component.name = copyComponent.name;
        ReplaceComponent(index, component);
    }

    public void RemoveNameAge() {
        RemoveComponent(MyTestComponentsLookup.NameAge);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.3.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class MyTestMatcher {

    static JCMG.EntitasRedux.IMatcher<MyTestEntity> _matcherNameAge;

    public static JCMG.EntitasRedux.IMatcher<MyTestEntity> NameAge {
        get {
            if (_matcherNameAge == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<MyTestEntity>)JCMG.EntitasRedux.Matcher<MyTestEntity>.AllOf(MyTestComponentsLookup.NameAge);
                matcher.ComponentNames = MyTestComponentsLookup.ComponentNames;
                _matcherNameAge = matcher;
            }

            return _matcherNameAge;
        }
    }
}
