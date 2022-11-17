using UnitTestConsole;

namespace TestKey
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        [DataRow(1, false,2, 3862.5)]
        [DataRow(2, false, 2, 5725)]
        [DataRow(2, true, 3, 6687.75)]
        [DataRow(3, true, 3, 8531.625)]
        public void TestMethodGetSalaryOfTeacher(double factor, bool union, int seniority, double s)
        {
            Teacher teacher = new Teacher();
            teacher.Factor = factor;
            teacher.UnionMember = union;
            teacher.Seniority = seniority;
            Assert.AreEqual(s, teacher.GetSalary());
        }


        [TestMethod]
        [DataRow(1, 1, 1, 11375.1)]
        [DataRow(1, 2, 2, 141550.2)]
        [DataRow(2, 3, 3, 151450.2)]
        [DataRow(2, 3, 1, 32650.2)]
        public void TestMethodGetSalaryOfResearcher(double factor, int NumberOfPaper, int paperRank, double s)
        {
            Researcher researcher = new Researcher();
            researcher.Factor = factor;
            researcher.NumOfPaper = NumberOfPaper;
            researcher.PaperRank = paperRank;
            Assert.AreEqual(s, researcher.GetSalary());
        }





    }
}