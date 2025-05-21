
using Reqnroll;

namespace Test.Integrations {
    public class MyFixtureTestClass : IAsyncLifetime {
        public MyFixtureTestClass() {
            Console.WriteLine($"init is called");
        }
        public Task DisposeAsync() {
            return Task.CompletedTask;
        }

        public Task InitializeAsync() {
            return Task.CompletedTask;

        }
    }

    [Binding]
    [Scope(Tag = "TestingAsyncSetup")]
    public class TestSteps : IClassFixture<MyFixtureTestClass> {
        public TestSteps(MyFixtureTestClass fixture) {
                    
        }

        [Given("the test is executed")]
        public void DoSomeTest() {
            Console.WriteLine($"{nameof(DoSomeTest)} is called");
        }
    }
}
