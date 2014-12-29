namespace UnitTestProject
{
    using System;
    using System.Collections.Generic;
    using CsvReadWrite;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CsvReaderUnitTest
    {
        #region ' TEST 0xx

        [TestMethod]
        public void ReadRowTest001()
        {
            var expected = new List<string>()
            {
                "a", "b", "c", "d", "e"
            };

            var reader = new CsvReader(@"Data\ReadRowTest001.csv");
            
            var actual = reader.ReadRow();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReadRowTest002()
        {
            var expected = new List<string>()
            {
                "a", "b", "c", "d", "e"
            };

            var reader = new CsvReader(@"Data\ReadRowTest002.csv");

            var actual = reader.ReadRow();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReadRowTest003()
        {
            var expected = new List<List<string>>()
            {
                new List<string>() {"a", "b", "c", "d", "e"},
                new List<string>() {"f", "g", "h", "i", "j"}
            };

            var reader = new CsvReader(@"Data\ReadRowTest003.csv");

            var actual = reader.ReadToEnd();

            Assert.AreEqual(expected.Count, actual.Count);
            for (var i = 0; i < expected.Count; i++)
            {
                CollectionAssert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void ReadRowTest004()
        {
            var expected = new List<List<string>>()
            {
                new List<string>() {"a", "b", "c", "d", "e"},
                new List<string>() {"f", "g", "h", "i", "j"}
            };

            var reader = new CsvReader(@"Data\ReadRowTest004.csv");

            var actual = reader.ReadToEnd();

            Assert.AreEqual(expected.Count, actual.Count);
            for (var i = 0; i < expected.Count; i++)
            {
                CollectionAssert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void ReadRowTest005()
        {
            var expected = new List<List<string>>()
            {
                new List<string>() {"a", "b", "c", "d", "e"},
                new List<string>() {"f", "g", "h", "i", "j"},
                new List<string>() {"k", "l", "m", "n", "o"}
            };

            var reader = new CsvReader(@"Data\ReadRowTest005.csv");

            var actual = reader.ReadToEnd();

            Assert.AreEqual(expected.Count, actual.Count);
            for (var i = 0; i < expected.Count; i++)
            {
                CollectionAssert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void ReadRowTest006()
        {
            var expected = new List<List<string>>()
            {
                new List<string>() {"a", "b", "c", "d", "e"},
                new List<string>() {"f", "g", "h", "i", "j"},
                new List<string>() {"k", "l", "m", "n", "o"}
            };

            var reader = new CsvReader(@"Data\ReadRowTest006.csv");

            var actual = reader.ReadToEnd();

            Assert.AreEqual(expected.Count, actual.Count);
            for (var i = 0; i < expected.Count; i++)
            {
                CollectionAssert.AreEqual(expected[i], actual[i]);
            }
        }

        #endregion 
        #region ' TEST 1xx

        [TestMethod]
        public void ReadRowTest101()
        {
            var expected = new List<string>()
            {
                "a", "b", "c", "d", "e"
            };

            var reader = new CsvReader(@"Data\ReadRowTest101.csv");

            var actual = reader.ReadRow();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReadRowTest102()
        {
            var expected = new List<string>()
            {
                "a", "b", "c", "d", "e"
            };

            var reader = new CsvReader(@"Data\ReadRowTest102.csv");

            var actual = reader.ReadRow();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReadRowTest103()
        {
            var expected = new List<string>()
            {
                "a", "b", "c", "d", "e"
            };

            var reader = new CsvReader(@"Data\ReadRowTest103.csv");

            var actual = reader.ReadRow();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReadRowTest104()
        {
            var expected = new List<string>()
            {
                "a", "b", "c", "d", "e"
            };

            var reader = new CsvReader(@"Data\ReadRowTest104.csv");

            var actual = reader.ReadRow();

            CollectionAssert.AreEqual(expected, actual);
        }

        #endregion
        #region ' TEST 2xx

        [TestMethod]
        public void ReadRowTest201()
        {
            var expected = new List<string>()
            {
                "\r\nabc", "b\r\nef", "gh\r\ni", "jkl\r\n", "\r\nm\r\nn\r\no\r\n"
            };

            var reader = new CsvReader(@"Data\ReadRowTest201.csv");

            var actual = reader.ReadRow();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReadRowTest202()
        {
            var expected = new List<string>()
            {
                "\r\na\r\nb\r\nc\r\n", "bef", "ghi", "jkl", "mno"
            };

            var reader = new CsvReader(@"Data\ReadRowTest202.csv");

            var actual = reader.ReadRow();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReadRowTest203()
        {
            var expected = new List<string>()
            {
                "abc", "bef", "\r\ng\r\nh\r\ni\r\n", "jkl", "mno"
            };

            var reader = new CsvReader(@"Data\ReadRowTest203.csv");

            var actual = reader.ReadRow();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReadRowTest204()
        {
            var expected = new List<string>()
            {
                "abc", "bef", "ghi", "jkl", "\r\nm\r\nn\r\no\r\n"
            };

            var reader = new CsvReader(@"Data\ReadRowTest204.csv");

            var actual = reader.ReadRow();

            CollectionAssert.AreEqual(expected, actual);
        }
        
        #endregion
        #region ' TEST 3xx

        [TestMethod]
        public void ReadRowTest301()
        {
            var expected = new List<string>()
            {
                "\"a\"bc", "b\"e\"f", "gh\"i\"", "\"jk\"l", "\"mno\""
            };

            var reader = new CsvReader(@"Data\ReadRowTest301.csv");

            var actual = reader.ReadRow();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReadRowTest302()
        {
            var expected = new List<string>()
            {
                "\"a\"\"b\"\"c\"", "bef", "ghi", "jkl", "mno"
            };

            var reader = new CsvReader(@"Data\ReadRowTest302.csv");

            var actual = reader.ReadRow();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReadRowTest303()
        {
            var expected = new List<string>()
            {
                "abc", "bef", "\"g\"hi", "jkl", "mno"
            };

            var reader = new CsvReader(@"Data\ReadRowTest303.csv");

            var actual = reader.ReadRow();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReadRowTest304()
        {
            var expected = new List<string>()
            {
                "abc", "bef", "ghi", "jkl", "mn\"o\""
            };

            var reader = new CsvReader(@"Data\ReadRowTest304.csv");

            var actual = reader.ReadRow();

            CollectionAssert.AreEqual(expected, actual);
        }


        #endregion
        #region ' TEST 4xx

        [TestMethod]
        public void ReadRowTest401()
        {
            var expected = new List<string>()
            {
                ",abc", "d,ef", "gh,i", "jkl,", ",m,n,o,"
            };

            var reader = new CsvReader(@"Data\ReadRowTest401.csv");

            var actual = reader.ReadRow();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReadRowTest402()
        {
            var expected = new List<string>()
            {
                ",a,b,c,", "def", "ghi", "jkl", "mno"
            };

            var reader = new CsvReader(@"Data\ReadRowTest402.csv");

            var actual = reader.ReadRow();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReadRowTest403()
        {
            var expected = new List<string>()
            {
                "abc", "def", ",g,h,i,", "jkl", "mno"
            };

            var reader = new CsvReader(@"Data\ReadRowTest403.csv");

            var actual = reader.ReadRow();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReadRowTest404()
        {
            var expected = new List<string>()
            {
                "abc", "def", "ghi", "jkl", ",m,n,o,"
            };

            var reader = new CsvReader(@"Data\ReadRowTest404.csv");

            var actual = reader.ReadRow();

            CollectionAssert.AreEqual(expected, actual);
        }

        #endregion
        #region ' TEST 5xx

        [TestMethod]
        public void ReadRowTest501()
        {
            var expected = new List<string>()
            {
                "\r\n\",abc", "d\r\n,\"ef", "gh\r\n,\"i", "jkl\r\n,\"", "\r\nm,n\"o\r\n,\""
            };

            var reader = new CsvReader(@"Data\ReadRowTest501.csv");

            var actual = reader.ReadRow();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReadRowTest502()
        {
            var expected = new List<string>()
            {
                "\r\n,\",\r\n", "def", "ghi", "jkl", "mno"
            };

            var reader = new CsvReader(@"Data\ReadRowTest502.csv");

            var actual = reader.ReadRow();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReadRowTest503()
        {
            var expected = new List<string>()
            {
                "abc", "def", "\r\n,\",\r\n", "jkl", "mno"
            };

            var reader = new CsvReader(@"Data\ReadRowTest503.csv");

            var actual = reader.ReadRow();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReadRowTest504()
        {
            var expected = new List<string>()
            {
                "abc", "def", "ghi", "jkl", "\r\n,\",\r\n"
            };

            var reader = new CsvReader(@"Data\ReadRowTest504.csv");

            var actual = reader.ReadRow();

            CollectionAssert.AreEqual(expected, actual);
        }

        #endregion
    }
}
