//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.3.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class VisualDebugEntity {

    public ExampleContent.VisualDebugging.MyHiddenIntComponent MyHiddenInt { get { return (ExampleContent.VisualDebugging.MyHiddenIntComponent)GetComponent(VisualDebugComponentsLookup.MyHiddenInt); } }
    public bool HasMyHiddenInt { get { return HasComponent(VisualDebugComponentsLookup.MyHiddenInt); } }

    public void AddMyHiddenInt(int newMyInt) {
        var index = VisualDebugComponentsLookup.MyHiddenInt;
        var component = (ExampleContent.VisualDebugging.MyHiddenIntComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MyHiddenIntComponent));
        component.myInt = newMyInt;
        AddComponent(index, component);
    }

    public void ReplaceMyHiddenInt(int newMyInt) {
        var index = VisualDebugComponentsLookup.MyHiddenInt;
        var component = (ExampleContent.VisualDebugging.MyHiddenIntComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MyHiddenIntComponent));
        component.myInt = newMyInt;
        ReplaceComponent(index, component);
    }

	public void CopyMyHiddenIntTo(ExampleContent.VisualDebugging.MyHiddenIntComponent copyComponent) {
        var index = VisualDebugComponentsLookup.MyHiddenInt;
        var component = (ExampleContent.VisualDebugging.MyHiddenIntComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MyHiddenIntComponent));
        component.myInt = copyComponent.myInt;
        ReplaceComponent(index, component);
    }

    public void RemoveMyHiddenInt() {
        RemoveComponent(VisualDebugComponentsLookup.MyHiddenInt);
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
public sealed partial class VisualDebugMatcher {

    static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherMyHiddenInt;

    public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> MyHiddenInt {
        get {
            if (_matcherMyHiddenInt == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.MyHiddenInt);
                matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
                _matcherMyHiddenInt = matcher;
            }

            return _matcherMyHiddenInt;
        }
    }
}
