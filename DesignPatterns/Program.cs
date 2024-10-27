// config
var solidPrinciples_SingleResponsibilityPrinciple = false;
var solidPrinciples_OpenClosedPrinciple = false;
var solidPrinciples_LiskovSubstitutionPrinciple = true;

if (solidPrinciples_SingleResponsibilityPrinciple)
    DesignPatterns.SolidPrinciples.SingleResponsibility.Engine.Run();

if (solidPrinciples_OpenClosedPrinciple)
    DesignPatterns.SolidPrinciples.OpenClosed.Engine.Run();

if (solidPrinciples_LiskovSubstitutionPrinciple)
    DesignPatterns.SolidPrinciples.LiskovSubstitution.Engine.Run();