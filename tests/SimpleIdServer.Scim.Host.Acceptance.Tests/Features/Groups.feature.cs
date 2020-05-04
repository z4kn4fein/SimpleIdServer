// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SimpleIdServer.Scim.Host.Acceptance.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class GroupsFeature : Xunit.IClassFixture<GroupsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "Groups.feature"
#line hidden
        
        public GroupsFeature(GroupsFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Groups", "\tCheck the /Groups endpoint", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Check Group can be created")]
        [Xunit.TraitAttribute("FeatureTitle", "Groups")]
        [Xunit.TraitAttribute("Description", "Check Group can be created")]
        public virtual void CheckGroupCanBeCreated()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check Group can be created", null, ((string[])(null)));
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table3.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:schemas:core:2.0:Group\" ]"});
            table3.AddRow(new string[] {
                        "displayName",
                        "Tour Guides"});
            table3.AddRow(new string[] {
                        "members",
                        "[ { \"value\": \"2819c223-7f76-453a-919d-413861904646\", \"$ref\": \"https://example.com" +
                            "/v2/Users/2819c223-7f76-453a-919d-413861904646\", \"display\": \"Babs Jensen\" }  ]"});
#line 5
 testRunner.When("execute HTTP POST JSON request \'http://localhost/Groups\'", ((string)(null)), table3, "When ");
