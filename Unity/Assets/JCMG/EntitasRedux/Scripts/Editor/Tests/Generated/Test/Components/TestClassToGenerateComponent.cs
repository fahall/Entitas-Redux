//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.3.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public ClassToGenerateComponent ClassToGenerate { get { return (ClassToGenerateComponent)GetComponent(TestComponentsLookup.ClassToGenerate); } }
    public bool HasClassToGenerate { get { return HasComponent(TestComponentsLookup.ClassToGenerate); } }

    public void AddClassToGenerate(EntitasRedux.Tests.ClassToGenerate newValue) {
        var index = TestComponentsLookup.ClassToGenerate;
        var component = (ClassToGenerateComponent)CreateComponent(index, typeof(ClassToGenerateComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceClassToGenerate(EntitasRedux.Tests.ClassToGenerate newValue) {
        var index = TestComponentsLookup.ClassToGenerate;
        var component = (ClassToGenerateComponent)CreateComponent(index, typeof(ClassToGenerateComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

	public void CopyClassToGenerateTo(ClassToGenerateComponent copyComponent) {
        var index = TestComponentsLookup.ClassToGenerate;
        var component = (ClassToGenerateComponent)CreateComponent(index, typeof(ClassToGenerateComponent));
        component.value = copyComponent.value;
        ReplaceComponent(index, component);
    }

    public void RemoveClassToGenerate() {
        RemoveComponent(TestComponentsLookup.ClassToGenerate);
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
public partial class TestEntity : IClassToGenerateEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.3.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class TestMatcher {

    static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherClassToGenerate;

    public static JCMG.EntitasRedux.IMatcher<TestEntity> ClassToGenerate {
        get {
            if (_matcherClassToGenerate == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.ClassToGenerate);
                matcher.ComponentNames = TestComponentsLookup.ComponentNames;
                _matcherClassToGenerate = matcher;
            }

            return _matcherClassToGenerate;
        }
    }
}
