using System;
using System.IO;
using FusionAlliance.DotNetAdapters.Common.IO;
using NUnit.Framework;

namespace FusionAlliance.DotNetAdapters.Common.Tests.IO
{
    [TestFixture]
    public class FileSystemAdapterTests
    {
        private IFileSystem fileSystem;
        private string tempFolderRoot;

        [SetUp]
        public void Before_each_test()
        {
            tempFolderRoot = @"C:\DotNetAdapters-" + Guid.NewGuid().ToString("N");
            Directory.CreateDirectory(tempFolderRoot);

            fileSystem = new FileSystemAdapter();
        }

        [TearDown]
        public void After_each_test()
        {
            Directory.Delete(tempFolderRoot, true);
        }

        [Test]
        public void Combine_returns_expected_value()
        {
            var path = fileSystem.Combine(tempFolderRoot, "myfile.txt");
            var expected = tempFolderRoot + @"\myfile.txt";
            Assert.AreEqual(expected, path);
        }

        [Test]
        public void CreateDirectory_can_create_a_directory()
        {
            var path = Path.Combine(tempFolderRoot, "tempDir");
            fileSystem.CreateDirectory(path);
            Assert.IsTrue(Directory.Exists(path));
        }

        [Test]
        public void DeleteDirectory_can_delete_a_directory()
        {
            var path = Path.Combine(tempFolderRoot, "deleteMe");
            Directory.CreateDirectory(path);
            Assert.IsTrue(Directory.Exists(path));
            fileSystem.DeleteDirectory(path);
            Assert.IsFalse(Directory.Exists(path));
        }
    }
}
