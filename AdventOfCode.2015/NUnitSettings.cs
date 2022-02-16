using NUnit.Framework;
[assembly: Parallelizable(ParallelScope.Fixtures)]
[assembly: FixtureLifeCycle(LifeCycle.InstancePerTestCase)]