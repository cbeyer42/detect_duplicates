using DetectDuplicates.Lib;
using DetectDuplicates.Lib.Contracts;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Remoting.Contexts;

namespace DetectDuplicates.Lib.Tests
{
    public class DuplicateDetectorTests
    {
        public string testRootDir { get; } = $"{TestContext.CurrentContext.TestDirectory}/TEST";

        [SetUp]
        public void Setup()
        {
            Directory.CreateDirectory($"{testRootDir}/emptyDirectory");
            
            Directory.CreateDirectory($"{testRootDir}/topLevel/secondLevel-1/thirdLevel-1");
            Directory.CreateDirectory($"{testRootDir}/topLevel/secondLevel-2/thirdLevel-1");
            Directory.CreateDirectory($"{testRootDir}/topLevel/secondLevel-2/thirdLevel-2");
            Directory.CreateDirectory($"{testRootDir}/topLevel/secondLevel-2/thirdLevel-3");
        }
        [TearDown]
        public void TearDown()
        {
            Directory.Delete(testRootDir, true );
        }

        [Test]
        public void CollectDuplicatesShouldReturnNoDuplicatesForEmptyDirectories()
        {
            var sut = new DuplicateDetector();
            var candidates = sut.CollectCandidates($"{testRootDir}/emptyDirectory");

            Assert.That(candidates, Is.Empty);
        }
    }
}