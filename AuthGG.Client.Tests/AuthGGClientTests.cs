using Xunit;
using System;
using System.Collections.Generic;
using System.Text;
using tcortega.AuthGG.Client.Exceptions;

namespace tcortega.AuthGGClient.Tests
{
    public class AuthGGClientTests
    {
        [Fact]
        public void Create_ShouldThrowInvalidAuthDataException()
        {
            Assert.Throws<InvalidAuthDataException>(() => AuthGGClient.Create("", "", ""));
        }

        [Fact]
        public void Create_ShouldBeAbleToReturnNewInstance()
        {
            Assert.IsType<AuthGGClient>(AuthGGClient.Create("1231", "123213", "BCE2bsUXQ5D33aBeIqMe523JTgV3dxPexQU"));
        }
    }
}