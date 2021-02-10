using LINQ.LinqExamples;
using System;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = ExamplesEnumeration.ExclusionWithWhere;

            switch (exampleToRun)
            {
                case ExamplesEnumeration.BasicSyntax:
                    BasicSyntax.ShowBasicSyntaxLinq();
                    break;
                case ExamplesEnumeration.GenderCondition:
                    BasicSyntax.ShowConditionWithGender();
                    break;
                case ExamplesEnumeration.ExtensionMethodSyntax:
                    ExtensionMethodSyntax.ShowExtensionMethodSyntax();
                    break;
                case ExamplesEnumeration.DefferedExecution:
                    ExtensionMethodSyntax.DefferedExecution();
                    break;
                case ExamplesEnumeration.WhereBasicSyntax:
                    WhereClause.ShowWhereWithBasicSyntax();
                    break;
                case ExamplesEnumeration.WhereExtensionSyntax:
                    WhereClause.ShowWhereWithExtensionSyntax();
                    break;
                case ExamplesEnumeration.OrderByBasicSyntax:
                    OrderByClause.ShowOrderBy();
                    break;
                case ExamplesEnumeration.OrderByExtensionSyntax:
                    OrderByClause.OrderByExtensionSyntax();
                    break;
                case ExamplesEnumeration.GroupByBasicSyntax:
                    GroupByClause.ShowGroupBy();
                    break;
                case ExamplesEnumeration.GroupByExtensionSyntax:
                    GroupByClause.GroupByExtensionSyntax();
                    break;
                case ExamplesEnumeration.GroupByInto:
                    GroupByClause.GroupByInto();
                    break;
                case ExamplesEnumeration.AnonymousTypes:
                    AnonymousTypes.ShowAnonymousTypes();
                    break;
                case ExamplesEnumeration.AnonymousTypesTryChangeProperty:
                    AnonymousTypes.TryChangeProperty();
                    break;
                case ExamplesEnumeration.AnonymousTypesPropertyNamesInheritance:
                    AnonymousTypes.PropertiesNamesInheritance();
                    break;
                case ExamplesEnumeration.ExplicitSelectClause:
                    ExplicitSelectClause.ShowExplicitSelect();
                    break;
                case ExamplesEnumeration.ExplicitSelectAnonymousType:
                    ExplicitSelectClause.SelectAnonymousType();
                    break;
                case ExamplesEnumeration.DynamicTypes:
                    DynamicTypes.ShowDynamicTypes();
                    break;
                case ExamplesEnumeration.JoinWithQuerySyntax:
                    JoinClause.ShowJoinWithQuerySyntax();
                    break;
                case ExamplesEnumeration.JoinWithExtensionMethodsSyntax:
                    JoinClause.ShowJoinByMultipleFieldsWithTuple();
                    break;
                case ExamplesEnumeration.JoinByMultipleFields:
                    JoinClause.ShowJoinByMultipleFields();
                    break;
                case ExamplesEnumeration.JoinByMultipleFieldsWithTuple:
                    JoinClause.ShowJoinByMultipleFieldsWithTuple();
                    break;
                case ExamplesEnumeration.LeftJoinQuerySyntax:
                    JoinClause.ShowLeftJoinQuerySyntax();
                    break;
                case ExamplesEnumeration.LeftJoinExtensionMethodsSyntax:
                    JoinClause.ShowLeftJoinExtensionMethodsSyntax();
                    break;
                case ExamplesEnumeration.ExclusionWithWhere:
                    WhereClause.ShowExclusionWithWhere();
                    break;
            }

            Console.Read();
        }
    }
}