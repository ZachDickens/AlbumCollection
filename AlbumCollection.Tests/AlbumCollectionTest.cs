using AlbumCollection.Controllers;
using AlbumCollection.Models;
using AlbumCollection.Repositories;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using System.Collections.Generic;
using Xunit;

namespace AlbumCollection.Tests
{
    public class AlbumCollectionTest
    {
        AlbumController underTest;
        IAlbumRepository repo;

        public AlbumCollectionTest()
        {
            this.repo = Substitute.For<IAlbumRepository>(); ;
            underTest = new AlbumController(repo);
        }
        [Fact]
        public void Index_Returns_View()
        {
                               
            var result = underTest.Index();
            
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Returns_View()
        {
            //Arrange

            //Act

            //Assert
        }

        [Fact]
        public void Index_Returns_Model()
        {
            var givenmodel = new List<Album>();
            repo.GetAll().Returns(givenmodel);
            var result = (List<Album>)underTest.Index().Model;
            Assert.Equal(givenmodel, result);
        }
    }
}
