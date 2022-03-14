using NUnit.Framework;
using Moq;
using LibraryManagementCrud.CrudOpeartion.LibraryMembers;
using LibraryManagementCrud.Models;
namespace LibraryMembersCRUD.UnitTests
{
    public class LibraryMemberUnitTesting
    {
        private LibraryMembers service;
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TC1_LibraryMemberInsert_IfSuccessfull_ReturnsLibraryMemberInsertSuccess()
        {
            service = new LibraryMembers()
            {
                MemberId = 1314,
                MemberName = "jay",
                MemberAddress = "Navsari school",
                MemberCity = "navsari",
                MemberPincode = 396445,
                MemberDate_Register="2012/04/12",
                MemberDate_Expire = "2012/04/12",
                Membership_Status="Temporary"

            };
            Mock<LibraryMemberOperation> insertClassObject = new Mock<LibraryMemberOperation>();
            var ExpectedOutput = insertClassObject.Setup(x => x.LibraryMemberInsert(service))
                .Returns("Library Member Insert Operation Success");
            Assert.That(ExpectedOutput.Equals("Library Member Insert Operation Success"));
        }
    }
}