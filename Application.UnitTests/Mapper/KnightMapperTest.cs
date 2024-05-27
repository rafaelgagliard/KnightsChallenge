using Application.ViewModel.Request;
using Domain.UnitTests.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Mapper;
using Domain.Entities;
using Application.ViewModel.Response;
using Application.UnitTests.Builders;

namespace Application.UnitTests.Mapper
{
    [TestFixture()]
    public class KnightMapperTest
    {
        [Test]
        public void ValidateRequestToKnight()
        {
            var knightRequest = KnightRequestBuilder.Build();
            var knight = KnightsBuilder.Build();

            Assert.That(knight, Is.EqualTo(knightRequest.RequestToKnight()));
        }

        [Test]
        public void ValidateKnightToResponse() {
            var knight = KnightsBuilder.Build();
            var knightResponse = KnightResponseBuilder.Build();

            Assert.That(knightResponse, Is.EqualTo(knight.KnightToResponse()));
        }

        [Test]
        public void ValidateKnightsToResponse()
        {
            var knight = new List<Knight> { KnightsBuilder.Build() };
            var knightResponse = new List<KnightResponse> { KnightResponseBuilder.Build() };

            Assert.That(knightResponse, Is.EqualTo(knight.KnightsToResponse()));
        }
    }
}