#line 10
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And("extract \'id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table4.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:api:messages:2.0:PatchOp\" ]"});
            table4.AddRow(new string[] {
                        "Operations",
                        @"[ { ""op"" : ""remove"", ""path"": ""members[display eq \""Babs Jensen\"" and value co \""2819\""]"" }, { ""op"": ""add"", ""path"": ""members"", ""value"": [ { ""value"": ""902c246b-6245-4190-8e05-00816be7344a"", ""$ref"": ""https://example.com/v2/Users/902c246b-6245-4190-8e05-00816be7344a"", ""display"": ""Mandy Pepperidge"" } ] } ]"});
#line 12
 testRunner.And("execute HTTP PATCH JSON request \'http://localhost/Groups/$id$\'", ((string)(null)), table4, "And ");
#line 16
 testRunner.And("execute HTTP GET request \'http://localhost/Groups/$id$\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
 testRunner.Then("HTTP HEADER contains \'Location\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.Then("HTTP HEADER contains \'ETag\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
 testRunner.Then("JSON exists \'id\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
 testRunner.Then("JSON exists \'meta.created\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
 testRunner.Then("JSON exists \'meta.lastModified\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
 testRunner.Then("JSON exists \'meta.version\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
 testRunner.Then("JSON exists \'meta.location\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
 testRunner.Then("JSON \'displayName\'=\'Tour Guides\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 28
 testRunner.Then("JSON \'members[0].display\'=\'Mandy Pepperidge\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
 testRunner.Then("JSON \'members[0].$ref\'=\'https://example.com/v2/Users/902c246b-6245-4190-8e05-0081" +
                    "6be7344a\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
 testRunner.Then("JSON \'members[0].value\'=\'902c246b-6245-4190-8e05-00816be7344a\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Check user can be added to a group")]
        [Xunit.TraitAttribute("FeatureTitle", "Groups")]
        [Xunit.TraitAttribute("Description", "Check user can be added to a group")]
        public virtual void CheckUserCanBeAddedToAGroup()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check user can be added to a group", null, ((string[])(null)));
#line 32
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table5.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:schemas:core:2.0:User\", \"urn:ietf:params:scim:schemas:ext" +
                            "ension:enterprise:2.0:User\" ]"});
            table5.AddRow(new string[] {
                        "userName",
                        "bjen"});
            table5.AddRow(new string[] {
                        "externalId",
                        "externalid"});
            table5.AddRow(new string[] {
                        "name",
                        "{ \"formatted\" : \"formatted\", \"familyName\": \"familyName\", \"givenName\": \"givenName\"" +
                            " }"});
            table5.AddRow(new string[] {
                        "employeeNumber",
                        "number"});
#line 33
 testRunner.When("execute HTTP POST JSON request \'http://localhost/Users\'", ((string)(null)), table5, "When ");
#line 41
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.And("extract \'id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table6.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:schemas:core:2.0:Group\" ]"});
            table6.AddRow(new string[] {
                        "displayName",
                        "Tour Guides"});
            table6.AddRow(new string[] {
                        "members",
                        "[ { \"value\": \"$id$\" } ]"});
#line 43
 testRunner.And("execute HTTP POST JSON request \'http://localhost/Groups\'", ((string)(null)), table6, "And ");
#line 48
 testRunner.And("execute HTTP GET request \'http://localhost/Users/$id$\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 52
 testRunner.Then("HTTP HEADER contains \'Location\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 53
 testRunner.Then("HTTP HEADER contains \'ETag\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 54
 testRunner.Then("JSON exists \'id\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 55
 testRunner.Then("JSON exists \'meta.created\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 56
 testRunner.Then("JSON exists \'meta.lastModified\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 57
 testRunner.Then("JSON exists \'meta.version\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 58
 testRunner.Then("JSON exists \'meta.location\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 59
 testRunner.Then("JSON \'groups[0].display\'=\'Tour guides\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Check group can be updated with multiple users")]
        [Xunit.TraitAttribute("FeatureTitle", "Groups")]
        [Xunit.TraitAttribute("Description", "Check group can be updated with multiple users")]
        public virtual void CheckGroupCanBeUpdatedWithMultipleUsers()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check group can be updated with multiple users", null, ((string[])(null)));
#line 61
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table7.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:schemas:core:2.0:User\", \"urn:ietf:params:scim:schemas:ext" +
                            "ension:enterprise:2.0:User\" ]"});
            table7.AddRow(new string[] {
                        "userName",
                        "bjen"});
            table7.AddRow(new string[] {
                        "externalId",
                        "externalid"});
            table7.AddRow(new string[] {
                        "name",
                        "{ \"formatted\" : \"formatted\", \"familyName\": \"familyName\", \"givenName\": \"givenName\"" +
                            " }"});
            table7.AddRow(new string[] {
                        "employeeNumber",
                        "number"});
#line 62
 testRunner.When("execute HTTP POST JSON request \'http://localhost/Users\'", ((string)(null)), table7, "When ");
#line 70
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.And("extract \'id\' from JSON body into \'firstuserid\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table8.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:schemas:core:2.0:User\", \"urn:ietf:params:scim:schemas:ext" +
                            "ension:enterprise:2.0:User\" ]"});
            table8.AddRow(new string[] {
                        "userName",
                        "bjen2"});
            table8.AddRow(new string[] {
                        "externalId",
                        "externalid"});
            table8.AddRow(new string[] {
                        "name",
                        "{ \"formatted\" : \"formatted\", \"familyName\": \"familyName\", \"givenName\": \"givenName\"" +
                            " }"});
            table8.AddRow(new string[] {
                        "employeeNumber",
                        "number"});
#line 72
 testRunner.And("execute HTTP POST JSON request \'http://localhost/Users\'", ((string)(null)), table8, "And ");
#line 79
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.And("extract \'id\' from JSON body into \'seconduserid\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table9.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:schemas:core:2.0:Group\" ]"});
            table9.AddRow(new string[] {
                        "displayName",
                        "Tour Guides"});
            table9.AddRow(new string[] {
                        "members",
                        "[ { \"value\": \"$firstuserid$\" } ]"});
#line 81
 testRunner.And("execute HTTP POST JSON request \'http://localhost/Groups\'", ((string)(null)), table9, "And ");
#line 86
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
 testRunner.And("extract \'id\' from JSON body into \'groupid\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table10.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:schemas:core:2.0:Group\" ]"});
            table10.AddRow(new string[] {
                        "members",
                        "[ { \"value\": \"$firstuserid$\" }, { \"value\": \"$seconduserid$\" } ]"});
#line 88
 testRunner.And("execute HTTP PUT JSON request \'http://localhost/Groups/$groupid$\'", ((string)(null)), table10, "And ");
#line 92
 testRunner.And("execute HTTP GET request \'http://localhost/Groups/$groupid$\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 96
 testRunner.Then("JSON exists \'members[0].value\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 97
 testRunner.Then("JSON exists \'members[1].value\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                GroupsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                GroupsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
