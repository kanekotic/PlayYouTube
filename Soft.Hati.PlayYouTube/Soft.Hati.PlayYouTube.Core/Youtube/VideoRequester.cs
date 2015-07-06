using System.Threading.Tasks;
using Google.Apis.YouTube.v3.Data;

namespace Soft.Hati.YouPlayVS.Core.Youtube
{
    public class VideoRequester
    {
        private readonly IYoutubeServiceContainer serviceContainer;

        public VideoRequester(IYoutubeServiceContainer serviceContainer)
        {
            this.serviceContainer = serviceContainer;
        }

        public async Task<YuotubeQueryResponse> Search(string query)
        {
            var searchListRequest = serviceContainer.Service.Search.List("snippet");
            searchListRequest.Q = query;
            searchListRequest.MaxResults = 50;

            return new YuotubeQueryResponse(await searchListRequest.ExecuteAsync());
        }
    }
}