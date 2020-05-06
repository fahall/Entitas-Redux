//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class VisualDebugEntity {

    public PositionComponent Position { get { return (PositionComponent)GetComponent(VisualDebugComponentsLookup.Position); } }
    public bool hasPosition { get { return HasComponent(VisualDebugComponentsLookup.Position); } }

    public void AddPosition(ExampleContent.VisualDebugging.IntVector2 newValue) {
        var index = VisualDebugComponentsLookup.Position;
        var component = (PositionComponent)CreateComponent(index, typeof(PositionComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplacePosition(ExampleContent.VisualDebugging.IntVector2 newValue) {
        var index = VisualDebugComponentsLookup.Position;
        var component = (PositionComponent)CreateComponent(index, typeof(PositionComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemovePosition() {
        RemoveComponent(VisualDebugComponentsLookup.Position);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class VisualDebugMatcher {

    static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherPosition;

    public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> Position {
        get {
            if (_matcherPosition == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.Position);
                matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
                _matcherPosition = matcher;
            }

            return _matcherPosition;
        }
    }
}