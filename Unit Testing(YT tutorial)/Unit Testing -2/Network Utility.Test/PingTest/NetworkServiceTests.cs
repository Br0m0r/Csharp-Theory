using FluentAssertions;
using FluentAssertions.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Unit_Testing_2.Ping;

namespace Network_Utility.Test.PingTest
{
   
    public class NetworkServiceTests
    { 
       private readonly NetworkService _pingService;

       public NetworkServiceTests() 
       {
         //SUT 
         _pingService = new NetworkService();

       }
    
        [Fact]
        public void NetworkService_LastPingDate_ReturnDate()
        {
            //Arrange - variables,classes,mocks
           //var pingService = new NetworkService();   since we create a constructor(helps with calling globally)
           //we dont need to create this everytime

            //Act
            //var result = pingService.SendPing(); so this becomes :
            var result = _pingService.LastPingDate();

            //Assert
            result.Should().BeAfter(1.January(2010));
            result.Should().BeBefore(1.January(2030));
            

        }

        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2,2,4)]

        public void NetworkService_PingTimeOut_ReturnInt(int a,int b,int expected)
        {
            //Arrange
            var pingService = new NetworkService();

            //Act
            var result = pingService.PingTimeOut(a,b);

            //Assert
            result.Should().Be(expected);
            result.Should().BeGreaterThanOrEqualTo(2);
            result.Should().NotBeInRange(-10000, 0);

        }

        [Fact]
        public void NetworkService_MostRecentPings_ReturnsObjects()
        {
            //Arrange
            var expected = new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };
            //Act
            var result = _pingService.MostRecentPings();

            //Assert WARNING :"Be" as in the word "be" carefull
            result.Should().BeOfType<PingOptions[]>();
            result.Should().ContainEquivalentOf(expected);
            result.Should().Contain(x => x.DontFragment == true);


        }
    }
}
