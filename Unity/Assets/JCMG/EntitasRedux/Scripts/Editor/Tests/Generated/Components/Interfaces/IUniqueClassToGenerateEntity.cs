//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial interface IUniqueClassToGenerateEntity {

    UniqueClassToGenerateComponent UniqueClassToGenerate { get; }
    bool hasUniqueClassToGenerate { get; }

    void AddUniqueClassToGenerate(EntitasRedux.Tests.UniqueClassToGenerate newValue);
    void ReplaceUniqueClassToGenerate(EntitasRedux.Tests.UniqueClassToGenerate newValue);
    void RemoveUniqueClassToGenerate();
}