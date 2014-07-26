using System;
using System.IO;
using FusionAlliance.DotNetAdapters.Common.IO;
using NUnit.Framework;

namespace FusionAlliance.DotNetAdapters.Common.Tests.IO
{
    [TestFixture]
    public class FileSystemAdapterTests
    {
        [SetUp]
        public void Before_each_test()
        {
            _tempFolderRoot = @"C:\DotNetAdapters-" + Guid.NewGuid().ToString("N");
            Directory.CreateDirectory(_tempFolderRoot);

            _fileSystem = new FileSystemAdapter();
        }

        [TearDown]
        public void After_each_test()
        {
            Directory.Delete(_tempFolderRoot, true);
        }

        private IFileSystem _fileSystem;
        private string _tempFolderRoot;

        [Test]
        public void Combine_returns_expected_value()
        {
            var path = _fileSystem.Combine(_tempFolderRoot, "myfile.txt");
            var expected = _tempFolderRoot + @"\myfile.txt";
            Assert.AreEqual(expected, path);
        }

        [Test]
        public void CreateDirectory_can_create_a_directory()
        {
            var path = Path.Combine(_tempFolderRoot, "tempDir");
            _fileSystem.CreateDirectory(path);
            Assert.IsTrue(Directory.Exists(path));
        }

        [Test]
        public void DeleteDirectory_can_delete_a_directory()
        {
            var path = Path.Combine(_tempFolderRoot, "deleteMe");
            Directory.CreateDirectory(path);
            Assert.IsTrue(Directory.Exists(path));
            _fileSystem.DeleteDirectory(path);
            Assert.IsFalse(Directory.Exists(path));
        }
    }
}