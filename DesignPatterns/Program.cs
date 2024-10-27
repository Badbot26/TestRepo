// config
var solidPrinciples_SingleResponsibilityPrinciple = false;
var solidPrinciples_OpenClosedPrinciple = false;
var solidPrinciples_LiskovSubstitutionPrinciple = false;
var solidPrinciples_InterfaceSegregationPrinciple = false;
var solidPrinciples_DependencyInversionPrinciple = true;

if (solidPrinciples_SingleResponsibilityPrinciple)
    DesignPatterns.SolidPrinciples.SingleResponsibility.Engine.Run();

if (solidPrinciples_OpenClosedPrinciple)
    DesignPatterns.SolidPrinciples.OpenClosed.Engine.Run();

if (solidPrinciples_LiskovSubstitutionPrinciple)
    DesignPatterns.SolidPrinciples.LiskovSubstitution.Engine.Run();

if (solidPrinciples_InterfaceSegregationPrinciple)
    DesignPatterns.SolidPrinciples.InterfaceSegregation.Engine.Run();

if (solidPrinciples_DependencyInversionPrinciple)
    DesignPatterns.SolidPrinciples.DependencyInversion.Engine.Run();