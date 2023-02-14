using System;
using Xunit;
using Dziekanat.Services;

namespace DziekanatTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("student1", "student1",true)]
        [InlineData("student2", "student2",true)]
        [InlineData("student3", "student3",true)]
        [InlineData("student4", "student4",true)]
        [InlineData("student1", "student2",false)]
        public void Logowanie(string login,string password,bool correct)
        {
            SerwisPomocniczy _sut = new SerwisPomocniczy();
            var result = _sut.LoginUser(login, password);
            Console.WriteLine(result);
            Assert.Equal(correct, result);
        }


        [Theory]
        [InlineData(1, 5, true)]
        [InlineData(2, 2, false)]
        [InlineData(3, 4, true)]
        [InlineData(4, 3, false)]
        [InlineData(5, 1, true)]

        public void PrzedmiotZaliczony(int studentID,int id_przedmiotu,bool corrent)
        {
            SerwisPomocniczy _sut = new SerwisPomocniczy();
            var result = _sut.PrzedmiotZaliczony(studentID, id_przedmiotu);
            Console.WriteLine(result);
            Assert.Equal(corrent, result);
        }
    }
}
