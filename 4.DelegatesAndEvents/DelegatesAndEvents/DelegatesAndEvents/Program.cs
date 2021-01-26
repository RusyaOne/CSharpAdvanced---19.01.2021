using Delegates.DelegatesExamples;
using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = ExamplesEnumeration.BuildInDelegateAction;

            switch (exampleToRun)
            {
                case ExamplesEnumeration.DelegatesBasicSyntaxShow:
                    BasicSyntaxDelegate.ShowDelegate();
                    break;
                case ExamplesEnumeration.DelegateShortSyntax:
                    ShortSyntaxDelegate.ShowShortSyntax();
                    break;
                case ExamplesEnumeration.DelegateNonStatic:
                    NonStaticDelegate.ShowNonStaticDelegate();
                    break;
                case ExamplesEnumeration.DelegateWithParameters:
                    WithParametersDelegate.ShowWithParametersDelegate();
                    break;
                case ExamplesEnumeration.DelegateCombined:
                    CombinedDelegates.ShowCombinedDelegate();
                    break;
                case ExamplesEnumeration.DelegateAnonymousMethod:
                    AnonymousMethodsDelegate.ShowAnonymousMethod();
                    break;
                case ExamplesEnumeration.DelegateAnonymousMethodReturn:
                    AnonymousMethodsDelegate.MethodWithReturnType();
                    break;
                case ExamplesEnumeration.DelegateLambdaExpression:
                    LambdaExpressionDelegate.ShowLambdaExpression();
                    break;
                case ExamplesEnumeration.DelegateAnounymousMethodVsLambda:
                    LambdaExpressionDelegate.AnonymousMethodVsLambda();
                    break;
                case ExamplesEnumeration.BuildInDelegateAction:
                    BuildInDelegates.ShowActionDelegate();
                    break;
                case ExamplesEnumeration.BuildInDelegateGenericAction:
                    BuildInDelegates.ShowGenericActionDelegate();
                    break;
                case ExamplesEnumeration.BuildInDelegateFunction:
                    BuildInDelegates.ShowFunctionDelegate();
                    break;
                case ExamplesEnumeration.BuildInDelegatePredicate:
                    BuildInDelegates.ShowPredicateDelegate();
                    break;
                case ExamplesEnumeration.CallbackShow:
                    CallbackExample.UseCallback();
                    break;
            }

            Console.Read();
        }
    }
}
